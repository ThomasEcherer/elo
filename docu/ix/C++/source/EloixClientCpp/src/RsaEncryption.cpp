/////////////////////////////////////////////////////////////////////////////
//
// This file is a part of the ELO IndexServer product.
// (c) ELO Digital Office GmbH, All Rights Reserved.
//
// THIS SOURCE CODE CAN ONLY BE USED UNDER THE TERMS AND CONDITIONS OUTLINED
// IN FILE ReadMe.txt. 
// 
/////////////////////////////////////////////////////////////////////////////
#include "stdafx.h"
#include "RsaEncryption.h"
#include "Base64Coder.h"

#pragma warning (disable : 4786)
#pragma warning( disable : 4996 ) // wcsicmp deprecated
#pragma warning( disable : 4995 ) // wcsicmp deprecated

RsaEncryption::RsaEncryption() {
  m_hProv = NULL;
  m_hSessionKey = NULL;
  m_dwBlockLen = 0;
}

DWORD RsaEncryption::EnsureCryptContext() {

  if (m_hProv != NULL) return 0;

  DWORD dwResult = 0;

  if (!CryptAcquireContext(&m_hProv, NULL, MS_DEF_PROV, PROV_RSA_FULL, 0)){
		dwResult = GetLastError();
		
    if (dwResult == NTE_BAD_KEYSET){
      dwResult = 0;
			if (!CryptAcquireContext(&m_hProv, NULL, MS_DEF_PROV, PROV_RSA_FULL, CRYPT_NEWKEYSET)){
				dwResult = GetLastError();
			}
		}
	}

  return dwResult;
}

static void reverseBuffer(BYTE* pbBuf, DWORD cbBuf) {
  for (DWORD i = 0; i < (cbBuf / 2); i++) {
    DWORD k = cbBuf-i-1;
    BYTE b = pbBuf[i];
    pbBuf[i] = pbBuf[k];
    pbBuf[k] = b;
  }
}

static void decodeBase64(const LPCSTR s, BYTE** ppbMod, DWORD *cbMod) {
  Base64Coder base64;
  base64.Decode(s);
  *cbMod = base64.GetDecodedMessageLength();
  *ppbMod = new BYTE[*cbMod];
  memcpy(*ppbMod, base64.DecodedMessage(), *cbMod);
}

static LPSTR encodeBase64(BYTE* pbBuf, DWORD cb) {
  Base64Coder base64;
  base64.Encode(pbBuf, cb);
  int n = (int)base64.GetEncodedMessageLength();
  LPSTR s = new CHAR[n+1];
  strncpy(s, base64.EncodedMessage(), n);
  s[n] = 0;
  return s;
}

static DWORD getModAndExp(const LPCSTR szKey, LPSTR* pszMod, LPSTR* pszExp) {
  *pszMod = *pszExp = NULL;
  if (szKey == NULL) return ERROR_INVALID_PARAMETER;

  LPCSTR p = strchr(szKey, ' ');
  if (p == NULL) return ERROR_INVALID_PARAMETER;

  int i = (int)(p - szKey);
  int n = (int)strlen(szKey);
  *pszMod = new CHAR[n+1];
  *pszExp = new CHAR[n+1];
  strncpy(*pszMod, szKey, i); (*pszMod)[i] = 0;
  strncpy(*pszExp, szKey + i + 1, n - i - 1); (*pszExp)[n-i-1] = 0;

  return ERROR_SUCCESS;
}

static DWORD getModAndExpBin(const LPCSTR szKey,  
                            BYTE** ppbMod, DWORD *pcbMod, 
                            BYTE** ppbExp, DWORD *pcbExp) {

  DWORD ret = ERROR_SUCCESS;

  LPSTR szMod = NULL, szExp = NULL;
  ret = getModAndExp(szKey, &szMod, &szExp);
  if (ret) return ret;
  
  *ppbMod = NULL;
  *pcbMod = 0;
  decodeBase64(szMod, ppbMod, pcbMod);
  reverseBuffer(*ppbMod, *pcbMod);
  if ((*ppbMod)[(*pcbMod)-1] == 0) (*pcbMod) -= 1;
  
  *ppbExp = NULL;
  *pcbExp = 0;
  decodeBase64(szExp, ppbExp, pcbExp);
  reverseBuffer(*ppbExp, *pcbExp);

  delete[] szMod;
  delete[] szExp;

  return ret;
}

void RsaEncryption::MakeKeyBlobBin(BYTE* pbMod, DWORD cbMod, 
                           BYTE* pbExp, DWORD cbExp, 
                           BYTE** ppbBlob, DWORD* pcbBlob) {

  *pcbBlob = sizeof(PUBLICKEYSTRUC) + sizeof(RSAPUBKEY) + cbMod;
  BYTE* pBlob = *ppbBlob = new BYTE[*pcbBlob];
  ZeroMemory(pBlob, *pcbBlob);
  
  PUBLICKEYSTRUC* pPubKeyStruc = (PUBLICKEYSTRUC*)pBlob;
  pPubKeyStruc->bType = PUBLICKEYBLOB;
  pPubKeyStruc->bVersion = CUR_BLOB_VERSION;
  pPubKeyStruc->aiKeyAlg = CALG_RSA_KEYX;

  RSAPUBKEY* pRsaPubKey = (RSAPUBKEY*)(pBlob + sizeof(PUBLICKEYSTRUC));
  pRsaPubKey->magic = (0x31415352); //Set to RSA1 (0x31415352) for public keys and to RSA2 (0x32415352) for private keys.
  pRsaPubKey->bitlen = cbMod * 8; // keylen
  for (DWORD i = 0; i < cbExp; i++) {
    pRsaPubKey->pubexp <<= 8;
    pRsaPubKey->pubexp |= pbExp[i];
  }
  
  BYTE* pbModBlob = (pBlob + sizeof(PUBLICKEYSTRUC) + sizeof(RSAPUBKEY));
  memcpy(pbModBlob, pbMod, cbMod);
}

DWORD RsaEncryption::MakeKeyBlob(LPCSTR szKey, BYTE** ppbBlob, DWORD* pcbBlob) {
  
  BYTE* pbMod = NULL;
  DWORD cbMod = 0;
  BYTE* pbExp = NULL;
  DWORD cbExp = 0;
  DWORD ret = getModAndExpBin(szKey, &pbMod, &cbMod, &pbExp, &cbExp);
  if (ret) return ret;

  MakeKeyBlobBin(pbMod, cbMod, pbExp, cbExp, ppbBlob, pcbBlob);

  delete[] pbMod;
  delete[] pbExp;

  return ERROR_SUCCESS;
}

LPSTR RsaEncryption::Encrypt(LPCSTR sz) {

  DWORD ret = ERROR_SUCCESS;
  BYTE *pbBuf = NULL;
  DWORD cbBuf = 0;
  DWORD cbBufSize = 0;
  LPSTR szEncrBase64 = NULL;

  cbBuf = (DWORD)strlen(sz);
  cbBufSize = ((cbBuf / m_dwBlockLen) + 1) * m_dwBlockLen;
  pbBuf = new BYTE[cbBufSize];
  ZeroMemory(pbBuf, cbBufSize);
  memcpy(pbBuf, sz, cbBuf);

	if (!CryptEncrypt(m_hSessionKey, NULL, TRUE, 0, pbBuf, &cbBuf, cbBufSize))
	{
		ret = GetLastError();
    NTE_BAD_ALGID;
    goto leave;
	}

  reverseBuffer(pbBuf, cbBuf);

  szEncrBase64 = encodeBase64(pbBuf, cbBuf);

leave:
  if (pbBuf) delete[] pbBuf;

  SetLastError(ret);

  return szEncrBase64;
}


BOOL RsaEncryption::SetPublicKey(LPCSTR szKey) {
  
  DWORD ret = ERROR_SUCCESS;
  BYTE* pbKeyBlob = NULL;
  DWORD cbKeyBlob = 0;
  
  ret = EnsureCryptContext();
  if (ret) goto leave;

  ret = MakeKeyBlob(szKey, &pbKeyBlob, &cbKeyBlob);
  if (ret) goto leave;

	if (!CryptImportKey(m_hProv, pbKeyBlob, cbKeyBlob, NULL, 0, &m_hSessionKey))
	{
		ret = GetLastError();
    goto leave;
	}

  DWORD cbData = sizeof(m_dwBlockLen);
  if (!CryptGetKeyParam(m_hSessionKey, KP_BLOCKLEN, (PBYTE)&m_dwBlockLen, &cbData, 0)) {
	  ret = GetLastError();
    goto leave;
  }

leave:
  if (pbKeyBlob) delete[] pbKeyBlob;

  SetLastError(ret);

  return ret == ERROR_SUCCESS;
}


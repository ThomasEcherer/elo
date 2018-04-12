/////////////////////////////////////////////////////////////////////////////
//
// This file is a part of the ELO IndexServer product.
// (c) ELO Digital Office GmbH, All Rights Reserved.
//
// THIS SOURCE CODE CAN ONLY BE USED UNDER THE TERMS AND CONDITIONS OUTLINED
// IN FILE ReadMe.txt. 
// 
/////////////////////////////////////////////////////////////////////////////
#ifndef __RSA__ENCRYPT__

#include <wincrypt.h>

class RsaEncryption {

  HCRYPTPROV m_hProv;
	HCRYPTKEY m_hSessionKey;
  DWORD m_dwBlockLen;
  
public:
  RsaEncryption();

  ////////////////////////////////////////
  // Public Key zuweisen.
  // szKey besteht aus "<modulo> <exponent>". <modulo> und <exponent> sind 
  // Base64 codiert.
  // return Erfolg: TRUE, Fehler: FALSE - GetLastError() liefert Fehlercode
  //
  BOOL SetPublicKey(LPCSTR szKey);

  ////////////////////////////////////////
  // Verschlüsselt übergebenen char-string.
  // Die Verschlüsselte Nachricht wird umgekehrt, damit sie mit 
  // dem RSA-Verfahren der Java VM entschlüsselt werden kann.
  // return Erfolg: Base64-codierter String, mit delete[] freigeben.
  //        Fehler: NULL - GetLastError() liefert Fehlercode
  // 
  LPSTR Encrypt(LPCSTR sz);

protected:
  DWORD EnsureCryptContext();
  void MakeKeyBlobBin(BYTE* pbMod, DWORD cbMod, 
                      BYTE* pbExp, DWORD cbExp, 
                      BYTE** ppbBlob, DWORD* pcbBlob);

  DWORD MakeKeyBlob(LPCSTR szKey, BYTE** ppbBlob, DWORD* pcbBlob);
};

#endif

#pragma once
#include "IXAPI.h"
//***************************************************************************************************************************************************************************
namespace de { namespace elo { namespace ix { namespace client { 
using namespace std;
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
class IXClientMaskLine
{
public:
   int            m_okeyno;
   wstring        m_key;
   wstring        m_label;

                  IXClientMaskLine(int okeyno, LPCTSTR key, LPCTSTR label);
};
typedef std::vector<IXClientMaskLine*> VEC_MASKLINES;
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
class IXClientMask
{
public:
   int            m_maskno;
   wstring        m_name;
   bool           m_structmask;
   bool           m_docmask;
   bool           m_searchmask;
   int            m_encryption_set;
   int            m_arcpath;

   VEC_MASKLINES  m_lines;

                  IXClientMask(int maskno, LPCTSTR name, bool for_struct, bool for_doc, bool for_search, int encryption_set, int arcpath);
                 ~IXClientMask();

   void           DestroyLines();
   void           AddLine(int okeyno, LPCTSTR key, LPCTSTR label);
};
typedef std::vector<IXClientMask*>      VEC_MASKS;
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
class IXClientMaskCache
{
private:
   //TReportFile*   m_rpt;

public:
  VEC_MASKS       m_masks;

                  IXClientMaskCache(/*TReportFile* rpt*/);
                 ~IXClientMaskCache();

  void            DestroyMasks();
  UINT            CountMasks();
  UINT            GetAllMasks();
  IXClientMask*   AddMask(int maskno, LPCTSTR name, bool for_struct, bool for_doc, bool for_search, int encryption_set, int arcpath);
  IXClientMask*   GetMask(UINT vec_pos);
  UINT            GetAllMasks(PIXConnection ix);
};
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
} } } }
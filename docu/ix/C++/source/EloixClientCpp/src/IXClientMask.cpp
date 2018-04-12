#include "StdAfx.h"
#include "IXClientMask.h"
namespace de { namespace elo { namespace ix { namespace client { 
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
IXClientMaskLine::IXClientMaskLine(int okeyno, LPCTSTR key, LPCTSTR label)
{
   m_okeyno =  okeyno;
   m_key    =  key;
   m_label  =  label;
}
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
IXClientMask::IXClientMask(int maskno, LPCTSTR name, bool for_struct, bool for_doc, bool for_search, int encryption_set, int arcpath)
{
   m_maskno          =  maskno;
   m_name            =  name;
   m_structmask      =  for_struct;
   m_docmask         =  for_doc;
   m_searchmask      =  for_search;
   m_encryption_set  =  encryption_set;
   m_arcpath         =  arcpath;
   m_lines.clear();
}
IXClientMask::~IXClientMask()
{
   DestroyLines();
}
//***************************************************************************************************************************************************************************
void IXClientMask::DestroyLines()
{
   for(UINT i=0; i<m_lines.size(); i++){
      delete m_lines[i];
   }
   m_lines.clear();
}
//***************************************************************************************************************************************************************************
void IXClientMask::AddLine(int okeyno, LPCTSTR key, LPCTSTR label)
{
   IXClientMaskLine* line  =  new IXClientMaskLine(okeyno, key, label);
   m_lines.push_back(line);
}
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
IXClientMaskCache::IXClientMaskCache(/*TReportFile* rpt*/)
{
   //m_rpt =  rpt;
}
IXClientMaskCache::~IXClientMaskCache()
{
   DestroyMasks();
}
//***************************************************************************************************************************************************************************
void IXClientMaskCache::DestroyMasks()
{
  for(UINT i=0; i<m_masks.size(); i++){
     delete m_masks[i];
  }
  m_masks.clear();
}
//***************************************************************************************************************************************************************************
UINT IXClientMaskCache::CountMasks()
{
   return   (UINT)m_masks.size();
}
//***************************************************************************************************************************************************************************
IXClientMask* IXClientMaskCache::AddMask(int maskno, LPCTSTR name, bool for_struct, bool for_doc, bool for_search, int encryption_set, int arcpath)
{
   IXClientMask*  retval   =  new IXClientMask(maskno, name, for_struct, for_doc, for_search, encryption_set, arcpath);
   m_masks.push_back(retval);
   return   retval;
}
//***************************************************************************************************************************************************************************
IXClientMask* IXClientMaskCache::GetMask(UINT vec_pos)
{
   IXClientMask*  retval   =  NULL;
   if (vec_pos < m_masks.size()){
      retval   =  m_masks[vec_pos];
   }
   return  retval;
}
//***************************************************************************************************************************************************************************
UINT IXClientMaskCache::GetAllMasks(PIXConnection ix)
{
   //TReportBlock   RB(m_rpt, _T("IXClientMaskCache::GetAllMasks"), 3);
   UINT  retval   =  0;
   if (ix != NULL){
      DestroyMasks();
      try{
         PSordZ                           sordZ(new   SordZ(SordC::mbId));
         PEditInfoZ                       editMaskZ(new   EditInfoZ(EditInfoC::mbMaskNames, sordZ));
         byps_ptr< BArray1< PMaskName > > arr_mname   =  ix->ix()->checkoutSord(L"1", editMaskZ, LockC::NO)->getMaskNames();
         
         for(size_t i=0; i<arr_mname->length(); i++){
            PMaskName         mname    =  arr_mname->at(i);
            PDocMask          dmask    =  ix->ix()->checkoutDocMask(mname->getName(), DocMaskC::mbAll, LockC::NO); 
            IXClientMask*     mask     =  AddMask(mname->getId(), mname->getName().c_str(), mname->getFolderMask(), mname->getDocumentMask(), mname->getSearchMask(), dmask->getDetails()->getEncryptionSet(), dmask->getDPath());
             
            PDocMaskZ         maskZ(new DocMaskZ(DocMaskC::mbAllMembers));  
            byps_ptr< BArray1< PDocMaskLine > > mlines   =  ix->ix()->checkoutDocMask(mname->getName(), maskZ, LockC::NO)->getLines();

            for(size_t j=0; j<mlines->length(); j++){
               mask->AddLine(mlines->at(j)->getId(), mlines->at(j)->getKey().c_str(), mlines->at(j)->getName().c_str());
            }
            retval++;
         }

         return   retval;
      }
      catch(exception&){      
         //RB.Ok(_T("xcpt (%s)"), xcpt->msg.c_str());
      }
   }
   return   retval;
}
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
} } } }
#include "StdAfx.h"
#include "IXClientPathInfo.h"

namespace de { namespace elo { namespace ix { namespace client { 
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
IXClientPathInfo::IXClientPathInfo()
{
   m_id  =  m_flags = m_scatter  =  0;
   m_std =  false;
}
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
bool IXClientPathInfo::IsMD5()
{
   if (m_scatter == StoreInfoC::SP_MD5_HASH){
      return   true;
   }
   return false;
}
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
} } } }
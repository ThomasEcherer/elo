#pragma once
#include <vector>
#include "IXAPI.h"
//***************************************************************************************************************************************************************************
namespace de { namespace elo { namespace ix { namespace client { 
using namespace std;
//***************************************************************************************************************************************************************************
class IXClientPathInfo
{
public:
   int      m_id;
   wstring  m_name;
   wstring  m_dir;
   int      m_flags;
   int      m_scatter;
   wstring  m_create_date;
   wstring  m_update_date;
   bool     m_std;

            IXClientPathInfo();

   bool     IsMD5();
};
typedef std::vector<IXClientPathInfo*> VEC_PATHINFO;
//***************************************************************************************************************************************************************************
//***************************************************************************************************************************************************************************
} } } }
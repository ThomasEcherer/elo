#include "StdAfx.h"
#include "IXProperties.h"

using namespace std;

namespace de { namespace elo { namespace ix { namespace client { 

IXProperties::IXProperties(void)
{
}

IXProperties::IXProperties(PIXProperties defaultProps)
{
  this->defaultProps = defaultProps;
}

IXProperties::~IXProperties(void)
{
}

wstring IXProperties::getProperty(const wstring& key) {
  return getProperty(key, L"");
}

wstring IXProperties::getProperty(const wstring& key, const wstring& defaultValue) {
  wstring v;
  MAP::iterator it = mymap.find(key);
  if (it != mymap.end() ){
    v = (*it).second;
  }
  if (v.size() == 0) {
    if (defaultProps != NULL) {
      v = defaultProps->getProperty(key);
    }
    if (v.size() == 0) {
      v = defaultValue;
    }
  }
  return v;
}
void IXProperties::setProperty(const wstring& key, const wstring& val) {
  mymap[key] = val;
}

IXProperties::MAP& IXProperties::map() {
  return mymap;
}

void IXProperties::putAll(PIXProperties props) {
  IXProperties::MAP& pmap = props->map();
  for (IXProperties::MAP::iterator it = pmap.begin(); it != pmap.end(); it++) {
    mymap.insert(IXProperties::MAP::value_type((*it).first, (*it).second));
  }
}

void IXProperties::read(PBytes bytes) {
  string str((char*)bytes->data, bytes->length);
  wstring wstr = fromUtf8(str);
  size_t lineIdx = 0, lineIdx2 = 0;
  do {
    lineIdx = wstr.find_first_of(L"\r\n", lineIdx2);
    if (lineIdx == wstring::npos) lineIdx = wstr.length();
    if (lineIdx != lineIdx2) {
      wstring line = wstr.substr(lineIdx2, lineIdx-lineIdx2);
      addKeyValue(line);
    }
    lineIdx2 = lineIdx+1;
  }
  while(lineIdx2 < wstr.size());
}


void IXProperties::addKeyValue(const wstring& keyEqValue) {
  size_t i = keyEqValue.find(L'=');
  wstring key, value;
  if (i != wstring::npos) {
    key = keyEqValue.substr(0, i);
    value = keyEqValue.substr(i+1);
  }
  setProperty(key, value);
}




}}}}
#pragma once

#include "Byps.h"
#include <map>
#include <string>

namespace de { namespace elo { namespace ix { namespace client { 

using namespace byps;

class IXProperties;
typedef byps_ptr<IXProperties> PIXProperties;

class IXProperties 
{
public:
  typedef std::map< std::wstring, std::wstring >  MAP;
protected:
  MAP mymap;
  PIXProperties defaultProps;
public:
  IXProperties(void);
  IXProperties(PIXProperties defaultProps);
  virtual ~IXProperties(void);
  virtual std::wstring getProperty(const std::wstring& key);
  virtual std::wstring getProperty(const std::wstring& key, const std::wstring& defaultValue);
  virtual void setProperty(const std::wstring& key, const std::wstring& val);
  virtual MAP& map();
  virtual void putAll(PIXProperties props);
  virtual void read(PBytes bytes);
private:
  void addKeyValue(const std::wstring& keyEqValue);
};


}}}}
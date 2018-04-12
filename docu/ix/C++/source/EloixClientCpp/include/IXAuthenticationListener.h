#pragma once

#include "IXAPI.h"

namespace de { namespace elo { namespace ix { namespace client { 

using namespace std;
using namespace byps;

class IXAuthenticationListener;
typedef byps_ptr<IXAuthenticationListener> PIXAuthenticationListener;

class IXAuthenticationListener : public BAsyncResultT<PClient>
{
public:
	IXAuthenticationListener(void);
	virtual ~IXAuthenticationListener(void);
	virtual void setAsyncResult(const PClient& result, BException ex) = 0;
};

}}}}
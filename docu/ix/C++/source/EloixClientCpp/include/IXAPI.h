#ifndef IXAPI_H_
#define IXAPI_H_

#include "Byps.h"
#include "Bypshttp.h"

namespace de { namespace elo { namespace ix { namespace client { 

class IXAuthentication;
class IXAuthenticationListener;
class IXConnection;
class IXConnFactory;
class IXProperties;
class EventBusApi;
class IXEventBusHandler;

// How to export template classes
// Aber dann muss ich für DLL und EXE dieselbe MSVCRT Version nehmen.
// http://support.microsoft.com/default.aspx?scid=KB;EN-US;168958

//EXPIMP_TEMPLATE template class ELOIXCLIENTCPP_API byps_ptr<IXProperties>;


typedef byps_ptr<IXAuthentication> PIXAuthentication;
typedef byps_ptr<IXAuthenticationListener> PIXAuthenticationListener;
typedef byps_ptr<IXConnection> PIXConnection;
typedef byps_ptr<IXConnFactory> PIXConnFactory;
typedef byps_ptr<IXProperties> PIXProperties;
typedef byps_ptr<EventBusApi> PEventBusApi;
typedef byps_ptr<IXEventBusHandler> PIXEventBusHandler;

}}}}

#undef ERROR 

#include "Indexserver-api.h"

#include "IXConnFactory.h"
#include "IXAuthentication.h"
#include "IXAuthenticationListener.h"
#include "IXProperties.h"
#include "IXConnection.h"
#include "EventBusApi.h"

#endif
#include "StdAfx.h"
#include "EventBusApi.h"

namespace de { namespace elo { namespace ix { namespace client { 

using namespace byps;
using namespace byps::http;
using namespace std;

class BusImpl;
typedef byps_ptr<BusImpl> PBusImpl;

class EventBusApiImpl : public EventBusApi, public byps_enable_shared_from_this<EventBusApiImpl> {

  byps_atomic<int64_t> subsId;
  byps_weak_ptr<BClient_Indexserver> bclientWeakPtr;
  byps_weak_ptr<IXConnection> connWeakPtr;

  byps_mutex mutex;
  unordered_map<int64_t, PBusImpl> busses;

public:

  EventBusApiImpl(PIXConnection conn, PClient_Indexserver bclient) 
    : connWeakPtr(conn), bclientWeakPtr(bclient), subsId(0) {
  }

  PIXConnection conn() {
    PIXConnection v = connWeakPtr.lock();
    if (!v) throw BException(BExceptionC::INTERNAL, L"Already disconnected");
    return v;
  }

  PClient_Indexserver bclient() {
    PClient_Indexserver v = bclientWeakPtr.lock();
    if (!v) throw BException(BExceptionC::INTERNAL, L"Already disconnected");
    return v;
  }

  /**
   * Returns the internally used subscriber ID.
   * @return subscriber ID
   */
	int64_t getSubscriberId() {
    ensureSubscriber();
    return subsId;
  }

  void ensureSubscriber() {
    int64_t zero = 0;
    if (!subsId.compare_exchange_strong(zero, 0)) return;

    PIXConnection conn = connWeakPtr.lock();
    if (!conn) return;

    int64_t subsId2 = conn->ix()->createEventBusSubscriber();
    l_debug << L"subsId=" << subsId2;

    if (subsId.compare_exchange_strong(zero, subsId2)) {

      int64_t lsnId = getUserBus(conn->getUserId())->addListener(EventBusC::EVENT_TYPE_OPEN_CHAT);
      l_debug << L"listener for EVENT_TYPE_OPEN_CHAT, lsnId=" << lsnId;
    }
  }

  /**
   * Adds the event handler.
   * @param evh Event handler
   */
	virtual void addHandler(PIXEventBusHandler handler);
	virtual void addHandler(PSkeleton_IXEventBusHandler handler);

  /**
   * Remove the given handler.
   * @param evh Event handler
   * @deprecated
   */
	virtual void removeHandler(PIXEventBusHandler ) {
  }
	virtual void removeHandler(PSkeleton_IXEventBusHandler handler) {
  }

  /**
   * Wird von IXConnection aufgerufen, wenn ein relogin erfolgt.
   * Es muss dann die subscriber ID erneuert werden.
   */
  virtual void onReLogin() {
    log.info() << L"onReLogin(";
    PIXConnection conn = connWeakPtr.lock();
    if (!conn) return;

    try {
      int64_t subsId = 0;

      if (log.isInfoEnabled()) log.info() << L"ticket=" << conn->getLoginResult()->getClientInfo()->getTicket();
      subsId = conn->ix()->createEventBusSubscriber();
      if (log.isInfoEnabled()) log.info() << L"subsId=" << subsId;

      this->subsId = subsId;

      renewAllEventListenersAfterRelogin();
    }
    catch (BException& ex) {
      throw ex;
    }
    log.info() << L")onReLogin";
  }

  void renewAllEventListenersAfterRelogin();

	/**
	* This function opens an event bus for the given channel ID.
	* @param channelId Either an arbitary ID used to create most likely uniqe bus ID. 
	* Or null, to create a random bus ID.
	* @return Bus object.
	*/
	virtual PBus openEventBusChannel(const std::wstring& channelId) {
    return openEventBusChannel(channelId, false);
  }

  /**
   * This function opens an event bus for the given channel ID.
   * @param channelId Either an arbitary ID used to create most likely uniqe bus ID. 
   * Or null, to create a random bus ID.
   * @param noForwardToOtherIxs Set this parameter as true, if the messages sent on this 
   * bus should not be forwarded to other Indexserver instances. A value of true makes sense, 
   * if no other client applications are interested in messages on this bus. 
   * @return Bus object.
   */
	virtual PBus openEventBusChannel(const std::wstring& channelId, bool noForwardToOtherIxs) {
    PIXConnection conn = connWeakPtr.lock();
    if (!conn) throw BException(BExceptionC::INTERNAL, L"Already disconnected");

    PEventBusParams p(new EventBusParams());
    p->setChannelId(channelId);
    p->setNoForwardToOtherIxs(noForwardToOtherIxs);
    int64_t busId = conn->ix()->openEventBus(p);
    return getEventBus(busId);
  }

	/**
	* Returns a <code>Bus</code> object for the given bus ID.
	* @param busId Event bus ID.
	* @return Bus object.
	* @see Bus#close()
	*/
	virtual PBus getEventBus(int64_t busId);
  
	/**
	* Returns a <code>Bus</code> object for the broadcast bus.
	* @return Bus object.
	*/
	virtual PBus getBroadcastBus() {
    return getEventBus(EventBusC::BUSID_BROADCAST);
  }
  
	/**
	* Returns a <code>Bus</code> object for an user bus.
	* @param userId User ID.
	* @return Bus object.
	*/
	virtual PBus getUserBus(int32_t userId) {
    return getEventBus(EventBusC::BUSID_USER + userId);
  }

  void releaseBus(int64_t busId) {
    byps_unique_lock lock(mutex);
    auto it = busses.find(busId);
    if (it != busses.end()) {
      busses.erase(it);
    }
  }

  static BLogger log;
};

/**
* This class encapsulates the functions for sending events and listening for events.
* Objects of this class are thread safe.
*/
class BusImpl : public EventBusApi::Bus, public byps_enable_shared_from_this<BusImpl> {
  byps_weak_ptr<EventBusApiImpl> parentWeakPtr;
  int64_t busId;

  byps_mutex mutex;
  unordered_map<int64_t, PEventListener> eventListeners;

  static BLogger log;
public:

  BusImpl(byps_ptr<EventBusApiImpl> parent, int64_t busId) 
    : parentWeakPtr(parent), busId(busId) {
  } 

  byps_ptr<EventBusApiImpl> parent() {
    auto p = parentWeakPtr.lock();
    if (!p) throw BException(BExceptionC::INTERNAL, L"Already disconnected");
    return p;
  }

	/**
		* Send an event of the given type.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE*.
		* @return this object
		* @throws RemoteException
		* @see Event
		* @see EventBusC
		*/
	virtual EventBusApi::PBus send(int64_t eventType) {
    return send(eventType, PAny());
  }
    
	/**
		* Send an event of the given type with the supplied object as event data.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE*.
		* @param data Object passed to Event.any 
		* @return this object
		* @throws RemoteException
		* @see Event
		* @see EventBusC
		*/
	virtual EventBusApi::PBus send(int64_t eventType, PAny data) {
    return send(eventType, 0, data);
  }
    
	/**
		* Send an event of the given type with the supplied event ID and object as event data.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE*.
		* @param eventId Event ID
		* @param data Object passed to Event.any 
		* @return this object
		* @throws RemoteException
		* @see Event
		* @see EventBusC
		*/
	virtual EventBusApi::PBus send(int64_t eventType, int64_t eventId, PAny data) {
    vector<PEvent> events;
    PEvent ev(new Event());
    events.push_back(ev);

    ev->setBusId(this->busId);
    ev->setType(eventType);
    ev->setId(eventId);
    ev->setAny(data);

    return send(events);
  }

	/**
		* Send the given events. 
		* The function sets the member busId of the Event objects to the ID of this bus.
		* @param events Events to be sent.
		* @return this object
		* @throws RemoteException
		*/
	virtual EventBusApi::PBus send(std::vector<PEvent>& events) {
    if (log.isDebugEnabled()) log.debug() << L"send(";

    if (events.size()) {
      for (unsigned i = 0; i < events.size(); i++) events[i]->setBusId(this->busId);

      // Wenn hier ein Relogin nötig ist, dann muss für die 
      // wiederholte Ausführung von sendEvents die neu erstellte 
      // Teilnehmer-ID verwendet werden. Deshalb kann ich den Mechanismus 
      // von BAuthentication nicht verwenden und muss das 
      // Relogin hier selbst abhandeln. 
      // In meiner BAuthentication-Implementierung löst der 
      // sendEvents-Aufruf kein Relogin aus, s. IXAuthentication.

      byps_ptr<EventBusApiImpl> pparent = parent();
      PIXConnection conn = pparent->conn();
      PClient_Indexserver bclient = pparent->bclient();
      byps_ptr<BArray1<PEvent> > arr(new BArray1<PEvent>(events));

      try {
        // sendEvents aufrufen. Es erfolgt kein Relogin bei abgelaufenem Ticket, 
        // weil mein BAuthentication für die sendEvents-Funktion kein Relogin verlangt.
        int64_t subsId = pparent->getSubscriberId();
        if (log.isInfoEnabled()) {
          log.info() << L"sendEvents first try, ticket=" << conn->getLoginResult()->getClientInfo()->getTicket() << L", subsId=" << subsId;
        }
        
        bclient->getIXServicePortIF()->sendEvents(subsId, arr);
      }
      catch (BException& ex) {

        // Ist es eine Relogin-Exception?
        if (!bclient->getAuthentication()->isReloginException(parent()->bclient(), ex, 0)) throw ex;

        // Authentifizieren
	      BSyncResultT<bool>* syncNegoResult = new BSyncResultT<bool>();
        PAsyncResult asyncResult(syncNegoResult);
        bclient->getTransport()->negotiateProtocolClient(asyncResult);
        syncNegoResult->getResult();

        // Mit der neuen Teilnehmer-ID rufe ich die Funktion nochmal auf.
        int64_t subsId = pparent->getSubscriberId();
        if (log.isInfoEnabled()) {
          log.info() << L"sendEvents second try, ticket=" << conn->getLoginResult()->getClientInfo()->getTicket() << L", subsId=" << subsId;
        }
        bclient->getIXServicePortIF()->sendEvents(subsId, arr);
      }

    }

    if (log.isDebugEnabled()) log.debug() << L")send";

    return shared_from_this();
  }

	/**
		* Add an event listener for events of the given type.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		* @return Listener ID
		* @throws RemoteException
		* @see EventBusC
		*/
	virtual int64_t addListener(int64_t eventType) {
    return addListener(eventType, 0);
  }

	/**
		* Add an event listener for events of the given type.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		* @param param1 Event param1.
		* @return Listener ID
		* @throws RemoteException
		* @see EventBusC
		*/
	virtual int64_t addListener(int64_t eventType, int64_t param1) {
    return addListener(eventType, param1, L"");
  }
    
	/**
		* Add an event listener for events of the given type.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		* @param param2 Event param2.
		* @return Listener ID
		* @throws RemoteException
		* @see EventBusC
		*/
	virtual int64_t addListener(int64_t eventType, const std::wstring& param2) {
    return addListener(eventType, 0, param2);
  }
    
	/**
		* Add an event listener for events of the given type.
		* @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		* @param param1 Event param1.
		* @param param2 Event param2.
		* @return Listener ID
		* @throws RemoteException
		* @see EventBusC
		*/
	virtual int64_t addListener(int64_t eventType, int64_t param1, const std::wstring& param2) {
    PEventFilter ef(new EventFilter());
    ef->setType(eventType);
    ef->setParam1(param1);
    ef->setParam2(param2);
    return addListener(ef);
  }
    
	/**
		* Add an event listener for events of the given types.
		* @param eventTypes Event types. 
		* @return Listener ID
		* @throws RemoteException
		* @see EventBusC
		*/
	virtual int64_t addListener(const std::vector<int64_t>& eventTypes) {
    std::vector<PEventFilter> vec; 
    for (unsigned i = 0; i < eventTypes.size(); i++) {
      PEventFilter ef(new EventFilter());
      ef->setType(eventTypes[i]);
      vec.push_back(ef);
    }
    return addListener(vec);
  }

  virtual int64_t addListener(PEventFilter filter) {
    std::vector<PEventFilter> filters; 
    filters.push_back(filter);
    return addListener(filters);
  }
    
	/**
		* Add an event listener with the given filters.
		* @param filters Event filters
		* @return Listener ID
		* @throws RemoteException
		*/
	virtual int64_t addListener(std::vector<PEventFilter>& filters) {
    byps_ptr<BArray1<PEventFilter> > arr(new BArray1<PEventFilter>(filters));
    PEventListener lsn(new EventListener());
    lsn->setFilters(arr);
    return addListener(lsn);
  }

	virtual int64_t addListener(PEventListener eventListener) {
    if (log.isDebugEnabled()) log.debug() << L"addListener(";

    int64_t lsnId = 0;
    byps_ptr<EventBusApiImpl> pparent = parent();
    PIXConnection conn = pparent->conn();
    PClient_Indexserver bclient = pparent->bclient();

    if (eventListener && eventListener->getFilters() && eventListener->getFilters()->length()) {
      
      // Sicherstellen, dass die Bus-ID korrekt gesetzt ist.
      byps_ptr<BArray1<PEventFilter> > arr = eventListener->getFilters();
      for (unsigned i = 0; i < arr->length(); i++) {
        arr->at(i)->setBusId(this->busId);
      }

      // Relogin hier abhandeln wie in sendEvents.
      try {
        int64_t subsId = pparent->getSubscriberId();
        if (log.isInfoEnabled()) log.info() << L"createEventBusListener first try, subsId=" << subsId;
        lsnId = bclient->getIXServicePortIF()->createEventBusListener(subsId, eventListener);
        if (log.isInfoEnabled()) log.info() << L"lsnId=" << lsnId;
        eventListeners_put(lsnId, eventListener);
      }
      catch (BException& ex) {

        // Ist es eine Relogin-Exception?
        if (!bclient->getAuthentication()->isReloginException(parent()->bclient(), ex, 0)) throw ex;

        // Authentifizieren
	      BSyncResultT<bool>* syncNegoResult = new BSyncResultT<bool>();
        PAsyncResult asyncResult(syncNegoResult);
        bclient->getTransport()->negotiateProtocolClient(asyncResult);
        syncNegoResult->getResult();

        // Mit der neuen Teilnehmer-ID rufe ich die Funktion nochmal auf.
        int64_t subsId = pparent->getSubscriberId();
        if (log.isInfoEnabled()) {
          log.info() << L"createEventBusListener second try, ticket=" << conn->getLoginResult()->getClientInfo()->getTicket() << L", subsId=" << subsId;
        }
        lsnId = bclient->getIXServicePortIF()->createEventBusListener(subsId, eventListener);
        if (log.isInfoEnabled()) log.info() << L"lsnId=" << lsnId;

        eventListeners_put(lsnId, eventListener);

      }
    }

    if (log.isDebugEnabled()) log.debug() << L")addListener";
    return lsnId;
  }
    
	/**
		* Deletes an event bus listener
		* @param lsnId Listener ID
		* @throws RemoteException
		*/
	virtual void deleteListener(int64_t lsnId) {
    byps_ptr<EventBusApiImpl> pparent = parent();
    PIXConnection conn = pparent->conn();

    eventListeners_remove(lsnId);
    
    conn->ix()->deleteEventBusListener(lsnId);
  }
    
	/**
		* Delete all listeners from this event bus.
		* Call this function, if the Bus object is no longer needed by this application. 
		* Other applications can use the bus furtheron.
		* @throws RemoteException
		*/
	virtual void release() {

    vector<int64_t> lsnIds;
    {
      byps_unique_lock lock(mutex);
      for (auto it = eventListeners.begin(); it != eventListeners.end(); it++) lsnIds.push_back((*it).first);
      eventListeners.clear();
    }    

    byps_ptr<EventBusApiImpl> pparent = parent();
    PIXConnection conn = pparent->conn();

    for (unsigned i = 0; i < lsnIds.size(); i++) {
      try {
        conn->ix()->deleteEventBusListener(lsnIds[i]);
      } 
      catch(...) {}
    }

    pparent->releaseBus(this->busId);
  }
    
	/**
		* Close event bus.
		* Call this function, if the Bus object is no longer needed by this and other applications. 
		* This function internally calls release() to delete all listeners from the bus.
		* @throws RemoteException
		*/
  virtual void close() {
    if (log.isDebugEnabled()) log.debug() << L"close(";
    release();

    parent()->conn()->ix()->closeEventBus(this->busId);

    if (log.isDebugEnabled()) log.debug() << L")close";
  }
    
	virtual int64_t getId() {
    return this->busId;
  }

  void renewEventListenersAfterRelogin() {

    vector<PEventListener> arr;
    {
      byps_unique_lock lock(mutex);
      for (auto it = eventListeners.begin(); it != eventListeners.end(); it++) arr.push_back((*it).second);
      eventListeners.clear();
    }    

    byps_ptr<EventBusApiImpl> pparent = parent();
    PIXConnection conn = pparent->conn();

    int64_t subsId = pparent->getSubscriberId();
    for (unsigned i = 0; i < arr.size(); i++) {
      int64_t lsnId = conn->ix()->createEventBusListener(subsId, arr[i]);
      eventListeners_put(lsnId, arr[i]);
    }

  }

  void eventListeners_put(int64_t lsnId, PEventListener lsn) {
    byps_unique_lock lock(mutex);
    eventListeners[lsnId] = lsn;
  }

  void eventListeners_remove(int64_t lsnId) {
    byps_unique_lock lock(mutex);
    auto it = eventListeners.find(lsnId);
    if (it != eventListeners.end()) {
      eventListeners.erase(it);
    }
  }

};

/**
 * BSkeleton-Wrapper um Interface-Impl von IXEventBusHandler.
 * Wird in addHandler benötigt, wenn das übergebene Interface kein BSkeleton ist.
 */
class BSkeleton_IXEventBusHandler_Impl : public BSkeleton_IXEventBusHandler {
  PIXEventBusHandler innerHandler;
public: 
  BSkeleton_IXEventBusHandler_Impl(PIXEventBusHandler innerHandler) : innerHandler(innerHandler) {
  }

  virtual void processEventBusEvents(int64_t subsId, const byps_ptr< BArray1< PEvent > >& events) {
    innerHandler->processEventBusEvents(subsId, events);
  }
};

void EventBusApiImpl::addHandler(PIXEventBusHandler handler) {
  PSkeleton_IXEventBusHandler impl = byps_ptr_cast<BSkeleton_IXEventBusHandler>(handler);
  if (!impl) {
    impl = PSkeleton_IXEventBusHandler(new BSkeleton_IXEventBusHandler_Impl(handler));
  }
  addHandler(impl);
}

void EventBusApiImpl::addHandler(PSkeleton_IXEventBusHandler impl) {
  PClient_Indexserver bclient = bclientWeakPtr.lock();
  if (!bclient) return;
  bclient->addRemote(impl);
}

void EventBusApiImpl::renewAllEventListenersAfterRelogin() {
  for (auto it = busses.begin(); it != busses.end(); it++) {
    (*it).second->renewEventListenersAfterRelogin();
  }
}

EventBusApi::PBus EventBusApiImpl::getEventBus(int64_t busId) {

  byps_unique_lock lock(mutex);
  PBusImpl bus;

  auto it = busses.find(busId);
  if (it != busses.end()) {
    bus = (*it).second;
  }
  else {
    byps_ptr<EventBusApiImpl> parent = shared_from_this();
    bus = PBusImpl(new BusImpl(parent, busId));
    busses[busId] = bus;
  }

  return bus;
}



BLogger EventBusApiImpl::log("EventBusApi");
BLogger BusImpl::log("Bus");

PEventBusApi EventBusApi_create(PIXConnection conn, PClient_Indexserver bclient) {
  return PEventBusApi(new EventBusApiImpl(conn, bclient));
}

}}}}
#pragma once

#include "IXAPI.h"


namespace de { namespace elo { namespace ix { namespace client { 

using namespace byps;
using namespace byps::http;
using namespace std;

PEventBusApi EventBusApi_create(PIXConnection conn, PClient_Indexserver bclient);

/**
 * This class helps to use the event bus API functions.
 * <p>
 * In order to send an event, obtain an event bus with one of the functions 
 * <code>getEventBus, getBroadcastBus, getUserBus</code> and call one of its send functions.
 * </p><p> 
 * For receiving events, pass an implementation of the interface <code>IXEventBusHandler</code>
 * to function <code>setHandler</code> and add event listeners to a predefined or 
 * application defined bus. 
 * </p><p> 
 * Listeners can be registered with an event bus by calling the addListeners functions of 
 * the nested <code>Bus</code> class.
 * </p><p> 
 * Predefined event busses, like the broadcast bus and the user busses, do not need to be closed, 
 * when they are no longer needed. In contrast, application defined busses should be closed. They
 * stay alive inside Indexserver as int64_t as there are listeners registered with.  
 * The function <code>Bus.release</code> deletes the currently attached listeners of a bus object. 
 * Listeners are automatically removed, when the user loggs out. 
 * </p><p> 
 * Objects of this class are thread safe.
 * @see IXEventBusHandler
 */
class EventBusApi {

public:

	class Bus;
	typedef byps_ptr<Bus> PBus;

  /**
   * Returns the internally used subscriber ID.
   * @return subscriber ID
   */
	virtual int64_t getSubscriberId() = 0;

  /**
   * Adds the event handler.
   * @param evh Event handler
   */
	virtual void addHandler(PIXEventBusHandler handler) = 0;
	virtual void addHandler(PSkeleton_IXEventBusHandler handler) = 0;

  /**
   * Remove the given handler.
   * @param evh Event handler
   * @deprecated
   */
	virtual void removeHandler(PIXEventBusHandler handler) = 0;
	virtual void removeHandler(PSkeleton_IXEventBusHandler handler) = 0;

  /**
   * Wird von IXConnection aufgerufen, wenn ein relogin erfolgt.
   * Es muss dann die subscriber ID erneuert werden.
   */
  virtual void onReLogin() = 0;

	/**
	* This function opens an event bus for the given channel ID.
	* @param channelId Either an arbitary ID used to create most likely uniqe bus ID. 
	* Or null, to create a random bus ID.
	* @return Bus object.
	*/
	virtual PBus openEventBusChannel(const std::wstring& channelId) = 0;

  /**
   * This function opens an event bus for the given channel ID.
   * @param channelId Either an arbitary ID used to create most likely uniqe bus ID. 
   * Or null, to create a random bus ID.
   * @param noForwardToOtherIxs Set this parameter as true, if the messages sent on this 
   * bus should not be forwarded to other Indexserver instances. A value of true makes sense, 
   * if no other client applications are interested in messages on this bus. 
   * @return Bus object.
   */
	virtual PBus openEventBusChannel(const std::wstring& channelId, bool noForwardToOtherIxs) = 0;

	/**
	* Returns a <code>Bus</code> object for the given bus ID.
	* @param busId Event bus ID.
	* @return Bus object.
	* @see Bus#close()
	*/
	virtual PBus getEventBus(int64_t busId) = 0;
  
	/**
	* Returns a <code>Bus</code> object for the broadcast bus.
	* @return Bus object.
	*/
	virtual PBus getBroadcastBus() = 0;
  
	/**
	* Returns a <code>Bus</code> object for an user bus.
	* @param userId User ID.
	* @return Bus object.
	*/
	virtual PBus getUserBus(int32_t userId) = 0;

	/**
	* This class encapsulates the functions for sending events and listening for events.
	* Objects of this class are thread safe.
	*/
	class Bus {
	public:
		/**
		 * Send an event of the given type.
		 * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE*.
		 * @return this object
		 * @throws RemoteException
		 * @see Event
		 * @see EventBusC
		 */
		virtual PBus send(int64_t eventType) = 0;
    
		/**
		 * Send an event of the given type with the supplied object as event data.
		 * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE*.
		 * @param data Object passed to Event.any 
		 * @return this object
		 * @throws RemoteException
		 * @see Event
		 * @see EventBusC
		 */
		virtual PBus send(int64_t eventType, PAny data) = 0;
    
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
		virtual PBus send(int64_t eventType, int64_t eventId, PAny data) = 0;

		/**
		 * Send the given events. 
		 * The function sets the member busId of the Event objects to the ID of this bus.
		 * @param events Events to be sent.
		 * @return this object
		 * @throws RemoteException
		 */
		virtual PBus send(std::vector<PEvent>& events) = 0;

		/**
		 * Add an event listener for events of the given type.
		 * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		 * @return Listener ID
		 * @throws RemoteException
		 * @see EventBusC
		 */
		virtual int64_t addListener(int64_t eventType) = 0;

		/**
		 * Add an event listener for events of the given type.
		 * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		 * @param param1 Event param1.
		 * @return Listener ID
		 * @throws RemoteException
		 * @see EventBusC
		 */
		virtual int64_t addListener(int64_t eventType, int64_t param1) = 0;
    
		/**
		 * Add an event listener for events of the given type.
		 * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		 * @param param2 Event param2.
		 * @return Listener ID
		 * @throws RemoteException
		 * @see EventBusC
		 */
		virtual int64_t addListener(int64_t eventType, const std::wstring& param2) = 0;
    
		/**
		 * Add an event listener for events of the given type.
		 * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
		 * @param param1 Event param1.
		 * @param param2 Event param2.
		 * @return Listener ID
		 * @throws RemoteException
		 * @see EventBusC
		 */
		virtual int64_t addListener(int64_t eventType, int64_t param1, const std::wstring& param2) = 0;
    
		/**
		 * Add an event listener for events of the given types.
		 * @param eventTypes Event types. 
		 * @return Listener ID
		 * @throws RemoteException
		 * @see EventBusC
		 */
		virtual int64_t addListener(const std::vector<int64_t>& eventTypes) = 0;

		virtual int64_t addListener(PEventFilter filter) = 0;
    
		/**
		 * Add an event listener with the given filters.
		 * @param filters Event filters
		 * @return Listener ID
		 * @throws RemoteException
		 */
		virtual int64_t addListener(std::vector<PEventFilter>& filters) = 0;

		virtual int64_t addListener(PEventListener eventListener) = 0;
    
		/**
		 * Deletes an event bus listener
		 * @param lsnId Listener ID
		 * @throws RemoteException
		 */
		virtual void deleteListener(int64_t lsnId) = 0;
    
		/**
		 * Delete all listeners from this event bus.
		 * Call this function, if the Bus object is no longer needed by this application. 
		 * Other applications can use the bus furtheron.
		 * @throws RemoteException
		 */
		virtual void release() = 0;
    
		/**
		 * Close event bus.
		 * Call this function, if the Bus object is no longer needed by this and other applications. 
		 * This function internally calls release() to delete all listeners from the bus.
		 * @throws RemoteException
		 */
		virtual void close() = 0;
    
		virtual int64_t getId() = 0;

	};

};

}}}}
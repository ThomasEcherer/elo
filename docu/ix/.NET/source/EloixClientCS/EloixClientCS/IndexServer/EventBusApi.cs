using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using byps;


/*
* This class helps to use the event bus API functions.
* <p>
* In order to send an event, obtain an event bus with one of the functions or properties
* <code>GetEventBus, BroadcastBus, UserBus</code> and call one of its send functions.
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
* stay alive inside Indexserver as long as there are listeners registered with.  
* The function <code>Bus.release</code> deletes the currently attached listeners of a bus object. 
* Listeners are automatically removed, when the user loggs out. 
* </p><p> 
* Objects of this class are thread safe.
* @see IXEventBusHandler
*/
namespace EloixClient.IndexServer
{
    /// <summary>
    /// This class helps to use the event bus API functions.
    /// </summary>
    /// <remarks>
    /// <p>
    /// In order to send an event, obtain an event bus with one of the functions or properties 
    /// <code>getEventBus, BroadcastBus, GetUserBus</code> and call one of its send functions.
    /// </p><p> 
    /// For receiving events, add an event handler to the property <code>EventBusHandler</code>
    /// and add event listeners to a predefined or application defined bus. 
    /// </p><p> 
    /// Listeners can be registered with an event bus by calling the <code>AddListeners</code> functions of 
    /// the nested <code>Bus</code> class.
    /// </p><p> 
    /// Predefined event busses, like the broadcast bus and the user busses, do not need to be closed, 
    /// when they are no longer needed. In contrast, application defined busses should be closed. They
    /// stay alive inside Indexserver as long as there are listeners registered with.  
    /// The function <code>Bus.Release</code> deletes the currently attached listeners of a bus object. 
    /// Listeners are automatically removed, when the user loggs out. 
    /// </p><p> 
    /// Objects of this class are thread safe.
    /// </remarks>
    public class EventBusApi
    {
        /// <summary>
        /// Returns the internally used subscriber ID.
        /// </summary>
        public long SubscriberId
        {
            get
            {
                ensureSubscriber();
                return eventBusSubsId;
            }
        }

        /// <summary>
        /// Delegate function to handle events.
        /// </summary>
        /// <param name="subsId">Subscriber ID</param>
        /// <param name="events">Array of events</param>
        public delegate void ProcessEventBusEvents(long subsId, Event[] events);

        /// <summary>
        /// Event handler for event bus events.
        /// </summary>
        public event ProcessEventBusEvents EventBusHandler
        {
            add
            {
                lock (this)
                {
                    handlers.Add(value);
                }
            }
            remove
            {
                lock (this)
                {
                    handlers.Remove(value);
                    if (handlers.Count == 0)
                    {
                        Done();
                    }
                }
            }
        }

        public void Done()
        {
            handlers.Clear();
        }

        /// <summary>
        /// This function opens an event bus for the given channel ID.
        /// </summary>
        /// <remarks>
        /// Other applications recieve the same bus ID, if they pass the same channel ID.
        /// </remarks>
        /// <param name="channelId">Either an arbitary ID used to create most likely uniqe bus ID.
        /// Or null, in order to create a random bus ID.
        /// </param>
        /// <returns>Bus object.</returns>
        public Bus OpenEventBusChannel(String channelId)
        {
            EventBusParams p = new EventBusParams();
            p.channelId = channelId;
            long busId = conn.Ix.openEventBus(p);
            return GetEventBus(busId);
        }

        /// <summary>
        /// Returns a <code>Bus</code> object for the given bus ID.
        /// </summary>
        /// <param name="busId">Event bus ID.</param>
        /// <returns>Bus object.</returns>
        public Bus GetEventBus(long busId)
        {
            lock (this)
            {
                Bus bus = null;
                if (!busses.TryGetValue(busId, out bus))
                {
                    bus = new Bus(this, busId);
                    busses[busId] = bus;
                }
                return bus;
            }
        }

        /// <summary>
        /// Returns a <code>Bus</code> object for the broadcast bus.
        /// </summary>
        public Bus BroadcastBus
        {
            get
            {
                return GetEventBus(EventBusC.BUSID_BROADCAST);
            }
        }

        /// <summary>
        /// Returns a <code>Bus</code> object for an user bus.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <returns>Bus object</returns>
        public Bus GetUserBus(int userId)
        {
            return GetEventBus(EventBusC.BUSID_USER + userId);
        }

        /// <summary>
        /// This class encapsulates the functions for sending events and listening for events.
        /// </summary>
        /// <remarks>
        /// Objects of this class are thread safe.
        /// </remarks>
        public class Bus
        {
            /// <summary>
            /// Bus ID
            /// </summary>
            public long Id
            {
                get { return busId; }
            }

            /// <summary>
            /// Send an event of the given type.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE*.</param>
            /// <returns>this object</returns>
            public Bus Send(long eventType)
            {
                return Send(eventType, 0, null);
            }

            /// <summary>
            /// Send an event of the given type with the supplied object as event data.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE*.</param>
            /// <param name="data">Object passed to Event.any </param>
            /// <returns>this object</returns>
            public Bus Send(long eventType, Object data)
            {
                return Send(eventType, 0, data);
            }
            
            /// <summary>
            /// Send an event of the given type with the supplied event ID and object as event data.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE*.</param>
            /// <param name="eventId">Event ID</param>
            /// <param name="data">Object passed to Event.any </param>
            /// <returns>this object</returns>
            public Bus Send(long eventType, long eventId, Object data)
            {
                Event[] events = new Event[] { new Event() };
                events[0].busId = this.busId;
                events[0].type = eventType;
                events[0].id = eventId;
                events[0].any = AnyToObject.fromObject(data);
                return Send(events);
            }

            /// <summary>
            /// Send the given events.
            /// </summary>
            /// <remarks>
            /// The function sets the member busId of the Event objects to the ID of this bus.
            /// </remarks>
            /// <param name="events">Array of events to be sent.</param>
            /// <returns>this object</returns>
            public Bus Send(Event[] events)
            {
                if (events != null && events.Length != 0) 
                {
                    foreach (Event e in events) e.busId = this.busId;
                    try
                    {
                        eventBusApi.conn.Ix.sendEvents(eventBusApi.eventBusSubsId, events);
                    }
                    catch (Exception ex)
                    {
                        BClient_Indexserver bclient = eventBusApi.bclient;
                        if (!bclient.getAuthentication().isReloginException(bclient, ex, 0)) throw ex;

                        BSyncResult<bool> syncResult = new BSyncResult<bool>();
                        bclient.getTransport().negotiateProtocolClient(syncResult);
                        syncResult.GetResult();

                        long subsId = eventBusApi.SubscriberId;
                        bclient.IXServicePortIF.sendEvents(subsId, events);
                    }
                }
                return this;
            }

            /*
             * Add an event listener for events of the given type.
             * @param eventType Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.
             * @return this object
             * @throws RemoteException
             * @see EventBusC
             */

            /// <summary>
            /// Add an event listener for events of the given type.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.</param>
            /// <returns>Listener ID</returns>
            public long AddListener(long eventType) 
            {
              EventFilter[] filters = new EventFilter[] { new EventFilter() };
              filters[0].type = eventType;
              return AddListener(filters);
            }

            /// <summary>
            /// Add an event listener for events of the given type.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.</param>
            /// <param name="param1">Event param1</param>
            /// <returns>Listener ID</returns>
            public long AddListener(long eventType, long param1)
            {
              return AddListener(eventType, param1, null);
            }
    
            /// <summary>
            /// Add an event listener for events of the given type.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.</param>
            /// <param name="param2">Event param2</param>
            /// <returns>Listener ID</returns>
            public long AddListener(long eventType, String param2)
            {
              return AddListener(eventType, 0, param2);
            }
    
            /// <summary>
            /// Add an event listener for events of the given type.
            /// </summary>
            /// <param name="eventType">Event type, one of the constants EventBusC.EVENT_TYPE* or an application defined event type.</param>
            /// <param name="param1">Event param1</param>
            /// <param name="param2">Event param2</param>
            /// <returns>Listener ID</returns>
            public long AddListener(long eventType, long param1, String param2)
            {
              EventFilter filter = new EventFilter();
              filter.type = eventType;
              filter.param1 = param1;
              filter.param2 = param2;
              return AddListener(filter);
            }

            /// <summary>
            /// Add an event listener for events of the given types.
            /// </summary>
            /// <param name="eventTypes">Event types, constants EventBusC.EVENT_TYPE* or an application defined event type.</param>
            /// <returns>Listener ID</returns>
            public long AddListener(long[] eventTypes)
            {
      
              EventFilter[] filters = new EventFilter[eventTypes.Length];
              for (int i = 0; i < eventTypes.Length; i++) {
                filters[i] = new EventFilter();
                filters[i].type = eventTypes[i];
              }
      
              return AddListener(filters);
            }

            /// <summary>
            /// Add an event listener for the given event filter.
            /// </summary>
            /// <param name="filter">Event filter</param>
            /// <returns>Listener ID</returns>
            public long AddListener(EventFilter filter)
            {
              return AddListener(new EventFilter[] {filter});
            }

            /// <summary>
            /// Add an event listener for the given event filters.
            /// </summary>
            /// <param name="filters">Event filters</param>
            /// <returns>Listener ID</returns>
            public long AddListener(EventFilter[] filters)
            {
              EventListener eventListener = new EventListener();
              eventListener.filters = filters;
              return AddListener(eventListener);
            }

            /// <summary>
            /// Add the given event listener.
            /// </summary>
            /// <param name="eventListener">Event listener, the member busId will be internally set for each filter.</param>
            /// <returns>Listener ID</returns>
            public long AddListener(EventListener eventListener)
            {
                long lsnId = 0;
                if (eventListener != null && eventListener.filters != null && eventListener.filters.Length != 0)
                {
                    eventBusApi.ensureSubscriber();

                    foreach (EventFilter f in eventListener.filters) f.busId = busId;
                        
                    if (eventListeners == null) eventListeners = new Dictionary<long, EventListener>();

                    try
                    {
                        lsnId = eventBusApi.conn.Ix.createEventBusListener(eventBusApi.SubscriberId, eventListener);
                        eventListeners[lsnId] = eventListener;
                    }
                    catch (Exception ex)
                    {
                        BClient_Indexserver bclient = eventBusApi.bclient;
                        if (!bclient.getAuthentication().isReloginException(bclient, ex, 0)) throw ex;

                        BSyncResult<bool> syncResult = new BSyncResult<bool>();
                        bclient.getTransport().negotiateProtocolClient(syncResult);
                        syncResult.GetResult();

                        long subsId = eventBusApi.SubscriberId;
                        lsnId = bclient.IXServicePortIF.createEventBusListener(subsId, eventListener);
                        eventListeners[lsnId] = eventListener;
                    }

                }
                return lsnId;
            }

            /// <summary>
            /// Deletes an event bus listener.
            /// </summary>
            /// <param name="lsnId">Listener ID</param>
            public void DeleteListener(long lsnId)
            {
                eventListeners.Remove(lsnId);
                eventBusApi.conn.Ix.deleteEventBusListener(lsnId);
            }

            /// <summary>
            /// Delete all event listeners from this bus.
            /// </summary>
            /// <remarks>
            /// Call this function, if the Bus object is no longer needed by this application. 
            /// Other applications can use the bus furtheron.
            /// </remarks>
            public void Release() 
            {
                foreach (long lsnId in eventListeners.Keys)
                {
                    eventBusApi.conn.Ix.deleteEventBusListener(lsnId); 
                }
                eventListeners.Clear();
                eventBusApi.releaseBus(busId);
            }

            /// <summary>
            /// Close event bus.
            /// </summary>
            /// <remarks>
            /// Call this function, if the Bus object is no longer needed by this and other applications. 
            /// This function internally calls release() to delete all listeners from the bus.
            /// </remarks>
            public void Close() {
                Release();
                eventBusApi.conn.Ix.closeEventBus(busId);
            }

            internal Bus(EventBusApi eventBusApi, long busId)
            {
                this.eventBusApi = eventBusApi;
                this.busId = busId;
            }

            internal void renewEventListenersAfterRelogin() 
            {
                lock(eventListeners) 
                {
                    List<EventListener> arr = new List<EventListener>(eventListeners.Values);
                    eventListeners.Clear();
        
                    long subsId = eventBusApi.SubscriberId;
                    foreach (EventListener eventListener in arr) 
                    {
                        long lsnId = eventBusApi.conn.Ix.createEventBusListener( subsId, eventListener );
                        eventListeners[lsnId] = eventListener;
                    }
                }
            }


            private long busId;
            EventBusApi eventBusApi;
            private Dictionary<long, EventListener> eventListeners = new Dictionary<long, EventListener>();

        }

        private void releaseBus(long busId) 
        {
            busses.Remove(busId);
        }

        private void ensureSubscriber()
        {
            if (eventBusSubsId != 0) return;

            LoginResult lr = conn.LoginResult;
            if (lr == null) return;

            eventBusSubsId = conn.Ix.createEventBusSubscriber();

            EventListener eventListener = new EventListener();
            EventFilter[] filters = new EventFilter[1];
            int i = 0;

            filters[i] = new EventFilter();
            filters[i].busId = EventBusC.BUSID_USER + lr.user.id;
            filters[i].type = EventBusC.EVENT_TYPE_OPEN_CHAT;

            eventListener.filters = filters;
            long lsnId = conn.Ix.createEventBusListener(eventBusSubsId, eventListener);

            lr = conn.LoginResult;
            if (lr != null) lastTicket = lr.clientInfo.ticket;
        }

        class MyEventBusHandler : BSkeleton_IXEventBusHandler
        {
            EventBusApi eventBusApi;

            internal MyEventBusHandler(EventBusApi eventBusApi)
            {
                this.eventBusApi = eventBusApi;
            }

            public override void processEventBusEvents(long subsId, Event[] events, BAsyncResult<object> asyncResult)
            {
                try
                {
                    foreach (ProcessEventBusEvents handler in this.eventBusApi.handlers)
                    {
                        handler(eventBusApi.eventBusSubsId, events);
                    }
                }
                catch (Exception) { }
                asyncResult(true, null);
            }
        };

        internal EventBusApi(IXConnection conn, BClient_Indexserver bclient)
        {
            this.conn = conn;
            this.bclient = bclient;

            bclient.addRemote(new MyEventBusHandler(this));
        }

        private void renewAllEventListenersAfterRelogin() 
        {
            foreach (Bus bus in busses.Values) 
            {
                bus.renewEventListenersAfterRelogin();
            }
        }

        internal void onRelogin()
        {
            eventBusSubsId = conn.Ix.createEventBusSubscriber();
            renewAllEventListenersAfterRelogin();
        }

        private IXConnection conn;
        private BClient_Indexserver bclient;
        private long eventBusSubsId;
        private String lastTicket;
        private List<ProcessEventBusEvents> handlers = new List<ProcessEventBusEvents>();
        private Dictionary<long, Bus> busses = new Dictionary<long,Bus>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EloixClient.IndexServer;
using System.Threading;

namespace Examples
{
    /// <summary>
    /// This example shows how to send and received events.
    /// </summary>
    class EventBusSendReceive
    {
        // URL to IndexServer
        public String url;

        // [X] Account to authenticate 
        public String userName = "Administrator";
        public String userPwd = "";

        private long myEventType;

        List<String> receivedMessages = new List<String>();

        public void run()
        {
            IXConnFactory connFact = null;
            IXConnection ix1 = null;
            IXConnection ix2 = null;

            // generate an event type that is most likely only used by me.
            myEventType = computeMyEventType();

            try
            {
                IXProperties connProps = IXConnFactory.CreateConnProperties(url);
                IXProperties sessOpts = IXConnFactory.CreateSessionOptions("IX-Examples", "1.0");
                connFact = new IXConnFactory(connProps, sessOpts);
                Logger.instance().log("create IXConnFactory OK");

                // LOGIN
                Logger.instance().log("login connections...");
                ix1 = connFact.Create(userName, userPwd, "myComputer-conn1", null);
                ix2 = connFact.Create(userName, userPwd, "myComputer-conn2", null);
                // ci = ix.Login.ci
                Logger.instance().log("login OK");

                // Add event bus handlers.
                // This handlers are called for the received events from a background thread.
                // Thus we cannot update the user interfache in this threads directly. 
                // The handlers will add the received events to the list receivedMessages and 
                // the items of the list are printed from the main thread.
                ix1.EventBusApi.EventBusHandler += new EventBusApi.ProcessEventBusEvents(EventBusApi_EventBusHandler1);
                ix2.EventBusApi.EventBusHandler += new EventBusApi.ProcessEventBusEvents(EventBusApi_EventBusHandler2);

                // Add listeners to our private event.
                ix1.EventBusApi.BroadcastBus.AddListener(myEventType);
                ix2.EventBusApi.BroadcastBus.AddListener(myEventType);

                Logger.instance().log("conn1.subsId=" + ix1.EventBusApi.SubscriberId);
                Logger.instance().log("conn2.subsId=" + ix2.EventBusApi.SubscriberId);

                // Each connection sends 3 events to the other connection.
                // Here, the event data is a simple string. But it could be a Sord e.g. too.
                Logger.instance().log("send events");
                for (int i = 0; i < 3; i++)
                {
                    EventBusApi.Bus bbus1 = ix1.EventBusApi.BroadcastBus;
                    bbus1.Send(myEventType, "Hello conn2 - " + i);

                    EventBusApi.Bus bbus2 = ix2.EventBusApi.BroadcastBus;
                    bbus2.Send(myEventType, "Hello conn1 - " + i);
                }

                // Wait for the events and print them.
                Logger.instance().log("wait 1");
                Thread.Sleep(1 * 1000);

                // Print received messages
                Logger.instance().log("received:");
                foreach (String s in receivedMessages) Logger.instance().log(s);

                if (receivedMessages.Count != 6)
                {
                    Logger.instance().log("Error: 6 events should have been received");
                }

                        

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Logout
                // --
                if (ix1 != null && ix2 != null)
                {
                    Logger.instance().log("IX logout...");
                    ix1.Logout();
                    ix2.Logout();
                    Logger.instance().log("IX logout OK");
                }
            }
        }

        String eventToString(Event e)
        {
            return ("[type=" + e.type + ", data=" + AnyToObject.ToObject(e.any) + "]");
        }

        void addReceivedMessages(String capt, Event[] events)
        {
            lock (receivedMessages)
            {
                foreach (Event e in events)
                {
                    receivedMessages.Add(capt + eventToString(e));
                }
            }
        }

        /// <summary>
        /// Event handler for first connection.
        /// </summary>
        /// <remarks>
        /// This function is called in a background thread. 
        /// </remarks>
        /// <param name="subsId">Subscriber ID</param>
        /// <param name="events">Array of events</param>
        void EventBusApi_EventBusHandler1(long subsId, Event[] events)
        {
            addReceivedMessages("conn1 " + subsId + " received event: ", events);
        }

        /// <summary>
        /// Event handler for second connection.
        /// </summary>
        /// <remarks>
        /// This function is called in a background thread. 
        /// </remarks>
        /// <param name="subsId">Subscriber ID</param>
        /// <param name="events">Array of events</param>
        void EventBusApi_EventBusHandler2(long subsId, Event[] events)
        {
            addReceivedMessages("conn2 " + subsId + " received event: ", events);
        }

        /// <summary>
        /// This function generates a random number to be used as a private event type.
        /// </summary>
        /// <remarks>
        /// Application defined event types must be greater than EventBusC.EVENT_TYPE_MAX_SYSTEM
        /// </remarks>
        /// <returns>Random number</returns>
        long computeMyEventType()
        {
            Random rand = new Random();
            long type = 0;

            while (type <= EventBusC.EVENT_TYPE_MAX_SYSTEM)
            {
                byte[] buf = new byte[8];
                rand.NextBytes(buf);
                type = BitConverter.ToInt64(buf, 0);
                if (type < 0) type = -type;
            }
            return type;
        }
    }
}

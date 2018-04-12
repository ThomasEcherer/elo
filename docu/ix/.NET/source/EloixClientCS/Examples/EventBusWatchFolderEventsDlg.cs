using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServer;

namespace Examples
{
    /// <summary>
    /// This dialog shows the events sent by ELOix, when the 
    /// subitems of a folder have changed.
    /// </summary>
    /// <remarks>
    /// The events are received from a background thread. 
    /// To show the events in the list view, 
    /// the control has to be called in a thread safe way. 
    /// See: http://msdn.microsoft.com/en-us/library/ms171728(v=vs.100).aspx
    /// </remarks>
    public partial class EventBusWatchFolderEventsDlg : Form
    {
        // Indexserver connection
        IXConnection conn;

        // Current listener ID
        long watchFolderLsnId;

        /// <summary>
        /// This delegate type is impemented by the ShowEvents function.
        /// </summary>
        /// <param name="subsId">Subscriber ID</param>
        /// <param name="events">Events</param>
        delegate void ShowEventsCallback(long subsId, Event[] events);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">Indexserver connection</param>
        public EventBusWatchFolderEventsDlg(IXConnection conn)
        {
            this.conn = conn;

            // Create dialog UI
            InitializeComponent();

            // Add an event bus handler function to the connection.
            conn.EventBusApi.EventBusHandler += 
                new EventBusApi.ProcessEventBusEvents(EventBusApi_EventBusHandler);
            
            // Add a listener for the object ID given in TextBox edObjId
            initListener();
        }

        /// <summary>
        /// Delete the current listener, add a new listener. 
        /// </summary>
        private void initListener()
        {
            // Delete current listener
            if (watchFolderLsnId != 0L)
            {
                conn.EventBusApi.BroadcastBus.DeleteListener(watchFolderLsnId);
                watchFolderLsnId = 0L;
            }

            // Add new listener
            try
            {
                watchFolderLsnId = conn.EventBusApi.BroadcastBus.AddListener(
                    EventBusC.EVENT_TYPE_WATCH_FOLDER, 0, edObjId.Text);
            }
            catch (Exception)
            {
                // Ignored. 
                // initListener() is called on each change in TextBox edObjId. 
                // There might be an invalid object ID during editing.
            }
        }

        /// <summary>
        /// Event bus handler function.
        /// </summary>
        /// <remarks>
        /// This function is called in a background thread. 
        /// Thus, it cannot access the dialog elements of this form directly. 
        /// We have to create a delegate object that contains the call 
        /// ShowEvents to update the UI. 
        /// This delegate is passed to the Invoke function which executes 
        /// ShowEvents in the UI thread.
        /// </remarks>
        /// <param name="subsId">Subscriber ID</param>
        /// <param name="events">Events</param>
        void EventBusApi_EventBusHandler(long subsId, Event[] events)
        {
            ShowEventsCallback d = new ShowEventsCallback(ShowEvents);
            this.Invoke(d, new Object[] { subsId, events });
        }

        /// <summary>
        /// This function adds the events to the list view.
        /// </summary>
        /// <param name="subsId">Subscriber ID</param>
        /// <param name="events">Events</param>
        private void ShowEvents(long subsId, Event[] events)
        {
            foreach (Event e in events)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(e.type);
                item.SubItems.Add(e.param2);
                Object[] args = (Object[])AnyToObject.ToObject(e.any);
                Sord sord = (Sord)args[0];
                item.SubItems.Add(sord.name);
                int what = (int)args[2];
                switch (what)
                {
                    case EventBusC.WATCH_INSERT: item.SubItems.Add("inserted"); break;
                    case EventBusC.WATCH_UPDATE: item.SubItems.Add("updated"); break;
                    case EventBusC.WATCH_DELETE: item.SubItems.Add("deleted"); break;
                }
                this.lvEvents.Items.Add(item);
            }
        }

        /// <summary>
        /// Update the listener on each change of the TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edObjId_TextChanged(object sender, EventArgs e)
        {
            initListener();
        }

        /// <summary>
        /// Release the broadcast event bus in order to delete attached 
        /// listeners and detach the event bus hander.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventBusWatchFolderEventsDlg_FormClosed(object sender, 
            FormClosedEventArgs e)
        {
            try
            {
                // Detach event bus hander. 
                // EventBusApi_EventBusHandler must not be called 
                // after the Form has been disposed.  
                conn.EventBusApi.EventBusHandler -= 
                    new EventBusApi.ProcessEventBusEvents(EventBusApi_EventBusHandler);

                // Delete all of my attached listeners.
                conn.EventBusApi.BroadcastBus.Release();
            }
            catch (Exception)
            {
            }
        }

        
    }
}

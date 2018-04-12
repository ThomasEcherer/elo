using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Workflow
{
    /// <summary>
    /// This class represents a reminder. It encapsulates the 
    /// Reminder class from the IndexServer API.
    /// </summary>
    public class FWReminder : FWWorkflowBase
    {
        [CLSCompliant(false)]
        protected Reminder _reminder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ifc">Workflow interface object</param>
        /// <param name="reminder">Reminder object from IndexServer API</param>
        public FWReminder(FWWorkflowInterface ifc, Reminder reminder)
            : base(ifc)
        {
            _reminder = reminder;
        }

        /// <summary>
        /// Gets / Sets the internal Reminder object.
        /// </summary>
        public Reminder Core
        {
            get { return _reminder; }
            set { _reminder = value; }
        }

        /// <summary>
        /// Writes all changes to the reminder object into the archive and removes the lock.
        /// </summary>
        public virtual void Checkin()
        {
            if (_reminder.deleted)
            {
                Conn.Ix.deleteReminders(new int[] { _reminder.id }, LockC.YES);
            }
            else
            {
                Conn.Ix.checkinReminder(_reminder, null, false, LockC.YES);
            }
        }

        /// <summary>
        /// Deletes the Reminder object.
        /// </summary>
        public virtual void Delete()
        {
            _reminder.deleted = true;
            Checkin();
        }

        /// <summary>
        /// Removes the lock.
        /// </summary>
        public virtual void Unlock()
        {
        }

        #region properties

        /// <summary>
        /// Gets or sets the numeric ID of the reminder.
        /// </summary>
        public int Id
        {
            get { return _reminder.id; }
            internal set { _reminder.id = value; }
        }

        /// <summary>
        /// Gets or sets the GUID of the reminder.
        /// </summary>
        public string Guid
        {
            get { return string.Empty; }
        }

        #endregion
    }
}

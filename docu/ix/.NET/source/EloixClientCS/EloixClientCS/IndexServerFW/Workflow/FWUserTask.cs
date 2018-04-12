using System;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Content;

namespace EloixClient.IndexServerFW.Workflow
{
    /// <summary>
    /// Types of user tasks
    /// </summary>
    public enum FWUserTaskType
    {
        /// <summary>
        /// Workflow task
        /// </summary>
        Workflow = 1,
        /// <summary>
        /// Reminder task
        /// </summary>
        Reminder = 2,
        /// <summary>
        /// Activity task
        /// </summary>
        Activity = 3
    }

    /// <summary>
    /// This class provides generic access to 
    /// some members of the UserTask class.
    /// </summary>
    public class FWUserTask : FWWorkflowBase
    {
        /// <summary>
        /// UserTask object from IndexServer API
        /// </summary>
        protected UserTask userTaskVal;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ifc">Interface object</param>
        /// <param name="userTask">UserTask object from IndexServer API</param>
        public FWUserTask(FWWorkflowInterface ifc, UserTask userTask)
            : base(ifc)
        {
            this.userTaskVal = userTask;
        }
        /// <summary>
        /// Get/set the internal UserTask object
        /// </summary>
        public virtual UserTask Core
        {
            get { return userTaskVal; }
            set { userTaskVal = value; }
        }
        /// <summary>
        /// User task name
        /// </summary>
        public virtual String Name
        {
            get
            {
                String name = "";
                if (userTaskVal.wfNode != null)
                {
                    name = userTaskVal.wfNode.nodeName;
                }
                else if (userTaskVal.reminder != null)
                {
                    name = userTaskVal.reminder.name;
                }
                else if (userTaskVal.activity != null)
                {
                    name = userTaskVal.activity.name;
                }
                return name;
            }
        }
        /// <summary>
        /// User task priority
        /// </summary>
        public virtual int Priority
        {
            get
            {
                int prio = UserTaskPriorityC.HIGHEST;
                if (userTaskVal.wfNode != null)
                {
                    prio = userTaskVal.wfNode.prio;
                }
                else if (userTaskVal.reminder != null)
                {
                    prio = userTaskVal.reminder.prio;
                }
                else if (userTaskVal.activity != null)
                {
                    prio = userTaskVal.activity.prio;
                }
                return prio;
            }
            /*
            set
            {
              if (userTaskVal.wfNode != null)
              {
                userTaskVal.wfNode.prio = value;
              }
              else if (userTaskVal.reminder != null)
              {
                userTaskVal.reminder.prio = value;
              }
              else if (userTaskVal.activity != null)
              {
                userTaskVal.activity.prio = value;
              }
            }*/
        }
        /// <summary>
        /// User task type
        /// </summary>
        public virtual FWUserTaskType Type
        {
            get
            {
                FWUserTaskType t = default(FWUserTaskType);

                if (userTaskVal.wfNode != null)
                {
                    t = FWUserTaskType.Workflow;
                }
                else if (userTaskVal.reminder != null)
                {
                    t = FWUserTaskType.Reminder;
                }
                else if (userTaskVal.activity != null)
                {
                    t = FWUserTaskType.Activity;
                }
                return t;
            }
        }
        /// <summary>
        /// User task date
        /// </summary>
        public virtual DateTime Date
        {
            get
            {
                String isoDate = "";

                if (userTaskVal.wfNode != null)
                {
                    isoDate = userTaskVal.wfNode.activateDateIso;
                }
                else if (userTaskVal.reminder != null)
                {
                    isoDate = userTaskVal.reminder.promptDateIso;
                }
                else if (userTaskVal.activity != null)
                {
                    isoDate = userTaskVal.activity.dueDateIso;
                }

                return Conn.IsoToDate(isoDate);
            }
            /*
            set
            {
              String isoDate = Conn.DateToIso(value);

              if (userTaskVal.wfNode != null)
              {
                userTaskVal.wfNode.activateDateIso = isoDate;
              }
              else if (userTaskVal.reminder != null)
              {
                userTaskVal.reminder.promptDateIso = isoDate;
              }
              else if (userTaskVal.activity != null)
              {
                userTaskVal.activity.dueDateIso = isoDate;
              }
            }*/
        }
        /// <summary>
        /// User task description 
        /// </summary>
        public virtual String Desc
        {
            get
            {
                String desc = "";

                if (userTaskVal.wfNode != null)
                {
                    desc = userTaskVal.wfNode.flowName;
                }
                else if (userTaskVal.reminder != null)
                {
                    desc = userTaskVal.reminder.desc;
                }
                else if (userTaskVal.activity != null)
                {
                    desc = userTaskVal.activity.comment;
                }

                return desc;
            }
            /*
            set
            {
              String desc = value;

              if (userTaskVal.wfNode != null)
              {
              }
              else if (userTaskVal.reminder != null)
              {
                userTaskVal.reminder.desc = desc;
              }
              else if (userTaskVal.activity != null)
              {
                userTaskVal.activity.comment = desc;
              }
            }*/
        }
        /// <summary>
        /// Type of the associated Sord object
        /// </summary>
        public virtual int SordType
        {
            get
            {
                int t = SordC.LBT_DOCUMENT;

                if (userTaskVal.wfNode != null)
                {
                    t = userTaskVal.wfNode.objType;
                }
                else if (userTaskVal.reminder != null)
                {
                    t = userTaskVal.reminder.objType;
                }
                else if (userTaskVal.activity != null)
                {
                }
                return t;
            }
        }
        /// <summary>
        /// Image index of the associated Sord object.
        /// </summary>
        /// <remarks>
        /// The index is related to the image list of the connections SordTypeCache.
        /// </remarks>
        /// <seealso cref="SordTypeCache.ImageList"/>
        public virtual int SordImageIndex
        {
            get
            {
                int v = this.ifc.Conn.MasterData.SordTypes.ImageList.getImageIndex(SordType, false, false);
                return v;
            }
        }
        /// <summary>
        /// This user is responsible for the user task.
        /// </summary>
        public virtual String ReceiverName
        {
            get
            {
                String s = "";

                if (userTaskVal.wfNode != null)
                {
                    s = userTaskVal.wfNode.userName;
                }
                else if (userTaskVal.reminder != null)
                {
                    s = userTaskVal.reminder.receiverName;
                }
                else if (userTaskVal.activity != null)
                {
                    s = userTaskVal.activity.receiverName;
                }

                return s;
            }
        }

        /// <summary>
        /// This user is responsible for the user task.
        /// </summary>
        public virtual int ReceiverId
        {
            get
            {
                int s = -1;
                if (userTaskVal.wfNode != null)
                {
                    s = userTaskVal.wfNode.userId;
                }
                else if (userTaskVal.reminder != null)
                {
                    s = userTaskVal.reminder.receiverId;
                }
                else if (userTaskVal.activity != null)
                {
                    s = userTaskVal.activity.receiverId;
                }
                return s;
            }
        }

        /// <summary>
        /// Get the Sord object associated to the user task.
        /// </summary>
        /// <remarks>Accessing this property might cause 
        /// a server request to read the Sord object.
        /// </remarks>
        public virtual FWSord Sord
        {
            get
            {
                return ifc.Conn.Content.GetSord(ObjId);
            }
        }
        /// <summary>
        /// Get the associated object ID or GUID (activity).
        /// </summary>
        public virtual string ObjId
        {
            get
            {
                String objId = "";
                if (userTaskVal.wfNode != null)
                {
                    objId = Convert.ToString(userTaskVal.wfNode.objId);
                }
                else if (userTaskVal.reminder != null)
                {
                    objId = Convert.ToString(userTaskVal.reminder.objId);
                }
                else if (userTaskVal.activity != null)
                {
                    objId = userTaskVal.activity.objGuid;
                }
                return objId;
            }
        }

    }
}

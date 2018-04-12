//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class Reminder : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Reminder() {
		}		
		
		public Reminder(String @desc, int @id, int @lockId, String @name, int @objId, int @objType, int @prio, int @receiverId, int @senderId, String @createDateIso, bool @deleted, String @dueDateIso, String @lockName, bool @notifyOnDelete, bool @notifyOnView, String @objGuid, String @promptDateIso, String @receiverName, String @senderName) {
			this.descValue = @desc;
			this.idValue = @id;
			this.lockIdValue = @lockId;
			this.nameValue = @name;
			this.objIdValue = @objId;
			this.objTypeValue = @objType;
			this.prioValue = @prio;
			this.receiverIdValue = @receiverId;
			this.senderIdValue = @senderId;
			this.createDateIsoValue = @createDateIso;
			this.deletedValue = @deleted;
			this.dueDateIsoValue = @dueDateIso;
			this.lockNameValue = @lockName;
			this.notifyOnDeleteValue = @notifyOnDelete;
			this.notifyOnViewValue = @notifyOnView;
			this.objGuidValue = @objGuid;
			this.promptDateIsoValue = @promptDateIso;
			this.receiverNameValue = @receiverName;
			this.senderNameValue = @senderName;
		}		
		
		public Reminder(Reminder rhs) : base(rhs)
		{
			this.descValue = rhs.descValue;
			this.idValue = rhs.idValue;
			this.lockIdValue = rhs.lockIdValue;
			this.nameValue = rhs.nameValue;
			this.objIdValue = rhs.objIdValue;
			this.objTypeValue = rhs.objTypeValue;
			this.prioValue = rhs.prioValue;
			this.receiverIdValue = rhs.receiverIdValue;
			this.senderIdValue = rhs.senderIdValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.deletedValue = rhs.deletedValue;
			this.dueDateIsoValue = rhs.dueDateIsoValue;
			this.lockNameValue = rhs.lockNameValue;
			this.notifyOnDeleteValue = rhs.notifyOnDeleteValue;
			this.notifyOnViewValue = rhs.notifyOnViewValue;
			this.objGuidValue = rhs.objGuidValue;
			this.promptDateIsoValue = rhs.promptDateIsoValue;
			this.receiverNameValue = rhs.receiverNameValue;
			this.senderNameValue = rhs.senderNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Memo text
		/// </summary>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
				setChangedMember(ReminderC.mbDesc);
			}
		}
		
		
		/// <summary>
		/// Reminder ID
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(ReminderC.mbId);
			}
		}
		
		
		/// <summary>
		/// ID of user who has locked the reminder record in DB
		/// </summary>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(ReminderC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// Short description visible in the task list.
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
				setChangedMember(ReminderC.mbName);
			}
		}
		
		
		/// <summary>
		/// Reminder is linked to this Sord.
		/// </summary>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(ReminderC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Sord type.
		/// </summary>
		public int objType
		{
			get
			{
				return objTypeValue;
			}
			set
			{
				this.objTypeValue = value;
				setChangedMember(ReminderC.mbObjType);
			}
		}
		
		
		/// <summary>
		/// Priority: 0...high, 1...medium, 2...low
		/// </summary>
		public int prio
		{
			get
			{
				return prioValue;
			}
			set
			{
				this.prioValue = value;
				setChangedMember(ReminderC.mbPrio);
			}
		}
		
		
		/// <summary>
		/// Reminder was created for this user.
		/// </summary>
		public int receiverId
		{
			get
			{
				return receiverIdValue;
			}
			set
			{
				this.receiverIdValue = value;
				setChangedMember(ReminderC.mbReceiverId);
			}
		}
		
		
		/// <summary>
		/// Reminder was created by this user.
		/// </summary>
		public int senderId
		{
			get
			{
				return senderIdValue;
			}
			set
			{
				this.senderIdValue = value;
				setChangedMember(ReminderC.mbSenderId);
			}
		}
		
		
		/// <summary>
		/// Reminder was created at this date.
		/// </summary>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
				setChangedMember(ReminderC.mbCreateDateIso);
			}
		}
		
		
		/// <summary>
		/// Reminder is deleted logically if set.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
				setChangedMember(ReminderC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// On this date the receiver has seen the reminder.
		/// </summary>
		public String dueDateIso
		{
			get
			{
				return dueDateIsoValue;
			}
			set
			{
				this.dueDateIsoValue = value;
				setChangedMember(ReminderC.mbDueDateIso);
			}
		}
		
		
		/// <summary>
		/// Reminder is locked by this user.
		/// </summary>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
				setChangedMember(ReminderC.mbLockName);
			}
		}
		
		
		/// <summary>
		/// Notify sender if receiver deletes the reminder.
		/// </summary>
		public bool notifyOnDelete
		{
			get
			{
				return notifyOnDeleteValue;
			}
			set
			{
				this.notifyOnDeleteValue = value;
				setChangedMember(ReminderC.mbNotifyOnDelete);
			}
		}
		
		
		/// <summary>
		/// Notify sender if receiver views the reminder.
		/// </summary>
		public bool notifyOnView
		{
			get
			{
				return notifyOnViewValue;
			}
			set
			{
				this.notifyOnViewValue = value;
				setChangedMember(ReminderC.mbNotifyOnView);
			}
		}
		
		
		/// <summary>
		/// Sord GUID.
		/// </summary>
		public String objGuid
		{
			get
			{
				return objGuidValue;
			}
			set
			{
				this.objGuidValue = value;
				setChangedMember(ReminderC.mbObjGuid);
			}
		}
		
		
		/// <summary>
		/// At this Date the reminder should be made visible to the receiver.
		/// </summary>
		public String promptDateIso
		{
			get
			{
				return promptDateIsoValue;
			}
			set
			{
				this.promptDateIsoValue = value;
				setChangedMember(ReminderC.mbPromptDateIso);
			}
		}
		
		
		/// <summary>
		/// Reminder was created for this user.
		/// </summary>
		public String receiverName
		{
			get
			{
				return receiverNameValue;
			}
			set
			{
				this.receiverNameValue = value;
				setChangedMember(ReminderC.mbReceiverName);
			}
		}
		
		
		/// <summary>
		/// Reminder was created by this user.
		/// </summary>
		public String senderName
		{
			get
			{
				return senderNameValue;
			}
			set
			{
				this.senderNameValue = value;
				setChangedMember(ReminderC.mbSenderName);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String descValue;

		protected int idValue;

		protected int lockIdValue;

		protected String nameValue;

		protected int objIdValue;

		protected int objTypeValue;

		protected int prioValue;

		protected int receiverIdValue;

		protected int senderIdValue;

		protected String createDateIsoValue;

		protected bool deletedValue;

		protected String dueDateIsoValue;

		protected String lockNameValue;

		protected bool notifyOnDeleteValue;

		protected bool notifyOnViewValue;

		protected String objGuidValue;

		protected String promptDateIsoValue;

		protected String receiverNameValue;

		protected String senderNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 256674679L;		
	} // end class
}  // end namespace

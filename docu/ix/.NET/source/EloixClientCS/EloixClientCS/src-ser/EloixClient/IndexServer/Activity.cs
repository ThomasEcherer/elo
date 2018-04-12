//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// This class represents an activity.
	/// </summary>
	/// <remarks>
	/// <p>
	/// An activity is a task delegated to an instance outside the ELO system.
	/// It is created when the task is sent to the instance and deleted, if it is received back.
	/// An activity defines a date for expecting the response, <code>dueDateIso</code>.
	/// At this date, the activity appears in the task list of the initiator. If the task is finished,
	/// the initiator sets the <code>backAt</code> member and the activity is closed.
	/// </p><p>
	/// Activities can be used to observe a document or a folder. For each modification,
	/// a ELO_NOTIFY activity is created and displayed in the task list of the user that wants to
	/// observe the object.
	/// </p><p>
	/// An activity object is an instance on an activity project. The project defines
	/// the properties the user can edit or select to provide more information to the task.
	/// </p>
	/// </remarks>
	public class Activity : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Activity() {
		}		
		
		public Activity(String @TStamp, String @backAt, String @backMode, String @comment, String @destination, String @dueDateIso, String @fileName, String @guid, String @name, String @objGuid, int @prio, String @project, int @receiverId, String @revVers, int @senderId, String @sentAtIso, String @sentMode, String @ud0, String @ud1, String @ud2, String @ud3, String @ud4, String @ud5, String @ud6, String @ud7, String @ud8, String @ud9, String @receiverName, String @senderName, String @transId, int @objId, int @objType, String @TStampSync) {
			this.TStampValue = @TStamp;
			this.backAtValue = @backAt;
			this.backModeValue = @backMode;
			this.commentValue = @comment;
			this.destinationValue = @destination;
			this.dueDateIsoValue = @dueDateIso;
			this.fileNameValue = @fileName;
			this.guidValue = @guid;
			this.nameValue = @name;
			this.objGuidValue = @objGuid;
			this.prioValue = @prio;
			this.projectValue = @project;
			this.receiverIdValue = @receiverId;
			this.revVersValue = @revVers;
			this.senderIdValue = @senderId;
			this.sentAtIsoValue = @sentAtIso;
			this.sentModeValue = @sentMode;
			this.ud0Value = @ud0;
			this.ud1Value = @ud1;
			this.ud2Value = @ud2;
			this.ud3Value = @ud3;
			this.ud4Value = @ud4;
			this.ud5Value = @ud5;
			this.ud6Value = @ud6;
			this.ud7Value = @ud7;
			this.ud8Value = @ud8;
			this.ud9Value = @ud9;
			this.receiverNameValue = @receiverName;
			this.senderNameValue = @senderName;
			this.transIdValue = @transId;
			this.objIdValue = @objId;
			this.objTypeValue = @objType;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public Activity(Activity rhs) : base(rhs)
		{
			this.TStampValue = rhs.TStampValue;
			this.backAtValue = rhs.backAtValue;
			this.backModeValue = rhs.backModeValue;
			this.commentValue = rhs.commentValue;
			this.destinationValue = rhs.destinationValue;
			this.dueDateIsoValue = rhs.dueDateIsoValue;
			this.fileNameValue = rhs.fileNameValue;
			this.guidValue = rhs.guidValue;
			this.nameValue = rhs.nameValue;
			this.objGuidValue = rhs.objGuidValue;
			this.prioValue = rhs.prioValue;
			this.projectValue = rhs.projectValue;
			this.receiverIdValue = rhs.receiverIdValue;
			this.revVersValue = rhs.revVersValue;
			this.senderIdValue = rhs.senderIdValue;
			this.sentAtIsoValue = rhs.sentAtIsoValue;
			this.sentModeValue = rhs.sentModeValue;
			this.ud0Value = rhs.ud0Value;
			this.ud1Value = rhs.ud1Value;
			this.ud2Value = rhs.ud2Value;
			this.ud3Value = rhs.ud3Value;
			this.ud4Value = rhs.ud4Value;
			this.ud5Value = rhs.ud5Value;
			this.ud6Value = rhs.ud6Value;
			this.ud7Value = rhs.ud7Value;
			this.ud8Value = rhs.ud8Value;
			this.ud9Value = rhs.ud9Value;
			this.receiverNameValue = rhs.receiverNameValue;
			this.senderNameValue = rhs.senderNameValue;
			this.transIdValue = rhs.transIdValue;
			this.objIdValue = rhs.objIdValue;
			this.objTypeValue = rhs.objTypeValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Date and time of the last update.
		/// </summary>
		/// <remarks>
		/// Readonly
		/// </remarks>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(ActivityC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Date when activity object was returned, ISO format.
		/// </summary>
		/// <remarks>
		/// This value does not contain a time portion.
		/// </remarks>
		public String backAt
		{
			get
			{
				return backAtValue;
			}
			set
			{
				this.backAtValue = value;
				setChangedMember(ActivityC.mbBackAt);
			}
		}
		
		
		/// <summary>
		/// Application defined purpose.
		/// </summary>
		public String backMode
		{
			get
			{
				return backModeValue;
			}
			set
			{
				this.backModeValue = value;
				setChangedMember(ActivityC.mbBackMode);
			}
		}
		
		
		/// <summary>
		/// Comment for the activity.
		/// </summary>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
				setChangedMember(ActivityC.mbComment);
			}
		}
		
		
		/// <summary>
		/// Application defined purpose.
		/// </summary>
		public String destination
		{
			get
			{
				return destinationValue;
			}
			set
			{
				this.destinationValue = value;
				setChangedMember(ActivityC.mbDestination);
			}
		}
		
		
		/// <summary>
		/// Date when activity object is expected to be returned.
		/// </summary>
		/// <remarks>
		/// This value does not contain a time portion.
		/// </remarks>
		public String dueDateIso
		{
			get
			{
				return dueDateIsoValue;
			}
			set
			{
				this.dueDateIsoValue = value;
				setChangedMember(ActivityC.mbDueDateIso);
			}
		}
		
		
		/// <summary>
		/// Application defined purpose.
		/// </summary>
		public String fileName
		{
			get
			{
				return fileNameValue;
			}
			set
			{
				this.fileNameValue = value;
				setChangedMember(ActivityC.mbFileName);
			}
		}
		
		
		/// <summary>
		/// GUID of the activity object.
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(ActivityC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Short name/description of the activity object.
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
				setChangedMember(ActivityC.mbName);
			}
		}
		
		
		/// <summary>
		/// GUID of the assigned archive entry.
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
				setChangedMember(ActivityC.mbObjGuid);
			}
		}
		
		
		/// <summary>
		/// Priority for the activity.
		/// </summary>
		/// <remarks>
		/// Priority A has value 0, UserTaskPriorityC.HIGHEST
		/// Priority B has value 1.
		/// Priority C has value 2, UserTaskPriorityC#LOWEST
		/// </remarks>
		public int prio
		{
			get
			{
				return prioValue;
			}
			set
			{
				this.prioValue = value;
				setChangedMember(ActivityC.mbPrio);
			}
		}
		
		
		/// <summary>
		/// Project name for the activity.
		/// </summary>
		public String project
		{
			get
			{
				return projectValue;
			}
			set
			{
				this.projectValue = value;
				setChangedMember(ActivityC.mbProject);
			}
		}
		
		
		/// <summary>
		/// The ID of the recipient.
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
				setChangedMember(ActivityC.mbReceiverId);
			}
		}
		
		
		/// <summary>
		/// Revision version of the activity object.
		/// </summary>
		public String revVers
		{
			get
			{
				return revVersValue;
			}
			set
			{
				this.revVersValue = value;
				setChangedMember(ActivityC.mbRevVers);
			}
		}
		
		
		/// <summary>
		/// ID of the user who created the activity.
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
				setChangedMember(ActivityC.mbSenderId);
			}
		}
		
		
		/// <summary>
		/// Date the activity was sent in ISO format.
		/// </summary>
		/// <remarks>
		/// This value does not contain a time portion.
		/// </remarks>
		public String sentAtIso
		{
			get
			{
				return sentAtIsoValue;
			}
			set
			{
				this.sentAtIsoValue = value;
				setChangedMember(ActivityC.mbSentAtIso);
			}
		}
		
		
		/// <summary>
		/// Application defined purpose.
		/// </summary>
		public String sentMode
		{
			get
			{
				return sentModeValue;
			}
			set
			{
				this.sentModeValue = value;
				setChangedMember(ActivityC.mbSentMode);
			}
		}
		
		
		/// <summary>
		/// First application defined value.
		/// </summary>
		public String ud0
		{
			get
			{
				return ud0Value;
			}
			set
			{
				this.ud0Value = value;
				setChangedMember(ActivityC.mbUd0);
			}
		}
		
		
		/// <summary>
		/// Second application defined value.
		/// </summary>
		public String ud1
		{
			get
			{
				return ud1Value;
			}
			set
			{
				this.ud1Value = value;
				setChangedMember(ActivityC.mbUd1);
			}
		}
		
		
		/// <summary>
		/// Third application defined value.
		/// </summary>
		public String ud2
		{
			get
			{
				return ud2Value;
			}
			set
			{
				this.ud2Value = value;
				setChangedMember(ActivityC.mbUd2);
			}
		}
		
		
		/// <summary>
		/// Fourth application defined value.
		/// </summary>
		public String ud3
		{
			get
			{
				return ud3Value;
			}
			set
			{
				this.ud3Value = value;
				setChangedMember(ActivityC.mbUd3);
			}
		}
		
		
		/// <summary>
		/// Fifth application defined value.
		/// </summary>
		public String ud4
		{
			get
			{
				return ud4Value;
			}
			set
			{
				this.ud4Value = value;
				setChangedMember(ActivityC.mbUd4);
			}
		}
		
		
		/// <summary>
		/// Sixth application defined value.
		/// </summary>
		public String ud5
		{
			get
			{
				return ud5Value;
			}
			set
			{
				this.ud5Value = value;
				setChangedMember(ActivityC.mbUd5);
			}
		}
		
		
		/// <summary>
		/// Seventh application defined value.
		/// </summary>
		public String ud6
		{
			get
			{
				return ud6Value;
			}
			set
			{
				this.ud6Value = value;
				setChangedMember(ActivityC.mbUd6);
			}
		}
		
		
		/// <summary>
		/// Eighth application defined value.
		/// </summary>
		public String ud7
		{
			get
			{
				return ud7Value;
			}
			set
			{
				this.ud7Value = value;
				setChangedMember(ActivityC.mbUd7);
			}
		}
		
		
		/// <summary>
		/// Ninth application defined value.
		/// </summary>
		public String ud8
		{
			get
			{
				return ud8Value;
			}
			set
			{
				this.ud8Value = value;
				setChangedMember(ActivityC.mbUd8);
			}
		}
		
		
		/// <summary>
		/// Tenth application defined value.
		/// </summary>
		public String ud9
		{
			get
			{
				return ud9Value;
			}
			set
			{
				this.ud9Value = value;
				setChangedMember(ActivityC.mbUd9);
			}
		}
		
		
		/// <summary>
		/// Activity was created for this user.
		/// </summary>
		/// <remarks>
		/// Readonly.
		/// </remarks>
		public String receiverName
		{
			get
			{
				return receiverNameValue;
			}
			set
			{
				this.receiverNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Activity was created by this user.
		/// </summary>
		/// <remarks>
		/// Readonly.
		/// </remarks>
		public String senderName
		{
			get
			{
				return senderNameValue;
			}
			set
			{
				this.senderNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Application defined value.
		/// </summary>
		public String transId
		{
			get
			{
				return transIdValue;
			}
			set
			{
				this.transIdValue = value;
				setChangedMember(ActivityC.mbTransId);
			}
		}
		
		
		/// <summary>
		/// Object ID of the associated folder or document.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(ActivityC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Object type of the associated folder or document.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int objType
		{
			get
			{
				return objTypeValue;
			}
			set
			{
				this.objTypeValue = value;
				setChangedMember(ActivityC.mbObjType);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(ActivityC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String TStampValue;

		protected String backAtValue;

		protected String backModeValue;

		protected String commentValue;

		protected String destinationValue;

		protected String dueDateIsoValue;

		protected String fileNameValue;

		protected String guidValue;

		protected String nameValue;

		protected String objGuidValue;

		protected int prioValue;

		protected String projectValue;

		protected int receiverIdValue;

		protected String revVersValue;

		protected int senderIdValue;

		protected String sentAtIsoValue;

		protected String sentModeValue;

		protected String ud0Value;

		protected String ud1Value;

		protected String ud2Value;

		protected String ud3Value;

		protected String ud4Value;

		protected String ud5Value;

		protected String ud6Value;

		protected String ud7Value;

		protected String ud8Value;

		protected String ud9Value;

		protected String receiverNameValue;

		protected String senderNameValue;

		protected String transIdValue;

		protected int objIdValue;

		protected int objTypeValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 460199434L;		
	} // end class
}  // end namespace

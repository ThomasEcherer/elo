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
	/// This class specifies constraints for
	/// the API function {@link IXServicePortIF#findFirstActivities(ClientInfo, FindActivityInfo, int, ActivityZ)}.
	/// </summary>
	/// <remarks>
	/// <p>
	/// By default, the members of this class are combined by AND.
	/// If {@link #senderOrReceiver} is set, senderId and receiverId are combined by OR.
	/// </p><p>
	/// If neither senderId nor receiverId is set, the function findFirstActivities collects all activities
	/// that can be read by the current session.
	/// </p>
	/// </remarks>
	public class FindActivityInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindActivityInfo() {
		}		
		
		public FindActivityInfo(String @objId, String @senderId, String @receiverId, bool @senderOrReceiver, bool @inclGroup, bool @inclDeputy, bool @inclDeleted) {
			this.objIdValue = @objId;
			this.senderIdValue = @senderId;
			this.receiverIdValue = @receiverId;
			this.senderOrReceiverValue = @senderOrReceiver;
			this.inclGroupValue = @inclGroup;
			this.inclDeputyValue = @inclDeputy;
			this.inclDeletedValue = @inclDeleted;
		}		
		
		public FindActivityInfo(FindActivityInfo rhs) : base(rhs)
		{
			this.objIdValue = rhs.objIdValue;
			this.senderIdValue = rhs.senderIdValue;
			this.receiverIdValue = rhs.receiverIdValue;
			this.senderOrReceiverValue = rhs.senderOrReceiverValue;
			this.inclGroupValue = rhs.inclGroupValue;
			this.inclDeputyValue = rhs.inclDeputyValue;
			this.inclDeletedValue = rhs.inclDeletedValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Find by object ID.
		/// </summary>
		/// <remarks>
		/// Find activities assigned to this object.
		/// Optional.
		/// </remarks>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find activities created by this user.
		/// </summary>
		/// <remarks>
		/// Can be set to a user ID, user GUID or user name.
		/// Optional.
		/// </remarks>
		public String senderId
		{
			get
			{
				return senderIdValue;
			}
			set
			{
				this.senderIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find activities created for this receiver.
		/// </summary>
		/// <remarks>
		/// Can be set to a user ID, user GUID or user name.
		/// Optional.
		/// </remarks>
		public String receiverId
		{
			get
			{
				return receiverIdValue;
			}
			set
			{
				this.receiverIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for sender or receiver.
		/// </summary>
		/// <remarks>
		/// Combine the senderId and receiverId by logical OR operation.
		/// </remarks>
		public bool senderOrReceiver
		{
			get
			{
				return senderOrReceiverValue;
			}
			set
			{
				this.senderOrReceiverValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for all groups of sender and receiver too.
		/// </summary>
		public bool inclGroup
		{
			get
			{
				return inclGroupValue;
			}
			set
			{
				this.inclGroupValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for the activities of the deputized users too.
		/// </summary>
		public bool inclDeputy
		{
			get
			{
				return inclDeputyValue;
			}
			set
			{
				this.inclDeputyValue = value;
			}
		}
		
		
		/// <summary>
		/// Find activities for deleted folders and documents too.
		/// </summary>
		public bool inclDeleted
		{
			get
			{
				return inclDeletedValue;
			}
			set
			{
				this.inclDeletedValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String objIdValue;

		protected String senderIdValue;

		protected String receiverIdValue;

		protected bool senderOrReceiverValue;

		protected bool inclGroupValue;

		protected bool inclDeputyValue;

		protected bool inclDeletedValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1456865464L;		
	} // end class
}  // end namespace

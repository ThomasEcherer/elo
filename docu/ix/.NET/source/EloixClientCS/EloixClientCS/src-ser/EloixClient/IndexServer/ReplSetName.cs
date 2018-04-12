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
	/// Properties of a replication set.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ReplSetName : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReplSetName() {
		}		
		
		public ReplSetName(String @TStamp, String @desc, int @id, int @image, int @mobile, String @name, String @TStampSync, int @priority) {
			this.TStampValue = @TStamp;
			this.descValue = @desc;
			this.idValue = @id;
			this.imageValue = @image;
			this.mobileValue = @mobile;
			this.nameValue = @name;
			this.TStampSyncValue = @TStampSync;
			this.priorityValue = @priority;
		}		
		
		public ReplSetName(ReplSetName rhs) : base(rhs)
		{
			this.TStampValue = rhs.TStampValue;
			this.descValue = rhs.descValue;
			this.idValue = rhs.idValue;
			this.imageValue = rhs.imageValue;
			this.mobileValue = rhs.mobileValue;
			this.nameValue = rhs.nameValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
			this.priorityValue = rhs.priorityValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Timestamp of the last change.
		/// </summary>
		/// <remarks>
		/// The format is JJJJ.MM.DD.hh.mm.ss
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
				setChangedMember(ReplSetNameC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Descriptive text for the replication set.
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
				setChangedMember(ReplSetNameC.mbDesc);
			}
		}
		
		
		/// <summary>
		/// Identifier for the replication set.
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
				setChangedMember(ReplSetNameC.mbId);
			}
		}
		
		
		/// <summary>
		/// Image used for the replication set in list function in the client application.
		/// </summary>
		public int image
		{
			get
			{
				return imageValue;
			}
			set
			{
				this.imageValue = value;
				setChangedMember(ReplSetNameC.mbImage);
			}
		}
		
		
		/// <summary>
		/// Replication set is used for archive synchronisation(ELO MOBIL).
		/// </summary>
		public int mobile
		{
			get
			{
				return mobileValue;
			}
			set
			{
				this.mobileValue = value;
				setChangedMember(ReplSetNameC.mbMobile);
			}
		}
		
		
		/// <summary>
		/// Name of the replication set.
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
				setChangedMember(ReplSetNameC.mbName);
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
				setChangedMember(ReplSetNameC.mbTStampSync);
			}
		}
		
		
		/// <summary>
		/// Priority of this replication set.
		/// </summary>
		public int priority
		{
			get
			{
				return priorityValue;
			}
			set
			{
				this.priorityValue = value;
				setChangedMember(ReplSetNameC.mbPriority);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String TStampValue;

		protected String descValue;

		protected int idValue;

		protected int imageValue;

		protected int mobileValue;

		protected String nameValue;

		protected String TStampSyncValue;

		protected int priorityValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 755067340L;		
	} // end class
}  // end namespace

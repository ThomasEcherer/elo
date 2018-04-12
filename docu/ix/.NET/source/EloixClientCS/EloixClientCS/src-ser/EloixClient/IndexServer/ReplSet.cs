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
	/// <p>Objects of this class store the replication information of archive entries.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ReplSet : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReplSet() {
		}		
		
		public ReplSet(int[] @dw, int @objId, String @TStamp, String @TStampSync) {
			this.dwValue = @dw;
			this.objIdValue = @objId;
			this.TStampValue = @TStamp;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public ReplSet(ReplSet rhs) : base(rhs)
		{
			this.dwValue = rhs.dwValue;
			this.objIdValue = rhs.objIdValue;
			this.TStampValue = rhs.TStampValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset of replication IDs.
		/// </summary>
		public int[] dw
		{
			get
			{
				return dwValue;
			}
			set
			{
				this.dwValue = value;
			}
		}
		
		
		/// <summary>
		/// This replication information belongs to the archive entry with ID <code>objId</code>
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
			}
		}
		
		
		/// <summary>
		/// Timestamp of the last alteration of replication sets for the corresponding
		/// archive entry.
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
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int[] dwValue;

		protected int objIdValue;

		protected String TStampValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1124529321L;		
	} // end class
}  // end namespace

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
	/// Alerts are messages shown in the alert tab of ELO client.
	/// </summary>
	public class Alert : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Alert() {
		}		
		
		public Alert(int @dest, String @destName, int @source, String @sourceName, int @type, int @objId, int @extra1, int @extra2, String @memo, int @time, String @timeIso) {
			this.destValue = @dest;
			this.destNameValue = @destName;
			this.sourceValue = @source;
			this.sourceNameValue = @sourceName;
			this.typeValue = @type;
			this.objIdValue = @objId;
			this.extra1Value = @extra1;
			this.extra2Value = @extra2;
			this.memoValue = @memo;
			this.timeValue = @time;
			this.timeIsoValue = @timeIso;
		}		
		
		public Alert(Alert rhs) : base(rhs)
		{
			this.destValue = rhs.destValue;
			this.destNameValue = rhs.destNameValue;
			this.sourceValue = rhs.sourceValue;
			this.sourceNameValue = rhs.sourceNameValue;
			this.typeValue = rhs.typeValue;
			this.objIdValue = rhs.objIdValue;
			this.extra1Value = rhs.extra1Value;
			this.extra2Value = rhs.extra2Value;
			this.memoValue = rhs.memoValue;
			this.timeValue = rhs.timeValue;
			this.timeIsoValue = rhs.timeIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int dest
		{
			get
			{
				return destValue;
			}
			set
			{
				this.destValue = value;
				setChangedMember(AlertC.mbDest);
			}
		}
		
		
		/// <summary>
		/// User name of the recipient.
		/// </summary>
		public String destName
		{
			get
			{
				return destNameValue;
			}
			set
			{
				this.destNameValue = value;
			}
		}
		
		
		/// <summary>
		/// User ID of the sender.
		/// </summary>
		/// <remarks>
		/// DB column: source
		/// </remarks>
		public int source
		{
			get
			{
				return sourceValue;
			}
			set
			{
				this.sourceValue = value;
				setChangedMember(AlertC.mbSource);
			}
		}
		
		
		/// <summary>
		/// User name of the sender.
		/// </summary>
		public String sourceName
		{
			get
			{
				return sourceNameValue;
			}
			set
			{
				this.sourceNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Alert type.
		/// </summary>
		/// <remarks>
		/// DB column: alerttype
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(AlertC.mbType);
			}
		}
		
		
		/// <summary>
		/// Object ID.
		/// </summary>
		/// <remarks>
		/// DB column: objid
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
				setChangedMember(AlertC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Extra data 1.
		/// </summary>
		/// <remarks>
		/// DB column: extra1
		/// </remarks>
		public int extra1
		{
			get
			{
				return extra1Value;
			}
			set
			{
				this.extra1Value = value;
				setChangedMember(AlertC.mbExtra1);
			}
		}
		
		
		/// <summary>
		/// Extra data 2.
		/// </summary>
		/// <remarks>
		/// DB column: extra2
		/// </remarks>
		public int extra2
		{
			get
			{
				return extra2Value;
			}
			set
			{
				this.extra2Value = value;
				setChangedMember(AlertC.mbExtra2);
			}
		}
		
		
		/// <summary>
		/// Comment text.
		/// </summary>
		/// <remarks>
		/// DB column: alertmemo
		/// </remarks>
		public String memo
		{
			get
			{
				return memoValue;
			}
			set
			{
				this.memoValue = value;
				setChangedMember(AlertC.mbMemo);
			}
		}
		
		
		/// <summary>
		/// Date and time when the alert was created.
		/// </summary>
		/// <remarks>
		/// DB column: alerttime
		/// </remarks>
		public int time
		{
			get
			{
				return timeValue;
			}
			set
			{
				this.timeValue = value;
				setChangedMember(AlertC.mbTime);
			}
		}
		
		
		/// <summary>
		/// ISO date when the alert was created.
		/// </summary>
		/// <remarks>
		/// Timezone is related to ClientInfo.timezone.
		/// </remarks>
		public String timeIso
		{
			get
			{
				return timeIsoValue;
			}
			set
			{
				this.timeIsoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int destValue;

		protected String destNameValue;

		protected int sourceValue;

		protected String sourceNameValue;

		protected int typeValue;

		protected int objIdValue;

		protected int extra1Value;

		protected int extra2Value;

		protected String memoValue;

		protected int timeValue;

		protected String timeIsoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 280775671L;		
	} // end class
}  // end namespace

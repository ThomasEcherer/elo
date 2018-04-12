//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// <p>Bit constants for members of ActionHistory</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ActionHistDataC : BSerializable
	{
	
		#region Constructors
		
		public ActionHistDataC() {
		}		
		
		public ActionHistDataC(int @lnActionGuid, int @lnCreateDateIso, int @lnText) {
			this.lnActionGuidValue = @lnActionGuid;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
			this.lnTextValue = @lnText;
		}		
		
		public ActionHistDataC(ActionHistDataC rhs)
		{
			this.lnActionGuidValue = rhs.lnActionGuidValue;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
			this.lnTextValue = rhs.lnTextValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Action GUID.
		/// </summary>
		/// <remarks>
		/// DB column: actionguid
		/// </remarks>
		public int lnActionGuid
		{
			get
			{
				return lnActionGuidValue;
			}
			set
			{
				this.lnActionGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public int lnCreateDateIso
		{
			get
			{
				return lnCreateDateIsoValue;
			}
			set
			{
				this.lnCreateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Comment text.
		/// </summary>
		/// <remarks>
		/// DB column: actiontext
		/// </remarks>
		public int lnText
		{
			get
			{
				return lnTextValue;
			}
			set
			{
				this.lnTextValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Action GUID.
		/// </summary>
		/// <remarks>
		/// DB column: actionguid
		/// </remarks>
		public const long mbActionGuid = 1L;

		protected int lnActionGuidValue;

		/// <summary>
		/// Member bit: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public const long mbCreateDateIso = 2L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// Member bit: Comment text.
		/// </summary>
		/// <remarks>
		/// DB column: actiontext
		/// </remarks>
		public const long mbText = 4L;

		protected int lnTextValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 734763371L;		
	} // end class
}  // end namespace

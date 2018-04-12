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
	/// <p>Bit constants for members of SordHist</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ObjHistC : BSerializable
	{
	
		#region Constructors
		
		public ObjHistC() {
		}		
		
		public ObjHistC(int @lnHistGuid, int @lnTimeStampUTC, int @lnObjGuid, int @lnUserName, int @lnTimeStampLocal, int @lnWorkStation) {
			this.lnHistGuidValue = @lnHistGuid;
			this.lnTimeStampUTCValue = @lnTimeStampUTC;
			this.lnObjGuidValue = @lnObjGuid;
			this.lnUserNameValue = @lnUserName;
			this.lnTimeStampLocalValue = @lnTimeStampLocal;
			this.lnWorkStationValue = @lnWorkStation;
		}		
		
		public ObjHistC(ObjHistC rhs)
		{
			this.lnHistGuidValue = rhs.lnHistGuidValue;
			this.lnTimeStampUTCValue = rhs.lnTimeStampUTCValue;
			this.lnObjGuidValue = rhs.lnObjGuidValue;
			this.lnUserNameValue = rhs.lnUserNameValue;
			this.lnTimeStampLocalValue = rhs.lnTimeStampLocalValue;
			this.lnWorkStationValue = rhs.lnWorkStationValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Serialisation version ID
		/// DB column: objhistguid
		/// </summary>
		public int lnHistGuid
		{
			get
			{
				return lnHistGuidValue;
			}
			set
			{
				this.lnHistGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objhistts
		/// </summary>
		public int lnTimeStampUTC
		{
			get
			{
				return lnTimeStampUTCValue;
			}
			set
			{
				this.lnTimeStampUTCValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objguid
		/// </summary>
		public int lnObjGuid
		{
			get
			{
				return lnObjGuidValue;
			}
			set
			{
				this.lnObjGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: username
		/// </summary>
		public int lnUserName
		{
			get
			{
				return lnUserNameValue;
			}
			set
			{
				this.lnUserNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objhistlocts
		/// </summary>
		public int lnTimeStampLocal
		{
			get
			{
				return lnTimeStampLocalValue;
			}
			set
			{
				this.lnTimeStampLocalValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objhistwks
		/// </summary>
		public int lnWorkStation
		{
			get
			{
				return lnWorkStationValue;
			}
			set
			{
				this.lnWorkStationValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Serialisation version ID
		/// DB column: objhistguid
		/// </summary>
		public const long mbHistGuid = 1L;

		protected int lnHistGuidValue;

		/// <summary>
		/// DB column: objhistts
		/// </summary>
		public const long mbTimeStampUTC = 2L;

		protected int lnTimeStampUTCValue;

		/// <summary>
		/// DB column: objguid
		/// </summary>
		public const long mbObjGuid = 4L;

		protected int lnObjGuidValue;

		/// <summary>
		/// DB column: objuser
		/// </summary>
		public const long mbUserNo = 8L;

		/// <summary>
		/// DB column: username
		/// </summary>
		public const long mbUserName = 16L;

		protected int lnUserNameValue;

		/// <summary>
		/// DB column: objhistsrc
		/// </summary>
		public const long mbHistSource = 32L;

		/// <summary>
		/// DB column: objhistlocts
		/// </summary>
		public const long mbTimeStampLocal = 64L;

		protected int lnTimeStampLocalValue;

		/// <summary>
		/// DB column: objhistwks
		/// </summary>
		public const long mbWorkStation = 128L;

		protected int lnWorkStationValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 255L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1015803641L;		
	} // end class
}  // end namespace

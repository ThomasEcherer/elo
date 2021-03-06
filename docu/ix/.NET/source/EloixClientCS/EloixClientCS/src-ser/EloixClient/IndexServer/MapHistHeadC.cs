﻿//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// <p>Bit constants for members of MapHist</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class MapHistHeadC : BSerializable
	{
	
		#region Constructors
		
		public MapHistHeadC() {
		}		
		
		public MapHistHeadC(int @lnHistGuid, int @lnTimeStampUTC, int @lnMapGuid, int @lnUserName, int @lnTimeStampLocal, int @lnWorkStation) {
			this.lnHistGuidValue = @lnHistGuid;
			this.lnTimeStampUTCValue = @lnTimeStampUTC;
			this.lnMapGuidValue = @lnMapGuid;
			this.lnUserNameValue = @lnUserName;
			this.lnTimeStampLocalValue = @lnTimeStampLocal;
			this.lnWorkStationValue = @lnWorkStation;
		}		
		
		public MapHistHeadC(MapHistHeadC rhs)
		{
			this.lnHistGuidValue = rhs.lnHistGuidValue;
			this.lnTimeStampUTCValue = rhs.lnTimeStampUTCValue;
			this.lnMapGuidValue = rhs.lnMapGuidValue;
			this.lnUserNameValue = rhs.lnUserNameValue;
			this.lnTimeStampLocalValue = rhs.lnTimeStampLocalValue;
			this.lnWorkStationValue = rhs.lnWorkStationValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Serialisation version ID
		/// DB column: maphistguid
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
		/// DB column: maphistts
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
		/// DB column: mapguid
		/// </summary>
		public int lnMapGuid
		{
			get
			{
				return lnMapGuidValue;
			}
			set
			{
				this.lnMapGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: mapusername
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
		/// DB column: maphistlocts
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
		/// DB column: maphistwks
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
		/// DB column: maphistguid
		/// </summary>
		public const long mbHistGuid = 1L;

		protected int lnHistGuidValue;

		/// <summary>
		/// DB column: maphistts
		/// </summary>
		public const long mbTimeStampUTC = 2L;

		protected int lnTimeStampUTCValue;

		/// <summary>
		/// DB column: mapguid
		/// </summary>
		public const long mbMapGuid = 4L;

		protected int lnMapGuidValue;

		/// <summary>
		/// DB column: mapuser
		/// </summary>
		public const long mbUserId = 8L;

		/// <summary>
		/// DB column: mapusername
		/// </summary>
		public const long mbUserName = 16L;

		protected int lnUserNameValue;

		/// <summary>
		/// DB column: maphistsrc
		/// </summary>
		public const long mbHistSource = 32L;

		/// <summary>
		/// DB column: maphistlocts
		/// </summary>
		public const long mbTimeStampLocal = 64L;

		protected int lnTimeStampLocalValue;

		/// <summary>
		/// DB column: maphistwks
		/// </summary>
		public const long mbWorkStation = 128L;

		protected int lnWorkStationValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 255L;

		#endregion
		
		
		public static readonly long serialVersionUID = 812099209L;		
	} // end class
}  // end namespace

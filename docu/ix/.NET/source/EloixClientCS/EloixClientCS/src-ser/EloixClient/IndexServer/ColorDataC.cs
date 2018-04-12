//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class ColorDataC : EloixClient.IndexServer.ColorDataInternC, BSerializable
	{
	
		#region Constructors
		
		public ColorDataC() {
		}		
		
		public ColorDataC(String @GUID_SYSTEM, String @GUID_RED, String @GUID_GREEN, String @GUID_BLUE) {
			this.GUID_SYSTEMValue = @GUID_SYSTEM;
			this.GUID_REDValue = @GUID_RED;
			this.GUID_GREENValue = @GUID_GREEN;
			this.GUID_BLUEValue = @GUID_BLUE;
		}		
		
		public ColorDataC(ColorDataC rhs) : base(rhs)
		{
			this.GUID_SYSTEMValue = rhs.GUID_SYSTEMValue;
			this.GUID_REDValue = rhs.GUID_REDValue;
			this.GUID_GREENValue = rhs.GUID_GREENValue;
			this.GUID_BLUEValue = rhs.GUID_BLUEValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// System color
		/// </summary>
		public String GUID_SYSTEM
		{
			get
			{
				return GUID_SYSTEMValue;
			}
			set
			{
				this.GUID_SYSTEMValue = value;
			}
		}
		
		
		/// <summary>
		/// Color red
		/// </summary>
		public String GUID_RED
		{
			get
			{
				return GUID_REDValue;
			}
			set
			{
				this.GUID_REDValue = value;
			}
		}
		
		
		/// <summary>
		/// Color green
		/// </summary>
		public String GUID_GREEN
		{
			get
			{
				return GUID_GREENValue;
			}
			set
			{
				this.GUID_GREENValue = value;
			}
		}
		
		
		/// <summary>
		/// Color blue
		/// </summary>
		public String GUID_BLUE
		{
			get
			{
				return GUID_BLUEValue;
			}
			set
			{
				this.GUID_BLUEValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String GUID_SYSTEMValue;

		protected String GUID_REDValue;

		protected String GUID_GREENValue;

		protected String GUID_BLUEValue;

		public const long mbDeleted = 8L;

		#endregion
		
		
		public static readonly new long serialVersionUID = 881975137L;		
	} // end class
}  // end namespace

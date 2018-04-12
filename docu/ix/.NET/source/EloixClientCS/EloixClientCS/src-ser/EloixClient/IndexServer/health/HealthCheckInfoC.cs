//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	/// <summary>
	/// <p>Bit constants for members of HealthCheckInfo</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class HealthCheckInfoC : BSerializable
	{
	
		#region Constructors
		
		public HealthCheckInfoC() {
		}		
		
		public HealthCheckInfoC(int @lnName, int @lnStringValue, int @lnDoubleValue, int @lnSampleSize) {
			this.lnNameValue = @lnName;
			this.lnStringValueValue = @lnStringValue;
			this.lnDoubleValueValue = @lnDoubleValue;
			this.lnSampleSizeValue = @lnSampleSize;
		}		
		
		public HealthCheckInfoC(HealthCheckInfoC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnStringValueValue = rhs.lnStringValueValue;
			this.lnDoubleValueValue = rhs.lnDoubleValueValue;
			this.lnSampleSizeValue = rhs.lnSampleSizeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Value name.
		/// </summary>
		/// <remarks>
		/// DB column: name
		/// </remarks>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: String value.
		/// </summary>
		/// <remarks>
		/// DB column: stringValue
		/// </remarks>
		public int lnStringValue
		{
			get
			{
				return lnStringValueValue;
			}
			set
			{
				this.lnStringValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Numeric value.
		/// </summary>
		/// <remarks>
		/// DB column: doubleValue
		/// </remarks>
		public int lnDoubleValue
		{
			get
			{
				return lnDoubleValueValue;
			}
			set
			{
				this.lnDoubleValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Sample size for mean values.
		/// </summary>
		/// <remarks>
		/// DB column: sampleSize
		/// </remarks>
		public int lnSampleSize
		{
			get
			{
				return lnSampleSizeValue;
			}
			set
			{
				this.lnSampleSizeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Value name.
		/// </summary>
		/// <remarks>
		/// DB column: name
		/// </remarks>
		public const long mbName = 1L;

		protected int lnNameValue;

		/// <summary>
		/// Member bit: String value.
		/// </summary>
		/// <remarks>
		/// DB column: stringValue
		/// </remarks>
		public const long mbStringValue = 2L;

		protected int lnStringValueValue;

		/// <summary>
		/// Member bit: Numeric value.
		/// </summary>
		/// <remarks>
		/// DB column: doubleValue
		/// </remarks>
		public const long mbDoubleValue = 4L;

		protected int lnDoubleValueValue;

		/// <summary>
		/// Member bit: Sample size for mean values.
		/// </summary>
		/// <remarks>
		/// DB column: sampleSize
		/// </remarks>
		public const long mbSampleSize = 8L;

		protected int lnSampleSizeValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 15L;

		#endregion
		
		
		public static readonly long serialVersionUID = 526645641L;		
	} // end class
}  // end namespace

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
	/// This class represents one value for health check evaluation.
	/// </summary>
	public class HealthCheckInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public HealthCheckInfo() {
		}		
		
		public HealthCheckInfo(String @name, String @stringValue, double @doubleValue, long @sampleSize, EloixClient.IndexServer.health.HealthCheckValueOperation @operation) {
			this.nameValue = @name;
			this.stringValueValue = @stringValue;
			this.doubleValueValue = @doubleValue;
			this.sampleSizeValue = @sampleSize;
			this.operationValue = @operation;
		}		
		
		public HealthCheckInfo(HealthCheckInfo rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.stringValueValue = rhs.stringValueValue;
			this.doubleValueValue = rhs.doubleValueValue;
			this.sampleSizeValue = rhs.sampleSizeValue;
			this.operationValue = rhs.operationValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Value name.
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
				setChangedMember(HealthCheckInfoC.mbName);
			}
		}
		
		
		/// <summary>
		/// String value.
		/// </summary>
		/// <remarks>
		/// Either this or {@link #doubleValue} has to be set.
		/// </remarks>
		public String stringValue
		{
			get
			{
				return stringValueValue;
			}
			set
			{
				this.stringValueValue = value;
				setChangedMember(HealthCheckInfoC.mbStringValue);
			}
		}
		
		
		/// <summary>
		/// Numeric value.
		/// </summary>
		/// <remarks>
		/// Either this value or {@link #stringValue} has to be set.
		/// </remarks>
		public double doubleValue
		{
			get
			{
				return doubleValueValue;
			}
			set
			{
				this.doubleValueValue = value;
				setChangedMember(HealthCheckInfoC.mbDoubleValue);
			}
		}
		
		
		/// <summary>
		/// Sample size for mean values.
		/// </summary>
		/// <remarks>
		/// If {@link #doubleValue} is a arithmetic mean, this value gives the
		/// number of the underlying samples.
		/// If {@link #stringValue} is set, this value has to be 0.
		/// </remarks>
		public long sampleSize
		{
			get
			{
				return sampleSizeValue;
			}
			set
			{
				this.sampleSizeValue = value;
				setChangedMember(HealthCheckInfoC.mbSampleSize);
			}
		}
		
		
		/// <summary>
		/// Operation to process when updating the value.
		/// </summary>
		public EloixClient.IndexServer.health.HealthCheckValueOperation operation
		{
			get
			{
				return operationValue;
			}
			set
			{
				this.operationValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected String stringValueValue;

		protected double doubleValueValue;

		protected long sampleSizeValue;

		protected EloixClient.IndexServer.health.HealthCheckValueOperation operationValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 585951890L;		
	} // end class
}  // end namespace

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
	/// License information to be checked with {@link IXServicePortIF#checkLicense(ClientInfo, LicenseInfo)}.
	/// </summary>
	public class LicenseInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public LicenseInfo() {
		}		
		
		public LicenseInfo(String @customerName, String @moduleName, String @licenseKey) {
			this.customerNameValue = @customerName;
			this.moduleNameValue = @moduleName;
			this.licenseKeyValue = @licenseKey;
		}		
		
		public LicenseInfo(LicenseInfo rhs) : base(rhs)
		{
			this.customerNameValue = rhs.customerNameValue;
			this.moduleNameValue = rhs.moduleNameValue;
			this.licenseKeyValue = rhs.licenseKeyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Customer name.
		/// </summary>
		public String customerName
		{
			get
			{
				return customerNameValue;
			}
			set
			{
				this.customerNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Module name.
		/// </summary>
		public String moduleName
		{
			get
			{
				return moduleNameValue;
			}
			set
			{
				this.moduleNameValue = value;
			}
		}
		
		
		/// <summary>
		/// License key.
		/// </summary>
		public String licenseKey
		{
			get
			{
				return licenseKeyValue;
			}
			set
			{
				this.licenseKeyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String customerNameValue;

		protected String moduleNameValue;

		protected String licenseKeyValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2024296158L;		
	} // end class
}  // end namespace

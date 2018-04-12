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
	/// This class holds the values for health check evaluation.
	/// </summary>
	public class HealthCheckInfos : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public HealthCheckInfos() {
		}		
		
		public HealthCheckInfos(IList<EloixClient.IndexServer.health.HealthCheckInfo> @infos, String @archiveGuid, String @customerLicenseKeyHash) {
			this.infosValue = @infos;
			this.archiveGuidValue = @archiveGuid;
			this.customerLicenseKeyHashValue = @customerLicenseKeyHash;
		}		
		
		public HealthCheckInfos(HealthCheckInfos rhs) : base(rhs)
		{
			this.infosValue = rhs.infosValue;
			this.archiveGuidValue = rhs.archiveGuidValue;
			this.customerLicenseKeyHashValue = rhs.customerLicenseKeyHashValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Health check data.
		/// </summary>
		/// <remarks>
		/// If returned from {@link HealthCheckService#read(de.elo.ix.client.ClientInfo, List)},
		/// this list is sorted by {@link HealthCheckInfo#getName()}.
		/// </remarks>
		public IList<EloixClient.IndexServer.health.HealthCheckInfo> infos
		{
			get
			{
				return infosValue;
			}
			set
			{
				this.infosValue = value;
			}
		}
		
		
		/// <summary>
		/// Archive GUID.
		/// </summary>
		public String archiveGuid
		{
			get
			{
				return archiveGuidValue;
			}
			set
			{
				this.archiveGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// MD5 hash of license key.
		/// </summary>
		/// <remarks>
		/// The part of the license key used to compute this hash can be obtained by
		/// <code><pre>conn.getServerInfo().getLicense().getSerno();</pre></code>
		/// </remarks>
		public String customerLicenseKeyHash
		{
			get
			{
				return customerLicenseKeyHashValue;
			}
			set
			{
				this.customerLicenseKeyHashValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IList<EloixClient.IndexServer.health.HealthCheckInfo> infosValue;

		protected String archiveGuidValue;

		protected String customerLicenseKeyHashValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 333475674L;		
	} // end class
}  // end namespace

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	/// <summary>
	/// Functions for health check.
	/// </summary>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface HealthCheckServiceAuth : BRemote {
	
		/// <summary>
		/// Update arithmetic mean.
		/// </summary>
		/// <remarks>
		/// This function adds the given mean value to the
		/// already existing value in the database. The new value is computed as:
		/// (db-meanValue * db-sampleSize + meanValue * sampleSize) / (db-sampleSize +
		/// sampleSize).
		/// Example:
		/// <code><pre>
		/// IXConnection conn = ...
		/// double value = (1.1 + 1.2 + 1.3) / 3;
		/// conn.getHealthCheckService().updateMeanValue("valuename", 1.2, 3);
		/// </pre></code>
		/// </remarks>
		void updateMeanValue(String name, double meanValue, long sampleSize);
		void updateMeanValue(String name, double meanValue, long sampleSize, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Update one value.
		/// </summary>
		/// <remarks>
		/// This function overwrites an existing value.
		/// Example:
		/// <code><pre>
		/// IXConnection conn = ...
		/// conn.getHealthCheckService().updateDoubleValue("valuename", 1.2);
		/// </pre></code>
		/// </remarks>
		void updateDoubleValue(String name, double doubleValue);
		void updateDoubleValue(String name, double doubleValue, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Compute value.
		/// </summary>
		/// <remarks>
		/// This function computes a new value using the specified operation.
		/// Example:
		/// <code><pre>
		/// IXConnection conn = ...
		/// conn.getHealthCheckService().computeDoubleValue("valuename", 1.2, HealthCheckValueOperation.ADD);
		/// </pre></code>
		/// </remarks>
		void computeDoubleValue(String name, double doubleValue, EloixClient.IndexServer.health.HealthCheckValueOperation operation);
		void computeDoubleValue(String name, double doubleValue, EloixClient.IndexServer.health.HealthCheckValueOperation operation, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Update one value.
		/// </summary>
		/// <remarks>
		/// Example:
		/// <code><pre>
		/// IXConnection conn = ...
		/// HealthCheckInfo hci = new HealthCheckInfo();
		/// hci.setName("valuename");
		/// hci.setStringValue("string1");
		/// conn.getHealthCheckService().update(hci);
		/// </pre></code>
		/// </remarks>
		void update(EloixClient.IndexServer.health.HealthCheckInfo hci);
		void update(EloixClient.IndexServer.health.HealthCheckInfo hci, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Update given values.
		/// </summary>
		void updateAll(IList<EloixClient.IndexServer.health.HealthCheckInfo> hcis);
		void updateAll(IList<EloixClient.IndexServer.health.HealthCheckInfo> hcis, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Force uploading health check data to web service.
		/// </summary>
		/// <remarks>
		/// This function should only be used in test scenarios.
		/// Indexserver automatically uploads health check data one time per month.
		/// </remarks>
		Object uploadAll(Object reserved);
		void uploadAll(Object reserved, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Read given health check values.
		/// </summary>
		EloixClient.IndexServer.health.HealthCheckInfos read(IList<String> names);
		void read(IList<String> names, BAsyncResult<EloixClient.IndexServer.health.HealthCheckInfos> asyncResult) ;
		
		
	}
}  // end namespace

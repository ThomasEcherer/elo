using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface SystemInformation : BRemote {
	
		EloixClient.Indexserver.system.ArchivReport archivReport(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si);
		void archivReport(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.ArchivReport> asyncResult) ;
		
		EloixClient.Indexserver.system.SystemReport countDocsInStorePath(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si);
		void countDocsInStorePath(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.SystemReport> asyncResult) ;
		
		EloixClient.Indexserver.system.LicenseReport licenseReport(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si);
		void licenseReport(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.LicenseReport> asyncResult) ;
		
		EloixClient.Indexserver.system.UserReport userReport(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si);
		void userReport(EloixClient.IndexServer.ClientInfo ci, EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.UserReport> asyncResult) ;
		
		
	}
}  // end namespace

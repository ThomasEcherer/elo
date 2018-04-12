using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface SystemInformationAuth : BRemote {
	
		EloixClient.Indexserver.system.ArchivReport archivReport(EloixClient.Indexserver.system.SystemInfo si);
		void archivReport(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.ArchivReport> asyncResult) ;
		
		EloixClient.Indexserver.system.SystemReport countDocsInStorePath(EloixClient.Indexserver.system.SystemInfo si);
		void countDocsInStorePath(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.SystemReport> asyncResult) ;
		
		EloixClient.Indexserver.system.LicenseReport licenseReport(EloixClient.Indexserver.system.SystemInfo si);
		void licenseReport(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.LicenseReport> asyncResult) ;
		
		EloixClient.Indexserver.system.UserReport userReport(EloixClient.Indexserver.system.SystemInfo si);
		void userReport(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.UserReport> asyncResult) ;
		
		
	}
}  // end namespace

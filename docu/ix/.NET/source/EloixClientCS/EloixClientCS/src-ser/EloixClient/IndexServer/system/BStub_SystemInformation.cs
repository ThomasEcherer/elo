using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class BStub_SystemInformation : BStub, SystemInformationAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 708455930L;
		
		public BStub_SystemInformation(BTransport transport)
			: base(transport) {}			
		
		public virtual EloixClient.Indexserver.system.ArchivReport archivReport(EloixClient.Indexserver.system.SystemInfo si) {
			BSyncResult<EloixClient.Indexserver.system.ArchivReport> asyncResult = new BSyncResult<EloixClient.Indexserver.system.ArchivReport>();			
			archivReport(si, BAsyncResultHelper.ToDelegate<EloixClient.Indexserver.system.ArchivReport>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void archivReport(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.ArchivReport> asyncResult) {
			BRequest_SystemInformation_archivReport req = new BRequest_SystemInformation_archivReport();			
			req.siValue = si;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.Indexserver.system.SystemReport countDocsInStorePath(EloixClient.Indexserver.system.SystemInfo si) {
			BSyncResult<EloixClient.Indexserver.system.SystemReport> asyncResult = new BSyncResult<EloixClient.Indexserver.system.SystemReport>();			
			countDocsInStorePath(si, BAsyncResultHelper.ToDelegate<EloixClient.Indexserver.system.SystemReport>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void countDocsInStorePath(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.SystemReport> asyncResult) {
			BRequest_SystemInformation_countDocsInStorePath req = new BRequest_SystemInformation_countDocsInStorePath();			
			req.siValue = si;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.Indexserver.system.LicenseReport licenseReport(EloixClient.Indexserver.system.SystemInfo si) {
			BSyncResult<EloixClient.Indexserver.system.LicenseReport> asyncResult = new BSyncResult<EloixClient.Indexserver.system.LicenseReport>();			
			licenseReport(si, BAsyncResultHelper.ToDelegate<EloixClient.Indexserver.system.LicenseReport>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void licenseReport(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.LicenseReport> asyncResult) {
			BRequest_SystemInformation_licenseReport req = new BRequest_SystemInformation_licenseReport();			
			req.siValue = si;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.Indexserver.system.UserReport userReport(EloixClient.Indexserver.system.SystemInfo si) {
			BSyncResult<EloixClient.Indexserver.system.UserReport> asyncResult = new BSyncResult<EloixClient.Indexserver.system.UserReport>();			
			userReport(si, BAsyncResultHelper.ToDelegate<EloixClient.Indexserver.system.UserReport>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void userReport(EloixClient.Indexserver.system.SystemInfo si, BAsyncResult<EloixClient.Indexserver.system.UserReport> asyncResult) {
			BRequest_SystemInformation_userReport req = new BRequest_SystemInformation_userReport();			
			req.siValue = si;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}

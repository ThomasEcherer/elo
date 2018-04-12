using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Zusammenfassung für ViewAndEditSord.
	/// </summary>
	public class ViewAndEditSord
	{
		// URL to IndexServer
		public String url;

		// [X] Account to authenticate 
		public String userName = "Administrator"; 
		public String userPwd = "";					

		public void run()
		{
			IXConnFactory connFact = null;
			IXConnection ix = null;
			try 
			{
				IXProperties connProps = IXConnFactory.CreateConnProperties(url);
				IXProperties sessOpts = IXConnFactory.CreateSessionOptions("IX-Examples", "1.0");
				connFact = new IXConnFactory(connProps, sessOpts);
				Logger.instance().log("create IXConnFactory OK");

				// Prepare ClientInfo object with language and country
				// ClientInfo ci = new ClientInfo();
				// ci.language = "de";
				// ci.country = "DE";

				// LOGIN
				Logger.instance().log("login...");
				ix = connFact.Create(userName, userPwd, "myComputer", null);
				// ci = ix.Login.ci
				Logger.instance().log("login OK");

				// get constants
				Logger.instance().log("get const...");
				IXServicePortC CONST = ix.CONST;
				Logger.instance().log("get const OK");
		
				// Create a root folder based on keywording form "Email".
				// Parent is the "imaginary" archive entry with object ID = 1.
				String parentId = "1"; 
				String maskId = "email";   
				EditInfo ed = ix.Ix.createSord(parentId, maskId, EditInfoC.mbAll);
				ed.sord.name = "New Sord";

				ViewAndEditSordDlg dlg = new ViewAndEditSordDlg();
				dlg.init(ix, ed);
				dlg.ShowDialog(null);		

				// CHECKIN
				int objId = ix.Ix.checkinSord(dlg.getSord(), SordC.mbAll, LockC.NO);
				Logger.instance().log("Created sord successfully, objId=" + objId);

			} 
			catch (Exception e) 
			{
				throw e;
			} 
			finally 
			{
				// Logout
				// --
				if (ix != null) 
				{
					Logger.instance().log("IX logout...");
					ix.Logout();
					Logger.instance().log("IX logout OK");
				}
			}
		}
	}
}

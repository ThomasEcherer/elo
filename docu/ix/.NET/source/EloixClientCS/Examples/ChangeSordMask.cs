using System;
using EloixClient.IndexServer;

namespace Examples
{
	/// <summary>
	/// This Exemple shows the usage of changeSordMask
	/// </summary>
	public class ChangeSordMask
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
				connFact = new IXConnFactory(url, "IX-Examples", "1.0");
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
		
				// Create a root folder based on keywording form "Basic entry".
				// Parent is the "imaginary" archive entry with object ID = 1.
				String parentId = "1"; 
				String maskId = "";   
				EditInfo editInfo = ix.Ix.createSord(parentId, maskId, EditInfoC.mbSord);

				Logger.instance().log("created sord, GUID=" + editInfo.sord.guid);
				Logger.instance().log("name=" + editInfo.sord.name + ", #objKeys=" + editInfo.sord.objKeys.Length);

				// Change the storage mask to "Email"
				editInfo.sord.name = "C# change mask"; // to show, that attributes are not changed in changeSordMask
				editInfo = ix.Ix.changeSordMask(editInfo.sord, "Email", EditInfoC.mbSord);

				Logger.instance().log("created sord, GUID=" + editInfo.sord.guid + ", objId=" + editInfo.sord.id);
				Logger.instance().log("name=" + editInfo.sord.name + ", #objKeys=" + editInfo.sord.objKeys.Length);

				// Hint: The Sord object was not saved, neither by createSord nor changeSordMask.
				//       You have to call checkinSord to save it to the database.

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

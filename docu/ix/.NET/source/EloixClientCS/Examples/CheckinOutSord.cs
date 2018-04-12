using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Example shows the usage of checkinSord/checkoutSord.
	/// </summary>
	public class CheckinOutSord
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
				EditInfo editInfo = ix.Ix.createSord(parentId, maskId, EditInfoC.mbAll);
				
				// Hint: Supply the constant EditInfoC.mbAll to get not only the Sord object data
				//       but the storage mask data too.
				
				Logger.instance().log("prepared sord with GUID=" + editInfo.sord.guid);

				DocMask mask = editInfo.mask;
				Sord sord = editInfo.sord;

				// Set display name
				sord.name = "C# sord";

				// Set some index attributes
				for (int i = 0; i < mask.lines.Length; i++) 
				{
					DocMaskLine dml = mask.lines[i];
					if (dml.name.Equals("From") ||
						dml.key.Equals("ELOOUTL1")) // this line is just to make it work with all languages 
					{
						sord.objKeys[i].data = new String[] {"f.fritz@d-online.de"};
					} 
					else if (dml.name.Equals("To") ||
							 dml.key.Equals("ELOOUTL2")) // this line is just to make it work with all languages 
					{
						sord.objKeys[i].data = new String[] {"g.gustav@d-online.de"};
					}
				}

				// CHECKIN
				int objId = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
				Logger.instance().log("Created sord successfully, objId=" + objId);

				// CHECKOUT
				String strObjId = (String)Convert.ChangeType(objId, typeof(String));
				editInfo = ix.Ix.checkoutSord(strObjId, EditInfoC.mbSord, LockC.NO);
				sord = editInfo.sord;
				Logger.instance().log("Checkout sord successfully, GUID=" + sord.guid);
				Logger.instance().log("name=" + sord.name);
				for (int i = 0; i < sord.objKeys.Length; i++) 
				{
					ObjKey okey = sord.objKeys[i];
					if (okey.data.Length != 0) 
					{
						Logger.instance().log("okey, goup-name=" + okey.name + ", data=" + okey.data[0]);
					}
				}

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

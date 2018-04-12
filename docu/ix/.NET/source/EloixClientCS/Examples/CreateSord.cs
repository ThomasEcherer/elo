using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	/// Example shows usage of createSord.
	/// </summary>
	public class CreateSord
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
		
				// CREATE SORD
				// createSord does not create the new Sord object inside the database.
				// The purpose of this function is to initialize a new Sord object and
				// inherit ACL values and replication sets from the parent or 
				// storage mask.

				// 1.
				// Create a root folder based on keywording form "Basic entry".
				// Parent is the "imaginary" archive entry with object ID = 1.
				String parentId = "1"; 
				String maskId = "0";   // same as "" or "0"
				EditInfo editInfo = ix.Ix.createSord(parentId, maskId, EditInfoC.mbSord);

				Logger.instance().log("1. created sord, GUID=" + editInfo.sord.guid);

				// 2.
				// Create a folder inside the "Chaos Folder".
				// Hint: Chaos objects can only be retrieved by search. 
				//       They are not visible in the archive hirarchie.
				parentId = null;	   // same as "" or "0"
				maskId = "EMail";      
				editInfo = ix.Ix.createSord(parentId, maskId, EditInfoC.mbAll);

				Logger.instance().log("2. created sord, GUID=" + editInfo.sord.guid);

				// for each DocMaskLine in "EMail" there is an ObjKey in Sord.
				Logger.instance().log("sord: #index-lines=" + editInfo.sord.objKeys.Length);
				Logger.instance().log("mask: #index-lines=" + editInfo.mask.lines.Length);
				for (int i = 0; i < editInfo.mask.lines.Length; i++) {
					DocMaskLine dml = editInfo.mask.lines[i];
					ObjKey okey = editInfo.sord.objKeys[i];
					Logger.instance().log("label=" + dml.name + 
                                          ", group-name=" + okey.name +
										  ", #values=" + okey.data.Length);
				}

				// 3.
				// Create a root folder based on keywording form "Basic entry".
				// Parent is the "imaginary" archive entry with object ID = 1.
				//String parentId = "Sord GUID or ID";			// [x] put in any GUID or ID of an existing archive entry
				//String maskId = "keywording form name or ID";	// [X] put in any name or ID of an existing document mask, e. g. "Structure element", "EMail"
				//EditInfo editInfo = ix.Ix.createSord(parentId, maskId, EditInfoC.mbSord);

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

using System;
using System.Collections.Generic;
using System.Text;
using EloixClient.IndexServer;


namespace Examples
{
  class CheckinOutDocEncrypted
  {
		// URL to IndexServer
		public String url;

		// [X] Account to authenticate 
		public String userName = "Administrator"; 
		public String userPwd = "";

    /// <summary>
    /// Encryption set ID. 
    /// Must be in range 1...16
    /// </summary>
    public int encryptionSet = 13;

    /// <summary>
    /// External password for the encryption set.
    /// </summary>
    public String encryptionPassword = "elo";

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

        // Example for initializing an encryption set with a new internal password.
        // If you uncomment this lines, aready encrypted documents of this encryption set
        // cannot be decrypted anymore since the internal key is lost!
        // Logger.instance().log("init encryption set ...");
        //initializeNewEncryptionSet(ix, CONST, 13, "CS-TEST", encryptionPassword);
        // Logger.instance().log("init encryption set OK");

        // checkin example document and encrypt it
        string objId = checkinDocEncrypted(ix, CONST);

        // checkout example document
        checkoutDocDecryptedUsingSessionOption(ix, CONST, objId);

        // checkout example document
        checkoutDocDecryptedUsingUrlExt(ix, CONST, objId);

        bool cleanUp = true;
        if (cleanUp)
        {
          // Delete Document
          DeleteOptions delOpts = new DeleteOptions();
          delOpts.deleteFinally = true;
          ix.Ix.deleteSord(null, objId, LockC.NO, null);
          ix.Ix.deleteSord(null, objId, LockC.NO, delOpts);
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

    /// <summary>
    /// This function shows how to checkin a document using encryption functionality of  
    /// </summary>
    /// <param name="ix"></param>
    /// <param name="CONST"></param>
    /// <param name="ci"></param>
    /// <returns></returns>
    private string checkinDocEncrypted(IXConnection ix, IXServicePortC CONST)
    {
      // Tell IndexServer to encrypt/decrypt.
      setSessionOptionEncrypt(ix, true);

      // Provide external password of encryption set.
      // This password must be encrpyted for security reasons. 
      // Administrators should not know it!
      string encrPwd = ix.EncryptPassword(encryptionPassword);
      ix.Ix.provideCryptPassword("" + encryptionSet, encrPwd);

      // Create document 
      EditInfo ed = ix.Ix.createDoc("1", "0", null, EditInfoC.mbSordDoc);
      ed.sord.name = "C# example CheckinOutDocEncrypted";
      ed.sord.details.encryptionSet = encryptionSet;

      // Create file for document version
      String testFile = internalCreateTestFile("CheckinDocEncrypted example file", "txt");

      // Supply the extension of the document
      ed.document.docs = new DocVersion[1];
      ed.document.docs[0] = new DocVersion();
      ed.document.docs[0].ext = ix.GetFileExt(testFile);
      ed.document.docs[0].pathId = ed.sord.path;
      ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;

      // CheckinDocBegin: let IndexServer generate an URL to upload the document
      // This URL addresses always the IndexServer and not the Document Manager.
      ed.document = ix.Ix.checkinDocBegin(ed.document);

      // -------------------------------------------------------------------------------
      // The URL to upload the document should be a HTTPS URL in production environments!
      // IndexServer configuration option "ixUrlBase" might be helpful here.
      // -------------------------------------------------------------------------------

      Logger.instance().log("prepared upload URL=" + ed.document.docs[0].url + ", doc-guid=" + ed.document.docs[0].guid);

      // Upload document version.
      // IndexServer encrypts the document.
      ed.document.docs[0].uploadResult = ix.Upload(ed.document.docs[0].url, testFile);
      Logger.instance().log("upload document version succeeded");

      // CheckinDocEnd: uploadResult contains the document information from ELODM.
      // Pass this information to 
      ed.document = ix.Ix.checkinDocEnd(ed.sord, SordC.mbAll, ed.document, LockC.NO);
      Logger.instance().log("inserted document:");
      Logger.instance().log("  objId=" + ed.document.objId);
      Logger.instance().log("  docId=" + ed.document.docs[0].id);
      Logger.instance().log("  doc-guid=" + ed.document.docs[0].guid);
      Logger.instance().log("  URL=" + ed.document.docs[0].url);

      System.IO.File.Delete(testFile);

      return ed.document.objId;
    }

    /// <summary>
    /// This function shows how to checkout a document using encryption functionality of  
    /// It sets the session option ix.Ix.cryptDocuments which directs IX to generate URLs for decryption.
    /// IX provides the file extension and file size of the original document in the 
    /// DocVersion object. This requires an extra call to DM because the original size and
    /// extension is only available in the file header.
    /// The extra calls are also needed in findFirstSords/findNextSords. 
    /// </summary>
    /// <param name="ix"></param>
    /// <param name="CONST"></param>
    /// <param name="ci"></param>
    /// <param name="objId"></param>
    private void checkoutDocDecryptedUsingSessionOption(IXConnection ix, IXServicePortC CONST, string objId)
    {
      // Tell IndexServer to encrypt/decrypt.
      setSessionOptionEncrypt(ix, true);

      // Provide external password of encryption set.
      string encrPwd = ix.EncryptPassword(encryptionPassword);
      ix.Ix.provideCryptPassword("" + encryptionSet, encrPwd);

      EditInfo ed = ix.Ix.checkoutDoc(objId, null, EditInfoC.mbSordDoc, LockC.NO);
      Logger.instance().log("orginal.ext=" + ed.document.docs[0].ext);
      Logger.instance().log("original.size=" + ed.document.docs[0].size);
      String tempName2 = internalMakeTempFileName(ed.document.docs[0].ext);

      // -------------------------------------------------------------------------------
      // The URL to download the document should be a HTTPS URL in production environments!
      // IndexServer configuration option "ixUrlBase" might be helpful here.
      // -------------------------------------------------------------------------------

      Logger.instance().log("prepared download URL=" + ed.document.docs[0].url);

      ix.Download(ed.document.docs[0].url, tempName2);

      // Show document in notepad:
      System.Diagnostics.Process.Start("notepad.exe", tempName2);
      System.Threading.Thread.Sleep(3000);

      System.IO.File.Delete(tempName2);
    }

    /// <summary>
    /// This function shows how to checkout a document using encryption functionality of  
    /// It does not set the ix.Ix.cryptDocuments session option. It assigns "&crypt=true" 
    /// to the URL to direct IndexServer to decrypt the document. 
    /// Using this method does not require an extra call to DM. But the file size and file extension
    /// in the DocVersion object comes from the encrypted document (ETF-file) rather the 
    /// original document. 
    /// </summary>
    /// <param name="ix"></param>
    /// <param name="CONST"></param>
    /// <param name="ci"></param>
    /// <param name="objId"></param>
    private void checkoutDocDecryptedUsingUrlExt(IXConnection ix, IXServicePortC CONST, string objId)
    {
      // Tell IndexServer not to encrypt/decrypt.
      setSessionOptionEncrypt(ix, false);

      // Provide external password of encryption set.
      string encrPwd = ix.EncryptPassword(encryptionPassword);
      ix.Ix.provideCryptPassword("" + encryptionSet, encrPwd);

      EditInfo ed = ix.Ix.checkoutDoc(objId, null, EditInfoC.mbSordDoc, LockC.NO);
      Logger.instance().log("encrypted.ext=" + ed.document.docs[0].ext);
      Logger.instance().log("encrypted.size=" + ed.document.docs[0].size);
      String tempName2 = internalMakeTempFileName(".tmp");

      // append the special parameter to the URL
      String urlDecr = ed.document.docs[0].url + "&crypt=true";
      Logger.instance().log("prepared download URL=" + urlDecr);

      // -------------------------------------------------------------------------------
      // The URL to download the document should be a HTTPS URL in production environments!
      // IndexServer configuration option "ixUrlBase" might be helpful here.
      // -------------------------------------------------------------------------------

      ix.Download(urlDecr, tempName2);

      // Show document in notepad:
      System.Diagnostics.Process.Start("notepad.exe", tempName2);
      System.Threading.Thread.Sleep(3000);

      System.IO.File.Delete(tempName2);
    }

    /// <summary>
    /// This function tells IndexServer to encrypt or decrypt documents that are 
    /// assigned to an encryption set. 
    /// </summary>
    /// <param name="ix"></param>
    /// <param name="ci"></param>
    /// <param name="encr"></param>
    private void setSessionOptionEncrypt(IXConnection ix, bool encr) {
      SessionOptions sopts = new SessionOptions();
      sopts.options = new KeyValue[2];
      sopts.options[0] = new KeyValue();
      sopts.options[0].key = SessionOptionsC.ENCRYPT_DOCUMENTS;
      sopts.options[0].value = "" + encr;
      sopts.options[1] = new KeyValue();
      sopts.options[1].key = SessionOptionsC.DECRYPT_DOCUMENTS;
      sopts.options[1].value = "" + encr;
      ix.Ix.setSessionOptions(sopts);
    }

    /// <summary>
    /// This function initializes an encryption set with a new internal and external password.
    /// It must be called with administrator rights.
    /// </summary>
    /// <param name="encrSet">Encryption set ID</param>
    /// <param name="name">Encryption set name</param>
    /// <param name="pwd">External password</param>
    private void initializeNewEncryptionSet(IXConnection ix, IXServicePortC CONST, 
      int encrSet, String name, String pwd)
    {
      // Create new CryptInfo object that contains the parameters for an encrpytion set
      CryptInfo yi = new CryptInfo();
      yi.id = encrSet;
      yi.name = name;

      // Encrypt the password with the public key supplied by IndexServer
      yi.pwd = ix.EncryptPassword(pwd);

      // KeyInfo can be filled with the internal ELO representation of the 
      // internal encryption key. This information is encrypted with the
      // external password. To create a new internal key, set this member to "*"
      yi.keyInfo = "*";

      // write crypt info
      ix.Ix.checkinCryptInfos(new CryptInfo[] {yi}, LockC.NO);
    }

    /// <summary>
    /// Helper function to generate a temporary file name.
    /// </summary>
    /// <param name="ext">Extension</param>
    /// <returns></returns>
		private String internalMakeTempFileName(String ext)
		{
			Random r = new Random((int)DateTime.Now.Ticks);
			String tempDir = System.IO.Path.GetTempPath();
			String tempName = "";
			do
			{
				tempName = tempDir + "eloix" + r.Next() + "." + ext;
			} while (System.IO.File.Exists(tempName));
			return tempName;
		}

    /// <summary>
    /// Helper function to generate a temporary file with the given content and extension.
    /// </summary>
    /// <param name="text">File content.</param>
    /// <param name="ext">File extension.</param>
    /// <returns></returns>
		private String internalCreateTestFile(String text, String ext)
		{
			String tempName = internalMakeTempFileName(ext);
			System.IO.FileStream fstrm = new System.IO.FileStream(tempName, 
				System.IO.FileMode.Create, System.IO.FileAccess.Write);
			System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
			int n = encoding.GetByteCount(text);
			byte[] buf = new byte[n];
			encoding.GetBytes(text, 0, text.Length, buf, 0);
			fstrm.Write(buf, 0, buf.Length);
			fstrm.Close();
			return tempName;
		}
	}
  
}

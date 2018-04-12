//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// Constants of SessionOptions.
	/// </summary>
	public class SessionOptionsC : BSerializable
	{
	
		#region Constructors
		
		public SessionOptionsC() {
		}		
		
		public SessionOptionsC(SessionOptionsC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Client application name.
		/// </summary>
		/// <remarks>
		/// Optional.
		/// </remarks>
		public const String CLIENT_APP_NAME = "clientApp.name";

		/// <summary>
		/// Client application version.
		/// </summary>
		/// <remarks>
		/// Optional.
		/// </remarks>
		public const String CLIENT_APP_VERSION = "clientApp.version";

		/// <summary>
		/// Client application type.
		/// </summary>
		/// <remarks>
		/// Mandatory.
		/// The appropriate value for partner applications is TYPE_PARTNER_APPLICATION
		/// unless a special type is arranged.
		/// </remarks>
		public const String CLIENT_APP_TYPE = "clientApp.type";

		/// <summary>
		/// This option value has to be used for option CLIENT_APP_TYPE if a
		/// partner application connects to IX.
		/// </summary>
		public const String TYPE_PARTNER_APPLICATION = "TDBD";

		/// <summary>
		/// Reserved.
		/// </summary>
		/// <remarks>
		/// This value is reserved for ELO applications. Unauthorized usage
		/// violates the ELO licensing terms.
		/// </remarks>
		public const String APP_TYPE_MINI_CLIENT = "DRFJ";

		/// <summary>
		/// This character is used in the SQL statement, if the search criterias contain
		/// one of the SQL wildcard characters: &quot;%&quot;, &quot;_&quot;.
		/// </summary>
		/// <remarks>
		/// It defaults to &quot;Â¶&quot; which is a reserved character in ELO and a
		/// valid escape character for the most SQL servers and configurations.
		/// Unless a search kritera contains &quot;Â¶&quot; or the SQL server does not
		/// allow the use of this character (e. g. ORACLE, UTF-8) the value has to be
		/// changed.
		/// Hint: IndexServer-API uses &quot;*&quot; as the only valid wildcard.
		/// The escape character must not be used in the search criterias.
		/// </remarks>
		public const String DB_ESCAPE_CHAR = "db.escapeChar";

		/// <summary>
		/// This characters are used as wildcards in search terms.
		/// </summary>
		/// <remarks>
		/// The first wildcard is used for zero or more characters.
		/// The second wildcard is used for exactly one character.
		/// By default (if this member is null or empty),
		/// only the first wildcard is defined: *
		/// </remarks>
		public const String DB_WILDCARDS = "db.wildcards";

		/// <summary>
		/// This option specifies which application is addressed in URLs to upload
		/// and download documents.
		/// </summary>
		/// <remarks>
		/// If direct access is true, the URLs address the
		/// DM directly. Otherwise the documents are routed though the IX.
		/// </remarks>
		public const String DIRECT_DM_ACCESS = "ix.directDMAccess";

		/// <summary>
		/// Set this option to encrypt documents on checkin.
		/// </summary>
		/// <remarks>
		/// A secure connection (HTTPS)
		/// is required to use this option.
		/// </remarks>
		public const String ENCRYPT_DOCUMENTS = "ix.encryptDocuments";

		/// <summary>
		/// Set this option to decrypt documents on checkout.
		/// </summary>
		/// <remarks>
		/// A secure connection (HTTPS)
		/// is required to use this option.
		/// </remarks>
		public const String DECRYPT_DOCUMENTS = "ix.decryptDocuments";

		/// <summary>
		/// Translate keywording forms names, index names, index values and keyword lists
		/// into resp. from the language given in <code>ClientInfo.language</code>.
		/// </summary>
		public const String TRANSLATE_TERMS = "ix.translateTerms";

		/// <summary>
		/// Format ISO date values with delimiter characters defined in ISO 8601.
		/// </summary>
		public const String ISO_DATE_WITH_DELIMS = "ix.isoDateWithDelims";

		/// <summary>
		/// If this option is set to "true", the IndexServer starts the workflow
		/// defined in DocMask.flowId and DocMask.flowId2 when an associated document
		/// is created or checked in.
		/// </summary>
		public const String START_DOCMASK_WORKFLOWS = "ix.startDocMaskWorkflows";

		/// <summary>
		/// Function getSessionFromTicket: session must be known by this IndexServer instance.
		/// </summary>
		/// <remarks>
		/// An exception is thrown, if the session is not known by this IndexServer instance.
		/// The ticket lifetime is extended.
		/// </remarks>
		public const int SESSION_FROM_IX = 0;

		/// <summary>
		/// Function getSessionFromTicket: any active session known by the AccessManager can be requested.
		/// </summary>
		/// <remarks>
		/// The session is not inserted into the session management of this IndexServer instance.
		/// Thus the session cannot be used to make IndexServer function calls.
		/// The ticket lifetime is not extended.
		/// </remarks>
		public const int SESSION_FROM_AM = 1;

		/// <summary>
		/// Function getSessionFromTicket: used in combination with SESSION_FROM_AM.
		/// </summary>
		/// <remarks>
		/// Add the session into the internal session management.
		/// </remarks>
		public const int SESSION_ADD = 2;

		/// <summary>
		/// Function getSessionFromTicket: any active session can be requested and is inserted
		/// into the session management of this IndexServer instance.
		/// </summary>
		/// <remarks>
		/// If the session is not known by this IndexServer instance, it is assumed to be a
		/// Windows CLIENT session (relevant to license model).
		/// The ticket lifetime is extended.
		/// This value is the same as SESSION_FROM_AM | SESSION_ADD.
		/// </remarks>
		public const int SESSION_FROM_AM_ADD = 3;

		/// <summary>
		/// Define the first part of the URLs generated from Indexserver.
		/// </summary>
		/// <remarks>
		/// See configuration option ixUrlBase on the Indexserver option page.
		/// </remarks>
		public const String IX_URL_BASE = "ix.ixUrlBase";

		/// <summary>
		/// Define the first part of the document URLs generated from Indexserver.
		/// </summary>
		/// <remarks>
		/// See configuration option documentUrlBase on the Indexserver option page.
		/// </remarks>
		public const String DOC_URL_BASE = "ix.documentUrlBase";

		/// <summary>
		/// Define the download URL type.
		/// </summary>
		/// <remarks>
		/// IX can generate several types of URLs to download documents.
		/// Possible values are the constants DOWNLOAD_URL_TYPE_*.
		/// The default value is DOWNLOAD_URL_TYPE_TEMPORARY.
		/// </remarks>
		public const String DOWNLOAD_URL_TYPE = "ix.downloadUrlType";

		/// <summary>
		/// Generate URLs that expire after a given time.
		/// </summary>
		/// <remarks>
		/// The lifetime can be specified with the option "documentUrlLifetimeSeconds".
		/// By default, all URLs are created with a constrained lifetime.
		/// </remarks>
		public const String DOWNLOAD_URL_TYPE_TEMPORARY = "temporary";

		/// <summary>
		/// Generate URLs that do not expire.
		/// </summary>
		/// <remarks>
		/// IX generates URLs that can be used without time limitation.
		/// The URL includes a strongly encrypted ID of the document or attachment version.
		/// AES is used to encrypt the URL parameters. The AES key is read from the IX option AESEncryptionKey.
		/// 
		/// <br/>
		/// <b>ATTENTION: If the key AESEncryptionKey is changed, all URLs generated before become invalid!</b>
		/// 
		/// <br/>
		/// <b>ATTENTION: No access checking is performed, when the document is downloaded from the URL!
		/// Everyone who knows the URL and has access to ELOix can download the document.
		/// This option cannot not be used for documents with blackening. No URL is generated for those documents.</b>
		/// 
		/// <br/>
		/// Only main administrators can use this option. The document is accessed by the IX account.
		/// Authentication is not required or performed.
		/// </remarks>
		public const String DOWNLOAD_URL_TYPE_PERSISTENT = "persistent";

		/// <summary>
		/// Generate public download URLs for the actual working version, that expire after a given time.
		/// </summary>
		/// <remarks>
		/// Only a given number of downloads is allowed.
		/// IX generates URLs that can be used by non ELO users.
		/// The URL includes a strongly encrypted ID of the document or attachment version.
		/// AES is used to encrypt the URL parameters. The AES key is read from the IX option AESEncryptionKey.
		/// 
		/// <br/>
		/// <b>ATTENTION: If the key AESEncryptionKey is changed, all URLs generated before become invalid!</b>
		/// 
		/// <br/>
		/// <b>ATTENTION: No access checking is performed, when the document is downloaded from the URL!
		/// Everyone who knows the URL and has access to ELOix can download the document.
		/// This option cannot not be used for documents with blackening. No URL is generated for those documents.</b>
		/// 
		/// <br/>
		/// Authentication is not required or performed.
		/// </remarks>
		public const String DOWNLOAD_URL_TYPE_PUBLIC = "public";

		/// <summary>
		/// Generate public download URLs for the document version, that expire after a given time..
		/// </summary>
		/// <remarks>
		/// Only a given number of downloads is allowed.
		/// IX generates URLs that can be used by non ELO users.
		/// The URL includes a strongly encrypted ID of the document or attachment version.
		/// AES is used to encrypt the URL parameters. The AES key is read from the IX option AESEncryptionKey.
		/// 
		/// <br/>
		/// <b>ATTENTION: If the key AESEncryptionKey is changed, all URLs generated before become invalid!</b>
		/// 
		/// <br/>
		/// <b>ATTENTION: No access checking is performed, when the document is downloaded from the URL!
		/// Everyone who knows the URL and has access to ELOix can download the document.
		/// This option cannot not be used for documents with blackening. No URL is generated for those documents.</b>
		/// 
		/// <br/>
		/// Authentication is not required or performed.
		/// </remarks>
		public const String DOWNLOAD_URL_TYPE_PUBLIC_VERSION = "public_version";

		/// <summary>
		/// Define the allowed number of public downloads.
		/// </summary>
		public const String PUBLIC_DOWNLOAD_COUNT = "ix.publicDownloadCount";

		/// <summary>
		/// Define the expired time of public downloads.
		/// </summary>
		public const String PUBLIC_DOWNLOAD_EXPIREDTIME = "ix.publicDownloadExpiredTime";

		/// <summary>
		/// Apply all blackenings on documents regardless of their ACL.
		/// </summary>
		/// <remarks>
		/// ELOtr sets this option as "true" to receive documents with all blackenings.
		/// This ensures that blackened parts cannot be retrieved by a fulltext search.
		/// TTS003793
		/// </remarks>
		public const String APPLY_ALL_BLACKENINGS = "ix.applyAllBlackenings";

		/// <summary>
		/// If set, this option disables the protection of change information.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Disabling the writing of changes information causes the IndexServer to not
		/// update the *tstamp* database columns. Then, the client has to ensure that
		/// the time stamps of objects are set correctly. Setting this option without
		/// reason causes the loss of traceability of objects in the archive! Only the
		/// replication module should use this option.
		/// </p>
		/// <p>
		/// The replication searches the database for changes since the last
		/// replication run. The gathered changes will be transported to other sites
		/// and imported into the database there. Such an import must not trigger the
		/// writing of change informations as further this would trigger the export of
		/// these changes again, claiming the changes would have been made at the site
		/// importing the changes.
		/// </p>
		/// </remarks>
		public const String DISABLE_CHANGE_INFO_PROTECTION = "ix.disableChangeInfoProtection";

		/// <summary>
		/// This session option declares that the IXConnection handles server events declared in {@link IXServerEvents}.
		/// </summary>
		public const String HANDLE_IX_SERVER_EVENTS = "ix.handleIXServerEvents";

		#endregion
		
		
		public static readonly long serialVersionUID = 2000345779L;		
	} // end class
}  // end namespace

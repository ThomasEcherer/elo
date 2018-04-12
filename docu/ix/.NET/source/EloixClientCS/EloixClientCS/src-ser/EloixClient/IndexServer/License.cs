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
	/// <p>This class contains license information.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class License : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public License() {
		}		
		
		public License(bool @backup, bool @cold, bool @demoVersion, bool @dispatchFolder, bool @domea, bool @emailOnly, int[] @features, bool @fultext, bool @httpServer, bool @indexServer, bool @limitedIg, bool @limitedVersion, int @nbOfIgLicenses, int @nbOfServerLicenses, bool @professional, bool @replication, bool @sapALink, String @serno, bool @signature, bool @stack, bool @tobid, bool @xmlImport, int @nbOfFulltextLangs) {
			this.backupValue = @backup;
			this.coldValue = @cold;
			this.demoVersionValue = @demoVersion;
			this.dispatchFolderValue = @dispatchFolder;
			this.domeaValue = @domea;
			this.emailOnlyValue = @emailOnly;
			this.featuresValue = @features;
			this.fultextValue = @fultext;
			this.httpServerValue = @httpServer;
			this.indexServerValue = @indexServer;
			this.limitedIgValue = @limitedIg;
			this.limitedVersionValue = @limitedVersion;
			this.nbOfIgLicensesValue = @nbOfIgLicenses;
			this.nbOfServerLicensesValue = @nbOfServerLicenses;
			this.professionalValue = @professional;
			this.replicationValue = @replication;
			this.sapALinkValue = @sapALink;
			this.sernoValue = @serno;
			this.signatureValue = @signature;
			this.stackValue = @stack;
			this.tobidValue = @tobid;
			this.xmlImportValue = @xmlImport;
			this.nbOfFulltextLangsValue = @nbOfFulltextLangs;
		}		
		
		public License(License rhs) : base(rhs)
		{
			this.backupValue = rhs.backupValue;
			this.coldValue = rhs.coldValue;
			this.demoVersionValue = rhs.demoVersionValue;
			this.dispatchFolderValue = rhs.dispatchFolderValue;
			this.domeaValue = rhs.domeaValue;
			this.emailOnlyValue = rhs.emailOnlyValue;
			this.featuresValue = rhs.featuresValue;
			this.fultextValue = rhs.fultextValue;
			this.httpServerValue = rhs.httpServerValue;
			this.indexServerValue = rhs.indexServerValue;
			this.limitedIgValue = rhs.limitedIgValue;
			this.limitedVersionValue = rhs.limitedVersionValue;
			this.nbOfIgLicensesValue = rhs.nbOfIgLicensesValue;
			this.nbOfServerLicensesValue = rhs.nbOfServerLicensesValue;
			this.professionalValue = rhs.professionalValue;
			this.replicationValue = rhs.replicationValue;
			this.sapALinkValue = rhs.sapALinkValue;
			this.sernoValue = rhs.sernoValue;
			this.signatureValue = rhs.signatureValue;
			this.stackValue = rhs.stackValue;
			this.tobidValue = rhs.tobidValue;
			this.xmlImportValue = rhs.xmlImportValue;
			this.nbOfFulltextLangsValue = rhs.nbOfFulltextLangsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Backup enabled.
		/// </summary>
		public bool backup
		{
			get
			{
				return backupValue;
			}
			set
			{
				this.backupValue = value;
			}
		}
		
		
		/// <summary>
		/// COLD
		/// </summary>
		public bool cold
		{
			get
			{
				return coldValue;
			}
			set
			{
				this.coldValue = value;
			}
		}
		
		
		/// <summary>
		/// Demo version.
		/// </summary>
		public bool demoVersion
		{
			get
			{
				return demoVersionValue;
			}
			set
			{
				this.demoVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// Dispatch folder (Versendemappe)
		/// </summary>
		public bool dispatchFolder
		{
			get
			{
				return dispatchFolderValue;
			}
			set
			{
				this.dispatchFolderValue = value;
			}
		}
		
		
		/// <summary>
		/// DOMEA
		/// </summary>
		public bool domea
		{
			get
			{
				return domeaValue;
			}
			set
			{
				this.domeaValue = value;
			}
		}
		
		
		/// <summary>
		/// EMail
		/// </summary>
		public bool emailOnly
		{
			get
			{
				return emailOnlyValue;
			}
			set
			{
				this.emailOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// Binary coded license information
		/// </summary>
		public int[] features
		{
			get
			{
				return featuresValue;
			}
			set
			{
				this.featuresValue = value;
			}
		}
		
		
		/// <summary>
		/// Fulltext enabled.
		/// </summary>
		public bool fultext
		{
			get
			{
				return fultextValue;
			}
			set
			{
				this.fultextValue = value;
			}
		}
		
		
		/// <summary>
		/// HTTP DocServer
		/// </summary>
		public bool httpServer
		{
			get
			{
				return httpServerValue;
			}
			set
			{
				this.httpServerValue = value;
			}
		}
		
		
		/// <summary>
		/// IndexServer
		/// </summary>
		public bool indexServer
		{
			get
			{
				return indexServerValue;
			}
			set
			{
				this.indexServerValue = value;
			}
		}
		
		
		/// <summary>
		/// Limited Internet Gateway
		/// </summary>
		public bool limitedIg
		{
			get
			{
				return limitedIgValue;
			}
			set
			{
				this.limitedIgValue = value;
			}
		}
		
		
		/// <summary>
		/// Limited version.
		/// </summary>
		public bool limitedVersion
		{
			get
			{
				return limitedVersionValue;
			}
			set
			{
				this.limitedVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of ELO Internet Gateway users.
		/// </summary>
		public int nbOfIgLicenses
		{
			get
			{
				return nbOfIgLicensesValue;
			}
			set
			{
				this.nbOfIgLicensesValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of server licenses.
		/// </summary>
		public int nbOfServerLicenses
		{
			get
			{
				return nbOfServerLicensesValue;
			}
			set
			{
				this.nbOfServerLicensesValue = value;
			}
		}
		
		
		/// <summary>
		/// True for ELOprofessional
		/// </summary>
		public bool professional
		{
			get
			{
				return professionalValue;
			}
			set
			{
				this.professionalValue = value;
			}
		}
		
		
		/// <summary>
		/// Replication enabled.
		/// </summary>
		public bool replication
		{
			get
			{
				return replicationValue;
			}
			set
			{
				this.replicationValue = value;
			}
		}
		
		
		/// <summary>
		/// SAPALINK interface
		/// </summary>
		public bool sapALink
		{
			get
			{
				return sapALinkValue;
			}
			set
			{
				this.sapALinkValue = value;
			}
		}
		
		
		/// <summary>
		/// License key.
		/// </summary>
		public String serno
		{
			get
			{
				return sernoValue;
			}
			set
			{
				this.sernoValue = value;
			}
		}
		
		
		/// <summary>
		/// SIGNATURE
		/// </summary>
		public bool signature
		{
			get
			{
				return signatureValue;
			}
			set
			{
				this.signatureValue = value;
			}
		}
		
		
		/// <summary>
		/// STACK
		/// </summary>
		public bool stack
		{
			get
			{
				return stackValue;
			}
			set
			{
				this.stackValue = value;
			}
		}
		
		
		/// <summary>
		/// Tobit
		/// </summary>
		public bool tobid
		{
			get
			{
				return tobidValue;
			}
			set
			{
				this.tobidValue = value;
			}
		}
		
		
		/// <summary>
		/// XML-Import
		/// </summary>
		public bool xmlImport
		{
			get
			{
				return xmlImportValue;
			}
			set
			{
				this.xmlImportValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of languages for which linguistic processing can be used during fulltext indexing.
		/// </summary>
		public int nbOfFulltextLangs
		{
			get
			{
				return nbOfFulltextLangsValue;
			}
			set
			{
				this.nbOfFulltextLangsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool backupValue;

		protected bool coldValue;

		protected bool demoVersionValue;

		protected bool dispatchFolderValue;

		protected bool domeaValue;

		protected bool emailOnlyValue;

		protected int[] featuresValue;

		protected bool fultextValue;

		protected bool httpServerValue;

		protected bool indexServerValue;

		protected bool limitedIgValue;

		protected bool limitedVersionValue;

		protected int nbOfIgLicensesValue;

		protected int nbOfServerLicensesValue;

		protected bool professionalValue;

		protected bool replicationValue;

		protected bool sapALinkValue;

		protected String sernoValue;

		protected bool signatureValue;

		protected bool stackValue;

		protected bool tobidValue;

		protected bool xmlImportValue;

		protected int nbOfFulltextLangsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1330120264L;		
	} // end class
}  // end namespace

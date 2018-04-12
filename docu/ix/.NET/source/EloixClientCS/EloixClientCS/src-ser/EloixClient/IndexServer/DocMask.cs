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
	/// <p>Contains the data for a storage mask.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class DocMask : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocMask() {
		}		
		
		public DocMask(String @DAcl, int @DKind, int @DPath, String @TStamp, String @barcode, int @flowId, int @id, String @index, String @lifetime, int @lockId, String @lockName, String @name, String @text, String @acl, EloixClient.IndexServer.AclItem[] @aclItems, EloixClient.IndexServer.DocMaskDetails @details, EloixClient.IndexServer.AclItem[] @docAclItems, EloixClient.IndexServer.DocMaskLine[] @lines, String @guid, bool @deleted, int @flowId2, String @TStampSync, String @textTranslationKey, String @nameTranslationKey, int @dataOrganisation) {
			this.DAclValue = @DAcl;
			this.DKindValue = @DKind;
			this.DPathValue = @DPath;
			this.TStampValue = @TStamp;
			this.barcodeValue = @barcode;
			this.flowIdValue = @flowId;
			this.idValue = @id;
			this.indexValue = @index;
			this.lifetimeValue = @lifetime;
			this.lockIdValue = @lockId;
			this.lockNameValue = @lockName;
			this.nameValue = @name;
			this.textValue = @text;
			this.aclValue = @acl;
			this.aclItemsValue = @aclItems;
			this.detailsValue = @details;
			this.docAclItemsValue = @docAclItems;
			this.linesValue = @lines;
			this.guidValue = @guid;
			this.deletedValue = @deleted;
			this.flowId2Value = @flowId2;
			this.TStampSyncValue = @TStampSync;
			this.textTranslationKeyValue = @textTranslationKey;
			this.nameTranslationKeyValue = @nameTranslationKey;
			this.dataOrganisationValue = @dataOrganisation;
		}		
		
		public DocMask(DocMask rhs) : base(rhs)
		{
			this.DAclValue = rhs.DAclValue;
			this.DKindValue = rhs.DKindValue;
			this.DPathValue = rhs.DPathValue;
			this.TStampValue = rhs.TStampValue;
			this.barcodeValue = rhs.barcodeValue;
			this.flowIdValue = rhs.flowIdValue;
			this.idValue = rhs.idValue;
			this.indexValue = rhs.indexValue;
			this.lifetimeValue = rhs.lifetimeValue;
			this.lockIdValue = rhs.lockIdValue;
			this.lockNameValue = rhs.lockNameValue;
			this.nameValue = rhs.nameValue;
			this.textValue = rhs.textValue;
			this.aclValue = rhs.aclValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.detailsValue = rhs.detailsValue;
			this.docAclItemsValue = rhs.docAclItemsValue;
			this.linesValue = rhs.linesValue;
			this.guidValue = rhs.guidValue;
			this.deletedValue = rhs.deletedValue;
			this.flowId2Value = rhs.flowId2Value;
			this.TStampSyncValue = rhs.TStampSyncValue;
			this.textTranslationKeyValue = rhs.textTranslationKeyValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
			this.dataOrganisationValue = rhs.dataOrganisationValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// New objects are created with these ACL permission settings.
		/// </summary>
		public String DAcl
		{
			get
			{
				return DAclValue;
			}
			set
			{
				this.DAclValue = value;
				setChangedMember(DocMaskC.mbDAcl);
			}
		}
		
		
		/// <summary>
		/// The marker color ID for new objects created with this mask.
		/// </summary>
		public int DKind
		{
			get
			{
				return DKindValue;
			}
			set
			{
				this.DKindValue = value;
				setChangedMember(DocMaskC.mbDKind);
			}
		}
		
		
		/// <summary>
		/// Document storage path name where the documents of this mask
		/// should be stored.
		/// </summary>
		public int DPath
		{
			get
			{
				return DPathValue;
			}
			set
			{
				this.DPathValue = value;
				setChangedMember(DocMaskC.mbDPath);
			}
		}
		
		
		/// <summary>
		/// Last update time of the storage mask data.
		/// </summary>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(DocMaskC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Barcode string.
		/// </summary>
		public String barcode
		{
			get
			{
				return barcodeValue;
			}
			set
			{
				this.barcodeValue = value;
				setChangedMember(DocMaskC.mbBarcode);
			}
		}
		
		
		/// <summary>
		/// The ID of a workflow that is started if a new object with this
		/// mask is created.
		/// </summary>
		/// <remarks>
		/// If the SessionOption START_DOCMASK_WORKFLOWS is set, the IndexServer
		/// starts this workflow, if an associated document is created. Otherwise the
		/// client application is responsible for starting the workflow.
		/// </remarks>
		public int flowId
		{
			get
			{
				return flowIdValue;
			}
			set
			{
				this.flowIdValue = value;
				setChangedMember(DocMaskC.mbFlowId);
			}
		}
		
		
		/// <summary>
		/// Storage mask ID.
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(DocMaskC.mbId);
			}
		}
		
		
		/// <summary>
		/// This control string provides a way of storing new storage mask objects
		/// automatically in a particular archive path.
		/// </summary>
		public String index
		{
			get
			{
				return indexValue;
			}
			set
			{
				this.indexValue = value;
				setChangedMember(DocMaskC.mbIndex);
			}
		}
		
		
		/// <summary>
		/// New objects are valid for this length of time.
		/// </summary>
		public String lifetime
		{
			get
			{
				return lifetimeValue;
			}
			set
			{
				this.lifetimeValue = value;
				setChangedMember(DocMaskC.mbLifetime);
			}
		}
		
		
		/// <summary>
		/// User ID of the user that has locked the storage mask.
		/// </summary>
		/// <remarks>
		/// If -1, no lock is held.
		/// </remarks>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(DocMaskC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// Name of the user that has locked th storage mask.
		/// </summary>
		/// <remarks>
		/// Read-only, ignored in checkinDocMask.
		/// </remarks>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Storage mask name.
		/// </summary>
		/// <remarks>
		/// It can be translated into reps. from the users language:
		/// set <code>SessionOptionsC.TRANSLATE_TERM</code>.
		/// </remarks>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
				setChangedMember(DocMaskC.mbName);
			}
		}
		
		
		/// <summary>
		/// Tab captions.
		/// </summary>
		/// <remarks>
		/// List of tab captions separated by pipe char |.
		/// </remarks>
		public String text
		{
			get
			{
				return textValue;
			}
			set
			{
				this.textValue = value;
				setChangedMember(DocMaskC.mbText);
			}
		}
		
		
		/// <summary>
		/// Access control for the mask line
		/// </summary>
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
				setChangedMember(DocMaskC.mbAcl);
			}
		}
		
		
		/// <summary>
		/// Access control to mask line.
		/// </summary>
		/// <remarks>
		/// Currently this can only be null or one item representing a key.
		/// </remarks>
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
				setChangedMember(DocMaskC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// Detailed properties for the DocMask object.
		/// </summary>
		public EloixClient.IndexServer.DocMaskDetails details
		{
			get
			{
				return detailsValue;
			}
			set
			{
				this.detailsValue = value;
				setChangedMember(DocMaskC.mbDetails);
			}
		}
		
		
		/// <summary>
		/// These access control items are the initial values for new documents inserted with this mask.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] docAclItems
		{
			get
			{
				return docAclItemsValue;
			}
			set
			{
				this.docAclItemsValue = value;
				setChangedMember(DocMaskC.mbDocAclItems);
			}
		}
		
		
		/// <summary>
		/// Array of index value definitions.
		/// </summary>
		public EloixClient.IndexServer.DocMaskLine[] lines
		{
			get
			{
				return linesValue;
			}
			set
			{
				this.linesValue = value;
				setChangedMember(DocMaskC.mbLines);
			}
		}
		
		
		/// <summary>
		/// GUID
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(DocMaskC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Deleted status.
		/// </summary>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
				setChangedMember(DocMaskC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// The ID of a workflow that is to be started if a new version of an associated
		/// document is checked in.
		/// </summary>
		/// <remarks>
		/// If the SessionOption START_DOCMASK_WORKFLOWS is set, the IndexServer
		/// starts this workflow, if an associated document is checked in. Otherwise the
		/// client application is responsible for starting the workflow.
		/// </remarks>
		public int flowId2
		{
			get
			{
				return flowId2Value;
			}
			set
			{
				this.flowId2Value = value;
				setChangedMember(DocMaskC.mbFlowId2);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(DocMaskC.mbTStampSync);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link DocMask#text}.
		/// </summary>
		public String textTranslationKey
		{
			get
			{
				return textTranslationKeyValue;
			}
			set
			{
				this.textTranslationKeyValue = value;
				setChangedMember(DocMaskC.mbTextTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link DocMask#name}.
		/// </summary>
		public String nameTranslationKey
		{
			get
			{
				return nameTranslationKeyValue;
			}
			set
			{
				this.nameTranslationKeyValue = value;
				setChangedMember(DocMaskC.mbNameTranslationKey);
			}
		}
		
		
		/// <summary>
		/// This member specifies how the index values are stored in database.
		/// </summary>
		public int dataOrganisation
		{
			get
			{
				return dataOrganisationValue;
			}
			set
			{
				this.dataOrganisationValue = value;
				setChangedMember(DocMaskC.mbDataOrganisation);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String DAclValue;

		protected int DKindValue;

		protected int DPathValue;

		protected String TStampValue;

		protected String barcodeValue;

		protected int flowIdValue;

		protected int idValue;

		protected String indexValue;

		protected String lifetimeValue;

		protected int lockIdValue;

		protected String lockNameValue;

		protected String nameValue;

		protected String textValue;

		protected String aclValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected EloixClient.IndexServer.DocMaskDetails detailsValue;

		protected EloixClient.IndexServer.AclItem[] docAclItemsValue;

		protected EloixClient.IndexServer.DocMaskLine[] linesValue;

		protected String guidValue;

		protected bool deletedValue;

		protected int flowId2Value;

		protected String TStampSyncValue;

		protected String textTranslationKeyValue;

		protected String nameTranslationKeyValue;

		protected int dataOrganisationValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2054753789L;		
	} // end class
}  // end namespace

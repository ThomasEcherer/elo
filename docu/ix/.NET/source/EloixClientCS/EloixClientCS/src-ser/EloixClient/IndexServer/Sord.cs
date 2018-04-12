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
	/// <p>Indexing information of an archive entry.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class Sord : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Sord() {
		}		
		
		public Sord(String @SReg, String @TStamp, String @acl, int @att, int @childCount, int @doc, String @guid, int @histCount, int @id, int @info, int @key, int @kind, int @lockId, int @mask, String @name, int @ownerId, int @parentId, int @path, int @type, int @vtRep, String @IDateIso, String @XDateIso, int @access, EloixClient.IndexServer.AclItem[] @aclItems, String @delDateIso, bool @deleted, String @desc, EloixClient.IndexServer.SordDetails @details, EloixClient.IndexServer.DocVersion @docVersion, String @hiddenText, EloixClient.IndexServer.SordLink[] @linksComeIn, EloixClient.IndexServer.SordLink[] @linksGoOut, String @lockName, EloixClient.IndexServer.ObjKey[] @objKeys, String @ownerName, String[] @parentIds, EloixClient.IndexServer.ArcPath[] @refPaths, EloixClient.IndexServer.ReplSetName[] @replNames, EloixClient.IndexServer.ReplSet @replSet, String @maskName, EloixClient.IndexServer.DocVersion @attVersion, String @deleteDateIso, int @lockIdSord, int @lockIdDoc, String @lockNameSord, String @lockNameDoc, String @TStampSync, String @TStampAcl, String @TStampAclSync, int @deleteUser) {
			this.SRegValue = @SReg;
			this.TStampValue = @TStamp;
			this.aclValue = @acl;
			this.attValue = @att;
			this.childCountValue = @childCount;
			this.docValue = @doc;
			this.guidValue = @guid;
			this.histCountValue = @histCount;
			this.idValue = @id;
			this.infoValue = @info;
			this.keyValue = @key;
			this.kindValue = @kind;
			this.lockIdValue = @lockId;
			this.maskValue = @mask;
			this.nameValue = @name;
			this.ownerIdValue = @ownerId;
			this.parentIdValue = @parentId;
			this.pathValue = @path;
			this.typeValue = @type;
			this.vtRepValue = @vtRep;
			this.IDateIsoValue = @IDateIso;
			this.XDateIsoValue = @XDateIso;
			this.accessValue = @access;
			this.aclItemsValue = @aclItems;
			this.delDateIsoValue = @delDateIso;
			this.deletedValue = @deleted;
			this.descValue = @desc;
			this.detailsValue = @details;
			this.docVersionValue = @docVersion;
			this.hiddenTextValue = @hiddenText;
			this.linksComeInValue = @linksComeIn;
			this.linksGoOutValue = @linksGoOut;
			this.lockNameValue = @lockName;
			this.objKeysValue = @objKeys;
			this.ownerNameValue = @ownerName;
			this.parentIdsValue = @parentIds;
			this.refPathsValue = @refPaths;
			this.replNamesValue = @replNames;
			this.replSetValue = @replSet;
			this.maskNameValue = @maskName;
			this.attVersionValue = @attVersion;
			this.deleteDateIsoValue = @deleteDateIso;
			this.lockIdSordValue = @lockIdSord;
			this.lockIdDocValue = @lockIdDoc;
			this.lockNameSordValue = @lockNameSord;
			this.lockNameDocValue = @lockNameDoc;
			this.TStampSyncValue = @TStampSync;
			this.TStampAclValue = @TStampAcl;
			this.TStampAclSyncValue = @TStampAclSync;
			this.deleteUserValue = @deleteUser;
		}		
		
		public Sord(Sord rhs) : base(rhs)
		{
			this.SRegValue = rhs.SRegValue;
			this.TStampValue = rhs.TStampValue;
			this.aclValue = rhs.aclValue;
			this.attValue = rhs.attValue;
			this.childCountValue = rhs.childCountValue;
			this.docValue = rhs.docValue;
			this.guidValue = rhs.guidValue;
			this.histCountValue = rhs.histCountValue;
			this.idValue = rhs.idValue;
			this.infoValue = rhs.infoValue;
			this.keyValue = rhs.keyValue;
			this.kindValue = rhs.kindValue;
			this.lockIdValue = rhs.lockIdValue;
			this.maskValue = rhs.maskValue;
			this.nameValue = rhs.nameValue;
			this.ownerIdValue = rhs.ownerIdValue;
			this.parentIdValue = rhs.parentIdValue;
			this.pathValue = rhs.pathValue;
			this.typeValue = rhs.typeValue;
			this.vtRepValue = rhs.vtRepValue;
			this.IDateIsoValue = rhs.IDateIsoValue;
			this.XDateIsoValue = rhs.XDateIsoValue;
			this.accessValue = rhs.accessValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.delDateIsoValue = rhs.delDateIsoValue;
			this.deletedValue = rhs.deletedValue;
			this.descValue = rhs.descValue;
			this.detailsValue = rhs.detailsValue;
			this.docVersionValue = rhs.docVersionValue;
			this.hiddenTextValue = rhs.hiddenTextValue;
			this.linksComeInValue = rhs.linksComeInValue;
			this.linksGoOutValue = rhs.linksGoOutValue;
			this.lockNameValue = rhs.lockNameValue;
			this.objKeysValue = rhs.objKeysValue;
			this.ownerNameValue = rhs.ownerNameValue;
			this.parentIdsValue = rhs.parentIdsValue;
			this.refPathsValue = rhs.refPathsValue;
			this.replNamesValue = rhs.replNamesValue;
			this.replSetValue = rhs.replSetValue;
			this.maskNameValue = rhs.maskNameValue;
			this.attVersionValue = rhs.attVersionValue;
			this.deleteDateIsoValue = rhs.deleteDateIsoValue;
			this.lockIdSordValue = rhs.lockIdSordValue;
			this.lockIdDocValue = rhs.lockIdDocValue;
			this.lockNameSordValue = rhs.lockNameSordValue;
			this.lockNameDocValue = rhs.lockNameDocValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
			this.TStampAclValue = rhs.TStampAclValue;
			this.TStampAclSyncValue = rhs.TStampAclSyncValue;
			this.deleteUserValue = rhs.deleteUserValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Version numer of the current work version.
		/// </summary>
		public String SReg
		{
			get
			{
				return SRegValue;
			}
			set
			{
				this.SRegValue = value;
				setChangedMember(SordC.mbSReg);
			}
		}
		
		
		/// <summary>
		/// Timestamp of the last change.
		/// </summary>
		/// <remarks>
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(SordC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Access control language in coded form.
		/// </summary>
		/// <remarks>
		/// The checkInSord method must set either
		/// acl or aclItems. aclItems has priority.
		/// </remarks>
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
				setChangedMember(SordC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// Id of the current attachment version.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int att
		{
			get
			{
				return attValue;
			}
			set
			{
				this.attValue = value;
				setChangedMember(SordC.mbAttVersionMembers);
			}
		}
		
		
		/// <summary>
		/// Estimated sum of the sub-entries in a directory.
		/// </summary>
		/// <remarks>
		/// This does not take
		/// account of any access rights assigned to the entries.
		/// This property should only be used to determine whether the directory has
		/// additional entries.
		/// Read-only.
		/// </remarks>
		public int childCount
		{
			get
			{
				return childCountValue;
			}
			set
			{
				this.childCountValue = value;
				setChangedMember(SordC.mbChildCount);
			}
		}
		
		
		/// <summary>
		/// Read-only.
		/// </summary>
		/// <remarks>
		/// Id of the current document version.
		/// </remarks>
		public int doc
		{
			get
			{
				return docValue;
			}
			set
			{
				this.docValue = value;
				setChangedMember(SordC.mbDocVersionMembers);
			}
		}
		
		
		/// <summary>
		/// GUID of the current document version.
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
				setChangedMember(SordC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Number of document versions.
		/// </summary>
		public int histCount
		{
			get
			{
				return histCountValue;
			}
			set
			{
				this.histCountValue = value;
				setChangedMember(SordC.mbHistCount);
			}
		}
		
		
		/// <summary>
		/// Id of the current document version.
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
				setChangedMember(SordC.mbId);
			}
		}
		
		
		/// <summary>
		/// RESERVED
		/// </summary>
		public int info
		{
			get
			{
				return infoValue;
			}
			set
			{
				this.infoValue = value;
				setChangedMember(SordC.mbInfo);
			}
		}
		
		
		/// <summary>
		/// RESERVED
		/// </summary>
		public int key
		{
			get
			{
				return keyValue;
			}
			set
			{
				this.keyValue = value;
				setChangedMember(SordC.mbKey);
			}
		}
		
		
		/// <summary>
		/// Colour
		/// </summary>
		public int kind
		{
			get
			{
				return kindValue;
			}
			set
			{
				this.kindValue = value;
				setChangedMember(SordC.mbKind);
			}
		}
		
		
		/// <summary>
		/// This is the id of the user who has a lock on the object.
		/// </summary>
		/// <remarks>
		/// To know whether
		/// the Sord or the Document is locked, see lockIdSord or lockIdDoc
		/// respectively. The object is locked using checkoutSord with the LOCK.YES,
		/// LOCK.SORD or LOCK.DOC parameter. Read-only.
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
				setChangedMember(SordC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// The id of the filing mask used to archive the sord.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int mask
		{
			get
			{
				return maskValue;
			}
			set
			{
				this.maskValue = value;
				setChangedMember(SordC.mbMask);
			}
		}
		
		
		/// <summary>
		/// The short description/name for the object.
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
				setChangedMember(SordC.mbName);
			}
		}
		
		
		/// <summary>
		/// The id of the owner of the object.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int ownerId
		{
			get
			{
				return ownerIdValue;
			}
			set
			{
				this.ownerIdValue = value;
				setChangedMember(SordC.mbOwnerId);
			}
		}
		
		
		/// <summary>
		/// Id of the parent object(archive heirachy) of the sord object.
		/// </summary>
		/// <remarks>
		/// Read-only
		/// </remarks>
		public int parentId
		{
			get
			{
				return parentIdValue;
			}
			set
			{
				this.parentIdValue = value;
				setChangedMember(SordC.mbParentIds);
			}
		}
		
		
		/// <summary>
		/// Filing path for the document manager.
		/// </summary>
		/// <remarks>
		/// Only valid for documents. Read-only.
		/// <p>
		/// If this Sord object is obtained by a call to checkoutSord or checkoutDoc
		/// with a database lock (e.g. LockC.IF_FREE), this member contains the storage
		/// path specified in the associated keywording form (DocMask.DPath). If the keywording
		/// form does not define a path, the default storage path is returned
		/// (ServerInfoDM.basisStoreIds[0]). Hence, the current value of the
		/// database column objekte.objpath is not used as default
		/// for new versions anymore.
		/// </p>
		/// <p>
		/// If this Sord object is obtained by a call without a lock, e.g. from findFirstSords,
		/// this value should not be used anymore. The storage path of the work version
		/// should be used instead, which can be found in Sord.docVersion.pathId.
		/// </p>
		/// </remarks>
		public int path
		{
			get
			{
				return pathValue;
			}
			set
			{
				this.pathValue = value;
				setChangedMember(SordC.mbPath);
			}
		}
		
		
		/// <summary>
		/// The type of sord object.
		/// </summary>
		/// <remarks>
		/// Folder objects: 0 &lt; type &lt; LBT_DOCUMENT
		/// Document objects: LBT_DOCUMENT &lt;= type &lt; LBT_DOCUMENT_MAX
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(SordC.mbType);
			}
		}
		
		
		/// <summary>
		/// RESERVED
		/// </summary>
		public int vtRep
		{
			get
			{
				return vtRepValue;
			}
			set
			{
				this.vtRepValue = value;
				setChangedMember(SordC.mbVtRep);
			}
		}
		
		
		/// <summary>
		/// ISO encoded internal (archive defined) date.
		/// </summary>
		public String IDateIso
		{
			get
			{
				return IDateIsoValue;
			}
			set
			{
				this.IDateIsoValue = value;
				setChangedMember(SordC.mbIDateIso);
			}
		}
		
		
		/// <summary>
		/// ISO encoded external (user defined) date.
		/// </summary>
		public String XDateIso
		{
			get
			{
				return XDateIsoValue;
			}
			set
			{
				this.XDateIsoValue = value;
				setChangedMember(SordC.mbXDateIso);
			}
		}
		
		
		/// <summary>
		/// The current users access rights for this Sord.
		/// </summary>
		/// <remarks>
		/// Returns a combination of AccessC.LUR_ constants.
		/// Read-only. Is returned when SordC.mbAcl is set in checkoutSord.
		/// </remarks>
		public int access
		{
			get
			{
				return accessValue;
			}
			set
			{
				this.accessValue = value;
			}
		}
		
		
		/// <summary>
		/// This is the access control list as an array of <code>AclItem</code> objects.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
				setChangedMember(SordC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// ISO encoded expiry date.
		/// </summary>
		/// <remarks>
		/// Only users having right AccessC.FLAG_EDITDUEDATE
		/// are allowed to set the expiry date. Once the expiry date is set, it cannot
		/// be set to a date before the original expiry date.
		/// </remarks>
		public String delDateIso
		{
			get
			{
				return delDateIsoValue;
			}
			set
			{
				this.delDateIsoValue = value;
				setChangedMember(SordC.mbDelDateIso);
			}
		}
		
		
		/// <summary>
		/// Indicates whether the sord has been deleted or not.
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
				setChangedMember(SordC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// The (visible) memo text.
		/// </summary>
		/// <remarks>
		/// If the value starts with a "!" this member can define a dynamic folder.
		/// This is a folder which contents are filled by an arbitrary SQL statement.
		/// </remarks>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
				setChangedMember(SordC.mbDesc);
			}
		}
		
		
		/// <summary>
		/// Object encapsulates flags.
		/// </summary>
		public EloixClient.IndexServer.SordDetails details
		{
			get
			{
				return detailsValue;
			}
			set
			{
				this.detailsValue = value;
				setChangedMember(SordC.mbDetails);
			}
		}
		
		
		/// <summary>
		/// Version information of current document work version.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public EloixClient.IndexServer.DocVersion docVersion
		{
			get
			{
				return docVersionValue;
			}
			set
			{
				this.docVersionValue = value;
				setChangedMember(SordC.mbDocVersionMembers);
			}
		}
		
		
		/// <summary>
		/// Hidden text that must not be displayed to the user.
		/// </summary>
		public String hiddenText
		{
			get
			{
				return hiddenTextValue;
			}
			set
			{
				this.hiddenTextValue = value;
				setChangedMember(SordC.mbHiddenText);
			}
		}
		
		
		/// <summary>
		/// Links pointing from other archive entries to this.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public EloixClient.IndexServer.SordLink[] linksComeIn
		{
			get
			{
				return linksComeInValue;
			}
			set
			{
				this.linksComeInValue = value;
				setChangedMember(SordC.mbLinksComeIn);
			}
		}
		
		
		/// <summary>
		/// Links starting from <code>this</code> to other archive entries.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public EloixClient.IndexServer.SordLink[] linksGoOut
		{
			get
			{
				return linksGoOutValue;
			}
			set
			{
				this.linksGoOutValue = value;
				setChangedMember(SordC.mbLinksGoOut);
			}
		}
		
		
		/// <summary>
		/// The name of the user who has locked the object.
		/// </summary>
		/// <remarks>
		/// Read-only.
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
		/// Index values during serialization
		/// </summary>
		public EloixClient.IndexServer.ObjKey[] objKeys
		{
			get
			{
				return objKeysValue;
			}
			set
			{
				this.objKeysValue = value;
				setChangedMember(SordC.mbObjKeys);
			}
		}
		
		
		/// <summary>
		/// Name of the owner (read-only).
		/// </summary>
		public String ownerName
		{
			get
			{
				return ownerNameValue;
			}
			set
			{
				this.ownerNameValue = value;
				setChangedMember(SordC.mbOwnerName);
			}
		}
		
		
		/// <summary>
		/// GUIDs of archive entries that contain a reference to <code>this</code>.
		/// </summary>
		/// <remarks>
		/// The first element of
		/// the array is the GUID of the main parent, where <code>this</code> is physically placed.
		/// Read-only.
		/// </remarks>
		public String[] parentIds
		{
			get
			{
				return parentIdsValue;
			}
			set
			{
				this.parentIdsValue = value;
				setChangedMember(SordC.mbParentIds);
			}
		}
		
		
		/// <summary>
		/// Archive paths to this Sord.
		/// </summary>
		/// <remarks>
		/// The first path, refPaths[0], contains the path to the original Sord.
		/// The other paths contain references to this Sord. The paths do not include an
		/// entry for the archive and for this Sord.
		/// Since 10.18.021, TTS005149: If the user does not have read access to at least one element in a reference path, this path is
		/// excluded from the list. An exception applies to the original path. If the user does not have
		/// read access to at least one element in the original path, the ArcPath object at refPaths[0] is
		/// empty: refPaths[0].path.length == 0, refPaths[0].pathAsString = "Â¶".
		/// In contrast to refPaths, the array {@link #parentIds} is not checked for read access.
		/// </remarks>
		public EloixClient.IndexServer.ArcPath[] refPaths
		{
			get
			{
				return refPathsValue;
			}
			set
			{
				this.refPathsValue = value;
				setChangedMember(SordC.mbRefPaths);
			}
		}
		
		
		/// <summary>
		/// Replication set names.
		/// </summary>
		/// <remarks>
		/// The replication set information of an object is binary encoded in the
		/// database. The Class <code>ReplNameMap</code> provides functions to convert from the binary
		/// format into a list of replication set names and vice versa.
		/// Both replNames and replSet contain the information in which replications
		/// set the object is contain in. replNames has priority when checking the object in.
		/// </remarks>
		public EloixClient.IndexServer.ReplSetName[] replNames
		{
			get
			{
				return replNamesValue;
			}
			set
			{
				this.replNamesValue = value;
				setChangedMember(SordC.mbReplNames);
			}
		}
		
		
		/// <summary>
		/// Replication sets.
		/// </summary>
		/// <remarks>
		/// Binary encoded information.
		/// Both replNames and replSet contain the information determining in which replications
		/// sets the object is contain in. replNames has priority when checking the object in.
		/// </remarks>
		public EloixClient.IndexServer.ReplSet replSet
		{
			get
			{
				return replSetValue;
			}
			set
			{
				this.replSetValue = value;
				setChangedMember(SordC.mbReplSet);
			}
		}
		
		
		/// <summary>
		/// Name of keywording form.
		/// </summary>
		/// <remarks>
		/// This value is translated into the language given by {@link ClientInfo#language}.
		/// It cannot be used as a parameter in Indexserver API functions. Use {@link Sord#getMask()} to specify the Keywording form in API functions.
		/// Read-only.
		/// </remarks>
		public String maskName
		{
			get
			{
				return maskNameValue;
			}
			set
			{
				this.maskNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Work version of the attachment.
		/// </summary>
		public EloixClient.IndexServer.DocVersion attVersion
		{
			get
			{
				return attVersionValue;
			}
			set
			{
				this.attVersionValue = value;
				setChangedMember(SordC.mbAttVersionMembers);
			}
		}
		
		
		/// <summary>
		/// The Sord is deleted at this date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>Is undefined if isDeleted() returns false.</p>
		/// </remarks>
		public String deleteDateIso
		{
			get
			{
				return deleteDateIsoValue;
			}
			set
			{
				this.deleteDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// This is the id of the user who has a lock on the object (not the document).
		/// </summary>
		/// <remarks>
		/// The object is locked using checkoutSord with the LOCK.SORD parameter.
		/// Read-only.
		/// </remarks>
		public int lockIdSord
		{
			get
			{
				return lockIdSordValue;
			}
			set
			{
				this.lockIdSordValue = value;
				setChangedMember(SordC.mbLockIdSord);
			}
		}
		
		
		/// <summary>
		/// This is the id of the user who has a lock on the document (not the object).
		/// </summary>
		/// <remarks>
		/// The object is locked using checkoutSord with the LOCK.DOC parameter.
		/// Read-only.
		/// </remarks>
		public int lockIdDoc
		{
			get
			{
				return lockIdDocValue;
			}
			set
			{
				this.lockIdDocValue = value;
				setChangedMember(SordC.mbLockIdDoc);
			}
		}
		
		
		/// <summary>
		/// The name of the user who has locked the object.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public String lockNameSord
		{
			get
			{
				return lockNameSordValue;
			}
			set
			{
				this.lockNameSordValue = value;
			}
		}
		
		
		/// <summary>
		/// The name of the user who has locked the document.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public String lockNameDoc
		{
			get
			{
				return lockNameDocValue;
			}
			set
			{
				this.lockNameDocValue = value;
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
				setChangedMember(SordC.mbTStampSync);
			}
		}
		
		
		/// <summary>
		/// Timestamp of the last ACL change.
		/// </summary>
		/// <remarks>
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String TStampAcl
		{
			get
			{
				return TStampAclValue;
			}
			set
			{
				this.TStampAclValue = value;
				setChangedMember(SordC.mbTStampAcl);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's ACLs last export by the replication.
		/// </summary>
		public String TStampAclSync
		{
			get
			{
				return TStampAclSyncValue;
			}
			set
			{
				this.TStampAclSyncValue = value;
				setChangedMember(SordC.mbTStampAclSync);
			}
		}
		
		
		/// <summary>
		/// The Sord is deleted at this user.
		/// </summary>
		/// <remarks>
		/// <p>Is undefined if isDeleted() returns false.</p>
		/// </remarks>
		public int deleteUser
		{
			get
			{
				return deleteUserValue;
			}
			set
			{
				this.deleteUserValue = value;
				setChangedMember(SordC.mbDeleteUser);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String SRegValue;

		protected String TStampValue;

		protected String aclValue;

		protected int attValue;

		protected int childCountValue;

		protected int docValue;

		protected String guidValue;

		protected int histCountValue;

		protected int idValue;

		protected int infoValue;

		protected int keyValue;

		protected int kindValue;

		protected int lockIdValue;

		protected int maskValue;

		protected String nameValue;

		protected int ownerIdValue;

		protected int parentIdValue;

		protected int pathValue;

		protected int typeValue;

		protected int vtRepValue;

		protected String IDateIsoValue;

		protected String XDateIsoValue;

		protected int accessValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected String delDateIsoValue;

		protected bool deletedValue;

		protected String descValue;

		protected EloixClient.IndexServer.SordDetails detailsValue;

		protected EloixClient.IndexServer.DocVersion docVersionValue;

		protected String hiddenTextValue;

		protected EloixClient.IndexServer.SordLink[] linksComeInValue;

		protected EloixClient.IndexServer.SordLink[] linksGoOutValue;

		protected String lockNameValue;

		protected EloixClient.IndexServer.ObjKey[] objKeysValue;

		protected String ownerNameValue;

		protected String[] parentIdsValue;

		protected EloixClient.IndexServer.ArcPath[] refPathsValue;

		protected EloixClient.IndexServer.ReplSetName[] replNamesValue;

		protected EloixClient.IndexServer.ReplSet replSetValue;

		protected String maskNameValue;

		protected EloixClient.IndexServer.DocVersion attVersionValue;

		protected String deleteDateIsoValue;

		protected int lockIdSordValue;

		protected int lockIdDocValue;

		protected String lockNameSordValue;

		protected String lockNameDocValue;

		protected String TStampSyncValue;

		protected String TStampAclValue;

		protected String TStampAclSyncValue;

		protected int deleteUserValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1576327931L;		
	} // end class
}  // end namespace

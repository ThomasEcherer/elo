#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SessionOptionsC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring SessionOptionsC::CLIENT_APP_NAME = std::wstring(L"clientApp.name");

const ::std::wstring SessionOptionsC::CLIENT_APP_VERSION = std::wstring(L"clientApp.version");

const ::std::wstring SessionOptionsC::CLIENT_APP_TYPE = std::wstring(L"clientApp.type");

const ::std::wstring SessionOptionsC::TYPE_PARTNER_APPLICATION = std::wstring(L"TDBD");

const ::std::wstring SessionOptionsC::APP_TYPE_MINI_CLIENT = std::wstring(L"DRFJ");

const ::std::wstring SessionOptionsC::DB_ESCAPE_CHAR = std::wstring(L"db.escapeChar");

const ::std::wstring SessionOptionsC::DB_WILDCARDS = std::wstring(L"db.wildcards");

const ::std::wstring SessionOptionsC::DIRECT_DM_ACCESS = std::wstring(L"ix.directDMAccess");

const ::std::wstring SessionOptionsC::ENCRYPT_DOCUMENTS = std::wstring(L"ix.encryptDocuments");

const ::std::wstring SessionOptionsC::DECRYPT_DOCUMENTS = std::wstring(L"ix.decryptDocuments");

const ::std::wstring SessionOptionsC::TRANSLATE_TERMS = std::wstring(L"ix.translateTerms");

const ::std::wstring SessionOptionsC::ISO_DATE_WITH_DELIMS = std::wstring(L"ix.isoDateWithDelims");

const ::std::wstring SessionOptionsC::START_DOCMASK_WORKFLOWS = std::wstring(L"ix.startDocMaskWorkflows");

const ::std::wstring SessionOptionsC::IX_URL_BASE = std::wstring(L"ix.ixUrlBase");

const ::std::wstring SessionOptionsC::DOC_URL_BASE = std::wstring(L"ix.documentUrlBase");

const ::std::wstring SessionOptionsC::DOWNLOAD_URL_TYPE = std::wstring(L"ix.downloadUrlType");

const ::std::wstring SessionOptionsC::DOWNLOAD_URL_TYPE_TEMPORARY = std::wstring(L"temporary");

const ::std::wstring SessionOptionsC::DOWNLOAD_URL_TYPE_PERSISTENT = std::wstring(L"persistent");

const ::std::wstring SessionOptionsC::DOWNLOAD_URL_TYPE_PUBLIC = std::wstring(L"public");

const ::std::wstring SessionOptionsC::DOWNLOAD_URL_TYPE_PUBLIC_VERSION = std::wstring(L"public_version");

const ::std::wstring SessionOptionsC::PUBLIC_DOWNLOAD_COUNT = std::wstring(L"ix.publicDownloadCount");

const ::std::wstring SessionOptionsC::PUBLIC_DOWNLOAD_EXPIREDTIME = std::wstring(L"ix.publicDownloadExpiredTime");

const ::std::wstring SessionOptionsC::APPLY_ALL_BLACKENINGS = std::wstring(L"ix.applyAllBlackenings");

const ::std::wstring SessionOptionsC::DISABLE_CHANGE_INFO_PROTECTION = std::wstring(L"ix.disableChangeInfoProtection");

const ::std::wstring SessionOptionsC::HANDLE_IX_SERVER_EVENTS = std::wstring(L"ix.handleIXServerEvents");

// checkpoint byps.gen.cpp.GenApiClass:489
SessionOptionsC::SessionOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SessionOptionsC::BSerializable_getTypeId() {
	return 2000345779; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SessionOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2000345779(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SessionOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Sord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Sord::Sord() {
	att = 0;
	childCount = 0;
	doc = 0;
	histCount = 0;
	id = 0;
	info = 0;
	key = 0;
	kind = 0;
	lockId = 0;
	mask = 0;
	ownerId = 0;
	parentId = 0;
	path = 0;
	type = 0;
	vtRep = 0;
	access = 0;
	deleted = false;
	lockIdSord = 0;
	lockIdDoc = 0;
	deleteUser = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Sord::Sord(const ::std::wstring& SReg, const ::std::wstring& TStamp, const ::std::wstring& acl, int32_t att, int32_t childCount, int32_t doc, const ::std::wstring& guid, int32_t histCount, int32_t id, int32_t info, int32_t key, int32_t kind, int32_t lockId, int32_t mask, const ::std::wstring& name, int32_t ownerId, int32_t parentId, int32_t path, int32_t type, int32_t vtRep, const ::std::wstring& IDateIso, const ::std::wstring& XDateIso, int32_t access, const PArrayAclItem& aclItems, const ::std::wstring& delDateIso, bool deleted, const ::std::wstring& desc, const PSordDetails& details, const PDocVersion& docVersion, const ::std::wstring& hiddenText, const PArraySordLink& linksComeIn, const PArraySordLink& linksGoOut, const ::std::wstring& lockName, const PArrayObjKey& objKeys, const ::std::wstring& ownerName, const PArrayString& parentIds, const PArrayArcPath& refPaths, const PArrayReplSetName& replNames, const PReplSet& replSet, const ::std::wstring& maskName, const PDocVersion& attVersion, const ::std::wstring& deleteDateIso, int32_t lockIdSord, int32_t lockIdDoc, const ::std::wstring& lockNameSord, const ::std::wstring& lockNameDoc, const ::std::wstring& TStampSync, const ::std::wstring& TStampAcl, const ::std::wstring& TStampAclSync, int32_t deleteUser)
	: SReg(SReg)
	, TStamp(TStamp)
	, acl(acl)
	, att(att)
	, childCount(childCount)
	, doc(doc)
	, guid(guid)
	, histCount(histCount)
	, id(id)
	, info(info)
	, key(key)
	, kind(kind)
	, lockId(lockId)
	, mask(mask)
	, name(name)
	, ownerId(ownerId)
	, parentId(parentId)
	, path(path)
	, type(type)
	, vtRep(vtRep)
	, IDateIso(IDateIso)
	, XDateIso(XDateIso)
	, access(access)
	, aclItems(aclItems)
	, delDateIso(delDateIso)
	, deleted(deleted)
	, desc(desc)
	, details(details)
	, docVersion(docVersion)
	, hiddenText(hiddenText)
	, linksComeIn(linksComeIn)
	, linksGoOut(linksGoOut)
	, lockName(lockName)
	, objKeys(objKeys)
	, ownerName(ownerName)
	, parentIds(parentIds)
	, refPaths(refPaths)
	, replNames(replNames)
	, replSet(replSet)
	, maskName(maskName)
	, attVersion(attVersion)
	, deleteDateIso(deleteDateIso)
	, lockIdSord(lockIdSord)
	, lockIdDoc(lockIdDoc)
	, lockNameSord(lockNameSord)
	, lockNameDoc(lockNameDoc)
	, TStampSync(TStampSync)
	, TStampAcl(TStampAcl)
	, TStampAclSync(TStampAclSync)
	, deleteUser(deleteUser)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Sord::BSerializable_getTypeId() {
	return 1576327931; 
}
void Sord::setSReg(::std::wstring v) {
	SReg = v;
	setChangedMember(SordC::mbSReg);
}
void Sord::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(SordC::mbTStamp);
}
void Sord::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(SordC::mbAclItems);
}
void Sord::setAtt(int32_t v) {
	att = v;
	setChangedMember(SordC::mbAttVersionMembers);
}
void Sord::setChildCount(int32_t v) {
	childCount = v;
	setChangedMember(SordC::mbChildCount);
}
void Sord::setDoc(int32_t v) {
	doc = v;
	setChangedMember(SordC::mbDocVersionMembers);
}
void Sord::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(SordC::mbGuid);
}
void Sord::setHistCount(int32_t v) {
	histCount = v;
	setChangedMember(SordC::mbHistCount);
}
void Sord::setId(int32_t v) {
	id = v;
	setChangedMember(SordC::mbId);
}
void Sord::setInfo(int32_t v) {
	info = v;
	setChangedMember(SordC::mbInfo);
}
void Sord::setKey(int32_t v) {
	key = v;
	setChangedMember(SordC::mbKey);
}
void Sord::setKind(int32_t v) {
	kind = v;
	setChangedMember(SordC::mbKind);
}
void Sord::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(SordC::mbLockId);
}
void Sord::setMask(int32_t v) {
	mask = v;
	setChangedMember(SordC::mbMask);
}
void Sord::setName(::std::wstring v) {
	name = v;
	setChangedMember(SordC::mbName);
}
void Sord::setOwnerId(int32_t v) {
	ownerId = v;
	setChangedMember(SordC::mbOwnerId);
}
void Sord::setParentId(int32_t v) {
	parentId = v;
	setChangedMember(SordC::mbParentIds);
}
void Sord::setPath(int32_t v) {
	path = v;
	setChangedMember(SordC::mbPath);
}
void Sord::setType(int32_t v) {
	type = v;
	setChangedMember(SordC::mbType);
}
void Sord::setVtRep(int32_t v) {
	vtRep = v;
	setChangedMember(SordC::mbVtRep);
}
void Sord::setIDateIso(::std::wstring v) {
	IDateIso = v;
	setChangedMember(SordC::mbIDateIso);
}
void Sord::setXDateIso(::std::wstring v) {
	XDateIso = v;
	setChangedMember(SordC::mbXDateIso);
}
void Sord::setAccess(int32_t v) {
	access = v;
}
void Sord::setAclItems(PArrayAclItem v) {
	aclItems = v;
	setChangedMember(SordC::mbAclItems);
}
void Sord::setDelDateIso(::std::wstring v) {
	delDateIso = v;
	setChangedMember(SordC::mbDelDateIso);
}
void Sord::setDeleted(bool v) {
	deleted = v;
	setChangedMember(SordC::mbDeleted);
}
void Sord::setDesc(::std::wstring v) {
	desc = v;
	setChangedMember(SordC::mbDesc);
}
void Sord::setDetails(PSordDetails v) {
	details = v;
	setChangedMember(SordC::mbDetails);
}
void Sord::setDocVersion(PDocVersion v) {
	docVersion = v;
	setChangedMember(SordC::mbDocVersionMembers);
}
void Sord::setHiddenText(::std::wstring v) {
	hiddenText = v;
	setChangedMember(SordC::mbHiddenText);
}
void Sord::setLinksComeIn(PArraySordLink v) {
	linksComeIn = v;
	setChangedMember(SordC::mbLinksComeIn);
}
void Sord::setLinksGoOut(PArraySordLink v) {
	linksGoOut = v;
	setChangedMember(SordC::mbLinksGoOut);
}
void Sord::setLockName(::std::wstring v) {
	lockName = v;
}
void Sord::setObjKeys(PArrayObjKey v) {
	objKeys = v;
	setChangedMember(SordC::mbObjKeys);
}
void Sord::setOwnerName(::std::wstring v) {
	ownerName = v;
	setChangedMember(SordC::mbOwnerName);
}
void Sord::setParentIds(PArrayString v) {
	parentIds = v;
	setChangedMember(SordC::mbParentIds);
}
void Sord::setRefPaths(PArrayArcPath v) {
	refPaths = v;
	setChangedMember(SordC::mbRefPaths);
}
void Sord::setReplNames(PArrayReplSetName v) {
	replNames = v;
	setChangedMember(SordC::mbReplNames);
}
void Sord::setReplSet(PReplSet v) {
	replSet = v;
	setChangedMember(SordC::mbReplSet);
}
void Sord::setMaskName(::std::wstring v) {
	maskName = v;
}
void Sord::setAttVersion(PDocVersion v) {
	attVersion = v;
	setChangedMember(SordC::mbAttVersionMembers);
}
void Sord::setDeleteDateIso(::std::wstring v) {
	deleteDateIso = v;
}
void Sord::setLockIdSord(int32_t v) {
	lockIdSord = v;
	setChangedMember(SordC::mbLockIdSord);
}
void Sord::setLockIdDoc(int32_t v) {
	lockIdDoc = v;
	setChangedMember(SordC::mbLockIdDoc);
}
void Sord::setLockNameSord(::std::wstring v) {
	lockNameSord = v;
}
void Sord::setLockNameDoc(::std::wstring v) {
	lockNameDoc = v;
}
void Sord::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(SordC::mbTStampSync);
}
void Sord::setTStampAcl(::std::wstring v) {
	TStampAcl = v;
	setChangedMember(SordC::mbTStampAcl);
}
void Sord::setTStampAclSync(::std::wstring v) {
	TStampAclSync = v;
	setChangedMember(SordC::mbTStampAclSync);
}
void Sord::setDeleteUser(int32_t v) {
	deleteUser = v;
	setChangedMember(SordC::mbDeleteUser);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Sord::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->IDateIso;
	ar & this->SReg;
	ar & this->TStamp;
	ar & this->XDateIso;
	ar & this->access;
	ar & this->acl;
	ar & this->att;
	ar & this->childCount;
	ar & this->delDateIso;
	ar & this->deleted;
	ar & this->desc;
	ar & this->doc;
	ar & this->guid;
	ar & this->hiddenText;
	ar & this->histCount;
	ar & this->id;
	ar & this->info;
	ar & this->key;
	ar & this->kind;
	ar & this->lockId;
	ar & this->lockName;
	ar & this->mask;
	ar & this->name;
	ar & this->ownerId;
	ar & this->ownerName;
	ar & this->parentId;
	ar & this->path;
	ar & this->type;
	ar & this->vtRep;
	if (version >= 700000000000028) {
		ar & this->maskName;
		if (version >= 900000000000000) {
			ar & this->deleteDateIso;
			if (version >= 900990009000001) {
				ar & this->TStampAcl;
				ar & this->TStampAclSync;
				ar & this->TStampSync;
				ar & this->lockIdDoc;
				ar & this->lockIdSord;
				ar & this->lockNameDoc;
				ar & this->lockNameSord;
				if (version >= 1000000020000012) {
					ar & this->deleteUser;
				}
			}
		}
	}
	ar & this->aclItems;
	ar & this->details;
	ar & this->docVersion;
	ar & this->linksComeIn;
	ar & this->linksGoOut;
	ar & this->objKeys;
	ar & this->parentIds;
	ar & this->refPaths;
	ar & this->replNames;
	ar & this->replSet;
	if (version >= 700000040000007) {
		ar & this->attVersion;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1576327931(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Sord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordC
// Generated from class byps.gen.cpp.GenApiClass

const PSordZ SordC::mbAll = PSordZ(new SordZ(
	2145422063697919LL));

const PSordZ SordC::mbLean = PSordZ(new SordZ(
	10168869847039LL));

const PSordZ SordC::mbAllIndex = PSordZ(new SordZ(
	438980017389567LL));

const PSordZ SordC::mbMin = PSordZ(new SordZ(
	1372776824831LL));

const PSordZ SordC::mbOnlyId = PSordZ(new SordZ(
	1LL));

const PSordZ SordC::mbOnlyGuid = PSordZ(new SordZ(
	2LL));

const PSordZ SordC::mbOnlyLock = PSordZ(new SordZ(
	0LL));

const PSordZ SordC::mbOnlyUnlock = PSordZ(new SordZ(
	0LL));

const PSordZ SordC::mbMinDocVersion = PSordZ(new SordZ(
	89333707046911LL));

const PSordZ SordC::mbCheckout = PSordZ(new SordZ(
	2180606435786751LL));

const PSordZ SordC::mbCheckoutPreview = PSordZ(new SordZ(
	2250975179964415LL));

const ::std::wstring SordC::DESC_DELIM = std::wstring(L"!!ELO_DELIM!!");

// checkpoint byps.gen.cpp.GenApiClass:489
SordC::SordC() {
	lnDesc = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordC::SordC(int64_t mbAclItems, int64_t mbReplSet, int64_t mbReplNames, int64_t mbObjKeys, int64_t mbDocVersionMembers, int64_t mbSmallDocumentContent, int64_t mbPreview, int64_t mbPhysPath, int64_t mbParentIds, int64_t mbLinks, int64_t mbRefPaths, int64_t mbAttVersionMembers, int64_t mbContentStream, int64_t mbIDateIso, int64_t mbXDateIso, int64_t mbDelDateIso, int64_t mbDeleted, int64_t mbDetails, int64_t mbDocVersion, int64_t mbHiddenText, int64_t mbLinksComeIn, int64_t mbLinksGoOut, int64_t mbOwnerName, int64_t mbDesc, int64_t mbReadOnlyMembers, int64_t mbWriteOnlyMembers, int32_t lnDesc, int64_t mbAllMembers, int64_t mbLeanMembers, int64_t mbReplMembers, int64_t mbMinMembers, int32_t LBT_DOCUMENT, int32_t LBT_DOCUMENT_MAX, int32_t LBT_ARCHIVE, int32_t TYPE_USER_FOLDER, int32_t ATTACHMENT_FLAG_IN_DOCHISTORY, const PSordZ& mbAll, const PSordZ& mbLean, const PSordZ& mbAllIndex, const PSordZ& mbMin, const PSordZ& mbOnlyId, const PSordZ& mbOnlyGuid, const PSordZ& mbOnlyLock, const PSordZ& mbOnlyUnlock, const PSordZ& mbMinDocVersion, const PSordZ& mbCheckout, const PSordZ& mbCheckoutPreview, const ::std::wstring& DESC_DELIM, const ::std::wstring& GUID_REPLICATION_BASE, const ::std::wstring& GUID_SCRIPTING_BASE, const ::std::wstring& GUID_IX_SCRIPTING_BASE, const ::std::wstring& GUID_ADMINISTRATION_BASE, const ::std::wstring& GUID_COLD_BACKGROUND_IMAGES, const ::std::wstring& GUID_WIN_SCRIPTING_BASE, const ::std::wstring& GUID_WORKFLOW_ICONS_BASE, const ::std::wstring& GUID_WFNODE_ICON_BEGINNODE, const ::std::wstring& GUID_WFNODE_ICON_PERSONNODE, const ::std::wstring& GUID_WFNODE_ICON_IFNODE, const ::std::wstring& GUID_WFNODE_ICON_COLLECTNODE, const ::std::wstring& GUID_WFNODE_ICON_TERMINATE, const ::std::wstring& GUID_WFNODE_ICON_CYCLE_BEGIN, const ::std::wstring& GUID_WFNODE_ICON_CYCLE_END, const ::std::wstring& GUID_WFNODE_ICON_SET_SERVER_ID, const ::std::wstring& GUID_WFNODE_ICON_SPLITNODE, const ::std::wstring& GUID_USERS_FOLDER, const ::std::wstring& GUID_TEXTREADER_FOLDER, const ::std::wstring& GUID_TRNOTCONV_FOLDER, const ::std::wstring& GUID_APPS_FOLDER, const ::std::wstring& ELOINDEX_USER_FOLDER_DATA, const ::std::wstring& ELOINDEX_USER_FOLDER_DATA_PROFILE, const ::std::wstring& ELOINDEX_USER_FOLDER_PRIVATE, const ::std::wstring& ELOINDEX_USER_FOLDER_INBOX)
	: lnDesc(lnDesc)
	, GUID_REPLICATION_BASE(GUID_REPLICATION_BASE)
	, GUID_SCRIPTING_BASE(GUID_SCRIPTING_BASE)
	, GUID_IX_SCRIPTING_BASE(GUID_IX_SCRIPTING_BASE)
	, GUID_ADMINISTRATION_BASE(GUID_ADMINISTRATION_BASE)
	, GUID_COLD_BACKGROUND_IMAGES(GUID_COLD_BACKGROUND_IMAGES)
	, GUID_WIN_SCRIPTING_BASE(GUID_WIN_SCRIPTING_BASE)
	, GUID_WORKFLOW_ICONS_BASE(GUID_WORKFLOW_ICONS_BASE)
	, GUID_WFNODE_ICON_BEGINNODE(GUID_WFNODE_ICON_BEGINNODE)
	, GUID_WFNODE_ICON_PERSONNODE(GUID_WFNODE_ICON_PERSONNODE)
	, GUID_WFNODE_ICON_IFNODE(GUID_WFNODE_ICON_IFNODE)
	, GUID_WFNODE_ICON_COLLECTNODE(GUID_WFNODE_ICON_COLLECTNODE)
	, GUID_WFNODE_ICON_TERMINATE(GUID_WFNODE_ICON_TERMINATE)
	, GUID_WFNODE_ICON_CYCLE_BEGIN(GUID_WFNODE_ICON_CYCLE_BEGIN)
	, GUID_WFNODE_ICON_CYCLE_END(GUID_WFNODE_ICON_CYCLE_END)
	, GUID_WFNODE_ICON_SET_SERVER_ID(GUID_WFNODE_ICON_SET_SERVER_ID)
	, GUID_WFNODE_ICON_SPLITNODE(GUID_WFNODE_ICON_SPLITNODE)
	, GUID_USERS_FOLDER(GUID_USERS_FOLDER)
	, GUID_TEXTREADER_FOLDER(GUID_TEXTREADER_FOLDER)
	, GUID_TRNOTCONV_FOLDER(GUID_TRNOTCONV_FOLDER)
	, GUID_APPS_FOLDER(GUID_APPS_FOLDER)
	, ELOINDEX_USER_FOLDER_DATA(ELOINDEX_USER_FOLDER_DATA)
	, ELOINDEX_USER_FOLDER_DATA_PROFILE(ELOINDEX_USER_FOLDER_DATA_PROFILE)
	, ELOINDEX_USER_FOLDER_PRIVATE(ELOINDEX_USER_FOLDER_PRIVATE)
	, ELOINDEX_USER_FOLDER_INBOX(ELOINDEX_USER_FOLDER_INBOX)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordC::BSerializable_getTypeId() {
	return 1553100003; 
}
void SordC::setLnDesc(int32_t v) {
	lnDesc = v;
}
void SordC::setGUID_REPLICATION_BASE(::std::wstring v) {
	GUID_REPLICATION_BASE = v;
}
void SordC::setGUID_SCRIPTING_BASE(::std::wstring v) {
	GUID_SCRIPTING_BASE = v;
}
void SordC::setGUID_IX_SCRIPTING_BASE(::std::wstring v) {
	GUID_IX_SCRIPTING_BASE = v;
}
void SordC::setGUID_ADMINISTRATION_BASE(::std::wstring v) {
	GUID_ADMINISTRATION_BASE = v;
}
void SordC::setGUID_COLD_BACKGROUND_IMAGES(::std::wstring v) {
	GUID_COLD_BACKGROUND_IMAGES = v;
}
void SordC::setGUID_WIN_SCRIPTING_BASE(::std::wstring v) {
	GUID_WIN_SCRIPTING_BASE = v;
}
void SordC::setGUID_WORKFLOW_ICONS_BASE(::std::wstring v) {
	GUID_WORKFLOW_ICONS_BASE = v;
}
void SordC::setGUID_WFNODE_ICON_BEGINNODE(::std::wstring v) {
	GUID_WFNODE_ICON_BEGINNODE = v;
}
void SordC::setGUID_WFNODE_ICON_PERSONNODE(::std::wstring v) {
	GUID_WFNODE_ICON_PERSONNODE = v;
}
void SordC::setGUID_WFNODE_ICON_IFNODE(::std::wstring v) {
	GUID_WFNODE_ICON_IFNODE = v;
}
void SordC::setGUID_WFNODE_ICON_COLLECTNODE(::std::wstring v) {
	GUID_WFNODE_ICON_COLLECTNODE = v;
}
void SordC::setGUID_WFNODE_ICON_TERMINATE(::std::wstring v) {
	GUID_WFNODE_ICON_TERMINATE = v;
}
void SordC::setGUID_WFNODE_ICON_CYCLE_BEGIN(::std::wstring v) {
	GUID_WFNODE_ICON_CYCLE_BEGIN = v;
}
void SordC::setGUID_WFNODE_ICON_CYCLE_END(::std::wstring v) {
	GUID_WFNODE_ICON_CYCLE_END = v;
}
void SordC::setGUID_WFNODE_ICON_SET_SERVER_ID(::std::wstring v) {
	GUID_WFNODE_ICON_SET_SERVER_ID = v;
}
void SordC::setGUID_WFNODE_ICON_SPLITNODE(::std::wstring v) {
	GUID_WFNODE_ICON_SPLITNODE = v;
}
void SordC::setGUID_USERS_FOLDER(::std::wstring v) {
	GUID_USERS_FOLDER = v;
}
void SordC::setGUID_TEXTREADER_FOLDER(::std::wstring v) {
	GUID_TEXTREADER_FOLDER = v;
}
void SordC::setGUID_TRNOTCONV_FOLDER(::std::wstring v) {
	GUID_TRNOTCONV_FOLDER = v;
}
void SordC::setGUID_APPS_FOLDER(::std::wstring v) {
	GUID_APPS_FOLDER = v;
}
void SordC::setELOINDEX_USER_FOLDER_DATA(::std::wstring v) {
	ELOINDEX_USER_FOLDER_DATA = v;
}
void SordC::setELOINDEX_USER_FOLDER_DATA_PROFILE(::std::wstring v) {
	ELOINDEX_USER_FOLDER_DATA_PROFILE = v;
}
void SordC::setELOINDEX_USER_FOLDER_PRIVATE(::std::wstring v) {
	ELOINDEX_USER_FOLDER_PRIVATE = v;
}
void SordC::setELOINDEX_USER_FOLDER_INBOX(::std::wstring v) {
	ELOINDEX_USER_FOLDER_INBOX = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordC::serialize(BIO& ar, const BVERSION version) {
	ObjDataC::serialize(ar, version);
	ar & this->GUID_ADMINISTRATION_BASE;
	ar & this->GUID_REPLICATION_BASE;
	ar & this->GUID_SCRIPTING_BASE;
	ar & this->lnDesc;
	if (version >= 700000000000029) {
		ar & this->GUID_IX_SCRIPTING_BASE;
		if (version >= 700000022000001) {
			ar & this->GUID_COLD_BACKGROUND_IMAGES;
			if (version >= 700000022000003) {
				ar & this->GUID_WIN_SCRIPTING_BASE;
				if (version >= 700000040000012) {
					ar & this->GUID_WFNODE_ICON_BEGINNODE;
					ar & this->GUID_WFNODE_ICON_COLLECTNODE;
					ar & this->GUID_WFNODE_ICON_CYCLE_BEGIN;
					ar & this->GUID_WFNODE_ICON_CYCLE_END;
					ar & this->GUID_WFNODE_ICON_IFNODE;
					ar & this->GUID_WFNODE_ICON_PERSONNODE;
					ar & this->GUID_WFNODE_ICON_SET_SERVER_ID;
					ar & this->GUID_WFNODE_ICON_SPLITNODE;
					ar & this->GUID_WFNODE_ICON_TERMINATE;
					ar & this->GUID_WORKFLOW_ICONS_BASE;
					if (version >= 900000000000011) {
						ar & this->GUID_USERS_FOLDER;
						if (version >= 900000000000032) {
							ar & this->ELOINDEX_USER_FOLDER_DATA;
							ar & this->ELOINDEX_USER_FOLDER_DATA_PROFILE;
							ar & this->ELOINDEX_USER_FOLDER_INBOX;
							ar & this->ELOINDEX_USER_FOLDER_PRIVATE;
							if (version >= 900000016000019) {
								ar & this->GUID_TEXTREADER_FOLDER;
								ar & this->GUID_TRNOTCONV_FOLDER;
								if (version >= 900990009000008) {
									ar & this->GUID_APPS_FOLDER;
								}
							}
						}
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1553100003(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordDetails
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordDetails::SordDetails() {
	archivingMode = 0;
	encryptionSet = 0;
	fulltext = false;
	sortOrder = 0;
	arcReplEnabled = false;
	fulltextDone = false;
	replRoot = false;
	linked = false;
	incomplete = false;
	limitedReleaseDocument = false;
	linkedPermanent = false;
	documentContainer = false;
	translateSordName = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordDetails::SordDetails(int32_t archivingMode, int32_t encryptionSet, bool fulltext, int32_t sortOrder, bool arcReplEnabled, bool fulltextDone, bool replRoot, bool linked, bool incomplete, bool limitedReleaseDocument, bool linkedPermanent, bool documentContainer, bool translateSordName)
	: archivingMode(archivingMode)
	, encryptionSet(encryptionSet)
	, fulltext(fulltext)
	, sortOrder(sortOrder)
	, arcReplEnabled(arcReplEnabled)
	, fulltextDone(fulltextDone)
	, replRoot(replRoot)
	, linked(linked)
	, incomplete(incomplete)
	, limitedReleaseDocument(limitedReleaseDocument)
	, linkedPermanent(linkedPermanent)
	, documentContainer(documentContainer)
	, translateSordName(translateSordName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordDetails::BSerializable_getTypeId() {
	return 1713693326; 
}
void SordDetails::setArchivingMode(int32_t v) {
	archivingMode = v;
}
void SordDetails::setEncryptionSet(int32_t v) {
	encryptionSet = v;
}
void SordDetails::setFulltext(bool v) {
	fulltext = v;
}
void SordDetails::setSortOrder(int32_t v) {
	sortOrder = v;
}
void SordDetails::setArcReplEnabled(bool v) {
	arcReplEnabled = v;
}
void SordDetails::setFulltextDone(bool v) {
	fulltextDone = v;
}
void SordDetails::setReplRoot(bool v) {
	replRoot = v;
}
void SordDetails::setLinked(bool v) {
	linked = v;
}
void SordDetails::setIncomplete(bool v) {
	incomplete = v;
}
void SordDetails::setLimitedReleaseDocument(bool v) {
	limitedReleaseDocument = v;
}
void SordDetails::setLinkedPermanent(bool v) {
	linkedPermanent = v;
}
void SordDetails::setDocumentContainer(bool v) {
	documentContainer = v;
}
void SordDetails::setTranslateSordName(bool v) {
	translateSordName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordDetails::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->arcReplEnabled;
	ar & this->archivingMode;
	ar & this->encryptionSet;
	ar & this->fulltext;
	ar & this->fulltextDone;
	ar & this->replRoot;
	ar & this->sortOrder;
	if (version >= 700000000000046) {
		ar & this->linked;
		if (version >= 800000026000001) {
			ar & this->incomplete;
			if (version >= 800000032000007) {
				ar & this->limitedReleaseDocument;
				if (version >= 900000016000008) {
					ar & this->linkedPermanent;
					if (version >= 900000018000004) {
						ar & this->documentContainer;
						if (version >= 900000030000013) {
							ar & this->translateSordName;
						}
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1713693326(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordDetails>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordHist
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordHist::SordHist() {
	histSource = 0;
	userNo = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordHist::SordHist(const ::std::wstring& histGuid, int32_t histSource, const ::std::wstring& objGuid, const ::std::wstring& timeStampLocal, const ::std::wstring& timeStampUTC, const ::std::wstring& userName, int32_t userNo, const ::std::wstring& workStation, const PArraySordHistKey& histKeys)
	: histGuid(histGuid)
	, histSource(histSource)
	, objGuid(objGuid)
	, timeStampLocal(timeStampLocal)
	, timeStampUTC(timeStampUTC)
	, userName(userName)
	, userNo(userNo)
	, workStation(workStation)
	, histKeys(histKeys)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordHist::BSerializable_getTypeId() {
	return 2121567102; 
}
void SordHist::setHistGuid(::std::wstring v) {
	histGuid = v;
	setChangedMember(SordHistC::mbHistGuid);
}
void SordHist::setHistSource(int32_t v) {
	histSource = v;
	setChangedMember(SordHistC::mbHistSource);
}
void SordHist::setObjGuid(::std::wstring v) {
	objGuid = v;
	setChangedMember(SordHistC::mbObjGuid);
}
void SordHist::setTimeStampLocal(::std::wstring v) {
	timeStampLocal = v;
	setChangedMember(SordHistC::mbTimeStampLocal);
}
void SordHist::setTimeStampUTC(::std::wstring v) {
	timeStampUTC = v;
	setChangedMember(SordHistC::mbTimeStampUTC);
}
void SordHist::setUserName(::std::wstring v) {
	userName = v;
	setChangedMember(SordHistC::mbUserName);
}
void SordHist::setUserNo(int32_t v) {
	userNo = v;
	setChangedMember(SordHistC::mbUserNo);
}
void SordHist::setWorkStation(::std::wstring v) {
	workStation = v;
	setChangedMember(SordHistC::mbWorkStation);
}
void SordHist::setHistKeys(PArraySordHistKey v) {
	histKeys = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordHist::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->histGuid;
	ar & this->histSource;
	ar & this->objGuid;
	ar & this->timeStampLocal;
	ar & this->timeStampUTC;
	ar & this->userName;
	ar & this->userNo;
	ar & this->workStation;
	ar & this->histKeys;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2121567102(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordHist>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordHistC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordHistC::SordHistC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordHistC::BSerializable_getTypeId() {
	return 520610723; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordHistC::serialize(BIO& ar, const BVERSION version) {
	ObjHistC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_520610723(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordHistC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordHistKey
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordHistKey::SordHistKey() {
	keyNo = 0;
	keyIndex = 0;
	keyId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordHistKey::SordHistKey(const ::std::wstring& histGuid, const ::std::wstring& keyData, const ::std::wstring& keyName, int32_t keyNo, int32_t keyIndex, int32_t keyId)
	: histGuid(histGuid)
	, keyData(keyData)
	, keyName(keyName)
	, keyNo(keyNo)
	, keyIndex(keyIndex)
	, keyId(keyId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordHistKey::BSerializable_getTypeId() {
	return 251810638; 
}
void SordHistKey::setHistGuid(::std::wstring v) {
	histGuid = v;
	setChangedMember(SordHistKeyC::mbHistGuid);
}
void SordHistKey::setKeyData(::std::wstring v) {
	keyData = v;
	setChangedMember(SordHistKeyC::mbKeyData);
}
void SordHistKey::setKeyName(::std::wstring v) {
	keyName = v;
	setChangedMember(SordHistKeyC::mbKeyName);
}
void SordHistKey::setKeyNo(int32_t v) {
	keyNo = v;
	setChangedMember(SordHistKeyC::mbKeyNo);
}
void SordHistKey::setKeyIndex(int32_t v) {
	keyIndex = v;
}
void SordHistKey::setKeyId(int32_t v) {
	keyId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordHistKey::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->histGuid;
	ar & this->keyData;
	ar & this->keyName;
	ar & this->keyNo;
	if (version >= 800000032000007) {
		ar & this->keyId;
		ar & this->keyIndex;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_251810638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordHistKey>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordHistKeyC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring SordHistKeyC::NAME_SORD_NAME = std::wstring(L"OBJSHORT");

const ::std::wstring SordHistKeyC::NAME_SORD_XDATE = std::wstring(L"DOCDATE");

const ::std::wstring SordHistKeyC::NAME_SORD_DESC = std::wstring(L"MEMO");

const ::std::wstring SordHistKeyC::NAME_DOCMASK_NAME = std::wstring(L"MNAME");

const ::std::wstring SordHistKeyC::NAME_SORD_ACL = std::wstring(L"ACL");

const ::std::wstring SordHistKeyC::NAME_SORD_DELDATE = std::wstring(L"DELDATE");

// checkpoint byps.gen.cpp.GenApiClass:489
SordHistKeyC::SordHistKeyC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordHistKeyC::BSerializable_getTypeId() {
	return 762601968; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordHistKeyC::serialize(BIO& ar, const BVERSION version) {
	ObjHistKeyC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_762601968(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordHistKeyC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_645430982(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSordHistKey > >(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_491352407(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSordHist > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordLink
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordLink::SordLink() {
	permanent = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordLink::SordLink(const ::std::wstring& id, const ::std::wstring& linkId, bool permanent)
	: id(id)
	, linkId(linkId)
	, permanent(permanent)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordLink::BSerializable_getTypeId() {
	return 200815802; 
}
void SordLink::setId(::std::wstring v) {
	id = v;
	setChangedMember(SordLinkC::mbId);
}
void SordLink::setLinkId(::std::wstring v) {
	linkId = v;
	setChangedMember(SordLinkC::mbLinkId);
}
void SordLink::setPermanent(bool v) {
	permanent = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordLink::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->linkId;
	if (version >= 900000016000008) {
		ar & this->permanent;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_200815802(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordLink>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordLinkC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordLinkC::SordLinkC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordLinkC::BSerializable_getTypeId() {
	return 1347988541; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordLinkC::serialize(BIO& ar, const BVERSION version) {
	ObjLinkC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1347988541(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordLinkC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_376993407(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSordLink > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordPath
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordPath::SordPath() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordPath::SordPath(const PVectorSord& sords)
	: sords(sords)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordPath::BSerializable_getTypeId() {
	return 544862901; 
}
void SordPath::setSords(PVectorSord v) {
	sords = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordPath::serialize(BIO& ar, const BVERSION version) {
	ar & this->sords;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_544862901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordPath>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordPaths
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordPaths::SordPaths() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordPaths::SordPaths(const PVectorSordPath& sordPaths)
	: sordPaths(sordPaths)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordPaths::BSerializable_getTypeId() {
	return 1835331414; 
}
void SordPaths::setSordPaths(PVectorSordPath v) {
	sordPaths = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordPaths::serialize(BIO& ar, const BVERSION version) {
	ar & this->sordPaths;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1835331414(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordPaths>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordType
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordType::SordType() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordType::SordType(const PFileData& disabledIcon, const PArrayString& extensions, const PFileData& icon, int32_t id, const ::std::wstring& name, const PFileData& workflowIcon)
	: disabledIcon(disabledIcon)
	, extensions(extensions)
	, icon(icon)
	, id(id)
	, name(name)
	, workflowIcon(workflowIcon)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordType::BSerializable_getTypeId() {
	return 2065094749; 
}
void SordType::setDisabledIcon(PFileData v) {
	disabledIcon = v;
	setChangedMember(SordTypeC::mbDisabledIconMember);
}
void SordType::setExtensions(PArrayString v) {
	extensions = v;
}
void SordType::setIcon(PFileData v) {
	icon = v;
	setChangedMember(SordTypeC::mbIconMember);
}
void SordType::setId(int32_t v) {
	id = v;
	setChangedMember(SordTypeC::mbIdNameExt);
}
void SordType::setName(::std::wstring v) {
	name = v;
}
void SordType::setWorkflowIcon(PFileData v) {
	workflowIcon = v;
	setChangedMember(SordTypeC::mbWorkflowIconMember);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordType::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->name;
	ar & this->disabledIcon;
	ar & this->extensions;
	ar & this->icon;
	ar & this->workflowIcon;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2065094749(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordType>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordTypeC
// Generated from class byps.gen.cpp.GenApiClass

const PSordTypeZ SordTypeC::mbNoIcons = PSordTypeZ(new SordTypeZ(
	1LL));

const PSordTypeZ SordTypeC::mbIconJPG = PSordTypeZ(new SordTypeZ(
	18LL));

const PSordTypeZ SordTypeC::mbIconBMP = PSordTypeZ(new SordTypeZ(
	34LL));

const PSordTypeZ SordTypeC::mbIconICO = PSordTypeZ(new SordTypeZ(
	66LL));

const PSordTypeZ SordTypeC::mbIconPNG = PSordTypeZ(new SordTypeZ(
	130LL));

const PSordTypeZ SordTypeC::mbIconsJPG = PSordTypeZ(new SordTypeZ(
	26LL));

const PSordTypeZ SordTypeC::mbIconsBMP = PSordTypeZ(new SordTypeZ(
	42LL));

const PSordTypeZ SordTypeC::mbIconsICO = PSordTypeZ(new SordTypeZ(
	74LL));

const PSordTypeZ SordTypeC::mbIconsPNG = PSordTypeZ(new SordTypeZ(
	138LL));

const PSordTypeZ SordTypeC::mbAllJPG = PSordTypeZ(new SordTypeZ(
	30LL));

const PSordTypeZ SordTypeC::mbAllBMP = PSordTypeZ(new SordTypeZ(
	46LL));

const PSordTypeZ SordTypeC::mbAllICO = PSordTypeZ(new SordTypeZ(
	78LL));

const PSordTypeZ SordTypeC::mbAllPNG = PSordTypeZ(new SordTypeZ(
	142LL));

// checkpoint byps.gen.cpp.GenApiClass:489
SordTypeC::SordTypeC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordTypeC::BSerializable_getTypeId() {
	return 635922924; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordTypeC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_635922924(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordTypeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordTypeZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordTypeZ::SordTypeZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordTypeZ::SordTypeZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordTypeZ::BSerializable_getTypeId() {
	return 314474107; 
}
void SordTypeZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordTypeZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_314474107(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordTypeZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_133130047(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSordType > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SordZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SordZ::SordZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SordZ::SordZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SordZ::BSerializable_getTypeId() {
	return 1441094282; 
}
void SordZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SordZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1441094282(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SordZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1559053609(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSordZ > >(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_919539303(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSord > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SortOrderC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SortOrderC::SortOrderC() {
	dummy = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SortOrderC::SortOrderC(int32_t MANUAL, int32_t ALPHA, int32_t XDATE, int32_t IDATE, int32_t IXDATE, int32_t IIDATE, int32_t IALPHA, int32_t DEFAULT, int32_t NONE, int32_t USERNAME, int32_t IUSERNAME, int32_t dummy)
	: dummy(dummy)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SortOrderC::BSerializable_getTypeId() {
	return 1551556842; 
}
void SortOrderC::setDummy(int32_t v) {
	dummy = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SortOrderC::serialize(BIO& ar, const BVERSION version) {
	// skip transient member dummy
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1551556842(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SortOrderC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class StartAdHocWorkflowInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
StartAdHocWorkflowInfo::StartAdHocWorkflowInfo() {
	forValidation = false;
	serialFlow = false;
	deactivateNodes = false;
	flags = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::StartAdHocWorkflowInfo::StartAdHocWorkflowInfo(bool forValidation, bool serialFlow, const ::std::wstring& cancelUserId, const ::std::wstring& cancelMessage, const ::std::wstring& finishedUserId, const ::std::wstring& finishedMessage, const ::std::wstring& finishedScript, const ::std::wstring& nodeName, const ::std::wstring& workflowRepeatMessage, const ::std::wstring& breakWorkflowMessage, const PArrayString& userIdsToDeactivate, bool deactivateNodes, const ::std::wstring& acceptMessage, const ::std::wstring& noticeMessage, const ::std::wstring& actionRejectMessage, const ::std::wstring& successMessage, const PWFTimeLimit& timeLimit, const PArrayWFTimeLimit& timeLimitEscalations, int32_t flags, const PVectorValueClass& nodeInfos)
	: forValidation(forValidation)
	, serialFlow(serialFlow)
	, cancelUserId(cancelUserId)
	, cancelMessage(cancelMessage)
	, finishedUserId(finishedUserId)
	, finishedMessage(finishedMessage)
	, finishedScript(finishedScript)
	, nodeName(nodeName)
	, workflowRepeatMessage(workflowRepeatMessage)
	, breakWorkflowMessage(breakWorkflowMessage)
	, userIdsToDeactivate(userIdsToDeactivate)
	, deactivateNodes(deactivateNodes)
	, acceptMessage(acceptMessage)
	, noticeMessage(noticeMessage)
	, actionRejectMessage(actionRejectMessage)
	, successMessage(successMessage)
	, timeLimit(timeLimit)
	, timeLimitEscalations(timeLimitEscalations)
	, flags(flags)
	, nodeInfos(nodeInfos)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::StartAdHocWorkflowInfo::BSerializable_getTypeId() {
	return 1587514612; 
}
void StartAdHocWorkflowInfo::setForValidation(bool v) {
	forValidation = v;
}
void StartAdHocWorkflowInfo::setSerialFlow(bool v) {
	serialFlow = v;
}
void StartAdHocWorkflowInfo::setCancelUserId(::std::wstring v) {
	cancelUserId = v;
}
void StartAdHocWorkflowInfo::setCancelMessage(::std::wstring v) {
	cancelMessage = v;
}
void StartAdHocWorkflowInfo::setFinishedUserId(::std::wstring v) {
	finishedUserId = v;
}
void StartAdHocWorkflowInfo::setFinishedMessage(::std::wstring v) {
	finishedMessage = v;
}
void StartAdHocWorkflowInfo::setFinishedScript(::std::wstring v) {
	finishedScript = v;
}
void StartAdHocWorkflowInfo::setNodeName(::std::wstring v) {
	nodeName = v;
}
void StartAdHocWorkflowInfo::setWorkflowRepeatMessage(::std::wstring v) {
	workflowRepeatMessage = v;
}
void StartAdHocWorkflowInfo::setBreakWorkflowMessage(::std::wstring v) {
	breakWorkflowMessage = v;
}
void StartAdHocWorkflowInfo::setUserIdsToDeactivate(PArrayString v) {
	userIdsToDeactivate = v;
}
void StartAdHocWorkflowInfo::setDeactivateNodes(bool v) {
	deactivateNodes = v;
}
void StartAdHocWorkflowInfo::setAcceptMessage(::std::wstring v) {
	acceptMessage = v;
}
void StartAdHocWorkflowInfo::setNoticeMessage(::std::wstring v) {
	noticeMessage = v;
}
void StartAdHocWorkflowInfo::setActionRejectMessage(::std::wstring v) {
	actionRejectMessage = v;
}
void StartAdHocWorkflowInfo::setSuccessMessage(::std::wstring v) {
	successMessage = v;
}
void StartAdHocWorkflowInfo::setTimeLimit(PWFTimeLimit v) {
	timeLimit = v;
}
void StartAdHocWorkflowInfo::setTimeLimitEscalations(PArrayWFTimeLimit v) {
	timeLimitEscalations = v;
}
void StartAdHocWorkflowInfo::setFlags(int32_t v) {
	flags = v;
}
void StartAdHocWorkflowInfo::setNodeInfos(PVectorValueClass v) {
	nodeInfos = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void StartAdHocWorkflowInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->breakWorkflowMessage;
	ar & this->cancelMessage;
	ar & this->cancelUserId;
	ar & this->finishedMessage;
	ar & this->finishedScript;
	ar & this->finishedUserId;
	ar & this->forValidation;
	ar & this->nodeName;
	ar & this->serialFlow;
	ar & this->workflowRepeatMessage;
	if (version >= 900000012000004) {
		ar & this->deactivateNodes;
		if (version >= 900000012000006) {
			ar & this->acceptMessage;
			ar & this->noticeMessage;
			if (version >= 900000014000006) {
				ar & this->actionRejectMessage;
				ar & this->successMessage;
				if (version >= 900000016000013) {
					ar & this->flags;
				}
			}
		}
	}
	if (version >= 900000012000004) {
		ar & this->userIdsToDeactivate;
		if (version >= 900000016000009) {
			ar & this->timeLimit;
			ar & this->timeLimitEscalations;
			if (version >= 1000000000000008) {
				ar & this->nodeInfos;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1587514612(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::StartAdHocWorkflowInfo>(bio, pObj, pObjS, pBase);	
}
}}}}

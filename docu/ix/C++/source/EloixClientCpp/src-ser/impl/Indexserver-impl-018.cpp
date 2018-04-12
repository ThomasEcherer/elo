#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CounterInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CounterInfo::CounterInfo() {
	value = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CounterInfo::CounterInfo(const ::std::wstring& name, int32_t value)
	: name(name)
	, value(value)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CounterInfo::BSerializable_getTypeId() {
	return 1809378891; 
}
void CounterInfo::setName(::std::wstring v) {
	name = v;
}
void CounterInfo::setValue(int32_t v) {
	value = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CounterInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->name;
	ar & this->value;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1809378891(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CounterInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CounterInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CounterInfoC::CounterInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CounterInfoC::BSerializable_getTypeId() {
	return 1843901056; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CounterInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1843901056(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CounterInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1698110251(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PCounterInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CryptInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CryptInfo::CryptInfo() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CryptInfo::CryptInfo(int32_t id, const ::std::wstring& name, const ::std::wstring& pwd, const ::std::wstring& keyInfo)
	: id(id)
	, name(name)
	, pwd(pwd)
	, keyInfo(keyInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CryptInfo::BSerializable_getTypeId() {
	return 1826259804; 
}
void CryptInfo::setId(int32_t v) {
	id = v;
}
void CryptInfo::setName(::std::wstring v) {
	name = v;
}
void CryptInfo::setPwd(::std::wstring v) {
	pwd = v;
}
void CryptInfo::setKeyInfo(::std::wstring v) {
	keyInfo = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CryptInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->keyInfo;
	ar & this->name;
	ar & this->pwd;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1826259804(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CryptInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_809229049(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PCryptInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DeleteActivityOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DeleteActivityOptions::DeleteActivityOptions() {
	deleteFinally = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DeleteActivityOptions::DeleteActivityOptions(bool deleteFinally)
	: deleteFinally(deleteFinally)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DeleteActivityOptions::BSerializable_getTypeId() {
	return 78913228; 
}
void DeleteActivityOptions::setDeleteFinally(bool v) {
	deleteFinally = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DeleteActivityOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->deleteFinally;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_78913228(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DeleteActivityOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DeleteOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DeleteOptions::DeleteOptions() {
	deleteFinally = false;
	deleteExpiredOnly = false;
	deleteDocumentVersionsOnly = false;
	deleteCertainDocumentVersionsOnly = false;
	deleteResidueFree = false;
	folderMustBeEmpty = false;
	deleteExpiredFolders = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DeleteOptions::DeleteOptions(bool deleteFinally, const ::std::wstring& maxIDate, bool deleteExpiredOnly, const ::std::wstring& maxTStamp, bool deleteDocumentVersionsOnly, bool deleteCertainDocumentVersionsOnly, bool deleteResidueFree, bool folderMustBeEmpty, bool deleteExpiredFolders)
	: deleteFinally(deleteFinally)
	, maxIDate(maxIDate)
	, deleteExpiredOnly(deleteExpiredOnly)
	, maxTStamp(maxTStamp)
	, deleteDocumentVersionsOnly(deleteDocumentVersionsOnly)
	, deleteCertainDocumentVersionsOnly(deleteCertainDocumentVersionsOnly)
	, deleteResidueFree(deleteResidueFree)
	, folderMustBeEmpty(folderMustBeEmpty)
	, deleteExpiredFolders(deleteExpiredFolders)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DeleteOptions::BSerializable_getTypeId() {
	return 329713511; 
}
void DeleteOptions::setDeleteFinally(bool v) {
	deleteFinally = v;
}
void DeleteOptions::setMaxIDate(::std::wstring v) {
	maxIDate = v;
}
void DeleteOptions::setDeleteExpiredOnly(bool v) {
	deleteExpiredOnly = v;
}
void DeleteOptions::setMaxTStamp(::std::wstring v) {
	maxTStamp = v;
}
void DeleteOptions::setDeleteDocumentVersionsOnly(bool v) {
	deleteDocumentVersionsOnly = v;
}
void DeleteOptions::setDeleteCertainDocumentVersionsOnly(bool v) {
	deleteCertainDocumentVersionsOnly = v;
}
void DeleteOptions::setDeleteResidueFree(bool v) {
	deleteResidueFree = v;
}
void DeleteOptions::setFolderMustBeEmpty(bool v) {
	folderMustBeEmpty = v;
}
void DeleteOptions::setDeleteExpiredFolders(bool v) {
	deleteExpiredFolders = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DeleteOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->deleteFinally;
	ar & this->maxIDate;
	if (version >= 600000098000000) {
		ar & this->deleteExpiredOnly;
		if (version >= 700000000000041) {
			ar & this->maxTStamp;
			if (version >= 700000000000044) {
				ar & this->deleteDocumentVersionsOnly;
				ar & this->deleteResidueFree;
				if (version >= 800000010000003) {
					ar & this->folderMustBeEmpty;
					if (version >= 800000030000002) {
						ar & this->deleteCertainDocumentVersionsOnly;
						if (version >= 800000032000009) {
							ar & this->deleteExpiredFolders;
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
void BSerializer_329713511(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DeleteOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DeleteOrgUnitInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DeleteOrgUnitInfo::DeleteOrgUnitInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DeleteOrgUnitInfo::DeleteOrgUnitInfo(const PArrayInt& ids, const PArrayString& names)
	: ids(ids)
	, names(names)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DeleteOrgUnitInfo::BSerializable_getTypeId() {
	return 537993523; 
}
void DeleteOrgUnitInfo::setIds(PArrayInt v) {
	ids = v;
}
void DeleteOrgUnitInfo::setNames(PArrayString v) {
	names = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DeleteOrgUnitInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->ids;
	ar & this->names;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_537993523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DeleteOrgUnitInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocHistory
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocHistory::DocHistory() {
	objId = 0;
	docId = 0;
	user = 0;
	createDate = 0;
	sigId = 0;
	status = 0;
	flags = 0;
	deleteDate = 0;
	nbOfValidSignatures = 0;
	type = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocHistory::DocHistory(int32_t objId, int32_t docId, int32_t user, int32_t createDate, const ::std::wstring& comment, const ::std::wstring& version, const ::std::wstring& docMD5, const ::std::wstring& guid, const ::std::wstring& tStamp, int32_t sigId, int32_t status, int32_t flags, int32_t deleteDate, int32_t nbOfValidSignatures, int32_t type, const ::std::wstring& TStampSync)
	: objId(objId)
	, docId(docId)
	, user(user)
	, createDate(createDate)
	, comment(comment)
	, version(version)
	, docMD5(docMD5)
	, guid(guid)
	, tStamp(tStamp)
	, sigId(sigId)
	, status(status)
	, flags(flags)
	, deleteDate(deleteDate)
	, nbOfValidSignatures(nbOfValidSignatures)
	, type(type)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocHistory::BSerializable_getTypeId() {
	return 189452795; 
}
void DocHistory::setObjId(int32_t v) {
	objId = v;
	setChangedMember(DocHistoryC::mbObjId);
}
void DocHistory::setDocId(int32_t v) {
	docId = v;
	setChangedMember(DocHistoryC::mbDocId);
}
void DocHistory::setUser(int32_t v) {
	user = v;
	setChangedMember(DocHistoryC::mbUser);
}
void DocHistory::setCreateDate(int32_t v) {
	createDate = v;
	setChangedMember(DocHistoryC::mbCreateDate);
}
void DocHistory::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(DocHistoryC::mbComment);
}
void DocHistory::setVersion(::std::wstring v) {
	version = v;
	setChangedMember(DocHistoryC::mbVersion);
}
void DocHistory::setDocMD5(::std::wstring v) {
	docMD5 = v;
	setChangedMember(DocHistoryC::mbDocMD5);
}
void DocHistory::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(DocHistoryC::mbGuid);
}
void DocHistory::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(DocHistoryC::mbTStamp);
}
void DocHistory::setSigId(int32_t v) {
	sigId = v;
	setChangedMember(DocHistoryC::mbSigId);
}
void DocHistory::setStatus(int32_t v) {
	status = v;
	setChangedMember(DocHistoryC::mbStatus);
}
void DocHistory::setFlags(int32_t v) {
	flags = v;
	setChangedMember(DocHistoryC::mbFlags);
}
void DocHistory::setDeleteDate(int32_t v) {
	deleteDate = v;
	setChangedMember(DocHistoryC::mbDeleteDate);
}
void DocHistory::setNbOfValidSignatures(int32_t v) {
	nbOfValidSignatures = v;
	setChangedMember(DocHistoryC::mbNbOfValidSignatures);
}
void DocHistory::setType(int32_t v) {
	type = v;
	setChangedMember(DocHistoryC::mbType);
}
void DocHistory::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(DocHistoryC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocHistory::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->comment;
	ar & this->createDate;
	ar & this->docId;
	ar & this->docMD5;
	ar & this->flags;
	ar & this->guid;
	ar & this->objId;
	ar & this->sigId;
	ar & this->status;
	ar & this->tStamp;
	ar & this->user;
	ar & this->version;
	if (version >= 900000000000000) {
		ar & this->deleteDate;
		if (version >= 900000016000002) {
			ar & this->nbOfValidSignatures;
			if (version >= 900990009000001) {
				ar & this->TStampSync;
				ar & this->type;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_189452795(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocHistory>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocHistoryC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocHistoryC::DocHistoryC() {
	lnComment = 0;
	lnVersion = 0;
	lnDocMD5 = 0;
	lnGuid = 0;
	lnTStamp = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocHistoryC::DocHistoryC(int64_t mbObjId, int64_t mbDocId, int64_t mbUser, int64_t mbCreateDate, int64_t mbComment, int32_t lnComment, int64_t mbVersion, int32_t lnVersion, int64_t mbDocMD5, int32_t lnDocMD5, int64_t mbGuid, int32_t lnGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbSigId, int64_t mbStatus, int64_t mbFlags, int64_t mbDeleteDate, int64_t mbNbOfValidSignatures, int64_t mbType, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnComment(lnComment)
	, lnVersion(lnVersion)
	, lnDocMD5(lnDocMD5)
	, lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocHistoryC::BSerializable_getTypeId() {
	return 1456349355; 
}
void DocHistoryC::setLnComment(int32_t v) {
	lnComment = v;
}
void DocHistoryC::setLnVersion(int32_t v) {
	lnVersion = v;
}
void DocHistoryC::setLnDocMD5(int32_t v) {
	lnDocMD5 = v;
}
void DocHistoryC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void DocHistoryC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void DocHistoryC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocHistoryC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	ar & this->lnDocMD5;
	ar & this->lnGuid;
	ar & this->lnTStamp;
	ar & this->lnVersion;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1456349355(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocHistoryC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocInfoDM
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocInfoDM::DocInfoDM() {
	id = 0;
	size = 0;
	pathId = 0;
	pathId2 = 0;
	owner = 0;
	sizeOrig = 0;
	encrSet = 0;
	previewSize = 0;
	fulltextContentSize = 0;
	sizeL = 0;
	sizeOrigL = 0;
	previewSizeL = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocInfoDM::DocInfoDM(int32_t id, const ::std::wstring& guid, int32_t size, const ::std::wstring& md5, int32_t pathId, int32_t pathId2, const ::std::wstring& createDateIso, const ::std::wstring& lastAccessIso, const ::std::wstring& lastUpdateIso, int32_t owner, const ::std::wstring& ext, const ::std::wstring& fclip, const ::std::wstring& extOrig, int32_t sizeOrig, int32_t encrSet, int32_t previewSize, const ::std::wstring& previewExt, const ::std::wstring& fulltextContentTStamp, int32_t fulltextContentSize, int64_t sizeL, int64_t sizeOrigL, int64_t previewSizeL, const ::std::wstring& relFilePath)
	: id(id)
	, guid(guid)
	, size(size)
	, md5(md5)
	, pathId(pathId)
	, pathId2(pathId2)
	, createDateIso(createDateIso)
	, lastAccessIso(lastAccessIso)
	, lastUpdateIso(lastUpdateIso)
	, owner(owner)
	, ext(ext)
	, fclip(fclip)
	, extOrig(extOrig)
	, sizeOrig(sizeOrig)
	, encrSet(encrSet)
	, previewSize(previewSize)
	, previewExt(previewExt)
	, fulltextContentTStamp(fulltextContentTStamp)
	, fulltextContentSize(fulltextContentSize)
	, sizeL(sizeL)
	, sizeOrigL(sizeOrigL)
	, previewSizeL(previewSizeL)
	, relFilePath(relFilePath)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocInfoDM::BSerializable_getTypeId() {
	return 673204378; 
}
void DocInfoDM::setId(int32_t v) {
	id = v;
	setChangedMember(DocInfoDMC::mbId);
}
void DocInfoDM::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(DocInfoDMC::mbGuid);
}
void DocInfoDM::setSize(int32_t v) {
	size = v;
	setChangedMember(DocInfoDMC::mbSize);
}
void DocInfoDM::setMd5(::std::wstring v) {
	md5 = v;
	setChangedMember(DocInfoDMC::mbMd5);
}
void DocInfoDM::setPathId(int32_t v) {
	pathId = v;
	setChangedMember(DocInfoDMC::mbPathId);
}
void DocInfoDM::setPathId2(int32_t v) {
	pathId2 = v;
	setChangedMember(DocInfoDMC::mbPathId2);
}
void DocInfoDM::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(DocInfoDMC::mbCreateDateIso);
}
void DocInfoDM::setLastAccessIso(::std::wstring v) {
	lastAccessIso = v;
	setChangedMember(DocInfoDMC::mbLastAccessIso);
}
void DocInfoDM::setLastUpdateIso(::std::wstring v) {
	lastUpdateIso = v;
	setChangedMember(DocInfoDMC::mbLastUpdateIso);
}
void DocInfoDM::setOwner(int32_t v) {
	owner = v;
	setChangedMember(DocInfoDMC::mbOwner);
}
void DocInfoDM::setExt(::std::wstring v) {
	ext = v;
	setChangedMember(DocInfoDMC::mbExt);
}
void DocInfoDM::setFclip(::std::wstring v) {
	fclip = v;
	setChangedMember(DocInfoDMC::mbFclip);
}
void DocInfoDM::setExtOrig(::std::wstring v) {
	extOrig = v;
	setChangedMember(DocInfoDMC::mbExtOrig);
}
void DocInfoDM::setSizeOrig(int32_t v) {
	sizeOrig = v;
	setChangedMember(DocInfoDMC::mbSizeOrig);
}
void DocInfoDM::setEncrSet(int32_t v) {
	encrSet = v;
	setChangedMember(DocInfoDMC::mbEncrSet);
}
void DocInfoDM::setPreviewSize(int32_t v) {
	previewSize = v;
	setChangedMember(DocInfoDMC::mbPreviewSize);
}
void DocInfoDM::setPreviewExt(::std::wstring v) {
	previewExt = v;
	setChangedMember(DocInfoDMC::mbPreviewExt);
}
void DocInfoDM::setFulltextContentTStamp(::std::wstring v) {
	fulltextContentTStamp = v;
	setChangedMember(DocInfoDMC::mbFulltextContentTStamp);
}
void DocInfoDM::setFulltextContentSize(int32_t v) {
	fulltextContentSize = v;
	setChangedMember(DocInfoDMC::mbFulltextContentSize);
}
void DocInfoDM::setSizeL(int64_t v) {
	sizeL = v;
	setChangedMember(DocInfoDMC::mbSizeL);
}
void DocInfoDM::setSizeOrigL(int64_t v) {
	sizeOrigL = v;
	setChangedMember(DocInfoDMC::mbSizeOrigL);
}
void DocInfoDM::setPreviewSizeL(int64_t v) {
	previewSizeL = v;
	setChangedMember(DocInfoDMC::mbPreviewSizeL);
}
void DocInfoDM::setRelFilePath(::std::wstring v) {
	relFilePath = v;
	setChangedMember(DocInfoDMC::mbRelFilePath);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocInfoDM::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->createDateIso;
	ar & this->ext;
	ar & this->fclip;
	ar & this->guid;
	ar & this->id;
	ar & this->lastAccessIso;
	ar & this->lastUpdateIso;
	ar & this->md5;
	ar & this->owner;
	ar & this->pathId;
	ar & this->pathId2;
	ar & this->size;
	if (version >= 600000097000000) {
		ar & this->encrSet;
		ar & this->extOrig;
		ar & this->sizeOrig;
		if (version >= 700000026000001) {
			ar & this->previewExt;
			ar & this->previewSize;
			if (version >= 700000040000006) {
				ar & this->fulltextContentSize;
				ar & this->fulltextContentTStamp;
				if (version >= 900000000000023) {
					ar & this->previewSizeL;
					ar & this->sizeL;
					ar & this->sizeOrigL;
					if (version >= 900000030000023) {
						ar & this->relFilePath;
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_673204378(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocInfoDM>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocInfoDMC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocInfoDMC::DocInfoDMC() {
	lnGuid = 0;
	lnMd5 = 0;
	lnCreateDateIso = 0;
	lnLastAccessIso = 0;
	lnLastUpdateIso = 0;
	lnExt = 0;
	lnFclip = 0;
	lnExtOrig = 0;
	lnPreviewExt = 0;
	lnFulltextContentTStamp = 0;
	lnSizeL = 0;
	lnSizeOrigL = 0;
	lnPreviewSizeL = 0;
	lnRelFilePath = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocInfoDMC::DocInfoDMC(int64_t mbId, int64_t mbGuid, int32_t lnGuid, int64_t mbMd5, int32_t lnMd5, int64_t mbPathId, int64_t mbPathId2, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbLastAccessIso, int32_t lnLastAccessIso, int64_t mbLastUpdateIso, int32_t lnLastUpdateIso, int64_t mbOwner, int64_t mbExt, int32_t lnExt, int64_t mbFclip, int32_t lnFclip, int64_t mbSize, int64_t mbPreviewSize, int64_t mbSizeOrig, int64_t mbExtOrig, int32_t lnExtOrig, int64_t mbEncrSet, int64_t mbPreviewExt, int32_t lnPreviewExt, int64_t mbFulltextContentTStamp, int32_t lnFulltextContentTStamp, int64_t mbFulltextContentSize, int64_t mbSizeL, int32_t lnSizeL, int64_t mbSizeOrigL, int32_t lnSizeOrigL, int64_t mbPreviewSizeL, int32_t lnPreviewSizeL, int64_t mbRelFilePath, int32_t lnRelFilePath, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnMd5(lnMd5)
	, lnCreateDateIso(lnCreateDateIso)
	, lnLastAccessIso(lnLastAccessIso)
	, lnLastUpdateIso(lnLastUpdateIso)
	, lnExt(lnExt)
	, lnFclip(lnFclip)
	, lnExtOrig(lnExtOrig)
	, lnPreviewExt(lnPreviewExt)
	, lnFulltextContentTStamp(lnFulltextContentTStamp)
	, lnSizeL(lnSizeL)
	, lnSizeOrigL(lnSizeOrigL)
	, lnPreviewSizeL(lnPreviewSizeL)
	, lnRelFilePath(lnRelFilePath)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocInfoDMC::BSerializable_getTypeId() {
	return 1042422760; 
}
void DocInfoDMC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void DocInfoDMC::setLnMd5(int32_t v) {
	lnMd5 = v;
}
void DocInfoDMC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
void DocInfoDMC::setLnLastAccessIso(int32_t v) {
	lnLastAccessIso = v;
}
void DocInfoDMC::setLnLastUpdateIso(int32_t v) {
	lnLastUpdateIso = v;
}
void DocInfoDMC::setLnExt(int32_t v) {
	lnExt = v;
}
void DocInfoDMC::setLnFclip(int32_t v) {
	lnFclip = v;
}
void DocInfoDMC::setLnExtOrig(int32_t v) {
	lnExtOrig = v;
}
void DocInfoDMC::setLnPreviewExt(int32_t v) {
	lnPreviewExt = v;
}
void DocInfoDMC::setLnFulltextContentTStamp(int32_t v) {
	lnFulltextContentTStamp = v;
}
void DocInfoDMC::setLnSizeL(int32_t v) {
	lnSizeL = v;
}
void DocInfoDMC::setLnSizeOrigL(int32_t v) {
	lnSizeOrigL = v;
}
void DocInfoDMC::setLnPreviewSizeL(int32_t v) {
	lnPreviewSizeL = v;
}
void DocInfoDMC::setLnRelFilePath(int32_t v) {
	lnRelFilePath = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocInfoDMC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCreateDateIso;
	ar & this->lnExt;
	ar & this->lnFclip;
	ar & this->lnGuid;
	ar & this->lnLastAccessIso;
	ar & this->lnLastUpdateIso;
	ar & this->lnMd5;
	if (version >= 600000097000000) {
		ar & this->lnExtOrig;
		if (version >= 700000026000001) {
			ar & this->lnPreviewExt;
			if (version >= 700000040000006) {
				ar & this->lnFulltextContentTStamp;
				if (version >= 900000000000023) {
					ar & this->lnPreviewSizeL;
					ar & this->lnSizeL;
					ar & this->lnSizeOrigL;
					if (version >= 900000030000023) {
						ar & this->lnRelFilePath;
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1042422760(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocInfoDMC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMask::DocMask() {
	DKind = 0;
	DPath = 0;
	flowId = 0;
	id = 0;
	lockId = 0;
	deleted = false;
	flowId2 = 0;
	dataOrganisation = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMask::DocMask(const ::std::wstring& DAcl, int32_t DKind, int32_t DPath, const ::std::wstring& TStamp, const ::std::wstring& barcode, int32_t flowId, int32_t id, const ::std::wstring& index, const ::std::wstring& lifetime, int32_t lockId, const ::std::wstring& lockName, const ::std::wstring& name, const ::std::wstring& text, const ::std::wstring& acl, const PArrayAclItem& aclItems, const PDocMaskDetails& details, const PArrayAclItem& docAclItems, const PArrayDocMaskLine& lines, const ::std::wstring& guid, bool deleted, int32_t flowId2, const ::std::wstring& TStampSync, const ::std::wstring& textTranslationKey, const ::std::wstring& nameTranslationKey, int32_t dataOrganisation)
	: DAcl(DAcl)
	, DKind(DKind)
	, DPath(DPath)
	, TStamp(TStamp)
	, barcode(barcode)
	, flowId(flowId)
	, id(id)
	, index(index)
	, lifetime(lifetime)
	, lockId(lockId)
	, lockName(lockName)
	, name(name)
	, text(text)
	, acl(acl)
	, aclItems(aclItems)
	, details(details)
	, docAclItems(docAclItems)
	, lines(lines)
	, guid(guid)
	, deleted(deleted)
	, flowId2(flowId2)
	, TStampSync(TStampSync)
	, textTranslationKey(textTranslationKey)
	, nameTranslationKey(nameTranslationKey)
	, dataOrganisation(dataOrganisation)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMask::BSerializable_getTypeId() {
	return 2054753789; 
}
void DocMask::setDAcl(::std::wstring v) {
	DAcl = v;
	setChangedMember(DocMaskC::mbDAcl);
}
void DocMask::setDKind(int32_t v) {
	DKind = v;
	setChangedMember(DocMaskC::mbDKind);
}
void DocMask::setDPath(int32_t v) {
	DPath = v;
	setChangedMember(DocMaskC::mbDPath);
}
void DocMask::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(DocMaskC::mbTStamp);
}
void DocMask::setBarcode(::std::wstring v) {
	barcode = v;
	setChangedMember(DocMaskC::mbBarcode);
}
void DocMask::setFlowId(int32_t v) {
	flowId = v;
	setChangedMember(DocMaskC::mbFlowId);
}
void DocMask::setId(int32_t v) {
	id = v;
	setChangedMember(DocMaskC::mbId);
}
void DocMask::setIndex(::std::wstring v) {
	index = v;
	setChangedMember(DocMaskC::mbIndex);
}
void DocMask::setLifetime(::std::wstring v) {
	lifetime = v;
	setChangedMember(DocMaskC::mbLifetime);
}
void DocMask::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(DocMaskC::mbLockId);
}
void DocMask::setLockName(::std::wstring v) {
	lockName = v;
}
void DocMask::setName(::std::wstring v) {
	name = v;
	setChangedMember(DocMaskC::mbName);
}
void DocMask::setText(::std::wstring v) {
	text = v;
	setChangedMember(DocMaskC::mbText);
}
void DocMask::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(DocMaskC::mbAcl);
}
void DocMask::setAclItems(PArrayAclItem v) {
	aclItems = v;
	setChangedMember(DocMaskC::mbAclItems);
}
void DocMask::setDetails(PDocMaskDetails v) {
	details = v;
	setChangedMember(DocMaskC::mbDetails);
}
void DocMask::setDocAclItems(PArrayAclItem v) {
	docAclItems = v;
	setChangedMember(DocMaskC::mbDocAclItems);
}
void DocMask::setLines(PArrayDocMaskLine v) {
	lines = v;
	setChangedMember(DocMaskC::mbLines);
}
void DocMask::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(DocMaskC::mbGuid);
}
void DocMask::setDeleted(bool v) {
	deleted = v;
	setChangedMember(DocMaskC::mbDeleted);
}
void DocMask::setFlowId2(int32_t v) {
	flowId2 = v;
	setChangedMember(DocMaskC::mbFlowId2);
}
void DocMask::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(DocMaskC::mbTStampSync);
}
void DocMask::setTextTranslationKey(::std::wstring v) {
	textTranslationKey = v;
	setChangedMember(DocMaskC::mbTextTranslationKey);
}
void DocMask::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
	setChangedMember(DocMaskC::mbNameTranslationKey);
}
void DocMask::setDataOrganisation(int32_t v) {
	dataOrganisation = v;
	setChangedMember(DocMaskC::mbDataOrganisation);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMask::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->DAcl;
	ar & this->DKind;
	ar & this->DPath;
	ar & this->TStamp;
	ar & this->acl;
	ar & this->barcode;
	ar & this->flowId;
	ar & this->id;
	ar & this->index;
	ar & this->lifetime;
	ar & this->lockId;
	ar & this->name;
	ar & this->text;
	if (version >= 700000000000001) {
		ar & this->deleted;
		ar & this->guid;
		if (version >= 700000026000002) {
			ar & this->lockName;
			if (version >= 700000040000016) {
				ar & this->flowId2;
				if (version >= 900000018000005) {
					ar & this->nameTranslationKey;
					ar & this->textTranslationKey;
					if (version >= 900000039000001) {
						ar & this->dataOrganisation;
						if (version >= 900990009000001) {
							ar & this->TStampSync;
						}
					}
				}
			}
		}
	}
	ar & this->aclItems;
	ar & this->details;
	ar & this->docAclItems;
	ar & this->lines;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2054753789(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskDataC::DocMaskDataC() {
	lnName = 0;
	lnIndex = 0;
	lnBarcode = 0;
	lnDAcl = 0;
	lnLifetime = 0;
	lnText = 0;
	lnTStamp = 0;
	lnRawPosInfo = 0;
	lnGuid = 0;
	lnInternalAcl = 0;
	lnTStampSync = 0;
	lnTextTranslationKey = 0;
	lnNameTranslationKey = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskDataC::DocMaskDataC(int64_t mbId, int64_t mbName, int32_t lnName, int64_t mbIndex, int32_t lnIndex, int64_t mbBarcode, int32_t lnBarcode, int64_t mbKey, int64_t mbDPath, int64_t mbDKind, int64_t mbDKey, int64_t mbLockId, int64_t mbFlags, int64_t mbFlowId, int64_t mbDAcl, int32_t lnDAcl, int64_t mbLifetime, int32_t lnLifetime, int64_t mbText, int32_t lnText, int64_t mbTStamp, int32_t lnTStamp, int64_t mbRawPosInfo, int32_t lnRawPosInfo, int64_t mbGuid, int32_t lnGuid, int64_t mbStatus, int64_t mbInternalAcl, int32_t lnInternalAcl, int64_t mbFlowId2, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbTextTranslationKey, int32_t lnTextTranslationKey, int64_t mbNameTranslationKey, int32_t lnNameTranslationKey, int64_t mbDataOrganisation, int64_t mbAllMembers)
	: lnName(lnName)
	, lnIndex(lnIndex)
	, lnBarcode(lnBarcode)
	, lnDAcl(lnDAcl)
	, lnLifetime(lnLifetime)
	, lnText(lnText)
	, lnTStamp(lnTStamp)
	, lnRawPosInfo(lnRawPosInfo)
	, lnGuid(lnGuid)
	, lnInternalAcl(lnInternalAcl)
	, lnTStampSync(lnTStampSync)
	, lnTextTranslationKey(lnTextTranslationKey)
	, lnNameTranslationKey(lnNameTranslationKey)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskDataC::BSerializable_getTypeId() {
	return 1968969939; 
}
void DocMaskDataC::setLnName(int32_t v) {
	lnName = v;
}
void DocMaskDataC::setLnIndex(int32_t v) {
	lnIndex = v;
}
void DocMaskDataC::setLnBarcode(int32_t v) {
	lnBarcode = v;
}
void DocMaskDataC::setLnDAcl(int32_t v) {
	lnDAcl = v;
}
void DocMaskDataC::setLnLifetime(int32_t v) {
	lnLifetime = v;
}
void DocMaskDataC::setLnText(int32_t v) {
	lnText = v;
}
void DocMaskDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void DocMaskDataC::setLnRawPosInfo(int32_t v) {
	lnRawPosInfo = v;
}
void DocMaskDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void DocMaskDataC::setLnInternalAcl(int32_t v) {
	lnInternalAcl = v;
}
void DocMaskDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
void DocMaskDataC::setLnTextTranslationKey(int32_t v) {
	lnTextTranslationKey = v;
}
void DocMaskDataC::setLnNameTranslationKey(int32_t v) {
	lnNameTranslationKey = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnBarcode;
	ar & this->lnDAcl;
	ar & this->lnIndex;
	ar & this->lnLifetime;
	ar & this->lnName;
	ar & this->lnRawPosInfo;
	ar & this->lnTStamp;
	ar & this->lnText;
	if (version >= 700000000000001) {
		ar & this->lnGuid;
		if (version >= 700000000000006) {
			ar & this->lnInternalAcl;
			if (version >= 900000018000005) {
				ar & this->lnNameTranslationKey;
				ar & this->lnTextTranslationKey;
				if (version >= 900990009000001) {
					ar & this->lnTStampSync;
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1968969939(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskC
// Generated from class byps.gen.cpp.GenApiClass

const PDocMaskZ DocMaskC::mbAll = PDocMaskZ(new DocMaskZ(
	4503599627370495LL));

const PDocMaskZ DocMaskC::mbOnlyLock = PDocMaskZ(new DocMaskZ(
	0LL));

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskC::DocMaskC() {
	lnAcl = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskC::DocMaskC(const ::std::wstring& GUID_BASIC, const ::std::wstring& GUID_EMAIL, const ::std::wstring& GUID_STRUCTURE_ELEMENT, const ::std::wstring& GUID_CONTACT, const ::std::wstring& GUID_FOLDER, const ::std::wstring& GUID_SEARCH, const ::std::wstring& GUID_ELOSCRIPTS, const ::std::wstring& GUID_USER_FOLDER, const ::std::wstring& GUID_MS_SHAREPOINT_DOCUMENT, int64_t mbAcl, int32_t lnAcl, int64_t mbAclItems, int64_t mbMaskLines, int64_t mbAllMembers, int64_t mbSortOrderNotArchivingMode, const PDocMaskZ& mbAll, const PDocMaskZ& mbOnlyLock, int64_t mbDetails, int64_t mbDocAclItems, int64_t mbLines, int64_t mbDeleted, int32_t DATA_ORGANISATION_OBJKEYS, int32_t DATA_ORGANISATION_TABLE)
	: GUID_BASIC(GUID_BASIC)
	, GUID_EMAIL(GUID_EMAIL)
	, GUID_STRUCTURE_ELEMENT(GUID_STRUCTURE_ELEMENT)
	, GUID_CONTACT(GUID_CONTACT)
	, GUID_FOLDER(GUID_FOLDER)
	, GUID_SEARCH(GUID_SEARCH)
	, GUID_ELOSCRIPTS(GUID_ELOSCRIPTS)
	, GUID_USER_FOLDER(GUID_USER_FOLDER)
	, GUID_MS_SHAREPOINT_DOCUMENT(GUID_MS_SHAREPOINT_DOCUMENT)
	, lnAcl(lnAcl)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskC::BSerializable_getTypeId() {
	return 387842089; 
}
void DocMaskC::setGUID_BASIC(::std::wstring v) {
	GUID_BASIC = v;
}
void DocMaskC::setGUID_EMAIL(::std::wstring v) {
	GUID_EMAIL = v;
}
void DocMaskC::setGUID_STRUCTURE_ELEMENT(::std::wstring v) {
	GUID_STRUCTURE_ELEMENT = v;
}
void DocMaskC::setGUID_CONTACT(::std::wstring v) {
	GUID_CONTACT = v;
}
void DocMaskC::setGUID_FOLDER(::std::wstring v) {
	GUID_FOLDER = v;
}
void DocMaskC::setGUID_SEARCH(::std::wstring v) {
	GUID_SEARCH = v;
}
void DocMaskC::setGUID_ELOSCRIPTS(::std::wstring v) {
	GUID_ELOSCRIPTS = v;
}
void DocMaskC::setGUID_USER_FOLDER(::std::wstring v) {
	GUID_USER_FOLDER = v;
}
void DocMaskC::setGUID_MS_SHAREPOINT_DOCUMENT(::std::wstring v) {
	GUID_MS_SHAREPOINT_DOCUMENT = v;
}
void DocMaskC::setLnAcl(int32_t v) {
	lnAcl = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskC::serialize(BIO& ar, const BVERSION version) {
	DocMaskDataC::serialize(ar, version);
	if (version >= 700000000000003) {
		ar & this->GUID_BASIC;
		ar & this->GUID_CONTACT;
		ar & this->GUID_EMAIL;
		ar & this->GUID_STRUCTURE_ELEMENT;
		if (version >= 700000000000006) {
			ar & this->lnAcl;
			if (version >= 700000000000024) {
				ar & this->GUID_FOLDER;
				ar & this->GUID_SEARCH;
				if (version >= 800000020000001) {
					ar & this->GUID_ELOSCRIPTS;
					if (version >= 900000000000011) {
						ar & this->GUID_USER_FOLDER;
						if (version >= 1000170059000003) {
							ar & this->GUID_MS_SHAREPOINT_DOCUMENT;
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
void BSerializer_387842089(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskDetails
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskDetails::DocMaskDetails() {
	archivingMode = 0;
	encryptionSet = 0;
	fulltext = false;
	sortOrder = 0;
	documentMask = false;
	searchMask = false;
	folderMask = false;
	createIndexPath = false;
	createIndexReferencesPaths = false;
	releaseDocument = false;
	documentContainer = false;
	translateSordName = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskDetails::DocMaskDetails(int32_t archivingMode, int32_t encryptionSet, bool fulltext, int32_t sortOrder, bool documentMask, bool searchMask, bool folderMask, bool createIndexPath, bool createIndexReferencesPaths, bool releaseDocument, bool documentContainer, bool translateSordName)
	: archivingMode(archivingMode)
	, encryptionSet(encryptionSet)
	, fulltext(fulltext)
	, sortOrder(sortOrder)
	, documentMask(documentMask)
	, searchMask(searchMask)
	, folderMask(folderMask)
	, createIndexPath(createIndexPath)
	, createIndexReferencesPaths(createIndexReferencesPaths)
	, releaseDocument(releaseDocument)
	, documentContainer(documentContainer)
	, translateSordName(translateSordName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskDetails::BSerializable_getTypeId() {
	return 639048562; 
}
void DocMaskDetails::setArchivingMode(int32_t v) {
	archivingMode = v;
}
void DocMaskDetails::setEncryptionSet(int32_t v) {
	encryptionSet = v;
}
void DocMaskDetails::setFulltext(bool v) {
	fulltext = v;
}
void DocMaskDetails::setSortOrder(int32_t v) {
	sortOrder = v;
}
void DocMaskDetails::setDocumentMask(bool v) {
	documentMask = v;
}
void DocMaskDetails::setSearchMask(bool v) {
	searchMask = v;
}
void DocMaskDetails::setFolderMask(bool v) {
	folderMask = v;
}
void DocMaskDetails::setCreateIndexPath(bool v) {
	createIndexPath = v;
}
void DocMaskDetails::setCreateIndexReferencesPaths(bool v) {
	createIndexReferencesPaths = v;
}
void DocMaskDetails::setReleaseDocument(bool v) {
	releaseDocument = v;
}
void DocMaskDetails::setDocumentContainer(bool v) {
	documentContainer = v;
}
void DocMaskDetails::setTranslateSordName(bool v) {
	translateSordName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskDetails::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->archivingMode;
	ar & this->documentMask;
	ar & this->encryptionSet;
	ar & this->fulltext;
	ar & this->searchMask;
	ar & this->sortOrder;
	if (version >= 600000098000000) {
		ar & this->createIndexPath;
		ar & this->createIndexReferencesPaths;
		if (version >= 700000000000000) {
			ar & this->folderMask;
			if (version >= 800000032000007) {
				ar & this->releaseDocument;
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
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_639048562(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskDetails>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLine
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLine::DocMaskLine() {
	id = 0;
	maskId = 0;
	max = 0;
	min = 0;
	canEdit = false;
	editCol = 0;
	editRow = 0;
	editWidth = 0;
	hidden = false;
	labelCol = 0;
	labelRow = 0;
	nextTab = false;
	onlyBuzzwords = false;
	postfixAsterix = false;
	prefixAsterix = false;
	readOnly = false;
	tabOrder = 0;
	type = 0;
	important = false;
	notTokenized = false;
	excludeFromISearch = false;
	version = false;
	translate = false;
	access = 0;
	disableWordWheel = false;
	tabIndex = 0;
	inherit = false;
	inheritFromParent = false;
	valueArray = false;
	required = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLine::DocMaskLine(const ::std::wstring& comment, int32_t id, const ::std::wstring& key, int32_t maskId, int32_t max, int32_t min, const ::std::wstring& name, const PArrayAclItem& aclItems, bool canEdit, int32_t editCol, int32_t editRow, int32_t editWidth, bool hidden, int32_t labelCol, int32_t labelRow, bool nextTab, bool onlyBuzzwords, bool postfixAsterix, bool prefixAsterix, bool readOnly, int32_t tabOrder, int32_t type, const ::std::wstring& externalData, bool important, bool notTokenized, bool excludeFromISearch, bool version, bool translate, const ::std::wstring& acl, int32_t access, bool disableWordWheel, const ::std::wstring& defaultValue, int32_t tabIndex, const ::std::wstring& serverScriptName, bool inherit, bool inheritFromParent, const ::std::wstring& nameTranslationKey, const ::std::wstring& commentTranslationKey, bool valueArray, const ::std::wstring& validateExpression, bool required)
	: comment(comment)
	, id(id)
	, key(key)
	, maskId(maskId)
	, max(max)
	, min(min)
	, name(name)
	, aclItems(aclItems)
	, canEdit(canEdit)
	, editCol(editCol)
	, editRow(editRow)
	, editWidth(editWidth)
	, hidden(hidden)
	, labelCol(labelCol)
	, labelRow(labelRow)
	, nextTab(nextTab)
	, onlyBuzzwords(onlyBuzzwords)
	, postfixAsterix(postfixAsterix)
	, prefixAsterix(prefixAsterix)
	, readOnly(readOnly)
	, tabOrder(tabOrder)
	, type(type)
	, externalData(externalData)
	, important(important)
	, notTokenized(notTokenized)
	, excludeFromISearch(excludeFromISearch)
	, version(version)
	, translate(translate)
	, acl(acl)
	, access(access)
	, disableWordWheel(disableWordWheel)
	, defaultValue(defaultValue)
	, tabIndex(tabIndex)
	, serverScriptName(serverScriptName)
	, inherit(inherit)
	, inheritFromParent(inheritFromParent)
	, nameTranslationKey(nameTranslationKey)
	, commentTranslationKey(commentTranslationKey)
	, valueArray(valueArray)
	, validateExpression(validateExpression)
	, required(required)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLine::BSerializable_getTypeId() {
	return 1291500689; 
}
void DocMaskLine::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(DocMaskLineC::mbComment);
}
void DocMaskLine::setId(int32_t v) {
	id = v;
	setChangedMember(DocMaskLineC::mbId);
}
void DocMaskLine::setKey(::std::wstring v) {
	key = v;
	setChangedMember(DocMaskLineC::mbKey);
}
void DocMaskLine::setMaskId(int32_t v) {
	maskId = v;
	setChangedMember(DocMaskLineC::mbMaskId);
}
void DocMaskLine::setMax(int32_t v) {
	max = v;
	setChangedMember(DocMaskLineC::mbMax);
}
void DocMaskLine::setMin(int32_t v) {
	min = v;
	setChangedMember(DocMaskLineC::mbMin);
}
void DocMaskLine::setName(::std::wstring v) {
	name = v;
	setChangedMember(DocMaskLineC::mbName);
}
void DocMaskLine::setAclItems(PArrayAclItem v) {
	aclItems = v;
	setChangedMember(DocMaskLineC::mbAclItems);
}
void DocMaskLine::setCanEdit(bool v) {
	canEdit = v;
}
void DocMaskLine::setEditCol(int32_t v) {
	editCol = v;
}
void DocMaskLine::setEditRow(int32_t v) {
	editRow = v;
}
void DocMaskLine::setEditWidth(int32_t v) {
	editWidth = v;
}
void DocMaskLine::setHidden(bool v) {
	hidden = v;
	setChangedMember(DocMaskLineC::mbHidden);
}
void DocMaskLine::setLabelCol(int32_t v) {
	labelCol = v;
}
void DocMaskLine::setLabelRow(int32_t v) {
	labelRow = v;
}
void DocMaskLine::setNextTab(bool v) {
	nextTab = v;
	setChangedMember(DocMaskLineC::mbNextTab);
}
void DocMaskLine::setOnlyBuzzwords(bool v) {
	onlyBuzzwords = v;
	setChangedMember(DocMaskLineC::mbOnlyBuzzwords);
}
void DocMaskLine::setPostfixAsterix(bool v) {
	postfixAsterix = v;
	setChangedMember(DocMaskLineC::mbPostfixAsterix);
}
void DocMaskLine::setPrefixAsterix(bool v) {
	prefixAsterix = v;
	setChangedMember(DocMaskLineC::mbPrefixAsterix);
}
void DocMaskLine::setReadOnly(bool v) {
	readOnly = v;
	setChangedMember(DocMaskLineC::mbReadOnly);
}
void DocMaskLine::setTabOrder(int32_t v) {
	tabOrder = v;
	setChangedMember(DocMaskLineC::mbTabOrder);
}
void DocMaskLine::setType(int32_t v) {
	type = v;
	setChangedMember(DocMaskLineC::mbType);
}
void DocMaskLine::setExternalData(::std::wstring v) {
	externalData = v;
	setChangedMember(DocMaskLineC::mbExternalData);
}
void DocMaskLine::setImportant(bool v) {
	important = v;
	setChangedMember(DocMaskLineC::mbImportant);
}
void DocMaskLine::setNotTokenized(bool v) {
	notTokenized = v;
}
void DocMaskLine::setExcludeFromISearch(bool v) {
	excludeFromISearch = v;
}
void DocMaskLine::setVersion(bool v) {
	version = v;
	setChangedMember(DocMaskLineC::mbVersion);
}
void DocMaskLine::setTranslate(bool v) {
	translate = v;
	setChangedMember(DocMaskLineC::mbTranslate);
}
void DocMaskLine::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(DocMaskLineC::mbAcl);
}
void DocMaskLine::setAccess(int32_t v) {
	access = v;
}
void DocMaskLine::setDisableWordWheel(bool v) {
	disableWordWheel = v;
}
void DocMaskLine::setDefaultValue(::std::wstring v) {
	defaultValue = v;
	setChangedMember(DocMaskLineC::mbDefaultValue);
}
void DocMaskLine::setTabIndex(int32_t v) {
	tabIndex = v;
	setChangedMember(DocMaskLineC::mbTabIndex);
}
void DocMaskLine::setServerScriptName(::std::wstring v) {
	serverScriptName = v;
	setChangedMember(DocMaskLineC::mbServerScriptName);
}
void DocMaskLine::setInherit(bool v) {
	inherit = v;
}
void DocMaskLine::setInheritFromParent(bool v) {
	inheritFromParent = v;
}
void DocMaskLine::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
	setChangedMember(DocMaskLineC::mbNameTranslationKey);
}
void DocMaskLine::setCommentTranslationKey(::std::wstring v) {
	commentTranslationKey = v;
	setChangedMember(DocMaskLineC::mbCommentTranslationKey);
}
void DocMaskLine::setValueArray(bool v) {
	valueArray = v;
}
void DocMaskLine::setValidateExpression(::std::wstring v) {
	validateExpression = v;
	setChangedMember(DocMaskLineC::mbValidateExpression);
}
void DocMaskLine::setRequired(bool v) {
	required = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLine::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->acl;
	ar & this->canEdit;
	ar & this->comment;
	ar & this->editCol;
	ar & this->editRow;
	ar & this->editWidth;
	ar & this->hidden;
	ar & this->id;
	ar & this->key;
	ar & this->labelCol;
	ar & this->labelRow;
	ar & this->maskId;
	ar & this->max;
	ar & this->min;
	ar & this->name;
	ar & this->nextTab;
	ar & this->onlyBuzzwords;
	ar & this->postfixAsterix;
	ar & this->prefixAsterix;
	ar & this->readOnly;
	ar & this->tabOrder;
	ar & this->type;
	if (version >= 700000000000000) {
		ar & this->externalData;
		if (version >= 700000000000004) {
			ar & this->important;
			ar & this->translate;
			ar & this->version;
			if (version >= 700000000000047) {
				ar & this->access;
				if (version >= 700000040000015) {
					ar & this->disableWordWheel;
					if (version >= 700000040000016) {
						ar & this->defaultValue;
						if (version >= 900000000000000) {
							ar & this->tabIndex;
							if (version >= 900000000000001) {
								ar & this->serverScriptName;
								if (version >= 900000016000011) {
									ar & this->inherit;
									if (version >= 900000018000005) {
										ar & this->commentTranslationKey;
										ar & this->nameTranslationKey;
										if (version >= 900000022000000) {
											ar & this->notTokenized;
											if (version >= 900000030000019) {
												ar & this->inheritFromParent;
												if (version >= 900000039000001) {
													ar & this->valueArray;
													if (version >= 1000000020000010) {
														ar & this->required;
														ar & this->validateExpression;
														if (version >= 1000000020000023) {
															ar & this->excludeFromISearch;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
	ar & this->aclItems;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1291500689(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLine>(bio, pObj, pObjS, pBase);	
}
}}}}

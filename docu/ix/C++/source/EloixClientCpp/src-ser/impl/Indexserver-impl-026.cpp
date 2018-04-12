#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessAcl
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessAcl::ProcessAcl() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessAcl::ProcessAcl(const PArrayAclItem& addAclItems, const PArrayAclItem& andAclItems, const PArrayAclItem& setAclItems, const PArrayAclItem& subAclItems, const ::std::wstring& addAcl, const ::std::wstring& subAcl, const ::std::wstring& andAcl, const ::std::wstring& setAcl)
	: addAclItems(addAclItems)
	, andAclItems(andAclItems)
	, setAclItems(setAclItems)
	, subAclItems(subAclItems)
	, addAcl(addAcl)
	, subAcl(subAcl)
	, andAcl(andAcl)
	, setAcl(setAcl)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessAcl::BSerializable_getTypeId() {
	return 402225782; 
}
void ProcessAcl::setAddAclItems(PArrayAclItem v) {
	addAclItems = v;
}
void ProcessAcl::setAndAclItems(PArrayAclItem v) {
	andAclItems = v;
}
void ProcessAcl::setSetAclItems(PArrayAclItem v) {
	setAclItems = v;
}
void ProcessAcl::setSubAclItems(PArrayAclItem v) {
	subAclItems = v;
}
void ProcessAcl::setAddAcl(::std::wstring v) {
	addAcl = v;
}
void ProcessAcl::setSubAcl(::std::wstring v) {
	subAcl = v;
}
void ProcessAcl::setAndAcl(::std::wstring v) {
	andAcl = v;
}
void ProcessAcl::setSetAcl(::std::wstring v) {
	setAcl = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessAcl::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 700000020000008) {
		ar & this->addAcl;
		ar & this->andAcl;
		ar & this->setAcl;
		ar & this->subAcl;
	}
	ar & this->addAclItems;
	ar & this->andAclItems;
	ar & this->setAclItems;
	ar & this->subAclItems;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_402225782(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessAcl>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessCopyElements
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessCopyElements::ProcessCopyElements() {
	createMapping = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessCopyElements::ProcessCopyElements(const PCopyOptions& copyOptions, bool createMapping, const PCopyResult& copyResult)
	: copyOptions(copyOptions)
	, createMapping(createMapping)
	, copyResult(copyResult)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessCopyElements::BSerializable_getTypeId() {
	return 147051188; 
}
void ProcessCopyElements::setCopyOptions(PCopyOptions v) {
	copyOptions = v;
}
void ProcessCopyElements::setCreateMapping(bool v) {
	createMapping = v;
}
void ProcessCopyElements::setCopyResult(PCopyResult v) {
	copyResult = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessCopyElements::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 900000014000004) {
		ar & this->createMapping;
	}
	ar & this->copyOptions;
	if (version >= 900000014000004) {
		ar & this->copyResult;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_147051188(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessCopyElements>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessCountElements
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessCountElements::ProcessCountElements() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessCountElements::ProcessCountElements(const PCountResult& countResult)
	: countResult(countResult)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessCountElements::BSerializable_getTypeId() {
	return 1130489422; 
}
void ProcessCountElements::setCountResult(PCountResult v) {
	countResult = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessCountElements::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->countResult;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1130489422(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessCountElements>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessFulltext
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessFulltext::ProcessFulltext() {
	addToFulltext = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessFulltext::ProcessFulltext(bool addToFulltext)
	: addToFulltext(addToFulltext)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessFulltext::BSerializable_getTypeId() {
	return 1125907212; 
}
void ProcessFulltext::setAddToFulltext(bool v) {
	addToFulltext = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessFulltext::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->addToFulltext;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1125907212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessFulltext>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessInfo::ProcessInfo() {
	delStatus = 0;
	errorMode = 0;
	ignoreDocuments = false;
	ignoreStructures = false;
	procMsgMax = 0;
	forceOperation = false;
	inclReferences = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessInfo::ProcessInfo(int32_t delStatus, const ::std::wstring& desc, int32_t errorMode, bool ignoreDocuments, bool ignoreStructures, const PLockZ& lockZ, const PProcessAcl& procAcl, const PProcessFulltext& procFulltext, const PProcessCountElements& procCountElem, const PProcessMoveDocumentsToStoragePath& procMoveDocumentsToStoragePath, const PProcessCopyElements& procCopyElements, int32_t procMsgMax, const PArrayString& procMsgs, const PProcessReplSet& procReplSet, const PProcessScript& procScript, bool forceOperation, bool inclReferences, const PProcessReleaseLock& procReleaseLock, const PProcessInheritKeywording& procInheritKeywording)
	: delStatus(delStatus)
	, desc(desc)
	, errorMode(errorMode)
	, ignoreDocuments(ignoreDocuments)
	, ignoreStructures(ignoreStructures)
	, lockZ(lockZ)
	, procAcl(procAcl)
	, procFulltext(procFulltext)
	, procCountElem(procCountElem)
	, procMoveDocumentsToStoragePath(procMoveDocumentsToStoragePath)
	, procCopyElements(procCopyElements)
	, procMsgMax(procMsgMax)
	, procMsgs(procMsgs)
	, procReplSet(procReplSet)
	, procScript(procScript)
	, forceOperation(forceOperation)
	, inclReferences(inclReferences)
	, procReleaseLock(procReleaseLock)
	, procInheritKeywording(procInheritKeywording)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessInfo::BSerializable_getTypeId() {
	return 1037318967; 
}
void ProcessInfo::setDelStatus(int32_t v) {
	delStatus = v;
}
void ProcessInfo::setDesc(::std::wstring v) {
	desc = v;
}
void ProcessInfo::setErrorMode(int32_t v) {
	errorMode = v;
}
void ProcessInfo::setIgnoreDocuments(bool v) {
	ignoreDocuments = v;
}
void ProcessInfo::setIgnoreStructures(bool v) {
	ignoreStructures = v;
}
void ProcessInfo::setLockZ(PLockZ v) {
	lockZ = v;
}
void ProcessInfo::setProcAcl(PProcessAcl v) {
	procAcl = v;
}
void ProcessInfo::setProcFulltext(PProcessFulltext v) {
	procFulltext = v;
}
void ProcessInfo::setProcCountElem(PProcessCountElements v) {
	procCountElem = v;
}
void ProcessInfo::setProcMoveDocumentsToStoragePath(PProcessMoveDocumentsToStoragePath v) {
	procMoveDocumentsToStoragePath = v;
}
void ProcessInfo::setProcCopyElements(PProcessCopyElements v) {
	procCopyElements = v;
}
void ProcessInfo::setProcMsgMax(int32_t v) {
	procMsgMax = v;
}
void ProcessInfo::setProcMsgs(PArrayString v) {
	procMsgs = v;
}
void ProcessInfo::setProcReplSet(PProcessReplSet v) {
	procReplSet = v;
}
void ProcessInfo::setProcScript(PProcessScript v) {
	procScript = v;
}
void ProcessInfo::setForceOperation(bool v) {
	forceOperation = v;
}
void ProcessInfo::setInclReferences(bool v) {
	inclReferences = v;
}
void ProcessInfo::setProcReleaseLock(PProcessReleaseLock v) {
	procReleaseLock = v;
}
void ProcessInfo::setProcInheritKeywording(PProcessInheritKeywording v) {
	procInheritKeywording = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->delStatus;
	ar & this->desc;
	ar & this->errorMode;
	ar & this->ignoreDocuments;
	ar & this->ignoreStructures;
	ar & this->procMsgMax;
	if (version >= 700000000000038) {
		ar & this->forceOperation;
		if (version >= 800000000000004) {
			ar & this->inclReferences;
		}
	}
	ar & this->lockZ;
	ar & this->procAcl;
	ar & this->procMsgs;
	ar & this->procReplSet;
	ar & this->procScript;
	if (version >= 600000099000000) {
		ar & this->procFulltext;
		if (version >= 700000000000000) {
			ar & this->procCountElem;
			if (version >= 700000000000045) {
				ar & this->procMoveDocumentsToStoragePath;
				if (version >= 700000020000001) {
					ar & this->procCopyElements;
					if (version >= 900000000000031) {
						ar & this->procReleaseLock;
						if (version >= 1000170040000001) {
							ar & this->procInheritKeywording;
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
void BSerializer_1037318967(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessInfoC::ProcessInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessInfoC::BSerializable_getTypeId() {
	return 659513392; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_659513392(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessInheritKeywording
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessInheritKeywording::ProcessInheritKeywording() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessInheritKeywording::BSerializable_getTypeId() {
	return 1130489423; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessInheritKeywording::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1130489423(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessInheritKeywording>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessMoveDocumentsToStoragePath
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessMoveDocumentsToStoragePath::ProcessMoveDocumentsToStoragePath() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessMoveDocumentsToStoragePath::ProcessMoveDocumentsToStoragePath(const ::std::wstring& pathId)
	: pathId(pathId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessMoveDocumentsToStoragePath::BSerializable_getTypeId() {
	return 3376635; 
}
void ProcessMoveDocumentsToStoragePath::setPathId(::std::wstring v) {
	pathId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessMoveDocumentsToStoragePath::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->pathId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_3376635(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessMoveDocumentsToStoragePath>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessReleaseLock
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessReleaseLock::ProcessReleaseLock() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessReleaseLock::BSerializable_getTypeId() {
	return 1270934212; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessReleaseLock::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1270934212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessReleaseLock>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessReplSet
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessReplSet::ProcessReplSet() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessReplSet::ProcessReplSet(const PArrayIdName& addReplSets, const PArrayIdName& andReplSets, const PArrayIdName& setReplSets, const PArrayIdName& subReplSets)
	: addReplSets(addReplSets)
	, andReplSets(andReplSets)
	, setReplSets(setReplSets)
	, subReplSets(subReplSets)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessReplSet::BSerializable_getTypeId() {
	return 712209598; 
}
void ProcessReplSet::setAddReplSets(PArrayIdName v) {
	addReplSets = v;
}
void ProcessReplSet::setAndReplSets(PArrayIdName v) {
	andReplSets = v;
}
void ProcessReplSet::setSetReplSets(PArrayIdName v) {
	setReplSets = v;
}
void ProcessReplSet::setSubReplSets(PArrayIdName v) {
	subReplSets = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessReplSet::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->addReplSets;
	ar & this->andReplSets;
	ar & this->setReplSets;
	ar & this->subReplSets;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_712209598(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessReplSet>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ProcessScript
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ProcessScript::ProcessScript() {
	processPostfix = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ProcessScript::ProcessScript(const ::std::wstring& name, bool processPostfix, const ::std::wstring& tag)
	: name(name)
	, processPostfix(processPostfix)
	, tag(tag)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ProcessScript::BSerializable_getTypeId() {
	return 1122555546; 
}
void ProcessScript::setName(::std::wstring v) {
	name = v;
}
void ProcessScript::setProcessPostfix(bool v) {
	processPostfix = v;
}
void ProcessScript::setTag(::std::wstring v) {
	tag = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ProcessScript::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->name;
	ar & this->processPostfix;
	ar & this->tag;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1122555546(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ProcessScript>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PublicDownload
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PublicDownload::PublicDownload() {
	remaining = 0;
	docId = 0;
	objId = 0;
	userId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PublicDownload::PublicDownload(const ::std::wstring& id, int32_t remaining, const ::std::wstring& expiration, const ::std::wstring& timeStamp, int32_t docId, int32_t objId, int32_t userId, const ::std::wstring& url, const ::std::wstring& fileName, const ::std::wstring& attachmentCode)
	: id(id)
	, remaining(remaining)
	, expiration(expiration)
	, timeStamp(timeStamp)
	, docId(docId)
	, objId(objId)
	, userId(userId)
	, url(url)
	, fileName(fileName)
	, attachmentCode(attachmentCode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PublicDownload::BSerializable_getTypeId() {
	return 2062827124; 
}
void PublicDownload::setId(::std::wstring v) {
	id = v;
	setChangedMember(PublicDownloadC::mbId);
}
void PublicDownload::setRemaining(int32_t v) {
	remaining = v;
	setChangedMember(PublicDownloadC::mbRemaining);
}
void PublicDownload::setExpiration(::std::wstring v) {
	expiration = v;
	setChangedMember(PublicDownloadC::mbExpiration);
}
void PublicDownload::setTimeStamp(::std::wstring v) {
	timeStamp = v;
	setChangedMember(PublicDownloadC::mbTimeStamp);
}
void PublicDownload::setDocId(int32_t v) {
	docId = v;
	setChangedMember(PublicDownloadC::mbDocId);
}
void PublicDownload::setObjId(int32_t v) {
	objId = v;
	setChangedMember(PublicDownloadC::mbObjId);
}
void PublicDownload::setUserId(int32_t v) {
	userId = v;
	setChangedMember(PublicDownloadC::mbUserId);
}
void PublicDownload::setUrl(::std::wstring v) {
	url = v;
}
void PublicDownload::setFileName(::std::wstring v) {
	fileName = v;
	setChangedMember(PublicDownloadC::mbFileName);
}
void PublicDownload::setAttachmentCode(::std::wstring v) {
	attachmentCode = v;
	setChangedMember(PublicDownloadC::mbAttachmentCode);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PublicDownload::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->docId;
	ar & this->expiration;
	ar & this->id;
	ar & this->remaining;
	ar & this->timeStamp;
	ar & this->userId;
	if (version >= 900000000000028) {
		ar & this->objId;
		if (version >= 900000014000002) {
			ar & this->url;
			if (version >= 900000030000030) {
				ar & this->attachmentCode;
				ar & this->fileName;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2062827124(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PublicDownload>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PublicDownloadDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PublicDownloadDataC::PublicDownloadDataC() {
	lnId = 0;
	lnTimeStamp = 0;
	lnExpiration = 0;
	lnFileName = 0;
	lnAttachmentCode = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PublicDownloadDataC::PublicDownloadDataC(int64_t mbId, int32_t lnId, int64_t mbTimeStamp, int32_t lnTimeStamp, int64_t mbRemaining, int64_t mbExpiration, int32_t lnExpiration, int64_t mbDocId, int64_t mbUserId, int64_t mbObjId, int64_t mbFileName, int32_t lnFileName, int64_t mbAttachmentCode, int32_t lnAttachmentCode, int64_t mbAllMembers)
	: lnId(lnId)
	, lnTimeStamp(lnTimeStamp)
	, lnExpiration(lnExpiration)
	, lnFileName(lnFileName)
	, lnAttachmentCode(lnAttachmentCode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PublicDownloadDataC::BSerializable_getTypeId() {
	return 1639180602; 
}
void PublicDownloadDataC::setLnId(int32_t v) {
	lnId = v;
}
void PublicDownloadDataC::setLnTimeStamp(int32_t v) {
	lnTimeStamp = v;
}
void PublicDownloadDataC::setLnExpiration(int32_t v) {
	lnExpiration = v;
}
void PublicDownloadDataC::setLnFileName(int32_t v) {
	lnFileName = v;
}
void PublicDownloadDataC::setLnAttachmentCode(int32_t v) {
	lnAttachmentCode = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PublicDownloadDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnExpiration;
	ar & this->lnId;
	ar & this->lnTimeStamp;
	if (version >= 900000030000030) {
		ar & this->lnAttachmentCode;
		ar & this->lnFileName;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1639180602(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PublicDownloadDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PublicDownloadC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PublicDownloadC::PublicDownloadC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PublicDownloadC::BSerializable_getTypeId() {
	return 1919187163; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PublicDownloadC::serialize(BIO& ar, const BVERSION version) {
	PublicDownloadDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1919187163(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PublicDownloadC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PublicDownloadOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PublicDownloadOptions::PublicDownloadOptions() {
	remaining = 0;
	fileNameFromSordName = false;
	contentDispositionAttachment = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PublicDownloadOptions::PublicDownloadOptions(const PArrayString& downloadIds, const ::std::wstring& expiration, int32_t remaining, const ::std::wstring& docId, const ::std::wstring& objId, bool fileNameFromSordName, bool contentDispositionAttachment)
	: downloadIds(downloadIds)
	, expiration(expiration)
	, remaining(remaining)
	, docId(docId)
	, objId(objId)
	, fileNameFromSordName(fileNameFromSordName)
	, contentDispositionAttachment(contentDispositionAttachment)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PublicDownloadOptions::BSerializable_getTypeId() {
	return 252853324; 
}
void PublicDownloadOptions::setDownloadIds(PArrayString v) {
	downloadIds = v;
}
void PublicDownloadOptions::setExpiration(::std::wstring v) {
	expiration = v;
}
void PublicDownloadOptions::setRemaining(int32_t v) {
	remaining = v;
}
void PublicDownloadOptions::setDocId(::std::wstring v) {
	docId = v;
}
void PublicDownloadOptions::setObjId(::std::wstring v) {
	objId = v;
}
void PublicDownloadOptions::setFileNameFromSordName(bool v) {
	fileNameFromSordName = v;
}
void PublicDownloadOptions::setContentDispositionAttachment(bool v) {
	contentDispositionAttachment = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PublicDownloadOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 900000012000003) {
		ar & this->expiration;
		ar & this->remaining;
		if (version >= 900000012000004) {
			ar & this->docId;
			ar & this->objId;
			if (version >= 900000014000008) {
				ar & this->contentDispositionAttachment;
				ar & this->fileNameFromSordName;
			}
		}
	}
	ar & this->downloadIds;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_252853324(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PublicDownloadOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PurgeSettings
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PurgeSettings::PurgeSettings() {
	dayLimit = 0;
	pathId = 0;
	fileCheckMode = 0;
	startHour = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PurgeSettings::PurgeSettings(int32_t dayLimit, int32_t pathId, int32_t fileCheckMode, int32_t startHour, const byps::PVectorInteger& excludePathIds)
	: dayLimit(dayLimit)
	, pathId(pathId)
	, fileCheckMode(fileCheckMode)
	, startHour(startHour)
	, excludePathIds(excludePathIds)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PurgeSettings::BSerializable_getTypeId() {
	return 1576340510; 
}
void PurgeSettings::setDayLimit(int32_t v) {
	dayLimit = v;
}
void PurgeSettings::setPathId(int32_t v) {
	pathId = v;
}
void PurgeSettings::setFileCheckMode(int32_t v) {
	fileCheckMode = v;
}
void PurgeSettings::setStartHour(int32_t v) {
	startHour = v;
}
void PurgeSettings::setExcludePathIds(byps::PVectorInteger v) {
	excludePathIds = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PurgeSettings::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->dayLimit;
	ar & this->fileCheckMode;
	ar & this->pathId;
	ar & this->startHour;
	if (version >= 900000000000027) {
		ar & this->excludePathIds;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1576340510(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PurgeSettings>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PurgeSettingsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PurgeSettingsC::PurgeSettingsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PurgeSettingsC::BSerializable_getTypeId() {
	return 1865968564; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PurgeSettingsC::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1865968564(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PurgeSettingsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PurgeStatus
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PurgeStatus::PurgeStatus() {
	isRunning = false;
	numberOfDocsPurged = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PurgeStatus::PurgeStatus(bool isRunning, int32_t numberOfDocsPurged, const ::std::wstring& lastPurgeTime, const ::std::wstring& errorMessage)
	: isRunning(isRunning)
	, numberOfDocsPurged(numberOfDocsPurged)
	, lastPurgeTime(lastPurgeTime)
	, errorMessage(errorMessage)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PurgeStatus::BSerializable_getTypeId() {
	return 2053888643; 
}
void PurgeStatus::setIsRunning(bool v) {
	isRunning = v;
}
void PurgeStatus::setNumberOfDocsPurged(int32_t v) {
	numberOfDocsPurged = v;
}
void PurgeStatus::setLastPurgeTime(::std::wstring v) {
	lastPurgeTime = v;
}
void PurgeStatus::setErrorMessage(::std::wstring v) {
	errorMessage = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PurgeStatus::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->errorMessage;
	ar & this->isRunning;
	ar & this->lastPurgeTime;
	ar & this->numberOfDocsPurged;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2053888643(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PurgeStatus>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class QueryJobProtocolC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
QueryJobProtocolC::QueryJobProtocolC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::QueryJobProtocolC::BSerializable_getTypeId() {
	return 1764906979; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void QueryJobProtocolC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1764906979(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::QueryJobProtocolC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class QueryJobProtocolEvent
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
QueryJobProtocolEvent::QueryJobProtocolEvent() {
	level = 0;
	objId = 0;
	eventId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::QueryJobProtocolEvent::QueryJobProtocolEvent(const ::std::wstring& date, const ::std::wstring& message, int32_t level, int32_t objId, int32_t eventId)
	: date(date)
	, message(message)
	, level(level)
	, objId(objId)
	, eventId(eventId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::QueryJobProtocolEvent::BSerializable_getTypeId() {
	return 892520690; 
}
void QueryJobProtocolEvent::setDate(::std::wstring v) {
	date = v;
}
void QueryJobProtocolEvent::setMessage(::std::wstring v) {
	message = v;
}
void QueryJobProtocolEvent::setLevel(int32_t v) {
	level = v;
}
void QueryJobProtocolEvent::setObjId(int32_t v) {
	objId = v;
}
void QueryJobProtocolEvent::setEventId(int32_t v) {
	eventId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void QueryJobProtocolEvent::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->date;
	ar & this->level;
	ar & this->message;
	ar & this->objId;
	if (version >= 900000000000026) {
		ar & this->eventId;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_892520690(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::QueryJobProtocolEvent>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1465721064(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PQueryJobProtocolEvent > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class QueryJobProtocolInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
QueryJobProtocolInfo::QueryJobProtocolInfo() {
	startEventId = 0;
	level = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::QueryJobProtocolInfo::QueryJobProtocolInfo(const ::std::wstring& jobGuid, const ::std::wstring& startDateISO, int32_t startEventId, int32_t level)
	: jobGuid(jobGuid)
	, startDateISO(startDateISO)
	, startEventId(startEventId)
	, level(level)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::QueryJobProtocolInfo::BSerializable_getTypeId() {
	return 1362638222; 
}
void QueryJobProtocolInfo::setJobGuid(::std::wstring v) {
	jobGuid = v;
}
void QueryJobProtocolInfo::setStartDateISO(::std::wstring v) {
	startDateISO = v;
}
void QueryJobProtocolInfo::setStartEventId(int32_t v) {
	startEventId = v;
}
void QueryJobProtocolInfo::setLevel(int32_t v) {
	level = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void QueryJobProtocolInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->jobGuid;
	ar & this->level;
	ar & this->startDateISO;
	if (version >= 900000000000030) {
		ar & this->startEventId;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1362638222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::QueryJobProtocolInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class QueryJobProtocolResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
QueryJobProtocolResult::QueryJobProtocolResult() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::QueryJobProtocolResult::QueryJobProtocolResult(const ::std::wstring& downloadUrl, const PArrayQueryJobProtocolEvent& events)
	: downloadUrl(downloadUrl)
	, events(events)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::QueryJobProtocolResult::BSerializable_getTypeId() {
	return 222450704; 
}
void QueryJobProtocolResult::setDownloadUrl(::std::wstring v) {
	downloadUrl = v;
}
void QueryJobProtocolResult::setEvents(PArrayQueryJobProtocolEvent v) {
	events = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void QueryJobProtocolResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->downloadUrl;
	ar & this->events;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_222450704(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::QueryJobProtocolResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Relation
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Relation::Relation() {
	parentId = 0;
	objId = 0;
	ordinal = 0;
	status = 0;
	mainRelation = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Relation::Relation(int32_t parentId, int32_t objId, int32_t ordinal, int32_t status, const ::std::wstring& tStamp, const ::std::wstring& guid, const ::std::wstring& deleteDateIso, bool mainRelation, const ::std::wstring& TStampSync)
	: parentId(parentId)
	, objId(objId)
	, ordinal(ordinal)
	, status(status)
	, tStamp(tStamp)
	, guid(guid)
	, deleteDateIso(deleteDateIso)
	, mainRelation(mainRelation)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Relation::BSerializable_getTypeId() {
	return 837810375; 
}
void Relation::setParentId(int32_t v) {
	parentId = v;
	setChangedMember(RelationC::mbParentId);
}
void Relation::setObjId(int32_t v) {
	objId = v;
	setChangedMember(RelationC::mbObjId);
}
void Relation::setOrdinal(int32_t v) {
	ordinal = v;
	setChangedMember(RelationC::mbOrdinal);
}
void Relation::setStatus(int32_t v) {
	status = v;
	setChangedMember(RelationC::mbStatus);
}
void Relation::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(RelationC::mbTStamp);
}
void Relation::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(RelationC::mbGuid);
}
void Relation::setDeleteDateIso(::std::wstring v) {
	deleteDateIso = v;
}
void Relation::setMainRelation(bool v) {
	mainRelation = v;
}
void Relation::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(RelationC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Relation::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->objId;
	ar & this->ordinal;
	ar & this->parentId;
	ar & this->status;
	ar & this->tStamp;
	if (version >= 700000000000004) {
		ar & this->guid;
		if (version >= 900000000000002) {
			ar & this->deleteDateIso;
			if (version >= 900990009000001) {
				ar & this->TStampSync;
				ar & this->mainRelation;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_837810375(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Relation>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class RelationC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
RelationC::RelationC() {
	lnTStamp = 0;
	lnGuid = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::RelationC::RelationC(int64_t mbParentId, int64_t mbObjId, int64_t mbOrdinal, int64_t mbStatus, int64_t mbTStamp, int32_t lnTStamp, int64_t mbGuid, int32_t lnGuid, int64_t mbDeleteDate, int64_t mbRelMain, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnTStamp(lnTStamp)
	, lnGuid(lnGuid)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::RelationC::BSerializable_getTypeId() {
	return 1203469035; 
}
void RelationC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void RelationC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void RelationC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void RelationC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnTStamp;
	if (version >= 700000000000004) {
		ar & this->lnGuid;
		if (version >= 900990009000001) {
			ar & this->lnTStampSync;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1203469035(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::RelationC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Reminder
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Reminder::Reminder() {
	id = 0;
	lockId = 0;
	objId = 0;
	objType = 0;
	prio = 0;
	receiverId = 0;
	senderId = 0;
	deleted = false;
	notifyOnDelete = false;
	notifyOnView = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Reminder::Reminder(const ::std::wstring& desc, int32_t id, int32_t lockId, const ::std::wstring& name, int32_t objId, int32_t objType, int32_t prio, int32_t receiverId, int32_t senderId, const ::std::wstring& createDateIso, bool deleted, const ::std::wstring& dueDateIso, const ::std::wstring& lockName, bool notifyOnDelete, bool notifyOnView, const ::std::wstring& objGuid, const ::std::wstring& promptDateIso, const ::std::wstring& receiverName, const ::std::wstring& senderName)
	: desc(desc)
	, id(id)
	, lockId(lockId)
	, name(name)
	, objId(objId)
	, objType(objType)
	, prio(prio)
	, receiverId(receiverId)
	, senderId(senderId)
	, createDateIso(createDateIso)
	, deleted(deleted)
	, dueDateIso(dueDateIso)
	, lockName(lockName)
	, notifyOnDelete(notifyOnDelete)
	, notifyOnView(notifyOnView)
	, objGuid(objGuid)
	, promptDateIso(promptDateIso)
	, receiverName(receiverName)
	, senderName(senderName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Reminder::BSerializable_getTypeId() {
	return 256674679; 
}
void Reminder::setDesc(::std::wstring v) {
	desc = v;
	setChangedMember(ReminderC::mbDesc);
}
void Reminder::setId(int32_t v) {
	id = v;
	setChangedMember(ReminderC::mbId);
}
void Reminder::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(ReminderC::mbLockId);
}
void Reminder::setName(::std::wstring v) {
	name = v;
	setChangedMember(ReminderC::mbName);
}
void Reminder::setObjId(int32_t v) {
	objId = v;
	setChangedMember(ReminderC::mbObjId);
}
void Reminder::setObjType(int32_t v) {
	objType = v;
	setChangedMember(ReminderC::mbObjType);
}
void Reminder::setPrio(int32_t v) {
	prio = v;
	setChangedMember(ReminderC::mbPrio);
}
void Reminder::setReceiverId(int32_t v) {
	receiverId = v;
	setChangedMember(ReminderC::mbReceiverId);
}
void Reminder::setSenderId(int32_t v) {
	senderId = v;
	setChangedMember(ReminderC::mbSenderId);
}
void Reminder::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(ReminderC::mbCreateDateIso);
}
void Reminder::setDeleted(bool v) {
	deleted = v;
	setChangedMember(ReminderC::mbDeleted);
}
void Reminder::setDueDateIso(::std::wstring v) {
	dueDateIso = v;
	setChangedMember(ReminderC::mbDueDateIso);
}
void Reminder::setLockName(::std::wstring v) {
	lockName = v;
	setChangedMember(ReminderC::mbLockName);
}
void Reminder::setNotifyOnDelete(bool v) {
	notifyOnDelete = v;
	setChangedMember(ReminderC::mbNotifyOnDelete);
}
void Reminder::setNotifyOnView(bool v) {
	notifyOnView = v;
	setChangedMember(ReminderC::mbNotifyOnView);
}
void Reminder::setObjGuid(::std::wstring v) {
	objGuid = v;
	setChangedMember(ReminderC::mbObjGuid);
}
void Reminder::setPromptDateIso(::std::wstring v) {
	promptDateIso = v;
	setChangedMember(ReminderC::mbPromptDateIso);
}
void Reminder::setReceiverName(::std::wstring v) {
	receiverName = v;
	setChangedMember(ReminderC::mbReceiverName);
}
void Reminder::setSenderName(::std::wstring v) {
	senderName = v;
	setChangedMember(ReminderC::mbSenderName);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Reminder::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->createDateIso;
	ar & this->deleted;
	ar & this->desc;
	ar & this->dueDateIso;
	ar & this->id;
	ar & this->lockId;
	ar & this->lockName;
	ar & this->name;
	ar & this->notifyOnDelete;
	ar & this->notifyOnView;
	ar & this->objGuid;
	ar & this->objId;
	ar & this->objType;
	ar & this->prio;
	ar & this->promptDateIso;
	ar & this->receiverId;
	ar & this->receiverName;
	ar & this->senderId;
	ar & this->senderName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_256674679(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Reminder>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReminderDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReminderDataC::ReminderDataC() {
	lnName = 0;
	lnDesc = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReminderDataC::ReminderDataC(int64_t mbId, int64_t mbObjId, int64_t mbReceiverId, int64_t mbSenderId, int64_t mbPromptDate, int64_t mbCreateDate, int64_t mbDueDate, int64_t mbPrio, int64_t mbActionCode, int64_t mbLockId, int64_t mbObjType, int64_t mbName, int32_t lnName, int64_t mbDesc, int32_t lnDesc, int64_t mbAllMembers)
	: lnName(lnName)
	, lnDesc(lnDesc)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReminderDataC::BSerializable_getTypeId() {
	return 1099169893; 
}
void ReminderDataC::setLnName(int32_t v) {
	lnName = v;
}
void ReminderDataC::setLnDesc(int32_t v) {
	lnDesc = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReminderDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnDesc;
	ar & this->lnName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1099169893(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReminderDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReminderC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReminderC::ReminderC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReminderC::BSerializable_getTypeId() {
	return 1431555044; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReminderC::serialize(BIO& ar, const BVERSION version) {
	ReminderDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1431555044(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReminderC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1701141707(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PReminder > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReplCode
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring ReplCode::ARCR_OBJECT_DATA_S = std::wstring(L"obj");

const ::std::wstring ReplCode::ARCR_OBJECT_KEYS_S = std::wstring(L"key");

const ::std::wstring ReplCode::ARCR_NOTE_DATA_S = std::wstring(L"not");

const ::std::wstring ReplCode::ARCR_NOTE_DELETE_S = std::wstring(L"ndl");

const ::std::wstring ReplCode::ARCR_VERSION_COMMENT_S = std::wstring(L"dvc");

const ::std::wstring ReplCode::ARCR_OBJECT_RELATIONS_S = std::wstring(L"orl");

const ::std::wstring ReplCode::ARCR_OBJECT_INSERT_REF_S = std::wstring(L"irl");

const ::std::wstring ReplCode::ARCR_OBJECT_DELETE_REF_S = std::wstring(L"drl");

const ::std::wstring ReplCode::ARCR_DOCUMENT_DATA_S = std::wstring(L"doc");

const ::std::wstring ReplCode::ARCR_DOCUMENT_INSERT_S = std::wstring(L"din");

const ::std::wstring ReplCode::ARCR_DOCUMENT_SWITCH_S = std::wstring(L"dsw");

const ::std::wstring ReplCode::ARCR_ATTACHMENT_DATA_S = std::wstring(L"att");

const ::std::wstring ReplCode::ARCR_SIGNATURE_DATA_S = std::wstring(L"sig");

const ::std::wstring ReplCode::ARCR_IGNORE_BROKER_OPTZ_S = std::wstring(L"ibo");

const ::std::wstring ReplCode::ARCR_DOCUMENT_STATUS_S = std::wstring(L"dst");

const ::std::wstring ReplCode::ARCR_BASEDATA_VERIFY_S = std::wstring(L"bvy");

const ::std::wstring ReplCode::ARCR_DOCMASKS_DATA_S = std::wstring(L"dms");

const ::std::wstring ReplCode::ARCR_OBJECT_DELETE_PHYS_S = std::wstring(L"dpy");

const ::std::wstring ReplCode::ARCR_OBJECT_REPLSET_S = std::wstring(L"orp");

const ::std::wstring ReplCode::ARCR_WORKFLOW_DATA_S = std::wstring(L"wfl");

const ::std::wstring ReplCode::ARCR_INITIAL_DATA_S = std::wstring(L"ini");

const ::std::wstring ReplCode::ARCR_MARKER_S = std::wstring(L"mrk");

const ::std::wstring ReplCode::ARCR_OBJECT_HIST_S = std::wstring(L"hst");

const ::std::wstring ReplCode::ARCR_ACTION_S = std::wstring(L"act");

const ::std::wstring ReplCode::ARCR_USER_DATA_S = std::wstring(L"usr");

const ::std::wstring ReplCode::ARCR_USER_DELETE_S = std::wstring(L"usd");

const ::std::wstring ReplCode::ARCR_TRANSLATION_S = std::wstring(L"tra");

const ::std::wstring ReplCode::ARCR_DOCMASK_DELETE_S = std::wstring(L"dmd");

const ::std::wstring ReplCode::ARCR_DOCUMENT_FEED_S = std::wstring(L"fed");

const ::std::wstring ReplCode::ARCR_LINK_S = std::wstring(L"lnk");

const ::std::wstring ReplCode::ARCR_MAP_CHANGED_S = std::wstring(L"map");

const ::std::wstring ReplCode::ARCR_SWL_DATA_S = std::wstring(L"dwl");

const ::std::wstring ReplCode::ARCR_CONTROL_VDS_S = std::wstring(L"vds");

const ::std::wstring ReplCode::ARCR_TRAFO_S = std::wstring(L"tra");

const ::std::wstring ReplCode::ARCR_BROKER_S = std::wstring(L"brk");

const ::std::wstring ReplCode::ARCR_CODE_SEP = std::wstring(L"|");

const ::std::wstring ReplCode::ARCR_EXT_CODE_UNDEF_S = std::wstring(L"???");

// checkpoint byps.gen.cpp.GenApiClass:489
ReplCode::ReplCode() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReplCode::BSerializable_getTypeId() {
	return 1235558040; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReplCode::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1235558040(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReplCode>(bio, pObj, pObjS, pBase);	
}
}}}}

#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByPreviewCtrl
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByPreviewCtrl::FindByPreviewCtrl() {
	previewAvailable = false;
	previewError = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByPreviewCtrl::FindByPreviewCtrl(bool previewAvailable, bool previewError, const PArrayString& fileExtensions)
	: previewAvailable(previewAvailable)
	, previewError(previewError)
	, fileExtensions(fileExtensions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByPreviewCtrl::BSerializable_getTypeId() {
	return 78436038; 
}
void FindByPreviewCtrl::setPreviewAvailable(bool v) {
	previewAvailable = v;
}
void FindByPreviewCtrl::setPreviewError(bool v) {
	previewError = v;
}
void FindByPreviewCtrl::setFileExtensions(PArrayString v) {
	fileExtensions = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByPreviewCtrl::serialize(BIO& ar, const BVERSION version) {
	ar & this->previewAvailable;
	ar & this->previewError;
	if (version >= 700000040000010) {
		ar & this->fileExtensions;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_78436038(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByPreviewCtrl>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByRegisteredFunction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByRegisteredFunction::FindByRegisteredFunction() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByRegisteredFunction::FindByRegisteredFunction(const ::std::wstring& functionName, const PAny& args)
	: functionName(functionName)
	, args(args)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByRegisteredFunction::BSerializable_getTypeId() {
	return 700871698; 
}
void FindByRegisteredFunction::setFunctionName(::std::wstring v) {
	functionName = v;
}
void FindByRegisteredFunction::setArgs(PAny v) {
	args = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByRegisteredFunction::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->functionName;
	ar & this->args;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_700871698(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByRegisteredFunction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindBySordHist
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindBySordHist::FindBySordHist() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindBySordHist::FindBySordHist(const PArraySordHistKey& histKeys)
	: histKeys(histKeys)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindBySordHist::BSerializable_getTypeId() {
	return 2098788325; 
}
void FindBySordHist::setHistKeys(PArraySordHistKey v) {
	histKeys = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindBySordHist::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->histKeys;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2098788325(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindBySordHist>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByType
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByType::FindByType() {
	typeDocuments = false;
	typeStructures = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByType::FindByType(bool typeDocuments, const PArrayString& typeExtensions, const PArrayInt& typeIDs, const PArrayString& typeNames, bool typeStructures)
	: typeDocuments(typeDocuments)
	, typeExtensions(typeExtensions)
	, typeIDs(typeIDs)
	, typeNames(typeNames)
	, typeStructures(typeStructures)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByType::BSerializable_getTypeId() {
	return 151307616; 
}
void FindByType::setTypeDocuments(bool v) {
	typeDocuments = v;
}
void FindByType::setTypeExtensions(PArrayString v) {
	typeExtensions = v;
}
void FindByType::setTypeIDs(PArrayInt v) {
	typeIDs = v;
}
void FindByType::setTypeNames(PArrayString v) {
	typeNames = v;
}
void FindByType::setTypeStructures(bool v) {
	typeStructures = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByType::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->typeDocuments;
	ar & this->typeStructures;
	ar & this->typeExtensions;
	ar & this->typeIDs;
	ar & this->typeNames;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_151307616(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByType>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByVersion
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByVersion::FindByVersion() {
	workVersionOnly = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByVersion::FindByVersion(const ::std::wstring& versionComment, const ::std::wstring& versionMD5, const ::std::wstring& versionNumber, bool workVersionOnly)
	: versionComment(versionComment)
	, versionMD5(versionMD5)
	, versionNumber(versionNumber)
	, workVersionOnly(workVersionOnly)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByVersion::BSerializable_getTypeId() {
	return 925953882; 
}
void FindByVersion::setVersionComment(::std::wstring v) {
	versionComment = v;
}
void FindByVersion::setVersionMD5(::std::wstring v) {
	versionMD5 = v;
}
void FindByVersion::setVersionNumber(::std::wstring v) {
	versionNumber = v;
}
void FindByVersion::setWorkVersionOnly(bool v) {
	workVersionOnly = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByVersion::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->versionComment;
	ar & this->versionMD5;
	ar & this->versionNumber;
	ar & this->workVersionOnly;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_925953882(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByVersion>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindChildren
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindChildren::FindChildren() {
	mainParent = false;
	endLevel = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindChildren::FindChildren(bool mainParent, const ::std::wstring& parentId, int32_t endLevel)
	: mainParent(mainParent)
	, parentId(parentId)
	, endLevel(endLevel)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindChildren::BSerializable_getTypeId() {
	return 752202075; 
}
void FindChildren::setMainParent(bool v) {
	mainParent = v;
}
void FindChildren::setParentId(::std::wstring v) {
	parentId = v;
}
void FindChildren::setEndLevel(int32_t v) {
	endLevel = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindChildren::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->mainParent;
	ar & this->parentId;
	if (version >= 700000000000010) {
		ar & this->endLevel;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_752202075(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindChildren>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindConfigFileInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindConfigFileInfo::FindConfigFileInfo() {
	inclDeputy = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindConfigFileInfo::FindConfigFileInfo(const PArrayString& names, bool inclDeputy, const ::std::wstring& postboxUserId)
	: names(names)
	, inclDeputy(inclDeputy)
	, postboxUserId(postboxUserId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindConfigFileInfo::BSerializable_getTypeId() {
	return 1887106523; 
}
void FindConfigFileInfo::setNames(PArrayString v) {
	names = v;
}
void FindConfigFileInfo::setInclDeputy(bool v) {
	inclDeputy = v;
}
void FindConfigFileInfo::setPostboxUserId(::std::wstring v) {
	postboxUserId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindConfigFileInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->inclDeputy;
	ar & this->postboxUserId;
	ar & this->names;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1887106523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindConfigFileInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindDirect
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindDirect::FindDirect() {
	searchInSordName = false;
	searchInMemo = false;
	searchInIndex = false;
	searchInFulltext = false;
	searchInNotes = false;
	searchInVersions = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindDirect::FindDirect(const ::std::wstring& query, bool searchInSordName, bool searchInMemo, bool searchInIndex, bool searchInFulltext, bool searchInNotes, bool searchInVersions)
	: query(query)
	, searchInSordName(searchInSordName)
	, searchInMemo(searchInMemo)
	, searchInIndex(searchInIndex)
	, searchInFulltext(searchInFulltext)
	, searchInNotes(searchInNotes)
	, searchInVersions(searchInVersions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindDirect::BSerializable_getTypeId() {
	return 1028007046; 
}
void FindDirect::setQuery(::std::wstring v) {
	query = v;
}
void FindDirect::setSearchInSordName(bool v) {
	searchInSordName = v;
}
void FindDirect::setSearchInMemo(bool v) {
	searchInMemo = v;
}
void FindDirect::setSearchInIndex(bool v) {
	searchInIndex = v;
}
void FindDirect::setSearchInFulltext(bool v) {
	searchInFulltext = v;
}
void FindDirect::setSearchInNotes(bool v) {
	searchInNotes = v;
}
void FindDirect::setSearchInVersions(bool v) {
	searchInVersions = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindDirect::serialize(BIO& ar, const BVERSION version) {
	ar & this->query;
	ar & this->searchInFulltext;
	ar & this->searchInIndex;
	ar & this->searchInMemo;
	ar & this->searchInNotes;
	ar & this->searchInSordName;
	ar & this->searchInVersions;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1028007046(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindDirect>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindDirectC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindDirectC::FindDirectC() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindDirectC::FindDirectC(const ::std::wstring& FIELD_DESC, const ::std::wstring& FIELD_EXT, const ::std::wstring& FIELD_OWNER, const ::std::wstring& FIELD_TSTAMP, const ::std::wstring& FIELD_GUID, const ::std::wstring& FIELD_ID, const ::std::wstring& FIELD_DELDATE, const ::std::wstring& FIELD_DELDATE_YEAR, const ::std::wstring& FIELD_DELDATE_MONTH, const ::std::wstring& FIELD_IDATE, const ::std::wstring& FIELD_IDATE_YEAR, const ::std::wstring& FIELD_IDATE_MONTH, const ::std::wstring& FIELD_XDATE, const ::std::wstring& FIELD_XDATE_YEAR, const ::std::wstring& FIELD_XDATE_MONTH, const ::std::wstring& FIELD_MASK_ID, const ::std::wstring& FIELD_MASK_NAME, const ::std::wstring& FIELD_NAME, const ::std::wstring& FIELD_OWNER_ID, const ::std::wstring& FIELD_TYPE, const ::std::wstring& FIELD_OBJ_KEY, const ::std::wstring& FIELD_OBJ_KEY_TOKENIZED, const ::std::wstring& FIELD_OBJ_KEY_NUMERIC, const ::std::wstring& FIELD_OBJ_KEY_DATE, const ::std::wstring& FIELD_DOC_SIZE, const ::std::wstring& FIELD_VERSION_NUMBER, const ::std::wstring& FIELD_VERSION_COMMENT, const ::std::wstring& FIELD_VERSION_OWNER)
	: FIELD_DESC(FIELD_DESC)
	, FIELD_EXT(FIELD_EXT)
	, FIELD_OWNER(FIELD_OWNER)
	, FIELD_TSTAMP(FIELD_TSTAMP)
	, FIELD_GUID(FIELD_GUID)
	, FIELD_ID(FIELD_ID)
	, FIELD_DELDATE(FIELD_DELDATE)
	, FIELD_DELDATE_YEAR(FIELD_DELDATE_YEAR)
	, FIELD_DELDATE_MONTH(FIELD_DELDATE_MONTH)
	, FIELD_IDATE(FIELD_IDATE)
	, FIELD_IDATE_YEAR(FIELD_IDATE_YEAR)
	, FIELD_IDATE_MONTH(FIELD_IDATE_MONTH)
	, FIELD_XDATE(FIELD_XDATE)
	, FIELD_XDATE_YEAR(FIELD_XDATE_YEAR)
	, FIELD_XDATE_MONTH(FIELD_XDATE_MONTH)
	, FIELD_MASK_ID(FIELD_MASK_ID)
	, FIELD_MASK_NAME(FIELD_MASK_NAME)
	, FIELD_NAME(FIELD_NAME)
	, FIELD_OWNER_ID(FIELD_OWNER_ID)
	, FIELD_TYPE(FIELD_TYPE)
	, FIELD_OBJ_KEY(FIELD_OBJ_KEY)
	, FIELD_OBJ_KEY_TOKENIZED(FIELD_OBJ_KEY_TOKENIZED)
	, FIELD_OBJ_KEY_NUMERIC(FIELD_OBJ_KEY_NUMERIC)
	, FIELD_OBJ_KEY_DATE(FIELD_OBJ_KEY_DATE)
	, FIELD_DOC_SIZE(FIELD_DOC_SIZE)
	, FIELD_VERSION_NUMBER(FIELD_VERSION_NUMBER)
	, FIELD_VERSION_COMMENT(FIELD_VERSION_COMMENT)
	, FIELD_VERSION_OWNER(FIELD_VERSION_OWNER)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindDirectC::BSerializable_getTypeId() {
	return 627433249; 
}
void FindDirectC::setFIELD_DESC(::std::wstring v) {
	FIELD_DESC = v;
}
void FindDirectC::setFIELD_EXT(::std::wstring v) {
	FIELD_EXT = v;
}
void FindDirectC::setFIELD_OWNER(::std::wstring v) {
	FIELD_OWNER = v;
}
void FindDirectC::setFIELD_TSTAMP(::std::wstring v) {
	FIELD_TSTAMP = v;
}
void FindDirectC::setFIELD_GUID(::std::wstring v) {
	FIELD_GUID = v;
}
void FindDirectC::setFIELD_ID(::std::wstring v) {
	FIELD_ID = v;
}
void FindDirectC::setFIELD_DELDATE(::std::wstring v) {
	FIELD_DELDATE = v;
}
void FindDirectC::setFIELD_DELDATE_YEAR(::std::wstring v) {
	FIELD_DELDATE_YEAR = v;
}
void FindDirectC::setFIELD_DELDATE_MONTH(::std::wstring v) {
	FIELD_DELDATE_MONTH = v;
}
void FindDirectC::setFIELD_IDATE(::std::wstring v) {
	FIELD_IDATE = v;
}
void FindDirectC::setFIELD_IDATE_YEAR(::std::wstring v) {
	FIELD_IDATE_YEAR = v;
}
void FindDirectC::setFIELD_IDATE_MONTH(::std::wstring v) {
	FIELD_IDATE_MONTH = v;
}
void FindDirectC::setFIELD_XDATE(::std::wstring v) {
	FIELD_XDATE = v;
}
void FindDirectC::setFIELD_XDATE_YEAR(::std::wstring v) {
	FIELD_XDATE_YEAR = v;
}
void FindDirectC::setFIELD_XDATE_MONTH(::std::wstring v) {
	FIELD_XDATE_MONTH = v;
}
void FindDirectC::setFIELD_MASK_ID(::std::wstring v) {
	FIELD_MASK_ID = v;
}
void FindDirectC::setFIELD_MASK_NAME(::std::wstring v) {
	FIELD_MASK_NAME = v;
}
void FindDirectC::setFIELD_NAME(::std::wstring v) {
	FIELD_NAME = v;
}
void FindDirectC::setFIELD_OWNER_ID(::std::wstring v) {
	FIELD_OWNER_ID = v;
}
void FindDirectC::setFIELD_TYPE(::std::wstring v) {
	FIELD_TYPE = v;
}
void FindDirectC::setFIELD_OBJ_KEY(::std::wstring v) {
	FIELD_OBJ_KEY = v;
}
void FindDirectC::setFIELD_OBJ_KEY_TOKENIZED(::std::wstring v) {
	FIELD_OBJ_KEY_TOKENIZED = v;
}
void FindDirectC::setFIELD_OBJ_KEY_NUMERIC(::std::wstring v) {
	FIELD_OBJ_KEY_NUMERIC = v;
}
void FindDirectC::setFIELD_OBJ_KEY_DATE(::std::wstring v) {
	FIELD_OBJ_KEY_DATE = v;
}
void FindDirectC::setFIELD_DOC_SIZE(::std::wstring v) {
	FIELD_DOC_SIZE = v;
}
void FindDirectC::setFIELD_VERSION_NUMBER(::std::wstring v) {
	FIELD_VERSION_NUMBER = v;
}
void FindDirectC::setFIELD_VERSION_COMMENT(::std::wstring v) {
	FIELD_VERSION_COMMENT = v;
}
void FindDirectC::setFIELD_VERSION_OWNER(::std::wstring v) {
	FIELD_VERSION_OWNER = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindDirectC::serialize(BIO& ar, const BVERSION version) {
	ar & this->FIELD_DELDATE;
	ar & this->FIELD_DELDATE_MONTH;
	ar & this->FIELD_DELDATE_YEAR;
	ar & this->FIELD_DESC;
	ar & this->FIELD_EXT;
	ar & this->FIELD_GUID;
	ar & this->FIELD_ID;
	ar & this->FIELD_IDATE;
	ar & this->FIELD_IDATE_MONTH;
	ar & this->FIELD_IDATE_YEAR;
	ar & this->FIELD_MASK_ID;
	ar & this->FIELD_MASK_NAME;
	ar & this->FIELD_NAME;
	ar & this->FIELD_OBJ_KEY;
	ar & this->FIELD_OBJ_KEY_TOKENIZED;
	ar & this->FIELD_OWNER;
	ar & this->FIELD_OWNER_ID;
	ar & this->FIELD_TSTAMP;
	ar & this->FIELD_TYPE;
	ar & this->FIELD_XDATE;
	ar & this->FIELD_XDATE_MONTH;
	ar & this->FIELD_XDATE_YEAR;
	if (version >= 1000000020000018) {
		ar & this->FIELD_DOC_SIZE;
		ar & this->FIELD_OBJ_KEY_DATE;
		ar & this->FIELD_OBJ_KEY_NUMERIC;
		if (version >= 1000000020000019) {
			ar & this->FIELD_VERSION_COMMENT;
			ar & this->FIELD_VERSION_NUMBER;
			ar & this->FIELD_VERSION_OWNER;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_627433249(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindDirectC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindInfo::FindInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindInfo::FindInfo(const PFindByFulltext& findByFulltext, const PFindDirect& findDirect, const PFindByIndex& findByIndex, const PFindByNotes& findByNotes, const PFindBySordHist& findBySordHist, const PFindByType& findByType, const PFindByVersion& findByVersion, const PFindChildren& findChildren, const PFindOptions& findOptions, const PFindByAcl& findByAcl, const PFindByPreviewCtrl& findByPreviewCtrl, const PFindByFulltextCtrl& findByFulltextCtrl, const PFindByRegisteredFunction& findByRegisteredFunction, const PFindLinks& findLinks)
	: findByFulltext(findByFulltext)
	, findDirect(findDirect)
	, findByIndex(findByIndex)
	, findByNotes(findByNotes)
	, findBySordHist(findBySordHist)
	, findByType(findByType)
	, findByVersion(findByVersion)
	, findChildren(findChildren)
	, findOptions(findOptions)
	, findByAcl(findByAcl)
	, findByPreviewCtrl(findByPreviewCtrl)
	, findByFulltextCtrl(findByFulltextCtrl)
	, findByRegisteredFunction(findByRegisteredFunction)
	, findLinks(findLinks)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindInfo::BSerializable_getTypeId() {
	return 1017838205; 
}
void FindInfo::setFindByFulltext(PFindByFulltext v) {
	findByFulltext = v;
}
void FindInfo::setFindDirect(PFindDirect v) {
	findDirect = v;
}
void FindInfo::setFindByIndex(PFindByIndex v) {
	findByIndex = v;
}
void FindInfo::setFindByNotes(PFindByNotes v) {
	findByNotes = v;
}
void FindInfo::setFindBySordHist(PFindBySordHist v) {
	findBySordHist = v;
}
void FindInfo::setFindByType(PFindByType v) {
	findByType = v;
}
void FindInfo::setFindByVersion(PFindByVersion v) {
	findByVersion = v;
}
void FindInfo::setFindChildren(PFindChildren v) {
	findChildren = v;
}
void FindInfo::setFindOptions(PFindOptions v) {
	findOptions = v;
}
void FindInfo::setFindByAcl(PFindByAcl v) {
	findByAcl = v;
}
void FindInfo::setFindByPreviewCtrl(PFindByPreviewCtrl v) {
	findByPreviewCtrl = v;
}
void FindInfo::setFindByFulltextCtrl(PFindByFulltextCtrl v) {
	findByFulltextCtrl = v;
}
void FindInfo::setFindByRegisteredFunction(PFindByRegisteredFunction v) {
	findByRegisteredFunction = v;
}
void FindInfo::setFindLinks(PFindLinks v) {
	findLinks = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->findByFulltext;
	ar & this->findByIndex;
	ar & this->findByNotes;
	ar & this->findBySordHist;
	ar & this->findByType;
	ar & this->findByVersion;
	ar & this->findChildren;
	ar & this->findOptions;
	if (version >= 600000092000000) {
		ar & this->findDirect;
		if (version >= 700000000000011) {
			ar & this->findByAcl;
			if (version >= 700000026000001) {
				ar & this->findByPreviewCtrl;
				if (version >= 700000040000006) {
					ar & this->findByFulltextCtrl;
					if (version >= 700000040000020) {
						ar & this->findByRegisteredFunction;
						if (version >= 900000000000028) {
							ar & this->findLinks;
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
void BSerializer_1017838205(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindInfoAsInternalSQL
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindInfoAsInternalSQL::FindInfoAsInternalSQL() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindInfoAsInternalSQL::FindInfoAsInternalSQL(const ::std::wstring& fromTables, const ::std::wstring& whereClause, const ::std::wstring& orderByClause, const ::std::wstring& groupByClause)
	: fromTables(fromTables)
	, whereClause(whereClause)
	, orderByClause(orderByClause)
	, groupByClause(groupByClause)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindInfoAsInternalSQL::BSerializable_getTypeId() {
	return 2003160309; 
}
void FindInfoAsInternalSQL::setFromTables(::std::wstring v) {
	fromTables = v;
}
void FindInfoAsInternalSQL::setWhereClause(::std::wstring v) {
	whereClause = v;
}
void FindInfoAsInternalSQL::setOrderByClause(::std::wstring v) {
	orderByClause = v;
}
void FindInfoAsInternalSQL::setGroupByClause(::std::wstring v) {
	groupByClause = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindInfoAsInternalSQL::serialize(BIO& ar, const BVERSION version) {
	ar & this->fromTables;
	ar & this->groupByClause;
	ar & this->orderByClause;
	ar & this->whereClause;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2003160309(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindInfoAsInternalSQL>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindLinks
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindLinks::FindLinks() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindLinks::FindLinks(const ::std::wstring& objectId)
	: objectId(objectId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindLinks::BSerializable_getTypeId() {
	return 832548178; 
}
void FindLinks::setObjectId(::std::wstring v) {
	objectId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindLinks::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->objectId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_832548178(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindLinks>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindOptions::FindOptions() {
	inclDeleted = false;
	reserved = 0;
	sortOrder = 0;
	timeoutSeconds = 0;
	totalCount = 0;
	evalCount = false;
	onlyDeleted = false;
	searchLifetimeSeconds = 0;
	excludeSummary = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindOptions::FindOptions(const ::std::wstring& escapeChar, bool inclDeleted, const PArrayString& objIds, const ::std::wstring& orderBy, const ::std::wstring& rangeDelimiter, const PReplSet& replSet, int64_t reserved, const ::std::wstring& searchId, const PSearchModeZ& searchMode, int32_t sortOrder, int32_t timeoutSeconds, int32_t totalCount, bool evalCount, bool onlyDeleted, const ::std::wstring& TStamp, const ::std::wstring& wildcards, const PLockZ& lockZ, int32_t searchLifetimeSeconds, bool excludeSummary)
	: escapeChar(escapeChar)
	, inclDeleted(inclDeleted)
	, objIds(objIds)
	, orderBy(orderBy)
	, rangeDelimiter(rangeDelimiter)
	, replSet(replSet)
	, reserved(reserved)
	, searchId(searchId)
	, searchMode(searchMode)
	, sortOrder(sortOrder)
	, timeoutSeconds(timeoutSeconds)
	, totalCount(totalCount)
	, evalCount(evalCount)
	, onlyDeleted(onlyDeleted)
	, TStamp(TStamp)
	, wildcards(wildcards)
	, lockZ(lockZ)
	, searchLifetimeSeconds(searchLifetimeSeconds)
	, excludeSummary(excludeSummary)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindOptions::BSerializable_getTypeId() {
	return 1371440255; 
}
void FindOptions::setEscapeChar(::std::wstring v) {
	escapeChar = v;
}
void FindOptions::setInclDeleted(bool v) {
	inclDeleted = v;
}
void FindOptions::setObjIds(PArrayString v) {
	objIds = v;
}
void FindOptions::setOrderBy(::std::wstring v) {
	orderBy = v;
}
void FindOptions::setRangeDelimiter(::std::wstring v) {
	rangeDelimiter = v;
}
void FindOptions::setReplSet(PReplSet v) {
	replSet = v;
}
void FindOptions::setReserved(int64_t v) {
	reserved = v;
}
void FindOptions::setSearchId(::std::wstring v) {
	searchId = v;
}
void FindOptions::setSearchMode(PSearchModeZ v) {
	searchMode = v;
}
void FindOptions::setSortOrder(int32_t v) {
	sortOrder = v;
}
void FindOptions::setTimeoutSeconds(int32_t v) {
	timeoutSeconds = v;
}
void FindOptions::setTotalCount(int32_t v) {
	totalCount = v;
}
void FindOptions::setEvalCount(bool v) {
	evalCount = v;
}
void FindOptions::setOnlyDeleted(bool v) {
	onlyDeleted = v;
}
void FindOptions::setTStamp(::std::wstring v) {
	TStamp = v;
}
void FindOptions::setWildcards(::std::wstring v) {
	wildcards = v;
}
void FindOptions::setLockZ(PLockZ v) {
	lockZ = v;
}
void FindOptions::setSearchLifetimeSeconds(int32_t v) {
	searchLifetimeSeconds = v;
}
void FindOptions::setExcludeSummary(bool v) {
	excludeSummary = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->escapeChar;
	ar & this->evalCount;
	ar & this->inclDeleted;
	ar & this->orderBy;
	ar & this->rangeDelimiter;
	ar & this->reserved;
	ar & this->searchId;
	ar & this->sortOrder;
	ar & this->timeoutSeconds;
	ar & this->totalCount;
	if (version >= 700000000000022) {
		ar & this->onlyDeleted;
		if (version >= 700000006000001) {
			ar & this->TStamp;
			if (version >= 700000022000002) {
				ar & this->wildcards;
				if (version >= 800000026000000) {
					ar & this->excludeSummary;
					ar & this->searchLifetimeSeconds;
				}
			}
		}
	}
	ar & this->objIds;
	ar & this->replSet;
	ar & this->searchMode;
	if (version >= 700000022000004) {
		ar & this->lockZ;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1371440255(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindReportInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindReportInfo::FindReportInfo() {
	timeoutSeconds = 0;
	totalCount = 0;
	findLastEntryBeforeEndDate = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindReportInfo::FindReportInfo(const ::std::wstring& endDateIso, const PArrayInt& erpCodes, const ::std::wstring& objId, const ::std::wstring& orderBy, const ::std::wstring& searchId, const ::std::wstring& startDateIso, int32_t timeoutSeconds, int32_t totalCount, const ::std::wstring& userId, bool findLastEntryBeforeEndDate, const ::std::wstring& extra1)
	: endDateIso(endDateIso)
	, erpCodes(erpCodes)
	, objId(objId)
	, orderBy(orderBy)
	, searchId(searchId)
	, startDateIso(startDateIso)
	, timeoutSeconds(timeoutSeconds)
	, totalCount(totalCount)
	, userId(userId)
	, findLastEntryBeforeEndDate(findLastEntryBeforeEndDate)
	, extra1(extra1)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindReportInfo::BSerializable_getTypeId() {
	return 504724737; 
}
void FindReportInfo::setEndDateIso(::std::wstring v) {
	endDateIso = v;
}
void FindReportInfo::setErpCodes(PArrayInt v) {
	erpCodes = v;
}
void FindReportInfo::setObjId(::std::wstring v) {
	objId = v;
}
void FindReportInfo::setOrderBy(::std::wstring v) {
	orderBy = v;
}
void FindReportInfo::setSearchId(::std::wstring v) {
	searchId = v;
}
void FindReportInfo::setStartDateIso(::std::wstring v) {
	startDateIso = v;
}
void FindReportInfo::setTimeoutSeconds(int32_t v) {
	timeoutSeconds = v;
}
void FindReportInfo::setTotalCount(int32_t v) {
	totalCount = v;
}
void FindReportInfo::setUserId(::std::wstring v) {
	userId = v;
}
void FindReportInfo::setFindLastEntryBeforeEndDate(bool v) {
	findLastEntryBeforeEndDate = v;
}
void FindReportInfo::setExtra1(::std::wstring v) {
	extra1 = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindReportInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->endDateIso;
	ar & this->objId;
	ar & this->orderBy;
	ar & this->searchId;
	ar & this->startDateIso;
	ar & this->timeoutSeconds;
	ar & this->totalCount;
	ar & this->userId;
	if (version >= 900000016000004) {
		ar & this->extra1;
		ar & this->findLastEntryBeforeEndDate;
	}
	ar & this->erpCodes;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_504724737(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindReportInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindResult::FindResult() {
	breakTimeout = false;
	breakTotalCount = false;
	moreResults = false;
	count = 0;
	estimatedCount = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindResult::FindResult(bool breakTimeout, bool breakTotalCount, const PArrayConfigFile& configFiles, const PArrayString& ids, bool moreResults, const PArrayReportInfo& reportInfos, int32_t count, int32_t estimatedCount, const ::std::wstring& searchId, const PArraySord& sords, const PArrayUserTask& tasks, const PArrayWFDiagram& workflows, const PArrayTranslateTerm& translateTerms, const PArrayFindByFulltextResultItem& fulltextResultItems, const PArrayFindByFulltextCtrlResultItem& fulltextCtrlResultItems, const ::std::wstring& dynamicFolder, const PArrayJobState& jobStates, const de::elo::ix::client::feed::PArrayAction& actions, const de::elo::ix::client::feed::PMapStringFeed& feeds, const PMapStringSubscription& subscriptions, const PMapStringNotification& notifications, const de::elo::ix::client::feed::PVectorHashTagRelation& hashTagRelations, const de::elo::ix::client::feed::PMapStringHashTag& hashTags, const PVectorNote& notes, const PMapIntegerUserInfo& userInfos, const PMapIntegerUserName& userNames)
	: breakTimeout(breakTimeout)
	, breakTotalCount(breakTotalCount)
	, configFiles(configFiles)
	, ids(ids)
	, moreResults(moreResults)
	, reportInfos(reportInfos)
	, count(count)
	, estimatedCount(estimatedCount)
	, searchId(searchId)
	, sords(sords)
	, tasks(tasks)
	, workflows(workflows)
	, translateTerms(translateTerms)
	, fulltextResultItems(fulltextResultItems)
	, fulltextCtrlResultItems(fulltextCtrlResultItems)
	, dynamicFolder(dynamicFolder)
	, jobStates(jobStates)
	, actions(actions)
	, feeds(feeds)
	, subscriptions(subscriptions)
	, notifications(notifications)
	, hashTagRelations(hashTagRelations)
	, hashTags(hashTags)
	, notes(notes)
	, userInfos(userInfos)
	, userNames(userNames)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindResult::BSerializable_getTypeId() {
	return 1301335819; 
}
void FindResult::setBreakTimeout(bool v) {
	breakTimeout = v;
}
void FindResult::setBreakTotalCount(bool v) {
	breakTotalCount = v;
}
void FindResult::setConfigFiles(PArrayConfigFile v) {
	configFiles = v;
}
void FindResult::setIds(PArrayString v) {
	ids = v;
}
void FindResult::setMoreResults(bool v) {
	moreResults = v;
}
void FindResult::setReportInfos(PArrayReportInfo v) {
	reportInfos = v;
}
void FindResult::setCount(int32_t v) {
	count = v;
}
void FindResult::setEstimatedCount(int32_t v) {
	estimatedCount = v;
}
void FindResult::setSearchId(::std::wstring v) {
	searchId = v;
}
void FindResult::setSords(PArraySord v) {
	sords = v;
}
void FindResult::setTasks(PArrayUserTask v) {
	tasks = v;
}
void FindResult::setWorkflows(PArrayWFDiagram v) {
	workflows = v;
}
void FindResult::setTranslateTerms(PArrayTranslateTerm v) {
	translateTerms = v;
}
void FindResult::setFulltextResultItems(PArrayFindByFulltextResultItem v) {
	fulltextResultItems = v;
}
void FindResult::setFulltextCtrlResultItems(PArrayFindByFulltextCtrlResultItem v) {
	fulltextCtrlResultItems = v;
}
void FindResult::setDynamicFolder(::std::wstring v) {
	dynamicFolder = v;
}
void FindResult::setJobStates(PArrayJobState v) {
	jobStates = v;
}
void FindResult::setActions(de::elo::ix::client::feed::PArrayAction v) {
	actions = v;
}
void FindResult::setFeeds(de::elo::ix::client::feed::PMapStringFeed v) {
	feeds = v;
}
void FindResult::setSubscriptions(PMapStringSubscription v) {
	subscriptions = v;
}
void FindResult::setNotifications(PMapStringNotification v) {
	notifications = v;
}
void FindResult::setHashTagRelations(de::elo::ix::client::feed::PVectorHashTagRelation v) {
	hashTagRelations = v;
}
void FindResult::setHashTags(de::elo::ix::client::feed::PMapStringHashTag v) {
	hashTags = v;
}
void FindResult::setNotes(PVectorNote v) {
	notes = v;
}
void FindResult::setUserInfos(PMapIntegerUserInfo v) {
	userInfos = v;
}
void FindResult::setUserNames(PMapIntegerUserName v) {
	userNames = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->breakTimeout;
	ar & this->breakTotalCount;
	ar & this->count;
	ar & this->moreResults;
	ar & this->searchId;
	if (version >= 700000040000004) {
		ar & this->estimatedCount;
		if (version >= 800000020000006) {
			ar & this->dynamicFolder;
		}
	}
	ar & this->configFiles;
	ar & this->ids;
	ar & this->reportInfos;
	ar & this->sords;
	ar & this->tasks;
	if (version >= 600000094000000) {
		ar & this->workflows;
		if (version >= 700000000000000) {
			ar & this->translateTerms;
			if (version >= 700000040000002) {
				ar & this->fulltextResultItems;
				if (version >= 700000040000008) {
					ar & this->fulltextCtrlResultItems;
					if (version >= 800000036000000) {
						ar & this->jobStates;
						if (version >= 900000000000003) {
							ar & this->actions;
							if (version >= 900000000000004) {
								ar & this->feeds;
								if (version >= 900000014000003) {
									ar & this->subscriptions;
									if (version >= 900000016000003) {
										ar & this->notes;
										if (version >= 900000022000006) {
											ar & this->notifications;
											if (version >= 900000022000015) {
												ar & this->hashTagRelations;
												if (version >= 900000022000020) {
													ar & this->hashTags;
													if (version >= 900000050000001) {
														ar & this->userInfos;
														ar & this->userNames;
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
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1301335819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindSubscriptionInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindSubscriptionInfo::FindSubscriptionInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindSubscriptionInfo::FindSubscriptionInfo(const PSordZ& sordZ, const de::elo::ix::client::feed::PFeedZ& feedZ, const ::std::wstring& userId)
	: sordZ(sordZ)
	, feedZ(feedZ)
	, userId(userId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindSubscriptionInfo::BSerializable_getTypeId() {
	return 1419135016; 
}
void FindSubscriptionInfo::setSordZ(PSordZ v) {
	sordZ = v;
}
void FindSubscriptionInfo::setFeedZ(de::elo::ix::client::feed::PFeedZ v) {
	feedZ = v;
}
void FindSubscriptionInfo::setUserId(::std::wstring v) {
	userId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindSubscriptionInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 900000014000005) {
		ar & this->userId;
	}
	if (version >= 900000014000005) {
		ar & this->feedZ;
		ar & this->sordZ;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1419135016(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindSubscriptionInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindTasksInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindTasksInfo::FindTasksInfo() {
	highestPriority = 0;
	inclActivities = false;
	inclDeputy = false;
	inclGroup = false;
	inclReminders = false;
	inclWorkflows = false;
	lowestPriority = 0;
	overTimeLimit = false;
	inclOverTimeForSuperior = false;
	inclDeleted = false;
	allUsers = false;
	updateInUseDate = false;
	inclHidden = false;
	timeLimitBias = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindTasksInfo::FindTasksInfo(const ::std::wstring& endDateIso, int32_t highestPriority, bool inclActivities, bool inclDeputy, bool inclGroup, bool inclReminders, bool inclWorkflows, int32_t lowestPriority, const ::std::wstring& objId, const PUserTaskSortOrderZ& sortOrder, const ::std::wstring& startDateIso, bool overTimeLimit, bool inclOverTimeForSuperior, const PArrayString& userIds, bool inclDeleted, bool allUsers, const PSordZ& sordZ, const ::std::wstring& taskName, bool updateInUseDate, const byps::PVectorString& inclActivityTypes, bool inclHidden, int32_t timeLimitBias)
	: endDateIso(endDateIso)
	, highestPriority(highestPriority)
	, inclActivities(inclActivities)
	, inclDeputy(inclDeputy)
	, inclGroup(inclGroup)
	, inclReminders(inclReminders)
	, inclWorkflows(inclWorkflows)
	, lowestPriority(lowestPriority)
	, objId(objId)
	, sortOrder(sortOrder)
	, startDateIso(startDateIso)
	, overTimeLimit(overTimeLimit)
	, inclOverTimeForSuperior(inclOverTimeForSuperior)
	, userIds(userIds)
	, inclDeleted(inclDeleted)
	, allUsers(allUsers)
	, sordZ(sordZ)
	, taskName(taskName)
	, updateInUseDate(updateInUseDate)
	, inclActivityTypes(inclActivityTypes)
	, inclHidden(inclHidden)
	, timeLimitBias(timeLimitBias)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindTasksInfo::BSerializable_getTypeId() {
	return 1489194452; 
}
void FindTasksInfo::setEndDateIso(::std::wstring v) {
	endDateIso = v;
}
void FindTasksInfo::setHighestPriority(int32_t v) {
	highestPriority = v;
}
void FindTasksInfo::setInclActivities(bool v) {
	inclActivities = v;
}
void FindTasksInfo::setInclDeputy(bool v) {
	inclDeputy = v;
}
void FindTasksInfo::setInclGroup(bool v) {
	inclGroup = v;
}
void FindTasksInfo::setInclReminders(bool v) {
	inclReminders = v;
}
void FindTasksInfo::setInclWorkflows(bool v) {
	inclWorkflows = v;
}
void FindTasksInfo::setLowestPriority(int32_t v) {
	lowestPriority = v;
}
void FindTasksInfo::setObjId(::std::wstring v) {
	objId = v;
}
void FindTasksInfo::setSortOrder(PUserTaskSortOrderZ v) {
	sortOrder = v;
}
void FindTasksInfo::setStartDateIso(::std::wstring v) {
	startDateIso = v;
}
void FindTasksInfo::setOverTimeLimit(bool v) {
	overTimeLimit = v;
}
void FindTasksInfo::setInclOverTimeForSuperior(bool v) {
	inclOverTimeForSuperior = v;
}
void FindTasksInfo::setUserIds(PArrayString v) {
	userIds = v;
}
void FindTasksInfo::setInclDeleted(bool v) {
	inclDeleted = v;
}
void FindTasksInfo::setAllUsers(bool v) {
	allUsers = v;
}
void FindTasksInfo::setSordZ(PSordZ v) {
	sordZ = v;
}
void FindTasksInfo::setTaskName(::std::wstring v) {
	taskName = v;
}
void FindTasksInfo::setUpdateInUseDate(bool v) {
	updateInUseDate = v;
}
void FindTasksInfo::setInclActivityTypes(byps::PVectorString v) {
	inclActivityTypes = v;
}
void FindTasksInfo::setInclHidden(bool v) {
	inclHidden = v;
}
void FindTasksInfo::setTimeLimitBias(int32_t v) {
	timeLimitBias = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindTasksInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->endDateIso;
	ar & this->highestPriority;
	ar & this->inclActivities;
	ar & this->inclDeputy;
	ar & this->inclGroup;
	ar & this->inclReminders;
	ar & this->inclWorkflows;
	ar & this->lowestPriority;
	ar & this->objId;
	ar & this->startDateIso;
	if (version >= 600000098000000) {
		ar & this->overTimeLimit;
		if (version >= 800000010000006) {
			ar & this->inclOverTimeForSuperior;
			if (version >= 800000012000005) {
				ar & this->inclDeleted;
				if (version >= 800000020000003) {
					ar & this->allUsers;
					if (version >= 800000028000002) {
						ar & this->taskName;
						if (version >= 900000000000025) {
							ar & this->updateInUseDate;
							if (version >= 900000018000006) {
								ar & this->inclHidden;
								if (version >= 900990009000009) {
									ar & this->timeLimitBias;
								}
							}
						}
					}
				}
			}
		}
	}
	ar & this->sortOrder;
	if (version >= 800000012000003) {
		ar & this->userIds;
		if (version >= 800000020000004) {
			ar & this->sordZ;
			if (version >= 900000000000003) {
				ar & this->inclActivityTypes;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1489194452(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindTasksInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindTranslateTermInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindTranslateTermInfo::FindTranslateTermInfo() {
	inclDeleted = false;
	inclToBeTranslated = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindTranslateTermInfo::FindTranslateTermInfo(const PArrayString& terms, const PArrayString& langs, bool inclDeleted, bool inclToBeTranslated)
	: terms(terms)
	, langs(langs)
	, inclDeleted(inclDeleted)
	, inclToBeTranslated(inclToBeTranslated)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindTranslateTermInfo::BSerializable_getTypeId() {
	return 986701599; 
}
void FindTranslateTermInfo::setTerms(PArrayString v) {
	terms = v;
}
void FindTranslateTermInfo::setLangs(PArrayString v) {
	langs = v;
}
void FindTranslateTermInfo::setInclDeleted(bool v) {
	inclDeleted = v;
}
void FindTranslateTermInfo::setInclToBeTranslated(bool v) {
	inclToBeTranslated = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindTranslateTermInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->inclDeleted;
	if (version >= 700000000000031) {
		ar & this->inclToBeTranslated;
	}
	ar & this->langs;
	ar & this->terms;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_986701599(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindTranslateTermInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindUserInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindUserInfo::FindUserInfo() {
	onlyUsers = false;
	onlyGroups = false;
	returnUserInfoMap = false;
	hasFlags = 0;
	hasNotFlags = 0;
	hasFlags2 = 0;
	hasNotFlags2 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindUserInfo::FindUserInfo(const ::std::wstring& name, const ::std::wstring& desc, const PKeyValue& property, const PKeyValue& ldapProperty, bool onlyUsers, bool onlyGroups, bool returnUserInfoMap, const PArrayString& userIds, const PCheckoutUsersZ& checkoutUsersZ, int32_t hasFlags, int32_t hasNotFlags, int32_t hasFlags2, int32_t hasNotFlags2)
	: name(name)
	, desc(desc)
	, property(property)
	, ldapProperty(ldapProperty)
	, onlyUsers(onlyUsers)
	, onlyGroups(onlyGroups)
	, returnUserInfoMap(returnUserInfoMap)
	, userIds(userIds)
	, checkoutUsersZ(checkoutUsersZ)
	, hasFlags(hasFlags)
	, hasNotFlags(hasNotFlags)
	, hasFlags2(hasFlags2)
	, hasNotFlags2(hasNotFlags2)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindUserInfo::BSerializable_getTypeId() {
	return 1847547446; 
}
void FindUserInfo::setName(::std::wstring v) {
	name = v;
}
void FindUserInfo::setDesc(::std::wstring v) {
	desc = v;
}
void FindUserInfo::setProperty(PKeyValue v) {
	property = v;
}
void FindUserInfo::setLdapProperty(PKeyValue v) {
	ldapProperty = v;
}
void FindUserInfo::setOnlyUsers(bool v) {
	onlyUsers = v;
}
void FindUserInfo::setOnlyGroups(bool v) {
	onlyGroups = v;
}
void FindUserInfo::setReturnUserInfoMap(bool v) {
	returnUserInfoMap = v;
}
void FindUserInfo::setUserIds(PArrayString v) {
	userIds = v;
}
void FindUserInfo::setCheckoutUsersZ(PCheckoutUsersZ v) {
	checkoutUsersZ = v;
}
void FindUserInfo::setHasFlags(int32_t v) {
	hasFlags = v;
}
void FindUserInfo::setHasNotFlags(int32_t v) {
	hasNotFlags = v;
}
void FindUserInfo::setHasFlags2(int32_t v) {
	hasFlags2 = v;
}
void FindUserInfo::setHasNotFlags2(int32_t v) {
	hasNotFlags2 = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindUserInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->desc;
	ar & this->name;
	ar & this->onlyGroups;
	ar & this->onlyUsers;
	ar & this->returnUserInfoMap;
	if (version >= 1000170010000005) {
		ar & this->hasFlags;
		ar & this->hasFlags2;
		ar & this->hasNotFlags;
		ar & this->hasNotFlags2;
	}
	ar & this->ldapProperty;
	ar & this->property;
	if (version >= 1000170010000004) {
		ar & this->checkoutUsersZ;
		ar & this->userIds;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1847547446(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindUserInfo>(bio, pObj, pObjS, pBase);	
}
}}}}

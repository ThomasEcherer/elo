#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1788243283(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PJobState > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeyInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeyInfo::KeyInfo() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeyInfo::KeyInfo(int32_t id, const ::std::wstring& name)
	: id(id)
	, name(name)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeyInfo::BSerializable_getTypeId() {
	return 1537059480; 
}
void KeyInfo::setId(int32_t v) {
	id = v;
}
void KeyInfo::setName(::std::wstring v) {
	name = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeyInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->name;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1537059480(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeyInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1112009864(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PKeyInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeyValue
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeyValue::KeyValue() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeyValue::KeyValue(const ::std::wstring& key, const ::std::wstring& value)
	: key(key)
	, value(value)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeyValue::BSerializable_getTypeId() {
	return 516301248; 
}
void KeyValue::setKey(::std::wstring v) {
	key = v;
}
void KeyValue::setValue(::std::wstring v) {
	value = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeyValue::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->key;
	ar & this->value;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_516301248(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeyValue>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1826370901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PKeyValue > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Keyword
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Keyword::Keyword() {
	add = false;
	enabled = false;
	raw = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Keyword::Keyword(bool add, const PArrayKeyword& children, bool enabled, const ::std::wstring& id, bool raw, const ::std::wstring& text)
	: add(add)
	, children(children)
	, enabled(enabled)
	, id(id)
	, raw(raw)
	, text(text)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Keyword::BSerializable_getTypeId() {
	return 1426243550; 
}
void Keyword::setAdd(bool v) {
	add = v;
}
void Keyword::setChildren(PArrayKeyword v) {
	children = v;
}
void Keyword::setEnabled(bool v) {
	enabled = v;
}
void Keyword::setId(::std::wstring v) {
	id = v;
}
void Keyword::setRaw(bool v) {
	raw = v;
	setChangedMember(KeywordC::mbRawText);
}
void Keyword::setText(::std::wstring v) {
	text = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Keyword::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->add;
	ar & this->enabled;
	ar & this->id;
	ar & this->raw;
	ar & this->text;
	ar & this->children;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1426243550(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Keyword>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeywordC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring KeywordC::KWID_STANDARD_LIST = std::wstring(L"ELOSTDSWL");

const ::std::wstring KeywordC::KWID_VERSION = std::wstring(L"ELOSTDVER");

const ::std::wstring KeywordC::KWID_VERSION_COMMENT = std::wstring(L"ELOSTDCOM");

const ::std::wstring KeywordC::KWID_WORKFLOW = std::wstring(L"ELOSTDWFW");

const ::std::wstring KeywordC::KWID_USER_LIST = std::wstring(L"USERLIST");

const ::std::wstring KeywordC::PLACEHOLDER_DATE = std::wstring(L"%%D%");

const ::std::wstring KeywordC::PLACEHOLDER_YEAR = std::wstring(L"%%Y%");

const ::std::wstring KeywordC::PLACEHOLDER_MONTH = std::wstring(L"%%M%");

const ::std::wstring KeywordC::PLACEHOLDER_DAY = std::wstring(L"%%T%");

const ::std::wstring KeywordC::PLACEHOLDER_USER_NAME = std::wstring(L"%%E%");

const ::std::wstring KeywordC::PLACEHOLDER_COUNTER_BEGIN = std::wstring(L"%%C%");

const ::std::wstring KeywordC::PLACEHOLDER_COUNTER_END = std::wstring(L"%");

const PKeywordZ KeywordC::mbEdit = PKeywordZ(new KeywordZ(
	2LL));

const PKeywordZ KeywordC::mbView = PKeywordZ(new KeywordZ(
	4LL));

// checkpoint byps.gen.cpp.GenApiClass:489
KeywordC::KeywordC() {
	lnRootId = 0;
	lnId = 0;
	lnText = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeywordC::KeywordC(const ::std::wstring& KWID_STANDARD_LIST, const ::std::wstring& KWID_VERSION, const ::std::wstring& KWID_VERSION_COMMENT, const ::std::wstring& KWID_WORKFLOW, const ::std::wstring& KWID_USER_LIST, const ::std::wstring& PLACEHOLDER_DATE, const ::std::wstring& PLACEHOLDER_YEAR, const ::std::wstring& PLACEHOLDER_MONTH, const ::std::wstring& PLACEHOLDER_DAY, const ::std::wstring& PLACEHOLDER_USER_NAME, const ::std::wstring& PLACEHOLDER_COUNTER_BEGIN, const ::std::wstring& PLACEHOLDER_COUNTER_END, int64_t mbRawText, int64_t mbPreCookedText, const PKeywordZ& mbEdit, const PKeywordZ& mbView, int32_t MAX_CHILDREN, int32_t MAX_TREE_DEPTH, int32_t lnRootId, int32_t lnId, int32_t lnText)
	: lnRootId(lnRootId)
	, lnId(lnId)
	, lnText(lnText)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeywordC::BSerializable_getTypeId() {
	return 1338796818; 
}
void KeywordC::setLnRootId(int32_t v) {
	lnRootId = v;
}
void KeywordC::setLnId(int32_t v) {
	lnId = v;
}
void KeywordC::setLnText(int32_t v) {
	lnText = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeywordC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnId;
	ar & this->lnRootId;
	ar & this->lnText;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1338796818(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeywordC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeywordList
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeywordList::KeywordList() {
	deleted = false;
	userId = 0;
	lockId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeywordList::KeywordList(const ::std::wstring& id, const ::std::wstring& guid, const ::std::wstring& tStamp, bool deleted, int32_t userId, const ::std::wstring& userName, const PArrayKeyword& children, int32_t lockId, const ::std::wstring& TStampSync)
	: id(id)
	, guid(guid)
	, tStamp(tStamp)
	, deleted(deleted)
	, userId(userId)
	, userName(userName)
	, children(children)
	, lockId(lockId)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeywordList::BSerializable_getTypeId() {
	return 1495731174; 
}
void KeywordList::setId(::std::wstring v) {
	id = v;
	setChangedMember(KeywordListC::mbId);
}
void KeywordList::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(KeywordListC::mbGuid);
}
void KeywordList::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(KeywordListC::mbTStamp);
}
void KeywordList::setDeleted(bool v) {
	deleted = v;
}
void KeywordList::setUserId(int32_t v) {
	userId = v;
	setChangedMember(KeywordListC::mbUserId);
}
void KeywordList::setUserName(::std::wstring v) {
	userName = v;
}
void KeywordList::setChildren(PArrayKeyword v) {
	children = v;
}
void KeywordList::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(KeywordListC::mbLockId);
}
void KeywordList::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(KeywordListC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeywordList::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->deleted;
	ar & this->guid;
	ar & this->id;
	ar & this->tStamp;
	ar & this->userId;
	ar & this->userName;
	if (version >= 800000010000004) {
		ar & this->lockId;
		if (version >= 900990009000001) {
			ar & this->TStampSync;
		}
	}
	ar & this->children;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1495731174(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeywordList>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeywordListC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeywordListC::KeywordListC() {
	lnId = 0;
	lnGuid = 0;
	lnTStamp = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeywordListC::KeywordListC(int64_t mbStatus, int64_t mbId, int32_t lnId, int64_t mbGuid, int32_t lnGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbUserId, int64_t mbLockId, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnId(lnId)
	, lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeywordListC::BSerializable_getTypeId() {
	return 1333073168; 
}
void KeywordListC::setLnId(int32_t v) {
	lnId = v;
}
void KeywordListC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void KeywordListC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void KeywordListC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeywordListC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnGuid;
	ar & this->lnId;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1333073168(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeywordListC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeywordZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeywordZ::KeywordZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeywordZ::KeywordZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeywordZ::BSerializable_getTypeId() {
	return 450335637; 
}
void KeywordZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeywordZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_450335637(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeywordZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_206201524(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PKeyword > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeywordsDynamicInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeywordsDynamicInfo::KeywordsDynamicInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeywordsDynamicInfo::KeywordsDynamicInfo(const PSord& sord, const PDocMaskLine& maskLineFocus, const ::std::wstring& mapScriptName, const ::std::wstring& mapLineFocus, const byps::PMapStringString& mapData)
	: sord(sord)
	, maskLineFocus(maskLineFocus)
	, mapScriptName(mapScriptName)
	, mapLineFocus(mapLineFocus)
	, mapData(mapData)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeywordsDynamicInfo::BSerializable_getTypeId() {
	return 2008405893; 
}
void KeywordsDynamicInfo::setSord(PSord v) {
	sord = v;
}
void KeywordsDynamicInfo::setMaskLineFocus(PDocMaskLine v) {
	maskLineFocus = v;
}
void KeywordsDynamicInfo::setMapScriptName(::std::wstring v) {
	mapScriptName = v;
}
void KeywordsDynamicInfo::setMapLineFocus(::std::wstring v) {
	mapLineFocus = v;
}
void KeywordsDynamicInfo::setMapData(byps::PMapStringString v) {
	mapData = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeywordsDynamicInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 900000014000011) {
		ar & this->mapLineFocus;
		ar & this->mapScriptName;
	}
	ar & this->maskLineFocus;
	ar & this->sord;
	if (version >= 900000014000011) {
		ar & this->mapData;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2008405893(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeywordsDynamicInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class KeywordsDynamicResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
KeywordsDynamicResult::KeywordsDynamicResult() {
	moreResults = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::KeywordsDynamicResult::KeywordsDynamicResult(const byps_ptr< ::std::vector< byps::PVectorString > >& table, const byps::PVectorString& header, const byps::PVectorString& keyNames, const ::std::wstring& message, bool moreResults, const ::std::wstring& title, const byps_ptr< ::std::vector< byps::PMapStringString > >& columnProperties)
	: table(table)
	, header(header)
	, keyNames(keyNames)
	, message(message)
	, moreResults(moreResults)
	, title(title)
	, columnProperties(columnProperties)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::KeywordsDynamicResult::BSerializable_getTypeId() {
	return 1552114559; 
}
void KeywordsDynamicResult::setTable(byps_ptr< ::std::vector< byps::PVectorString > > v) {
	table = v;
}
void KeywordsDynamicResult::setHeader(byps::PVectorString v) {
	header = v;
}
void KeywordsDynamicResult::setKeyNames(byps::PVectorString v) {
	keyNames = v;
}
void KeywordsDynamicResult::setMessage(::std::wstring v) {
	message = v;
}
void KeywordsDynamicResult::setMoreResults(bool v) {
	moreResults = v;
}
void KeywordsDynamicResult::setTitle(::std::wstring v) {
	title = v;
}
void KeywordsDynamicResult::setColumnProperties(byps_ptr< ::std::vector< byps::PMapStringString > > v) {
	columnProperties = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void KeywordsDynamicResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->message;
	ar & this->moreResults;
	if (version >= 900000000000010) {
		ar & this->title;
	}
	ar & this->header;
	ar & this->keyNames;
	ar & this->table;
	if (version >= 900000016000018) {
		ar & this->columnProperties;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1552114559(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::KeywordsDynamicResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class License
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
License::License() {
	backup = false;
	cold = false;
	demoVersion = false;
	dispatchFolder = false;
	domea = false;
	emailOnly = false;
	fultext = false;
	httpServer = false;
	indexServer = false;
	limitedIg = false;
	limitedVersion = false;
	nbOfIgLicenses = 0;
	nbOfServerLicenses = 0;
	professional = false;
	replication = false;
	sapALink = false;
	signature = false;
	stack = false;
	tobid = false;
	xmlImport = false;
	nbOfFulltextLangs = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::License::License(bool backup, bool cold, bool demoVersion, bool dispatchFolder, bool domea, bool emailOnly, const PArrayInt& features, bool fultext, bool httpServer, bool indexServer, bool limitedIg, bool limitedVersion, int32_t nbOfIgLicenses, int32_t nbOfServerLicenses, bool professional, bool replication, bool sapALink, const ::std::wstring& serno, bool signature, bool stack, bool tobid, bool xmlImport, int32_t nbOfFulltextLangs)
	: backup(backup)
	, cold(cold)
	, demoVersion(demoVersion)
	, dispatchFolder(dispatchFolder)
	, domea(domea)
	, emailOnly(emailOnly)
	, features(features)
	, fultext(fultext)
	, httpServer(httpServer)
	, indexServer(indexServer)
	, limitedIg(limitedIg)
	, limitedVersion(limitedVersion)
	, nbOfIgLicenses(nbOfIgLicenses)
	, nbOfServerLicenses(nbOfServerLicenses)
	, professional(professional)
	, replication(replication)
	, sapALink(sapALink)
	, serno(serno)
	, signature(signature)
	, stack(stack)
	, tobid(tobid)
	, xmlImport(xmlImport)
	, nbOfFulltextLangs(nbOfFulltextLangs)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::License::BSerializable_getTypeId() {
	return 1330120264; 
}
void License::setBackup(bool v) {
	backup = v;
}
void License::setCold(bool v) {
	cold = v;
}
void License::setDemoVersion(bool v) {
	demoVersion = v;
}
void License::setDispatchFolder(bool v) {
	dispatchFolder = v;
}
void License::setDomea(bool v) {
	domea = v;
}
void License::setEmailOnly(bool v) {
	emailOnly = v;
}
void License::setFeatures(PArrayInt v) {
	features = v;
}
void License::setFultext(bool v) {
	fultext = v;
}
void License::setHttpServer(bool v) {
	httpServer = v;
}
void License::setIndexServer(bool v) {
	indexServer = v;
}
void License::setLimitedIg(bool v) {
	limitedIg = v;
}
void License::setLimitedVersion(bool v) {
	limitedVersion = v;
}
void License::setNbOfIgLicenses(int32_t v) {
	nbOfIgLicenses = v;
}
void License::setNbOfServerLicenses(int32_t v) {
	nbOfServerLicenses = v;
}
void License::setProfessional(bool v) {
	professional = v;
}
void License::setReplication(bool v) {
	replication = v;
}
void License::setSapALink(bool v) {
	sapALink = v;
}
void License::setSerno(::std::wstring v) {
	serno = v;
}
void License::setSignature(bool v) {
	signature = v;
}
void License::setStack(bool v) {
	stack = v;
}
void License::setTobid(bool v) {
	tobid = v;
}
void License::setXmlImport(bool v) {
	xmlImport = v;
}
void License::setNbOfFulltextLangs(int32_t v) {
	nbOfFulltextLangs = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void License::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->backup;
	ar & this->cold;
	ar & this->demoVersion;
	ar & this->dispatchFolder;
	ar & this->domea;
	ar & this->emailOnly;
	ar & this->fultext;
	ar & this->httpServer;
	ar & this->indexServer;
	ar & this->limitedIg;
	ar & this->limitedVersion;
	ar & this->nbOfIgLicenses;
	ar & this->nbOfServerLicenses;
	ar & this->professional;
	ar & this->replication;
	ar & this->sapALink;
	ar & this->serno;
	ar & this->signature;
	ar & this->stack;
	ar & this->tobid;
	ar & this->xmlImport;
	if (version >= 800000024000001) {
		ar & this->nbOfFulltextLangs;
	}
	ar & this->features;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1330120264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::License>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LicenseInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LicenseInfo::LicenseInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LicenseInfo::LicenseInfo(const ::std::wstring& customerName, const ::std::wstring& moduleName, const ::std::wstring& licenseKey)
	: customerName(customerName)
	, moduleName(moduleName)
	, licenseKey(licenseKey)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LicenseInfo::BSerializable_getTypeId() {
	return 2024296158; 
}
void LicenseInfo::setCustomerName(::std::wstring v) {
	customerName = v;
}
void LicenseInfo::setModuleName(::std::wstring v) {
	moduleName = v;
}
void LicenseInfo::setLicenseKey(::std::wstring v) {
	licenseKey = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LicenseInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->customerName;
	ar & this->licenseKey;
	ar & this->moduleName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2024296158(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LicenseInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LicenseResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LicenseResult::LicenseResult() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LicenseResult::BSerializable_getTypeId() {
	return 545905411; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LicenseResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_545905411(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LicenseResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LinkSordC
// Generated from class byps.gen.cpp.GenApiClass

const PLinkSordZ LinkSordC::PAIR = PLinkSordZ(new LinkSordZ(
	0LL));

const PLinkSordZ LinkSordC::CROSS_LINK = PLinkSordZ(new LinkSordZ(
	1LL));

// checkpoint byps.gen.cpp.GenApiClass:489
LinkSordC::LinkSordC() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LinkSordC::LinkSordC(const PLinkSordZ& NOTHING, const PLinkSordZ& PAIR, const PLinkSordZ& CROSS_LINK)
	: NOTHING(NOTHING)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LinkSordC::BSerializable_getTypeId() {
	return 4981037; 
}
void LinkSordC::setNOTHING(PLinkSordZ v) {
	NOTHING = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LinkSordC::serialize(BIO& ar, const BVERSION version) {
	ar & this->NOTHING;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_4981037(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LinkSordC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LinkSordInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LinkSordInfo::LinkSordInfo() {
	linkPermanent = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LinkSordInfo::LinkSordInfo(bool linkPermanent)
	: linkPermanent(linkPermanent)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LinkSordInfo::BSerializable_getTypeId() {
	return 1427691295; 
}
void LinkSordInfo::setLinkPermanent(bool v) {
	linkPermanent = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LinkSordInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->linkPermanent;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1427691295(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LinkSordInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LinkSordZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LinkSordZ::LinkSordZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LinkSordZ::LinkSordZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LinkSordZ::BSerializable_getTypeId() {
	return 1473512051; 
}
void LinkSordZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LinkSordZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1473512051(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LinkSordZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LockC
// Generated from class byps.gen.cpp.GenApiClass

const PLockZ LockC::NO = PLockZ(new LockZ(
	0LL));

const PLockZ LockC::YES = PLockZ(new LockZ(
	1LL));

const PLockZ LockC::FORCE = PLockZ(new LockZ(
	2LL));

const PLockZ LockC::IF_FREE = PLockZ(new LockZ(
	4LL));

const PLockZ LockC::SORD = PLockZ(new LockZ(
	8LL));

const PLockZ LockC::DOC = PLockZ(new LockZ(
	16LL));

// checkpoint byps.gen.cpp.GenApiClass:489
LockC::LockC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LockC::BSerializable_getTypeId() {
	return 837669511; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LockC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_837669511(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LockC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LockZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LockZ::LockZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LockZ::LockZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LockZ::BSerializable_getTypeId() {
	return 1407753312; 
}
void LockZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LockZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1407753312(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LockZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LoginResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LoginResult::LoginResult() {
	ticketLifetime = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LoginResult::LoginResult(const PClientInfo& clientInfo, int32_t ticketLifetime, const PUserInfo& user)
	: clientInfo(clientInfo)
	, ticketLifetime(ticketLifetime)
	, user(user)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LoginResult::BSerializable_getTypeId() {
	return 777531606; 
}
void LoginResult::setClientInfo(PClientInfo v) {
	clientInfo = v;
}
void LoginResult::setTicketLifetime(int32_t v) {
	ticketLifetime = v;
}
void LoginResult::setUser(PUserInfo v) {
	user = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LoginResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->ticketLifetime;
	ar & this->clientInfo;
	ar & this->user;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_777531606(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LoginResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LoginScriptOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LoginScriptOptions::LoginScriptOptions() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::LoginScriptOptions::LoginScriptOptions(const ::std::wstring& clientName, const ::std::wstring& techUser)
	: clientName(clientName)
	, techUser(techUser)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LoginScriptOptions::BSerializable_getTypeId() {
	return 1536364115; 
}
void LoginScriptOptions::setClientName(::std::wstring v) {
	clientName = v;
}
void LoginScriptOptions::setTechUser(::std::wstring v) {
	techUser = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LoginScriptOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->clientName;
	if (version >= 1000170059000004) {
		ar & this->techUser;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1536364115(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LoginScriptOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class LoginScriptOptionsC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_FULLCLIENT = std::wstring(L"FullClient");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_WEBCLIENT = std::wstring(L"WebClient");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_ELOAPP = std::wstring(L"EloApp");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_PARTNERAPP = std::wstring(L"PartnerApp");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_DMS_DESKTOP = std::wstring(L"DMSDesktop");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_MOBILE_CLIENT = std::wstring(L"Mobilclient");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_WINDOWS_CLIENT = std::wstring(L"WindowsClient");

const ::std::wstring LoginScriptOptionsC::CLIENT_NAME_UNKNOWN = std::wstring(L"Unknown");

// checkpoint byps.gen.cpp.GenApiClass:489
LoginScriptOptionsC::LoginScriptOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::LoginScriptOptionsC::BSerializable_getTypeId() {
	return 1002222217; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LoginScriptOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1002222217(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::LoginScriptOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapData::MapData() {
	objId = 0;
	lockId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapData::MapData(const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, int32_t lockId, const ::std::wstring& lockName, const ::std::wstring& TStamp, const PArrayKeyValue& items, const ::std::wstring& guid, const PMapStringMapValue& mapItems)
	: domainName(domainName)
	, id(id)
	, objId(objId)
	, lockId(lockId)
	, lockName(lockName)
	, TStamp(TStamp)
	, items(items)
	, guid(guid)
	, mapItems(mapItems)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapData::BSerializable_getTypeId() {
	return 2011132580; 
}
void MapData::setDomainName(::std::wstring v) {
	domainName = v;
}
void MapData::setId(::std::wstring v) {
	id = v;
}
void MapData::setObjId(int32_t v) {
	objId = v;
}
void MapData::setLockId(int32_t v) {
	lockId = v;
}
void MapData::setLockName(::std::wstring v) {
	lockName = v;
}
void MapData::setTStamp(::std::wstring v) {
	TStamp = v;
}
void MapData::setItems(PArrayKeyValue v) {
	items = v;
}
void MapData::setGuid(::std::wstring v) {
	guid = v;
}
void MapData::setMapItems(PMapStringMapValue v) {
	mapItems = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->domainName;
	ar & this->id;
	ar & this->lockId;
	ar & this->lockName;
	ar & this->objId;
	if (version >= 800000024000002) {
		ar & this->guid;
	}
	ar & this->items;
	if (version >= 1000000020000007) {
		ar & this->mapItems;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2011132580(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapData>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapDataC::MapDataC() {
	lnValue = 0;
	lnKey = 0;
	lnId = 0;
	lnBlob = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapDataC::MapDataC(int32_t lnValue, int32_t lnKey, int32_t lnId, int32_t lnBlob)
	: lnValue(lnValue)
	, lnKey(lnKey)
	, lnId(lnId)
	, lnBlob(lnBlob)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapDataC::BSerializable_getTypeId() {
	return 1277095765; 
}
void MapDataC::setLnValue(int32_t v) {
	lnValue = v;
}
void MapDataC::setLnKey(int32_t v) {
	lnKey = v;
}
void MapDataC::setLnId(int32_t v) {
	lnId = v;
}
void MapDataC::setLnBlob(int32_t v) {
	lnBlob = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnId;
	ar & this->lnKey;
	ar & this->lnValue;
	if (version >= 1000000020000007) {
		ar & this->lnBlob;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1277095765(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapDomain
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapDomain::MapDomain() {
	copy = false;
	replicate = false;
	history = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapDomain::MapDomain(const ::std::wstring& name, bool copy, bool replicate, bool history)
	: name(name)
	, copy(copy)
	, replicate(replicate)
	, history(history)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapDomain::BSerializable_getTypeId() {
	return 42339713; 
}
void MapDomain::setName(::std::wstring v) {
	name = v;
	setChangedMember(MapDomainC::mbName);
}
void MapDomain::setCopy(bool v) {
	copy = v;
}
void MapDomain::setReplicate(bool v) {
	replicate = v;
}
void MapDomain::setHistory(bool v) {
	history = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapDomain::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->copy;
	ar & this->name;
	ar & this->replicate;
	if (version >= 800000024000002) {
		ar & this->history;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_42339713(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapDomain>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapDomainDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapDomainDataC::MapDomainDataC() {
	lnName = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapDomainDataC::MapDomainDataC(int64_t mbFlags, int64_t mbName, int32_t lnName, int64_t mbAllMembers)
	: lnName(lnName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapDomainDataC::BSerializable_getTypeId() {
	return 915355095; 
}
void MapDomainDataC::setLnName(int32_t v) {
	lnName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapDomainDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_915355095(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapDomainDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapDomainC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring MapDomainC::DOMAIN_SORD = std::wstring(L"objekte");

const ::std::wstring MapDomainC::DOMAIN_WORKFLOW_ACTIVE = std::wstring(L"wfactive");

const ::std::wstring MapDomainC::DOMAIN_WORKFLOW_FINISHED = std::wstring(L"wffinished");

const ::std::wstring MapDomainC::DOMAIN_IX_OPTIONS = std::wstring(L"eloixopt");

const ::std::wstring MapDomainC::DOMAIN_DM_OPTIONS = std::wstring(L"elodmopt");

const ::std::wstring MapDomainC::DOMAIN_FT_OPTIONS = std::wstring(L"eloftopt");

// checkpoint byps.gen.cpp.GenApiClass:489
MapDomainC::MapDomainC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapDomainC::BSerializable_getTypeId() {
	return 47433043; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapDomainC::serialize(BIO& ar, const BVERSION version) {
	MapDomainDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_47433043(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapDomainC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1963952629(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PMapDomain > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHead
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHead::MapHead() {
	lockId = 0;
	objId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHead::MapHead(const ::std::wstring& id, int32_t lockId, int32_t objId, const ::std::wstring& TStamp, const ::std::wstring& guid)
	: id(id)
	, lockId(lockId)
	, objId(objId)
	, TStamp(TStamp)
	, guid(guid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHead::BSerializable_getTypeId() {
	return 1379783697; 
}
void MapHead::setId(::std::wstring v) {
	id = v;
	setChangedMember(MapHeadC::mbId);
}
void MapHead::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(MapHeadC::mbLockId);
}
void MapHead::setObjId(int32_t v) {
	objId = v;
	setChangedMember(MapHeadC::mbObjId);
}
void MapHead::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(MapHeadC::mbTStamp);
}
void MapHead::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(MapHeadC::mbGuid);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHead::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->id;
	ar & this->lockId;
	ar & this->objId;
	if (version >= 700000040000013) {
		ar & this->guid;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1379783697(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHead>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHeadC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHeadC::MapHeadC() {
	lnId = 0;
	lnTStamp = 0;
	lnGuid = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHeadC::MapHeadC(int64_t mbId, int32_t lnId, int64_t mbLockId, int64_t mbObjId, int64_t mbTStamp, int32_t lnTStamp, int64_t mbGuid, int32_t lnGuid, int64_t mbAllMembers)
	: lnId(lnId)
	, lnTStamp(lnTStamp)
	, lnGuid(lnGuid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHeadC::BSerializable_getTypeId() {
	return 812078539; 
}
void MapHeadC::setLnId(int32_t v) {
	lnId = v;
}
void MapHeadC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void MapHeadC::setLnGuid(int32_t v) {
	lnGuid = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHeadC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnGuid;
	ar & this->lnId;
	ar & this->lnTStamp;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_812078539(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHeadC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHist
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHist::MapHist() {
	histSource = 0;
	userId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHist::MapHist(const ::std::wstring& histGuid, int32_t histSource, const ::std::wstring& mapGuid, const ::std::wstring& timeStampLocal, const ::std::wstring& timeStampUTC, const ::std::wstring& userName, int32_t userId, const ::std::wstring& workStation, const PArrayMapHistItem& histItems, const ::std::wstring& mapId)
	: histGuid(histGuid)
	, histSource(histSource)
	, mapGuid(mapGuid)
	, timeStampLocal(timeStampLocal)
	, timeStampUTC(timeStampUTC)
	, userName(userName)
	, userId(userId)
	, workStation(workStation)
	, histItems(histItems)
	, mapId(mapId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHist::BSerializable_getTypeId() {
	return 303505086; 
}
void MapHist::setHistGuid(::std::wstring v) {
	histGuid = v;
	setChangedMember(MapHistC::mbHistGuid);
}
void MapHist::setHistSource(int32_t v) {
	histSource = v;
	setChangedMember(MapHistC::mbHistSource);
}
void MapHist::setMapGuid(::std::wstring v) {
	mapGuid = v;
	setChangedMember(MapHistC::mbMapGuid);
}
void MapHist::setTimeStampLocal(::std::wstring v) {
	timeStampLocal = v;
	setChangedMember(MapHistC::mbTimeStampLocal);
}
void MapHist::setTimeStampUTC(::std::wstring v) {
	timeStampUTC = v;
	setChangedMember(MapHistC::mbTimeStampUTC);
}
void MapHist::setUserName(::std::wstring v) {
	userName = v;
	setChangedMember(MapHistC::mbUserName);
}
void MapHist::setUserId(int32_t v) {
	userId = v;
	setChangedMember(MapHistC::mbUserId);
}
void MapHist::setWorkStation(::std::wstring v) {
	workStation = v;
	setChangedMember(MapHistC::mbWorkStation);
}
void MapHist::setHistItems(PArrayMapHistItem v) {
	histItems = v;
	setChangedMember(MapHistC::mbHistItems);
}
void MapHist::setMapId(::std::wstring v) {
	mapId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHist::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->histGuid;
	ar & this->histSource;
	ar & this->mapGuid;
	ar & this->mapId;
	ar & this->timeStampLocal;
	ar & this->timeStampUTC;
	ar & this->userId;
	ar & this->userName;
	ar & this->workStation;
	ar & this->histItems;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_303505086(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHist>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHistHeadC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHistHeadC::MapHistHeadC() {
	lnHistGuid = 0;
	lnTimeStampUTC = 0;
	lnMapGuid = 0;
	lnUserName = 0;
	lnTimeStampLocal = 0;
	lnWorkStation = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHistHeadC::MapHistHeadC(int64_t mbHistGuid, int32_t lnHistGuid, int64_t mbTimeStampUTC, int32_t lnTimeStampUTC, int64_t mbMapGuid, int32_t lnMapGuid, int64_t mbUserId, int64_t mbUserName, int32_t lnUserName, int64_t mbHistSource, int64_t mbTimeStampLocal, int32_t lnTimeStampLocal, int64_t mbWorkStation, int32_t lnWorkStation, int64_t mbAllMembers)
	: lnHistGuid(lnHistGuid)
	, lnTimeStampUTC(lnTimeStampUTC)
	, lnMapGuid(lnMapGuid)
	, lnUserName(lnUserName)
	, lnTimeStampLocal(lnTimeStampLocal)
	, lnWorkStation(lnWorkStation)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHistHeadC::BSerializable_getTypeId() {
	return 812099209; 
}
void MapHistHeadC::setLnHistGuid(int32_t v) {
	lnHistGuid = v;
}
void MapHistHeadC::setLnTimeStampUTC(int32_t v) {
	lnTimeStampUTC = v;
}
void MapHistHeadC::setLnMapGuid(int32_t v) {
	lnMapGuid = v;
}
void MapHistHeadC::setLnUserName(int32_t v) {
	lnUserName = v;
}
void MapHistHeadC::setLnTimeStampLocal(int32_t v) {
	lnTimeStampLocal = v;
}
void MapHistHeadC::setLnWorkStation(int32_t v) {
	lnWorkStation = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHistHeadC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnHistGuid;
	ar & this->lnMapGuid;
	ar & this->lnTimeStampLocal;
	ar & this->lnTimeStampUTC;
	ar & this->lnUserName;
	ar & this->lnWorkStation;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_812099209(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHistHeadC>(bio, pObj, pObjS, pBase);	
}
}}}}

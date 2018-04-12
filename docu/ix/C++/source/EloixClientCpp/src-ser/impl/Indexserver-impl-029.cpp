#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class StoreInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
StoreInfo::StoreInfo() {
	flags = 0;
	id = 0;
	scatter = 0;
	stdPath = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::StoreInfo::StoreInfo(const ::std::wstring& createDateISO, const ::std::wstring& dir, int32_t flags, int32_t id, const ::std::wstring& name, int32_t scatter, bool stdPath, const ::std::wstring& updateDateISO, const ::std::wstring& previewDir, const ::std::wstring& fulltextDir)
	: createDateISO(createDateISO)
	, dir(dir)
	, flags(flags)
	, id(id)
	, name(name)
	, scatter(scatter)
	, stdPath(stdPath)
	, updateDateISO(updateDateISO)
	, previewDir(previewDir)
	, fulltextDir(fulltextDir)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::StoreInfo::BSerializable_getTypeId() {
	return 964052256; 
}
void StoreInfo::setCreateDateISO(::std::wstring v) {
	createDateISO = v;
}
void StoreInfo::setDir(::std::wstring v) {
	dir = v;
}
void StoreInfo::setFlags(int32_t v) {
	flags = v;
}
void StoreInfo::setId(int32_t v) {
	id = v;
}
void StoreInfo::setName(::std::wstring v) {
	name = v;
}
void StoreInfo::setScatter(int32_t v) {
	scatter = v;
}
void StoreInfo::setStdPath(bool v) {
	stdPath = v;
}
void StoreInfo::setUpdateDateISO(::std::wstring v) {
	updateDateISO = v;
}
void StoreInfo::setPreviewDir(::std::wstring v) {
	previewDir = v;
}
void StoreInfo::setFulltextDir(::std::wstring v) {
	fulltextDir = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void StoreInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->createDateISO;
	ar & this->dir;
	ar & this->flags;
	ar & this->id;
	ar & this->name;
	ar & this->scatter;
	ar & this->stdPath;
	ar & this->updateDateISO;
	if (version >= 800000010000001) {
		ar & this->fulltextDir;
		ar & this->previewDir;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_964052256(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::StoreInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class StoreInfoC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring StoreInfoC::DMPATH_ELOSYS = std::wstring(L"elosys");

// checkpoint byps.gen.cpp.GenApiClass:489
StoreInfoC::StoreInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::StoreInfoC::BSerializable_getTypeId() {
	return 979653235; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void StoreInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_979653235(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::StoreInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_231031238(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PStoreInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SubsInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SubsInfo::SubsInfo() {
	active = false;
	inheritRights = false;
	subsId = 0;
	userId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SubsInfo::SubsInfo(bool active, bool inheritRights, int32_t subsId, const ::std::wstring& subsName, int32_t userId, const ::std::wstring& userName)
	: active(active)
	, inheritRights(inheritRights)
	, subsId(subsId)
	, subsName(subsName)
	, userId(userId)
	, userName(userName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SubsInfo::BSerializable_getTypeId() {
	return 1910142939; 
}
void SubsInfo::setActive(bool v) {
	active = v;
}
void SubsInfo::setInheritRights(bool v) {
	inheritRights = v;
}
void SubsInfo::setSubsId(int32_t v) {
	subsId = v;
}
void SubsInfo::setSubsName(::std::wstring v) {
	subsName = v;
}
void SubsInfo::setUserId(int32_t v) {
	userId = v;
}
void SubsInfo::setUserName(::std::wstring v) {
	userName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SubsInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->active;
	ar & this->inheritRights;
	ar & this->subsId;
	ar & this->subsName;
	ar & this->userId;
	ar & this->userName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1910142939(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SubsInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_105830886(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSubsInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Subscription
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Subscription::Subscription() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Subscription::Subscription(const ::std::wstring& userGuid, const ::std::wstring& watchGuid, const ::std::wstring& createDateIso)
	: userGuid(userGuid)
	, watchGuid(watchGuid)
	, createDateIso(createDateIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Subscription::BSerializable_getTypeId() {
	return 323351719; 
}
void Subscription::setUserGuid(::std::wstring v) {
	userGuid = v;
	setChangedMember(SubscriptionC::mbUserGuid);
}
void Subscription::setWatchGuid(::std::wstring v) {
	watchGuid = v;
	setChangedMember(SubscriptionC::mbWatchGuid);
}
void Subscription::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(SubscriptionC::mbCreateDateIso);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Subscription::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->createDateIso;
	ar & this->userGuid;
	ar & this->watchGuid;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_323351719(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Subscription>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SubscriptionDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SubscriptionDataC::SubscriptionDataC() {
	lnUserGuid = 0;
	lnWatchGuid = 0;
	lnCreateDateIso = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SubscriptionDataC::SubscriptionDataC(int64_t mbUserGuid, int32_t lnUserGuid, int64_t mbWatchGuid, int32_t lnWatchGuid, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbAllMembers)
	: lnUserGuid(lnUserGuid)
	, lnWatchGuid(lnWatchGuid)
	, lnCreateDateIso(lnCreateDateIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SubscriptionDataC::BSerializable_getTypeId() {
	return 1152087606; 
}
void SubscriptionDataC::setLnUserGuid(int32_t v) {
	lnUserGuid = v;
}
void SubscriptionDataC::setLnWatchGuid(int32_t v) {
	lnWatchGuid = v;
}
void SubscriptionDataC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SubscriptionDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCreateDateIso;
	ar & this->lnUserGuid;
	ar & this->lnWatchGuid;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1152087606(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SubscriptionDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SubscriptionC
// Generated from class byps.gen.cpp.GenApiClass

const PSubscriptionZ SubscriptionC::mbAll = PSubscriptionZ(new SubscriptionZ(
	7LL));

// checkpoint byps.gen.cpp.GenApiClass:489
SubscriptionC::SubscriptionC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SubscriptionC::BSerializable_getTypeId() {
	return 1994646365; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SubscriptionC::serialize(BIO& ar, const BVERSION version) {
	SubscriptionDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1994646365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SubscriptionC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SubscriptionZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SubscriptionZ::SubscriptionZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SubscriptionZ::SubscriptionZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SubscriptionZ::BSerializable_getTypeId() {
	return 1493215896; 
}
void SubscriptionZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SubscriptionZ::serialize(BIO& ar, const BVERSION version) {
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1493215896(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SubscriptionZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Thesaurus
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Thesaurus::Thesaurus() {
	groupId = 0;
	prio = 0;
	listId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Thesaurus::Thesaurus(int32_t groupId, int32_t prio, const ::std::wstring& data, const ::std::wstring& compare, int32_t listId)
	: groupId(groupId)
	, prio(prio)
	, data(data)
	, compare(compare)
	, listId(listId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Thesaurus::BSerializable_getTypeId() {
	return 1664944753; 
}
void Thesaurus::setGroupId(int32_t v) {
	groupId = v;
	setChangedMember(ThesaurusC::mbGroupId);
}
void Thesaurus::setPrio(int32_t v) {
	prio = v;
	setChangedMember(ThesaurusC::mbPrio);
}
void Thesaurus::setData(::std::wstring v) {
	data = v;
	setChangedMember(ThesaurusC::mbData);
}
void Thesaurus::setCompare(::std::wstring v) {
	compare = v;
	setChangedMember(ThesaurusC::mbCompare);
}
void Thesaurus::setListId(int32_t v) {
	listId = v;
	setChangedMember(ThesaurusC::mbListId);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Thesaurus::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->compare;
	ar & this->data;
	ar & this->groupId;
	ar & this->listId;
	ar & this->prio;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1664944753(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Thesaurus>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ThesaurusC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ThesaurusC::ThesaurusC() {
	lnData = 0;
	lnCompare = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ThesaurusC::ThesaurusC(int64_t mbGroupId, int64_t mbPrio, int64_t mbData, int32_t lnData, int64_t mbCompare, int32_t lnCompare, int64_t mbListId, int64_t mbAllMembers)
	: lnData(lnData)
	, lnCompare(lnCompare)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ThesaurusC::BSerializable_getTypeId() {
	return 670698541; 
}
void ThesaurusC::setLnData(int32_t v) {
	lnData = v;
}
void ThesaurusC::setLnCompare(int32_t v) {
	lnCompare = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ThesaurusC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCompare;
	ar & this->lnData;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_670698541(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ThesaurusC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class TranslateTerm
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
TranslateTerm::TranslateTerm() {
	deleted = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::TranslateTerm::TranslateTerm(const ::std::wstring& guid, bool deleted, const ::std::wstring& tStamp, const PArrayString& termLangs, const PArrayString& langs, const ::std::wstring& tStampSync, const ::std::wstring& translationKey)
	: guid(guid)
	, deleted(deleted)
	, tStamp(tStamp)
	, termLangs(termLangs)
	, langs(langs)
	, tStampSync(tStampSync)
	, translationKey(translationKey)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::TranslateTerm::BSerializable_getTypeId() {
	return 356302605; 
}
void TranslateTerm::setGuid(::std::wstring v) {
	guid = v;
}
void TranslateTerm::setDeleted(bool v) {
	deleted = v;
}
void TranslateTerm::setTStamp(::std::wstring v) {
	tStamp = v;
}
void TranslateTerm::setTermLangs(PArrayString v) {
	termLangs = v;
}
void TranslateTerm::setLangs(PArrayString v) {
	langs = v;
}
void TranslateTerm::setTStampSync(::std::wstring v) {
	tStampSync = v;
}
void TranslateTerm::setTranslationKey(::std::wstring v) {
	translationKey = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void TranslateTerm::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->deleted;
	ar & this->guid;
	ar & this->tStamp;
	if (version >= 900000018000008) {
		ar & this->translationKey;
		if (version >= 900990009000001) {
			ar & this->tStampSync;
		}
	}
	ar & this->langs;
	ar & this->termLangs;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_356302605(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::TranslateTerm>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class TranslateTermC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring TranslateTermC::GUID_SYSTEM_LANGUAGES = std::wstring(L"SYSTEM_LANGUAGES");

const PArrayString TranslateTermC::TASKIDS_FOR_SYSTEM_LANGUAGES = PArrayString((new ::byps::BArray1< ::std::wstring > (1))
	->set(0, std::wstring(L"SYSTEM_LANGUAGES"))
);

// checkpoint byps.gen.cpp.GenApiClass:489
TranslateTermC::TranslateTermC() {
	lnTermLang = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::TranslateTermC::TranslateTermC(const ::std::wstring& GUID_SYSTEM_LANGUAGES, const PArrayString& TASKIDS_FOR_SYSTEM_LANGUAGES, int32_t lnTermLang)
	: lnTermLang(lnTermLang)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::TranslateTermC::BSerializable_getTypeId() {
	return 1212336284; 
}
void TranslateTermC::setLnTermLang(int32_t v) {
	lnTermLang = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void TranslateTermC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnTermLang;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1212336284(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::TranslateTermC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class TranslateTermData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
TranslateTermData::TranslateTermData() {
	status = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::TranslateTermData::TranslateTermData(const ::std::wstring& guid, const ::std::wstring& TStamp, int32_t status, const ::std::wstring& lang1, const ::std::wstring& lang2, const ::std::wstring& lang3, const ::std::wstring& lang4, const ::std::wstring& lang5, const ::std::wstring& lang6, const ::std::wstring& lang7, const ::std::wstring& lang8, const ::std::wstring& lang9, const ::std::wstring& TStampSync)
	: guid(guid)
	, TStamp(TStamp)
	, status(status)
	, lang1(lang1)
	, lang2(lang2)
	, lang3(lang3)
	, lang4(lang4)
	, lang5(lang5)
	, lang6(lang6)
	, lang7(lang7)
	, lang8(lang8)
	, lang9(lang9)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::TranslateTermData::BSerializable_getTypeId() {
	return 486835904; 
}
void TranslateTermData::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(TranslateTermDataC::mbGuid);
}
void TranslateTermData::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(TranslateTermDataC::mbTStamp);
}
void TranslateTermData::setStatus(int32_t v) {
	status = v;
	setChangedMember(TranslateTermDataC::mbStatus);
}
void TranslateTermData::setLang1(::std::wstring v) {
	lang1 = v;
	setChangedMember(TranslateTermDataC::mbLang1);
}
void TranslateTermData::setLang2(::std::wstring v) {
	lang2 = v;
	setChangedMember(TranslateTermDataC::mbLang2);
}
void TranslateTermData::setLang3(::std::wstring v) {
	lang3 = v;
	setChangedMember(TranslateTermDataC::mbLang3);
}
void TranslateTermData::setLang4(::std::wstring v) {
	lang4 = v;
	setChangedMember(TranslateTermDataC::mbLang4);
}
void TranslateTermData::setLang5(::std::wstring v) {
	lang5 = v;
	setChangedMember(TranslateTermDataC::mbLang5);
}
void TranslateTermData::setLang6(::std::wstring v) {
	lang6 = v;
	setChangedMember(TranslateTermDataC::mbLang6);
}
void TranslateTermData::setLang7(::std::wstring v) {
	lang7 = v;
	setChangedMember(TranslateTermDataC::mbLang7);
}
void TranslateTermData::setLang8(::std::wstring v) {
	lang8 = v;
	setChangedMember(TranslateTermDataC::mbLang8);
}
void TranslateTermData::setLang9(::std::wstring v) {
	lang9 = v;
	setChangedMember(TranslateTermDataC::mbLang9);
}
void TranslateTermData::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(TranslateTermDataC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void TranslateTermData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->guid;
	ar & this->lang1;
	ar & this->lang2;
	ar & this->lang3;
	ar & this->lang4;
	ar & this->lang5;
	ar & this->lang6;
	ar & this->lang7;
	ar & this->lang8;
	ar & this->lang9;
	ar & this->status;
	if (version >= 900990009000001) {
		ar & this->TStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_486835904(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::TranslateTermData>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class TranslateTermDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
TranslateTermDataC::TranslateTermDataC() {
	lnGuid = 0;
	lnTStamp = 0;
	lnLang1 = 0;
	lnLang2 = 0;
	lnLang3 = 0;
	lnLang4 = 0;
	lnLang5 = 0;
	lnLang6 = 0;
	lnLang7 = 0;
	lnLang8 = 0;
	lnLang9 = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::TranslateTermDataC::TranslateTermDataC(int64_t mbGuid, int32_t lnGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbStatus, int64_t mbLang1, int32_t lnLang1, int64_t mbLang2, int32_t lnLang2, int64_t mbLang3, int32_t lnLang3, int64_t mbLang4, int32_t lnLang4, int64_t mbLang5, int32_t lnLang5, int64_t mbLang6, int32_t lnLang6, int64_t mbLang7, int32_t lnLang7, int64_t mbLang8, int32_t lnLang8, int64_t mbLang9, int32_t lnLang9, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnLang1(lnLang1)
	, lnLang2(lnLang2)
	, lnLang3(lnLang3)
	, lnLang4(lnLang4)
	, lnLang5(lnLang5)
	, lnLang6(lnLang6)
	, lnLang7(lnLang7)
	, lnLang8(lnLang8)
	, lnLang9(lnLang9)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::TranslateTermDataC::BSerializable_getTypeId() {
	return 1699470707; 
}
void TranslateTermDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void TranslateTermDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void TranslateTermDataC::setLnLang1(int32_t v) {
	lnLang1 = v;
}
void TranslateTermDataC::setLnLang2(int32_t v) {
	lnLang2 = v;
}
void TranslateTermDataC::setLnLang3(int32_t v) {
	lnLang3 = v;
}
void TranslateTermDataC::setLnLang4(int32_t v) {
	lnLang4 = v;
}
void TranslateTermDataC::setLnLang5(int32_t v) {
	lnLang5 = v;
}
void TranslateTermDataC::setLnLang6(int32_t v) {
	lnLang6 = v;
}
void TranslateTermDataC::setLnLang7(int32_t v) {
	lnLang7 = v;
}
void TranslateTermDataC::setLnLang8(int32_t v) {
	lnLang8 = v;
}
void TranslateTermDataC::setLnLang9(int32_t v) {
	lnLang9 = v;
}
void TranslateTermDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void TranslateTermDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnGuid;
	ar & this->lnLang1;
	ar & this->lnLang2;
	ar & this->lnLang3;
	ar & this->lnLang4;
	ar & this->lnLang5;
	ar & this->lnLang6;
	ar & this->lnLang7;
	ar & this->lnLang8;
	ar & this->lnLang9;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1699470707(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::TranslateTermDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1088095067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PTranslateTerm > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UrlParams
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UrlParams::UrlParams() {
	length = 0;
	offset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UrlParams::UrlParams(int64_t length, int64_t offset, const ::std::wstring& highlightTerms)
	: length(length)
	, offset(offset)
	, highlightTerms(highlightTerms)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UrlParams::BSerializable_getTypeId() {
	return 2007960901; 
}
void UrlParams::setLength(int64_t v) {
	length = v;
}
void UrlParams::setOffset(int64_t v) {
	offset = v;
}
void UrlParams::setHighlightTerms(::std::wstring v) {
	highlightTerms = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UrlParams::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->highlightTerms;
	ar & this->length;
	ar & this->offset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2007960901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UrlParams>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserInfo::UserInfo() {
	flags = 0;
	id = 0;
	parent = 0;
	type = 0;
	superiorId = 0;
	flags2 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserInfo::UserInfo(const ::std::wstring& desc, int32_t flags, const PArrayInt& groupList, int32_t id, const PArrayInt& keylist, const ::std::wstring& name, int32_t parent, const ::std::wstring& pwd, const PArraySessionInfo& sessions, int32_t type, const PArrayString& userProps, const byps::PMapStringString& ldapProperties, const ::std::wstring& guid, const ::std::wstring& tStamp, const ::std::wstring& lastLoginIso, int32_t superiorId, int32_t flags2, const PArrayInt& orgUnitIds)
	: desc(desc)
	, flags(flags)
	, groupList(groupList)
	, id(id)
	, keylist(keylist)
	, name(name)
	, parent(parent)
	, pwd(pwd)
	, sessions(sessions)
	, type(type)
	, userProps(userProps)
	, ldapProperties(ldapProperties)
	, guid(guid)
	, tStamp(tStamp)
	, lastLoginIso(lastLoginIso)
	, superiorId(superiorId)
	, flags2(flags2)
	, orgUnitIds(orgUnitIds)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserInfo::BSerializable_getTypeId() {
	return 1485735592; 
}
void UserInfo::setDesc(::std::wstring v) {
	desc = v;
}
void UserInfo::setFlags(int32_t v) {
	flags = v;
}
void UserInfo::setGroupList(PArrayInt v) {
	groupList = v;
}
void UserInfo::setId(int32_t v) {
	id = v;
}
void UserInfo::setKeylist(PArrayInt v) {
	keylist = v;
}
void UserInfo::setName(::std::wstring v) {
	name = v;
}
void UserInfo::setParent(int32_t v) {
	parent = v;
}
void UserInfo::setPwd(::std::wstring v) {
	pwd = v;
}
void UserInfo::setSessions(PArraySessionInfo v) {
	sessions = v;
}
void UserInfo::setType(int32_t v) {
	type = v;
}
void UserInfo::setUserProps(PArrayString v) {
	userProps = v;
}
void UserInfo::setLdapProperties(byps::PMapStringString v) {
	ldapProperties = v;
}
void UserInfo::setGuid(::std::wstring v) {
	guid = v;
}
void UserInfo::setTStamp(::std::wstring v) {
	tStamp = v;
}
void UserInfo::setLastLoginIso(::std::wstring v) {
	lastLoginIso = v;
}
void UserInfo::setSuperiorId(int32_t v) {
	superiorId = v;
}
void UserInfo::setFlags2(int32_t v) {
	flags2 = v;
}
void UserInfo::setOrgUnitIds(PArrayInt v) {
	orgUnitIds = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->desc;
	ar & this->flags;
	ar & this->id;
	ar & this->name;
	ar & this->parent;
	ar & this->pwd;
	ar & this->type;
	if (version >= 700000000000012) {
		ar & this->guid;
		if (version >= 700000000000013) {
			ar & this->tStamp;
			if (version >= 700000040000011) {
				ar & this->lastLoginIso;
				if (version >= 700000040000017) {
					ar & this->flags2;
					ar & this->superiorId;
				}
			}
		}
	}
	ar & this->groupList;
	ar & this->keylist;
	ar & this->sessions;
	ar & this->userProps;
	if (version >= 900000000000009) {
		ar & this->orgUnitIds;
		if (version >= 900000040000005) {
			ar & this->ldapProperties;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1485735592(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserInfoC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring UserInfoC::PROP_ACTION_USER_SHOULD_CHANGE_PASSWORD = std::wstring(L"PW");

const ::std::wstring UserInfoC::PROP_ACTION_USER_MUST_CHANGE_PASSWORD = std::wstring(L"PWf");

const ::std::wstring UserInfoC::PROP_ACTION_END_PASSWORD_DATE = std::wstring(L"EX");

const ::std::wstring UserInfoC::PWD_VALUE_IGNORE = std::wstring(L"(1E6ADC03-1A05-4df0-B627-3DAE0F6DA133)_ignorepwd");

const ::std::wstring UserInfoC::LDAP_PROP_CN = std::wstring(L"cn");

const ::std::wstring UserInfoC::LDAP_PROP_DISTINGUISHED_NAME = std::wstring(L"distinguishedName");

const ::std::wstring UserInfoC::LDAP_PROP_DISPLAY_NAME = std::wstring(L"displayName");

const ::std::wstring UserInfoC::LDAP_PROP_NAME = std::wstring(L"name");

const ::std::wstring UserInfoC::LDAP_PROP_PROXY_ADDRESSES = std::wstring(L"proxyAddresses");

const ::std::wstring UserInfoC::LDAP_PROP_USER_ACCOUNT_CONTROL = std::wstring(L"userAccountControl");

const ::std::wstring UserInfoC::LDAP_PROP_SAM_ACCOUNT_NAME = std::wstring(L"sAMAccountName");

const ::std::wstring UserInfoC::LDAP_PROP_SAM_ACCOUNT_TYPE = std::wstring(L"sAMAccountType");

const ::std::wstring UserInfoC::LDAP_PROP_USER_PRINCIPAL_NAME = std::wstring(L"userPrincipalName");

const ::std::wstring UserInfoC::LDAP_PROP_OBJECT_CATEGORY = std::wstring(L"objectCategory");

const ::std::wstring UserInfoC::LDAP_PROP_MAIL_NICK_NAME = std::wstring(L"mailNickname");

const ::std::wstring UserInfoC::LDAP_PROP_OBJECT_GUID = std::wstring(L"objectGUID");

const ::std::wstring UserInfoC::LDAP_PROP_OBJECT_SID = std::wstring(L"objectSid");

const ::std::wstring UserInfoC::LDAP_PROP_MS_EXCHANGE_MAILBOX_GUID = std::wstring(L"msExchMailboxGuid");

const ::std::wstring UserInfoC::LDAP_PROP_GROUP_TYPE = std::wstring(L"groupType");

const ::std::wstring UserInfoC::LDAP_PROP_FQDN = std::wstring(L"fqdn");

const ::std::wstring UserInfoC::LDAP_PROP_ONLINE = std::wstring(L"online");

const ::std::wstring UserInfoC::LDAP_PROP_OBJECT_CLASS = std::wstring(L"objectClass");

const ::std::wstring UserInfoC::LDAP_PROP_MEMBER_OF = std::wstring(L"memberOf");

const ::std::wstring UserInfoC::LDAP_PROP_LEGACY_EXCHANGE_DN = std::wstring(L"legacyExchangeDN");

const ::std::wstring UserInfoC::LDAP_PROP_MAIL = std::wstring(L"mail");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_HIDE_FROM_ADDRESS_LISTS = std::wstring(L"msExchHideFromAddressLists");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_RECIPIENT_TYPE_DETAILS = std::wstring(L"msExchRecipientTypeDetails");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_RECIPIENT_DISPLAY_TYPE = std::wstring(L"msExchRecipientDisplayType");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_DELEGATE_LIST_LINK = std::wstring(L"msExchDelegateListLink");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_PUBFOLDER_MAILBOX = std::wstring(L"msExchPublicFolderMailbox");

const ::std::wstring UserInfoC::LDAP_PROP_ADMIN_DISPLAY_NAME = std::wstring(L"adminDisplayName");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_JOURNAL_RCPT = std::wstring(L"msExchMessageJournalRecipient");

const ::std::wstring UserInfoC::LDAP_PROP_EXCH_OWNING_SERVER = std::wstring(L"msExchOwningServer");

const ::std::wstring UserInfoC::LDAP_PROP_ONLINE_MAIL = std::wstring(L"PrimarySmtpAddress");

const ::std::wstring UserInfoC::LDAP_PROP_ONLINE_RECIPIENT_TYPE_DETAILS = std::wstring(L"RecipientTypeDetails");

const ::std::wstring UserInfoC::LDAP_PROP_ONLINE_GUID = std::wstring(L"Guid");

const ::std::wstring UserInfoC::LDAP_PROP_ONLINE_MAILBOX_ENABLED = std::wstring(L"IsMailboxEnabled");

const ::std::wstring UserInfoC::LDAP_KEY_CN = std::wstring(L"cn");

const ::std::wstring UserInfoC::LDAP_KEY_DISTINGUISHED_NAME = std::wstring(L"distinguishedname");

const ::std::wstring UserInfoC::LDAP_KEY_DISPLAY_NAME = std::wstring(L"displayname");

const ::std::wstring UserInfoC::LDAP_KEY_NAME = std::wstring(L"name");

const ::std::wstring UserInfoC::LDAP_KEY_PROXY_ADDRESSES = std::wstring(L"proxyaddresses");

const ::std::wstring UserInfoC::LDAP_KEY_USER_ACCOUNT_CONTROL = std::wstring(L"useraccountcontrol");

const ::std::wstring UserInfoC::LDAP_KEY_SAM_ACCOUNT_NAME = std::wstring(L"samaccountname");

const ::std::wstring UserInfoC::LDAP_KEY_SAM_ACCOUNT_TYPE = std::wstring(L"samaccounttype");

const ::std::wstring UserInfoC::LDAP_KEY_USER_PRINCIPAL_NAME = std::wstring(L"userprincipalname");

const ::std::wstring UserInfoC::LDAP_KEY_OBJECT_CATEGORY = std::wstring(L"objectcategory");

const ::std::wstring UserInfoC::LDAP_KEY_MAIL_NICK_NAME = std::wstring(L"mailnickname");

const ::std::wstring UserInfoC::LDAP_KEY_OBJECT_GUID = std::wstring(L"objectguid");

const ::std::wstring UserInfoC::LDAP_KEY_OBJECT_SID = std::wstring(L"objectsid");

const ::std::wstring UserInfoC::LDAP_KEY_MS_EXCHANGE_MAILBOX_GUID = std::wstring(L"msexchmailboxguid");

const ::std::wstring UserInfoC::LDAP_KEY_GROUP_TYPE = std::wstring(L"grouptype");

const ::std::wstring UserInfoC::LDAP_KEY_FQDN = std::wstring(L"fqdn");

const ::std::wstring UserInfoC::LDAP_KEY_ONLINE = std::wstring(L"online");

const ::std::wstring UserInfoC::LDAP_KEY_OBJECT_CLASS = std::wstring(L"objectclass");

const ::std::wstring UserInfoC::LDAP_KEY_MEMBER_OF = std::wstring(L"memberof");

const ::std::wstring UserInfoC::LDAP_KEY_LEGACY_EXCHANGE_DN = std::wstring(L"legacyexchangedn");

const ::std::wstring UserInfoC::LDAP_KEY_MAIL = std::wstring(L"mail");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_HIDE_FROM_ADDRESS_LISTS = std::wstring(L"msexchhidefromaddresslists");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_RECIPIENT_TYPE_DETAILS = std::wstring(L"msexchrecipienttypedetails");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_RECIPIENT_DISPLAY_TYPE = std::wstring(L"msexchrecipientdisplaytype");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_DELEGATE_LIST_LINK = std::wstring(L"msexchdelegatelistlink");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_PUBFOLDER_MAILBOX = std::wstring(L"msexchpublicfoldermailbox");

const ::std::wstring UserInfoC::LDAP_KEY_ADMIN_DISPLAY_NAME = std::wstring(L"admindisplayname");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_JOURNAL_RCPT = std::wstring(L"msexchmessagejournalrecipient");

const ::std::wstring UserInfoC::LDAP_KEY_EXCH_OWNING_SERVER = std::wstring(L"msexchowningserver");

const ::std::wstring UserInfoC::LDAP_KEY_ONLINE_MAIL = std::wstring(L"primarysmtpaddress");

const ::std::wstring UserInfoC::LDAP_KEY_ONLINE_RECIPIENT_TYPE_DETAILS = std::wstring(L"recipienttypedetails");

const ::std::wstring UserInfoC::LDAP_KEY_ONLINE_GUID = std::wstring(L"guid");

const ::std::wstring UserInfoC::LDAP_KEY_ONLINE_MAILBOX_ENABLED = std::wstring(L"ismailboxenabled");

// checkpoint byps.gen.cpp.GenApiClass:489
UserInfoC::UserInfoC() {
	lnName = 0;
	lnPwd = 0;
	lnDesc = 0;
	lnUserProp = 0;
	lnLdapPropKey = 0;
	lnLdapPropValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserInfoC::UserInfoC(int32_t MAX_USERPROP, int32_t MAX_KEY, int32_t MAX_USERS, int32_t MAX_GROUPS, int32_t MAX_PERSISTENT_GROUPS, int32_t TYPE_USER, int32_t TYPE_GROUP, int32_t TYPE_USERID_OWNER, int32_t MAX_NAME, int32_t PROP_NAME_OS, int32_t PROP_NAME_EMAIL, int32_t PROP_ACTION, const ::std::wstring& PROP_ACTION_USER_SHOULD_CHANGE_PASSWORD, const ::std::wstring& PROP_ACTION_USER_MUST_CHANGE_PASSWORD, const ::std::wstring& PROP_ACTION_END_PASSWORD_DATE, int32_t PROP_GUID, int32_t lnName, int32_t lnPwd, int32_t lnDesc, int32_t lnUserProp, int32_t lnLdapPropKey, int32_t lnLdapPropValue, int32_t ID_EVERYONE_GROUP, int32_t ID_ADMINISTRATOR, const ::std::wstring& GUID_EVERYONE_GROUP, const ::std::wstring& GUID_ADMINISTRATOR, const ::std::wstring& PWD_VALUE_IGNORE, const ::std::wstring& LDAP_PROP_CN, const ::std::wstring& LDAP_PROP_DISTINGUISHED_NAME, const ::std::wstring& LDAP_PROP_DISPLAY_NAME, const ::std::wstring& LDAP_PROP_NAME, const ::std::wstring& LDAP_PROP_PROXY_ADDRESSES, const ::std::wstring& LDAP_PROP_USER_ACCOUNT_CONTROL, const ::std::wstring& LDAP_PROP_SAM_ACCOUNT_NAME, const ::std::wstring& LDAP_PROP_SAM_ACCOUNT_TYPE, const ::std::wstring& LDAP_PROP_USER_PRINCIPAL_NAME, const ::std::wstring& LDAP_PROP_OBJECT_CATEGORY, const ::std::wstring& LDAP_PROP_MAIL_NICK_NAME, const ::std::wstring& LDAP_PROP_OBJECT_GUID, const ::std::wstring& LDAP_PROP_OBJECT_SID, const ::std::wstring& LDAP_PROP_MS_EXCHANGE_MAILBOX_GUID, const ::std::wstring& LDAP_PROP_GROUP_TYPE, const ::std::wstring& LDAP_PROP_FQDN, const ::std::wstring& LDAP_PROP_ONLINE, const ::std::wstring& LDAP_PROP_OBJECT_CLASS, const ::std::wstring& LDAP_PROP_MEMBER_OF, const ::std::wstring& LDAP_PROP_LEGACY_EXCHANGE_DN, const ::std::wstring& LDAP_PROP_MAIL, const ::std::wstring& LDAP_PROP_EXCH_HIDE_FROM_ADDRESS_LISTS, const ::std::wstring& LDAP_PROP_EXCH_RECIPIENT_TYPE_DETAILS, const ::std::wstring& LDAP_PROP_EXCH_RECIPIENT_DISPLAY_TYPE, const ::std::wstring& LDAP_PROP_EXCH_DELEGATE_LIST_LINK, const ::std::wstring& LDAP_PROP_EXCH_PUBFOLDER_MAILBOX, const ::std::wstring& LDAP_PROP_ADMIN_DISPLAY_NAME, const ::std::wstring& LDAP_PROP_EXCH_JOURNAL_RCPT, const ::std::wstring& LDAP_PROP_EXCH_OWNING_SERVER, const ::std::wstring& LDAP_PROP_ONLINE_MAIL, const ::std::wstring& LDAP_PROP_ONLINE_RECIPIENT_TYPE_DETAILS, const ::std::wstring& LDAP_PROP_ONLINE_GUID, const ::std::wstring& LDAP_PROP_ONLINE_MAILBOX_ENABLED, const ::std::wstring& LDAP_KEY_CN, const ::std::wstring& LDAP_KEY_DISTINGUISHED_NAME, const ::std::wstring& LDAP_KEY_DISPLAY_NAME, const ::std::wstring& LDAP_KEY_NAME, const ::std::wstring& LDAP_KEY_PROXY_ADDRESSES, const ::std::wstring& LDAP_KEY_USER_ACCOUNT_CONTROL, const ::std::wstring& LDAP_KEY_SAM_ACCOUNT_NAME, const ::std::wstring& LDAP_KEY_SAM_ACCOUNT_TYPE, const ::std::wstring& LDAP_KEY_USER_PRINCIPAL_NAME, const ::std::wstring& LDAP_KEY_OBJECT_CATEGORY, const ::std::wstring& LDAP_KEY_MAIL_NICK_NAME, const ::std::wstring& LDAP_KEY_OBJECT_GUID, const ::std::wstring& LDAP_KEY_OBJECT_SID, const ::std::wstring& LDAP_KEY_MS_EXCHANGE_MAILBOX_GUID, const ::std::wstring& LDAP_KEY_GROUP_TYPE, const ::std::wstring& LDAP_KEY_FQDN, const ::std::wstring& LDAP_KEY_ONLINE, const ::std::wstring& LDAP_KEY_OBJECT_CLASS, const ::std::wstring& LDAP_KEY_MEMBER_OF, const ::std::wstring& LDAP_KEY_LEGACY_EXCHANGE_DN, const ::std::wstring& LDAP_KEY_MAIL, const ::std::wstring& LDAP_KEY_EXCH_HIDE_FROM_ADDRESS_LISTS, const ::std::wstring& LDAP_KEY_EXCH_RECIPIENT_TYPE_DETAILS, const ::std::wstring& LDAP_KEY_EXCH_RECIPIENT_DISPLAY_TYPE, const ::std::wstring& LDAP_KEY_EXCH_DELEGATE_LIST_LINK, const ::std::wstring& LDAP_KEY_EXCH_PUBFOLDER_MAILBOX, const ::std::wstring& LDAP_KEY_ADMIN_DISPLAY_NAME, const ::std::wstring& LDAP_KEY_EXCH_JOURNAL_RCPT, const ::std::wstring& LDAP_KEY_EXCH_OWNING_SERVER, const ::std::wstring& LDAP_KEY_ONLINE_MAIL, const ::std::wstring& LDAP_KEY_ONLINE_RECIPIENT_TYPE_DETAILS, const ::std::wstring& LDAP_KEY_ONLINE_GUID, const ::std::wstring& LDAP_KEY_ONLINE_MAILBOX_ENABLED)
	: lnName(lnName)
	, lnPwd(lnPwd)
	, lnDesc(lnDesc)
	, lnUserProp(lnUserProp)
	, lnLdapPropKey(lnLdapPropKey)
	, lnLdapPropValue(lnLdapPropValue)
	, GUID_EVERYONE_GROUP(GUID_EVERYONE_GROUP)
	, GUID_ADMINISTRATOR(GUID_ADMINISTRATOR)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserInfoC::BSerializable_getTypeId() {
	return 703234555; 
}
void UserInfoC::setLnName(int32_t v) {
	lnName = v;
}
void UserInfoC::setLnPwd(int32_t v) {
	lnPwd = v;
}
void UserInfoC::setLnDesc(int32_t v) {
	lnDesc = v;
}
void UserInfoC::setLnUserProp(int32_t v) {
	lnUserProp = v;
}
void UserInfoC::setLnLdapPropKey(int32_t v) {
	lnLdapPropKey = v;
}
void UserInfoC::setLnLdapPropValue(int32_t v) {
	lnLdapPropValue = v;
}
void UserInfoC::setGUID_EVERYONE_GROUP(::std::wstring v) {
	GUID_EVERYONE_GROUP = v;
}
void UserInfoC::setGUID_ADMINISTRATOR(::std::wstring v) {
	GUID_ADMINISTRATOR = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserInfoC::serialize(BIO& ar, const BVERSION version) {
	if (version >= 600000103000001) {
		ar & this->lnDesc;
		ar & this->lnName;
		ar & this->lnPwd;
		ar & this->lnUserProp;
		if (version >= 700000000000012) {
			ar & this->GUID_ADMINISTRATOR;
			ar & this->GUID_EVERYONE_GROUP;
			if (version >= 1000170010000008) {
				ar & this->lnLdapPropKey;
				ar & this->lnLdapPropValue;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_703234555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1132956238(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PUserInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserName
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserName::UserName() {
	id = 0;
	type = 0;
	flags = 0;
	flags2 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserName::UserName(int32_t id, const ::std::wstring& name, int32_t type, int32_t flags, int32_t flags2)
	: id(id)
	, name(name)
	, type(type)
	, flags(flags)
	, flags2(flags2)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserName::BSerializable_getTypeId() {
	return 123879203; 
}
void UserName::setId(int32_t v) {
	id = v;
}
void UserName::setName(::std::wstring v) {
	name = v;
}
void UserName::setType(int32_t v) {
	type = v;
}
void UserName::setFlags(int32_t v) {
	flags = v;
}
void UserName::setFlags2(int32_t v) {
	flags2 = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserName::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->name;
	ar & this->type;
	if (version >= 700000000000020) {
		ar & this->flags;
		if (version >= 800000000000006) {
			ar & this->flags2;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_123879203(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserName>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1001617329(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PUserName > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserNodeInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserNodeInfo::UserNodeInfo() {
	timeLimit = 0;
	flags = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserNodeInfo::UserNodeInfo(const ::std::wstring& nodeName, const ::std::wstring& userId, const PArrayWFTimeLimit& timeLimitEscalations, int32_t timeLimit, const ::std::wstring& timeLimitIso, int32_t flags)
	: nodeName(nodeName)
	, userId(userId)
	, timeLimitEscalations(timeLimitEscalations)
	, timeLimit(timeLimit)
	, timeLimitIso(timeLimitIso)
	, flags(flags)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserNodeInfo::BSerializable_getTypeId() {
	return 2059835971; 
}
void UserNodeInfo::setNodeName(::std::wstring v) {
	nodeName = v;
}
void UserNodeInfo::setUserId(::std::wstring v) {
	userId = v;
}
void UserNodeInfo::setTimeLimitEscalations(PArrayWFTimeLimit v) {
	timeLimitEscalations = v;
}
void UserNodeInfo::setTimeLimit(int32_t v) {
	timeLimit = v;
}
void UserNodeInfo::setTimeLimitIso(::std::wstring v) {
	timeLimitIso = v;
}
void UserNodeInfo::setFlags(int32_t v) {
	flags = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserNodeInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->nodeName;
	ar & this->userId;
	if (version >= 900000016000009) {
		ar & this->timeLimit;
		ar & this->timeLimitIso;
		if (version >= 900000016000013) {
			ar & this->flags;
		}
	}
	if (version >= 900000016000009) {
		ar & this->timeLimitEscalations;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2059835971(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserNodeInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1772247724(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PUserNodeInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserProfile
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserProfile::UserProfile() {
	excludeGroupValues = false;
	excludeDefaultValues = false;
	groupId = 0;
	includeAllGroupAndDefaultOptions = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserProfile::UserProfile(const PArrayKeyValue& options, const ::std::wstring& userId, bool excludeGroupValues, bool excludeDefaultValues, const PArrayKeyValue& userOptions, const PArrayKeyValue& groupOptions, const PArrayKeyValue& defaultOptions, int32_t groupId, bool includeAllGroupAndDefaultOptions)
	: options(options)
	, userId(userId)
	, excludeGroupValues(excludeGroupValues)
	, excludeDefaultValues(excludeDefaultValues)
	, userOptions(userOptions)
	, groupOptions(groupOptions)
	, defaultOptions(defaultOptions)
	, groupId(groupId)
	, includeAllGroupAndDefaultOptions(includeAllGroupAndDefaultOptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserProfile::BSerializable_getTypeId() {
	return 1401065069; 
}
void UserProfile::setOptions(PArrayKeyValue v) {
	options = v;
}
void UserProfile::setUserId(::std::wstring v) {
	userId = v;
}
void UserProfile::setExcludeGroupValues(bool v) {
	excludeGroupValues = v;
}
void UserProfile::setExcludeDefaultValues(bool v) {
	excludeDefaultValues = v;
}
void UserProfile::setUserOptions(PArrayKeyValue v) {
	userOptions = v;
}
void UserProfile::setGroupOptions(PArrayKeyValue v) {
	groupOptions = v;
}
void UserProfile::setDefaultOptions(PArrayKeyValue v) {
	defaultOptions = v;
}
void UserProfile::setGroupId(int32_t v) {
	groupId = v;
}
void UserProfile::setIncludeAllGroupAndDefaultOptions(bool v) {
	includeAllGroupAndDefaultOptions = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserProfile::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->userId;
	if (version >= 700000040000014) {
		ar & this->excludeDefaultValues;
		ar & this->excludeGroupValues;
		if (version >= 800000010000001) {
			ar & this->groupId;
			if (version >= 1000170040000004) {
				ar & this->includeAllGroupAndDefaultOptions;
			}
		}
	}
	ar & this->options;
	if (version >= 800000010000001) {
		ar & this->defaultOptions;
		ar & this->groupOptions;
		ar & this->userOptions;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1401065069(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserProfile>(bio, pObj, pObjS, pBase);	
}
}}}}

#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLineDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLineDataC::DocMaskLineDataC() {
	lnName = 0;
	lnKey = 0;
	lnComment = 0;
	lnExternalData = 0;
	lnInternalAcl = 0;
	lnDefaultValue = 0;
	lnServerScriptName = 0;
	lnNameTranslationKey = 0;
	lnCommentTranslationKey = 0;
	lnValidateExpression = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLineDataC::DocMaskLineDataC(int64_t mbMaskId, int64_t mbId, int64_t mbRawType, int64_t mbName, int32_t lnName, int64_t mbKey, int32_t lnKey, int64_t mbMin, int64_t mbMax, int64_t mbLKey, int64_t mbRawFlags, int64_t mbComment, int32_t lnComment, int64_t mbExternalData, int32_t lnExternalData, int64_t mbInternalAcl, int32_t lnInternalAcl, int64_t mbDefaultValue, int32_t lnDefaultValue, int64_t mbTabIndex, int64_t mbServerScriptName, int32_t lnServerScriptName, int64_t mbNameTranslationKey, int32_t lnNameTranslationKey, int64_t mbCommentTranslationKey, int32_t lnCommentTranslationKey, int64_t mbValidateExpression, int32_t lnValidateExpression, int64_t mbAllMembers)
	: lnName(lnName)
	, lnKey(lnKey)
	, lnComment(lnComment)
	, lnExternalData(lnExternalData)
	, lnInternalAcl(lnInternalAcl)
	, lnDefaultValue(lnDefaultValue)
	, lnServerScriptName(lnServerScriptName)
	, lnNameTranslationKey(lnNameTranslationKey)
	, lnCommentTranslationKey(lnCommentTranslationKey)
	, lnValidateExpression(lnValidateExpression)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLineDataC::BSerializable_getTypeId() {
	return 1178569423; 
}
void DocMaskLineDataC::setLnName(int32_t v) {
	lnName = v;
}
void DocMaskLineDataC::setLnKey(int32_t v) {
	lnKey = v;
}
void DocMaskLineDataC::setLnComment(int32_t v) {
	lnComment = v;
}
void DocMaskLineDataC::setLnExternalData(int32_t v) {
	lnExternalData = v;
}
void DocMaskLineDataC::setLnInternalAcl(int32_t v) {
	lnInternalAcl = v;
}
void DocMaskLineDataC::setLnDefaultValue(int32_t v) {
	lnDefaultValue = v;
}
void DocMaskLineDataC::setLnServerScriptName(int32_t v) {
	lnServerScriptName = v;
}
void DocMaskLineDataC::setLnNameTranslationKey(int32_t v) {
	lnNameTranslationKey = v;
}
void DocMaskLineDataC::setLnCommentTranslationKey(int32_t v) {
	lnCommentTranslationKey = v;
}
void DocMaskLineDataC::setLnValidateExpression(int32_t v) {
	lnValidateExpression = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLineDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	ar & this->lnKey;
	ar & this->lnName;
	if (version >= 700000000000000) {
		ar & this->lnExternalData;
		if (version >= 700000000000006) {
			ar & this->lnInternalAcl;
			if (version >= 700000040000016) {
				ar & this->lnDefaultValue;
				if (version >= 900000000000001) {
					ar & this->lnServerScriptName;
					if (version >= 900000018000005) {
						ar & this->lnCommentTranslationKey;
						ar & this->lnNameTranslationKey;
						if (version >= 1000000020000010) {
							ar & this->lnValidateExpression;
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
void BSerializer_1178569423(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLineDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLineC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring DocMaskLineC::NAME_LINK = std::wstring(L"ELO_XLINK");

const ::std::wstring DocMaskLineC::NAME_FILENAME = std::wstring(L"ELO_FNAME");

const ::std::wstring DocMaskLineC::DOCNAME_VSL = std::wstring(L"ELO_VSL");

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLineC::DocMaskLineC() {
	lnAcl = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLineC::DocMaskLineC(int64_t mbType, int64_t mbFlags, int64_t mbAcl, int32_t lnAcl, int32_t _TYPE_TYPE_ID, int32_t TYPE_TEXT, int32_t TYPE_DATE, int32_t TYPE_NUMBER, int32_t TYPE_AZ, int32_t TYPE_ISO_DATE, int32_t TYPE_LIST, int32_t TYPE_USER, int32_t TYPE_THES, int32_t TYPE_NUMBER_F0, int32_t TYPE_NUMBER_F1, int32_t TYPE_NUMBER_F2, int32_t TYPE_NUMBER_F4, int32_t TYPE_NUMBER_F6, int32_t TYPE_INTEGER, int32_t TYPE_LONG, int32_t TYPE_FLOAT, int32_t TYPE_DOUBLE, int32_t DEFAULT, int32_t ID_LINK, const ::std::wstring& NAME_LINK, int32_t ID_FILENAME, const ::std::wstring& NAME_FILENAME, int32_t DOCKEY_VSL, const ::std::wstring& DOCNAME_VSL, int32_t MAX_ID_DOCMASK_LINE, int32_t MAX_ID_VALUE_ARRAY, int32_t MIN_ID_HIDDEN_VALUE, int32_t MAX_ID_HIDDEN_VALUE, int64_t mbAclItems, int64_t mbHidden, int64_t mbNextTab, int64_t mbOnlyBuzzwords, int64_t mbPostfixAsterix, int64_t mbPrefixAsterix, int64_t mbReadOnly, int64_t mbTabOrder, int64_t mbTranslate, int64_t mbImportant, int64_t mbVersion)
	: lnAcl(lnAcl)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLineC::BSerializable_getTypeId() {
	return 1453574806; 
}
void DocMaskLineC::setLnAcl(int32_t v) {
	lnAcl = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLineC::serialize(BIO& ar, const BVERSION version) {
	DocMaskLineDataC::serialize(ar, version);
	if (version >= 700000000000006) {
		ar & this->lnAcl;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1453574806(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLineC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLineTemplate
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLineTemplate::DocMaskLineTemplate() {
	lockId = 0;
	id = 0;
	max = 0;
	min = 0;
	hidden = false;
	onlyBuzzwords = false;
	postfixAsterix = false;
	prefixAsterix = false;
	readOnly = false;
	type = 0;
	important = false;
	notTokenized = false;
	excludeFromISearch = false;
	version = false;
	translate = false;
	disableWordWheel = false;
	inherit = false;
	inheritFromParent = false;
	required = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLineTemplate::DocMaskLineTemplate(const ::std::wstring& TStamp, const ::std::wstring& TStampSync, int32_t lockId, const ::std::wstring& comment, int32_t id, const ::std::wstring& key, int32_t max, int32_t min, const ::std::wstring& name, const PArrayAclItem& aclItems, bool hidden, bool onlyBuzzwords, bool postfixAsterix, bool prefixAsterix, bool readOnly, int32_t type, const ::std::wstring& externalData, bool important, bool notTokenized, bool excludeFromISearch, bool version, bool translate, const ::std::wstring& acl, bool disableWordWheel, const ::std::wstring& defaultValue, const ::std::wstring& serverScriptName, bool inherit, bool inheritFromParent, const ::std::wstring& nameTranslationKey, const ::std::wstring& commentTranslationKey, const ::std::wstring& lockName, const ::std::wstring& validateExpression, bool required)
	: TStamp(TStamp)
	, TStampSync(TStampSync)
	, lockId(lockId)
	, comment(comment)
	, id(id)
	, key(key)
	, max(max)
	, min(min)
	, name(name)
	, aclItems(aclItems)
	, hidden(hidden)
	, onlyBuzzwords(onlyBuzzwords)
	, postfixAsterix(postfixAsterix)
	, prefixAsterix(prefixAsterix)
	, readOnly(readOnly)
	, type(type)
	, externalData(externalData)
	, important(important)
	, notTokenized(notTokenized)
	, excludeFromISearch(excludeFromISearch)
	, version(version)
	, translate(translate)
	, acl(acl)
	, disableWordWheel(disableWordWheel)
	, defaultValue(defaultValue)
	, serverScriptName(serverScriptName)
	, inherit(inherit)
	, inheritFromParent(inheritFromParent)
	, nameTranslationKey(nameTranslationKey)
	, commentTranslationKey(commentTranslationKey)
	, lockName(lockName)
	, validateExpression(validateExpression)
	, required(required)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLineTemplate::BSerializable_getTypeId() {
	return 117741089; 
}
void DocMaskLineTemplate::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(DocMaskLineTemplateC::mbTStamp);
}
void DocMaskLineTemplate::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(DocMaskLineTemplateC::mbTStampSync);
}
void DocMaskLineTemplate::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(DocMaskLineTemplateC::mbLockId);
}
void DocMaskLineTemplate::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(DocMaskLineTemplateC::mbComment);
}
void DocMaskLineTemplate::setId(int32_t v) {
	id = v;
	setChangedMember(DocMaskLineTemplateC::mbId);
}
void DocMaskLineTemplate::setKey(::std::wstring v) {
	key = v;
	setChangedMember(DocMaskLineTemplateC::mbKey);
}
void DocMaskLineTemplate::setMax(int32_t v) {
	max = v;
	setChangedMember(DocMaskLineTemplateC::mbMax);
}
void DocMaskLineTemplate::setMin(int32_t v) {
	min = v;
	setChangedMember(DocMaskLineTemplateC::mbMin);
}
void DocMaskLineTemplate::setName(::std::wstring v) {
	name = v;
	setChangedMember(DocMaskLineTemplateC::mbName);
}
void DocMaskLineTemplate::setAclItems(PArrayAclItem v) {
	aclItems = v;
	setChangedMember(DocMaskLineTemplateC::mbAclItems);
}
void DocMaskLineTemplate::setHidden(bool v) {
	hidden = v;
	setChangedMember(DocMaskLineTemplateC::mbHidden);
}
void DocMaskLineTemplate::setOnlyBuzzwords(bool v) {
	onlyBuzzwords = v;
	setChangedMember(DocMaskLineTemplateC::mbOnlyBuzzwords);
}
void DocMaskLineTemplate::setPostfixAsterix(bool v) {
	postfixAsterix = v;
	setChangedMember(DocMaskLineTemplateC::mbPostfixAsterix);
}
void DocMaskLineTemplate::setPrefixAsterix(bool v) {
	prefixAsterix = v;
	setChangedMember(DocMaskLineTemplateC::mbPrefixAsterix);
}
void DocMaskLineTemplate::setReadOnly(bool v) {
	readOnly = v;
	setChangedMember(DocMaskLineTemplateC::mbReadOnly);
}
void DocMaskLineTemplate::setType(int32_t v) {
	type = v;
	setChangedMember(DocMaskLineTemplateC::mbType);
}
void DocMaskLineTemplate::setExternalData(::std::wstring v) {
	externalData = v;
	setChangedMember(DocMaskLineTemplateC::mbExternalData);
}
void DocMaskLineTemplate::setImportant(bool v) {
	important = v;
	setChangedMember(DocMaskLineTemplateC::mbImportant);
}
void DocMaskLineTemplate::setNotTokenized(bool v) {
	notTokenized = v;
}
void DocMaskLineTemplate::setExcludeFromISearch(bool v) {
	excludeFromISearch = v;
}
void DocMaskLineTemplate::setVersion(bool v) {
	version = v;
	setChangedMember(DocMaskLineTemplateC::mbVersion);
}
void DocMaskLineTemplate::setTranslate(bool v) {
	translate = v;
	setChangedMember(DocMaskLineTemplateC::mbTranslate);
}
void DocMaskLineTemplate::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(DocMaskLineTemplateC::mbAcl);
}
void DocMaskLineTemplate::setDisableWordWheel(bool v) {
	disableWordWheel = v;
}
void DocMaskLineTemplate::setDefaultValue(::std::wstring v) {
	defaultValue = v;
	setChangedMember(DocMaskLineTemplateC::mbDefaultValue);
}
void DocMaskLineTemplate::setServerScriptName(::std::wstring v) {
	serverScriptName = v;
	setChangedMember(DocMaskLineTemplateC::mbServerScriptName);
}
void DocMaskLineTemplate::setInherit(bool v) {
	inherit = v;
}
void DocMaskLineTemplate::setInheritFromParent(bool v) {
	inheritFromParent = v;
}
void DocMaskLineTemplate::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
	setChangedMember(DocMaskLineTemplateC::mbNameTranslationKey);
}
void DocMaskLineTemplate::setCommentTranslationKey(::std::wstring v) {
	commentTranslationKey = v;
	setChangedMember(DocMaskLineTemplateC::mbCommentTranslationKey);
}
void DocMaskLineTemplate::setLockName(::std::wstring v) {
	lockName = v;
}
void DocMaskLineTemplate::setValidateExpression(::std::wstring v) {
	validateExpression = v;
	setChangedMember(DocMaskLineTemplateC::mbValidateExpression);
}
void DocMaskLineTemplate::setRequired(bool v) {
	required = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLineTemplate::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->TStampSync;
	ar & this->acl;
	ar & this->comment;
	ar & this->commentTranslationKey;
	ar & this->defaultValue;
	ar & this->disableWordWheel;
	ar & this->externalData;
	ar & this->hidden;
	ar & this->id;
	ar & this->important;
	ar & this->inherit;
	ar & this->inheritFromParent;
	ar & this->key;
	ar & this->lockId;
	ar & this->lockName;
	ar & this->max;
	ar & this->min;
	ar & this->name;
	ar & this->nameTranslationKey;
	ar & this->notTokenized;
	ar & this->onlyBuzzwords;
	ar & this->postfixAsterix;
	ar & this->prefixAsterix;
	ar & this->readOnly;
	ar & this->serverScriptName;
	ar & this->translate;
	ar & this->type;
	ar & this->version;
	if (version >= 1000000020000010) {
		ar & this->required;
		ar & this->validateExpression;
		if (version >= 1000000020000023) {
			ar & this->excludeFromISearch;
		}
	}
	ar & this->aclItems;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_117741089(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLineTemplate>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLineTemplateDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLineTemplateDataC::DocMaskLineTemplateDataC() {
	lnName = 0;
	lnKey = 0;
	lnComment = 0;
	lnDefaultValue = 0;
	lnExternalData = 0;
	lnInternalAcl = 0;
	lnCommentTranslationKey = 0;
	lnNameTranslationKey = 0;
	lnServerScriptName = 0;
	lnTStamp = 0;
	lnTStampSync = 0;
	lnValidateExpression = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLineTemplateDataC::DocMaskLineTemplateDataC(int64_t mbId, int64_t mbRawType, int64_t mbName, int32_t lnName, int64_t mbKey, int32_t lnKey, int64_t mbMin, int64_t mbMax, int64_t mbLockId, int64_t mbLKey, int64_t mbRawFlags, int64_t mbComment, int32_t lnComment, int64_t mbDefaultValue, int32_t lnDefaultValue, int64_t mbExternalData, int32_t lnExternalData, int64_t mbInternalAcl, int32_t lnInternalAcl, int64_t mbCommentTranslationKey, int32_t lnCommentTranslationKey, int64_t mbNameTranslationKey, int32_t lnNameTranslationKey, int64_t mbServerScriptName, int32_t lnServerScriptName, int64_t mbTStamp, int32_t lnTStamp, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbValidateExpression, int32_t lnValidateExpression, int64_t mbAllMembers)
	: lnName(lnName)
	, lnKey(lnKey)
	, lnComment(lnComment)
	, lnDefaultValue(lnDefaultValue)
	, lnExternalData(lnExternalData)
	, lnInternalAcl(lnInternalAcl)
	, lnCommentTranslationKey(lnCommentTranslationKey)
	, lnNameTranslationKey(lnNameTranslationKey)
	, lnServerScriptName(lnServerScriptName)
	, lnTStamp(lnTStamp)
	, lnTStampSync(lnTStampSync)
	, lnValidateExpression(lnValidateExpression)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLineTemplateDataC::BSerializable_getTypeId() {
	return 96404005; 
}
void DocMaskLineTemplateDataC::setLnName(int32_t v) {
	lnName = v;
}
void DocMaskLineTemplateDataC::setLnKey(int32_t v) {
	lnKey = v;
}
void DocMaskLineTemplateDataC::setLnComment(int32_t v) {
	lnComment = v;
}
void DocMaskLineTemplateDataC::setLnDefaultValue(int32_t v) {
	lnDefaultValue = v;
}
void DocMaskLineTemplateDataC::setLnExternalData(int32_t v) {
	lnExternalData = v;
}
void DocMaskLineTemplateDataC::setLnInternalAcl(int32_t v) {
	lnInternalAcl = v;
}
void DocMaskLineTemplateDataC::setLnCommentTranslationKey(int32_t v) {
	lnCommentTranslationKey = v;
}
void DocMaskLineTemplateDataC::setLnNameTranslationKey(int32_t v) {
	lnNameTranslationKey = v;
}
void DocMaskLineTemplateDataC::setLnServerScriptName(int32_t v) {
	lnServerScriptName = v;
}
void DocMaskLineTemplateDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void DocMaskLineTemplateDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
void DocMaskLineTemplateDataC::setLnValidateExpression(int32_t v) {
	lnValidateExpression = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLineTemplateDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	ar & this->lnCommentTranslationKey;
	ar & this->lnDefaultValue;
	ar & this->lnExternalData;
	ar & this->lnInternalAcl;
	ar & this->lnKey;
	ar & this->lnName;
	ar & this->lnNameTranslationKey;
	ar & this->lnServerScriptName;
	ar & this->lnTStamp;
	ar & this->lnTStampSync;
	if (version >= 1000000020000010) {
		ar & this->lnValidateExpression;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_96404005(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLineTemplateDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLineTemplateC
// Generated from class byps.gen.cpp.GenApiClass

const PDocMaskLineTemplateZ DocMaskLineTemplateC::mbOnlyLock = PDocMaskLineTemplateZ(new DocMaskLineTemplateZ(
	0LL));

const PDocMaskLineTemplateZ DocMaskLineTemplateC::mbAll = PDocMaskLineTemplateZ(new DocMaskLineTemplateZ(
	524287LL));

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLineTemplateC::DocMaskLineTemplateC() {
	lnAcl = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLineTemplateC::DocMaskLineTemplateC(int64_t mbType, int64_t mbFlags, int64_t mbAcl, const PDocMaskLineTemplateZ& mbOnlyLock, const PDocMaskLineTemplateZ& mbAll, int32_t lnAcl, int64_t mbAclItems, int64_t mbHidden, int64_t mbOnlyBuzzwords, int64_t mbPostfixAsterix, int64_t mbPrefixAsterix, int64_t mbReadOnly, int64_t mbTranslate, int64_t mbImportant, int64_t mbVersion)
	: lnAcl(lnAcl)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLineTemplateC::BSerializable_getTypeId() {
	return 984407269; 
}
void DocMaskLineTemplateC::setLnAcl(int32_t v) {
	lnAcl = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLineTemplateC::serialize(BIO& ar, const BVERSION version) {
	DocMaskLineTemplateDataC::serialize(ar, version);
	if (version >= 700000000000006) {
		ar & this->lnAcl;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_984407269(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLineTemplateC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskLineTemplateZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskLineTemplateZ::DocMaskLineTemplateZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskLineTemplateZ::DocMaskLineTemplateZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskLineTemplateZ::BSerializable_getTypeId() {
	return 1687510263; 
}
void DocMaskLineTemplateZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskLineTemplateZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1687510263(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskLineTemplateZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1107316733(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PDocMaskLineTemplate > >(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_745804061(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PDocMaskLine > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocMaskZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocMaskZ::DocMaskZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocMaskZ::DocMaskZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocMaskZ::BSerializable_getTypeId() {
	return 1064616030; 
}
void DocMaskZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocMaskZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1064616030(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocMaskZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocVersion
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
DocVersion::DocVersion() {
	deleted = false;
	id = 0;
	milestone = false;
	ownerId = 0;
	pathId = 0;
	pathId2 = 0;
	size = 0;
	workVersion = false;
	encryptionSet = 0;
	nbOfValidSignatures = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocVersion::DocVersion(const ::std::wstring& accessDateIso, const ::std::wstring& comment, const ::std::wstring& createDateIso, bool deleted, const ::std::wstring& ext, const ::std::wstring& contentType, const PFileData& fileData, const ::std::wstring& guid, int32_t id, const ::std::wstring& md5, bool milestone, int32_t ownerId, const ::std::wstring& ownerName, int32_t pathId, int32_t pathId2, const ::std::wstring& physPath, const ::std::wstring& previewUrl, const PDocVersion& sig, const PDocVersion& preview, int64_t size, const ::std::wstring& tStamp, const ::std::wstring& updateDateIso, const ::std::wstring& uploadResult, const ::std::wstring& url, const ::std::wstring& version, bool workVersion, int32_t encryptionSet, const PDocVersion& fulltextContent, const ::std::wstring& deleteDateIso, int32_t nbOfValidSignatures, const ::std::wstring& relativeFilePath, const ::std::wstring& tStampSync)
	: accessDateIso(accessDateIso)
	, comment(comment)
	, createDateIso(createDateIso)
	, deleted(deleted)
	, ext(ext)
	, contentType(contentType)
	, fileData(fileData)
	, guid(guid)
	, id(id)
	, md5(md5)
	, milestone(milestone)
	, ownerId(ownerId)
	, ownerName(ownerName)
	, pathId(pathId)
	, pathId2(pathId2)
	, physPath(physPath)
	, previewUrl(previewUrl)
	, sig(sig)
	, preview(preview)
	, size(size)
	, tStamp(tStamp)
	, updateDateIso(updateDateIso)
	, uploadResult(uploadResult)
	, url(url)
	, version(version)
	, workVersion(workVersion)
	, encryptionSet(encryptionSet)
	, fulltextContent(fulltextContent)
	, deleteDateIso(deleteDateIso)
	, nbOfValidSignatures(nbOfValidSignatures)
	, relativeFilePath(relativeFilePath)
	, tStampSync(tStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocVersion::BSerializable_getTypeId() {
	return 633004623; 
}
void DocVersion::setAccessDateIso(::std::wstring v) {
	accessDateIso = v;
}
void DocVersion::setComment(::std::wstring v) {
	comment = v;
}
void DocVersion::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
}
void DocVersion::setDeleted(bool v) {
	deleted = v;
}
void DocVersion::setExt(::std::wstring v) {
	ext = v;
}
void DocVersion::setContentType(::std::wstring v) {
	contentType = v;
}
void DocVersion::setFileData(PFileData v) {
	fileData = v;
}
void DocVersion::setGuid(::std::wstring v) {
	guid = v;
}
void DocVersion::setId(int32_t v) {
	id = v;
}
void DocVersion::setMd5(::std::wstring v) {
	md5 = v;
}
void DocVersion::setMilestone(bool v) {
	milestone = v;
}
void DocVersion::setOwnerId(int32_t v) {
	ownerId = v;
}
void DocVersion::setOwnerName(::std::wstring v) {
	ownerName = v;
}
void DocVersion::setPathId(int32_t v) {
	pathId = v;
}
void DocVersion::setPathId2(int32_t v) {
	pathId2 = v;
}
void DocVersion::setPhysPath(::std::wstring v) {
	physPath = v;
}
void DocVersion::setPreviewUrl(::std::wstring v) {
	previewUrl = v;
}
void DocVersion::setSig(PDocVersion v) {
	sig = v;
}
void DocVersion::setPreview(PDocVersion v) {
	preview = v;
}
void DocVersion::setSize(int64_t v) {
	size = v;
}
void DocVersion::setTStamp(::std::wstring v) {
	tStamp = v;
}
void DocVersion::setUpdateDateIso(::std::wstring v) {
	updateDateIso = v;
}
void DocVersion::setUploadResult(::std::wstring v) {
	uploadResult = v;
}
void DocVersion::setUrl(::std::wstring v) {
	url = v;
}
void DocVersion::setVersion(::std::wstring v) {
	version = v;
}
void DocVersion::setWorkVersion(bool v) {
	workVersion = v;
}
void DocVersion::setEncryptionSet(int32_t v) {
	encryptionSet = v;
}
void DocVersion::setFulltextContent(PDocVersion v) {
	fulltextContent = v;
}
void DocVersion::setDeleteDateIso(::std::wstring v) {
	deleteDateIso = v;
}
void DocVersion::setNbOfValidSignatures(int32_t v) {
	nbOfValidSignatures = v;
}
void DocVersion::setRelativeFilePath(::std::wstring v) {
	relativeFilePath = v;
}
void DocVersion::setTStampSync(::std::wstring v) {
	tStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocVersion::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->accessDateIso;
	ar & this->comment;
	ar & this->createDateIso;
	ar & this->deleted;
	ar & this->encryptionSet;
	ar & this->ext;
	ar & this->guid;
	ar & this->id;
	ar & this->md5;
	ar & this->milestone;
	ar & this->ownerId;
	ar & this->ownerName;
	ar & this->pathId;
	ar & this->pathId2;
	ar & this->physPath;
	ar & this->previewUrl;
	ar & this->size;
	ar & this->tStamp;
	ar & this->updateDateIso;
	ar & this->uploadResult;
	ar & this->url;
	ar & this->version;
	ar & this->workVersion;
	if (version >= 600000095000000) {
		ar & this->contentType;
		if (version >= 900000000000000) {
			ar & this->deleteDateIso;
			if (version >= 900000016000002) {
				ar & this->nbOfValidSignatures;
				if (version >= 900000030000023) {
					ar & this->relativeFilePath;
					if (version >= 900990009000001) {
						ar & this->tStampSync;
					}
				}
			}
		}
	}
	ar & this->fileData;
	ar & this->sig;
	if (version >= 600000087000000) {
		ar & this->preview;
		if (version >= 700000020000003) {
			ar & this->fulltextContent;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_633004623(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocVersion>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class DocVersionC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring DocVersionC::UPLOAD_RESULT_ERROR = std::wstring(L"ERROR");

const ::std::wstring DocVersionC::URL_PARAM_OFFSET = std::wstring(L"offset");

const ::std::wstring DocVersionC::URL_PARAM_LENGTH = std::wstring(L"length");

const ::std::wstring DocVersionC::URL_PARAM_CREATE_DATE = std::wstring(L"createdate");

const ::std::wstring DocVersionC::URL_PARAM_LAST_UPDATE = std::wstring(L"lastupdate");

const ::std::wstring DocVersionC::URL_PARAM_LAST_ACCESS = std::wstring(L"lastaccess");

// checkpoint byps.gen.cpp.GenApiClass:489
DocVersionC::DocVersionC() {
	lnComment = 0;
	lnVersion = 0;
	lnExt = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::DocVersionC::DocVersionC(const ::std::wstring& UPLOAD_RESULT_ERROR, const ::std::wstring& URL_PARAM_OFFSET, const ::std::wstring& URL_PARAM_LENGTH, const ::std::wstring& URL_PARAM_CREATE_DATE, const ::std::wstring& URL_PARAM_LAST_UPDATE, const ::std::wstring& URL_PARAM_LAST_ACCESS, int32_t FLAG_MILESTONE, int32_t TYPE_DOCVERSION, int32_t TYPE_ATTACHMENT, int32_t lnComment, int32_t lnVersion, int32_t lnExt)
	: lnComment(lnComment)
	, lnVersion(lnVersion)
	, lnExt(lnExt)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::DocVersionC::BSerializable_getTypeId() {
	return 615288749; 
}
void DocVersionC::setLnComment(int32_t v) {
	lnComment = v;
}
void DocVersionC::setLnVersion(int32_t v) {
	lnVersion = v;
}
void DocVersionC::setLnExt(int32_t v) {
	lnExt = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void DocVersionC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	ar & this->lnExt;
	ar & this->lnVersion;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_615288749(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::DocVersionC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_807293031(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PDocVersion > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Document
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Document::Document() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Document::Document(const PArrayDocVersion& atts, const PArrayDocVersion& docs, const ::std::wstring& objId)
	: atts(atts)
	, docs(docs)
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Document::BSerializable_getTypeId() {
	return 341056676; 
}
void Document::setAtts(PArrayDocVersion v) {
	atts = v;
}
void Document::setDocs(PArrayDocVersion v) {
	docs = v;
}
void Document::setObjId(::std::wstring v) {
	objId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Document::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->objId;
	ar & this->atts;
	ar & this->docs;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_341056676(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Document>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1047127860(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PDocument > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EditInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EditInfo::EditInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EditInfo::EditInfo(const PArrayIdName& docTemplates, const PDocument& document, const PArrayKeyword& keywords, const PArrayIdName& markerNames, const PDocMask& mask, const PArrayMaskName& maskNames, const PArrayNote& notes, const PArrayIdName& pathNames, const PArrayIdName& replNames, const PSord& sord, const PArraySordType& sordTypes)
	: docTemplates(docTemplates)
	, document(document)
	, keywords(keywords)
	, markerNames(markerNames)
	, mask(mask)
	, maskNames(maskNames)
	, notes(notes)
	, pathNames(pathNames)
	, replNames(replNames)
	, sord(sord)
	, sordTypes(sordTypes)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EditInfo::BSerializable_getTypeId() {
	return 820228328; 
}
void EditInfo::setDocTemplates(PArrayIdName v) {
	docTemplates = v;
	setChangedMember(EditInfoC::mbDocTemplates);
}
void EditInfo::setDocument(PDocument v) {
	document = v;
	setChangedMember(EditInfoC::mbDocumentMembers);
}
void EditInfo::setKeywords(PArrayKeyword v) {
	keywords = v;
	setChangedMember(EditInfoC::mbKeywordMembers);
}
void EditInfo::setMarkerNames(PArrayIdName v) {
	markerNames = v;
	setChangedMember(EditInfoC::mbMarkerNames);
}
void EditInfo::setMask(PDocMask v) {
	mask = v;
	setChangedMember(EditInfoC::mbMaskNames);
}
void EditInfo::setMaskNames(PArrayMaskName v) {
	maskNames = v;
	setChangedMember(EditInfoC::mbMaskNames);
}
void EditInfo::setNotes(PArrayNote v) {
	notes = v;
	setChangedMember(EditInfoC::mbNoteMembers);
}
void EditInfo::setPathNames(PArrayIdName v) {
	pathNames = v;
	setChangedMember(EditInfoC::mbPathNames);
}
void EditInfo::setReplNames(PArrayIdName v) {
	replNames = v;
	setChangedMember(EditInfoC::mbReplNames);
}
void EditInfo::setSord(PSord v) {
	sord = v;
	setChangedMember(EditInfoC::mbSordTypesJPG);
}
void EditInfo::setSordTypes(PArraySordType v) {
	sordTypes = v;
	setChangedMember(EditInfoC::mbSordTypesJPG);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EditInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->docTemplates;
	ar & this->document;
	ar & this->keywords;
	ar & this->markerNames;
	ar & this->mask;
	ar & this->maskNames;
	ar & this->notes;
	ar & this->pathNames;
	ar & this->replNames;
	ar & this->sord;
	ar & this->sordTypes;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_820228328(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EditInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EditInfoC
// Generated from class byps.gen.cpp.GenApiClass

const PEditInfoZ EditInfoC::mbSord = PEditInfoZ(new EditInfoZ(
	0LL,
	PSordZ(new SordZ(
		2145422063697919LL))));

const PEditInfoZ EditInfoC::mbSordContentStream = PEditInfoZ(new EditInfoZ(
	0LL,
	PSordZ(new SordZ(
		4397221877383167LL))));

const PEditInfoZ EditInfoC::mbSordLean = PEditInfoZ(new EditInfoZ(
	0LL,
	PSordZ(new SordZ(
		10168869847039LL))));

const PEditInfoZ EditInfoC::mbSordDoc = PEditInfoZ(new EditInfoZ(
	320LL,
	PSordZ(new SordZ(
		2145422063697919LL))));

const PEditInfoZ EditInfoC::mbSordDocAtt = PEditInfoZ(new EditInfoZ(
	448LL,
	PSordZ(new SordZ(
		2145422063697919LL))));

const PEditInfoZ EditInfoC::mbSordDocAttContentStream = PEditInfoZ(new EditInfoZ(
	448LL,
	PSordZ(new SordZ(
		4397221877383167LL))));

const PEditInfoZ EditInfoC::mbSordDocSmallContent = PEditInfoZ(new EditInfoZ(
	320LL,
	PSordZ(new SordZ(
		2180606435786751LL))));

const PEditInfoZ EditInfoC::mbSordPreviewSmallContent = PEditInfoZ(new EditInfoZ(
	8512LL,
	PSordZ(new SordZ(
		2180606435786751LL))));

const PEditInfoZ EditInfoC::mbDocument = PEditInfoZ(new EditInfoZ(
	320LL,
	PSordZ(new SordZ(
		0LL))));

const PEditInfoZ EditInfoC::mbAttachment = PEditInfoZ(new EditInfoZ(
	128LL,
	PSordZ(new SordZ(
		0LL))));

const PEditInfoZ EditInfoC::mbAll = PEditInfoZ(new EditInfoZ(
	16383LL,
	PSordZ(new SordZ(
		2215790807875583LL))));

const PEditInfoZ EditInfoC::mbBasicData = PEditInfoZ(new EditInfoZ(
	5639LL,
	PSordZ(new SordZ(
		0LL))));

const PEditInfoZ EditInfoC::mbOnlyLock = PEditInfoZ(new EditInfoZ(
	0LL,
	PSordZ(new SordZ(
		0LL))));

const PEditInfoZ EditInfoC::mbNotes = PEditInfoZ(new EditInfoZ(
	2048LL,
	PSordZ(new SordZ(
		0LL))));

const PEditInfoZ EditInfoC::mbSordNotes = PEditInfoZ(new EditInfoZ(
	2048LL,
	PSordZ(new SordZ(
		2145422063697919LL))));

const PEditInfoZ EditInfoC::mbOnlyId = PEditInfoZ(new EditInfoZ(
	0LL,
	PSordZ(new SordZ(
		3LL))));

// checkpoint byps.gen.cpp.GenApiClass:489
EditInfoC::EditInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EditInfoC::BSerializable_getTypeId() {
	return 2100880359; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EditInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2100880359(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EditInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EditInfoEswOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EditInfoEswOptions::EditInfoEswOptions() {
	reserved = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EditInfoEswOptions::EditInfoEswOptions(int32_t reserved)
	: reserved(reserved)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EditInfoEswOptions::BSerializable_getTypeId() {
	return 522299581; 
}
void EditInfoEswOptions::setReserved(int32_t v) {
	reserved = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EditInfoEswOptions::serialize(BIO& ar, const BVERSION version) {
	if (version >= 700000040000024) {
		ar & this->reserved;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_522299581(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EditInfoEswOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EditInfoZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EditInfoZ::EditInfoZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EditInfoZ::EditInfoZ(int64_t bset, const PSordZ& sordZ)
	: bset(bset)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EditInfoZ::BSerializable_getTypeId() {
	return 878901868; 
}
void EditInfoZ::setBset(int64_t v) {
	bset = v;
}
void EditInfoZ::setSordZ(PSordZ v) {
	sordZ = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EditInfoZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
	ar & this->sordZ;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_878901868(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EditInfoZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_785380175(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PEditInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloDmOpt
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloDmOpt::EloDmOpt() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloDmOpt::EloDmOpt(int32_t id, const ::std::wstring& value, const ::std::wstring& remark, const ::std::wstring& instanceName)
	: id(id)
	, value(value)
	, remark(remark)
	, instanceName(instanceName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloDmOpt::BSerializable_getTypeId() {
	return 353149300; 
}
void EloDmOpt::setId(int32_t v) {
	id = v;
	setChangedMember(EloDmOptC::mbId);
}
void EloDmOpt::setValue(::std::wstring v) {
	value = v;
	setChangedMember(EloDmOptC::mbValue);
}
void EloDmOpt::setRemark(::std::wstring v) {
	remark = v;
	setChangedMember(EloDmOptC::mbRemark);
}
void EloDmOpt::setInstanceName(::std::wstring v) {
	instanceName = v;
	setChangedMember(EloDmOptC::mbInstanceName);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloDmOpt::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->remark;
	ar & this->value;
	if (version >= 1000000000000008) {
		ar & this->instanceName;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_353149300(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloDmOpt>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloDmOptDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloDmOptDataC::EloDmOptDataC() {
	lnValue = 0;
	lnRemark = 0;
	lnInstanceName = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloDmOptDataC::EloDmOptDataC(int64_t mbId, int64_t mbValue, int32_t lnValue, int64_t mbRemark, int32_t lnRemark, int64_t mbInstanceName, int32_t lnInstanceName, int64_t mbAllMembers)
	: lnValue(lnValue)
	, lnRemark(lnRemark)
	, lnInstanceName(lnInstanceName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloDmOptDataC::BSerializable_getTypeId() {
	return 1218961099; 
}
void EloDmOptDataC::setLnValue(int32_t v) {
	lnValue = v;
}
void EloDmOptDataC::setLnRemark(int32_t v) {
	lnRemark = v;
}
void EloDmOptDataC::setLnInstanceName(int32_t v) {
	lnInstanceName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloDmOptDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnRemark;
	ar & this->lnValue;
	if (version >= 1000000000000008) {
		ar & this->lnInstanceName;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1218961099(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloDmOptDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloDmOptC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring EloDmOptC::INSTANCE_ALL = std::wstring(L"_ALL");

// checkpoint byps.gen.cpp.GenApiClass:489
EloDmOptC::EloDmOptC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloDmOptC::BSerializable_getTypeId() {
	return 605470240; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloDmOptC::serialize(BIO& ar, const BVERSION version) {
	EloDmOptDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_605470240(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloDmOptC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloFtOpt
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloFtOpt::EloFtOpt() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloFtOpt::EloFtOpt(int32_t id, const ::std::wstring& value, const ::std::wstring& remark)
	: id(id)
	, value(value)
	, remark(remark)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloFtOpt::BSerializable_getTypeId() {
	return 181406923; 
}
void EloFtOpt::setId(int32_t v) {
	id = v;
	setChangedMember(EloFtOptC::mbId);
}
void EloFtOpt::setValue(::std::wstring v) {
	value = v;
	setChangedMember(EloFtOptC::mbValue);
}
void EloFtOpt::setRemark(::std::wstring v) {
	remark = v;
	setChangedMember(EloFtOptC::mbRemark);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloFtOpt::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->remark;
	ar & this->value;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_181406923(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloFtOpt>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloFtOptDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloFtOptDataC::EloFtOptDataC() {
	lnValue = 0;
	lnRemark = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloFtOptDataC::EloFtOptDataC(int64_t mbId, int64_t mbValue, int32_t lnValue, int64_t mbRemark, int32_t lnRemark, int64_t mbAllMembers)
	: lnValue(lnValue)
	, lnRemark(lnRemark)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloFtOptDataC::BSerializable_getTypeId() {
	return 1220982870; 
}
void EloFtOptDataC::setLnValue(int32_t v) {
	lnValue = v;
}
void EloFtOptDataC::setLnRemark(int32_t v) {
	lnRemark = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloFtOptDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnRemark;
	ar & this->lnValue;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1220982870(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloFtOptDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloFtOptC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloFtOptC::EloFtOptC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloFtOptC::BSerializable_getTypeId() {
	return 1603857234; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloFtOptC::serialize(BIO& ar, const BVERSION version) {
	EloFtOptDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1603857234(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloFtOptC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloFtStop
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloFtStop::EloFtStop() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloFtStop::EloFtStop(const ::std::wstring& stopword)
	: stopword(stopword)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloFtStop::BSerializable_getTypeId() {
	return 2135577346; 
}
void EloFtStop::setStopword(::std::wstring v) {
	stopword = v;
	setChangedMember(EloFtStopC::mbStopword);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloFtStop::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->stopword;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2135577346(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloFtStop>(bio, pObj, pObjS, pBase);	
}
}}}}

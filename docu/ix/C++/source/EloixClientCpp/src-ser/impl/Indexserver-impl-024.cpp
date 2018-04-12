#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHistC
// Generated from class byps.gen.cpp.GenApiClass

const PMapHistZ MapHistC::mbAll = PMapHistZ(new MapHistZ(
	2097151LL));

const PMapHistZ MapHistC::mbAllNoItems = PMapHistZ(new MapHistZ(
	1048575LL));

// checkpoint byps.gen.cpp.GenApiClass:489
MapHistC::MapHistC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHistC::BSerializable_getTypeId() {
	return 379654790; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHistC::serialize(BIO& ar, const BVERSION version) {
	MapHistHeadC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_379654790(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHistC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHistItem
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHistItem::MapHistItem() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHistItem::MapHistItem(const ::std::wstring& histGuid, const ::std::wstring& key, const ::std::wstring& value, const PFileData& blobValue)
	: histGuid(histGuid)
	, key(key)
	, value(value)
	, blobValue(blobValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHistItem::BSerializable_getTypeId() {
	return 342049067; 
}
void MapHistItem::setHistGuid(::std::wstring v) {
	histGuid = v;
	setChangedMember(MapHistItemC::mbHistGuid);
}
void MapHistItem::setKey(::std::wstring v) {
	key = v;
	setChangedMember(MapHistItemC::mbKey);
}
void MapHistItem::setValue(::std::wstring v) {
	value = v;
	setChangedMember(MapHistItemC::mbValue);
}
void MapHistItem::setBlobValue(PFileData v) {
	blobValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHistItem::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->histGuid;
	ar & this->key;
	ar & this->value;
	if (version >= 1000000020000011) {
		ar & this->blobValue;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_342049067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHistItem>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHistItemC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHistItemC::MapHistItemC() {
	lnHistGuid = 0;
	lnKey = 0;
	lnValue = 0;
	lnContentType = 0;
	lnBlobData = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHistItemC::MapHistItemC(int64_t mbHistGuid, int32_t lnHistGuid, int64_t mbKey, int32_t lnKey, int64_t mbValue, int32_t lnValue, int64_t mbContentType, int32_t lnContentType, int64_t mbBlobData, int32_t lnBlobData, int64_t mbAllMembers)
	: lnHistGuid(lnHistGuid)
	, lnKey(lnKey)
	, lnValue(lnValue)
	, lnContentType(lnContentType)
	, lnBlobData(lnBlobData)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHistItemC::BSerializable_getTypeId() {
	return 1314989638; 
}
void MapHistItemC::setLnHistGuid(int32_t v) {
	lnHistGuid = v;
}
void MapHistItemC::setLnKey(int32_t v) {
	lnKey = v;
}
void MapHistItemC::setLnValue(int32_t v) {
	lnValue = v;
}
void MapHistItemC::setLnContentType(int32_t v) {
	lnContentType = v;
}
void MapHistItemC::setLnBlobData(int32_t v) {
	lnBlobData = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHistItemC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnHistGuid;
	ar & this->lnKey;
	ar & this->lnValue;
	if (version >= 1000000020000011) {
		ar & this->lnBlobData;
		ar & this->lnContentType;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1314989638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHistItemC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_240257308(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PMapHistItem > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapHistZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapHistZ::MapHistZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapHistZ::MapHistZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapHistZ::BSerializable_getTypeId() {
	return 1505340976; 
}
void MapHistZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapHistZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1505340976(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapHistZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1756288553(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PMapHist > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapItem
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapItem::MapItem() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapItem::MapItem(const ::std::wstring& id, const ::std::wstring& key, const ::std::wstring& value, const ::std::wstring& contentType, const PContentStream& blobData)
	: id(id)
	, key(key)
	, value(value)
	, contentType(contentType)
	, blobData(blobData)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapItem::BSerializable_getTypeId() {
	return 1461301521; 
}
void MapItem::setId(::std::wstring v) {
	id = v;
	setChangedMember(MapItemC::mbId);
}
void MapItem::setKey(::std::wstring v) {
	key = v;
	setChangedMember(MapItemC::mbKey);
}
void MapItem::setValue(::std::wstring v) {
	value = v;
	setChangedMember(MapItemC::mbValue);
}
void MapItem::setContentType(::std::wstring v) {
	contentType = v;
	setChangedMember(MapItemC::mbContentType);
}
void MapItem::setBlobData(PContentStream v) {
	blobData = v;
	setChangedMember(MapItemC::mbBlobData);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapItem::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->contentType;
	ar & this->id;
	ar & this->key;
	ar & this->value;
	if (version >= 1000000020000005) {
		ar & this->blobData;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1461301521(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapItem>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapItemC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapItemC::MapItemC() {
	lnId = 0;
	lnKey = 0;
	lnValue = 0;
	lnContentType = 0;
	lnBlobData = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapItemC::MapItemC(int64_t mbId, int32_t lnId, int64_t mbKey, int32_t lnKey, int64_t mbValue, int32_t lnValue, int64_t mbContentType, int32_t lnContentType, int64_t mbBlobData, int32_t lnBlobData, int64_t mbAllMembers)
	: lnId(lnId)
	, lnKey(lnKey)
	, lnValue(lnValue)
	, lnContentType(lnContentType)
	, lnBlobData(lnBlobData)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapItemC::BSerializable_getTypeId() {
	return 812006040; 
}
void MapItemC::setLnId(int32_t v) {
	lnId = v;
}
void MapItemC::setLnKey(int32_t v) {
	lnKey = v;
}
void MapItemC::setLnValue(int32_t v) {
	lnValue = v;
}
void MapItemC::setLnContentType(int32_t v) {
	lnContentType = v;
}
void MapItemC::setLnBlobData(int32_t v) {
	lnBlobData = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapItemC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnContentType;
	ar & this->lnId;
	ar & this->lnKey;
	ar & this->lnValue;
	if (version >= 1000000020000005) {
		ar & this->lnBlobData;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_812006040(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapItemC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MapValue
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MapValue::MapValue() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MapValue::MapValue(const PFileData& blobValue)
	: blobValue(blobValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MapValue::BSerializable_getTypeId() {
	return 408347242; 
}
void MapValue::setBlobValue(PFileData v) {
	blobValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MapValue::serialize(BIO& ar, const BVERSION version) {
	KeyValue::serialize(ar, version);
	ar & this->blobValue;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_408347242(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MapValue>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MaskName
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MaskName::MaskName() {
	documentMask = false;
	id = 0;
	searchMask = false;
	folderMask = false;
	access = 0;
	barcodeMask = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MaskName::MaskName(bool documentMask, int32_t id, const ::std::wstring& name, bool searchMask, bool folderMask, const ::std::wstring& guid, int32_t access, bool barcodeMask, const ::std::wstring& nameTranslationKey)
	: documentMask(documentMask)
	, id(id)
	, name(name)
	, searchMask(searchMask)
	, folderMask(folderMask)
	, guid(guid)
	, access(access)
	, barcodeMask(barcodeMask)
	, nameTranslationKey(nameTranslationKey)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MaskName::BSerializable_getTypeId() {
	return 458953805; 
}
void MaskName::setDocumentMask(bool v) {
	documentMask = v;
}
void MaskName::setId(int32_t v) {
	id = v;
}
void MaskName::setName(::std::wstring v) {
	name = v;
}
void MaskName::setSearchMask(bool v) {
	searchMask = v;
}
void MaskName::setFolderMask(bool v) {
	folderMask = v;
}
void MaskName::setGuid(::std::wstring v) {
	guid = v;
}
void MaskName::setAccess(int32_t v) {
	access = v;
}
void MaskName::setBarcodeMask(bool v) {
	barcodeMask = v;
}
void MaskName::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MaskName::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->documentMask;
	ar & this->id;
	ar & this->name;
	ar & this->searchMask;
	if (version >= 700000000000000) {
		ar & this->folderMask;
		if (version >= 700000000000004) {
			ar & this->guid;
			if (version >= 700000000000042) {
				ar & this->access;
				if (version >= 800000036000001) {
					ar & this->barcodeMask;
					if (version >= 900000022000007) {
						ar & this->nameTranslationKey;
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_458953805(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MaskName>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_248117584(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PMaskName > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class MoveDocumentsInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MoveDocumentsInfo::MoveDocumentsInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::MoveDocumentsInfo::MoveDocumentsInfo(const ::std::wstring& sourcePathId, const ::std::wstring& targetPathId, const ::std::wstring& startDate, const ::std::wstring& endDate)
	: sourcePathId(sourcePathId)
	, targetPathId(targetPathId)
	, startDate(startDate)
	, endDate(endDate)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::MoveDocumentsInfo::BSerializable_getTypeId() {
	return 2016315141; 
}
void MoveDocumentsInfo::setSourcePathId(::std::wstring v) {
	sourcePathId = v;
}
void MoveDocumentsInfo::setTargetPathId(::std::wstring v) {
	targetPathId = v;
}
void MoveDocumentsInfo::setStartDate(::std::wstring v) {
	startDate = v;
}
void MoveDocumentsInfo::setEndDate(::std::wstring v) {
	endDate = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MoveDocumentsInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->sourcePathId;
	ar & this->targetPathId;
	if (version >= 1000170059000005) {
		ar & this->endDate;
		ar & this->startDate;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2016315141(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::MoveDocumentsInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NavigationInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NavigationInfo::NavigationInfo() {
	ignoreDocuments = false;
	maxCount = 0;
	maxDepth = 0;
	maxSiblings = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NavigationInfo::NavigationInfo(bool ignoreDocuments, int32_t maxCount, int32_t maxDepth, int32_t maxSiblings, const PArrayString& startIDs, const PFindInfo& findInfo)
	: ignoreDocuments(ignoreDocuments)
	, maxCount(maxCount)
	, maxDepth(maxDepth)
	, maxSiblings(maxSiblings)
	, startIDs(startIDs)
	, findInfo(findInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NavigationInfo::BSerializable_getTypeId() {
	return 1953181452; 
}
void NavigationInfo::setIgnoreDocuments(bool v) {
	ignoreDocuments = v;
}
void NavigationInfo::setMaxCount(int32_t v) {
	maxCount = v;
}
void NavigationInfo::setMaxDepth(int32_t v) {
	maxDepth = v;
}
void NavigationInfo::setMaxSiblings(int32_t v) {
	maxSiblings = v;
}
void NavigationInfo::setStartIDs(PArrayString v) {
	startIDs = v;
}
void NavigationInfo::setFindInfo(PFindInfo v) {
	findInfo = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NavigationInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->ignoreDocuments;
	ar & this->maxCount;
	ar & this->maxDepth;
	ar & this->maxSiblings;
	ar & this->startIDs;
	if (version >= 900000014000007) {
		ar & this->findInfo;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1953181452(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NavigationInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NavigationInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NavigationInfoC::NavigationInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NavigationInfoC::BSerializable_getTypeId() {
	return 1520348158; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NavigationInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1520348158(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NavigationInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Note
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Note::Note() {
	XPos = 0;
	YPos = 0;
	height = 0;
	id = 0;
	ownerId = 0;
	pageNo = 0;
	type = 0;
	width = 0;
	deleted = false;
	lockId = 0;
	color = 0;
	access = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Note::Note(const ::std::wstring& TStamp, int32_t XPos, int32_t YPos, const ::std::wstring& desc, const ::std::wstring& guid, int32_t height, int32_t id, int32_t ownerId, int32_t pageNo, int32_t type, int32_t width, const ::std::wstring& createDateIso, bool deleted, int32_t lockId, const ::std::wstring& lockName, const ::std::wstring& objId, const ::std::wstring& ownerName, const ::std::wstring& acl, const PArrayAclItem& aclItems, int32_t color, const PNoteText& noteText, const PNoteImage& noteImage, const PNoteFreehand& noteFreehand, int32_t access, const ::std::wstring& deleteDateIso, const ::std::wstring& TStampSync)
	: TStamp(TStamp)
	, XPos(XPos)
	, YPos(YPos)
	, desc(desc)
	, guid(guid)
	, height(height)
	, id(id)
	, ownerId(ownerId)
	, pageNo(pageNo)
	, type(type)
	, width(width)
	, createDateIso(createDateIso)
	, deleted(deleted)
	, lockId(lockId)
	, lockName(lockName)
	, objId(objId)
	, ownerName(ownerName)
	, acl(acl)
	, aclItems(aclItems)
	, color(color)
	, noteText(noteText)
	, noteImage(noteImage)
	, noteFreehand(noteFreehand)
	, access(access)
	, deleteDateIso(deleteDateIso)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Note::BSerializable_getTypeId() {
	return 937420667; 
}
void Note::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(NoteC::mbTStamp);
}
void Note::setXPos(int32_t v) {
	XPos = v;
	setChangedMember(NoteC::mbXPos);
}
void Note::setYPos(int32_t v) {
	YPos = v;
	setChangedMember(NoteC::mbYPos);
}
void Note::setDesc(::std::wstring v) {
	desc = v;
	setChangedMember(NoteC::mbDesc);
}
void Note::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(NoteC::mbGuid);
}
void Note::setHeight(int32_t v) {
	height = v;
	setChangedMember(NoteC::mbHeight);
}
void Note::setId(int32_t v) {
	id = v;
	setChangedMember(NoteC::mbId);
}
void Note::setOwnerId(int32_t v) {
	ownerId = v;
	setChangedMember(NoteC::mbOwnerId);
}
void Note::setPageNo(int32_t v) {
	pageNo = v;
	setChangedMember(NoteC::mbPageNo);
}
void Note::setType(int32_t v) {
	type = v;
	setChangedMember(NoteC::mbType);
}
void Note::setWidth(int32_t v) {
	width = v;
	setChangedMember(NoteC::mbWidth);
}
void Note::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(NoteC::mbCreateDateIso);
}
void Note::setDeleted(bool v) {
	deleted = v;
	setChangedMember(NoteC::mbDeleted);
}
void Note::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(NoteC::mbLockId);
}
void Note::setLockName(::std::wstring v) {
	lockName = v;
}
void Note::setObjId(::std::wstring v) {
	objId = v;
	setChangedMember(NoteC::mbObjId);
}
void Note::setOwnerName(::std::wstring v) {
	ownerName = v;
}
void Note::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(NoteC::mbAclItems);
}
void Note::setAclItems(PArrayAclItem v) {
	aclItems = v;
	setChangedMember(NoteC::mbAclItems);
}
void Note::setColor(int32_t v) {
	color = v;
	setChangedMember(NoteC::mbColor);
}
void Note::setNoteText(PNoteText v) {
	noteText = v;
	setChangedMember(NoteC::mbNoteText);
}
void Note::setNoteImage(PNoteImage v) {
	noteImage = v;
	setChangedMember(NoteC::mbNoteImage);
}
void Note::setNoteFreehand(PNoteFreehand v) {
	noteFreehand = v;
	setChangedMember(NoteC::mbNoteFreehand);
}
void Note::setAccess(int32_t v) {
	access = v;
}
void Note::setDeleteDateIso(::std::wstring v) {
	deleteDateIso = v;
}
void Note::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(NoteC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Note::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->XPos;
	ar & this->YPos;
	ar & this->acl;
	ar & this->createDateIso;
	ar & this->deleted;
	ar & this->desc;
	ar & this->guid;
	ar & this->height;
	ar & this->id;
	ar & this->lockId;
	ar & this->lockName;
	ar & this->objId;
	ar & this->ownerId;
	ar & this->ownerName;
	ar & this->pageNo;
	ar & this->type;
	ar & this->width;
	if (version >= 600000087000000) {
		ar & this->color;
		if (version >= 700000000000026) {
			ar & this->access;
			if (version >= 900000000000000) {
				ar & this->deleteDateIso;
				if (version >= 900990009000001) {
					ar & this->TStampSync;
				}
			}
		}
	}
	ar & this->aclItems;
	if (version >= 700000000000023) {
		ar & this->noteFreehand;
		ar & this->noteImage;
		ar & this->noteText;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_937420667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Note>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteDataC::NoteDataC() {
	lnDesc = 0;
	lnGuid = 0;
	lnTStamp = 0;
	lnAcl = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteDataC::NoteDataC(int64_t mbId, int64_t mbParentId, int64_t mbPageNo, int64_t mbXPos, int64_t mbYPos, int64_t mbOwnerId, int64_t mbType, int64_t mbHLock, int64_t mbCreateDate, int64_t mbDesc, int32_t lnDesc, int64_t mbGuid, int32_t lnGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbStatus, int64_t mbWidth, int64_t mbHeight, int64_t mbAcl, int32_t lnAcl, int64_t mbColor, int64_t mbDeleteDate, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnDesc(lnDesc)
	, lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnAcl(lnAcl)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteDataC::BSerializable_getTypeId() {
	return 1521483547; 
}
void NoteDataC::setLnDesc(int32_t v) {
	lnDesc = v;
}
void NoteDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void NoteDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void NoteDataC::setLnAcl(int32_t v) {
	lnAcl = v;
}
void NoteDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnAcl;
	ar & this->lnDesc;
	ar & this->lnGuid;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1521483547(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteC
// Generated from class byps.gen.cpp.GenApiClass

const PNoteZ NoteC::mbAll = PNoteZ(new NoteZ(
	524287LL));

const PNoteZ NoteC::mbNoDesc = PNoteZ(new NoteZ(
	523775LL));

const PNoteZ NoteC::mbOnlyLock = PNoteZ(new NoteZ(
	0LL));

// checkpoint byps.gen.cpp.GenApiClass:489
NoteC::NoteC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteC::BSerializable_getTypeId() {
	return 1319955249; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteC::serialize(BIO& ar, const BVERSION version) {
	NoteDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1319955249(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteFreehand
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteFreehand::NoteFreehand() {
	width = 0;
	strikeoutWidth = 0;
	strikeoutColor = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteFreehand::NoteFreehand(int32_t width, const PArrayPointInfo& points, int32_t strikeoutWidth, int32_t strikeoutColor)
	: width(width)
	, points(points)
	, strikeoutWidth(strikeoutWidth)
	, strikeoutColor(strikeoutColor)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteFreehand::BSerializable_getTypeId() {
	return 611837980; 
}
void NoteFreehand::setWidth(int32_t v) {
	width = v;
}
void NoteFreehand::setPoints(PArrayPointInfo v) {
	points = v;
}
void NoteFreehand::setStrikeoutWidth(int32_t v) {
	strikeoutWidth = v;
}
void NoteFreehand::setStrikeoutColor(int32_t v) {
	strikeoutColor = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteFreehand::serialize(BIO& ar, const BVERSION version) {
	ar & this->width;
	if (version >= 700000000000039) {
		ar & this->strikeoutColor;
		ar & this->strikeoutWidth;
	}
	ar & this->points;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_611837980(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteFreehand>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteFreehandC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteFreehandC::NoteFreehandC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteFreehandC::BSerializable_getTypeId() {
	return 1034219603; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteFreehandC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1034219603(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteFreehandC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteImage
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteImage::NoteImage() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteImage::NoteImage(const ::std::wstring& fileName, const PFileData& fileData)
	: fileName(fileName)
	, fileData(fileData)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteImage::BSerializable_getTypeId() {
	return 1753613701; 
}
void NoteImage::setFileName(::std::wstring v) {
	fileName = v;
}
void NoteImage::setFileData(PFileData v) {
	fileData = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteImage::serialize(BIO& ar, const BVERSION version) {
	ar & this->fileName;
	ar & this->fileData;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1753613701(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteImage>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteTemplate
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteTemplate::NoteTemplate() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteTemplate::NoteTemplate(int32_t id, const ::std::wstring& name, const ::std::wstring& userId, const PNoteText& noteText, const PNoteImage& noteImage, const ::std::wstring& acl, const PArrayAclItem& aclItems)
	: id(id)
	, name(name)
	, userId(userId)
	, noteText(noteText)
	, noteImage(noteImage)
	, acl(acl)
	, aclItems(aclItems)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteTemplate::BSerializable_getTypeId() {
	return 1995912373; 
}
void NoteTemplate::setId(int32_t v) {
	id = v;
	setChangedMember(NoteTemplateC::mbId);
}
void NoteTemplate::setName(::std::wstring v) {
	name = v;
	setChangedMember(NoteTemplateC::mbName);
}
void NoteTemplate::setUserId(::std::wstring v) {
	userId = v;
	setChangedMember(NoteTemplateC::mbUserId);
}
void NoteTemplate::setNoteText(PNoteText v) {
	noteText = v;
	setChangedMember(NoteTemplateC::mbNoteText);
}
void NoteTemplate::setNoteImage(PNoteImage v) {
	noteImage = v;
	setChangedMember(NoteTemplateC::mbNoteImage);
}
void NoteTemplate::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(NoteTemplateC::mbAcl);
}
void NoteTemplate::setAclItems(PArrayAclItem v) {
	aclItems = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteTemplate::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->name;
	ar & this->userId;
	if (version >= 700000000000040) {
		ar & this->acl;
	}
	ar & this->noteImage;
	ar & this->noteText;
	if (version >= 700000000000040) {
		ar & this->aclItems;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1995912373(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteTemplate>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteTemplateC
// Generated from class byps.gen.cpp.GenApiClass

const PNoteTemplateZ NoteTemplateC::mbMin = PNoteTemplateZ(new NoteTemplateZ(
	1LL));

const PNoteTemplateZ NoteTemplateC::mbAll = PNoteTemplateZ(new NoteTemplateZ(
	63LL));

const ::std::wstring NoteTemplateC::PLACEHOLDER_USERNAME = std::wstring(L"%u");

const ::std::wstring NoteTemplateC::PLACEHOLDER_DATE = std::wstring(L"%x");

const ::std::wstring NoteTemplateC::PLACEHOLDER_TIME = std::wstring(L"%X");

const ::std::wstring NoteTemplateC::USERID_ALL = std::wstring(L"2147483647");

const ::std::wstring NoteTemplateC::RAW_ITEM_SEPARATOR = std::wstring(L"\u00c3\u00bd\u00c3\u00bd\u00c3\u00bd");

const ::std::wstring NoteTemplateC::RAW_SUBITEM_SEPARATOR = std::wstring(L",");

const ::std::wstring NoteTemplateC::RAW_STAMPINFO_SEPARATOR = std::wstring(L"(,)");

// checkpoint byps.gen.cpp.GenApiClass:489
NoteTemplateC::NoteTemplateC() {
	lnName = 0;
	lnText = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteTemplateC::NoteTemplateC(int64_t mbId, int64_t mbName, int64_t mbUserId, int64_t mbNoteText, int64_t mbNoteImage, int64_t mbAcl, int64_t mbAllMembers, const PNoteTemplateZ& mbMin, const PNoteTemplateZ& mbAll, const ::std::wstring& PLACEHOLDER_USERNAME, const ::std::wstring& PLACEHOLDER_DATE, const ::std::wstring& PLACEHOLDER_TIME, const ::std::wstring& USERID_ALL, const ::std::wstring& RAW_ITEM_SEPARATOR, const ::std::wstring& RAW_SUBITEM_SEPARATOR, const ::std::wstring& RAW_STAMPINFO_SEPARATOR, int32_t lnName, int32_t lnText)
	: lnName(lnName)
	, lnText(lnText)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteTemplateC::BSerializable_getTypeId() {
	return 240897408; 
}
void NoteTemplateC::setLnName(int32_t v) {
	lnName = v;
}
void NoteTemplateC::setLnText(int32_t v) {
	lnText = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteTemplateC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnName;
	ar & this->lnText;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_240897408(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteTemplateC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteTemplateDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteTemplateDataC::NoteTemplateDataC() {
	lnOptKey = 0;
	lnOptValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteTemplateDataC::NoteTemplateDataC(int64_t mbUserIdInt, int64_t mbOptKey, int32_t lnOptKey, int64_t mbOptValue, int32_t lnOptValue, int64_t mbAllMembers)
	: lnOptKey(lnOptKey)
	, lnOptValue(lnOptValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteTemplateDataC::BSerializable_getTypeId() {
	return 1775437403; 
}
void NoteTemplateDataC::setLnOptKey(int32_t v) {
	lnOptKey = v;
}
void NoteTemplateDataC::setLnOptValue(int32_t v) {
	lnOptValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteTemplateDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnOptKey;
	ar & this->lnOptValue;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1775437403(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteTemplateDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteTemplateZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteTemplateZ::NoteTemplateZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteTemplateZ::NoteTemplateZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteTemplateZ::BSerializable_getTypeId() {
	return 1483878971; 
}
void NoteTemplateZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteTemplateZ::serialize(BIO& ar, const BVERSION version) {
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1483878971(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteTemplateZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1443841819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PNoteTemplate > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteText
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteText::NoteText() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteText::NoteText(const PFontInfo& fontInfo, const ::std::wstring& text)
	: fontInfo(fontInfo)
	, text(text)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteText::BSerializable_getTypeId() {
	return 669464920; 
}
void NoteText::setFontInfo(PFontInfo v) {
	fontInfo = v;
}
void NoteText::setText(::std::wstring v) {
	text = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteText::serialize(BIO& ar, const BVERSION version) {
	ar & this->text;
	ar & this->fontInfo;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_669464920(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteText>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NoteZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NoteZ::NoteZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NoteZ::NoteZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NoteZ::BSerializable_getTypeId() {
	return 2137405429; 
}
void NoteZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NoteZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2137405429(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NoteZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_776454091(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PNote > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Notification
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Notification::Notification() {
	prio = 0;
	what = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Notification::Notification(const ::std::wstring& userGuid, const ::std::wstring& watchGuid, const ::std::wstring& createDateIso, int32_t prio, int32_t what)
	: userGuid(userGuid)
	, watchGuid(watchGuid)
	, createDateIso(createDateIso)
	, prio(prio)
	, what(what)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Notification::BSerializable_getTypeId() {
	return 494610451; 
}
void Notification::setUserGuid(::std::wstring v) {
	userGuid = v;
	setChangedMember(NotificationC::mbUserGuid);
}
void Notification::setWatchGuid(::std::wstring v) {
	watchGuid = v;
	setChangedMember(NotificationC::mbWatchGuid);
}
void Notification::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(NotificationC::mbCreateDateIso);
}
void Notification::setPrio(int32_t v) {
	prio = v;
	setChangedMember(NotificationC::mbPrio);
}
void Notification::setWhat(int32_t v) {
	what = v;
	setChangedMember(NotificationC::mbWhat);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Notification::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->createDateIso;
	ar & this->userGuid;
	ar & this->watchGuid;
	if (version >= 900000022000003) {
		ar & this->prio;
		if (version >= 900000030000001) {
			ar & this->what;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_494610451(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Notification>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NotificationDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NotificationDataC::NotificationDataC() {
	lnUserGuid = 0;
	lnWatchGuid = 0;
	lnCreateDateIso = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NotificationDataC::NotificationDataC(int64_t mbUserGuid, int32_t lnUserGuid, int64_t mbWatchGuid, int32_t lnWatchGuid, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbPrio, int64_t mbWhat, int64_t mbAllMembers)
	: lnUserGuid(lnUserGuid)
	, lnWatchGuid(lnWatchGuid)
	, lnCreateDateIso(lnCreateDateIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NotificationDataC::BSerializable_getTypeId() {
	return 2010056196; 
}
void NotificationDataC::setLnUserGuid(int32_t v) {
	lnUserGuid = v;
}
void NotificationDataC::setLnWatchGuid(int32_t v) {
	lnWatchGuid = v;
}
void NotificationDataC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NotificationDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCreateDateIso;
	ar & this->lnUserGuid;
	ar & this->lnWatchGuid;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2010056196(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NotificationDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NotificationC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NotificationC::NotificationC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NotificationC::BSerializable_getTypeId() {
	return 1070921523; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NotificationC::serialize(BIO& ar, const BVERSION version) {
	NotificationDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1070921523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NotificationC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NotificationZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NotificationZ::NotificationZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NotificationZ::NotificationZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NotificationZ::BSerializable_getTypeId() {
	return 1624160439; 
}
void NotificationZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NotificationZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1624160439(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NotificationZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NotifyServerInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NotifyServerInfo::NotifyServerInfo() {
	scanCount = 0;
	ocrCount = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::NotifyServerInfo::NotifyServerInfo(int32_t scanCount, int32_t ocrCount)
	: scanCount(scanCount)
	, ocrCount(ocrCount)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NotifyServerInfo::BSerializable_getTypeId() {
	return 539899885; 
}
void NotifyServerInfo::setScanCount(int32_t v) {
	scanCount = v;
}
void NotifyServerInfo::setOcrCount(int32_t v) {
	ocrCount = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NotifyServerInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->ocrCount;
	ar & this->scanCount;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_539899885(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NotifyServerInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class NotifyServerResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
NotifyServerResult::NotifyServerResult() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::NotifyServerResult::BSerializable_getTypeId() {
	return 810727301; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void NotifyServerResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_810727301(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::NotifyServerResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjChange
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjChange::ObjChange() {
	code = 0;
	param = 0;
	user = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjChange::ObjChange(const ::std::wstring& objId, const ::std::wstring& tStamp, int32_t code, int32_t param, const ::std::wstring& param2, int32_t user)
	: objId(objId)
	, tStamp(tStamp)
	, code(code)
	, param(param)
	, param2(param2)
	, user(user)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjChange::BSerializable_getTypeId() {
	return 753146; 
}
void ObjChange::setObjId(::std::wstring v) {
	objId = v;
	setChangedMember(ObjChangeC::mbObjId);
}
void ObjChange::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(ObjChangeC::mbTStamp);
}
void ObjChange::setCode(int32_t v) {
	code = v;
	setChangedMember(ObjChangeC::mbCode);
}
void ObjChange::setParam(int32_t v) {
	param = v;
	setChangedMember(ObjChangeC::mbParam);
}
void ObjChange::setParam2(::std::wstring v) {
	param2 = v;
	setChangedMember(ObjChangeC::mbParam2);
}
void ObjChange::setUser(int32_t v) {
	user = v;
	setChangedMember(ObjChangeC::mbUser);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjChange::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->code;
	ar & this->objId;
	ar & this->param;
	ar & this->param2;
	ar & this->tStamp;
	ar & this->user;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_753146(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjChange>(bio, pObj, pObjS, pBase);	
}
}}}}

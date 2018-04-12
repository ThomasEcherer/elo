#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagRelation
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagRelation::HashTagRelation() {
	status = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::HashTagRelation::HashTagRelation(const ::std::wstring& hashtagGuid, const ::std::wstring& actionGuid, const ::std::wstring& tStamp, int32_t status)
	: hashtagGuid(hashtagGuid)
	, actionGuid(actionGuid)
	, tStamp(tStamp)
	, status(status)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagRelation::BSerializable_getTypeId() {
	return 1313473584; 
}
void HashTagRelation::setHashtagGuid(::std::wstring v) {
	hashtagGuid = v;
	setChangedMember(HashTagRelationC::mbHashtagGuid);
}
void HashTagRelation::setActionGuid(::std::wstring v) {
	actionGuid = v;
	setChangedMember(HashTagRelationC::mbActionGuid);
}
void HashTagRelation::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(HashTagRelationC::mbTStamp);
}
void HashTagRelation::setStatus(int32_t v) {
	status = v;
	setChangedMember(HashTagRelationC::mbStatus);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagRelation::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->actionGuid;
	ar & this->hashtagGuid;
	ar & this->status;
	ar & this->tStamp;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1313473584(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagRelation>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagRelationDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagRelationDataC::HashTagRelationDataC() {
	lnHashtagGuid = 0;
	lnActionGuid = 0;
	lnTStamp = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::HashTagRelationDataC::HashTagRelationDataC(int64_t mbHashtagGuid, int32_t lnHashtagGuid, int64_t mbActionGuid, int32_t lnActionGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbStatus, int64_t mbAllMembers)
	: lnHashtagGuid(lnHashtagGuid)
	, lnActionGuid(lnActionGuid)
	, lnTStamp(lnTStamp)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagRelationDataC::BSerializable_getTypeId() {
	return 2035445347; 
}
void HashTagRelationDataC::setLnHashtagGuid(int32_t v) {
	lnHashtagGuid = v;
}
void HashTagRelationDataC::setLnActionGuid(int32_t v) {
	lnActionGuid = v;
}
void HashTagRelationDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagRelationDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnActionGuid;
	ar & this->lnHashtagGuid;
	ar & this->lnTStamp;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2035445347(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagRelationDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagRelationC
// Generated from class byps.gen.cpp.GenApiClass

const PHashTagRelationZ HashTagRelationC::mbAll = PHashTagRelationZ(new HashTagRelationZ(
	15LL));

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagRelationC::HashTagRelationC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagRelationC::BSerializable_getTypeId() {
	return 747134350; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagRelationC::serialize(BIO& ar, const BVERSION version) {
	HashTagRelationDataC::serialize(ar, version);
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_747134350(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagRelationC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagRelationZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagRelationZ::HashTagRelationZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::HashTagRelationZ::HashTagRelationZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagRelationZ::BSerializable_getTypeId() {
	return 509234307; 
}
void HashTagRelationZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagRelationZ::serialize(BIO& ar, const BVERSION version) {
	ar & this->bset;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_509234307(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagRelationZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagZ::HashTagZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::HashTagZ::HashTagZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagZ::BSerializable_getTypeId() {
	return 1664941037; 
}
void HashTagZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagZ::serialize(BIO& ar, const BVERSION version) {
	ar & this->bset;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1664941037(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_computeDoubleValue
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_computeDoubleValue::BRequest_HealthCheckService_computeDoubleValue() : BMethodRequest(969424915) {
	doubleValue = 0;
	operation = de::elo::ix::client::health::HealthCheckValueOperation::UPDATE_VALUE;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_computeDoubleValue::BRequest_HealthCheckService_computeDoubleValue(const ::std::wstring& name, double doubleValue, HealthCheckValueOperation operation)
	: BMethodRequest(969424915) 
	, name(name)
	, doubleValue(doubleValue)
	, operation(operation)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_computeDoubleValue::BSerializable_getTypeId() {
	return 1919177848; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_computeDoubleValue::serialize(BIO& ar, const BVERSION version) {
	ar & this->doubleValue;
	ar & this->name;
	ar & this->operation;
	ar & this->ci;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_computeDoubleValue::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->computeDoubleValue(ci, name, doubleValue, operation, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_computeDoubleValue::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1919177848(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_computeDoubleValue>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_read
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_read::BRequest_HealthCheckService_read() : BMethodRequest(969424915) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_read::BRequest_HealthCheckService_read(const byps::PVectorString& names)
	: BMethodRequest(969424915) 
	, names(names)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_read::BSerializable_getTypeId() {
	return 771256331; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_read::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->names;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_read::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->read(ci, names, [__byps__asyncResult](PHealthCheckInfos __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_333475674(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_read::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_771256331(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_read>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_update
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_update::BRequest_HealthCheckService_update() : BMethodRequest(969424915) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_update::BRequest_HealthCheckService_update(const PHealthCheckInfo& hci)
	: BMethodRequest(969424915) 
	, hci(hci)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_update::BSerializable_getTypeId() {
	return 1948144488; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_update::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->hci;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_update::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->update(ci, hci, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_update::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1948144488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_update>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_updateAll
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_updateAll::BRequest_HealthCheckService_updateAll() : BMethodRequest(969424915) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_updateAll::BRequest_HealthCheckService_updateAll(const PVectorHealthCheckInfo& hcis)
	: BMethodRequest(969424915) 
	, hcis(hcis)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_updateAll::BSerializable_getTypeId() {
	return 720562919; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_updateAll::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->hcis;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_updateAll::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->updateAll(ci, hcis, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_updateAll::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_720562919(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_updateAll>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_updateDoubleValue
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_updateDoubleValue::BRequest_HealthCheckService_updateDoubleValue() : BMethodRequest(969424915) {
	doubleValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_updateDoubleValue::BRequest_HealthCheckService_updateDoubleValue(const ::std::wstring& name, double doubleValue)
	: BMethodRequest(969424915) 
	, name(name)
	, doubleValue(doubleValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_updateDoubleValue::BSerializable_getTypeId() {
	return 677413784; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_updateDoubleValue::serialize(BIO& ar, const BVERSION version) {
	ar & this->doubleValue;
	ar & this->name;
	ar & this->ci;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_updateDoubleValue::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->updateDoubleValue(ci, name, doubleValue, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_updateDoubleValue::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_677413784(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_updateDoubleValue>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_updateMeanValue
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_updateMeanValue::BRequest_HealthCheckService_updateMeanValue() : BMethodRequest(969424915) {
	meanValue = 0;
	sampleSize = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_updateMeanValue::BRequest_HealthCheckService_updateMeanValue(const ::std::wstring& name, double meanValue, int64_t sampleSize)
	: BMethodRequest(969424915) 
	, name(name)
	, meanValue(meanValue)
	, sampleSize(sampleSize)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_updateMeanValue::BSerializable_getTypeId() {
	return 1150533084; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_updateMeanValue::serialize(BIO& ar, const BVERSION version) {
	ar & this->meanValue;
	ar & this->name;
	ar & this->sampleSize;
	ar & this->ci;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_updateMeanValue::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->updateMeanValue(ci, name, meanValue, sampleSize, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_updateMeanValue::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1150533084(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_updateMeanValue>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class BRequest_HealthCheckService_uploadAll
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_HealthCheckService_uploadAll::BRequest_HealthCheckService_uploadAll() : BMethodRequest(969424915) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::BRequest_HealthCheckService_uploadAll::BRequest_HealthCheckService_uploadAll(const PSerializable& reserved)
	: BMethodRequest(969424915) 
	, reserved(reserved)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BRequest_HealthCheckService_uploadAll::BSerializable_getTypeId() {
	return 1827236639; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_HealthCheckService_uploadAll::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->reserved;
}
void de::elo::ix::client::health::BRequest_HealthCheckService_uploadAll::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PHealthCheckService __byps__remoteT = byps_ptr_cast<HealthCheckService>(__byps__remote);
	__byps__remoteT->uploadAll(ci, reserved, [__byps__asyncResult](PSerializable __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_21(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::health::BRequest_HealthCheckService_uploadAll::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1827236639(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::BRequest_HealthCheckService_uploadAll>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class HealthCheckInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HealthCheckInfo::HealthCheckInfo() {
	doubleValue = 0;
	sampleSize = 0;
	operation = de::elo::ix::client::health::HealthCheckValueOperation::UPDATE_VALUE;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::HealthCheckInfo::HealthCheckInfo(const ::std::wstring& name, const ::std::wstring& stringValue, double doubleValue, int64_t sampleSize, HealthCheckValueOperation operation)
	: name(name)
	, stringValue(stringValue)
	, doubleValue(doubleValue)
	, sampleSize(sampleSize)
	, operation(operation)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::HealthCheckInfo::BSerializable_getTypeId() {
	return 585951890; 
}
void HealthCheckInfo::setName(::std::wstring v) {
	name = v;
	setChangedMember(HealthCheckInfoC::mbName);
}
void HealthCheckInfo::setStringValue(::std::wstring v) {
	stringValue = v;
	setChangedMember(HealthCheckInfoC::mbStringValue);
}
void HealthCheckInfo::setDoubleValue(double v) {
	doubleValue = v;
	setChangedMember(HealthCheckInfoC::mbDoubleValue);
}
void HealthCheckInfo::setSampleSize(int64_t v) {
	sampleSize = v;
	setChangedMember(HealthCheckInfoC::mbSampleSize);
}
void HealthCheckInfo::setOperation(HealthCheckValueOperation v) {
	operation = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HealthCheckInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->doubleValue;
	ar & this->name;
	ar & this->sampleSize;
	ar & this->stringValue;
	if (version >= 1000000020000016) {
		ar & this->operation;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_585951890(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::HealthCheckInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class HealthCheckInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HealthCheckInfoC::HealthCheckInfoC() {
	lnName = 0;
	lnStringValue = 0;
	lnDoubleValue = 0;
	lnSampleSize = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::HealthCheckInfoC::HealthCheckInfoC(int64_t mbName, int32_t lnName, int64_t mbStringValue, int32_t lnStringValue, int64_t mbDoubleValue, int32_t lnDoubleValue, int64_t mbSampleSize, int32_t lnSampleSize, int64_t mbAllMembers)
	: lnName(lnName)
	, lnStringValue(lnStringValue)
	, lnDoubleValue(lnDoubleValue)
	, lnSampleSize(lnSampleSize)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::HealthCheckInfoC::BSerializable_getTypeId() {
	return 526645641; 
}
void HealthCheckInfoC::setLnName(int32_t v) {
	lnName = v;
}
void HealthCheckInfoC::setLnStringValue(int32_t v) {
	lnStringValue = v;
}
void HealthCheckInfoC::setLnDoubleValue(int32_t v) {
	lnDoubleValue = v;
}
void HealthCheckInfoC::setLnSampleSize(int32_t v) {
	lnSampleSize = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HealthCheckInfoC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnDoubleValue;
	ar & this->lnName;
	ar & this->lnSampleSize;
	ar & this->lnStringValue;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_526645641(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::HealthCheckInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class HealthCheckInfos
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HealthCheckInfos::HealthCheckInfos() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::health::HealthCheckInfos::HealthCheckInfos(const PVectorHealthCheckInfo& infos, const ::std::wstring& archiveGuid, const ::std::wstring& customerLicenseKeyHash)
	: infos(infos)
	, archiveGuid(archiveGuid)
	, customerLicenseKeyHash(customerLicenseKeyHash)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::HealthCheckInfos::BSerializable_getTypeId() {
	return 333475674; 
}
void HealthCheckInfos::setInfos(PVectorHealthCheckInfo v) {
	infos = v;
}
void HealthCheckInfos::setArchiveGuid(::std::wstring v) {
	archiveGuid = v;
}
void HealthCheckInfos::setCustomerLicenseKeyHash(::std::wstring v) {
	customerLicenseKeyHash = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HealthCheckInfos::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->archiveGuid;
	ar & this->customerLicenseKeyHash;
	ar & this->infos;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_333475674(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::HealthCheckInfos>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 

//-------------------------------------------------
// Implementation of class HealthCheckValueNameC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring HealthCheckValueNameC::DYNAMIC = std::wstring(L"elo.archive.dynamic.");

const ::std::wstring HealthCheckValueNameC::NB_OF_DOCUMENTS = std::wstring(L"elo.archive.dynamic.nbOfDocuments");

const ::std::wstring HealthCheckValueNameC::NB_OF_DOCUMENT_FILES = std::wstring(L"elo.archive.dynamic.nbOfDocumentFiles");

const ::std::wstring HealthCheckValueNameC::TOTAL_SIZE_OF_DOCUMENT_FILES = std::wstring(L"elo.archive.dynamic.totalSizeOfDocumentFiles");

const ::std::wstring HealthCheckValueNameC::NB_OF_DOCUMENT_FILES_WITH_BACKUP = std::wstring(L"elo.archive.dynamic.nbOfDocumentFilesWithBackup");

const ::std::wstring HealthCheckValueNameC::NB_OF_DOCUMENT_FILES_WITHOUT_BACKUP = std::wstring(L"elo.archive.dynamic.nbOfDocumentFilesWithoutBackup");

const ::std::wstring HealthCheckValueNameC::NB_OF_FAILED_LOGINS = std::wstring(L"elo.nbOfFailedLogins");

// checkpoint byps.gen.cpp.GenApiClass:489
HealthCheckValueNameC::HealthCheckValueNameC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::HealthCheckValueNameC::BSerializable_getTypeId() {
	return 2106201675; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HealthCheckValueNameC::serialize(BIO& ar, const BVERSION version) {
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2106201675(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::health::HealthCheckValueNameC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

//-------------------------------------------------
// Implementation of class BRequest_MyELOService_checkState
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_MyELOService_checkState::BRequest_MyELOService_checkState() : BMethodRequest(1063633807) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::myelo::BRequest_MyELOService_checkState::BRequest_MyELOService_checkState(const ::std::wstring& userGuidOrID, const ::std::wstring& sinceDateIso)
	: BMethodRequest(1063633807) 
	, userGuidOrID(userGuidOrID)
	, sinceDateIso(sinceDateIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::myelo::BRequest_MyELOService_checkState::BSerializable_getTypeId() {
	return 2068722874; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_MyELOService_checkState::serialize(BIO& ar, const BVERSION version) {
	ar & this->sinceDateIso;
	ar & this->userGuidOrID;
	ar & this->ci;
}
void de::elo::ix::client::myelo::BRequest_MyELOService_checkState::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PMyELOService __byps__remoteT = byps_ptr_cast<MyELOService>(__byps__remote);
	__byps__remoteT->checkState(ci, userGuidOrID, sinceDateIso, [__byps__asyncResult](PMyELOState __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1426941339(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::myelo::BRequest_MyELOService_checkState::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2068722874(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::myelo::BRequest_MyELOService_checkState>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

//-------------------------------------------------
// Implementation of class BRequest_MyELOService_readContent
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_MyELOService_readContent::BRequest_MyELOService_readContent() : BMethodRequest(1063633807) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::myelo::BRequest_MyELOService_readContent::BRequest_MyELOService_readContent(const PMyELOState& state, const PMyELOInfo& info)
	: BMethodRequest(1063633807) 
	, state(state)
	, info(info)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::myelo::BRequest_MyELOService_readContent::BSerializable_getTypeId() {
	return 261913914; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_MyELOService_readContent::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->info;
	ar & this->state;
}
void de::elo::ix::client::myelo::BRequest_MyELOService_readContent::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PMyELOService __byps__remoteT = byps_ptr_cast<MyELOService>(__byps__remote);
	__byps__remoteT->readContent(ci, state, info, [__byps__asyncResult](PMyELOContent __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1585309177(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::myelo::BRequest_MyELOService_readContent::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_261913914(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::myelo::BRequest_MyELOService_readContent>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

//-------------------------------------------------
// Implementation of class MyELOContent
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MyELOContent::MyELOContent() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::myelo::MyELOContent::MyELOContent(const de::elo::ix::client::PArrayWFDiagram& workflows, const de::elo::ix::client::PArrayUserTask& tasks, const de::elo::ix::client::PArraySord& sords, const de::elo::ix::client::feed::PArrayAction& actions, const de::elo::ix::client::feed::PMapStringFeed& feeds, const de::elo::ix::client::PMapStringSubscription& subscriptions, const de::elo::ix::client::PMapStringNotification& notifications, const de::elo::ix::client::feed::PVectorHashTagRelation& hashTagRelations, const de::elo::ix::client::feed::PMapStringHashTag& hashTags)
	: workflows(workflows)
	, tasks(tasks)
	, sords(sords)
	, actions(actions)
	, feeds(feeds)
	, subscriptions(subscriptions)
	, notifications(notifications)
	, hashTagRelations(hashTagRelations)
	, hashTags(hashTags)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::myelo::MyELOContent::BSerializable_getTypeId() {
	return 1585309177; 
}
void MyELOContent::setWorkflows(de::elo::ix::client::PArrayWFDiagram v) {
	workflows = v;
}
void MyELOContent::setTasks(de::elo::ix::client::PArrayUserTask v) {
	tasks = v;
}
void MyELOContent::setSords(de::elo::ix::client::PArraySord v) {
	sords = v;
}
void MyELOContent::setActions(de::elo::ix::client::feed::PArrayAction v) {
	actions = v;
}
void MyELOContent::setFeeds(de::elo::ix::client::feed::PMapStringFeed v) {
	feeds = v;
}
void MyELOContent::setSubscriptions(de::elo::ix::client::PMapStringSubscription v) {
	subscriptions = v;
}
void MyELOContent::setNotifications(de::elo::ix::client::PMapStringNotification v) {
	notifications = v;
}
void MyELOContent::setHashTagRelations(de::elo::ix::client::feed::PVectorHashTagRelation v) {
	hashTagRelations = v;
}
void MyELOContent::setHashTags(de::elo::ix::client::feed::PMapStringHashTag v) {
	hashTags = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MyELOContent::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->actions;
	ar & this->feeds;
	ar & this->hashTagRelations;
	ar & this->hashTags;
	ar & this->notifications;
	ar & this->sords;
	ar & this->subscriptions;
	ar & this->tasks;
	ar & this->workflows;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1585309177(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::myelo::MyELOContent>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

//-------------------------------------------------
// Implementation of class MyELOInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MyELOInfo::MyELOInfo() {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::myelo::MyELOInfo::MyELOInfo(const de::elo::ix::client::feed::PFindNotificationInfo& notificationInfo, const de::elo::ix::client::PFindWorkflowInfo& workflowInfo, const de::elo::ix::client::PFindTasksInfo& taskInfo, const ::std::wstring& date, int32_t max)
	: notificationInfo(notificationInfo)
	, workflowInfo(workflowInfo)
	, taskInfo(taskInfo)
	, date(date)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::myelo::MyELOInfo::BSerializable_getTypeId() {
	return 455864090; 
}
void MyELOInfo::setNotificationInfo(de::elo::ix::client::feed::PFindNotificationInfo v) {
	notificationInfo = v;
}
void MyELOInfo::setWorkflowInfo(de::elo::ix::client::PFindWorkflowInfo v) {
	workflowInfo = v;
}
void MyELOInfo::setTaskInfo(de::elo::ix::client::PFindTasksInfo v) {
	taskInfo = v;
}
void MyELOInfo::setDate(::std::wstring v) {
	date = v;
}
void MyELOInfo::setMax(int32_t v) {
	max = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MyELOInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->date;
	if (version >= 1000000020000002) {
		ar & this->max;
	}
	ar & this->notificationInfo;
	ar & this->taskInfo;
	ar & this->workflowInfo;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_455864090(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::myelo::MyELOInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

//-------------------------------------------------
// Implementation of class MyELOState
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
MyELOState::MyELOState() {
	newFeed = false;
	newWorkflow = false;
	newTask = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::myelo::MyELOState::MyELOState(const ::std::wstring& userGuid, bool newFeed, bool newWorkflow, bool newTask)
	: userGuid(userGuid)
	, newFeed(newFeed)
	, newWorkflow(newWorkflow)
	, newTask(newTask)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::myelo::MyELOState::BSerializable_getTypeId() {
	return 1426941339; 
}
void MyELOState::setUserGuid(::std::wstring v) {
	userGuid = v;
}
void MyELOState::setNewFeed(bool v) {
	newFeed = v;
}
void MyELOState::setNewWorkflow(bool v) {
	newWorkflow = v;
}
void MyELOState::setNewTask(bool v) {
	newTask = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void MyELOState::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->newFeed;
	ar & this->newTask;
	ar & this->newWorkflow;
	ar & this->userGuid;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1426941339(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::myelo::MyELOState>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace notify { 

//-------------------------------------------------
// Implementation of class BRequest_ClientNotification_adminMode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_ClientNotification_adminMode::BRequest_ClientNotification_adminMode() : BMethodRequest(2104055021) {
	mode = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::notify::BRequest_ClientNotification_adminMode::BRequest_ClientNotification_adminMode(const de::elo::ix::client::PClientInfo& ci, int32_t mode)
	: BMethodRequest(2104055021) 
	, ci(ci)
	, mode(mode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::notify::BRequest_ClientNotification_adminMode::BSerializable_getTypeId() {
	return 475567923; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_ClientNotification_adminMode::serialize(BIO& ar, const BVERSION version) {
	ar & this->mode;
	ar & this->ci;
}
void de::elo::ix::client::notify::BRequest_ClientNotification_adminMode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PClientNotification __byps__remoteT = byps_ptr_cast<ClientNotification>(__byps__remote);
	__byps__remoteT->adminMode(ci, mode, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_475567923(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::notify::BRequest_ClientNotification_adminMode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace notify { 

//-------------------------------------------------
// Implementation of class BRequest_ClientNotification_updateTask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_ClientNotification_updateTask::BRequest_ClientNotification_updateTask() : BMethodRequest(2104055021) {
	notifyType = de::elo::ix::client::notify::TaskNotifyType::InsertTask;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::notify::BRequest_ClientNotification_updateTask::BRequest_ClientNotification_updateTask(const de::elo::ix::client::PClientInfo& ci, const de::elo::ix::client::PUserTask& userTask, TaskNotifyType notifyType)
	: BMethodRequest(2104055021) 
	, ci(ci)
	, userTask(userTask)
	, notifyType(notifyType)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::notify::BRequest_ClientNotification_updateTask::BSerializable_getTypeId() {
	return 1469990419; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_ClientNotification_updateTask::serialize(BIO& ar, const BVERSION version) {
	ar & this->notifyType;
	ar & this->ci;
	ar & this->userTask;
}
void de::elo::ix::client::notify::BRequest_ClientNotification_updateTask::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PClientNotification __byps__remoteT = byps_ptr_cast<ClientNotification>(__byps__remote);
	__byps__remoteT->updateTask(ci, userTask, notifyType, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1469990419(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::notify::BRequest_ClientNotification_updateTask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace search { 

//-------------------------------------------------
// Implementation of class LanguageConfig
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LanguageConfig::LanguageConfig() {
	nbOfLangs = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::search::LanguageConfig::LanguageConfig(const ::std::wstring& languages, const ::std::wstring& allowedLangs, int32_t nbOfLangs, const ::std::wstring& archiveLang, const byps::PMapStringString& mapLanguageNames)
	: languages(languages)
	, allowedLangs(allowedLangs)
	, nbOfLangs(nbOfLangs)
	, archiveLang(archiveLang)
	, mapLanguageNames(mapLanguageNames)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::search::LanguageConfig::BSerializable_getTypeId() {
	return 2005992013; 
}
void LanguageConfig::setLanguages(::std::wstring v) {
	languages = v;
}
void LanguageConfig::setAllowedLangs(::std::wstring v) {
	allowedLangs = v;
}
void LanguageConfig::setNbOfLangs(int32_t v) {
	nbOfLangs = v;
}
void LanguageConfig::setArchiveLang(::std::wstring v) {
	archiveLang = v;
}
void LanguageConfig::setMapLanguageNames(byps::PMapStringString v) {
	mapLanguageNames = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LanguageConfig::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->allowedLangs;
	ar & this->languages;
	if (version >= 1000000020000021) {
		ar & this->archiveLang;
		if (version >= 1000000020000022) {
			ar & this->nbOfLangs;
		}
	}
	if (version >= 1000170010000003) {
		ar & this->mapLanguageNames;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2005992013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::search::LanguageConfig>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace search { 

//-------------------------------------------------
// Implementation of class OptimizerConfig
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OptimizerConfig::OptimizerConfig() {
	status = de::elo::ix::client::search::SearchIndexerStatus::Inactive;
	intervalHours = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::search::OptimizerConfig::OptimizerConfig(SearchIndexerStatus status, const BDateTime& nextRunAt, int32_t intervalHours, const ::std::wstring& ixid, const ::std::wstring& lastException, const ::std::wstring& lockName)
	: status(status)
	, nextRunAt(nextRunAt)
	, intervalHours(intervalHours)
	, ixid(ixid)
	, lastException(lastException)
	, lockName(lockName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::search::OptimizerConfig::BSerializable_getTypeId() {
	return 645566676; 
}
void OptimizerConfig::setStatus(SearchIndexerStatus v) {
	status = v;
}
void OptimizerConfig::setNextRunAt(BDateTime v) {
	nextRunAt = v;
}
void OptimizerConfig::setIntervalHours(int32_t v) {
	intervalHours = v;
}
void OptimizerConfig::setIxid(::std::wstring v) {
	ixid = v;
}
void OptimizerConfig::setLastException(::std::wstring v) {
	lastException = v;
}
void OptimizerConfig::setLockName(::std::wstring v) {
	lockName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OptimizerConfig::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->intervalHours;
	ar & this->ixid;
	ar & this->lastException;
	ar & this->nextRunAt;
	ar & this->status;
	if (version >= 1000000000000007) {
		ar & this->lockName;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_645566676(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::search::OptimizerConfig>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace search { 

//-------------------------------------------------
// Implementation of class ReindexerConfig
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReindexerConfig::ReindexerConfig() {
	status = de::elo::ix::client::search::SearchIndexerStatus::Inactive;
	progressInPercent = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::search::ReindexerConfig::ReindexerConfig(SearchIndexerStatus status, const BDateTime& startedAt, int32_t progressInPercent, const ::std::wstring& ixid, const ::std::wstring& lastException, const ::std::wstring& objIdRange, const ::std::wstring& lockName)
	: status(status)
	, startedAt(startedAt)
	, progressInPercent(progressInPercent)
	, ixid(ixid)
	, lastException(lastException)
	, objIdRange(objIdRange)
	, lockName(lockName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::search::ReindexerConfig::BSerializable_getTypeId() {
	return 1470978622; 
}
void ReindexerConfig::setStatus(SearchIndexerStatus v) {
	status = v;
}
void ReindexerConfig::setStartedAt(BDateTime v) {
	startedAt = v;
}
void ReindexerConfig::setProgressInPercent(int32_t v) {
	progressInPercent = v;
}
void ReindexerConfig::setIxid(::std::wstring v) {
	ixid = v;
}
void ReindexerConfig::setLastException(::std::wstring v) {
	lastException = v;
}
void ReindexerConfig::setObjIdRange(::std::wstring v) {
	objIdRange = v;
}
void ReindexerConfig::setLockName(::std::wstring v) {
	lockName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReindexerConfig::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->ixid;
	ar & this->lastException;
	ar & this->objIdRange;
	ar & this->progressInPercent;
	ar & this->startedAt;
	ar & this->status;
	if (version >= 1000000000000007) {
		ar & this->lockName;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1470978622(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::search::ReindexerConfig>(bio, pObj, pObjS, pBase);	
}
}}}}

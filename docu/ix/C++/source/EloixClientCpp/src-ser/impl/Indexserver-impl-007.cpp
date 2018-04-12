#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutReportOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutReportOptions::BRequest_IXServicePortIF_checkoutReportOptions() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutReportOptions::BRequest_IXServicePortIF_checkoutReportOptions(const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutReportOptions::BSerializable_getTypeId() {
	return 1436296110; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutReportOptions::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutReportOptions::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutReportOptions(ci, lockZ, [__byps__asyncResult](PReportOptions __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1057373949(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutReportOptions::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1436296110(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutReportOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutSord::BRequest_IXServicePortIF_checkoutSord() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutSord::BRequest_IXServicePortIF_checkoutSord(const ::std::wstring& objId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, objId(objId)
	, editInfoZ(editInfoZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutSord::BSerializable_getTypeId() {
	return 1879918634; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->ci;
	ar & this->editInfoZ;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutSord(ci, objId, editInfoZ, lockZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_820228328(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSord::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1879918634(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutSordHistory
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutSordHistory::BRequest_IXServicePortIF_checkoutSordHistory() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordHistory::BRequest_IXServicePortIF_checkoutSordHistory(const ::std::wstring& objId)
	: BMethodRequest(1795705954) 
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordHistory::BSerializable_getTypeId() {
	return 782528246; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutSordHistory::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordHistory::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutSordHistory(ci, objId, [__byps__asyncResult](PArraySordHist __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_491352407(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordHistory::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_782528246(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordHistory>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutSordPath
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutSordPath::BRequest_IXServicePortIF_checkoutSordPath() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordPath::BRequest_IXServicePortIF_checkoutSordPath(const ::std::wstring& objId, const PSordZ& sordZ, const PCheckoutSordPathInfo& csi)
	: BMethodRequest(1795705954) 
	, objId(objId)
	, sordZ(sordZ)
	, csi(csi)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordPath::BSerializable_getTypeId() {
	return 1700856977; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutSordPath::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->ci;
	ar & this->csi;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordPath::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutSordPath(ci, objId, sordZ, csi, [__byps__asyncResult](PSordPaths __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1835331414(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordPath::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1700856977(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordPath>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutSordTypes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutSordTypes::BRequest_IXServicePortIF_checkoutSordTypes() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordTypes::BRequest_IXServicePortIF_checkoutSordTypes(const PArrayInt& sordTypeIds, const PSordTypeZ& sordTypeZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, sordTypeIds(sordTypeIds)
	, sordTypeZ(sordTypeZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordTypes::BSerializable_getTypeId() {
	return 1182553489; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutSordTypes::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
	ar & this->sordTypeIds;
	ar & this->sordTypeZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordTypes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutSordTypes(ci, sordTypeIds, sordTypeZ, lockZ, [__byps__asyncResult](PArraySordType __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_133130047(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordTypes::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1182553489(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordTypes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutStorage
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutStorage::BRequest_IXServicePortIF_checkoutStorage() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutStorage::BRequest_IXServicePortIF_checkoutStorage(const PArrayString& ids, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, ids(ids)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutStorage::BSerializable_getTypeId() {
	return 1576625569; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutStorage::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->ids;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutStorage::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutStorage(ci, ids, lockZ, [__byps__asyncResult](PArrayStoreInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_231031238(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutStorage::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1576625569(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutStorage>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutSubs
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutSubs::BRequest_IXServicePortIF_checkoutSubs() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutSubs::BRequest_IXServicePortIF_checkoutSubs(const ::std::wstring& userId, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, userId(userId)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutSubs::BSerializable_getTypeId() {
	return 1879923919; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutSubs::serialize(BIO& ar, const BVERSION version) {
	ar & this->userId;
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSubs::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutSubs(ci, userId, lockZ, [__byps__asyncResult](PArraySubsInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_105830886(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutSubs::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1879923919(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutSubs>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutTranslateTerms
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutTranslateTerms::BRequest_IXServicePortIF_checkoutTranslateTerms() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutTranslateTerms::BRequest_IXServicePortIF_checkoutTranslateTerms(const PArrayString& termIds, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, termIds(termIds)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutTranslateTerms::BSerializable_getTypeId() {
	return 1899181963; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutTranslateTerms::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
	ar & this->termIds;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutTranslateTerms::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutTranslateTerms(ci, termIds, lockZ, [__byps__asyncResult](PArrayTranslateTerm __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1088095067(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutTranslateTerms::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1899181963(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutTranslateTerms>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutUserProfile
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutUserProfile::BRequest_IXServicePortIF_checkoutUserProfile() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutUserProfile::BRequest_IXServicePortIF_checkoutUserProfile(const PUserProfile& userProfile, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, userProfile(userProfile)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutUserProfile::BSerializable_getTypeId() {
	return 1452265150; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutUserProfile::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
	ar & this->userProfile;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutUserProfile::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutUserProfile(ci, userProfile, lockZ, [__byps__asyncResult](PUserProfile __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1401065069(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutUserProfile::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1452265150(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutUserProfile>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutUsers
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutUsers::BRequest_IXServicePortIF_checkoutUsers() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutUsers::BRequest_IXServicePortIF_checkoutUsers(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, ids(ids)
	, checkoutUsersZ(checkoutUsersZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutUsers::BSerializable_getTypeId() {
	return 1850110228; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutUsers::serialize(BIO& ar, const BVERSION version) {
	ar & this->checkoutUsersZ;
	ar & this->ci;
	ar & this->ids;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutUsers::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutUsers(ci, ids, checkoutUsersZ, lockZ, [__byps__asyncResult](PArrayUserInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1132956238(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutUsers::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1850110228(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutUsers>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutWorkFlow
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutWorkFlow::BRequest_IXServicePortIF_checkoutWorkFlow() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkFlow::BRequest_IXServicePortIF_checkoutWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, flowId(flowId)
	, typeZ(typeZ)
	, workFlowDiagramZ(workFlowDiagramZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkFlow::BSerializable_getTypeId() {
	return 981594235; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutWorkFlow::serialize(BIO& ar, const BVERSION version) {
	ar & this->flowId;
	ar & this->ci;
	ar & this->lockZ;
	ar & this->typeZ;
	ar & this->workFlowDiagramZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkFlow::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutWorkFlow(ci, flowId, typeZ, workFlowDiagramZ, lockZ, [__byps__asyncResult](PWFDiagram __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1663767661(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkFlow::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_981594235(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkFlow>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutWorkflowHistory
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutWorkflowHistory::BRequest_IXServicePortIF_checkoutWorkflowHistory() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowHistory::BRequest_IXServicePortIF_checkoutWorkflowHistory(const PCheckoutWorkflowHistoryParams& checkoutWorkflowHistoryParams)
	: BMethodRequest(1795705954) 
	, checkoutWorkflowHistoryParams(checkoutWorkflowHistoryParams)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowHistory::BSerializable_getTypeId() {
	return 1555002297; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutWorkflowHistory::serialize(BIO& ar, const BVERSION version) {
	ar & this->checkoutWorkflowHistoryParams;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowHistory::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutWorkflowHistory(ci, checkoutWorkflowHistoryParams, [__byps__asyncResult](PCheckoutWorkflowHistoryResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1754570852(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowHistory::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1555002297(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowHistory>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutWorkflowTemplate
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutWorkflowTemplate::BRequest_IXServicePortIF_checkoutWorkflowTemplate() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowTemplate::BRequest_IXServicePortIF_checkoutWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PWFDiagramZ& wfZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, flowId(flowId)
	, versionId(versionId)
	, wfZ(wfZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowTemplate::BSerializable_getTypeId() {
	return 968696309; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutWorkflowTemplate::serialize(BIO& ar, const BVERSION version) {
	ar & this->flowId;
	ar & this->versionId;
	ar & this->ci;
	ar & this->lockZ;
	ar & this->wfZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowTemplate::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutWorkflowTemplate(ci, flowId, versionId, wfZ, lockZ, [__byps__asyncResult](PWFDiagram __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1663767661(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowTemplate::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_968696309(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowTemplate>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_cleanupStart
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_cleanupStart::BRequest_IXServicePortIF_cleanupStart() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_cleanupStart::BRequest_IXServicePortIF_cleanupStart(const PDeleteOptions& deleteOptions)
	: BMethodRequest(1795705954) 
	, deleteOptions(deleteOptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_cleanupStart::BSerializable_getTypeId() {
	return 97888340; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_cleanupStart::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->deleteOptions;
}
void de::elo::ix::client::BRequest_IXServicePortIF_cleanupStart::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->cleanupStart(ci, deleteOptions, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_cleanupStart::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_97888340(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_cleanupStart>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_cleanupState
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_cleanupState::BRequest_IXServicePortIF_cleanupState() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_cleanupState::BSerializable_getTypeId() {
	return 97888387; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_cleanupState::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_cleanupState::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->cleanupState(ci, [__byps__asyncResult](PJobState __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1436376940(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_cleanupState::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_97888387(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_cleanupState>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_cleanupStop
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_cleanupStop::BRequest_IXServicePortIF_cleanupStop() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_cleanupStop::BSerializable_getTypeId() {
	return 689578544; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_cleanupStop::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_cleanupStop::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->cleanupStop(ci, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_cleanupStop::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_689578544(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_cleanupStop>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_closeEventBus
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_closeEventBus::BRequest_IXServicePortIF_closeEventBus() : BMethodRequest(1795705954) {
	busId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_closeEventBus::BRequest_IXServicePortIF_closeEventBus(int64_t busId)
	: BMethodRequest(1795705954) 
	, busId(busId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_closeEventBus::BSerializable_getTypeId() {
	return 1579680296; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_closeEventBus::serialize(BIO& ar, const BVERSION version) {
	ar & this->busId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_closeEventBus::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->closeEventBus(ci, busId, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_closeEventBus::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1579680296(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_closeEventBus>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_collectJobStates
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_collectJobStates::BRequest_IXServicePortIF_collectJobStates() : BMethodRequest(1795705954) {
	activeJobs = false;
	finishedJobs = false;
	fullInfo = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_collectJobStates::BRequest_IXServicePortIF_collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo)
	: BMethodRequest(1795705954) 
	, activeJobs(activeJobs)
	, finishedJobs(finishedJobs)
	, fullInfo(fullInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_collectJobStates::BSerializable_getTypeId() {
	return 1479025845; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_collectJobStates::serialize(BIO& ar, const BVERSION version) {
	ar & this->activeJobs;
	ar & this->finishedJobs;
	ar & this->fullInfo;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_collectJobStates::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->collectJobStates(ci, activeJobs, finishedJobs, fullInfo, [__byps__asyncResult](PArrayJobState __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1788243283(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_collectJobStates::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1479025845(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_collectJobStates>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_collectMapDomains
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_collectMapDomains::BRequest_IXServicePortIF_collectMapDomains() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_collectMapDomains::BSerializable_getTypeId() {
	return 1590880889; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_collectMapDomains::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_collectMapDomains::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->collectMapDomains(ci, [__byps__asyncResult](PArrayMapDomain __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1963952629(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_collectMapDomains::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1590880889(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_collectMapDomains>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_collectWorkFlowNodes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_collectWorkFlowNodes::BRequest_IXServicePortIF_collectWorkFlowNodes() : BMethodRequest(1795705954) {
	nodeType = 0;
	onlyActive = false;
	onlyStartNodes = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlowNodes::BRequest_IXServicePortIF_collectWorkFlowNodes(const ::std::wstring& flowName, const PWFTypeZ& wfTypeZ, const ::std::wstring& nodeName, int32_t nodeType, const ::std::wstring& objId, const ::std::wstring& enterDateIso, const ::std::wstring& exitDateIso, const PArrayString& userIds, bool onlyActive, bool onlyStartNodes)
	: BMethodRequest(1795705954) 
	, flowName(flowName)
	, wfTypeZ(wfTypeZ)
	, nodeName(nodeName)
	, nodeType(nodeType)
	, objId(objId)
	, enterDateIso(enterDateIso)
	, exitDateIso(exitDateIso)
	, userIds(userIds)
	, onlyActive(onlyActive)
	, onlyStartNodes(onlyStartNodes)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlowNodes::BSerializable_getTypeId() {
	return 791411518; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_collectWorkFlowNodes::serialize(BIO& ar, const BVERSION version) {
	ar & this->enterDateIso;
	ar & this->exitDateIso;
	ar & this->flowName;
	ar & this->nodeName;
	ar & this->nodeType;
	ar & this->objId;
	ar & this->onlyActive;
	ar & this->onlyStartNodes;
	ar & this->ci;
	ar & this->userIds;
	ar & this->wfTypeZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlowNodes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->collectWorkFlowNodes(ci, flowName, wfTypeZ, nodeName, nodeType, objId, enterDateIso, exitDateIso, userIds, onlyActive, onlyStartNodes, [__byps__asyncResult](PArrayWFCollectNode __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_2006133032(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlowNodes::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_791411518(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlowNodes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_collectWorkFlows
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_collectWorkFlows::BRequest_IXServicePortIF_collectWorkFlows() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlows::BRequest_IXServicePortIF_collectWorkFlows(const PWFTypeZ& typeZ)
	: BMethodRequest(1795705954) 
	, typeZ(typeZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlows::BSerializable_getTypeId() {
	return 1540999264; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_collectWorkFlows::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->typeZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlows::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->collectWorkFlows(ci, typeZ, [__byps__asyncResult](PArrayIdName __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_755261279(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlows::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1540999264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlows>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_combineAcl
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_combineAcl::BRequest_IXServicePortIF_combineAcl() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_combineAcl::BRequest_IXServicePortIF_combineAcl(const PArrayAclItem& lhs, const PArrayAclItem& rhs, const PCombineAclOptions& options)
	: BMethodRequest(1795705954) 
	, lhs(lhs)
	, rhs(rhs)
	, options(options)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_combineAcl::BSerializable_getTypeId() {
	return 1476771969; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_combineAcl::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lhs;
	ar & this->options;
	ar & this->rhs;
}
void de::elo::ix::client::BRequest_IXServicePortIF_combineAcl::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->combineAcl(ci, lhs, rhs, options, [__byps__asyncResult](PCombineAclResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1034263904(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_combineAcl::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1476771969(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_combineAcl>(bio, pObj, pObjS, pBase);	
}
}}}}

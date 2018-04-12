#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteSord::BRequest_IXServicePortIF_deleteSord() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteSord::BRequest_IXServicePortIF_deleteSord(const ::std::wstring& parentId, const ::std::wstring& objId, const PLockZ& unlockZ, const PDeleteOptions& deleteOptions)
	: BMethodRequest(1795705954) 
	, parentId(parentId)
	, objId(objId)
	, unlockZ(unlockZ)
	, deleteOptions(deleteOptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteSord::BSerializable_getTypeId() {
	return 894215281; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->parentId;
	ar & this->ci;
	ar & this->deleteOptions;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteSord(ci, parentId, objId, unlockZ, deleteOptions, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSord::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_894215281(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteSordTypes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteSordTypes::BRequest_IXServicePortIF_deleteSordTypes() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteSordTypes::BRequest_IXServicePortIF_deleteSordTypes(const PArrayInt& sordTypeIds, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, sordTypeIds(sordTypeIds)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteSordTypes::BSerializable_getTypeId() {
	return 789245482; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteSordTypes::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->sordTypeIds;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSordTypes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteSordTypes(ci, sordTypeIds, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSordTypes::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_789245482(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteSordTypes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteSubs
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteSubs::BRequest_IXServicePortIF_deleteSubs() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteSubs::BRequest_IXServicePortIF_deleteSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, deps(deps)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteSubs::BSerializable_getTypeId() {
	return 894209996; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteSubs::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->deps;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSubs::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteSubs(ci, deps, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSubs::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_894209996(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteSubs>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteSubscription
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteSubscription::BRequest_IXServicePortIF_deleteSubscription() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteSubscription::BRequest_IXServicePortIF_deleteSubscription(const PSubscription& subs)
	: BMethodRequest(1795705954) 
	, subs(subs)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteSubscription::BSerializable_getTypeId() {
	return 363712994; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteSubscription::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->subs;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSubscription::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteSubscription(ci, subs, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteSubscription::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_363712994(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteSubscription>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteTranslateTerms
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteTranslateTerms::BRequest_IXServicePortIF_deleteTranslateTerms() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteTranslateTerms::BRequest_IXServicePortIF_deleteTranslateTerms(const PArrayString& termIds, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, termIds(termIds)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteTranslateTerms::BSerializable_getTypeId() {
	return 158441882; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteTranslateTerms::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->termIds;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteTranslateTerms::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteTranslateTerms(ci, termIds, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteTranslateTerms::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_158441882(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteTranslateTerms>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteUserProfile
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteUserProfile::BRequest_IXServicePortIF_deleteUserProfile() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteUserProfile::BRequest_IXServicePortIF_deleteUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, userProfile(userProfile)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteUserProfile::BSerializable_getTypeId() {
	return 634031555; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteUserProfile::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->unlockZ;
	ar & this->userProfile;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteUserProfile::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteUserProfile(ci, userProfile, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteUserProfile::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_634031555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteUserProfile>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteUsers
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteUsers::BRequest_IXServicePortIF_deleteUsers() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteUsers::BRequest_IXServicePortIF_deleteUsers(const PArrayString& ids, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, ids(ids)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteUsers::BSerializable_getTypeId() {
	return 1948915673; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteUsers::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->ids;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteUsers::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteUsers(ci, ids, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteUsers::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1948915673(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteUsers>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteWorkFlow
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteWorkFlow::BRequest_IXServicePortIF_deleteWorkFlow() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkFlow::BRequest_IXServicePortIF_deleteWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, flowId(flowId)
	, typeZ(typeZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkFlow::BSerializable_getTypeId() {
	return 478820000; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteWorkFlow::serialize(BIO& ar, const BVERSION version) {
	ar & this->flowId;
	ar & this->ci;
	ar & this->typeZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkFlow::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteWorkFlow(ci, flowId, typeZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkFlow::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_478820000(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkFlow>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_deleteWorkflowTemplate
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_deleteWorkflowTemplate::BRequest_IXServicePortIF_deleteWorkflowTemplate() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkflowTemplate::BRequest_IXServicePortIF_deleteWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, flowId(flowId)
	, versionId(versionId)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkflowTemplate::BSerializable_getTypeId() {
	return 1634712102; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_deleteWorkflowTemplate::serialize(BIO& ar, const BVERSION version) {
	ar & this->flowId;
	ar & this->versionId;
	ar & this->ci;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkflowTemplate::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->deleteWorkflowTemplate(ci, flowId, versionId, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkflowTemplate::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1634712102(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkflowTemplate>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_editPublicDownloadUrls
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_editPublicDownloadUrls::BRequest_IXServicePortIF_editPublicDownloadUrls() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_editPublicDownloadUrls::BRequest_IXServicePortIF_editPublicDownloadUrls(const PPublicDownloadOptions& opts)
	: BMethodRequest(1795705954) 
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_editPublicDownloadUrls::BSerializable_getTypeId() {
	return 245225739; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_editPublicDownloadUrls::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->opts;
}
void de::elo::ix::client::BRequest_IXServicePortIF_editPublicDownloadUrls::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->editPublicDownloadUrls(ci, opts, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_editPublicDownloadUrls::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_245225739(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_editPublicDownloadUrls>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_encryptStringRsa
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_encryptStringRsa::BRequest_IXServicePortIF_encryptStringRsa() : BMethodRequest(1795705954) {
	encryptNotDecrypt = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_encryptStringRsa::BRequest_IXServicePortIF_encryptStringRsa(const ::std::wstring& key, const ::std::wstring& data, bool encryptNotDecrypt)
	: BMethodRequest(1795705954) 
	, key(key)
	, data(data)
	, encryptNotDecrypt(encryptNotDecrypt)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_encryptStringRsa::BSerializable_getTypeId() {
	return 1840380736; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_encryptStringRsa::serialize(BIO& ar, const BVERSION version) {
	ar & this->data;
	ar & this->encryptNotDecrypt;
	ar & this->key;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_encryptStringRsa::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->encryptStringRsa(ci, key, data, encryptNotDecrypt, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_10(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_encryptStringRsa::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1840380736(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_encryptStringRsa>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_endEditWorkFlowNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_endEditWorkFlowNode::BRequest_IXServicePortIF_endEditWorkFlowNode() : BMethodRequest(1795705954) {
	nFlowId = 0;
	nNodeId = 0;
	bTerminate = false;
	bCancel = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_endEditWorkFlowNode::BRequest_IXServicePortIF_endEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, bool bTerminate, bool bCancel, const ::std::wstring& sName, const ::std::wstring& sComment, const PArrayInt& arrEnterNodesIds)
	: BMethodRequest(1795705954) 
	, nFlowId(nFlowId)
	, nNodeId(nNodeId)
	, bTerminate(bTerminate)
	, bCancel(bCancel)
	, sName(sName)
	, sComment(sComment)
	, arrEnterNodesIds(arrEnterNodesIds)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_endEditWorkFlowNode::BSerializable_getTypeId() {
	return 551973808; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_endEditWorkFlowNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->bCancel;
	ar & this->bTerminate;
	ar & this->nFlowId;
	ar & this->nNodeId;
	ar & this->sComment;
	ar & this->sName;
	ar & this->arrEnterNodesIds;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_endEditWorkFlowNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->endEditWorkFlowNode(ci, nFlowId, nNodeId, bTerminate, bCancel, sName, sComment, arrEnterNodesIds, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_endEditWorkFlowNode::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_551973808(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_endEditWorkFlowNode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_evalAutoFiling
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_evalAutoFiling::BRequest_IXServicePortIF_evalAutoFiling() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_evalAutoFiling::BRequest_IXServicePortIF_evalAutoFiling(const ::std::wstring& maskId, const PSord& sord, const PAutoFilingOptions& opts)
	: BMethodRequest(1795705954) 
	, maskId(maskId)
	, sord(sord)
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_evalAutoFiling::BSerializable_getTypeId() {
	return 1823282746; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_evalAutoFiling::serialize(BIO& ar, const BVERSION version) {
	ar & this->maskId;
	ar & this->ci;
	ar & this->opts;
	ar & this->sord;
}
void de::elo::ix::client::BRequest_IXServicePortIF_evalAutoFiling::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->evalAutoFiling(ci, maskId, sord, opts, [__byps__asyncResult](PAutoFilingResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1881161566(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_evalAutoFiling::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1823282746(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_evalAutoFiling>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_executeRegisteredFunction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_executeRegisteredFunction::BRequest_IXServicePortIF_executeRegisteredFunction() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunction::BRequest_IXServicePortIF_executeRegisteredFunction(const ::std::wstring& functionName, const PAny& param)
	: BMethodRequest(1795705954) 
	, functionName(functionName)
	, param(param)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunction::BSerializable_getTypeId() {
	return 778610599; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_executeRegisteredFunction::serialize(BIO& ar, const BVERSION version) {
	ar & this->functionName;
	ar & this->ci;
	ar & this->param;
}
void de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->executeRegisteredFunction(ci, functionName, param, [__byps__asyncResult](PAny __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1191976387(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunction::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_778610599(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_executeRegisteredFunctionString
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_executeRegisteredFunctionString::BRequest_IXServicePortIF_executeRegisteredFunctionString() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunctionString::BRequest_IXServicePortIF_executeRegisteredFunctionString(const ::std::wstring& functionName, const ::std::wstring& param)
	: BMethodRequest(1795705954) 
	, functionName(functionName)
	, param(param)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunctionString::BSerializable_getTypeId() {
	return 553270730; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_executeRegisteredFunctionString::serialize(BIO& ar, const BVERSION version) {
	ar & this->functionName;
	ar & this->param;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunctionString::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->executeRegisteredFunctionString(ci, functionName, param, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_10(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunctionString::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_553270730(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunctionString>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_executeScript
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_executeScript::BRequest_IXServicePortIF_executeScript() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_executeScript::BRequest_IXServicePortIF_executeScript(const PExecuteScriptParams& params)
	: BMethodRequest(1795705954) 
	, params(params)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_executeScript::BSerializable_getTypeId() {
	return 905800490; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_executeScript::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->params;
}
void de::elo::ix::client::BRequest_IXServicePortIF_executeScript::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->executeScript(ci, params, [__byps__asyncResult](PExecuteScriptResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_63967077(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_executeScript::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_905800490(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_executeScript>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_exportWorkflow
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_exportWorkflow::BRequest_IXServicePortIF_exportWorkflow() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_exportWorkflow::BRequest_IXServicePortIF_exportWorkflow(const PWorkflowExportOptions& wfExportOptions)
	: BMethodRequest(1795705954) 
	, wfExportOptions(wfExportOptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_exportWorkflow::BSerializable_getTypeId() {
	return 809552457; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_exportWorkflow::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->wfExportOptions;
}
void de::elo::ix::client::BRequest_IXServicePortIF_exportWorkflow::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->exportWorkflow(ci, wfExportOptions, [__byps__asyncResult](PFileData __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_888671717(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_exportWorkflow::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_809552457(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_exportWorkflow>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findActivityProjects
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findActivityProjects::BRequest_IXServicePortIF_findActivityProjects() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findActivityProjects::BRequest_IXServicePortIF_findActivityProjects(const PFindActivityProjectsInfo& findInfo)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findActivityProjects::BSerializable_getTypeId() {
	return 1955899064; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findActivityProjects::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findActivityProjects::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findActivityProjects(ci, findInfo, [__byps__asyncResult](PArrayActivityProject __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_607287445(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findActivityProjects::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1955899064(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findActivityProjects>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findBackgroundThreads
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findBackgroundThreads::BRequest_IXServicePortIF_findBackgroundThreads() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findBackgroundThreads::BRequest_IXServicePortIF_findBackgroundThreads(const PFindBackgroundThreadOptions& findBackgroundThreadOptions)
	: BMethodRequest(1795705954) 
	, findBackgroundThreadOptions(findBackgroundThreadOptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findBackgroundThreads::BSerializable_getTypeId() {
	return 610169452; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findBackgroundThreads::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->findBackgroundThreadOptions;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findBackgroundThreads::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findBackgroundThreads(ci, findBackgroundThreadOptions, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findBackgroundThreads::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_610169452(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findBackgroundThreads>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findClose
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findClose::BRequest_IXServicePortIF_findClose() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findClose::BRequest_IXServicePortIF_findClose(const ::std::wstring& searchId)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findClose::BSerializable_getTypeId() {
	return 928687287; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findClose::serialize(BIO& ar, const BVERSION version) {
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findClose::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findClose(ci, searchId, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_findClose::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_928687287(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findClose>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstActivities
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstActivities::BRequest_IXServicePortIF_findFirstActivities() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstActivities::BRequest_IXServicePortIF_findFirstActivities(const PFindActivityInfo& findInfo, int32_t max, const PActivityZ& activityZ)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	, activityZ(activityZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstActivities::BSerializable_getTypeId() {
	return 1661199666; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstActivities::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->activityZ;
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstActivities::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstActivities(ci, findInfo, max, activityZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstActivities::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1661199666(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstActivities>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstConfigFiles
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstConfigFiles::BRequest_IXServicePortIF_findFirstConfigFiles() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstConfigFiles::BRequest_IXServicePortIF_findFirstConfigFiles(const PFindConfigFileInfo& findInfo, int32_t max, const PConfigFileZ& configFileZ)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	, configFileZ(configFileZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstConfigFiles::BSerializable_getTypeId() {
	return 954269076; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstConfigFiles::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->configFileZ;
	ar & this->findInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstConfigFiles::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstConfigFiles(ci, findInfo, max, configFileZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstConfigFiles::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_954269076(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstConfigFiles>(bio, pObj, pObjS, pBase);	
}
}}}}

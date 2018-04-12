#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutActivityProject
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutActivityProject::BRequest_IXServicePortIF_checkoutActivityProject() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivityProject::BRequest_IXServicePortIF_checkoutActivityProject(const ::std::wstring& projectName, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, projectName(projectName)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivityProject::BSerializable_getTypeId() {
	return 1209441042; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutActivityProject::serialize(BIO& ar, const BVERSION version) {
	ar & this->projectName;
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivityProject::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutActivityProject(ci, projectName, lockZ, [__byps__asyncResult](PActivityProject __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_2121298555(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivityProject::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1209441042(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivityProject>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutColors
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutColors::BRequest_IXServicePortIF_checkoutColors() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutColors::BRequest_IXServicePortIF_checkoutColors(const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutColors::BSerializable_getTypeId() {
	return 2037655284; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutColors::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutColors::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutColors(ci, lockZ, [__byps__asyncResult](PArrayColorData __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1870182600(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutColors::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2037655284(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutColors>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutConfigFiles
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutConfigFiles::BRequest_IXServicePortIF_checkoutConfigFiles() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutConfigFiles::BRequest_IXServicePortIF_checkoutConfigFiles(const PArrayString& names, const PConfigFileZ& configFileZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, names(names)
	, configFileZ(configFileZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutConfigFiles::BSerializable_getTypeId() {
	return 846870983; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutConfigFiles::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->configFileZ;
	ar & this->lockZ;
	ar & this->names;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutConfigFiles::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutConfigFiles(ci, names, configFileZ, lockZ, [__byps__asyncResult](PArrayConfigFile __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1737266313(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutConfigFiles::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_846870983(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutConfigFiles>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutCounters
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutCounters::BRequest_IXServicePortIF_checkoutCounters() : BMethodRequest(1795705954) {
	incrementCounters = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutCounters::BRequest_IXServicePortIF_checkoutCounters(const PArrayString& counterNames, bool incrementCounters, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, counterNames(counterNames)
	, incrementCounters(incrementCounters)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutCounters::BSerializable_getTypeId() {
	return 575147667; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutCounters::serialize(BIO& ar, const BVERSION version) {
	ar & this->incrementCounters;
	ar & this->ci;
	ar & this->counterNames;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutCounters::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutCounters(ci, counterNames, incrementCounters, lockZ, [__byps__asyncResult](PArrayCounterInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1698110251(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutCounters::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_575147667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutCounters>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutCryptInfos
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutCryptInfos::BRequest_IXServicePortIF_checkoutCryptInfos() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutCryptInfos::BRequest_IXServicePortIF_checkoutCryptInfos(const PArrayString& ids, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, ids(ids)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutCryptInfos::BSerializable_getTypeId() {
	return 1964025427; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutCryptInfos::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->ids;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutCryptInfos::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutCryptInfos(ci, ids, lockZ, [__byps__asyncResult](PArrayCryptInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_809229049(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutCryptInfos::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1964025427(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutCryptInfos>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutDoc
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutDoc::BRequest_IXServicePortIF_checkoutDoc() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutDoc::BRequest_IXServicePortIF_checkoutDoc(const ::std::wstring& objId, const ::std::wstring& docId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, objId(objId)
	, docId(docId)
	, editInfoZ(editInfoZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutDoc::BSerializable_getTypeId() {
	return 753364764; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutDoc::serialize(BIO& ar, const BVERSION version) {
	ar & this->docId;
	ar & this->objId;
	ar & this->ci;
	ar & this->editInfoZ;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutDoc::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutDoc(ci, objId, docId, editInfoZ, lockZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutDoc::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_753364764(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutDoc>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutDocMask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutDocMask::BRequest_IXServicePortIF_checkoutDocMask() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMask::BRequest_IXServicePortIF_checkoutDocMask(const ::std::wstring& maskId, const PDocMaskZ& docMaskZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, maskId(maskId)
	, docMaskZ(docMaskZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMask::BSerializable_getTypeId() {
	return 2135358504; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutDocMask::serialize(BIO& ar, const BVERSION version) {
	ar & this->maskId;
	ar & this->ci;
	ar & this->docMaskZ;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMask::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutDocMask(ci, maskId, docMaskZ, lockZ, [__byps__asyncResult](PDocMask __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_2054753789(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMask::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2135358504(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutDocMaskLineTemplates
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutDocMaskLineTemplates::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates(const PArrayString& groups, const PDocMaskLineTemplateZ& dmltZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, groups(groups)
	, dmltZ(dmltZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates::BSerializable_getTypeId() {
	return 550757795; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutDocMaskLineTemplates::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->dmltZ;
	ar & this->groups;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutDocMaskLineTemplates(ci, groups, dmltZ, lockZ, [__byps__asyncResult](PArrayDocMaskLineTemplate __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1107316733(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_550757795(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutKeys
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutKeys::BRequest_IXServicePortIF_checkoutKeys() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeys::BRequest_IXServicePortIF_checkoutKeys(const PArrayString& ids, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, ids(ids)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeys::BSerializable_getTypeId() {
	return 1879670928; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutKeys::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->ids;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeys::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutKeys(ci, ids, lockZ, [__byps__asyncResult](PArrayKeyInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1112009864(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeys::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1879670928(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeys>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutKeywordList
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutKeywordList::BRequest_IXServicePortIF_checkoutKeywordList() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordList::BRequest_IXServicePortIF_checkoutKeywordList(const ::std::wstring& kwid, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, kwid(kwid)
	, keywordZ(keywordZ)
	, max(max)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordList::BSerializable_getTypeId() {
	return 2139755509; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutKeywordList::serialize(BIO& ar, const BVERSION version) {
	ar & this->kwid;
	ar & this->max;
	ar & this->ci;
	ar & this->keywordZ;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordList::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutKeywordList(ci, kwid, keywordZ, max, lockZ, [__byps__asyncResult](PKeywordList __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1495731174(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordList::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2139755509(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordList>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutKeywords
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutKeywords::BRequest_IXServicePortIF_checkoutKeywords() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywords::BRequest_IXServicePortIF_checkoutKeywords(const PArrayString& kwids, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, kwids(kwids)
	, keywordZ(keywordZ)
	, max(max)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywords::BSerializable_getTypeId() {
	return 1470317638; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutKeywords::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->keywordZ;
	ar & this->kwids;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywords::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutKeywords(ci, kwids, keywordZ, max, lockZ, [__byps__asyncResult](PArrayKeyword __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_206201524(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywords::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1470317638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywords>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutKeywordsDynamic
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutKeywordsDynamic::BRequest_IXServicePortIF_checkoutKeywordsDynamic() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordsDynamic::BRequest_IXServicePortIF_checkoutKeywordsDynamic(const PKeywordsDynamicInfo& keywordsDynamicInfo)
	: BMethodRequest(1795705954) 
	, keywordsDynamicInfo(keywordsDynamicInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordsDynamic::BSerializable_getTypeId() {
	return 1951955225; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutKeywordsDynamic::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->keywordsDynamicInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordsDynamic::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutKeywordsDynamic(ci, keywordsDynamicInfo, [__byps__asyncResult](PKeywordsDynamicResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1552114559(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordsDynamic::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1951955225(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordsDynamic>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutMap
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutMap::BRequest_IXServicePortIF_checkoutMap() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutMap::BRequest_IXServicePortIF_checkoutMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, domainName(domainName)
	, id(id)
	, keyNames(keyNames)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutMap::BSerializable_getTypeId() {
	return 753372992; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutMap::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->id;
	ar & this->ci;
	ar & this->keyNames;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutMap::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutMap(ci, domainName, id, keyNames, lockZ, [__byps__asyncResult](PMapData __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_2011132580(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutMap::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_753372992(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutMap>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutMapDomain
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutMapDomain::BRequest_IXServicePortIF_checkoutMapDomain() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapDomain::BRequest_IXServicePortIF_checkoutMapDomain(const ::std::wstring& domainName, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, domainName(domainName)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapDomain::BSerializable_getTypeId() {
	return 223879132; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutMapDomain::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapDomain::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutMapDomain(ci, domainName, lockZ, [__byps__asyncResult](PMapDomain __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_42339713(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapDomain::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_223879132(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapDomain>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutMapHistory
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutMapHistory::BRequest_IXServicePortIF_checkoutMapHistory() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapHistory::BRequest_IXServicePortIF_checkoutMapHistory(const ::std::wstring& domainName, const ::std::wstring& mapId, const PMapHistZ& membersZ)
	: BMethodRequest(1795705954) 
	, domainName(domainName)
	, mapId(mapId)
	, membersZ(membersZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapHistory::BSerializable_getTypeId() {
	return 739067188; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutMapHistory::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->mapId;
	ar & this->ci;
	ar & this->membersZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapHistory::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutMapHistory(ci, domainName, mapId, membersZ, [__byps__asyncResult](PArrayMapHist __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1756288553(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapHistory::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_739067188(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapHistory>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutNoteTemplates
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutNoteTemplates::BRequest_IXServicePortIF_checkoutNoteTemplates() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutNoteTemplates::BRequest_IXServicePortIF_checkoutNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PNoteTemplateZ& ntemplZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, userId(userId)
	, ids(ids)
	, ntemplZ(ntemplZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutNoteTemplates::BSerializable_getTypeId() {
	return 1837424715; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutNoteTemplates::serialize(BIO& ar, const BVERSION version) {
	ar & this->userId;
	ar & this->ci;
	ar & this->ids;
	ar & this->lockZ;
	ar & this->ntemplZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutNoteTemplates::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutNoteTemplates(ci, userId, ids, ntemplZ, lockZ, [__byps__asyncResult](PArrayNoteTemplate __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1443841819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutNoteTemplates::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1837424715(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutNoteTemplates>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutNotes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutNotes::BRequest_IXServicePortIF_checkoutNotes() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotes::BRequest_IXServicePortIF_checkoutNotes(const ::std::wstring& objId, const PArrayString& noteIds, const PNoteZ& noteZ, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, objId(objId)
	, noteIds(noteIds)
	, noteZ(noteZ)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotes::BSerializable_getTypeId() {
	return 1856680027; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutNotes::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->ci;
	ar & this->lockZ;
	ar & this->noteIds;
	ar & this->noteZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutNotes(ci, objId, noteIds, noteZ, lockZ, [__byps__asyncResult](PArrayNote __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_776454091(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotes::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1856680027(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutNotification
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutNotification::BRequest_IXServicePortIF_checkoutNotification() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotification::BRequest_IXServicePortIF_checkoutNotification(const ::std::wstring& watchGuid, const ::std::wstring& userGuid)
	: BMethodRequest(1795705954) 
	, watchGuid(watchGuid)
	, userGuid(userGuid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotification::BSerializable_getTypeId() {
	return 294879111; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutNotification::serialize(BIO& ar, const BVERSION version) {
	ar & this->userGuid;
	ar & this->watchGuid;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotification::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutNotification(ci, watchGuid, userGuid, [__byps__asyncResult](PNotification __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_494610451(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotification::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_294879111(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotification>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutOrgUnits
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutOrgUnits::BRequest_IXServicePortIF_checkoutOrgUnits() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutOrgUnits::BRequest_IXServicePortIF_checkoutOrgUnits(const PCheckoutOrgUnitInfo& reserved, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, reserved(reserved)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutOrgUnits::BSerializable_getTypeId() {
	return 2042492025; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutOrgUnits::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
	ar & this->reserved;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutOrgUnits::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutOrgUnits(ci, reserved, lockZ, [__byps__asyncResult](PMapIntegerOrgUnitInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_893011331(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutOrgUnits::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2042492025(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutOrgUnits>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutPreviewImageURLs
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutPreviewImageURLs::BRequest_IXServicePortIF_checkoutPreviewImageURLs() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutPreviewImageURLs::BRequest_IXServicePortIF_checkoutPreviewImageURLs(const PPreviewImageInfo& previewImageInfo)
	: BMethodRequest(1795705954) 
	, previewImageInfo(previewImageInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutPreviewImageURLs::BSerializable_getTypeId() {
	return 755346067; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutPreviewImageURLs::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->previewImageInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutPreviewImageURLs::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutPreviewImageURLs(ci, previewImageInfo, [__byps__asyncResult](PPreviewImageResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_661820173(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutPreviewImageURLs::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_755346067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutPreviewImageURLs>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutReminders
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutReminders::BRequest_IXServicePortIF_checkoutReminders() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutReminders::BRequest_IXServicePortIF_checkoutReminders(const PArrayInt& reminderIds, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, reminderIds(reminderIds)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutReminders::BSerializable_getTypeId() {
	return 400637221; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutReminders::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
	ar & this->reminderIds;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutReminders::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutReminders(ci, reminderIds, lockZ, [__byps__asyncResult](PArrayReminder __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1701141707(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutReminders::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_400637221(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutReminders>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkoutReplNames
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkoutReplNames::BRequest_IXServicePortIF_checkoutReplNames() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkoutReplNames::BRequest_IXServicePortIF_checkoutReplNames(const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkoutReplNames::BSerializable_getTypeId() {
	return 1175566339; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkoutReplNames::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutReplNames::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkoutReplNames(ci, lockZ, [__byps__asyncResult](PArrayReplSetName __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_884364631(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkoutReplNames::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1175566339(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkoutReplNames>(bio, pObj, pObjS, pBase);	
}
}}}}

#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_configureBackup
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_configureBackup::BRequest_IXServicePortIF_configureBackup() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_configureBackup::BRequest_IXServicePortIF_configureBackup(const PArrayBackupProfile& backupProfiles)
	: BMethodRequest(1795705954) 
	, backupProfiles(backupProfiles)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_configureBackup::BSerializable_getTypeId() {
	return 251783250; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_configureBackup::serialize(BIO& ar, const BVERSION version) {
	ar & this->backupProfiles;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_configureBackup::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->configureBackup(ci, backupProfiles, [__byps__asyncResult](PArrayBackupProfile __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1233469422(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_configureBackup::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_251783250(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_configureBackup>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_configureFulltext
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_configureFulltext::BRequest_IXServicePortIF_configureFulltext() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_configureFulltext::BRequest_IXServicePortIF_configureFulltext(const ::std::wstring& userId, const PFulltextConfig& opts)
	: BMethodRequest(1795705954) 
	, userId(userId)
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_configureFulltext::BSerializable_getTypeId() {
	return 655595212; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_configureFulltext::serialize(BIO& ar, const BVERSION version) {
	ar & this->userId;
	ar & this->ci;
	ar & this->opts;
}
void de::elo::ix::client::BRequest_IXServicePortIF_configureFulltext::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->configureFulltext(ci, userId, opts, [__byps__asyncResult](PFulltextConfig __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_239574905(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_configureFulltext::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_655595212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_configureFulltext>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_configurePurge
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_configurePurge::BRequest_IXServicePortIF_configurePurge() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_configurePurge::BRequest_IXServicePortIF_configurePurge(const PPurgeSettings& purgeSettings)
	: BMethodRequest(1795705954) 
	, purgeSettings(purgeSettings)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_configurePurge::BSerializable_getTypeId() {
	return 1407134747; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_configurePurge::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->purgeSettings;
}
void de::elo::ix::client::BRequest_IXServicePortIF_configurePurge::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->configurePurge(ci, purgeSettings, [__byps__asyncResult](PPurgeSettings __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1576340510(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_configurePurge::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1407134747(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_configurePurge>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_controlBackgroundThread
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_controlBackgroundThread::BRequest_IXServicePortIF_controlBackgroundThread() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_controlBackgroundThread::BRequest_IXServicePortIF_controlBackgroundThread(const PJobState& jobState)
	: BMethodRequest(1795705954) 
	, jobState(jobState)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_controlBackgroundThread::BSerializable_getTypeId() {
	return 796672607; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_controlBackgroundThread::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->jobState;
}
void de::elo::ix::client::BRequest_IXServicePortIF_controlBackgroundThread::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->controlBackgroundThread(ci, jobState, [__byps__asyncResult](PJobState __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_controlBackgroundThread::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_796672607(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_controlBackgroundThread>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_controlBackup
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_controlBackup::BRequest_IXServicePortIF_controlBackup() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_controlBackup::BRequest_IXServicePortIF_controlBackup(const PControlBackupInfo& controlBackupInfo)
	: BMethodRequest(1795705954) 
	, controlBackupInfo(controlBackupInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_controlBackup::BSerializable_getTypeId() {
	return 429289481; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_controlBackup::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->controlBackupInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_controlBackup::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->controlBackup(ci, controlBackupInfo, [__byps__asyncResult](PBackupPurgeStatus __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_52201250(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_controlBackup::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_429289481(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_controlBackup>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_cookKeyword
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_cookKeyword::BRequest_IXServicePortIF_cookKeyword() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_cookKeyword::BRequest_IXServicePortIF_cookKeyword(const ::std::wstring& kwid)
	: BMethodRequest(1795705954) 
	, kwid(kwid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_cookKeyword::BSerializable_getTypeId() {
	return 922862219; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_cookKeyword::serialize(BIO& ar, const BVERSION version) {
	ar & this->kwid;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_cookKeyword::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->cookKeyword(ci, kwid, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_cookKeyword::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_922862219(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_cookKeyword>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_copySord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_copySord::BRequest_IXServicePortIF_copySord() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_copySord::BRequest_IXServicePortIF_copySord(const ::std::wstring& newParentId, const ::std::wstring& objId, const PCopyInfo& copyInfo, const PCopySordZ& copySordZ)
	: BMethodRequest(1795705954) 
	, newParentId(newParentId)
	, objId(objId)
	, copyInfo(copyInfo)
	, copySordZ(copySordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_copySord::BSerializable_getTypeId() {
	return 1944880601; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_copySord::serialize(BIO& ar, const BVERSION version) {
	ar & this->newParentId;
	ar & this->objId;
	ar & this->ci;
	ar & this->copyInfo;
	ar & this->copySordZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_copySord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->copySord(ci, newParentId, objId, copyInfo, copySordZ, [__byps__asyncResult](int32_t __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_5(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_copySord::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1944880601(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_copySord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createActivity
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createActivity::BRequest_IXServicePortIF_createActivity() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createActivity::BRequest_IXServicePortIF_createActivity(const ::std::wstring& projectName, const ::std::wstring& objId)
	: BMethodRequest(1795705954) 
	, projectName(projectName)
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createActivity::BSerializable_getTypeId() {
	return 806333153; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createActivity::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->projectName;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createActivity::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createActivity(ci, projectName, objId, [__byps__asyncResult](PActivity __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_460199434(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createActivity::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_806333153(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createActivity>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createActivityProject
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createActivityProject::BRequest_IXServicePortIF_createActivityProject() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createActivityProject::BRequest_IXServicePortIF_createActivityProject(const ::std::wstring& projectName)
	: BMethodRequest(1795705954) 
	, projectName(projectName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createActivityProject::BSerializable_getTypeId() {
	return 1769051912; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createActivityProject::serialize(BIO& ar, const BVERSION version) {
	ar & this->projectName;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createActivityProject::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createActivityProject(ci, projectName, [__byps__asyncResult](PActivityProject __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_createActivityProject::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1769051912(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createActivityProject>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createDoc
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createDoc::BRequest_IXServicePortIF_createDoc() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createDoc::BRequest_IXServicePortIF_createDoc(const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ)
	: BMethodRequest(1795705954) 
	, parentId(parentId)
	, maskId(maskId)
	, docTemplate(docTemplate)
	, editInfoZ(editInfoZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createDoc::BSerializable_getTypeId() {
	return 734350810; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createDoc::serialize(BIO& ar, const BVERSION version) {
	ar & this->docTemplate;
	ar & this->maskId;
	ar & this->parentId;
	ar & this->ci;
	ar & this->editInfoZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createDoc::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createDoc(ci, parentId, maskId, docTemplate, editInfoZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_createDoc::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_734350810(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createDoc>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createDocMask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createDocMask::BRequest_IXServicePortIF_createDocMask() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createDocMask::BRequest_IXServicePortIF_createDocMask(const ::std::wstring& maskId)
	: BMethodRequest(1795705954) 
	, maskId(maskId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createDocMask::BSerializable_getTypeId() {
	return 171070926; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createDocMask::serialize(BIO& ar, const BVERSION version) {
	ar & this->maskId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createDocMask::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createDocMask(ci, maskId, [__byps__asyncResult](PDocMask __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_createDocMask::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_171070926(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createDocMask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createEventBusListener
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createEventBusListener::BRequest_IXServicePortIF_createEventBusListener() : BMethodRequest(1795705954) {
	subsId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createEventBusListener::BRequest_IXServicePortIF_createEventBusListener(int64_t subsId, const PEventListener& eventListener)
	: BMethodRequest(1795705954) 
	, subsId(subsId)
	, eventListener(eventListener)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createEventBusListener::BSerializable_getTypeId() {
	return 563568172; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createEventBusListener::serialize(BIO& ar, const BVERSION version) {
	ar & this->subsId;
	ar & this->ci;
	ar & this->eventListener;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createEventBusListener::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createEventBusListener(ci, subsId, eventListener, [__byps__asyncResult](int64_t __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_6(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createEventBusListener::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_563568172(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createEventBusListener>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createEventBusSubscriber
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createEventBusSubscriber::BRequest_IXServicePortIF_createEventBusSubscriber() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createEventBusSubscriber::BSerializable_getTypeId() {
	return 1671043104; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createEventBusSubscriber::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createEventBusSubscriber::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createEventBusSubscriber(ci, [__byps__asyncResult](int64_t __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_6(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createEventBusSubscriber::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1671043104(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createEventBusSubscriber>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createKey
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createKey::BRequest_IXServicePortIF_createKey() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createKey::BSerializable_getTypeId() {
	return 734344371; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createKey::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createKey::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createKey(ci, [__byps__asyncResult](PKeyInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1537059480(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createKey::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_734344371(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createKey>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createNote
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createNote::BRequest_IXServicePortIF_createNote() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createNote::BRequest_IXServicePortIF_createNote(const ::std::wstring& objId)
	: BMethodRequest(1795705954) 
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createNote::BSerializable_getTypeId() {
	return 1289740092; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createNote::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createNote::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createNote(ci, objId, [__byps__asyncResult](PNote __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_937420667(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createNote::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1289740092(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createNote>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createNote2
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createNote2::BRequest_IXServicePortIF_createNote2() : BMethodRequest(1795705954) {
	noteType = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createNote2::BRequest_IXServicePortIF_createNote2(const ::std::wstring& objId, int32_t noteType, const ::std::wstring& templId)
	: BMethodRequest(1795705954) 
	, objId(objId)
	, noteType(noteType)
	, templId(templId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createNote2::BSerializable_getTypeId() {
	return 1327237138; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createNote2::serialize(BIO& ar, const BVERSION version) {
	ar & this->noteType;
	ar & this->objId;
	ar & this->templId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createNote2::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createNote2(ci, objId, noteType, templId, [__byps__asyncResult](PNote __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_937420667(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createNote2::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1327237138(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createNote2>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createNoteTemplate
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createNoteTemplate::BRequest_IXServicePortIF_createNoteTemplate() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createNoteTemplate::BRequest_IXServicePortIF_createNoteTemplate(const ::std::wstring& userId)
	: BMethodRequest(1795705954) 
	, userId(userId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createNoteTemplate::BSerializable_getTypeId() {
	return 1517964638; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createNoteTemplate::serialize(BIO& ar, const BVERSION version) {
	ar & this->userId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createNoteTemplate::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createNoteTemplate(ci, userId, [__byps__asyncResult](PNoteTemplate __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1995912373(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createNoteTemplate::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1517964638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createNoteTemplate>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createReminder
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createReminder::BRequest_IXServicePortIF_createReminder() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createReminder::BRequest_IXServicePortIF_createReminder(const ::std::wstring& objId)
	: BMethodRequest(1795705954) 
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createReminder::BSerializable_getTypeId() {
	return 1943697476; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createReminder::serialize(BIO& ar, const BVERSION version) {
	ar & this->objId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createReminder::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createReminder(ci, objId, [__byps__asyncResult](PReminder __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_256674679(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createReminder::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1943697476(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createReminder>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createRsaKeys
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createRsaKeys::BRequest_IXServicePortIF_createRsaKeys() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createRsaKeys::BSerializable_getTypeId() {
	return 518307262; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createRsaKeys::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createRsaKeys::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createRsaKeys(ci, [__byps__asyncResult](PArrayString __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1888107655(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createRsaKeys::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_518307262(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createRsaKeys>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createSord::BRequest_IXServicePortIF_createSord() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createSord::BRequest_IXServicePortIF_createSord(const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ)
	: BMethodRequest(1795705954) 
	, parentId(parentId)
	, maskId(maskId)
	, editInfoZ(editInfoZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createSord::BSerializable_getTypeId() {
	return 1289591200; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->maskId;
	ar & this->parentId;
	ar & this->ci;
	ar & this->editInfoZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createSord(ci, parentId, maskId, editInfoZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_createSord::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1289591200(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createSubscription
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createSubscription::BRequest_IXServicePortIF_createSubscription() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createSubscription::BRequest_IXServicePortIF_createSubscription(const ::std::wstring& watchGuid)
	: BMethodRequest(1795705954) 
	, watchGuid(watchGuid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createSubscription::BSerializable_getTypeId() {
	return 1409951761; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createSubscription::serialize(BIO& ar, const BVERSION version) {
	ar & this->watchGuid;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createSubscription::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createSubscription(ci, watchGuid, [__byps__asyncResult](PSubscription __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_323351719(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createSubscription::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1409951761(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createSubscription>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createUser
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createUser::BRequest_IXServicePortIF_createUser() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createUser::BRequest_IXServicePortIF_createUser(const ::std::wstring& rightsAsUserId)
	: BMethodRequest(1795705954) 
	, rightsAsUserId(rightsAsUserId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createUser::BSerializable_getTypeId() {
	return 1289528163; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createUser::serialize(BIO& ar, const BVERSION version) {
	ar & this->rightsAsUserId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createUser::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createUser(ci, rightsAsUserId, [__byps__asyncResult](PUserInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1485735592(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createUser::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1289528163(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createUser>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_createWFNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_createWFNode::BRequest_IXServicePortIF_createWFNode() : BMethodRequest(1795705954) {
	nodeId = 0;
	nodeTypeC = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_createWFNode::BRequest_IXServicePortIF_createWFNode(int32_t nodeId, int32_t nodeTypeC)
	: BMethodRequest(1795705954) 
	, nodeId(nodeId)
	, nodeTypeC(nodeTypeC)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_createWFNode::BSerializable_getTypeId() {
	return 2023998883; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_createWFNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->nodeId;
	ar & this->nodeTypeC;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_createWFNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->createWFNode(ci, nodeId, nodeTypeC, [__byps__asyncResult](PWFNode __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_2015686193(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_createWFNode::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2023998883(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_createWFNode>(bio, pObj, pObjS, pBase);	
}
}}}}

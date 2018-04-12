#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_beginForwardWorkflowNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_beginForwardWorkflowNode::BRequest_IXServicePortIF_beginForwardWorkflowNode() : BMethodRequest(1795705954) {
	flowId = 0;
	nodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_beginForwardWorkflowNode::BRequest_IXServicePortIF_beginForwardWorkflowNode(int32_t flowId, int32_t nodeId, const PBeginForwardWorkflowNodeInfo& fwdInfo, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, flowId(flowId)
	, nodeId(nodeId)
	, fwdInfo(fwdInfo)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_beginForwardWorkflowNode::BSerializable_getTypeId() {
	return 48774765; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_beginForwardWorkflowNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->flowId;
	ar & this->nodeId;
	ar & this->ci;
	ar & this->fwdInfo;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_beginForwardWorkflowNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->beginForwardWorkflowNode(ci, flowId, nodeId, fwdInfo, lockZ, [__byps__asyncResult](PWFEditNode __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1822579866(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_beginForwardWorkflowNode::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_48774765(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_beginForwardWorkflowNode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_changeSordMask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_changeSordMask::BRequest_IXServicePortIF_changeSordMask() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_changeSordMask::BRequest_IXServicePortIF_changeSordMask(const PSord& sord, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ)
	: BMethodRequest(1795705954) 
	, sord(sord)
	, maskId(maskId)
	, editInfoZ(editInfoZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_changeSordMask::BSerializable_getTypeId() {
	return 1393938400; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_changeSordMask::serialize(BIO& ar, const BVERSION version) {
	ar & this->maskId;
	ar & this->ci;
	ar & this->editInfoZ;
	ar & this->sord;
}
void de::elo::ix::client::BRequest_IXServicePortIF_changeSordMask::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->changeSordMask(ci, sord, maskId, editInfoZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_changeSordMask::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1393938400(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_changeSordMask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkLicense
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkLicense::BRequest_IXServicePortIF_checkLicense() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkLicense::BRequest_IXServicePortIF_checkLicense(const PLicenseInfo& licenseInfo)
	: BMethodRequest(1795705954) 
	, licenseInfo(licenseInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkLicense::BSerializable_getTypeId() {
	return 523346511; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkLicense::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->licenseInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkLicense::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkLicense(ci, licenseInfo, [__byps__asyncResult](PLicenseResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_545905411(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkLicense::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_523346511(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkLicense>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinActivity
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinActivity::BRequest_IXServicePortIF_checkinActivity() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinActivity::BRequest_IXServicePortIF_checkinActivity(const PActivity& act, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, act(act)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinActivity::BSerializable_getTypeId() {
	return 1990464102; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinActivity::serialize(BIO& ar, const BVERSION version) {
	ar & this->act;
	ar & this->ci;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinActivity::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinActivity(ci, act, unlockZ, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinActivity::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1990464102(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinActivity>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinActivityProject
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinActivityProject::BRequest_IXServicePortIF_checkinActivityProject() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinActivityProject::BRequest_IXServicePortIF_checkinActivityProject(const PActivityProject& actProj, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, actProj(actProj)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinActivityProject::BSerializable_getTypeId() {
	return 310669779; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinActivityProject::serialize(BIO& ar, const BVERSION version) {
	ar & this->actProj;
	ar & this->ci;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinActivityProject::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinActivityProject(ci, actProj, unlockZ, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinActivityProject::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_310669779(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinActivityProject>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinColors
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinColors::BRequest_IXServicePortIF_checkinColors() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinColors::BRequest_IXServicePortIF_checkinColors(const PArrayColorData& colors, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, colors(colors)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinColors::BSerializable_getTypeId() {
	return 1576322695; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinColors::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->colors;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinColors::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinColors(ci, colors, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinColors::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1576322695(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinColors>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinConfigFiles
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinConfigFiles::BRequest_IXServicePortIF_checkinConfigFiles() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFiles::BRequest_IXServicePortIF_checkinConfigFiles(const PArrayConfigFile& configFiles, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, configFiles(configFiles)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFiles::BSerializable_getTypeId() {
	return 1785918050; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinConfigFiles::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->configFiles;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFiles::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinConfigFiles(ci, configFiles, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFiles::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1785918050(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFiles>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinConfigFilesBegin
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinConfigFilesBegin::BRequest_IXServicePortIF_checkinConfigFilesBegin() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesBegin::BRequest_IXServicePortIF_checkinConfigFilesBegin(const PArrayString& names)
	: BMethodRequest(1795705954) 
	, names(names)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesBegin::BSerializable_getTypeId() {
	return 453135787; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinConfigFilesBegin::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->names;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesBegin::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinConfigFilesBegin(ci, names, [__byps__asyncResult](PArrayConfigFile __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesBegin::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_453135787(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesBegin>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinConfigFilesEnd
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinConfigFilesEnd::BRequest_IXServicePortIF_checkinConfigFilesEnd() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesEnd::BRequest_IXServicePortIF_checkinConfigFilesEnd(const PArrayConfigFile& configFiles, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, configFiles(configFiles)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesEnd::BSerializable_getTypeId() {
	return 1770305117; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinConfigFilesEnd::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->configFiles;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesEnd::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinConfigFilesEnd(ci, configFiles, unlockZ, [__byps__asyncResult](PArrayConfigFile __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesEnd::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1770305117(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesEnd>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinCounters
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinCounters::BRequest_IXServicePortIF_checkinCounters() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinCounters::BRequest_IXServicePortIF_checkinCounters(const PArrayCounterInfo& counterInfos, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, counterInfos(counterInfos)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinCounters::BSerializable_getTypeId() {
	return 1020556978; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinCounters::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->counterInfos;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinCounters::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinCounters(ci, counterInfos, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinCounters::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1020556978(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinCounters>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinCryptInfos
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinCryptInfos::BRequest_IXServicePortIF_checkinCryptInfos() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinCryptInfos::BRequest_IXServicePortIF_checkinCryptInfos(const PArrayCryptInfo& cryptInfos, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, cryptInfos(cryptInfos)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinCryptInfos::BSerializable_getTypeId() {
	return 1795186254; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinCryptInfos::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->cryptInfos;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinCryptInfos::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinCryptInfos(ci, cryptInfos, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinCryptInfos::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1795186254(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinCryptInfos>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocBegin
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocBegin::BRequest_IXServicePortIF_checkinDocBegin() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin::BRequest_IXServicePortIF_checkinDocBegin(const PDocument& document)
	: BMethodRequest(1795705954) 
	, document(document)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin::BSerializable_getTypeId() {
	return 165848488; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocBegin::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->document;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocBegin(ci, document, [__byps__asyncResult](PDocument __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_341056676(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_165848488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocBegin2
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocBegin2::BRequest_IXServicePortIF_checkinDocBegin2() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin2::BRequest_IXServicePortIF_checkinDocBegin2(const PSord& sord, const PDocument& document, const PCheckinDocOptions& opts)
	: BMethodRequest(1795705954) 
	, sord(sord)
	, document(document)
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin2::BSerializable_getTypeId() {
	return 846335882; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocBegin2::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->document;
	ar & this->opts;
	ar & this->sord;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin2::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocBegin2(ci, sord, document, opts, [__byps__asyncResult](PDocument __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_341056676(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin2::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_846335882(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin2>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocDupl
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocDupl::BRequest_IXServicePortIF_checkinDocDupl() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocDupl::BRequest_IXServicePortIF_checkinDocDupl(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, sord(sord)
	, sordZ(sordZ)
	, document(document)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocDupl::BSerializable_getTypeId() {
	return 1795690130; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocDupl::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->document;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocDupl::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocDupl(ci, sord, sordZ, document, unlockZ, [__byps__asyncResult](PDocument __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_341056676(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocDupl::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1795690130(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocDupl>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocEnd
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocEnd::BRequest_IXServicePortIF_checkinDocEnd() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocEnd::BRequest_IXServicePortIF_checkinDocEnd(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, sord(sord)
	, sordZ(sordZ)
	, document(document)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocEnd::BSerializable_getTypeId() {
	return 1604643226; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocEnd::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->document;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocEnd::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocEnd(ci, sord, sordZ, document, unlockZ, [__byps__asyncResult](PDocument __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_341056676(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocEnd::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1604643226(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocEnd>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocMask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocMask::BRequest_IXServicePortIF_checkinDocMask() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMask::BRequest_IXServicePortIF_checkinDocMask(const PDocMask& docMask, const PDocMaskZ& docMaskZ, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, docMask(docMask)
	, docMaskZ(docMaskZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMask::BSerializable_getTypeId() {
	return 1795441139; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocMask::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->docMask;
	ar & this->docMaskZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMask::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocMask(ci, docMask, docMaskZ, unlockZ, [__byps__asyncResult](int32_t __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMask::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1795441139(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocMaskLineTemplate
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocMaskLineTemplate::BRequest_IXServicePortIF_checkinDocMaskLineTemplate() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMaskLineTemplate::BRequest_IXServicePortIF_checkinDocMaskLineTemplate(const PDocMaskLineTemplate& dmlt, const PDocMaskLineTemplateZ& dmltZ, const PCheckInDocMaskLineTemplateOptions& options, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, dmlt(dmlt)
	, dmltZ(dmltZ)
	, options(options)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMaskLineTemplate::BSerializable_getTypeId() {
	return 702278853; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocMaskLineTemplate::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->dmlt;
	ar & this->dmltZ;
	ar & this->lockZ;
	ar & this->options;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMaskLineTemplate::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocMaskLineTemplate(ci, dmlt, dmltZ, options, lockZ, [__byps__asyncResult](int32_t __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMaskLineTemplate::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_702278853(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMaskLineTemplate>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocsBegin
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocsBegin::BRequest_IXServicePortIF_checkinDocsBegin() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsBegin::BRequest_IXServicePortIF_checkinDocsBegin(const PArrayDocument& documents)
	: BMethodRequest(1795705954) 
	, documents(documents)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsBegin::BSerializable_getTypeId() {
	return 2078187849; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocsBegin::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->documents;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsBegin::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocsBegin(ci, documents, [__byps__asyncResult](PArrayDocument __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1047127860(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsBegin::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2078187849(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsBegin>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinDocsEnd
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinDocsEnd::BRequest_IXServicePortIF_checkinDocsEnd() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsEnd::BRequest_IXServicePortIF_checkinDocsEnd(const PArraySord& sords, const PArraySordZ& sordZs, const PArrayDocument& documents, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, sords(sords)
	, sordZs(sordZs)
	, documents(documents)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsEnd::BSerializable_getTypeId() {
	return 1794336151; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinDocsEnd::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->documents;
	ar & this->sordZs;
	ar & this->sords;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsEnd::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinDocsEnd(ci, sords, sordZs, documents, unlockZ, [__byps__asyncResult](PArrayDocument __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1047127860(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsEnd::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1794336151(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsEnd>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinKeys
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinKeys::BRequest_IXServicePortIF_checkinKeys() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinKeys::BRequest_IXServicePortIF_checkinKeys(const PArrayKeyInfo& keyInfos, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, keyInfos(keyInfos)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinKeys::BSerializable_getTypeId() {
	return 573935819; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinKeys::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->keyInfos;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinKeys::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinKeys(ci, keyInfos, unlockZ, [__byps__asyncResult](PArrayInt __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_100361105(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_checkinKeys::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_573935819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinKeys>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinKeywordList
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinKeywordList::BRequest_IXServicePortIF_checkinKeywordList() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywordList::BRequest_IXServicePortIF_checkinKeywordList(const PKeywordList& kwList, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, kwList(kwList)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywordList::BSerializable_getTypeId() {
	return 1216164720; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinKeywordList::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->kwList;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywordList::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinKeywordList(ci, kwList, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywordList::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1216164720(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywordList>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_checkinKeywords
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_checkinKeywords::BRequest_IXServicePortIF_checkinKeywords() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywords::BRequest_IXServicePortIF_checkinKeywords(const PArrayKeyword& kws, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, kws(kws)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywords::BSerializable_getTypeId() {
	return 125387007; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_checkinKeywords::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->kws;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywords::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->checkinKeywords(ci, kws, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywords::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_125387007(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywords>(bio, pObj, pObjS, pBase);	
}
}}}}

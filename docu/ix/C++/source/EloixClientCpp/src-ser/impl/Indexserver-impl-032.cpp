#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkFlowHead
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkFlowHead::WorkFlowHead() {
	flowId = 0;
	status = 0;
	type = 0;
	parentWorkflow = 0;
	callNodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkFlowHead::WorkFlowHead(int32_t flowId, const ::std::wstring& tStamp, const ::std::wstring& guid, int32_t status, int32_t type, const ::std::wstring& actServerId, int32_t parentWorkflow, int32_t callNodeId)
	: flowId(flowId)
	, tStamp(tStamp)
	, guid(guid)
	, status(status)
	, type(type)
	, actServerId(actServerId)
	, parentWorkflow(parentWorkflow)
	, callNodeId(callNodeId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkFlowHead::BSerializable_getTypeId() {
	return 37271022; 
}
void WorkFlowHead::setFlowId(int32_t v) {
	flowId = v;
	setChangedMember(WorkFlowHeadC::mbFlowId);
}
void WorkFlowHead::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(WorkFlowHeadC::mbTStamp);
}
void WorkFlowHead::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(WorkFlowHeadC::mbGuid);
}
void WorkFlowHead::setStatus(int32_t v) {
	status = v;
	setChangedMember(WorkFlowHeadC::mbStatus);
}
void WorkFlowHead::setType(int32_t v) {
	type = v;
	setChangedMember(WorkFlowHeadC::mbType);
}
void WorkFlowHead::setActServerId(::std::wstring v) {
	actServerId = v;
	setChangedMember(WorkFlowHeadC::mbActServerId);
}
void WorkFlowHead::setParentWorkflow(int32_t v) {
	parentWorkflow = v;
	setChangedMember(WorkFlowHeadC::mbParentWorkflow);
}
void WorkFlowHead::setCallNodeId(int32_t v) {
	callNodeId = v;
	setChangedMember(WorkFlowHeadC::mbCallNodeId);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkFlowHead::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flowId;
	ar & this->guid;
	ar & this->status;
	ar & this->tStamp;
	if (version >= 700000000000014) {
		ar & this->actServerId;
		ar & this->type;
		if (version >= 900000030000022) {
			ar & this->parentWorkflow;
			if (version >= 1000000000000004) {
				ar & this->callNodeId;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_37271022(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkFlowHead>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkFlowHeadC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkFlowHeadC::WorkFlowHeadC() {
	lnTStamp = 0;
	lnGuid = 0;
	lnActServerId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkFlowHeadC::WorkFlowHeadC(int64_t mbFlowId, int64_t mbTStamp, int32_t lnTStamp, int64_t mbGuid, int32_t lnGuid, int64_t mbStatus, int64_t mbType, int64_t mbActServerId, int32_t lnActServerId, int64_t mbParentWorkflow, int64_t mbCallNodeId, int64_t mbAllMembers)
	: lnTStamp(lnTStamp)
	, lnGuid(lnGuid)
	, lnActServerId(lnActServerId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkFlowHeadC::BSerializable_getTypeId() {
	return 807993720; 
}
void WorkFlowHeadC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void WorkFlowHeadC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void WorkFlowHeadC::setLnActServerId(int32_t v) {
	lnActServerId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkFlowHeadC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnGuid;
	ar & this->lnTStamp;
	if (version >= 700000000000014) {
		ar & this->lnActServerId;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_807993720(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkFlowHeadC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkFlowNodeMatrix
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkFlowNodeMatrix::WorkFlowNodeMatrix() {
	flowId = 0;
	nodeId = 0;
	isNext = 0;
	terminate = 0;
	succType = 0;
	succ_0 = 0;
	succ_1 = 0;
	succ_2 = 0;
	succ_3 = 0;
	succ_4 = 0;
	succ_5 = 0;
	succ_6 = 0;
	succ_7 = 0;
	succ_8 = 0;
	succ_9 = 0;
	succ_10 = 0;
	succ_11 = 0;
	succ_12 = 0;
	succ_13 = 0;
	succ_14 = 0;
	succ_15 = 0;
	succ_16 = 0;
	succ_17 = 0;
	succ_18 = 0;
	succ_19 = 0;
	succOvertime = 0;
	versionId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkFlowNodeMatrix::WorkFlowNodeMatrix(int32_t flowId, int32_t nodeId, int32_t isNext, int32_t terminate, int32_t succType, int32_t succ_0, int32_t succ_1, int32_t succ_2, int32_t succ_3, int32_t succ_4, int32_t succ_5, int32_t succ_6, int32_t succ_7, int32_t succ_8, int32_t succ_9, int32_t succ_10, int32_t succ_11, int32_t succ_12, int32_t succ_13, int32_t succ_14, int32_t succ_15, int32_t succ_16, int32_t succ_17, int32_t succ_18, int32_t succ_19, int32_t succOvertime, int32_t versionId)
	: flowId(flowId)
	, nodeId(nodeId)
	, isNext(isNext)
	, terminate(terminate)
	, succType(succType)
	, succ_0(succ_0)
	, succ_1(succ_1)
	, succ_2(succ_2)
	, succ_3(succ_3)
	, succ_4(succ_4)
	, succ_5(succ_5)
	, succ_6(succ_6)
	, succ_7(succ_7)
	, succ_8(succ_8)
	, succ_9(succ_9)
	, succ_10(succ_10)
	, succ_11(succ_11)
	, succ_12(succ_12)
	, succ_13(succ_13)
	, succ_14(succ_14)
	, succ_15(succ_15)
	, succ_16(succ_16)
	, succ_17(succ_17)
	, succ_18(succ_18)
	, succ_19(succ_19)
	, succOvertime(succOvertime)
	, versionId(versionId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkFlowNodeMatrix::BSerializable_getTypeId() {
	return 1337377725; 
}
void WorkFlowNodeMatrix::setFlowId(int32_t v) {
	flowId = v;
	setChangedMember(WorkFlowNodeMatrixC::mbFlowId);
}
void WorkFlowNodeMatrix::setNodeId(int32_t v) {
	nodeId = v;
	setChangedMember(WorkFlowNodeMatrixC::mbNodeId);
}
void WorkFlowNodeMatrix::setIsNext(int32_t v) {
	isNext = v;
	setChangedMember(WorkFlowNodeMatrixC::mbIsNext);
}
void WorkFlowNodeMatrix::setTerminate(int32_t v) {
	terminate = v;
	setChangedMember(WorkFlowNodeMatrixC::mbTerminate);
}
void WorkFlowNodeMatrix::setSuccType(int32_t v) {
	succType = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSuccType);
}
void WorkFlowNodeMatrix::setSucc_0(int32_t v) {
	succ_0 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_0);
}
void WorkFlowNodeMatrix::setSucc_1(int32_t v) {
	succ_1 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_1);
}
void WorkFlowNodeMatrix::setSucc_2(int32_t v) {
	succ_2 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_2);
}
void WorkFlowNodeMatrix::setSucc_3(int32_t v) {
	succ_3 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_3);
}
void WorkFlowNodeMatrix::setSucc_4(int32_t v) {
	succ_4 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_4);
}
void WorkFlowNodeMatrix::setSucc_5(int32_t v) {
	succ_5 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_5);
}
void WorkFlowNodeMatrix::setSucc_6(int32_t v) {
	succ_6 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_6);
}
void WorkFlowNodeMatrix::setSucc_7(int32_t v) {
	succ_7 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_7);
}
void WorkFlowNodeMatrix::setSucc_8(int32_t v) {
	succ_8 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_8);
}
void WorkFlowNodeMatrix::setSucc_9(int32_t v) {
	succ_9 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_9);
}
void WorkFlowNodeMatrix::setSucc_10(int32_t v) {
	succ_10 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_10);
}
void WorkFlowNodeMatrix::setSucc_11(int32_t v) {
	succ_11 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_11);
}
void WorkFlowNodeMatrix::setSucc_12(int32_t v) {
	succ_12 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_12);
}
void WorkFlowNodeMatrix::setSucc_13(int32_t v) {
	succ_13 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_13);
}
void WorkFlowNodeMatrix::setSucc_14(int32_t v) {
	succ_14 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_14);
}
void WorkFlowNodeMatrix::setSucc_15(int32_t v) {
	succ_15 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_15);
}
void WorkFlowNodeMatrix::setSucc_16(int32_t v) {
	succ_16 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_16);
}
void WorkFlowNodeMatrix::setSucc_17(int32_t v) {
	succ_17 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_17);
}
void WorkFlowNodeMatrix::setSucc_18(int32_t v) {
	succ_18 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_18);
}
void WorkFlowNodeMatrix::setSucc_19(int32_t v) {
	succ_19 = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSucc_19);
}
void WorkFlowNodeMatrix::setSuccOvertime(int32_t v) {
	succOvertime = v;
	setChangedMember(WorkFlowNodeMatrixC::mbSuccOvertime);
}
void WorkFlowNodeMatrix::setVersionId(int32_t v) {
	versionId = v;
	setChangedMember(WorkFlowNodeMatrixC::mbVersionId);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkFlowNodeMatrix::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flowId;
	ar & this->isNext;
	ar & this->nodeId;
	ar & this->succType;
	ar & this->succ_0;
	ar & this->succ_1;
	ar & this->succ_10;
	ar & this->succ_11;
	ar & this->succ_12;
	ar & this->succ_13;
	ar & this->succ_14;
	ar & this->succ_15;
	ar & this->succ_16;
	ar & this->succ_17;
	ar & this->succ_18;
	ar & this->succ_19;
	ar & this->succ_2;
	ar & this->succ_3;
	ar & this->succ_4;
	ar & this->succ_5;
	ar & this->succ_6;
	ar & this->succ_7;
	ar & this->succ_8;
	ar & this->succ_9;
	ar & this->terminate;
	if (version >= 700000000000008) {
		ar & this->versionId;
		if (version >= 900000030000018) {
			ar & this->succOvertime;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1337377725(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkFlowNodeMatrix>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkFlowNodeMatrixC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkFlowNodeMatrixC::WorkFlowNodeMatrixC() {
	lnEdgesOrdinals = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkFlowNodeMatrixC::WorkFlowNodeMatrixC(int64_t mbEdgesOrdinals, int32_t lnEdgesOrdinals, int64_t mbFlowId, int64_t mbNodeId, int64_t mbIsNext, int64_t mbTerminate, int64_t mbSuccType, int64_t mbSucc_0, int64_t mbSucc_1, int64_t mbSucc_2, int64_t mbSucc_3, int64_t mbSucc_4, int64_t mbSucc_5, int64_t mbSucc_6, int64_t mbSucc_7, int64_t mbSucc_8, int64_t mbSucc_9, int64_t mbSucc_10, int64_t mbSucc_11, int64_t mbSucc_12, int64_t mbSucc_13, int64_t mbSucc_14, int64_t mbSucc_15, int64_t mbSucc_16, int64_t mbSucc_17, int64_t mbSucc_18, int64_t mbSucc_19, int64_t mbSuccOvertime, int64_t mbVersionId, int64_t mbAllMembers)
	: lnEdgesOrdinals(lnEdgesOrdinals)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkFlowNodeMatrixC::BSerializable_getTypeId() {
	return 813423307; 
}
void WorkFlowNodeMatrixC::setLnEdgesOrdinals(int32_t v) {
	lnEdgesOrdinals = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkFlowNodeMatrixC::serialize(BIO& ar, const BVERSION version) {
	if (version >= 900000030000014) {
		ar & this->lnEdgesOrdinals;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_813423307(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkFlowNodeMatrixC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkflowExchangeInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkflowExchangeInfo::WorkflowExchangeInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkflowExchangeInfo::WorkflowExchangeInfo(const PWFDiagram& workflow, const PMapIntegerUserName& userNames, const PMapIntegerWFDiagram& subWorkflowMap, const PArrayWFDiagram& workflowVersions, const byps_ptr< ::std::map< int32_t , PVectorWFDiagram > >& subWorkflowVersionMap)
	: workflow(workflow)
	, userNames(userNames)
	, subWorkflowMap(subWorkflowMap)
	, workflowVersions(workflowVersions)
	, subWorkflowVersionMap(subWorkflowVersionMap)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkflowExchangeInfo::BSerializable_getTypeId() {
	return 2070549585; 
}
void WorkflowExchangeInfo::setWorkflow(PWFDiagram v) {
	workflow = v;
}
void WorkflowExchangeInfo::setUserNames(PMapIntegerUserName v) {
	userNames = v;
}
void WorkflowExchangeInfo::setSubWorkflowMap(PMapIntegerWFDiagram v) {
	subWorkflowMap = v;
}
void WorkflowExchangeInfo::setWorkflowVersions(PArrayWFDiagram v) {
	workflowVersions = v;
}
void WorkflowExchangeInfo::setSubWorkflowVersionMap(byps_ptr< ::std::map< int32_t , PVectorWFDiagram > > v) {
	subWorkflowVersionMap = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkflowExchangeInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->userNames;
	ar & this->workflow;
	ar & this->workflowVersions;
	if (version >= 900000030000022) {
		ar & this->subWorkflowMap;
		ar & this->subWorkflowVersionMap;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2070549585(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkflowExchangeInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkflowExportOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkflowExportOptions::WorkflowExportOptions() {
	format = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkflowExportOptions::WorkflowExportOptions(const ::std::wstring& flowId, const ::std::wstring& flowVersId, const ::std::wstring& characterSet, const ::std::wstring& wordWrap, int32_t format)
	: flowId(flowId)
	, flowVersId(flowVersId)
	, characterSet(characterSet)
	, wordWrap(wordWrap)
	, format(format)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkflowExportOptions::BSerializable_getTypeId() {
	return 402835780; 
}
void WorkflowExportOptions::setFlowId(::std::wstring v) {
	flowId = v;
}
void WorkflowExportOptions::setFlowVersId(::std::wstring v) {
	flowVersId = v;
}
void WorkflowExportOptions::setCharacterSet(::std::wstring v) {
	characterSet = v;
}
void WorkflowExportOptions::setWordWrap(::std::wstring v) {
	wordWrap = v;
}
void WorkflowExportOptions::setFormat(int32_t v) {
	format = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkflowExportOptions::serialize(BIO& ar, const BVERSION version) {
	ar & this->characterSet;
	ar & this->flowId;
	ar & this->flowVersId;
	ar & this->wordWrap;
	if (version >= 900000016000017) {
		ar & this->format;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_402835780(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkflowExportOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkflowExportOptionsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkflowExportOptionsC::WorkflowExportOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkflowExportOptionsC::BSerializable_getTypeId() {
	return 1063132081; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkflowExportOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1063132081(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkflowExportOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkflowImportOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkflowImportOptions::WorkflowImportOptions() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkflowImportOptions::WorkflowImportOptions(const ::std::wstring& replaceMissingUserByUserId)
	: replaceMissingUserByUserId(replaceMissingUserByUserId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkflowImportOptions::BSerializable_getTypeId() {
	return 449037977; 
}
void WorkflowImportOptions::setReplaceMissingUserByUserId(::std::wstring v) {
	replaceMissingUserByUserId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkflowImportOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->replaceMissingUserByUserId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_449037977(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkflowImportOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkflowNodeInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkflowNodeInfo::WorkflowNodeInfo() {
	flags = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkflowNodeInfo::WorkflowNodeInfo(const ::std::wstring& nodeName, int32_t flags, const ::std::wstring& workflow)
	: nodeName(nodeName)
	, flags(flags)
	, workflow(workflow)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkflowNodeInfo::BSerializable_getTypeId() {
	return 1659862348; 
}
void WorkflowNodeInfo::setNodeName(::std::wstring v) {
	nodeName = v;
}
void WorkflowNodeInfo::setFlags(int32_t v) {
	flags = v;
}
void WorkflowNodeInfo::setWorkflow(::std::wstring v) {
	workflow = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkflowNodeInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flags;
	ar & this->nodeName;
	ar & this->workflow;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1659862348(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkflowNodeInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

//-------------------------------------------------
// Implementation of class BRequest_RawStreamService_download
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_RawStreamService_download::BRequest_RawStreamService_download() : BMethodRequest(354585327) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::compatibility::BRequest_RawStreamService_download::BRequest_RawStreamService_download(const PArrayString& params)
	: BMethodRequest(354585327) 
	, params(params)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::compatibility::BRequest_RawStreamService_download::BSerializable_getTypeId() {
	return 280725475; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_RawStreamService_download::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->params;
}
void de::elo::ix::client::compatibility::BRequest_RawStreamService_download::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PRawStreamService __byps__remoteT = byps_ptr_cast<RawStreamService>(__byps__remote);
	__byps__remoteT->download(ci, params, [__byps__asyncResult](PContentStream __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_15(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::compatibility::BRequest_RawStreamService_download::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_280725475(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::compatibility::BRequest_RawStreamService_download>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

//-------------------------------------------------
// Implementation of class BRequest_RawStreamService_upload
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_RawStreamService_upload::BRequest_RawStreamService_upload() : BMethodRequest(354585327) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::compatibility::BRequest_RawStreamService_upload::BRequest_RawStreamService_upload(const PArrayString& params, const PContentStream& is)
	: BMethodRequest(354585327) 
	, params(params)
	, is(is)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::compatibility::BRequest_RawStreamService_upload::BSerializable_getTypeId() {
	return 527524138; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_RawStreamService_upload::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->is;
	ar & this->params;
}
void de::elo::ix::client::compatibility::BRequest_RawStreamService_upload::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PRawStreamService __byps__remoteT = byps_ptr_cast<RawStreamService>(__byps__remote);
	__byps__remoteT->upload(ci, params, is, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::compatibility::BRequest_RawStreamService_upload::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_527524138(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::compatibility::BRequest_RawStreamService_upload>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

//-------------------------------------------------
// Implementation of class BRequest_WClientService_onAfterVersionChanged
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_WClientService_onAfterVersionChanged::BRequest_WClientService_onAfterVersionChanged() : BMethodRequest(1887299447) {
	objId = 0;
	docId = 0;
	flags = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::compatibility::BRequest_WClientService_onAfterVersionChanged::BRequest_WClientService_onAfterVersionChanged(int32_t objId, int32_t docId, int32_t flags)
	: BMethodRequest(1887299447) 
	, objId(objId)
	, docId(docId)
	, flags(flags)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::compatibility::BRequest_WClientService_onAfterVersionChanged::BSerializable_getTypeId() {
	return 2095806986; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_WClientService_onAfterVersionChanged::serialize(BIO& ar, const BVERSION version) {
	ar & this->docId;
	ar & this->flags;
	ar & this->objId;
	ar & this->ci;
}
void de::elo::ix::client::compatibility::BRequest_WClientService_onAfterVersionChanged::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PWClientService __byps__remoteT = byps_ptr_cast<WClientService>(__byps__remote);
	__byps__remoteT->onAfterVersionChanged(ci, objId, docId, flags, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::compatibility::BRequest_WClientService_onAfterVersionChanged::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2095806986(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::compatibility::BRequest_WClientService_onAfterVersionChanged>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

//-------------------------------------------------
// Implementation of class WClientC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WClientC::WClientC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::compatibility::WClientC::BSerializable_getTypeId() {
	return 1800529481; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WClientC::serialize(BIO& ar, const BVERSION version) {
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1800529481(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::compatibility::WClientC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class Action
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Action::Action() {
	type = de::elo::ix::client::feed::EActionType::Undefined;
	userId = 0;
	changeCounter = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::Action::Action(const ::std::wstring& guid, EActionType type, const ::std::wstring& feedGuid, const ::std::wstring& parentGuid, const ::std::wstring& userGuid, int32_t userId, const ::std::wstring& userName, const ::std::wstring& createDateIso, const ::std::wstring& updateDateIso, int32_t changeCounter, const ::std::wstring& text, const ::std::wstring& docVersionGuid, const de::elo::ix::client::PDocVersion& docVersion, const ::std::wstring& workflowGuid, const de::elo::ix::client::PWFDiagram& workflow, const ::std::wstring& TStamp, const PVectorActionHistory& history, const ::std::wstring& acl, const de::elo::ix::client::PArrayAclItem& aclItems, const ::std::wstring& TStampSync)
	: guid(guid)
	, type(type)
	, feedGuid(feedGuid)
	, parentGuid(parentGuid)
	, userGuid(userGuid)
	, userId(userId)
	, userName(userName)
	, createDateIso(createDateIso)
	, updateDateIso(updateDateIso)
	, changeCounter(changeCounter)
	, text(text)
	, docVersionGuid(docVersionGuid)
	, docVersion(docVersion)
	, workflowGuid(workflowGuid)
	, workflow(workflow)
	, TStamp(TStamp)
	, history(history)
	, acl(acl)
	, aclItems(aclItems)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::Action::BSerializable_getTypeId() {
	return 736351635; 
}
void Action::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(ActionC::mbGuid);
}
void Action::setType(EActionType v) {
	type = v;
}
void Action::setFeedGuid(::std::wstring v) {
	feedGuid = v;
	setChangedMember(ActionC::mbFeedGuid);
}
void Action::setParentGuid(::std::wstring v) {
	parentGuid = v;
	setChangedMember(ActionC::mbParentGuid);
}
void Action::setUserGuid(::std::wstring v) {
	userGuid = v;
	setChangedMember(ActionC::mbUserGuid);
}
void Action::setUserId(int32_t v) {
	userId = v;
}
void Action::setUserName(::std::wstring v) {
	userName = v;
}
void Action::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(ActionC::mbCreateDateIso);
}
void Action::setUpdateDateIso(::std::wstring v) {
	updateDateIso = v;
	setChangedMember(ActionC::mbUpdateDateIso);
}
void Action::setChangeCounter(int32_t v) {
	changeCounter = v;
	setChangedMember(ActionC::mbChangeCounter);
}
void Action::setText(::std::wstring v) {
	text = v;
	setChangedMember(ActionC::mbText);
}
void Action::setDocVersionGuid(::std::wstring v) {
	docVersionGuid = v;
	setChangedMember(ActionC::mbDocVersionGuid);
}
void Action::setDocVersion(de::elo::ix::client::PDocVersion v) {
	docVersion = v;
	setChangedMember(ActionC::mbDocVersion);
}
void Action::setWorkflowGuid(::std::wstring v) {
	workflowGuid = v;
	setChangedMember(ActionC::mbWorkflowGuid);
}
void Action::setWorkflow(de::elo::ix::client::PWFDiagram v) {
	workflow = v;
	setChangedMember(ActionC::mbWorkflow);
}
void Action::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(ActionC::mbTStamp);
}
void Action::setHistory(PVectorActionHistory v) {
	history = v;
	setChangedMember(ActionC::mbHistory);
}
void Action::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(ActionC::mbAcl);
}
void Action::setAclItems(de::elo::ix::client::PArrayAclItem v) {
	aclItems = v;
}
void Action::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(ActionC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Action::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->changeCounter;
	ar & this->createDateIso;
	ar & this->docVersionGuid;
	ar & this->feedGuid;
	ar & this->guid;
	ar & this->parentGuid;
	ar & this->text;
	ar & this->type;
	ar & this->updateDateIso;
	ar & this->userGuid;
	ar & this->userId;
	ar & this->userName;
	ar & this->workflowGuid;
	if (version >= 900000000000034) {
		ar & this->acl;
		if (version >= 900990009000001) {
			ar & this->TStampSync;
		}
	}
	ar & this->docVersion;
	ar & this->workflow;
	if (version >= 900000000000033) {
		ar & this->history;
		if (version >= 900000000000034) {
			ar & this->aclItems;
		}
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_736351635(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::Action>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class ActionDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActionDataC::ActionDataC() {
	lnGuid = 0;
	lnFeedGuid = 0;
	lnParentGuid = 0;
	lnUserGuid = 0;
	lnCreateDateIso = 0;
	lnUpdateDateIso = 0;
	lnText = 0;
	lnDocVersionGuid = 0;
	lnWorkflowGuid = 0;
	lnTStamp = 0;
	lnAcl = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::ActionDataC::ActionDataC(int64_t mbGuid, int32_t lnGuid, int64_t mbRawType, int64_t mbFeedGuid, int32_t lnFeedGuid, int64_t mbParentGuid, int32_t lnParentGuid, int64_t mbUserGuid, int32_t lnUserGuid, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbUpdateDateIso, int32_t lnUpdateDateIso, int64_t mbChangeCounter, int64_t mbText, int32_t lnText, int64_t mbDocVersionGuid, int32_t lnDocVersionGuid, int64_t mbWorkflowGuid, int32_t lnWorkflowGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbAcl, int32_t lnAcl, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnFeedGuid(lnFeedGuid)
	, lnParentGuid(lnParentGuid)
	, lnUserGuid(lnUserGuid)
	, lnCreateDateIso(lnCreateDateIso)
	, lnUpdateDateIso(lnUpdateDateIso)
	, lnText(lnText)
	, lnDocVersionGuid(lnDocVersionGuid)
	, lnWorkflowGuid(lnWorkflowGuid)
	, lnTStamp(lnTStamp)
	, lnAcl(lnAcl)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::ActionDataC::BSerializable_getTypeId() {
	return 423487901; 
}
void ActionDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void ActionDataC::setLnFeedGuid(int32_t v) {
	lnFeedGuid = v;
}
void ActionDataC::setLnParentGuid(int32_t v) {
	lnParentGuid = v;
}
void ActionDataC::setLnUserGuid(int32_t v) {
	lnUserGuid = v;
}
void ActionDataC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
void ActionDataC::setLnUpdateDateIso(int32_t v) {
	lnUpdateDateIso = v;
}
void ActionDataC::setLnText(int32_t v) {
	lnText = v;
}
void ActionDataC::setLnDocVersionGuid(int32_t v) {
	lnDocVersionGuid = v;
}
void ActionDataC::setLnWorkflowGuid(int32_t v) {
	lnWorkflowGuid = v;
}
void ActionDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void ActionDataC::setLnAcl(int32_t v) {
	lnAcl = v;
}
void ActionDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActionDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCreateDateIso;
	ar & this->lnDocVersionGuid;
	ar & this->lnFeedGuid;
	ar & this->lnGuid;
	ar & this->lnParentGuid;
	ar & this->lnTStamp;
	ar & this->lnText;
	ar & this->lnUpdateDateIso;
	ar & this->lnUserGuid;
	ar & this->lnWorkflowGuid;
	if (version >= 900000000000034) {
		ar & this->lnAcl;
		if (version >= 900990009000001) {
			ar & this->lnTStampSync;
		}
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_423487901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::ActionDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class ActionC
// Generated from class byps.gen.cpp.GenApiClass

const PActionZ ActionC::mbMin = PActionZ(new ActionZ(
	-7696581394689LL));

const PActionZ ActionC::mbAll = PActionZ(new ActionZ(
	-1LL));

// checkpoint byps.gen.cpp.GenApiClass:489
ActionC::ActionC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::ActionC::BSerializable_getTypeId() {
	return 1988394652; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActionC::serialize(BIO& ar, const BVERSION version) {
	ActionDataC::serialize(ar, version);
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1988394652(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::ActionC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class ActionHistDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActionHistDataC::ActionHistDataC() {
	lnActionGuid = 0;
	lnCreateDateIso = 0;
	lnText = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::ActionHistDataC::ActionHistDataC(int64_t mbActionGuid, int32_t lnActionGuid, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbText, int32_t lnText, int64_t mbAllMembers)
	: lnActionGuid(lnActionGuid)
	, lnCreateDateIso(lnCreateDateIso)
	, lnText(lnText)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::ActionHistDataC::BSerializable_getTypeId() {
	return 734763371; 
}
void ActionHistDataC::setLnActionGuid(int32_t v) {
	lnActionGuid = v;
}
void ActionHistDataC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
void ActionHistDataC::setLnText(int32_t v) {
	lnText = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActionHistDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnActionGuid;
	ar & this->lnCreateDateIso;
	ar & this->lnText;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_734763371(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::ActionHistDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class ActionHistory
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActionHistory::ActionHistory() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::ActionHistory::ActionHistory(const ::std::wstring& actionGuid, const ::std::wstring& createDateIso, const ::std::wstring& text)
	: actionGuid(actionGuid)
	, createDateIso(createDateIso)
	, text(text)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::ActionHistory::BSerializable_getTypeId() {
	return 598833764; 
}
void ActionHistory::setActionGuid(::std::wstring v) {
	actionGuid = v;
	setChangedMember(ActionHistoryC::mbActionGuid);
}
void ActionHistory::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(ActionHistoryC::mbCreateDateIso);
}
void ActionHistory::setText(::std::wstring v) {
	text = v;
	setChangedMember(ActionHistoryC::mbText);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActionHistory::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->actionGuid;
	ar & this->createDateIso;
	ar & this->text;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_598833764(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::ActionHistory>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class ActionHistoryC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActionHistoryC::ActionHistoryC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::ActionHistoryC::BSerializable_getTypeId() {
	return 442981425; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActionHistoryC::serialize(BIO& ar, const BVERSION version) {
	ActionHistDataC::serialize(ar, version);
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_442981425(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::ActionHistoryC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class ActionZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActionZ::ActionZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::ActionZ::ActionZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::ActionZ::BSerializable_getTypeId() {
	return 1006784044; 
}
void ActionZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActionZ::serialize(BIO& ar, const BVERSION version) {
	ar & this->bset;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1006784044(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::ActionZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_433625553(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::feed::PAction > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedNotification_updateAction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedNotification_updateAction::BRequest_FeedNotification_updateAction() : BMethodRequest(320199695) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedNotification_updateAction::BRequest_FeedNotification_updateAction(const PAction& action)
	: BMethodRequest(320199695) 
	, action(action)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedNotification_updateAction::BSerializable_getTypeId() {
	return 688797212; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedNotification_updateAction::serialize(BIO& ar, const BVERSION version) {
	ar & this->action;
}
void de::elo::ix::client::feed::BRequest_FeedNotification_updateAction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedNotification __byps__remoteT = byps_ptr_cast<FeedNotification>(__byps__remote);
	__byps__remoteT->updateAction(action, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_688797212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedNotification_updateAction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_checkinAction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_checkinAction::BRequest_FeedService_checkinAction() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_checkinAction::BRequest_FeedService_checkinAction(const PAction& action, const PActionZ& actionZ)
	: BMethodRequest(1670701039) 
	, action(action)
	, actionZ(actionZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_checkinAction::BSerializable_getTypeId() {
	return 1138765790; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_checkinAction::serialize(BIO& ar, const BVERSION version) {
	ar & this->action;
	ar & this->actionZ;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_checkinAction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->checkinAction(ci, action, actionZ, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_checkinAction::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1138765790(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_checkinAction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_checkoutAction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_checkoutAction::BRequest_FeedService_checkoutAction() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_checkoutAction::BRequest_FeedService_checkoutAction(const ::std::wstring& actionGuid, const PActionZ& actionZ)
	: BMethodRequest(1670701039) 
	, actionGuid(actionGuid)
	, actionZ(actionZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_checkoutAction::BSerializable_getTypeId() {
	return 1737190301; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_checkoutAction::serialize(BIO& ar, const BVERSION version) {
	ar & this->actionGuid;
	ar & this->actionZ;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_checkoutAction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->checkoutAction(ci, actionGuid, actionZ, [__byps__asyncResult](PAction __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_736351635(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_checkoutAction::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1737190301(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_checkoutAction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_checkoutHashTag
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_checkoutHashTag::BRequest_FeedService_checkoutHashTag() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_checkoutHashTag::BRequest_FeedService_checkoutHashTag(const ::std::wstring& hashtagGuidOrName, const PHashTagZ& hstgZ)
	: BMethodRequest(1670701039) 
	, hashtagGuidOrName(hashtagGuidOrName)
	, hstgZ(hstgZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_checkoutHashTag::BSerializable_getTypeId() {
	return 122354907; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_checkoutHashTag::serialize(BIO& ar, const BVERSION version) {
	ar & this->hashtagGuidOrName;
	ar & this->ci;
	ar & this->hstgZ;
}
void de::elo::ix::client::feed::BRequest_FeedService_checkoutHashTag::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->checkoutHashTag(ci, hashtagGuidOrName, hstgZ, [__byps__asyncResult](PHashTag __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1143177929(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_checkoutHashTag::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_122354907(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_checkoutHashTag>(bio, pObj, pObjS, pBase);	
}
}}}}

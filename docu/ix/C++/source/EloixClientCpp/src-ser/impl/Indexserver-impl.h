#ifndef __Indexserver_impl_H__
#define __Indexserver_impl_H__

#include "Byps-impl.h"
#include "Indexserver-api.h"


// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXEventBusHandler_processEventBusEvents
// typeId=1736645961

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXEventBusHandler_processEventBusEvents : public BMethodRequest {
	public: int64_t subsId;
	public: PArrayEvent events;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXEventBusHandler_processEventBusEvents();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXEventBusHandler_processEventBusEvents(int64_t subsId, const PArrayEvent& events);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_executeRegisteredFunction
// typeId=1363890826

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_executeRegisteredFunction : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring functionName;
	public: PAny any;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_executeRegisteredFunction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_executeRegisteredFunction(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const PAny& any);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_executeRegisteredFunctionString
// typeId=1679329575

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_executeRegisteredFunctionString : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring functionName;
	public: ::std::wstring args;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_executeRegisteredFunctionString();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_executeRegisteredFunctionString(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const ::std::wstring& args);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_getAppInfo
// typeId=1887140750

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_getAppInfo : public BMethodRequest {
	public: PIXServerEventsContext ec;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_getAppInfo();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_getAppInfo(const PIXServerEventsContext& ec);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_getUserNames
// typeId=1950460032

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_getUserNames : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PArrayString ids;
	public: PCheckoutUsersZ checkoutUsersZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_getUserNames();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_getUserNames(const PIXServerEventsContext& ec, const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_hasMethod
// typeId=110863678

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_hasMethod : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring methodName;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_hasMethod();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_hasMethod(const PIXServerEventsContext& ec, const ::std::wstring& methodName);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinActivity
// typeId=1027171864

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinActivity : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PActivity act;
	public: bool isNew;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinActivity();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinDocEnd
// typeId=1920958924

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinDocEnd : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSord sordDB;
	public: PSord parentSord;
	public: PDocument doc;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinDocEnd();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinMap
// typeId=1002917709

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinMap : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: int32_t objId;
	public: PArrayKeyValue data;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinNotes
// typeId=1729896360

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinNotes : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PArrayNote notes;
	public: PArraySord sords;
	public: int64_t noteC;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinReminder
// typeId=2130431109

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinReminder : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PArrayReminder remiArray;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinReminder();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinReminder(const PIXServerEventsContext& ec, const PArrayReminder& remiArray, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinSord
// typeId=1025485545

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSord sordDB;
	public: PSord parentSord;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterCheckinUsers
// typeId=1723326561

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterCheckinUsers : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PArrayUserInfo userInfos;
	public: PCheckinUsersZ checkinUsersZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterCheckinUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterDeleteMap
// typeId=40991853

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterDeleteMap : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: PArrayString keyNames;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterDeleteMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterDeleteSord
// typeId=1270939805

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterDeleteSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord parentSord;
	public: PSord sord;
	public: PLockZ unlockZ;
	public: PDeleteOptions delOpts;
	public: bool ret;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterDeleteSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, bool ret);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterEndEditWorkFlowNode
// typeId=812031586

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterEndEditWorkFlowNode : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PWFDiagram workflow;
	public: int32_t nodeId;
	public: PSord sord;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterEndEditWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterEndEditWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, int32_t nodeId, const PSord& sord, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterLogin
// typeId=1693784539

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterLogin : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring userName;
	public: PLoginScriptOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterLogin();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterRefSord
// typeId=807852157

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterRefSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord parentSordOld;
	public: PSord parentSordNew;
	public: PSord sord;
	public: int32_t manSortIndex;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterRefSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onAfterStartWorkFlow
// typeId=527527197

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onAfterStartWorkFlow : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PWFDiagram workflow;
	public: PSord sord;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onAfterStartWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onAfterStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeCheckinActivity
// typeId=1917517477

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeCheckinActivity : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PActivity act;
	public: bool isNew;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeCheckinActivity();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeCheckinDocEnd
// typeId=129508967

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeCheckinDocEnd : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSord sordDB;
	public: PSord parentSord;
	public: PDocument doc;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeCheckinDocEnd();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeCheckinMap
// typeId=1578945530

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeCheckinMap : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: int32_t objId;
	public: PArrayKeyValue data;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeCheckinMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeCheckinNotes
// typeId=1241851157

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeCheckinNotes : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PArrayNote notes;
	public: PArraySord sords;
	public: int64_t noteC;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeCheckinNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeCheckinSord
// typeId=1702478812

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeCheckinSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSord sordDB;
	public: PSord parentSord;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeCheckinSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeCheckinUsers
// typeId=1235281358

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeCheckinUsers : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PArrayUserInfo userInfos;
	public: PCheckinUsersZ checkinUsersZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeCheckinUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeDeleteMap
// typeId=393231686

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeDeleteMap : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: PArrayString keyNames;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeDeleteMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeDeleteSord
// typeId=694911984

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeDeleteSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord parentSord;
	public: PSord sord;
	public: PLockZ unlockZ;
	public: PDeleteOptions delOpts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeDeleteSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeFindSords
// typeId=384369013

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeFindSords : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PFindInfo findInfo;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeFindSords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeFindSords(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeFindSordsInternalSQL
// typeId=894418660

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeFindSordsInternalSQL : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PFindInfo findInfo;
	public: PSordZ sordZ;
	public: PFindInfoAsInternalSQL findSql;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeFindSordsInternalSQL();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeFindSordsInternalSQL(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindInfoAsInternalSQL& findSql);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeLogin
// typeId=2101716238

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeLogin : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring userName;
	public: PLoginScriptOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeLogin();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeRefSord
// typeId=372486646

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeRefSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord parentSordOld;
	public: PSord parentSordNew;
	public: PSord sord;
	public: int32_t manSortIndex;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeRefSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeStartWorkFlow
// typeId=1522940694

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeStartWorkFlow : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PWFDiagram workflow;
	public: PSord sord;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeStartWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onBeforeTakeWorkFlowNode
// typeId=727945599

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onBeforeTakeWorkFlowNode : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PWFDiagram workflow;
	public: PWFNode node;
	public: PUserInfo user;
	public: int32_t flags;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onBeforeTakeWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onBeforeTakeWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PWFNode& node, const PUserInfo& user, int32_t flags, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onCheckSordAccess
// typeId=1507824766

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onCheckSordAccess : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSordZ sordZ;
	public: int32_t lur;
	public: PCheckAccessOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onCheckSordAccess();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onCheckSordAccess(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, int32_t lur, const PCheckAccessOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onCreateDoc
// typeId=1029500828

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onCreateDoc : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring parentId;
	public: ::std::wstring maskId;
	public: ::std::wstring docTemplate;
	public: PEditInfoZ editInfoZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onCreateDoc();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onCreateDoc(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onCreateSord
// typeId=1849307166

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onCreateSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: ::std::wstring parentId;
	public: ::std::wstring maskId;
	public: PEditInfoZ editZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onCreateSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onCreateSord(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onFileUploadBuildResponse
// typeId=2105244922

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onFileUploadBuildResponse : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PDocVersion dv;
	public: ::std::wstring fileName;
	public: PHttpRequestInfo requestInfo;
	public: PHttpResponseInfo responseInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onFileUploadBuildResponse();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onFileUploadBuildResponse(const PIXServerEventsContext& ec, const PDocVersion& dv, const ::std::wstring& fileName, const PHttpRequestInfo& requestInfo, const PHttpResponseInfo& responseInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onFindClose
// typeId=1223837305

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onFindClose : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSerializable findInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onFindClose();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onFindClose(const PIXServerEventsContext& ec, const PSerializable& findInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onFindSordsResult
// typeId=127227249

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onFindSordsResult : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PFindInfo findInfo;
	public: PSordZ sordZ;
	public: PFindResult findResult;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onFindSordsResult();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onFindSordsResult(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindResult& findResult);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onInheritKeywording
// typeId=53854844

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onInheritKeywording : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSord parentSord;
	public: PArrayString okeyNames;
	public: PSerializable reserved;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onInheritKeywording();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onInheritKeywording(const PIXServerEventsContext& ec, const PSord& sord, const PSord& parentSord, const PArrayString& okeyNames, const PSerializable& reserved);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServerEvents_onReadSord
// typeId=227337860

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServerEvents_onReadSord : public BMethodRequest {
	public: PIXServerEventsContext ec;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PDocument doc;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServerEvents_onReadSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServerEvents_onReadSord(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, const PDocument& doc, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_addUrlParams
// typeId=177992598

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_addUrlParams : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring url;
	public: PUrlParams params;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_addUrlParams();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_addUrlParams(const ::std::wstring& url, const PUrlParams& params);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_adminMode
// typeId=1311037156

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_adminMode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t mode;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_adminMode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_adminMode(int32_t mode);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_alive
// typeId=1536711337

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_alive : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_alive();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_applyForNotifications
// typeId=1849289399

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_applyForNotifications : public BMethodRequest {
	public: PClientInfo ci;
	public: PApplyForNotificationsInfo info;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_applyForNotifications();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_applyForNotifications(const PApplyForNotificationsInfo& info);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_beginEditWorkFlowNode
// typeId=626823938

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_beginEditWorkFlowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t nFlowId;
	public: int32_t nNodeId;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_beginEditWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_beginEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_beginForwardWorkflowNode
// typeId=48774765

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_beginForwardWorkflowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t flowId;
	public: int32_t nodeId;
	public: PBeginForwardWorkflowNodeInfo fwdInfo;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_beginForwardWorkflowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_beginForwardWorkflowNode(int32_t flowId, int32_t nodeId, const PBeginForwardWorkflowNodeInfo& fwdInfo, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_changeSordMask
// typeId=1393938400

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_changeSordMask : public BMethodRequest {
	public: PClientInfo ci;
	public: PSord sord;
	public: ::std::wstring maskId;
	public: PEditInfoZ editInfoZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_changeSordMask();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_changeSordMask(const PSord& sord, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkLicense
// typeId=523346511

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkLicense : public BMethodRequest {
	public: PClientInfo ci;
	public: PLicenseInfo licenseInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkLicense();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkLicense(const PLicenseInfo& licenseInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinActivity
// typeId=1990464102

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinActivity : public BMethodRequest {
	public: PClientInfo ci;
	public: PActivity act;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinActivity();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinActivity(const PActivity& act, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinActivityProject
// typeId=310669779

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinActivityProject : public BMethodRequest {
	public: PClientInfo ci;
	public: PActivityProject actProj;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinActivityProject();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinActivityProject(const PActivityProject& actProj, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinColors
// typeId=1576322695

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinColors : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayColorData colors;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinColors();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinColors(const PArrayColorData& colors, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinConfigFiles
// typeId=1785918050

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinConfigFiles : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayConfigFile configFiles;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinConfigFiles();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinConfigFiles(const PArrayConfigFile& configFiles, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinConfigFilesBegin
// typeId=453135787

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinConfigFilesBegin : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString names;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinConfigFilesBegin();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinConfigFilesBegin(const PArrayString& names);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinConfigFilesEnd
// typeId=1770305117

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinConfigFilesEnd : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayConfigFile configFiles;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinConfigFilesEnd();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinConfigFilesEnd(const PArrayConfigFile& configFiles, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinCounters
// typeId=1020556978

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinCounters : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayCounterInfo counterInfos;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinCounters();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinCounters(const PArrayCounterInfo& counterInfos, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinCryptInfos
// typeId=1795186254

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinCryptInfos : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayCryptInfo cryptInfos;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinCryptInfos();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinCryptInfos(const PArrayCryptInfo& cryptInfos, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocBegin
// typeId=165848488

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocBegin : public BMethodRequest {
	public: PClientInfo ci;
	public: PDocument document;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocBegin();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocBegin(const PDocument& document);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocBegin2
// typeId=846335882

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocBegin2 : public BMethodRequest {
	public: PClientInfo ci;
	public: PSord sord;
	public: PDocument document;
	public: PCheckinDocOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocBegin2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocBegin2(const PSord& sord, const PDocument& document, const PCheckinDocOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocDupl
// typeId=1795690130

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocDupl : public BMethodRequest {
	public: PClientInfo ci;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PDocument document;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocDupl();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocDupl(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocEnd
// typeId=1604643226

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocEnd : public BMethodRequest {
	public: PClientInfo ci;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PDocument document;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocEnd();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocEnd(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocMask
// typeId=1795441139

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocMask : public BMethodRequest {
	public: PClientInfo ci;
	public: PDocMask docMask;
	public: PDocMaskZ docMaskZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocMask();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocMask(const PDocMask& docMask, const PDocMaskZ& docMaskZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocMaskLineTemplate
// typeId=702278853

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocMaskLineTemplate : public BMethodRequest {
	public: PClientInfo ci;
	public: PDocMaskLineTemplate dmlt;
	public: PDocMaskLineTemplateZ dmltZ;
	public: PCheckInDocMaskLineTemplateOptions options;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocMaskLineTemplate();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocMaskLineTemplate(const PDocMaskLineTemplate& dmlt, const PDocMaskLineTemplateZ& dmltZ, const PCheckInDocMaskLineTemplateOptions& options, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocsBegin
// typeId=2078187849

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocsBegin : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayDocument documents;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocsBegin();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocsBegin(const PArrayDocument& documents);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinDocsEnd
// typeId=1794336151

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinDocsEnd : public BMethodRequest {
	public: PClientInfo ci;
	public: PArraySord sords;
	public: PArraySordZ sordZs;
	public: PArrayDocument documents;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinDocsEnd();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinDocsEnd(const PArraySord& sords, const PArraySordZ& sordZs, const PArrayDocument& documents, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinKeys
// typeId=573935819

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinKeys : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayKeyInfo keyInfos;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinKeys();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinKeys(const PArrayKeyInfo& keyInfos, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinKeywordList
// typeId=1216164720

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinKeywordList : public BMethodRequest {
	public: PClientInfo ci;
	public: PKeywordList kwList;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinKeywordList();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinKeywordList(const PKeywordList& kwList, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinKeywords
// typeId=125387007

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinKeywords : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayKeyword kws;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinKeywords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinKeywords(const PArrayKeyword& kws, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinMap
// typeId=1126894501

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinMap : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: int32_t objId;
	public: PArrayKeyValue data;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinMap(const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinMapDomain
// typeId=1848884425

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinMapDomain : public BMethodRequest {
	public: PClientInfo ci;
	public: PMapDomain mapDomain;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinMapDomain();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinMapDomain(const PMapDomain& mapDomain, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinNoteTemplates
// typeId=1356325488

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinNoteTemplates : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayNoteTemplate noteTemplates;
	public: PNoteTemplateZ ntemplZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinNoteTemplates();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinNoteTemplates(const PArrayNoteTemplate& noteTemplates, const PNoteTemplateZ& ntemplZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinNotes
// typeId=615204554

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinNotes : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: PArrayNote notes;
	public: PNoteZ noteZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinNotes(const ::std::wstring& objId, const PArrayNote& notes, const PNoteZ& noteZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinNotification
// typeId=1249191106

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinNotification : public BMethodRequest {
	public: PClientInfo ci;
	public: PNotification notif;
	public: PNotificationZ notiZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinNotification();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinNotification(const PNotification& notif, const PNotificationZ& notiZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinOrgUnits
// typeId=656770626

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinOrgUnits : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayOrgUnitInfo orgUnitInfos;
	public: PCheckinOrgUnitInfo reserved;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinOrgUnits();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinOrgUnits(const PArrayOrgUnitInfo& orgUnitInfos, const PCheckinOrgUnitInfo& reserved, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinReminder
// typeId=1167138871

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinReminder : public BMethodRequest {
	public: PClientInfo ci;
	public: PReminder remi;
	public: PArrayString receiverIds;
	public: bool expandGroups;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinReminder();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinReminder(const PReminder& remi, const PArrayString& receiverIds, bool expandGroups, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinReplNames
// typeId=897197218

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinReplNames : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayReplSetName replNames;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinReplNames();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinReplNames(const PArrayReplSetName& replNames, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinReport
// typeId=1996643915

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinReport : public BMethodRequest {
	public: PClientInfo ci;
	public: PReportInfo report;
	public: PCheckinReportInfo reserved;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinReport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinReport(const PReportInfo& report, const PCheckinReportInfo& reserved, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinReportOptions
// typeId=955196883

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinReportOptions : public BMethodRequest {
	public: PClientInfo ci;
	public: PReportOptions options;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinReportOptions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinReportOptions(const PReportOptions& options, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinSord
// typeId=574183525

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinSord : public BMethodRequest {
	public: PClientInfo ci;
	public: PSord sord;
	public: PSordZ sordZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinSord(const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinSordPath
// typeId=998405674

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinSordPath : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring parentId;
	public: PArraySord sords;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinSordPath();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinSordPath(const ::std::wstring& parentId, const PArraySord& sords, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinSordTypes
// typeId=890210068

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinSordTypes : public BMethodRequest {
	public: PClientInfo ci;
	public: PArraySordType sordTypes;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinSordTypes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinSordTypes(const PArraySordType& sordTypes, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinStorage
// typeId=1212457916

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinStorage : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayStoreInfo storeInfos;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinStorage();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinStorage(const PArrayStoreInfo& storeInfos, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinSubs
// typeId=574188810

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinSubs : public BMethodRequest {
	public: PClientInfo ci;
	public: PArraySubsInfo deps;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinSubs();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinSubscription
// typeId=995161332

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinSubscription : public BMethodRequest {
	public: PClientInfo ci;
	public: PSubscription subs;
	public: PSubscriptionZ subsZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinSubscription();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinSubscription(const PSubscription& subs, const PSubscriptionZ& subsZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinTranslateTerms
// typeId=366611184

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinTranslateTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayTranslateTerm tterms;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinTranslateTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinTranslateTerms(const PArrayTranslateTerm& tterms, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinUserProfile
// typeId=1903655079

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinUserProfile : public BMethodRequest {
	public: PClientInfo ci;
	public: PUserProfile userProfile;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinUserProfile();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinUsers
// typeId=621774353

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinUsers : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayUserInfo userInfos;
	public: PCheckinUsersZ checkinUsersZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinUsers(const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinWorkFlow
// typeId=614110410

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: PWFDiagram wf;
	public: PWFDiagramZ workFlowDiagramZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinWorkFlow(const PWFDiagram& wf, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkinWorkflowTemplate
// typeId=847491504

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkinWorkflowTemplate : public BMethodRequest {
	public: PClientInfo ci;
	public: PWFDiagram wf;
	public: PWFDiagramZ wfZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkinWorkflowTemplate();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkinWorkflowTemplate(const PWFDiagram& wf, const PWFDiagramZ& wfZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutActivity
// typeId=708798549

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutActivity : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring actGuid;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutActivity();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutActivity(const ::std::wstring& actGuid, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutActivityProject
// typeId=1209441042

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutActivityProject : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring projectName;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutActivityProject();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutActivityProject(const ::std::wstring& projectName, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutColors
// typeId=2037655284

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutColors : public BMethodRequest {
	public: PClientInfo ci;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutColors();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutColors(const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutConfigFiles
// typeId=846870983

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutConfigFiles : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString names;
	public: PConfigFileZ configFileZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutConfigFiles();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutConfigFiles(const PArrayString& names, const PConfigFileZ& configFileZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutCounters
// typeId=575147667

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutCounters : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString counterNames;
	public: bool incrementCounters;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutCounters();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutCounters(const PArrayString& counterNames, bool incrementCounters, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutCryptInfos
// typeId=1964025427

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutCryptInfos : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutCryptInfos();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutCryptInfos(const PArrayString& ids, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutDoc
// typeId=753364764

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutDoc : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: ::std::wstring docId;
	public: PEditInfoZ editInfoZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutDoc();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutDoc(const ::std::wstring& objId, const ::std::wstring& docId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutDocMask
// typeId=2135358504

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutDocMask : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring maskId;
	public: PDocMaskZ docMaskZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutDocMask();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutDocMask(const ::std::wstring& maskId, const PDocMaskZ& docMaskZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutDocMaskLineTemplates
// typeId=550757795

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutDocMaskLineTemplates : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString groups;
	public: PDocMaskLineTemplateZ dmltZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutDocMaskLineTemplates();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutDocMaskLineTemplates(const PArrayString& groups, const PDocMaskLineTemplateZ& dmltZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutKeys
// typeId=1879670928

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutKeys : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutKeys();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutKeys(const PArrayString& ids, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutKeywordList
// typeId=2139755509

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutKeywordList : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring kwid;
	public: PKeywordZ keywordZ;
	public: int32_t max;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutKeywordList();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutKeywordList(const ::std::wstring& kwid, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutKeywords
// typeId=1470317638

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutKeywords : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString kwids;
	public: PKeywordZ keywordZ;
	public: int32_t max;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutKeywords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutKeywords(const PArrayString& kwids, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutKeywordsDynamic
// typeId=1951955225

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutKeywordsDynamic : public BMethodRequest {
	public: PClientInfo ci;
	public: PKeywordsDynamicInfo keywordsDynamicInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutKeywordsDynamic();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutKeywordsDynamic(const PKeywordsDynamicInfo& keywordsDynamicInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutMap
// typeId=753372992

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutMap : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: PArrayString keyNames;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutMapDomain
// typeId=223879132

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutMapDomain : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring domainName;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutMapDomain();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutMapDomain(const ::std::wstring& domainName, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutMapHistory
// typeId=739067188

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutMapHistory : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring domainName;
	public: ::std::wstring mapId;
	public: PMapHistZ membersZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutMapHistory();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutMapHistory(const ::std::wstring& domainName, const ::std::wstring& mapId, const PMapHistZ& membersZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutNoteTemplates
// typeId=1837424715

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutNoteTemplates : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userId;
	public: PArrayString ids;
	public: PNoteTemplateZ ntemplZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutNoteTemplates();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PNoteTemplateZ& ntemplZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutNotes
// typeId=1856680027

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutNotes : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: PArrayString noteIds;
	public: PNoteZ noteZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutNotes(const ::std::wstring& objId, const PArrayString& noteIds, const PNoteZ& noteZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutNotification
// typeId=294879111

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutNotification : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring watchGuid;
	public: ::std::wstring userGuid;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutNotification();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutNotification(const ::std::wstring& watchGuid, const ::std::wstring& userGuid);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutOrgUnits
// typeId=2042492025

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutOrgUnits : public BMethodRequest {
	public: PClientInfo ci;
	public: PCheckoutOrgUnitInfo reserved;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutOrgUnits();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutOrgUnits(const PCheckoutOrgUnitInfo& reserved, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutPreviewImageURLs
// typeId=755346067

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutPreviewImageURLs : public BMethodRequest {
	public: PClientInfo ci;
	public: PPreviewImageInfo previewImageInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutPreviewImageURLs();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutPreviewImageURLs(const PPreviewImageInfo& previewImageInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutReminders
// typeId=400637221

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutReminders : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayInt reminderIds;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutReminders();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutReminders(const PArrayInt& reminderIds, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutReplNames
// typeId=1175566339

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutReplNames : public BMethodRequest {
	public: PClientInfo ci;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutReplNames();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutReplNames(const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutReportOptions
// typeId=1436296110

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutReportOptions : public BMethodRequest {
	public: PClientInfo ci;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutReportOptions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutReportOptions(const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutSord
// typeId=1879918634

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutSord : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: PEditInfoZ editInfoZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutSord(const ::std::wstring& objId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutSordHistory
// typeId=782528246

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutSordHistory : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutSordHistory();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutSordHistory(const ::std::wstring& objId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutSordPath
// typeId=1700856977

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutSordPath : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: PSordZ sordZ;
	public: PCheckoutSordPathInfo csi;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutSordPath();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutSordPath(const ::std::wstring& objId, const PSordZ& sordZ, const PCheckoutSordPathInfo& csi);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutSordTypes
// typeId=1182553489

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutSordTypes : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayInt sordTypeIds;
	public: PSordTypeZ sordTypeZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutSordTypes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutSordTypes(const PArrayInt& sordTypeIds, const PSordTypeZ& sordTypeZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutStorage
// typeId=1576625569

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutStorage : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutStorage();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutStorage(const PArrayString& ids, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutSubs
// typeId=1879923919

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutSubs : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userId;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutSubs();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutSubs(const ::std::wstring& userId, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutTranslateTerms
// typeId=1899181963

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutTranslateTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString termIds;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutTranslateTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutTranslateTerms(const PArrayString& termIds, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutUserProfile
// typeId=1452265150

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutUserProfile : public BMethodRequest {
	public: PClientInfo ci;
	public: PUserProfile userProfile;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutUserProfile();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutUserProfile(const PUserProfile& userProfile, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutUsers
// typeId=1850110228

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutUsers : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PCheckoutUsersZ checkoutUsersZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutUsers(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutWorkFlow
// typeId=981594235

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: PWFTypeZ typeZ;
	public: PWFDiagramZ workFlowDiagramZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutWorkflowHistory
// typeId=1555002297

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutWorkflowHistory : public BMethodRequest {
	public: PClientInfo ci;
	public: PCheckoutWorkflowHistoryParams checkoutWorkflowHistoryParams;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutWorkflowHistory();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutWorkflowHistory(const PCheckoutWorkflowHistoryParams& checkoutWorkflowHistoryParams);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_checkoutWorkflowTemplate
// typeId=968696309

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_checkoutWorkflowTemplate : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: ::std::wstring versionId;
	public: PWFDiagramZ wfZ;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_checkoutWorkflowTemplate();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_checkoutWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PWFDiagramZ& wfZ, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_cleanupStart
// typeId=97888340

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_cleanupStart : public BMethodRequest {
	public: PClientInfo ci;
	public: PDeleteOptions deleteOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_cleanupStart();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_cleanupStart(const PDeleteOptions& deleteOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_cleanupState
// typeId=97888387

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_cleanupState : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_cleanupState();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_cleanupStop
// typeId=689578544

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_cleanupStop : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_cleanupStop();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_closeEventBus
// typeId=1579680296

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_closeEventBus : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t busId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_closeEventBus();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_closeEventBus(int64_t busId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_collectJobStates
// typeId=1479025845

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_collectJobStates : public BMethodRequest {
	public: PClientInfo ci;
	public: bool activeJobs;
	public: bool finishedJobs;
	public: bool fullInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_collectJobStates();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_collectMapDomains
// typeId=1590880889

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_collectMapDomains : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_collectMapDomains();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_collectWorkFlowNodes
// typeId=791411518

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_collectWorkFlowNodes : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowName;
	public: PWFTypeZ wfTypeZ;
	public: ::std::wstring nodeName;
	public: int32_t nodeType;
	public: ::std::wstring objId;
	public: ::std::wstring enterDateIso;
	public: ::std::wstring exitDateIso;
	public: PArrayString userIds;
	public: bool onlyActive;
	public: bool onlyStartNodes;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_collectWorkFlowNodes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_collectWorkFlowNodes(const ::std::wstring& flowName, const PWFTypeZ& wfTypeZ, const ::std::wstring& nodeName, int32_t nodeType, const ::std::wstring& objId, const ::std::wstring& enterDateIso, const ::std::wstring& exitDateIso, const PArrayString& userIds, bool onlyActive, bool onlyStartNodes);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_collectWorkFlows
// typeId=1540999264

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_collectWorkFlows : public BMethodRequest {
	public: PClientInfo ci;
	public: PWFTypeZ typeZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_collectWorkFlows();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_collectWorkFlows(const PWFTypeZ& typeZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_combineAcl
// typeId=1476771969

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_combineAcl : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayAclItem lhs;
	public: PArrayAclItem rhs;
	public: PCombineAclOptions options;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_combineAcl();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_combineAcl(const PArrayAclItem& lhs, const PArrayAclItem& rhs, const PCombineAclOptions& options);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_configureBackup
// typeId=251783250

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_configureBackup : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayBackupProfile backupProfiles;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_configureBackup();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_configureBackup(const PArrayBackupProfile& backupProfiles);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_configureFulltext
// typeId=655595212

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_configureFulltext : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userId;
	public: PFulltextConfig opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_configureFulltext();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_configureFulltext(const ::std::wstring& userId, const PFulltextConfig& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_configurePurge
// typeId=1407134747

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_configurePurge : public BMethodRequest {
	public: PClientInfo ci;
	public: PPurgeSettings purgeSettings;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_configurePurge();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_configurePurge(const PPurgeSettings& purgeSettings);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_controlBackgroundThread
// typeId=796672607

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_controlBackgroundThread : public BMethodRequest {
	public: PClientInfo ci;
	public: PJobState jobState;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_controlBackgroundThread();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_controlBackgroundThread(const PJobState& jobState);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_controlBackup
// typeId=429289481

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_controlBackup : public BMethodRequest {
	public: PClientInfo ci;
	public: PControlBackupInfo controlBackupInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_controlBackup();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_controlBackup(const PControlBackupInfo& controlBackupInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_cookKeyword
// typeId=922862219

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_cookKeyword : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring kwid;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_cookKeyword();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_cookKeyword(const ::std::wstring& kwid);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_copySord
// typeId=1944880601

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_copySord : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring newParentId;
	public: ::std::wstring objId;
	public: PCopyInfo copyInfo;
	public: PCopySordZ copySordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_copySord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_copySord(const ::std::wstring& newParentId, const ::std::wstring& objId, const PCopyInfo& copyInfo, const PCopySordZ& copySordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createActivity
// typeId=806333153

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createActivity : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring projectName;
	public: ::std::wstring objId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createActivity();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createActivity(const ::std::wstring& projectName, const ::std::wstring& objId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createActivityProject
// typeId=1769051912

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createActivityProject : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring projectName;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createActivityProject();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createActivityProject(const ::std::wstring& projectName);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createDoc
// typeId=734350810

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createDoc : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring parentId;
	public: ::std::wstring maskId;
	public: ::std::wstring docTemplate;
	public: PEditInfoZ editInfoZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createDoc();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createDoc(const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createDocMask
// typeId=171070926

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createDocMask : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring maskId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createDocMask();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createDocMask(const ::std::wstring& maskId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createEventBusListener
// typeId=563568172

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createEventBusListener : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t subsId;
	public: PEventListener eventListener;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createEventBusListener();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createEventBusListener(int64_t subsId, const PEventListener& eventListener);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createEventBusSubscriber
// typeId=1671043104

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createEventBusSubscriber : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createEventBusSubscriber();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createKey
// typeId=734344371

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createKey : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createKey();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createNote
// typeId=1289740092

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createNote : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createNote();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createNote(const ::std::wstring& objId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createNote2
// typeId=1327237138

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createNote2 : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: int32_t noteType;
	public: ::std::wstring templId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createNote2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createNote2(const ::std::wstring& objId, int32_t noteType, const ::std::wstring& templId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createNoteTemplate
// typeId=1517964638

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createNoteTemplate : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createNoteTemplate();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createNoteTemplate(const ::std::wstring& userId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createReminder
// typeId=1943697476

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createReminder : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createReminder();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createReminder(const ::std::wstring& objId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createRsaKeys
// typeId=518307262

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createRsaKeys : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createRsaKeys();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createSord
// typeId=1289591200

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createSord : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring parentId;
	public: ::std::wstring maskId;
	public: PEditInfoZ editInfoZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createSord(const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createSubscription
// typeId=1409951761

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createSubscription : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring watchGuid;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createSubscription();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createSubscription(const ::std::wstring& watchGuid);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createUser
// typeId=1289528163

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createUser : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring rightsAsUserId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createUser();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createUser(const ::std::wstring& rightsAsUserId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createWFNode
// typeId=2023998883

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createWFNode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t nodeId;
	public: int32_t nodeTypeC;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createWFNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createWFNode(int32_t nodeId, int32_t nodeTypeC);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_createWorkFlow
// typeId=1798241359

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_createWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring wfName;
	public: PWFTypeZ typeZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_createWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_createWorkFlow(const ::std::wstring& wfName, const PWFTypeZ& typeZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deferWorkFlowNode
// typeId=77680797

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deferWorkFlowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: int32_t nodeId;
	public: ::std::wstring userDelayDateIso;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deferWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deferWorkFlowNode(const ::std::wstring& flowId, int32_t nodeId, const ::std::wstring& userDelayDateIso, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_delegateWorkFlowNode
// typeId=2095741220

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_delegateWorkFlowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: PWFDelegateNodeInfo delegateNodeInfo;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_delegateWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_delegateWorkFlowNode(const PWFDelegateNodeInfo& delegateNodeInfo, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteActivity
// typeId=2125754512

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteActivity : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring actGuid;
	public: PDeleteActivityOptions deleteOptions;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteActivity();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteActivity(const ::std::wstring& actGuid, const PDeleteActivityOptions& deleteOptions, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteActivityProject
// typeId=1847611287

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteActivityProject : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring projectName;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteActivityProject();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteActivityProject(const ::std::wstring& projectName, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteConfigFiles
// typeId=28637388

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteConfigFiles : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString names;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteConfigFiles();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteConfigFiles(const PArrayString& names, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteCounters
// typeId=885266568

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteCounters : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString counterNames;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteCounters();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteCounters(const PArrayString& counterNames, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteDocMask
// typeId=1672606371

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteDocMask : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring maskId;
	public: ::std::wstring assignMaskId;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteDocMask();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteDocMask(const ::std::wstring& maskId, const ::std::wstring& assignMaskId, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteDocMaskLineTemplates
// typeId=1672428606

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteDocMaskLineTemplates : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString groups;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteDocMaskLineTemplates();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteDocMaskLineTemplates(const PArrayString& groups, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteEventBusListener
// typeId=1871772453

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteEventBusListener : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t lsnId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteEventBusListener();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteEventBusListener(int64_t lsnId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteEventBusSubscriber
// typeId=1276207409

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteEventBusSubscriber : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t subsId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteEventBusSubscriber();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteEventBusSubscriber(int64_t subsId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteKeys
// typeId=894462987

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteKeys : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteKeys();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteKeys(const PArrayString& ids, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteKeywordList
// typeId=1321521914

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteKeywordList : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring kwid;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteKeywordList();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteKeywordList(const ::std::wstring& kwid, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteKeywords
// typeId=9903403

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteKeywords : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString kwids;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteKeywords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteKeywords(const PArrayString& kwids, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteMap
// typeId=1691419845

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteMap : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring domainName;
	public: ::std::wstring id;
	public: PArrayString keyNames;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteMap();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteMapDomain
// typeId=1747919839

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteMapDomain : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring domainName;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteMapDomain();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteMapDomain(const ::std::wstring& domainName, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteNoteTemplates
// typeId=2114072954

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteNoteTemplates : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userId;
	public: PArrayString ids;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteNoteTemplates();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteNotes
// typeId=1955485472

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteNotes : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString noteIds;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteNotes(const PArrayString& noteIds, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteNotification
// typeId=109683220

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteNotification : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objGuid;
	public: ::std::wstring userGuid;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteNotification();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteNotification(const ::std::wstring& objGuid, const ::std::wstring& userGuid);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteOrgUnits
// typeId=792061036

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteOrgUnits : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteOrgUnits();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteOrgUnits(const PArrayString& ids, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteReminders
// typeId=1922531104

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteReminders : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayInt reminderIds;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteReminders();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteReminders(const PArrayInt& reminderIds, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteReport
// typeId=385335563

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteReport : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring endDateISO;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteReport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteReport(const ::std::wstring& endDateISO);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteSord
// typeId=894215281

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteSord : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring parentId;
	public: ::std::wstring objId;
	public: PLockZ unlockZ;
	public: PDeleteOptions deleteOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteSord(const ::std::wstring& parentId, const ::std::wstring& objId, const PLockZ& unlockZ, const PDeleteOptions& deleteOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteSordTypes
// typeId=789245482

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteSordTypes : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayInt sordTypeIds;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteSordTypes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteSordTypes(const PArrayInt& sordTypeIds, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteSubs
// typeId=894209996

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteSubs : public BMethodRequest {
	public: PClientInfo ci;
	public: PArraySubsInfo deps;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteSubs();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteSubscription
// typeId=363712994

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteSubscription : public BMethodRequest {
	public: PClientInfo ci;
	public: PSubscription subs;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteSubscription();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteSubscription(const PSubscription& subs);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteTranslateTerms
// typeId=158441882

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteTranslateTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString termIds;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteTranslateTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteTranslateTerms(const PArrayString& termIds, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteUserProfile
// typeId=634031555

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteUserProfile : public BMethodRequest {
	public: PClientInfo ci;
	public: PUserProfile userProfile;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteUserProfile();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteUsers
// typeId=1948915673

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteUsers : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteUsers(const PArrayString& ids, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteWorkFlow
// typeId=478820000

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: PWFTypeZ typeZ;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_deleteWorkflowTemplate
// typeId=1634712102

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_deleteWorkflowTemplate : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: ::std::wstring versionId;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_deleteWorkflowTemplate();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_deleteWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_editPublicDownloadUrls
// typeId=245225739

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_editPublicDownloadUrls : public BMethodRequest {
	public: PClientInfo ci;
	public: PPublicDownloadOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_editPublicDownloadUrls();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_editPublicDownloadUrls(const PPublicDownloadOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_encryptStringRsa
// typeId=1840380736

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_encryptStringRsa : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring key;
	public: ::std::wstring data;
	public: bool encryptNotDecrypt;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_encryptStringRsa();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_encryptStringRsa(const ::std::wstring& key, const ::std::wstring& data, bool encryptNotDecrypt);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_endEditWorkFlowNode
// typeId=551973808

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_endEditWorkFlowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t nFlowId;
	public: int32_t nNodeId;
	public: bool bTerminate;
	public: bool bCancel;
	public: ::std::wstring sName;
	public: ::std::wstring sComment;
	public: PArrayInt arrEnterNodesIds;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_endEditWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_endEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, bool bTerminate, bool bCancel, const ::std::wstring& sName, const ::std::wstring& sComment, const PArrayInt& arrEnterNodesIds);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_evalAutoFiling
// typeId=1823282746

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_evalAutoFiling : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring maskId;
	public: PSord sord;
	public: PAutoFilingOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_evalAutoFiling();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_evalAutoFiling(const ::std::wstring& maskId, const PSord& sord, const PAutoFilingOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_executeRegisteredFunction
// typeId=778610599

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_executeRegisteredFunction : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring functionName;
	public: PAny param;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_executeRegisteredFunction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_executeRegisteredFunction(const ::std::wstring& functionName, const PAny& param);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_executeRegisteredFunctionString
// typeId=553270730

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_executeRegisteredFunctionString : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring functionName;
	public: ::std::wstring param;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_executeRegisteredFunctionString();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_executeRegisteredFunctionString(const ::std::wstring& functionName, const ::std::wstring& param);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_executeScript
// typeId=905800490

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_executeScript : public BMethodRequest {
	public: PClientInfo ci;
	public: PExecuteScriptParams params;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_executeScript();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_executeScript(const PExecuteScriptParams& params);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_exportWorkflow
// typeId=809552457

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_exportWorkflow : public BMethodRequest {
	public: PClientInfo ci;
	public: PWorkflowExportOptions wfExportOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_exportWorkflow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_exportWorkflow(const PWorkflowExportOptions& wfExportOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findActivityProjects
// typeId=1955899064

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findActivityProjects : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindActivityProjectsInfo findInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findActivityProjects();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findActivityProjects(const PFindActivityProjectsInfo& findInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findBackgroundThreads
// typeId=610169452

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findBackgroundThreads : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindBackgroundThreadOptions findBackgroundThreadOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findBackgroundThreads();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findBackgroundThreads(const PFindBackgroundThreadOptions& findBackgroundThreadOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findClose
// typeId=928687287

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findClose : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findClose();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findClose(const ::std::wstring& searchId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstActivities
// typeId=1661199666

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstActivities : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindActivityInfo findInfo;
	public: int32_t max;
	public: PActivityZ activityZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstActivities();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstActivities(const PFindActivityInfo& findInfo, int32_t max, const PActivityZ& activityZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstConfigFiles
// typeId=954269076

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstConfigFiles : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindConfigFileInfo findInfo;
	public: int32_t max;
	public: PConfigFileZ configFileZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstConfigFiles();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstConfigFiles(const PFindConfigFileInfo& findInfo, int32_t max, const PConfigFileZ& configFileZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstNotes
// typeId=299362112

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstNotes : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindInfo findInfo;
	public: int32_t max;
	public: PNoteZ noteZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstNotes(const PFindInfo& findInfo, int32_t max, const PNoteZ& noteZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstReportInfos
// typeId=693111280

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstReportInfos : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindReportInfo opts;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstReportInfos();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstReportInfos(const PFindReportInfo& opts, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstSords
// typeId=303977764

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstSords : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindInfo findInfo;
	public: int32_t max;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstSords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstSords(const PFindInfo& findInfo, int32_t max, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstSubscriptions
// typeId=1290105973

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstSubscriptions : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindSubscriptionInfo findInfo;
	public: int32_t max;
	public: PSubscriptionZ subsZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstSubscriptions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstSubscriptions(const PFindSubscriptionInfo& findInfo, int32_t max, const PSubscriptionZ& subsZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstTasks
// typeId=304485389

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstTasks : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindTasksInfo findInfo;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstTasks();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstTasks(const PFindTasksInfo& findInfo, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstTranslateTerms
// typeId=1162113222

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstTranslateTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindTranslateTermInfo findInfo;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstTranslateTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstTranslateTerms(const PFindTranslateTermInfo& findInfo, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstUsers
// typeId=305931911

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstUsers : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindUserInfo findUserInfo;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstUsers(const PFindUserInfo& findUserInfo, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findFirstWorkflows
// typeId=546938477

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findFirstWorkflows : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindWorkflowInfo findInfo;
	public: int32_t max;
	public: PWFDiagramZ wfDiagramZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findFirstWorkflows();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findFirstWorkflows(const PFindWorkflowInfo& findInfo, int32_t max, const PWFDiagramZ& wfDiagramZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextActivities
// typeId=2116795663

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextActivities : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PActivityZ activityZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextActivities();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextActivities(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActivityZ& activityZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextConfigFiles
// typeId=2108007283

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextConfigFiles : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PConfigFileZ configFileZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextConfigFiles();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextConfigFiles(const ::std::wstring& searchId, int32_t idx, int32_t max, const PConfigFileZ& configFileZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextNotes
// typeId=1493835871

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextNotes : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PNoteZ noteZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextNotes();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextNotes(const ::std::wstring& searchId, int32_t idx, int32_t max, const PNoteZ& noteZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextReportInfos
// typeId=1846849487

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextReportInfos : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextReportInfos();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextReportInfos(const ::std::wstring& searchId, int32_t idx, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextSords
// typeId=1498451523

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextSords : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PSordZ sordZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextSords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextSords(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSordZ& sordZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextSubscriptions
// typeId=1930960532

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextSubscriptions : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PSubscriptionZ subsZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextSubscriptions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextSubscriptions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSubscriptionZ& subsZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextTasks
// typeId=1498959148

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextTasks : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextTasks();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextTasks(const ::std::wstring& searchId, int32_t idx, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextTranslateTerms
// typeId=1524508923

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextTranslateTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextTranslateTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextTranslateTerms(const ::std::wstring& searchId, int32_t idx, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextUsers
// typeId=1500405670

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextUsers : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextUsers();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextUsers(const ::std::wstring& searchId, int32_t idx, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_findNextWorkflows
// typeId=1653142322

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_findNextWorkflows : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t index;
	public: int32_t maxResults;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_findNextWorkflows();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_findNextWorkflows(const ::std::wstring& searchId, int32_t index, int32_t maxResults);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_finishExport
// typeId=1487849891

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_finishExport : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring exportId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_finishExport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_finishExport(const ::std::wstring& exportId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_forwardWorkflowNode
// typeId=572079312

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_forwardWorkflowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t flowId;
	public: int32_t nodeId;
	public: PForwardWorkflowNodeInfo fwdInfo;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_forwardWorkflowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_forwardWorkflowNode(int32_t flowId, int32_t nodeId, const PForwardWorkflowNodeInfo& fwdInfo, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getAclAccess
// typeId=939270158

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getAclAccess : public BMethodRequest {
	public: PClientInfo ci;
	public: PAclAccessInfo aai;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getAclAccess();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getAclAccess(const PAclAccessInfo& aai);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getArchiveStatistics
// typeId=538085115

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getArchiveStatistics : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getArchiveStatistics();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getArchiveStatistics(int64_t opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getCompiledScripts
// typeId=1449667401

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getCompiledScripts : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getCompiledScripts();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getConstants
// typeId=14637361

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getConstants : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getConstants();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getContextTerms
// typeId=1075096680

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getContextTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindInfo findInfo;
	public: ::std::wstring field;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getContextTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getContextTerms(const PFindInfo& findInfo, const ::std::wstring& field, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getDebuggerPort
// typeId=1274938050

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getDebuggerPort : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getDebuggerPort();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getDistinctValuesOfObjKey
// typeId=1260382845

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getDistinctValuesOfObjKey : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring okeyName;
	public: PValuesOfObjKeyOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getDistinctValuesOfObjKey();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getDistinctValuesOfObjKey(const ::std::wstring& okeyName, const PValuesOfObjKeyOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getESWFromEditInfo
// typeId=1694552757

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getESWFromEditInfo : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayEditInfo editInfos;
	public: PEditInfoEswOptions eswOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getESWFromEditInfo();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getESWFromEditInfo(const PArrayEditInfo& editInfos, const PEditInfoEswOptions& eswOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getEditInfoFromESW
// typeId=835848697

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getEditInfoFromESW : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayFileData fileDatas;
	public: PEditInfoEswOptions eswOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getEditInfoFromESW();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getEditInfoFromESW(const PArrayFileData& fileDatas, const PEditInfoEswOptions& eswOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getExportZipUrl
// typeId=1446672866

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getExportZipUrl : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring exportId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getExportZipUrl();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getExportZipUrl(const ::std::wstring& exportId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getImportZipUrl
// typeId=254632211

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getImportZipUrl : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring importId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getImportZipUrl();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getImportZipUrl(const ::std::wstring& importId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getPublicDownloads
// typeId=1822446082

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getPublicDownloads : public BMethodRequest {
	public: PClientInfo ci;
	public: PPublicDownloadOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getPublicDownloads();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getPublicDownloads(const PPublicDownloadOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getScriptsToDebug
// typeId=272016144

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getScriptsToDebug : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getScriptsToDebug();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getSearchTerms
// typeId=349631039

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getSearchTerms : public BMethodRequest {
	public: PClientInfo ci;
	public: PFindInfo findInfo;
	public: int32_t termType;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getSearchTerms();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getSearchTerms(const PFindInfo& findInfo, int32_t termType);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getServerInfo
// typeId=2074326767

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getServerInfo : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getServerInfo();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getServerInfoDM
// typeId=563195558

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getServerInfoDM : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getServerInfoDM();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getSessionFromTicket
// typeId=147146740

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getSessionFromTicket : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t options;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getSessionFromTicket();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getSessionFromTicket(int32_t options);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getSessionInfos
// typeId=1406789391

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getSessionInfos : public BMethodRequest {
	public: PClientInfo ci;
	public: PSessionInfoParams params;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getSessionInfos();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getSessionInfos(const PSessionInfoParams& params);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getSessionOptions
// typeId=109969832

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getSessionOptions : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getSessionOptions();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getUserNames
// typeId=730904509

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getUserNames : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString ids;
	public: PCheckoutUsersZ checkoutUsersZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getUserNames();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getUserNames(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getWebDAVPathFromObjID
// typeId=1491154434

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getWebDAVPathFromObjID : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getWebDAVPathFromObjID();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getWebDAVPathFromObjID(const ::std::wstring& objId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getWebDAVPathFromObjID2
// typeId=1018852852

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getWebDAVPathFromObjID2 : public BMethodRequest {
	public: PClientInfo ci;
	public: PGetWebDAVPathOptions options;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getWebDAVPathFromObjID2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getWebDAVPathFromObjID2(const PGetWebDAVPathOptions& options);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_getWorkflowTemplateVersions
// typeId=775523732

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_getWorkflowTemplateVersions : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: bool onlyDeleted;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_getWorkflowTemplateVersions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_getWorkflowTemplateVersions(const ::std::wstring& flowId, bool onlyDeleted);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_importWorkFlow
// typeId=2013797722

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_importWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowName;
	public: PBytes fileData;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_importWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_importWorkFlow(const ::std::wstring& flowName, const PBytes& fileData);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_importWorkFlow2
// typeId=1996780008

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_importWorkFlow2 : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowName;
	public: PBytes fileData;
	public: PWorkflowImportOptions importOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_importWorkFlow2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_importWorkFlow2(const ::std::wstring& flowName, const PBytes& fileData, const PWorkflowImportOptions& importOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_insertPublicDownload
// typeId=1596476256

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_insertPublicDownload : public BMethodRequest {
	public: PClientInfo ci;
	public: PPublicDownloadOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_insertPublicDownload();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_insertPublicDownload(const PPublicDownloadOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_internalReceiveEvents
// typeId=1518401879

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_internalReceiveEvents : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t subsId;
	public: int64_t timeoutMillis;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_internalReceiveEvents();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_internalReceiveEvents(int64_t subsId, int64_t timeoutMillis);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_invalidateCache
// typeId=767982831

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_invalidateCache : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t flags;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_invalidateCache();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_invalidateCache(int32_t flags);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_invalidateCache2
// typeId=1962336065

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_invalidateCache2 : public BMethodRequest {
	public: PClientInfo ci;
	public: PInvalidateCacheInfo info;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_invalidateCache2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_invalidateCache2(const PInvalidateCacheInfo& info);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_linkSords
// typeId=1326760021

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_linkSords : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring fromId;
	public: PArrayString toIds;
	public: PLinkSordZ linkZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_linkSords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_linkSords(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_linkSords2
// typeId=1820112259

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_linkSords2 : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring fromId;
	public: PArrayString toIds;
	public: PLinkSordZ linkSordZ;
	public: PLinkSordInfo linkSordInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_linkSords2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_linkSords2(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkSordZ, const PLinkSordInfo& linkSordInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_lockArchive
// typeId=2083874271

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_lockArchive : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring keyId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_lockArchive();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_lockArchive(const ::std::wstring& keyId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_login
// typeId=1526465549

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_login : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userName;
	public: ::std::wstring userPwd;
	public: ::std::wstring clientComputer;
	public: ::std::wstring runAsUser;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_login();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_login(const ::std::wstring& userName, const ::std::wstring& userPwd, const ::std::wstring& clientComputer, const ::std::wstring& runAsUser);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_loginAdmin
// typeId=139618532

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_loginAdmin : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring userName;
	public: ::std::wstring userPwd;
	public: ::std::wstring clientComputer;
	public: ::std::wstring reportAsUser;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_loginAdmin();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_loginAdmin(const ::std::wstring& userName, const ::std::wstring& userPwd, const ::std::wstring& clientComputer, const ::std::wstring& reportAsUser);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_loginEloProf
// typeId=1544232786

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_loginEloProf : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t userId;
	public: ::std::wstring certificate;
	public: ::std::wstring clientComputer;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_loginEloProf();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_loginEloProf(int32_t userId, const ::std::wstring& certificate, const ::std::wstring& clientComputer);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_loginKerberos
// typeId=575080338

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_loginKerberos : public BMethodRequest {
	public: PClientInfo ci;
	public: PBytes ticket;
	public: ::std::wstring clientComputer;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_loginKerberos();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_loginKerberos(const PBytes& ticket, const ::std::wstring& clientComputer);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_logout
// typeId=75785664

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_logout : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_logout();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_moveDocuments
// typeId=1730554767

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_moveDocuments : public BMethodRequest {
	public: PClientInfo ci;
	public: PMoveDocumentsInfo moveDocumentsInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_moveDocuments();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_moveDocuments(const PMoveDocumentsInfo& moveDocumentsInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_notifyServer
// typeId=1873214498

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_notifyServer : public BMethodRequest {
	public: PClientInfo ci;
	public: PNotifyServerInfo msg;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_notifyServer();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_notifyServer(const PNotifyServerInfo& msg);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_openEventBus
// typeId=1111320026

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_openEventBus : public BMethodRequest {
	public: PClientInfo ci;
	public: PEventBusParams params;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_openEventBus();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_openEventBus(const PEventBusParams& params);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_parseException
// typeId=218602898

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_parseException : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring exceptionString;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_parseException();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_parseException(const ::std::wstring& exceptionString);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_processFindResult
// typeId=255834993

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_processFindResult : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring searchId;
	public: PProcessInfo procInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_processFindResult();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_processFindResult(const ::std::wstring& searchId, const PProcessInfo& procInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_processOcr
// typeId=2058356197

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_processOcr : public BMethodRequest {
	public: PClientInfo ci;
	public: POcrInfo ocrInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_processOcr();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_processOcr(const POcrInfo& ocrInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_processTrees
// typeId=1894562916

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_processTrees : public BMethodRequest {
	public: PClientInfo ci;
	public: PNavigationInfo navigationInfo;
	public: PProcessInfo procInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_processTrees();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_processTrees(const PNavigationInfo& navigationInfo, const PProcessInfo& procInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_provideCryptPassword
// typeId=515214142

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_provideCryptPassword : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring encryptionSet;
	public: ::std::wstring pwd;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_provideCryptPassword();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_provideCryptPassword(const ::std::wstring& encryptionSet, const ::std::wstring& pwd);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_queryJobProtocol
// typeId=1653875517

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_queryJobProtocol : public BMethodRequest {
	public: PClientInfo ci;
	public: PQueryJobProtocolInfo queryJobProtocolInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_queryJobProtocol();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_queryJobProtocol(const PQueryJobProtocolInfo& queryJobProtocolInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_queryJobState
// typeId=221322822

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_queryJobState : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring jobGuid;
	public: bool activeJobs;
	public: bool finishedJobs;
	public: bool fullInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_queryJobState();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_queryJobState(const ::std::wstring& jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_refSord
// typeId=1607355701

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_refSord : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring oldParentId;
	public: ::std::wstring newParentId;
	public: ::std::wstring objId;
	public: int32_t manSortIdx;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_refSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_refSord(const ::std::wstring& oldParentId, const ::std::wstring& newParentId, const ::std::wstring& objId, int32_t manSortIdx);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_registerOcrWorker
// typeId=318217117

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_registerOcrWorker : public BMethodRequest {
	public: PClientInfo ci;
	public: POcrWorker ocrWorker;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_registerOcrWorker();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_registerOcrWorker(const POcrWorker& ocrWorker);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_reload
// typeId=86902351

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_reload : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_reload();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_reloadScripts
// typeId=1767312455

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_reloadScripts : public BMethodRequest {
	public: PClientInfo ci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_reloadScripts();
	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_resolveRights
// typeId=262295187

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_resolveRights : public BMethodRequest {
	public: PClientInfo ci;
	public: PUserInfo ui;
	public: PResolveRightsInfo info;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_resolveRights();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_resolveRights(const PUserInfo& ui, const PResolveRightsInfo& info);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_restoreSord
// typeId=487898554

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_restoreSord : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring objId;
	public: PRestoreOptions restoreOptions;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_restoreSord();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_restoreSord(const ::std::wstring& objId, const PRestoreOptions& restoreOptions);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_sendEvents
// typeId=1721831543

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_sendEvents : public BMethodRequest {
	public: PClientInfo ci;
	public: int64_t subsId;
	public: PArrayEvent events;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_sendEvents();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_sendEvents(int64_t subsId, const PArrayEvent& events);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_setScriptsToDebug
// typeId=1212168964

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_setScriptsToDebug : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring scriptsToDebug;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_setScriptsToDebug();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_setScriptsToDebug(const ::std::wstring& scriptsToDebug);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_setServerInfo
// typeId=1300195555

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_setServerInfo : public BMethodRequest {
	public: PClientInfo ci;
	public: PServerInfo serverInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_setServerInfo();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_setServerInfo(const PServerInfo& serverInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_setServerInfoDM
// typeId=347556966

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_setServerInfoDM : public BMethodRequest {
	public: PClientInfo ci;
	public: PServerInfoDM serverInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_setServerInfoDM();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_setServerInfoDM(const PServerInfoDM& serverInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_setSessionOptions
// typeId=830182988

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_setSessionOptions : public BMethodRequest {
	public: PClientInfo ci;
	public: PSessionOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_setSessionOptions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_setSessionOptions(const PSessionOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startAdHocWorkFlow
// typeId=1995358580

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startAdHocWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring name;
	public: ::std::wstring objId;
	public: PArrayString arrUserIds;
	public: ::std::wstring nodeName;
	public: bool forValidation;
	public: bool serialFlow;
	public: ::std::wstring cancelUserId;
	public: ::std::wstring cancelMessage;
	public: ::std::wstring finishedUserId;
	public: ::std::wstring finishedMessage;
	public: ::std::wstring finishedScript;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startAdHocWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startAdHocWorkFlow(const ::std::wstring& name, const ::std::wstring& objId, const PArrayString& arrUserIds, const ::std::wstring& nodeName, bool forValidation, bool serialFlow, const ::std::wstring& cancelUserId, const ::std::wstring& cancelMessage, const ::std::wstring& finishedUserId, const ::std::wstring& finishedMessage, const ::std::wstring& finishedScript);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startAdHocWorkFlow2
// typeId=1726573786

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startAdHocWorkFlow2 : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring name;
	public: ::std::wstring objId;
	public: PArrayUserNodeInfo userNodeInfo;
	public: PStartAdHocWorkflowInfo startWfInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startAdHocWorkFlow2();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startAdHocWorkFlow2(const ::std::wstring& name, const ::std::wstring& objId, const PArrayUserNodeInfo& userNodeInfo, const PStartAdHocWorkflowInfo& startWfInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startAdHocWorkFlow3
// typeId=1726573785

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startAdHocWorkFlow3 : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring name;
	public: ::std::wstring objId;
	public: PStartAdHocWorkflowInfo startWfInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startAdHocWorkFlow3();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startAdHocWorkFlow3(const ::std::wstring& name, const ::std::wstring& objId, const PStartAdHocWorkflowInfo& startWfInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startExport
// typeId=1213820864

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startExport : public BMethodRequest {
	public: PClientInfo ci;
	public: PArrayString topLevelIDs;
	public: int64_t options;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startExport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startExport(const PArrayString& topLevelIDs, int64_t options);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startExportExt
// typeId=1607764545

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startExportExt : public BMethodRequest {
	public: PClientInfo ci;
	public: PExportExtOptions options;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startExportExt();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startExportExt(const PExportExtOptions& options);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startImport
// typeId=1318178737

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startImport : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring filingPath;
	public: int32_t guidMethod;
	public: int64_t options;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startImport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startImport(const ::std::wstring& filingPath, int32_t guidMethod, int64_t options);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_startWorkFlow
// typeId=211211499

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_startWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring templFlowId;
	public: ::std::wstring flowName;
	public: ::std::wstring objId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_startWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_startWorkFlow(const ::std::wstring& templFlowId, const ::std::wstring& flowName, const ::std::wstring& objId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_takeWorkFlowNode
// typeId=1305676322

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_takeWorkFlowNode : public BMethodRequest {
	public: PClientInfo ci;
	public: int32_t nFlowId;
	public: int32_t nNodeId;
	public: ::std::wstring sUserId;
	public: int32_t nFlags;
	public: PLockZ lockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_takeWorkFlowNode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_takeWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const ::std::wstring& sUserId, int32_t nFlags, const PLockZ& lockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_terminatePublicDownloadUrls
// typeId=158007264

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_terminatePublicDownloadUrls : public BMethodRequest {
	public: PClientInfo ci;
	public: PPublicDownloadOptions opts;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_terminatePublicDownloadUrls();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_terminatePublicDownloadUrls(const PPublicDownloadOptions& opts);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_terminateWorkFlow
// typeId=1986005738

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_terminateWorkFlow : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring flowId;
	public: PLockZ unlockZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_terminateWorkFlow();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_terminateWorkFlow(const ::std::wstring& flowId, const PLockZ& unlockZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_testAdapter
// typeId=1934035815

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_testAdapter : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring fn;
	public: PArrayString params;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_testAdapter();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_testAdapter(const ::std::wstring& fn, const PArrayString& params);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_IXServicePortIF_unlinkSords
// typeId=1910068060

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BRequest_IXServicePortIF_unlinkSords : public BMethodRequest {
	public: PClientInfo ci;
	public: ::std::wstring fromId;
	public: PArrayString toIds;
	public: PLinkSordZ linkZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_IXServicePortIF_unlinkSords();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_IXServicePortIF_unlinkSords(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1
// typeId=139578694

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1 : public BSerializable {
	public: bool result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1(bool result = bool()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_10
// typeId=31972170

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_10 : public BSerializable {
	public: ::std::wstring result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_10(::std::wstring result = ::std::wstring()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1001617329
// typeId=1737934677

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1001617329 : public BSerializable {
	public: de::elo::ix::client::PArrayUserName result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1001617329(de::elo::ix::client::PArrayUserName result = de::elo::ix::client::PArrayUserName()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_100361105
// typeId=1083146178

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_100361105 : public BSerializable {
	public: PArrayInt result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_100361105(PArrayInt result = PArrayInt()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1005790586
// typeId=1028792992

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1005790586 : public BSerializable {
	public: de::elo::ix::client::PArrayContextTerm result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1005790586(de::elo::ix::client::PArrayContextTerm result = de::elo::ix::client::PArrayContextTerm()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1034263904
// typeId=928929669

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1034263904 : public BSerializable {
	public: de::elo::ix::client::PCombineAclResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1034263904(de::elo::ix::client::PCombineAclResult result = de::elo::ix::client::PCombineAclResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1047127860
// typeId=1007078901

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1047127860 : public BSerializable {
	public: de::elo::ix::client::PArrayDocument result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1047127860(de::elo::ix::client::PArrayDocument result = de::elo::ix::client::PArrayDocument()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1057373949
// typeId=1483320409

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1057373949 : public BSerializable {
	public: de::elo::ix::client::PReportOptions result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1057373949(de::elo::ix::client::PReportOptions result = de::elo::ix::client::PReportOptions()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_105830886
// typeId=1366049664

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_105830886 : public BSerializable {
	public: de::elo::ix::client::PArraySubsInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_105830886(de::elo::ix::client::PArraySubsInfo result = de::elo::ix::client::PArraySubsInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1078168929
// typeId=1463196284

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1078168929 : public BSerializable {
	public: de::elo::ix::client::PArrayFileData result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1078168929(de::elo::ix::client::PArrayFileData result = de::elo::ix::client::PArrayFileData()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1088095067
// typeId=253657563

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1088095067 : public BSerializable {
	public: de::elo::ix::client::PArrayTranslateTerm result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1088095067(de::elo::ix::client::PArrayTranslateTerm result = de::elo::ix::client::PArrayTranslateTerm()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1107316733
// typeId=874621629

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1107316733 : public BSerializable {
	public: de::elo::ix::client::PArrayDocMaskLineTemplate result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1107316733(de::elo::ix::client::PArrayDocMaskLineTemplate result = de::elo::ix::client::PArrayDocMaskLineTemplate()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1112009864
// typeId=1906806987

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1112009864 : public BSerializable {
	public: de::elo::ix::client::PArrayKeyInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1112009864(de::elo::ix::client::PArrayKeyInfo result = de::elo::ix::client::PArrayKeyInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1132956238
// typeId=1840998419

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1132956238 : public BSerializable {
	public: de::elo::ix::client::PArrayUserInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1132956238(de::elo::ix::client::PArrayUserInfo result = de::elo::ix::client::PArrayUserInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1143177929
// typeId=50804539

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1143177929 : public BSerializable {
	public: de::elo::ix::client::feed::PHashTag result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1143177929(de::elo::ix::client::feed::PHashTag result = de::elo::ix::client::feed::PHashTag()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1153931872
// typeId=1917165361

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1153931872 : public BSerializable {
	public: de::elo::ix::client::PValuesOfObjKey result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1153931872(de::elo::ix::client::PValuesOfObjKey result = de::elo::ix::client::PValuesOfObjKey()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1191976387
// typeId=1472696983

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1191976387 : public BSerializable {
	public: de::elo::ix::client::PAny result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1191976387(de::elo::ix::client::PAny result = de::elo::ix::client::PAny()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1197100286
// typeId=678319756

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1197100286 : public BSerializable {
	public: de::elo::ix::client::PSessionOptions result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1197100286(de::elo::ix::client::PSessionOptions result = de::elo::ix::client::PSessionOptions()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1233469422
// typeId=778916661

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1233469422 : public BSerializable {
	public: de::elo::ix::client::PArrayBackupProfile result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1233469422(de::elo::ix::client::PArrayBackupProfile result = de::elo::ix::client::PArrayBackupProfile()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1264954948
// typeId=1553005093

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1264954948 : public BSerializable {
	public: de::elo::ix::client::PIXServicePortC result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1264954948(de::elo::ix::client::PIXServicePortC result = de::elo::ix::client::PIXServicePortC()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1301335819
// typeId=526443365

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1301335819 : public BSerializable {
	public: de::elo::ix::client::PFindResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1301335819(de::elo::ix::client::PFindResult result = de::elo::ix::client::PFindResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1320348587
// typeId=1169396716

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1320348587 : public BSerializable {
	public: de::elo::ix::client::system::PLicenseReport result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1320348587(de::elo::ix::client::system::PLicenseReport result = de::elo::ix::client::system::PLicenseReport()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_133130047
// typeId=324094143

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_133130047 : public BSerializable {
	public: de::elo::ix::client::PArraySordType result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_133130047(de::elo::ix::client::PArraySordType result = de::elo::ix::client::PArraySordType()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1376733713
// typeId=98220986

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1376733713 : public BSerializable {
	public: de::elo::ix::client::PArraySessionInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1376733713(de::elo::ix::client::PArraySessionInfo result = de::elo::ix::client::PArraySessionInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1383534582
// typeId=878709939

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1383534582 : public BSerializable {
	public: de::elo::ix::client::system::PArchivReport result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1383534582(de::elo::ix::client::system::PArchivReport result = de::elo::ix::client::system::PArchivReport()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1401065069
// typeId=1364135521

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1401065069 : public BSerializable {
	public: de::elo::ix::client::PUserProfile result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1401065069(de::elo::ix::client::PUserProfile result = de::elo::ix::client::PUserProfile()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1425760760
// typeId=1576794397

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1425760760 : public BSerializable {
	public: de::elo::ix::client::PServerInfoDM result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1425760760(de::elo::ix::client::PServerInfoDM result = de::elo::ix::client::PServerInfoDM()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1426941339
// typeId=1775232095

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1426941339 : public BSerializable {
	public: de::elo::ix::client::myelo::PMyELOState result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1426941339(de::elo::ix::client::myelo::PMyELOState result = de::elo::ix::client::myelo::PMyELOState()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1436376940
// typeId=201271360

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1436376940 : public BSerializable {
	public: de::elo::ix::client::PJobState result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1436376940(de::elo::ix::client::PJobState result = de::elo::ix::client::PJobState()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1443841819
// typeId=980746876

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1443841819 : public BSerializable {
	public: de::elo::ix::client::PArrayNoteTemplate result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1443841819(de::elo::ix::client::PArrayNoteTemplate result = de::elo::ix::client::PArrayNoteTemplate()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_148564345
// typeId=1968102497

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_148564345 : public BSerializable {
	public: de::elo::ix::client::PGetWebDAVPathResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_148564345(de::elo::ix::client::PGetWebDAVPathResult result = de::elo::ix::client::PGetWebDAVPathResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1485735592
// typeId=853868916

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1485735592 : public BSerializable {
	public: de::elo::ix::client::PUserInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1485735592(de::elo::ix::client::PUserInfo result = de::elo::ix::client::PUserInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1495731174
// typeId=888818351

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1495731174 : public BSerializable {
	public: de::elo::ix::client::PKeywordList result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1495731174(de::elo::ix::client::PKeywordList result = de::elo::ix::client::PKeywordList()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_15
// typeId=31972165

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_15 : public BSerializable {
	public: PContentStream result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_15(PContentStream result = PContentStream()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1535847981
// typeId=1539142900

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1535847981 : public BSerializable {
	public: byps_ptr< ::std::set< de::elo::ix::client::feed::PHashTag > > result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1535847981(byps_ptr< ::std::set< de::elo::ix::client::feed::PHashTag > > result = byps_ptr< ::std::set< de::elo::ix::client::feed::PHashTag > >()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1537059480
// typeId=1208871945

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1537059480 : public BSerializable {
	public: de::elo::ix::client::PKeyInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1537059480(de::elo::ix::client::PKeyInfo result = de::elo::ix::client::PKeyInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1552114559
// typeId=2135982691

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1552114559 : public BSerializable {
	public: de::elo::ix::client::PKeywordsDynamicResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1552114559(de::elo::ix::client::PKeywordsDynamicResult result = de::elo::ix::client::PKeywordsDynamicResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1556767716
// typeId=1590515712

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1556767716 : public BSerializable {
	public: de::elo::ix::client::feed::PMapStringHashTag result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1556767716(de::elo::ix::client::feed::PMapStringHashTag result = de::elo::ix::client::feed::PMapStringHashTag()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1576340510
// typeId=664594975

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1576340510 : public BSerializable {
	public: de::elo::ix::client::PPurgeSettings result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1576340510(de::elo::ix::client::PPurgeSettings result = de::elo::ix::client::PPurgeSettings()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1585309177
// typeId=1516472013

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1585309177 : public BSerializable {
	public: de::elo::ix::client::myelo::PMyELOContent result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1585309177(de::elo::ix::client::myelo::PMyELOContent result = de::elo::ix::client::myelo::PMyELOContent()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1663767661
// typeId=1136640270

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1663767661 : public BSerializable {
	public: de::elo::ix::client::PWFDiagram result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1663767661(de::elo::ix::client::PWFDiagram result = de::elo::ix::client::PWFDiagram()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1698110251
// typeId=237230375

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1698110251 : public BSerializable {
	public: de::elo::ix::client::PArrayCounterInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1698110251(de::elo::ix::client::PArrayCounterInfo result = de::elo::ix::client::PArrayCounterInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1699606509
// typeId=792677022

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1699606509 : public BSerializable {
	public: de::elo::ix::client::PForwardWorkflowNodeResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1699606509(de::elo::ix::client::PForwardWorkflowNodeResult result = de::elo::ix::client::PForwardWorkflowNodeResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1701141707
// typeId=1830105166

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1701141707 : public BSerializable {
	public: de::elo::ix::client::PArrayReminder result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1701141707(de::elo::ix::client::PArrayReminder result = de::elo::ix::client::PArrayReminder()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1701204890
// typeId=1855130839

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1701204890 : public BSerializable {
	public: de::elo::ix::client::PServerInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1701204890(de::elo::ix::client::PServerInfo result = de::elo::ix::client::PServerInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1712381166
// typeId=226398691

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1712381166 : public BSerializable {
	public: de::elo::ix::client::PInvalidateCacheResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1712381166(de::elo::ix::client::PInvalidateCacheResult result = de::elo::ix::client::PInvalidateCacheResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1737266313
// typeId=470722300

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1737266313 : public BSerializable {
	public: de::elo::ix::client::PArrayConfigFile result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1737266313(de::elo::ix::client::PArrayConfigFile result = de::elo::ix::client::PArrayConfigFile()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1754570852
// typeId=439024483

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1754570852 : public BSerializable {
	public: de::elo::ix::client::PCheckoutWorkflowHistoryResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1754570852(de::elo::ix::client::PCheckoutWorkflowHistoryResult result = de::elo::ix::client::PCheckoutWorkflowHistoryResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1756288553
// typeId=2129303359

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1756288553 : public BSerializable {
	public: de::elo::ix::client::PArrayMapHist result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1756288553(de::elo::ix::client::PArrayMapHist result = de::elo::ix::client::PArrayMapHist()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1768472140
// typeId=1408305917

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1768472140 : public BSerializable {
	public: de::elo::ix::client::PArrayWFVersion result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1768472140(de::elo::ix::client::PArrayWFVersion result = de::elo::ix::client::PArrayWFVersion()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1788243283
// typeId=538961305

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1788243283 : public BSerializable {
	public: de::elo::ix::client::PArrayJobState result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1788243283(de::elo::ix::client::PArrayJobState result = de::elo::ix::client::PArrayJobState()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_18214274
// typeId=124408536

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_18214274 : public BSerializable {
	public: de::elo::ix::client::system::PUserReport result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_18214274(de::elo::ix::client::system::PUserReport result = de::elo::ix::client::system::PUserReport()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1822579866
// typeId=218334399

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1822579866 : public BSerializable {
	public: de::elo::ix::client::PWFEditNode result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1822579866(de::elo::ix::client::PWFEditNode result = de::elo::ix::client::PWFEditNode()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1826370901
// typeId=584143824

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1826370901 : public BSerializable {
	public: de::elo::ix::client::PArrayKeyValue result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1826370901(de::elo::ix::client::PArrayKeyValue result = de::elo::ix::client::PArrayKeyValue()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1835331414
// typeId=267493766

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1835331414 : public BSerializable {
	public: de::elo::ix::client::PSordPaths result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1835331414(de::elo::ix::client::PSordPaths result = de::elo::ix::client::PSordPaths()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1870182600
// typeId=1546359614

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1870182600 : public BSerializable {
	public: de::elo::ix::client::PArrayColorData result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1870182600(de::elo::ix::client::PArrayColorData result = de::elo::ix::client::PArrayColorData()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1881161566
// typeId=1082076800

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1881161566 : public BSerializable {
	public: de::elo::ix::client::PAutoFilingResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1881161566(de::elo::ix::client::PAutoFilingResult result = de::elo::ix::client::PAutoFilingResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1888107655
// typeId=1300693476

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1888107655 : public BSerializable {
	public: PArrayString result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1888107655(PArrayString result = PArrayString()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_19
// typeId=31972161

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_19 : public BSerializable {
	public: bool result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_19(bool result = bool()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1963952629
// typeId=2087116643

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1963952629 : public BSerializable {
	public: de::elo::ix::client::PArrayMapDomain result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1963952629(de::elo::ix::client::PArrayMapDomain result = de::elo::ix::client::PArrayMapDomain()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_1995912373
// typeId=496923600

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_1995912373 : public BSerializable {
	public: de::elo::ix::client::PNoteTemplate result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_1995912373(de::elo::ix::client::PNoteTemplate result = de::elo::ix::client::PNoteTemplate()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_200528028
// typeId=670536426

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_200528028 : public BSerializable {
	public: de::elo::ix::client::PAclAccessResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_200528028(de::elo::ix::client::PAclAccessResult result = de::elo::ix::client::PAclAccessResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2006133032
// typeId=1542551545

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2006133032 : public BSerializable {
	public: de::elo::ix::client::PArrayWFCollectNode result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2006133032(de::elo::ix::client::PArrayWFCollectNode result = de::elo::ix::client::PArrayWFCollectNode()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2011132580
// typeId=1152181358

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2011132580 : public BSerializable {
	public: de::elo::ix::client::PMapData result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2011132580(de::elo::ix::client::PMapData result = de::elo::ix::client::PMapData()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2015686193
// typeId=1749255216

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2015686193 : public BSerializable {
	public: de::elo::ix::client::PWFNode result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2015686193(de::elo::ix::client::PWFNode result = de::elo::ix::client::PWFNode()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2054753789
// typeId=65290103

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2054753789 : public BSerializable {
	public: de::elo::ix::client::PDocMask result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2054753789(de::elo::ix::client::PDocMask result = de::elo::ix::client::PDocMask()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2056457945
// typeId=1754530970

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2056457945 : public BSerializable {
	public: de::elo::ix::client::PArchiveStatistics result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2056457945(de::elo::ix::client::PArchiveStatistics result = de::elo::ix::client::PArchiveStatistics()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_206201524
// typeId=271580133

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_206201524 : public BSerializable {
	public: de::elo::ix::client::PArrayKeyword result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_206201524(de::elo::ix::client::PArrayKeyword result = de::elo::ix::client::PArrayKeyword()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2062827124
// typeId=59064871

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2062827124 : public BSerializable {
	public: de::elo::ix::client::PPublicDownload result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2062827124(de::elo::ix::client::PPublicDownload result = de::elo::ix::client::PPublicDownload()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_21
// typeId=31972138

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_21 : public BSerializable {
	public: PSerializable result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_21(PSerializable result = PSerializable()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_2121298555
// typeId=1182476551

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_2121298555 : public BSerializable {
	public: de::elo::ix::client::PActivityProject result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_2121298555(de::elo::ix::client::PActivityProject result = de::elo::ix::client::PActivityProject()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_222450704
// typeId=269034055

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_222450704 : public BSerializable {
	public: de::elo::ix::client::PQueryJobProtocolResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_222450704(de::elo::ix::client::PQueryJobProtocolResult result = de::elo::ix::client::PQueryJobProtocolResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_231031238
// typeId=1008002146

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_231031238 : public BSerializable {
	public: de::elo::ix::client::PArrayStoreInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_231031238(de::elo::ix::client::PArrayStoreInfo result = de::elo::ix::client::PArrayStoreInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_239574905
// typeId=334967155

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_239574905 : public BSerializable {
	public: de::elo::ix::client::PFulltextConfig result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_239574905(de::elo::ix::client::PFulltextConfig result = de::elo::ix::client::PFulltextConfig()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_256674679
// typeId=516768961

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_256674679 : public BSerializable {
	public: de::elo::ix::client::PReminder result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_256674679(de::elo::ix::client::PReminder result = de::elo::ix::client::PReminder()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_276702696
// typeId=270472684

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_276702696 : public BSerializable {
	public: de::elo::ix::client::system::PSystemReport result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_276702696(de::elo::ix::client::system::PSystemReport result = de::elo::ix::client::system::PSystemReport()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_323351719
// typeId=679516051

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_323351719 : public BSerializable {
	public: de::elo::ix::client::PSubscription result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_323351719(de::elo::ix::client::PSubscription result = de::elo::ix::client::PSubscription()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_333475674
// typeId=1093888861

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_333475674 : public BSerializable {
	public: de::elo::ix::client::health::PHealthCheckInfos result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_333475674(de::elo::ix::client::health::PHealthCheckInfos result = de::elo::ix::client::health::PHealthCheckInfos()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_341056676
// typeId=945357981

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_341056676 : public BSerializable {
	public: de::elo::ix::client::PDocument result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_341056676(de::elo::ix::client::PDocument result = de::elo::ix::client::PDocument()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_42339713
// typeId=58447221

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_42339713 : public BSerializable {
	public: de::elo::ix::client::PMapDomain result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_42339713(de::elo::ix::client::PMapDomain result = de::elo::ix::client::PMapDomain()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_460199434
// typeId=1768431067

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_460199434 : public BSerializable {
	public: de::elo::ix::client::PActivity result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_460199434(de::elo::ix::client::PActivity result = de::elo::ix::client::PActivity()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_491352407
// typeId=652213248

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_491352407 : public BSerializable {
	public: de::elo::ix::client::PArraySordHist result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_491352407(de::elo::ix::client::PArraySordHist result = de::elo::ix::client::PArraySordHist()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_494610451
// typeId=2092431731

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_494610451 : public BSerializable {
	public: de::elo::ix::client::PNotification result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_494610451(de::elo::ix::client::PNotification result = de::elo::ix::client::PNotification()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_498630295
// typeId=1349324407

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_498630295 : public BSerializable {
	public: byps::PMapIntegerString result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_498630295(byps::PMapIntegerString result = byps::PMapIntegerString()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_5
// typeId=139578690

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_5 : public BSerializable {
	public: int32_t result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_5(int32_t result = int32_t()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_52201250
// typeId=1769614830

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_52201250 : public BSerializable {
	public: de::elo::ix::client::PBackupPurgeStatus result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_52201250(de::elo::ix::client::PBackupPurgeStatus result = de::elo::ix::client::PBackupPurgeStatus()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_545905411
// typeId=1133476629

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_545905411 : public BSerializable {
	public: de::elo::ix::client::PLicenseResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_545905411(de::elo::ix::client::PLicenseResult result = de::elo::ix::client::PLicenseResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_6
// typeId=139578689

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_6 : public BSerializable {
	public: int64_t result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_6(int64_t result = int64_t()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_607287445
// typeId=1768200726

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_607287445 : public BSerializable {
	public: de::elo::ix::client::PArrayActivityProject result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_607287445(de::elo::ix::client::PArrayActivityProject result = de::elo::ix::client::PArrayActivityProject()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_63967077
// typeId=311083626

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_63967077 : public BSerializable {
	public: de::elo::ix::client::PExecuteScriptResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_63967077(de::elo::ix::client::PExecuteScriptResult result = de::elo::ix::client::PExecuteScriptResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_661820173
// typeId=765305647

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_661820173 : public BSerializable {
	public: de::elo::ix::client::PPreviewImageResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_661820173(de::elo::ix::client::PPreviewImageResult result = de::elo::ix::client::PPreviewImageResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_730157667
// typeId=296180383

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_730157667 : public BSerializable {
	public: de::elo::ix::client::POcrWorker result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_730157667(de::elo::ix::client::POcrWorker result = de::elo::ix::client::POcrWorker()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_736351635
// typeId=790953868

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_736351635 : public BSerializable {
	public: de::elo::ix::client::feed::PAction result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_736351635(de::elo::ix::client::feed::PAction result = de::elo::ix::client::feed::PAction()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_755261279
// typeId=933605785

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_755261279 : public BSerializable {
	public: de::elo::ix::client::PArrayIdName result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_755261279(de::elo::ix::client::PArrayIdName result = de::elo::ix::client::PArrayIdName()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_776454091
// typeId=799026444

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_776454091 : public BSerializable {
	public: de::elo::ix::client::PArrayNote result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_776454091(de::elo::ix::client::PArrayNote result = de::elo::ix::client::PArrayNote()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_77743605
// typeId=1249722428

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_77743605 : public BSerializable {
	public: de::elo::ix::client::PApplyForNotificationsInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_77743605(de::elo::ix::client::PApplyForNotificationsInfo result = de::elo::ix::client::PApplyForNotificationsInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_777531606
// typeId=115175465

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_777531606 : public BSerializable {
	public: de::elo::ix::client::PLoginResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_777531606(de::elo::ix::client::PLoginResult result = de::elo::ix::client::PLoginResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_784089396
// typeId=942817669

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_784089396 : public BSerializable {
	public: de::elo::ix::client::PIXExceptionData result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_784089396(de::elo::ix::client::PIXExceptionData result = de::elo::ix::client::PIXExceptionData()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_785380175
// typeId=30303361

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_785380175 : public BSerializable {
	public: de::elo::ix::client::PArrayEditInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_785380175(de::elo::ix::client::PArrayEditInfo result = de::elo::ix::client::PArrayEditInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_809229049
// typeId=681379622

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_809229049 : public BSerializable {
	public: de::elo::ix::client::PArrayCryptInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_809229049(de::elo::ix::client::PArrayCryptInfo result = de::elo::ix::client::PArrayCryptInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_810727301
// typeId=1125286952

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_810727301 : public BSerializable {
	public: de::elo::ix::client::PNotifyServerResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_810727301(de::elo::ix::client::PNotifyServerResult result = de::elo::ix::client::PNotifyServerResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_820228328
// typeId=474407488

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_820228328 : public BSerializable {
	public: de::elo::ix::client::PEditInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_820228328(de::elo::ix::client::PEditInfo result = de::elo::ix::client::PEditInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_881442092
// typeId=1007204783

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_881442092 : public BSerializable {
	public: de::elo::ix::client::PVectorPublicDownload result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_881442092(de::elo::ix::client::PVectorPublicDownload result = de::elo::ix::client::PVectorPublicDownload()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_884364631
// typeId=1628589312

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_884364631 : public BSerializable {
	public: de::elo::ix::client::PArrayReplSetName result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_884364631(de::elo::ix::client::PArrayReplSetName result = de::elo::ix::client::PArrayReplSetName()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_888671717
// typeId=970359246

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_888671717 : public BSerializable {
	public: de::elo::ix::client::PFileData result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_888671717(de::elo::ix::client::PFileData result = de::elo::ix::client::PFileData()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_892356058
// typeId=1595522649

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_892356058 : public BSerializable {
	public: de::elo::ix::client::InheritKeywordingResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_892356058(de::elo::ix::client::InheritKeywordingResult result = de::elo::ix::client::InheritKeywordingResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_893011331
// typeId=1901668644

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_893011331 : public BSerializable {
	public: de::elo::ix::client::PMapIntegerOrgUnitInfo result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_893011331(de::elo::ix::client::PMapIntegerOrgUnitInfo result = de::elo::ix::client::PMapIntegerOrgUnitInfo()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_907729609
// typeId=1537036490

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_907729609 : public BSerializable {
	public: de::elo::ix::client::PVectorResolveRightsResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_907729609(de::elo::ix::client::PVectorResolveRightsResult result = de::elo::ix::client::PVectorResolveRightsResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_910482075
// typeId=1281727937

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_910482075 : public BSerializable {
	public: de::elo::ix::client::PArrayEvent result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_910482075(de::elo::ix::client::PArrayEvent result = de::elo::ix::client::PArrayEvent()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_937420667
// typeId=1910622485

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_937420667 : public BSerializable {
	public: de::elo::ix::client::PNote result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_937420667(de::elo::ix::client::PNote result = de::elo::ix::client::PNote()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BResult_998509414
// typeId=870856762

namespace de { namespace elo { namespace ix { namespace client { 

using namespace ::byps;

class BResult_998509414 : public BSerializable {
	public: de::elo::ix::client::POcrResult result;
	// checkpoint byps.gen.cpp.GenApiClass:473
	public: BResult_998509414(de::elo::ix::client::POcrResult result = de::elo::ix::client::POcrResult()) : result(result) {}	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
};

}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_RawStreamService_download
// typeId=280725475

namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

using namespace ::byps;

class BRequest_RawStreamService_download : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PArrayString params;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_RawStreamService_download();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_RawStreamService_download(const PArrayString& params);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_RawStreamService_upload
// typeId=527524138

namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

using namespace ::byps;

class BRequest_RawStreamService_upload : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PArrayString params;
	public: PContentStream is;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_RawStreamService_upload();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_RawStreamService_upload(const PArrayString& params, const PContentStream& is);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_WClientService_onAfterVersionChanged
// typeId=2095806986

namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 

using namespace ::byps;

class BRequest_WClientService_onAfterVersionChanged : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: int32_t objId;
	public: int32_t docId;
	public: int32_t flags;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_WClientService_onAfterVersionChanged();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_WClientService_onAfterVersionChanged(int32_t objId, int32_t docId, int32_t flags);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedNotification_updateAction
// typeId=688797212

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedNotification_updateAction : public BMethodRequest {
	public: PAction action;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedNotification_updateAction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedNotification_updateAction(const PAction& action);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_checkinAction
// typeId=1138765790

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_checkinAction : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PAction action;
	public: PActionZ actionZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_checkinAction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_checkinAction(const PAction& action, const PActionZ& actionZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_checkoutAction
// typeId=1737190301

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_checkoutAction : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring actionGuid;
	public: PActionZ actionZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_checkoutAction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_checkoutAction(const ::std::wstring& actionGuid, const PActionZ& actionZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_checkoutHashTag
// typeId=122354907

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_checkoutHashTag : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring hashtagGuidOrName;
	public: PHashTagZ hstgZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_checkoutHashTag();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_checkoutHashTag(const ::std::wstring& hashtagGuidOrName, const PHashTagZ& hstgZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_createAction
// typeId=643943187

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_createAction : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: EActionType type;
	public: ::std::wstring parentGuid;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_createAction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_createAction(EActionType type, const ::std::wstring& parentGuid);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_createHashTagSubscription
// typeId=1471082196

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_createHashTagSubscription : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring hashtagGuidOrName;
	public: ::std::wstring userGuidOrId;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_createHashTagSubscription();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_createHashTagSubscription(const ::std::wstring& hashtagGuidOrName, const ::std::wstring& userGuidOrId);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findFirstActions
// typeId=334710983

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findFirstActions : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PFindActionsInfo findInfo;
	public: int32_t max;
	public: PActionZ actionZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findFirstActions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findFirstActions(const PFindActionsInfo& findInfo, int32_t max, const PActionZ& actionZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findFirstHashTagRelation
// typeId=2144547950

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findFirstHashTagRelation : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PFindHashTagInfo findInfo;
	public: int32_t max;
	public: PHashTagZ hashTagZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findFirstHashTagRelation();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findFirstHashTagRelation(const PFindHashTagInfo& findInfo, int32_t max, const PHashTagZ& hashTagZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findFirstNotification
// typeId=906090337

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findFirstNotification : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PFindNotificationInfo findInfo;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findFirstNotification();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findFirstNotification(const PFindNotificationInfo& findInfo, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findHashTagByActions
// typeId=421489164

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findHashTagByActions : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PArrayString actionGuids;
	public: PHashTagZ hashTagZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findHashTagByActions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findHashTagByActions(const PArrayString& actionGuids, const PHashTagZ& hashTagZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findHashTags
// typeId=66310175

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findHashTags : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PFindHashTagInfo findInfo;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findHashTags();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findHashTags(const PFindHashTagInfo& findInfo);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findNextActions
// typeId=933597872

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findNextActions : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PActionZ actionZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findNextActions();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findNextActions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActionZ& actionZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findNextHashTagRelation
// typeId=1204755579

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findNextHashTagRelation : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	public: PHashTagZ hashTagZ;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findNextHashTagRelation();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findNextHashTagRelation(const ::std::wstring& searchId, int32_t idx, int32_t max, const PHashTagZ& hashTagZ);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_findNextNotification
// typeId=1326557416

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_findNextNotification : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring searchId;
	public: int32_t idx;
	public: int32_t max;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_findNextNotification();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_findNextNotification(const ::std::wstring& searchId, int32_t idx, int32_t max);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_internalInsertSystemAction
// typeId=1637137212

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_internalInsertSystemAction : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PAction action;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_internalInsertSystemAction();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_internalInsertSystemAction(const PAction& action);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_registerNotify
// typeId=458959949

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_registerNotify : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring feedGuid;
	public: PFeedNotification notify;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_registerNotify();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_registerNotify(const ::std::wstring& feedGuid, const PFeedNotification& notify);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_FeedService_unregisterNotify
// typeId=285270298

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

using namespace ::byps;

class BRequest_FeedService_unregisterNotify : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring feedGuid;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_FeedService_unregisterNotify();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_FeedService_unregisterNotify(const ::std::wstring& feedGuid);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_computeDoubleValue
// typeId=1919177848

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_computeDoubleValue : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring name;
	public: double doubleValue;
	public: HealthCheckValueOperation operation;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_computeDoubleValue();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_computeDoubleValue(const ::std::wstring& name, double doubleValue, HealthCheckValueOperation operation);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_read
// typeId=771256331

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_read : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: byps::PVectorString names;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_read();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_read(const byps::PVectorString& names);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_update
// typeId=1948144488

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_update : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PHealthCheckInfo hci;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_update();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_update(const PHealthCheckInfo& hci);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_updateAll
// typeId=720562919

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_updateAll : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PVectorHealthCheckInfo hcis;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_updateAll();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_updateAll(const PVectorHealthCheckInfo& hcis);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_updateDoubleValue
// typeId=677413784

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_updateDoubleValue : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring name;
	public: double doubleValue;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_updateDoubleValue();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_updateDoubleValue(const ::std::wstring& name, double doubleValue);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_updateMeanValue
// typeId=1150533084

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_updateMeanValue : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring name;
	public: double meanValue;
	public: int64_t sampleSize;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_updateMeanValue();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_updateMeanValue(const ::std::wstring& name, double meanValue, int64_t sampleSize);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_HealthCheckService_uploadAll
// typeId=1827236639

namespace de { namespace elo { namespace ix { namespace client { namespace health { 

using namespace ::byps;

class BRequest_HealthCheckService_uploadAll : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PSerializable reserved;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_HealthCheckService_uploadAll();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_HealthCheckService_uploadAll(const PSerializable& reserved);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_MyELOService_checkState
// typeId=2068722874

namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

using namespace ::byps;

class BRequest_MyELOService_checkState : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: ::std::wstring userGuidOrID;
	public: ::std::wstring sinceDateIso;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_MyELOService_checkState();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_MyELOService_checkState(const ::std::wstring& userGuidOrID, const ::std::wstring& sinceDateIso);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_MyELOService_readContent
// typeId=261913914

namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 

using namespace ::byps;

class BRequest_MyELOService_readContent : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PMyELOState state;
	public: PMyELOInfo info;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_MyELOService_readContent();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_MyELOService_readContent(const PMyELOState& state, const PMyELOInfo& info);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_ClientNotification_adminMode
// typeId=475567923

namespace de { namespace elo { namespace ix { namespace client { namespace notify { 

using namespace ::byps;

class BRequest_ClientNotification_adminMode : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: int32_t mode;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_ClientNotification_adminMode();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_ClientNotification_adminMode(const de::elo::ix::client::PClientInfo& ci, int32_t mode);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_ClientNotification_updateTask
// typeId=1469990419

namespace de { namespace elo { namespace ix { namespace client { namespace notify { 

using namespace ::byps;

class BRequest_ClientNotification_updateTask : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: de::elo::ix::client::PUserTask userTask;
	public: TaskNotifyType notifyType;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_ClientNotification_updateTask();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_ClientNotification_updateTask(const de::elo::ix::client::PClientInfo& ci, const de::elo::ix::client::PUserTask& userTask, TaskNotifyType notifyType);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_SystemInformation_archivReport
// typeId=1995041693

namespace de { namespace elo { namespace ix { namespace client { namespace system { 

using namespace ::byps;

class BRequest_SystemInformation_archivReport : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PSystemInfo si;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_SystemInformation_archivReport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_SystemInformation_archivReport(const PSystemInfo& si);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_SystemInformation_countDocsInStorePath
// typeId=1786633213

namespace de { namespace elo { namespace ix { namespace client { namespace system { 

using namespace ::byps;

class BRequest_SystemInformation_countDocsInStorePath : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PSystemInfo si;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_SystemInformation_countDocsInStorePath();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_SystemInformation_countDocsInStorePath(const PSystemInfo& si);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_SystemInformation_licenseReport
// typeId=821360905

namespace de { namespace elo { namespace ix { namespace client { namespace system { 

using namespace ::byps;

class BRequest_SystemInformation_licenseReport : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PSystemInfo si;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_SystemInformation_licenseReport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_SystemInformation_licenseReport(const PSystemInfo& si);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:652
//-------------------------------------------------
// BRequest_SystemInformation_userReport
// typeId=2081672491

namespace de { namespace elo { namespace ix { namespace client { namespace system { 

using namespace ::byps;

class BRequest_SystemInformation_userReport : public BMethodRequest {
	public: de::elo::ix::client::PClientInfo ci;
	public: PSystemInfo si;
	
	// checkpoint byps.gen.cpp.GenApiClass:488
	public: BRequest_SystemInformation_userReport();
	// checkpoint byps.gen.cpp.GenApiClass:535
	public: BRequest_SystemInformation_userReport(const PSystemInfo& si);	
	public: virtual BTYPEID BSerializable_getTypeId();
	// checkpoint byps.gen.cpp.GenApiClass:870
	public: void serialize(BIO& ar, const BVERSION version);
	public: virtual void execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult);
	// checkpoint byps.gen.cpp.GenApiClass:843
	public: virtual void setSession(const PSerializable& __byps__sess);
};

}}}}}

namespace de { namespace elo { namespace ix { namespace client { 

// Serializer for byte[]
void BSerializer_1374008726(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AccessC
void BSerializer_384025970(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AclAccessInfo
void BSerializer_11569337(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AclAccessResult
void BSerializer_200528028(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AclItem
void BSerializer_1255072841(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AclItemC
void BSerializer_1507233874(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AclItem[]
void BSerializer_1944875656(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Activity
void BSerializer_460199434(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityC
void BSerializer_1091363488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityDataC
void BSerializer_72578008(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityOption
void BSerializer_595132669(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityOptionC
void BSerializer_1364827052(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityOption[]
void BSerializer_1831677187(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityProject
void BSerializer_2121298555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityProjectC
void BSerializer_1697907147(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityProjectDataC
void BSerializer_1946995741(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityProject[]
void BSerializer_607287445(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ActivityZ
void BSerializer_730005706(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AdminModeC
void BSerializer_1820929375(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Alert
void BSerializer_280775671(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AlertC
void BSerializer_1426544289(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AlertDataC
void BSerializer_1498169909(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Any
void BSerializer_1191976387(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AnyC
void BSerializer_908393697(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Any[]
void BSerializer_1233910153(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ApplyForNotificationsInfo
void BSerializer_77743605(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ArcPath
void BSerializer_945258954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ArcPath[]
void BSerializer_1192039710(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ArchiveStatistics
void BSerializer_2056457945(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ArchiveStatisticsOptionsC
void BSerializer_276716257(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ArchivingModeC
void BSerializer_1464718703(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AutoFilingOptions
void BSerializer_225606439(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.AutoFilingResult
void BSerializer_1881161566(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXEventBusHandler_processEventBusEvents
void BSerializer_1736645961(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_executeRegisteredFunction
void BSerializer_1363890826(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_executeRegisteredFunctionString
void BSerializer_1679329575(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_getAppInfo
void BSerializer_1887140750(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_getUserNames
void BSerializer_1950460032(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_hasMethod
void BSerializer_110863678(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinActivity
void BSerializer_1027171864(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinDocEnd
void BSerializer_1920958924(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinMap
void BSerializer_1002917709(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinNotes
void BSerializer_1729896360(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinReminder
void BSerializer_2130431109(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinSord
void BSerializer_1025485545(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinUsers
void BSerializer_1723326561(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterDeleteMap
void BSerializer_40991853(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterDeleteSord
void BSerializer_1270939805(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterEndEditWorkFlowNode
void BSerializer_812031586(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterLogin
void BSerializer_1693784539(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterRefSord
void BSerializer_807852157(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterStartWorkFlow
void BSerializer_527527197(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinActivity
void BSerializer_1917517477(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinDocEnd
void BSerializer_129508967(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinMap
void BSerializer_1578945530(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinNotes
void BSerializer_1241851157(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinSord
void BSerializer_1702478812(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinUsers
void BSerializer_1235281358(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeDeleteMap
void BSerializer_393231686(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeDeleteSord
void BSerializer_694911984(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeFindSords
void BSerializer_384369013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeFindSordsInternalSQL
void BSerializer_894418660(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeLogin
void BSerializer_2101716238(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeRefSord
void BSerializer_372486646(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeStartWorkFlow
void BSerializer_1522940694(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeTakeWorkFlowNode
void BSerializer_727945599(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onCheckSordAccess
void BSerializer_1507824766(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onCreateDoc
void BSerializer_1029500828(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onCreateSord
void BSerializer_1849307166(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onFileUploadBuildResponse
void BSerializer_2105244922(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onFindClose
void BSerializer_1223837305(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onFindSordsResult
void BSerializer_127227249(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onInheritKeywording
void BSerializer_53854844(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onReadSord
void BSerializer_227337860(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_addUrlParams
void BSerializer_177992598(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_adminMode
void BSerializer_1311037156(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_alive
void BSerializer_1536711337(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_applyForNotifications
void BSerializer_1849289399(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_beginEditWorkFlowNode
void BSerializer_626823938(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_beginForwardWorkflowNode
void BSerializer_48774765(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_changeSordMask
void BSerializer_1393938400(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkLicense
void BSerializer_523346511(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinActivity
void BSerializer_1990464102(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinActivityProject
void BSerializer_310669779(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinColors
void BSerializer_1576322695(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinConfigFiles
void BSerializer_1785918050(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinConfigFilesBegin
void BSerializer_453135787(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinConfigFilesEnd
void BSerializer_1770305117(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinCounters
void BSerializer_1020556978(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinCryptInfos
void BSerializer_1795186254(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocBegin
void BSerializer_165848488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocBegin2
void BSerializer_846335882(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocDupl
void BSerializer_1795690130(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocEnd
void BSerializer_1604643226(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocMask
void BSerializer_1795441139(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocMaskLineTemplate
void BSerializer_702278853(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocsBegin
void BSerializer_2078187849(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinDocsEnd
void BSerializer_1794336151(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinKeys
void BSerializer_573935819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinKeywordList
void BSerializer_1216164720(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinKeywords
void BSerializer_125387007(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinMap
void BSerializer_1126894501(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinMapDomain
void BSerializer_1848884425(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinNoteTemplates
void BSerializer_1356325488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinNotes
void BSerializer_615204554(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinNotification
void BSerializer_1249191106(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinOrgUnits
void BSerializer_656770626(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinReminder
void BSerializer_1167138871(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinReplNames
void BSerializer_897197218(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinReport
void BSerializer_1996643915(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinReportOptions
void BSerializer_955196883(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinSord
void BSerializer_574183525(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinSordPath
void BSerializer_998405674(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinSordTypes
void BSerializer_890210068(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinStorage
void BSerializer_1212457916(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinSubs
void BSerializer_574188810(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinSubscription
void BSerializer_995161332(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinTranslateTerms
void BSerializer_366611184(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinUserProfile
void BSerializer_1903655079(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinUsers
void BSerializer_621774353(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinWorkFlow
void BSerializer_614110410(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinWorkflowTemplate
void BSerializer_847491504(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutActivity
void BSerializer_708798549(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutActivityProject
void BSerializer_1209441042(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutColors
void BSerializer_2037655284(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutConfigFiles
void BSerializer_846870983(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutCounters
void BSerializer_575147667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutCryptInfos
void BSerializer_1964025427(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutDoc
void BSerializer_753364764(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutDocMask
void BSerializer_2135358504(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutDocMaskLineTemplates
void BSerializer_550757795(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutKeys
void BSerializer_1879670928(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutKeywordList
void BSerializer_2139755509(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutKeywords
void BSerializer_1470317638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutKeywordsDynamic
void BSerializer_1951955225(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutMap
void BSerializer_753372992(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutMapDomain
void BSerializer_223879132(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutMapHistory
void BSerializer_739067188(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutNoteTemplates
void BSerializer_1837424715(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutNotes
void BSerializer_1856680027(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutNotification
void BSerializer_294879111(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutOrgUnits
void BSerializer_2042492025(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutPreviewImageURLs
void BSerializer_755346067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutReminders
void BSerializer_400637221(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutReplNames
void BSerializer_1175566339(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutReportOptions
void BSerializer_1436296110(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutSord
void BSerializer_1879918634(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutSordHistory
void BSerializer_782528246(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutSordPath
void BSerializer_1700856977(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutSordTypes
void BSerializer_1182553489(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutStorage
void BSerializer_1576625569(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutSubs
void BSerializer_1879923919(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutTranslateTerms
void BSerializer_1899181963(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutUserProfile
void BSerializer_1452265150(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutUsers
void BSerializer_1850110228(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutWorkFlow
void BSerializer_981594235(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutWorkflowHistory
void BSerializer_1555002297(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutWorkflowTemplate
void BSerializer_968696309(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_cleanupStart
void BSerializer_97888340(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_cleanupState
void BSerializer_97888387(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_cleanupStop
void BSerializer_689578544(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_closeEventBus
void BSerializer_1579680296(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_collectJobStates
void BSerializer_1479025845(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_collectMapDomains
void BSerializer_1590880889(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_collectWorkFlowNodes
void BSerializer_791411518(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_collectWorkFlows
void BSerializer_1540999264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_combineAcl
void BSerializer_1476771969(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_configureBackup
void BSerializer_251783250(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_configureFulltext
void BSerializer_655595212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_configurePurge
void BSerializer_1407134747(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_controlBackgroundThread
void BSerializer_796672607(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_controlBackup
void BSerializer_429289481(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_cookKeyword
void BSerializer_922862219(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_copySord
void BSerializer_1944880601(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createActivity
void BSerializer_806333153(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createActivityProject
void BSerializer_1769051912(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createDoc
void BSerializer_734350810(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createDocMask
void BSerializer_171070926(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createEventBusListener
void BSerializer_563568172(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createEventBusSubscriber
void BSerializer_1671043104(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createKey
void BSerializer_734344371(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createNote
void BSerializer_1289740092(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createNote2
void BSerializer_1327237138(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createNoteTemplate
void BSerializer_1517964638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createReminder
void BSerializer_1943697476(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createRsaKeys
void BSerializer_518307262(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createSord
void BSerializer_1289591200(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createSubscription
void BSerializer_1409951761(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createUser
void BSerializer_1289528163(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createWFNode
void BSerializer_2023998883(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createWorkFlow
void BSerializer_1798241359(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deferWorkFlowNode
void BSerializer_77680797(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_delegateWorkFlowNode
void BSerializer_2095741220(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteActivity
void BSerializer_2125754512(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteActivityProject
void BSerializer_1847611287(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteConfigFiles
void BSerializer_28637388(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteCounters
void BSerializer_885266568(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteDocMask
void BSerializer_1672606371(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteDocMaskLineTemplates
void BSerializer_1672428606(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteEventBusListener
void BSerializer_1871772453(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteEventBusSubscriber
void BSerializer_1276207409(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteKeys
void BSerializer_894462987(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteKeywordList
void BSerializer_1321521914(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteKeywords
void BSerializer_9903403(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteMap
void BSerializer_1691419845(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteMapDomain
void BSerializer_1747919839(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteNoteTemplates
void BSerializer_2114072954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteNotes
void BSerializer_1955485472(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteNotification
void BSerializer_109683220(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteOrgUnits
void BSerializer_792061036(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteReminders
void BSerializer_1922531104(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteReport
void BSerializer_385335563(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteSord
void BSerializer_894215281(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteSordTypes
void BSerializer_789245482(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteSubs
void BSerializer_894209996(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteSubscription
void BSerializer_363712994(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteTranslateTerms
void BSerializer_158441882(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteUserProfile
void BSerializer_634031555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteUsers
void BSerializer_1948915673(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteWorkFlow
void BSerializer_478820000(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteWorkflowTemplate
void BSerializer_1634712102(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_editPublicDownloadUrls
void BSerializer_245225739(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_encryptStringRsa
void BSerializer_1840380736(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_endEditWorkFlowNode
void BSerializer_551973808(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_evalAutoFiling
void BSerializer_1823282746(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_executeRegisteredFunction
void BSerializer_778610599(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_executeRegisteredFunctionString
void BSerializer_553270730(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_executeScript
void BSerializer_905800490(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_exportWorkflow
void BSerializer_809552457(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findActivityProjects
void BSerializer_1955899064(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findBackgroundThreads
void BSerializer_610169452(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findClose
void BSerializer_928687287(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstActivities
void BSerializer_1661199666(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstConfigFiles
void BSerializer_954269076(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstNotes
void BSerializer_299362112(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstReportInfos
void BSerializer_693111280(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstSords
void BSerializer_303977764(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstSubscriptions
void BSerializer_1290105973(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstTasks
void BSerializer_304485389(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstTranslateTerms
void BSerializer_1162113222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstUsers
void BSerializer_305931911(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstWorkflows
void BSerializer_546938477(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextActivities
void BSerializer_2116795663(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextConfigFiles
void BSerializer_2108007283(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextNotes
void BSerializer_1493835871(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextReportInfos
void BSerializer_1846849487(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextSords
void BSerializer_1498451523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextSubscriptions
void BSerializer_1930960532(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextTasks
void BSerializer_1498959148(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextTranslateTerms
void BSerializer_1524508923(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextUsers
void BSerializer_1500405670(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findNextWorkflows
void BSerializer_1653142322(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_finishExport
void BSerializer_1487849891(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_forwardWorkflowNode
void BSerializer_572079312(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getAclAccess
void BSerializer_939270158(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getArchiveStatistics
void BSerializer_538085115(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getCompiledScripts
void BSerializer_1449667401(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getConstants
void BSerializer_14637361(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getContextTerms
void BSerializer_1075096680(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getDebuggerPort
void BSerializer_1274938050(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getDistinctValuesOfObjKey
void BSerializer_1260382845(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getESWFromEditInfo
void BSerializer_1694552757(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getEditInfoFromESW
void BSerializer_835848697(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getExportZipUrl
void BSerializer_1446672866(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getImportZipUrl
void BSerializer_254632211(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getPublicDownloads
void BSerializer_1822446082(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getScriptsToDebug
void BSerializer_272016144(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getSearchTerms
void BSerializer_349631039(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getServerInfo
void BSerializer_2074326767(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getServerInfoDM
void BSerializer_563195558(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getSessionFromTicket
void BSerializer_147146740(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getSessionInfos
void BSerializer_1406789391(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getSessionOptions
void BSerializer_109969832(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getUserNames
void BSerializer_730904509(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getWebDAVPathFromObjID
void BSerializer_1491154434(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getWebDAVPathFromObjID2
void BSerializer_1018852852(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getWorkflowTemplateVersions
void BSerializer_775523732(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_importWorkFlow
void BSerializer_2013797722(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_importWorkFlow2
void BSerializer_1996780008(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_insertPublicDownload
void BSerializer_1596476256(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_internalReceiveEvents
void BSerializer_1518401879(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_invalidateCache
void BSerializer_767982831(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_invalidateCache2
void BSerializer_1962336065(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_linkSords
void BSerializer_1326760021(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_linkSords2
void BSerializer_1820112259(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_lockArchive
void BSerializer_2083874271(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_login
void BSerializer_1526465549(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_loginAdmin
void BSerializer_139618532(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_loginEloProf
void BSerializer_1544232786(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_loginKerberos
void BSerializer_575080338(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_logout
void BSerializer_75785664(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_moveDocuments
void BSerializer_1730554767(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_notifyServer
void BSerializer_1873214498(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_openEventBus
void BSerializer_1111320026(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_parseException
void BSerializer_218602898(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_processFindResult
void BSerializer_255834993(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_processOcr
void BSerializer_2058356197(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_processTrees
void BSerializer_1894562916(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_provideCryptPassword
void BSerializer_515214142(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_queryJobProtocol
void BSerializer_1653875517(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_queryJobState
void BSerializer_221322822(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_refSord
void BSerializer_1607355701(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_registerOcrWorker
void BSerializer_318217117(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_reload
void BSerializer_86902351(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_reloadScripts
void BSerializer_1767312455(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_resolveRights
void BSerializer_262295187(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_restoreSord
void BSerializer_487898554(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_sendEvents
void BSerializer_1721831543(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_setScriptsToDebug
void BSerializer_1212168964(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_setServerInfo
void BSerializer_1300195555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_setServerInfoDM
void BSerializer_347556966(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_setSessionOptions
void BSerializer_830182988(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startAdHocWorkFlow
void BSerializer_1995358580(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startAdHocWorkFlow2
void BSerializer_1726573786(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startAdHocWorkFlow3
void BSerializer_1726573785(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startExport
void BSerializer_1213820864(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startExportExt
void BSerializer_1607764545(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startImport
void BSerializer_1318178737(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startWorkFlow
void BSerializer_211211499(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_takeWorkFlowNode
void BSerializer_1305676322(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_terminatePublicDownloadUrls
void BSerializer_158007264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_terminateWorkFlow
void BSerializer_1986005738(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_testAdapter
void BSerializer_1934035815(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_unlinkSords
void BSerializer_1910068060(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1
void BSerializer_139578694(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_10
void BSerializer_31972170(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1001617329
void BSerializer_1737934677(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_100361105
void BSerializer_1083146178(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1005790586
void BSerializer_1028792992(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1034263904
void BSerializer_928929669(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1047127860
void BSerializer_1007078901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1057373949
void BSerializer_1483320409(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_105830886
void BSerializer_1366049664(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1078168929
void BSerializer_1463196284(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1088095067
void BSerializer_253657563(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1107316733
void BSerializer_874621629(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1112009864
void BSerializer_1906806987(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1132956238
void BSerializer_1840998419(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1143177929
void BSerializer_50804539(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1153931872
void BSerializer_1917165361(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1191976387
void BSerializer_1472696983(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1197100286
void BSerializer_678319756(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1233469422
void BSerializer_778916661(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1264954948
void BSerializer_1553005093(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1301335819
void BSerializer_526443365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1320348587
void BSerializer_1169396716(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_133130047
void BSerializer_324094143(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1376733713
void BSerializer_98220986(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1383534582
void BSerializer_878709939(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1401065069
void BSerializer_1364135521(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1425760760
void BSerializer_1576794397(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1426941339
void BSerializer_1775232095(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1436376940
void BSerializer_201271360(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1443841819
void BSerializer_980746876(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_148564345
void BSerializer_1968102497(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1485735592
void BSerializer_853868916(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1495731174
void BSerializer_888818351(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_15
void BSerializer_31972165(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1535847981
void BSerializer_1539142900(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1537059480
void BSerializer_1208871945(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1552114559
void BSerializer_2135982691(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1556767716
void BSerializer_1590515712(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1576340510
void BSerializer_664594975(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1585309177
void BSerializer_1516472013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1663767661
void BSerializer_1136640270(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1698110251
void BSerializer_237230375(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1699606509
void BSerializer_792677022(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1701141707
void BSerializer_1830105166(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1701204890
void BSerializer_1855130839(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1712381166
void BSerializer_226398691(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1737266313
void BSerializer_470722300(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1754570852
void BSerializer_439024483(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1756288553
void BSerializer_2129303359(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1768472140
void BSerializer_1408305917(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1788243283
void BSerializer_538961305(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_18214274
void BSerializer_124408536(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1822579866
void BSerializer_218334399(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1826370901
void BSerializer_584143824(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1835331414
void BSerializer_267493766(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1870182600
void BSerializer_1546359614(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1881161566
void BSerializer_1082076800(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1888107655
void BSerializer_1300693476(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_19
void BSerializer_31972161(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1963952629
void BSerializer_2087116643(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_1995912373
void BSerializer_496923600(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_200528028
void BSerializer_670536426(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2006133032
void BSerializer_1542551545(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2011132580
void BSerializer_1152181358(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2015686193
void BSerializer_1749255216(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2054753789
void BSerializer_65290103(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2056457945
void BSerializer_1754530970(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_206201524
void BSerializer_271580133(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2062827124
void BSerializer_59064871(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_21
void BSerializer_31972138(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_2121298555
void BSerializer_1182476551(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_222450704
void BSerializer_269034055(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_231031238
void BSerializer_1008002146(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_239574905
void BSerializer_334967155(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_256674679
void BSerializer_516768961(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_276702696
void BSerializer_270472684(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_323351719
void BSerializer_679516051(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_333475674
void BSerializer_1093888861(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_341056676
void BSerializer_945357981(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_42339713
void BSerializer_58447221(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_460199434
void BSerializer_1768431067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_491352407
void BSerializer_652213248(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_494610451
void BSerializer_2092431731(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_498630295
void BSerializer_1349324407(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_5
void BSerializer_139578690(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_52201250
void BSerializer_1769614830(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_545905411
void BSerializer_1133476629(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_6
void BSerializer_139578689(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_607287445
void BSerializer_1768200726(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_63967077
void BSerializer_311083626(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_661820173
void BSerializer_765305647(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_730157667
void BSerializer_296180383(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_736351635
void BSerializer_790953868(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_755261279
void BSerializer_933605785(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_776454091
void BSerializer_799026444(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_77743605
void BSerializer_1249722428(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_777531606
void BSerializer_115175465(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_784089396
void BSerializer_942817669(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_785380175
void BSerializer_30303361(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_809229049
void BSerializer_681379622(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_810727301
void BSerializer_1125286952(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_820228328
void BSerializer_474407488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_881442092
void BSerializer_1007204783(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_884364631
void BSerializer_1628589312(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_888671717
void BSerializer_970359246(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_892356058
void BSerializer_1595522649(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_893011331
void BSerializer_1901668644(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_907729609
void BSerializer_1537036490(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_910482075
void BSerializer_1281727937(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_937420667
void BSerializer_1910622485(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BResult_998509414
void BSerializer_870856762(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BStub_IXEventBusHandler
void BSerializer_627994447(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BStub_IXServerEvents
void BSerializer_1938363825(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BStub_IXServicePortIF
void BSerializer_1795705954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BackupProfile
void BSerializer_1230334315(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BackupProfile[]
void BSerializer_1233469422(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BackupPurgeStatus
void BSerializer_52201250(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BackupStatus
void BSerializer_1288074907(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.BeginForwardWorkflowNodeInfo
void BSerializer_823426303(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Bitset
void BSerializer_1084624222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckAccessOptions
void BSerializer_2061147439(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckInDocMaskLineTemplateOptions
void BSerializer_1586163042(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckinDocOptions
void BSerializer_1433031299(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckinOrgUnitInfo
void BSerializer_740959052(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckinReportInfo
void BSerializer_279483092(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckinUsersC
void BSerializer_1602486374(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckinUsersZ
void BSerializer_403687865(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckoutOrgUnitInfo
void BSerializer_948431844(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckoutSordPathInfo
void BSerializer_730679282(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckoutUsersC
void BSerializer_531758278(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckoutUsersZ
void BSerializer_1897433533(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckoutWorkflowHistoryParams
void BSerializer_299426984(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CheckoutWorkflowHistoryResult
void BSerializer_1754570852(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ClientInfo
void BSerializer_1258190913(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ClientInfoC
void BSerializer_847449421(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ColorData
void BSerializer_1735048729(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ColorDataC
void BSerializer_881975137(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ColorDataInternC
void BSerializer_1208511866(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ColorData[]
void BSerializer_1870182600(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CombineAclOptions
void BSerializer_66519402(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CombineAclResult
void BSerializer_1034263904(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ConfigFile
void BSerializer_582012382(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ConfigFileC
void BSerializer_2098566124(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ConfigFileZ
void BSerializer_821574897(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ConfigFile[]
void BSerializer_1737266313(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ContextTerm
void BSerializer_1464223403(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ContextTerm[]
void BSerializer_1005790586(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ControlBackupInfo
void BSerializer_1738666671(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ControlBackupInfoC
void BSerializer_1165618755(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CopyInfo
void BSerializer_2138439536(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CopyOptions
void BSerializer_1427182574(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CopyResult
void BSerializer_1904597264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CopySordC
void BSerializer_1616091412(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CopySordZ
void BSerializer_2059126408(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CountResult
void BSerializer_1581335066(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CounterInfo
void BSerializer_1809378891(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CounterInfoC
void BSerializer_1843901056(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CounterInfo[]
void BSerializer_1698110251(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CryptInfo
void BSerializer_1826259804(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.CryptInfo[]
void BSerializer_809229049(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DeleteActivityOptions
void BSerializer_78913228(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DeleteOptions
void BSerializer_329713511(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DeleteOrgUnitInfo
void BSerializer_537993523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocHistory
void BSerializer_189452795(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocHistoryC
void BSerializer_1456349355(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocInfoDM
void BSerializer_673204378(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocInfoDMC
void BSerializer_1042422760(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMask
void BSerializer_2054753789(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskC
void BSerializer_387842089(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskDataC
void BSerializer_1968969939(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskDetails
void BSerializer_639048562(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLine
void BSerializer_1291500689(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineC
void BSerializer_1453574806(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineDataC
void BSerializer_1178569423(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineTemplate
void BSerializer_117741089(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineTemplateC
void BSerializer_984407269(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineTemplateDataC
void BSerializer_96404005(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineTemplateZ
void BSerializer_1687510263(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLineTemplate[]
void BSerializer_1107316733(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskLine[]
void BSerializer_745804061(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocMaskZ
void BSerializer_1064616030(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocVersion
void BSerializer_633004623(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocVersionC
void BSerializer_615288749(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.DocVersion[]
void BSerializer_807293031(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Document
void BSerializer_341056676(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Document[]
void BSerializer_1047127860(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EditInfo
void BSerializer_820228328(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EditInfoC
void BSerializer_2100880359(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EditInfoEswOptions
void BSerializer_522299581(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EditInfoZ
void BSerializer_878901868(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EditInfo[]
void BSerializer_785380175(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloDmOpt
void BSerializer_353149300(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloDmOptC
void BSerializer_605470240(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloDmOptDataC
void BSerializer_1218961099(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloFtOpt
void BSerializer_181406923(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloFtOptC
void BSerializer_1603857234(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloFtOptDataC
void BSerializer_1220982870(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloFtStop
void BSerializer_2135577346(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloFtStopC
void BSerializer_1842033553(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloIxOpt
void BSerializer_1454054253(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloIxOptC
void BSerializer_149956656(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloIxOptDataC
void BSerializer_1223860309(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloIxOpt_old
void BSerializer_399031267(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EloIxOpt_oldC
void BSerializer_1148546611(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Event
void BSerializer_877454055(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EventBusC
void BSerializer_572745886(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EventBusParams
void BSerializer_1489333610(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EventFilter
void BSerializer_1095275943(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EventFilter[]
void BSerializer_722503869(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.EventListener
void BSerializer_1005733106(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Event[]
void BSerializer_910482075(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ExecuteScriptParams
void BSerializer_936440117(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ExecuteScriptResult
void BSerializer_63967077(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ExportExtOptions
void BSerializer_291967(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ExportExtOptionsC
void BSerializer_162646972(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ExportOptionsC
void BSerializer_2043834611(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FileData
void BSerializer_888671717(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FileDataC
void BSerializer_1011013570(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FileDataZ
void BSerializer_686143141(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FileData[]
void BSerializer_1078168929(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindActivityInfo
void BSerializer_1456865464(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindActivityProjectsInfo
void BSerializer_151574948(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindAlertInfo
void BSerializer_897433042(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindBackgroundThreadOptions
void BSerializer_1054287589(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByAcl
void BSerializer_1535514212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByFulltext
void BSerializer_829543678(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByFulltextCtrl
void BSerializer_96165507(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByFulltextCtrlResultItem
void BSerializer_1755682788(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByFulltextCtrlResultItem[]
void BSerializer_1980589728(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByFulltextResultItem
void BSerializer_709720021(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByFulltextResultItem[]
void BSerializer_804274709(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByIndex
void BSerializer_1985205034(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByNotes
void BSerializer_735083434(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByPreviewCtrl
void BSerializer_78436038(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByRegisteredFunction
void BSerializer_700871698(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindBySordHist
void BSerializer_2098788325(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByType
void BSerializer_151307616(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindByVersion
void BSerializer_925953882(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindChildren
void BSerializer_752202075(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindConfigFileInfo
void BSerializer_1887106523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindDirect
void BSerializer_1028007046(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindDirectC
void BSerializer_627433249(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindInfo
void BSerializer_1017838205(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindInfoAsInternalSQL
void BSerializer_2003160309(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindLinks
void BSerializer_832548178(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindOptions
void BSerializer_1371440255(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindReportInfo
void BSerializer_504724737(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindResult
void BSerializer_1301335819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindSubscriptionInfo
void BSerializer_1419135016(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindTasksInfo
void BSerializer_1489194452(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindTranslateTermInfo
void BSerializer_986701599(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindUserInfo
void BSerializer_1847547446(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FindWorkflowInfo
void BSerializer_1768797010(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FontInfo
void BSerializer_1478273890(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ForwardWorkflowNodeInfo
void BSerializer_523867474(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ForwardWorkflowNodeResult
void BSerializer_1699606509(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FulltextConfig
void BSerializer_239574905(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.FulltextConfigC
void BSerializer_2025824562(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.GetWebDAVPathOptions
void BSerializer_1410517836(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.GetWebDAVPathResult
void BSerializer_148564345(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.HttpRequestInfo
void BSerializer_1892343155(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.HttpResponseInfo
void BSerializer_1552189905(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IXExceptionC
void BSerializer_1204588365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IXExceptionData
void BSerializer_784089396(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IXServerEventsC
void BSerializer_1963572851(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IXServerEventsContext
void BSerializer_956691491(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IXServicePortC
void BSerializer_1264954948(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IdName
void BSerializer_381683845(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IdName[]
void BSerializer_755261279(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ImportOptionsC
void BSerializer_1908370444(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IndexServerForArchive
void BSerializer_145656220(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.IndexServerForArchive[]
void BSerializer_1712744473(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.InvalidateCacheC
void BSerializer_320503229(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.InvalidateCacheInfo
void BSerializer_1441686860(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.InvalidateCacheInfoParam
void BSerializer_102205772(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.InvalidateCacheResult
void BSerializer_1712381166(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.JobState
void BSerializer_1436376940(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.JobState[]
void BSerializer_1788243283(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeyInfo
void BSerializer_1537059480(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeyInfo[]
void BSerializer_1112009864(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeyValue
void BSerializer_516301248(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeyValue[]
void BSerializer_1826370901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Keyword
void BSerializer_1426243550(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeywordC
void BSerializer_1338796818(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeywordList
void BSerializer_1495731174(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeywordListC
void BSerializer_1333073168(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeywordZ
void BSerializer_450335637(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Keyword[]
void BSerializer_206201524(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeywordsDynamicInfo
void BSerializer_2008405893(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.KeywordsDynamicResult
void BSerializer_1552114559(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.License
void BSerializer_1330120264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LicenseInfo
void BSerializer_2024296158(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LicenseResult
void BSerializer_545905411(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LinkSordC
void BSerializer_4981037(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LinkSordInfo
void BSerializer_1427691295(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LinkSordZ
void BSerializer_1473512051(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LockC
void BSerializer_837669511(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LockZ
void BSerializer_1407753312(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LoginResult
void BSerializer_777531606(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LoginScriptOptions
void BSerializer_1536364115(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.LoginScriptOptionsC
void BSerializer_1002222217(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapData
void BSerializer_2011132580(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapDataC
void BSerializer_1277095765(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapDomain
void BSerializer_42339713(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapDomainC
void BSerializer_47433043(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapDomainDataC
void BSerializer_915355095(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapDomain[]
void BSerializer_1963952629(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHead
void BSerializer_1379783697(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHeadC
void BSerializer_812078539(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHist
void BSerializer_303505086(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHistC
void BSerializer_379654790(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHistHeadC
void BSerializer_812099209(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHistItem
void BSerializer_342049067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHistItemC
void BSerializer_1314989638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHistItem[]
void BSerializer_240257308(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHistZ
void BSerializer_1505340976(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapHist[]
void BSerializer_1756288553(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapItem
void BSerializer_1461301521(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapItemC
void BSerializer_812006040(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MapValue
void BSerializer_408347242(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MaskName
void BSerializer_458953805(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MaskName[]
void BSerializer_248117584(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.MoveDocumentsInfo
void BSerializer_2016315141(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NavigationInfo
void BSerializer_1953181452(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NavigationInfoC
void BSerializer_1520348158(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Note
void BSerializer_937420667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteC
void BSerializer_1319955249(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteDataC
void BSerializer_1521483547(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteFreehand
void BSerializer_611837980(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteFreehandC
void BSerializer_1034219603(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteImage
void BSerializer_1753613701(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteTemplate
void BSerializer_1995912373(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteTemplateC
void BSerializer_240897408(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteTemplateDataC
void BSerializer_1775437403(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteTemplateZ
void BSerializer_1483878971(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteTemplate[]
void BSerializer_1443841819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteText
void BSerializer_669464920(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NoteZ
void BSerializer_2137405429(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Note[]
void BSerializer_776454091(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Notification
void BSerializer_494610451(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NotificationC
void BSerializer_1070921523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NotificationDataC
void BSerializer_2010056196(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NotificationZ
void BSerializer_1624160439(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NotifyServerInfo
void BSerializer_539899885(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.NotifyServerResult
void BSerializer_810727301(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjChange
void BSerializer_753146(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjChangeC
void BSerializer_1100272528(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjDataC
void BSerializer_1521332903(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjHistC
void BSerializer_1015803641(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjHistKeyC
void BSerializer_1013854536(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjKey
void BSerializer_237417996(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjKeyC
void BSerializer_711473895(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjKeyData
void BSerializer_1508164560(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjKeyDataC
void BSerializer_2463451(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjKey[]
void BSerializer_1628260993(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ObjLinkC
void BSerializer_1015668161(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrInfo
void BSerializer_1803060225(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrInfoC
void BSerializer_1068350778(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrInfoQueryLanguages
void BSerializer_648095775(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrInfoRecognizeFile
void BSerializer_701419851(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrRect
void BSerializer_1044855049(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrRect[]
void BSerializer_610838867(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrResult
void BSerializer_998509414(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrResultQueryLanguages
void BSerializer_916614291(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrResultRecognizeFile
void BSerializer_1533562699(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrWorker
void BSerializer_730157667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OcrWorkerC
void BSerializer_45899817(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OrgUnitInfo
void BSerializer_413918850(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OrgUnitInfoC
void BSerializer_864257789(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OrgUnitInfo[]
void BSerializer_1879760993(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.OrgUnitName
void BSerializer_427676481(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PhysDel
void BSerializer_124345500(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PhysDelC
void BSerializer_278631137(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PhysDelDataC
void BSerializer_448931954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PhysDelDocs
void BSerializer_855528761(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PhysDelDocsC
void BSerializer_434896477(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PointInfo
void BSerializer_1225068828(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PointInfo[]
void BSerializer_1853594537(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PreviewImageInfo
void BSerializer_1006046685(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PreviewImageInfoC
void BSerializer_407268655(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PreviewImageResult
void BSerializer_661820173(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessAcl
void BSerializer_402225782(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessCopyElements
void BSerializer_147051188(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessCountElements
void BSerializer_1130489422(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessFulltext
void BSerializer_1125907212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessInfo
void BSerializer_1037318967(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessInfoC
void BSerializer_659513392(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessInheritKeywording
void BSerializer_1130489423(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessMoveDocumentsToStoragePath
void BSerializer_3376635(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessReleaseLock
void BSerializer_1270934212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessReplSet
void BSerializer_712209598(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ProcessScript
void BSerializer_1122555546(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PublicDownload
void BSerializer_2062827124(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PublicDownloadC
void BSerializer_1919187163(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PublicDownloadDataC
void BSerializer_1639180602(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PublicDownloadOptions
void BSerializer_252853324(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PurgeSettings
void BSerializer_1576340510(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PurgeSettingsC
void BSerializer_1865968564(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.PurgeStatus
void BSerializer_2053888643(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.QueryJobProtocolC
void BSerializer_1764906979(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.QueryJobProtocolEvent
void BSerializer_892520690(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.QueryJobProtocolEvent[]
void BSerializer_1465721064(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.QueryJobProtocolInfo
void BSerializer_1362638222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.QueryJobProtocolResult
void BSerializer_222450704(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Relation
void BSerializer_837810375(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.RelationC
void BSerializer_1203469035(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Reminder
void BSerializer_256674679(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReminderC
void BSerializer_1431555044(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReminderDataC
void BSerializer_1099169893(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Reminder[]
void BSerializer_1701141707(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplCode
void BSerializer_1235558040(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplSet
void BSerializer_1124529321(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplSetCombination
void BSerializer_2078338937(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplSetCombinationC
void BSerializer_897151349(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplSetName
void BSerializer_755067340(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplSetNameC
void BSerializer_969246601(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReplSetName[]
void BSerializer_884364631(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.RepliHist
void BSerializer_899503054(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.RepliHistC
void BSerializer_104551413(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportC
void BSerializer_1285453013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportErpCode
void BSerializer_508806040(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportErpCode[]
void BSerializer_1004870809(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportInfo
void BSerializer_1280848136(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportInfoC
void BSerializer_1071192839(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportInfoUserModified
void BSerializer_1649121955(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportInfoUserProps
void BSerializer_2088129978(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportInfo[]
void BSerializer_1243223397(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportModeC
void BSerializer_1594659914(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportModeZ
void BSerializer_1248158950(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportOptions
void BSerializer_1057373949(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ReportOptionsC
void BSerializer_2081332891(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ResolveRightsInfo
void BSerializer_1631708942(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ResolveRightsResult
void BSerializer_973279163(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ResolveRightsResultC
void BSerializer_1322441656(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.RestoreOptions
void BSerializer_378110234(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SearchModeC
void BSerializer_1758444419(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SearchModeZ
void BSerializer_424689505(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SearchTermsC
void BSerializer_334358315(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ServerInfo
void BSerializer_1701204890(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ServerInfoDM
void BSerializer_1425760760(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ServerInfoDMC
void BSerializer_287365821(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ServerState
void BSerializer_1076606418(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ServerStateC
void BSerializer_1862501863(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SessionInfo
void BSerializer_866689803(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SessionInfoParams
void BSerializer_2013576169(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SessionInfo[]
void BSerializer_1376733713(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SessionOptions
void BSerializer_1197100286(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SessionOptionsC
void BSerializer_2000345779(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Sord
void BSerializer_1576327931(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordC
void BSerializer_1553100003(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordDetails
void BSerializer_1713693326(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordHist
void BSerializer_2121567102(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordHistC
void BSerializer_520610723(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordHistKey
void BSerializer_251810638(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordHistKeyC
void BSerializer_762601968(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordHistKey[]
void BSerializer_645430982(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordHist[]
void BSerializer_491352407(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordLink
void BSerializer_200815802(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordLinkC
void BSerializer_1347988541(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordLink[]
void BSerializer_376993407(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordPath
void BSerializer_544862901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordPaths
void BSerializer_1835331414(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordType
void BSerializer_2065094749(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordTypeC
void BSerializer_635922924(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordTypeZ
void BSerializer_314474107(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordType[]
void BSerializer_133130047(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordZ
void BSerializer_1441094282(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SordZ[]
void BSerializer_1559053609(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Sord[]
void BSerializer_919539303(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SortOrderC
void BSerializer_1551556842(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.StartAdHocWorkflowInfo
void BSerializer_1587514612(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.StoreInfo
void BSerializer_964052256(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.StoreInfoC
void BSerializer_979653235(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.StoreInfo[]
void BSerializer_231031238(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SubsInfo
void BSerializer_1910142939(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SubsInfo[]
void BSerializer_105830886(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Subscription
void BSerializer_323351719(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SubscriptionC
void BSerializer_1994646365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SubscriptionDataC
void BSerializer_1152087606(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.SubscriptionZ
void BSerializer_1493215896(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.Thesaurus
void BSerializer_1664944753(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ThesaurusC
void BSerializer_670698541(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.TranslateTerm
void BSerializer_356302605(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.TranslateTermC
void BSerializer_1212336284(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.TranslateTermData
void BSerializer_486835904(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.TranslateTermDataC
void BSerializer_1699470707(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.TranslateTerm[]
void BSerializer_1088095067(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UrlParams
void BSerializer_2007960901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserInfo
void BSerializer_1485735592(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserInfoC
void BSerializer_703234555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserInfo[]
void BSerializer_1132956238(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserName
void BSerializer_123879203(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserName[]
void BSerializer_1001617329(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserNodeInfo
void BSerializer_2059835971(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserNodeInfo[]
void BSerializer_1772247724(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserProfile
void BSerializer_1401065069(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserProfileC
void BSerializer_1968434410(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserProfileData
void BSerializer_2015395180(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserProfileDataC
void BSerializer_466121473(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserTask
void BSerializer_1484696239(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserTaskPriorityC
void BSerializer_260320342(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserTaskSortOrderC
void BSerializer_854117900(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserTaskSortOrderZ
void BSerializer_1199296467(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.UserTask[]
void BSerializer_829657911(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ValueClass
void BSerializer_175726414(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ValuesOfObjKey
void BSerializer_1153931872(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.ValuesOfObjKeyOptions
void BSerializer_958310068(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.VtDoc
void BSerializer_1935852595(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.VtDocC
void BSerializer_1585149555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFCollectNode
void BSerializer_1492908819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFCollectNode[]
void BSerializer_2006133032(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFDelegateNodeInfo
void BSerializer_20892334(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFDiagram
void BSerializer_1663767661(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFDiagramC
void BSerializer_1231341428(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFDiagramZ
void BSerializer_1717407429(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFDiagram[]
void BSerializer_838894319(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFEditNode
void BSerializer_1822579866(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNode
void BSerializer_2015686193(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeAssoc
void BSerializer_1042649178(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeAssoc[]
void BSerializer_715244239(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeC
void BSerializer_1514069164(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeHistory
void BSerializer_784568809(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeHistoryC
void BSerializer_1457412372(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeMatrix
void BSerializer_425879495(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeMatrixC
void BSerializer_171864975(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNodeZ
void BSerializer_226200225(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFNode[]
void BSerializer_1457843286(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFTakeNodeC
void BSerializer_1164251184(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFTimeLimit
void BSerializer_633363356(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFTimeLimit[]
void BSerializer_1495941578(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFTypeC
void BSerializer_1842783874(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFTypeZ
void BSerializer_927083544(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFVersion
void BSerializer_914434915(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFVersionC
void BSerializer_1378592156(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WFVersion[]
void BSerializer_1768472140(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkFlowActiveDoc
void BSerializer_1807635378(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkFlowActiveDocC
void BSerializer_509854692(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkFlowHead
void BSerializer_37271022(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkFlowHeadC
void BSerializer_807993720(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkFlowNodeMatrix
void BSerializer_1337377725(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkFlowNodeMatrixC
void BSerializer_813423307(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkflowExchangeInfo
void BSerializer_2070549585(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkflowExportOptions
void BSerializer_402835780(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkflowExportOptionsC
void BSerializer_1063132081(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkflowImportOptions
void BSerializer_449037977(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.WorkflowNodeInfo
void BSerializer_1659862348(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.compatibility.BRequest_RawStreamService_download
void BSerializer_280725475(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.compatibility.BRequest_RawStreamService_upload
void BSerializer_527524138(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.compatibility.BRequest_WClientService_onAfterVersionChanged
void BSerializer_2095806986(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.compatibility.BStub_RawStreamService
void BSerializer_354585327(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.compatibility.BStub_WClientService
void BSerializer_1887299447(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.compatibility.WClientC
void BSerializer_1800529481(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.Action
void BSerializer_736351635(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.ActionC
void BSerializer_1988394652(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.ActionDataC
void BSerializer_423487901(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.ActionHistDataC
void BSerializer_734763371(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.ActionHistory
void BSerializer_598833764(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.ActionHistoryC
void BSerializer_442981425(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.ActionZ
void BSerializer_1006784044(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.Action[]
void BSerializer_433625553(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedNotification_updateAction
void BSerializer_688797212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_checkinAction
void BSerializer_1138765790(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_checkoutAction
void BSerializer_1737190301(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_checkoutHashTag
void BSerializer_122354907(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_createAction
void BSerializer_643943187(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_createHashTagSubscription
void BSerializer_1471082196(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findFirstActions
void BSerializer_334710983(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findFirstHashTagRelation
void BSerializer_2144547950(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findFirstNotification
void BSerializer_906090337(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findHashTagByActions
void BSerializer_421489164(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findHashTags
void BSerializer_66310175(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findNextActions
void BSerializer_933597872(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findNextHashTagRelation
void BSerializer_1204755579(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findNextNotification
void BSerializer_1326557416(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_internalInsertSystemAction
void BSerializer_1637137212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_registerNotify
void BSerializer_458959949(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_unregisterNotify
void BSerializer_285270298(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BStub_FeedNotification
void BSerializer_320199695(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.BStub_FeedService
void BSerializer_1670701039(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.Feed
void BSerializer_556531185(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FeedC
void BSerializer_1754071588(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FeedDataC
void BSerializer_1837685365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FeedZ
void BSerializer_126672288(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FindActionsInfo
void BSerializer_1747180074(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FindActionsInfoC
void BSerializer_815857210(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FindHashTagInfo
void BSerializer_256103952(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.FindNotificationInfo
void BSerializer_432579435(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTag
void BSerializer_1143177929(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagC
void BSerializer_250741620(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagDataC
void BSerializer_513648569(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagRelation
void BSerializer_1313473584(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagRelationC
void BSerializer_747134350(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagRelationDataC
void BSerializer_2035445347(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagRelationZ
void BSerializer_509234307(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.feed.HashTagZ
void BSerializer_1664941037(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_computeDoubleValue
void BSerializer_1919177848(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_read
void BSerializer_771256331(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_update
void BSerializer_1948144488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_updateAll
void BSerializer_720562919(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_updateDoubleValue
void BSerializer_677413784(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_updateMeanValue
void BSerializer_1150533084(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_uploadAll
void BSerializer_1827236639(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.BStub_HealthCheckService
void BSerializer_969424915(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.HealthCheckInfo
void BSerializer_585951890(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.HealthCheckInfoC
void BSerializer_526645641(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.HealthCheckInfos
void BSerializer_333475674(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.health.HealthCheckValueNameC
void BSerializer_2106201675(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.myelo.BRequest_MyELOService_checkState
void BSerializer_2068722874(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.myelo.BRequest_MyELOService_readContent
void BSerializer_261913914(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.myelo.BStub_MyELOService
void BSerializer_1063633807(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.myelo.MyELOContent
void BSerializer_1585309177(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.myelo.MyELOInfo
void BSerializer_455864090(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.myelo.MyELOState
void BSerializer_1426941339(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.notify.BRequest_ClientNotification_adminMode
void BSerializer_475567923(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.notify.BRequest_ClientNotification_updateTask
void BSerializer_1469990419(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.notify.BStub_ClientNotification
void BSerializer_2104055021(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.search.LanguageConfig
void BSerializer_2005992013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.search.OptimizerConfig
void BSerializer_645566676(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.search.ReindexerConfig
void BSerializer_1470978622(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.search.SearchIndexerConfig
void BSerializer_1425319615(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.search.UpdaterConfig
void BSerializer_1275243126(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.ArchivReport
void BSerializer_1383534582(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.ArchivValue
void BSerializer_1695870218(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.BRequest_SystemInformation_archivReport
void BSerializer_1995041693(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.BRequest_SystemInformation_countDocsInStorePath
void BSerializer_1786633213(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.BRequest_SystemInformation_licenseReport
void BSerializer_821360905(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.BRequest_SystemInformation_userReport
void BSerializer_2081672491(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.BStub_SystemInformation
void BSerializer_708455930(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.LicenseCounter
void BSerializer_189487184(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.LicenseReport
void BSerializer_1320348587(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.SystemInfo
void BSerializer_2061316528(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.SystemReport
void BSerializer_276702696(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for de.elo.ix.client.system.UserReport
void BSerializer_18214274(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for int[]
void BSerializer_100361105(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.lang.String[]
void BSerializer_1888107655(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.ArrayList<de.elo.ix.client.WFDiagram>
void BSerializer_2063419988(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.ArrayList<de.elo.ix.client.WFNodeHistory>
void BSerializer_1549980077(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.HashMap<java.lang.Integer,java.lang.Integer>
void BSerializer_1434022628(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.HashMap<java.lang.String,de.elo.ix.client.feed.HashTag>
void BSerializer_1556767716(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.HashSet<de.elo.ix.client.feed.HashTag>
void BSerializer_1535847981(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.InvalidateCacheInfoParam>
void BSerializer_189813709(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.Note>
void BSerializer_2111020589(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.PublicDownload>
void BSerializer_881442092(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.ResolveRightsResult>
void BSerializer_907729609(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.Sord>
void BSerializer_2106404937(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.SordPath>
void BSerializer_1773247378(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.SubsInfo>
void BSerializer_1546602844(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.ValueClass>
void BSerializer_1241863010(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.feed.ActionHistory>
void BSerializer_1399835671(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.feed.EActionType>
void BSerializer_1644858720(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.feed.HashTagRelation>
void BSerializer_1403472717(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.health.HealthCheckInfo>
void BSerializer_1270538819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.system.ArchivValue>
void BSerializer_164573046(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<de.elo.ix.client.system.LicenseCounter>
void BSerializer_2005491011(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<java.lang.Integer>
void BSerializer_181681714(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<java.lang.String>
void BSerializer_2123584667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<java.util.List<java.lang.String>>
void BSerializer_1489667803(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.List<java.util.Map<java.lang.String,java.lang.String>>
void BSerializer_1319324274(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,de.elo.ix.client.OrgUnitInfo>
void BSerializer_893011331(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,de.elo.ix.client.UserInfo>
void BSerializer_1870226832(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,de.elo.ix.client.UserName>
void BSerializer_1874463571(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,de.elo.ix.client.WFDiagram>
void BSerializer_1085717935(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,java.lang.Integer>
void BSerializer_1347703734(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,java.lang.String>
void BSerializer_498630295(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,java.util.ArrayList<de.elo.ix.client.WFDiagram>>
void BSerializer_1741591604(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.Integer,java.util.ArrayList<de.elo.ix.client.WFNodeHistory>>
void BSerializer_689498285(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.MapValue>
void BSerializer_1129834343(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.Notification>
void BSerializer_1147263971(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.Subscription>
void BSerializer_1862275569(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.feed.Feed>
void BSerializer_425536672(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.feed.HashTag>
void BSerializer_1239602222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);
// Serializer for java.util.Map<java.lang.String,java.lang.String>
void BSerializer_1710660846(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase);

}}}}


#endif

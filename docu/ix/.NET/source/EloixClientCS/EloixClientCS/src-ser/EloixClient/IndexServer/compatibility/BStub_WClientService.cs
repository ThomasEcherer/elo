using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public class BStub_WClientService : BStub, WClientServiceAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 1887299447L;
		
		public BStub_WClientService(BTransport transport)
			: base(transport) {}			
		
		public virtual void onAfterVersionChanged(int objId, int docId, int flags) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterVersionChanged(objId, docId, flags, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterVersionChanged(int objId, int docId, int flags, BAsyncResult<Object> asyncResult) {
			BRequest_WClientService_onAfterVersionChanged req = new BRequest_WClientService_onAfterVersionChanged();			
			req.objIdValue = objId;
			req.docIdValue = docId;
			req.flagsValue = flags;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}

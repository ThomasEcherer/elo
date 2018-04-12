using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BStub_MyELOService : BStub, MyELOServiceAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 1063633807L;
		
		public BStub_MyELOService(BTransport transport)
			: base(transport) {}			
		
		public virtual EloixClient.IndexServer.myelo.MyELOState checkState(String userGuidOrID, String sinceDateIso) {
			BSyncResult<EloixClient.IndexServer.myelo.MyELOState> asyncResult = new BSyncResult<EloixClient.IndexServer.myelo.MyELOState>();			
			checkState(userGuidOrID, sinceDateIso, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.myelo.MyELOState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkState(String userGuidOrID, String sinceDateIso, BAsyncResult<EloixClient.IndexServer.myelo.MyELOState> asyncResult) {
			BRequest_MyELOService_checkState req = new BRequest_MyELOService_checkState();			
			req.userGuidOrIDValue = userGuidOrID;
			req.sinceDateIsoValue = sinceDateIso;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.myelo.MyELOContent readContent(EloixClient.IndexServer.myelo.MyELOState state, EloixClient.IndexServer.myelo.MyELOInfo info) {
			BSyncResult<EloixClient.IndexServer.myelo.MyELOContent> asyncResult = new BSyncResult<EloixClient.IndexServer.myelo.MyELOContent>();			
			readContent(state, info, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.myelo.MyELOContent>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void readContent(EloixClient.IndexServer.myelo.MyELOState state, EloixClient.IndexServer.myelo.MyELOInfo info, BAsyncResult<EloixClient.IndexServer.myelo.MyELOContent> asyncResult) {
			BRequest_MyELOService_readContent req = new BRequest_MyELOService_readContent();			
			req.stateValue = state;
			req.infoValue = info;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}

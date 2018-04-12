using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public class BStub_RawStreamService : BStub, RawStreamServiceAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 354585327L;
		
		public BStub_RawStreamService(BTransport transport)
			: base(transport) {}			
		
		public virtual String upload(String[] @params, System.IO.Stream @is) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			upload(@params, @is, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void upload(String[] @params, System.IO.Stream @is, BAsyncResult<String> asyncResult) {
			BRequest_RawStreamService_upload req = new BRequest_RawStreamService_upload();			
			req.paramsValue = @params;
			req.isValue = @is;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual System.IO.Stream download(String[] @params) {
			BSyncResult<System.IO.Stream> asyncResult = new BSyncResult<System.IO.Stream>();			
			download(@params, BAsyncResultHelper.ToDelegate<System.IO.Stream>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void download(String[] @params, BAsyncResult<System.IO.Stream> asyncResult) {
			BRequest_RawStreamService_download req = new BRequest_RawStreamService_download();			
			req.paramsValue = @params;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}

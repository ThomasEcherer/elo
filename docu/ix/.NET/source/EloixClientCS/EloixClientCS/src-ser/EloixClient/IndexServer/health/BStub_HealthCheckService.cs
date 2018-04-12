using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BStub_HealthCheckService : BStub, HealthCheckServiceAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 969424915L;
		
		public BStub_HealthCheckService(BTransport transport)
			: base(transport) {}			
		
		public virtual void updateMeanValue(String name, double meanValue, long sampleSize) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			updateMeanValue(name, meanValue, sampleSize, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void updateMeanValue(String name, double meanValue, long sampleSize, BAsyncResult<Object> asyncResult) {
			BRequest_HealthCheckService_updateMeanValue req = new BRequest_HealthCheckService_updateMeanValue();			
			req.nameValue = name;
			req.meanValueValue = meanValue;
			req.sampleSizeValue = sampleSize;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void updateDoubleValue(String name, double doubleValue) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			updateDoubleValue(name, doubleValue, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void updateDoubleValue(String name, double doubleValue, BAsyncResult<Object> asyncResult) {
			BRequest_HealthCheckService_updateDoubleValue req = new BRequest_HealthCheckService_updateDoubleValue();			
			req.nameValue = name;
			req.doubleValueValue = doubleValue;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void computeDoubleValue(String name, double doubleValue, EloixClient.IndexServer.health.HealthCheckValueOperation operation) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			computeDoubleValue(name, doubleValue, operation, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void computeDoubleValue(String name, double doubleValue, EloixClient.IndexServer.health.HealthCheckValueOperation operation, BAsyncResult<Object> asyncResult) {
			BRequest_HealthCheckService_computeDoubleValue req = new BRequest_HealthCheckService_computeDoubleValue();			
			req.nameValue = name;
			req.doubleValueValue = doubleValue;
			req.operationValue = operation;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void update(EloixClient.IndexServer.health.HealthCheckInfo hci) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			update(hci, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void update(EloixClient.IndexServer.health.HealthCheckInfo hci, BAsyncResult<Object> asyncResult) {
			BRequest_HealthCheckService_update req = new BRequest_HealthCheckService_update();			
			req.hciValue = hci;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void updateAll(IList<EloixClient.IndexServer.health.HealthCheckInfo> hcis) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			updateAll(hcis, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void updateAll(IList<EloixClient.IndexServer.health.HealthCheckInfo> hcis, BAsyncResult<Object> asyncResult) {
			BRequest_HealthCheckService_updateAll req = new BRequest_HealthCheckService_updateAll();			
			req.hcisValue = hcis;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual Object uploadAll(Object reserved) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			uploadAll(reserved, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void uploadAll(Object reserved, BAsyncResult<Object> asyncResult) {
			BRequest_HealthCheckService_uploadAll req = new BRequest_HealthCheckService_uploadAll();			
			req.reservedValue = reserved;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.health.HealthCheckInfos read(IList<String> names) {
			BSyncResult<EloixClient.IndexServer.health.HealthCheckInfos> asyncResult = new BSyncResult<EloixClient.IndexServer.health.HealthCheckInfos>();			
			read(names, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.health.HealthCheckInfos>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void read(IList<String> names, BAsyncResult<EloixClient.IndexServer.health.HealthCheckInfos> asyncResult) {
			BRequest_HealthCheckService_read req = new BRequest_HealthCheckService_read();			
			req.namesValue = names;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}

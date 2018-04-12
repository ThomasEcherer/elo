//
// Serializer for java.util.List<de.elo.ix.client.health.HealthCheckInfo>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1270538819 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1270538819();
		
		public BSerializer_1270538819() 
			: base(1270538819) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.health.HealthCheckInfo> arr = new List<EloixClient.IndexServer.health.HealthCheckInfo>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.health.HealthCheckInfo obj = (EloixClient.IndexServer.health.HealthCheckInfo)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.health.HealthCheckInfo> arr = (IList<EloixClient.IndexServer.health.HealthCheckInfo>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.health.HealthCheckInfo obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

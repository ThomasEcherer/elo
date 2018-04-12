//
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.Notification>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1147263971 : BSerializer_13 {
		
		public readonly static new BSerializer instance = new BSerializer_1147263971();
		
		public BSerializer_1147263971()
			: base(1147263971) {}		
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			Dictionary<String,EloixClient.IndexServer.Notification> map = new Dictionary<String,EloixClient.IndexServer.Notification>();
			bin.onObjectCreated(map);
			int n = bbuf.getLength();
			for (int i = 0; i < n; i++) {
				String key = bbuf.getString();
				EloixClient.IndexServer.Notification value = (EloixClient.IndexServer.Notification)bin.readObj(false, null);
				map[key] = value;
			}
			return map;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			Dictionary<String,EloixClient.IndexServer.Notification> map = (Dictionary<String,EloixClient.IndexServer.Notification>)obj1;
			int n = map.Count;
			bout.bbuf.putLength(n);
			foreach (KeyValuePair<String,EloixClient.IndexServer.Notification> obj in map) {
				bbuf.putString(obj.Key);
				bout.writeObj(obj.Value, false, null);
			}
		}
		
	}
} // namespace

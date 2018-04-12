//
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.feed.HashTag>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1239602222 : BSerializer_13 {
		
		public readonly static new BSerializer instance = new BSerializer_1239602222();
		
		public BSerializer_1239602222()
			: base(1239602222) {}		
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			Dictionary<String,EloixClient.IndexServer.feed.HashTag> map = new Dictionary<String,EloixClient.IndexServer.feed.HashTag>();
			bin.onObjectCreated(map);
			int n = bbuf.getLength();
			for (int i = 0; i < n; i++) {
				String key = bbuf.getString();
				EloixClient.IndexServer.feed.HashTag value = (EloixClient.IndexServer.feed.HashTag)bin.readObj(false, null);
				map[key] = value;
			}
			return map;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			Dictionary<String,EloixClient.IndexServer.feed.HashTag> map = (Dictionary<String,EloixClient.IndexServer.feed.HashTag>)obj1;
			int n = map.Count;
			bout.bbuf.putLength(n);
			foreach (KeyValuePair<String,EloixClient.IndexServer.feed.HashTag> obj in map) {
				bbuf.putString(obj.Key);
				bout.writeObj(obj.Value, false, null);
			}
		}
		
	}
} // namespace

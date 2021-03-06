﻿//
// Serializer for java.util.Map<java.lang.String,de.elo.ix.client.feed.Feed>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_425536672 : BSerializer_13 {
		
		public readonly static new BSerializer instance = new BSerializer_425536672();
		
		public BSerializer_425536672()
			: base(425536672) {}		
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			Dictionary<String,EloixClient.IndexServer.feed.Feed> map = new Dictionary<String,EloixClient.IndexServer.feed.Feed>();
			bin.onObjectCreated(map);
			int n = bbuf.getLength();
			for (int i = 0; i < n; i++) {
				String key = bbuf.getString();
				EloixClient.IndexServer.feed.Feed value = (EloixClient.IndexServer.feed.Feed)bin.readObj(false, null);
				map[key] = value;
			}
			return map;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			Dictionary<String,EloixClient.IndexServer.feed.Feed> map = (Dictionary<String,EloixClient.IndexServer.feed.Feed>)obj1;
			int n = map.Count;
			bout.bbuf.putLength(n);
			foreach (KeyValuePair<String,EloixClient.IndexServer.feed.Feed> obj in map) {
				bbuf.putString(obj.Key);
				bout.writeObj(obj.Value, false, null);
			}
		}
		
	}
} // namespace

//
// Serializer for java.util.HashSet<de.elo.ix.client.feed.HashTag>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1535847981 : BSerializer_14 {
		
		public readonly static new BSerializer instance = new BSerializer_1535847981();
		
		public BSerializer_1535847981() 
			: base(1535847981) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			HashSet<EloixClient.IndexServer.feed.HashTag> arr = new HashSet<EloixClient.IndexServer.feed.HashTag>();
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.feed.HashTag obj = (EloixClient.IndexServer.feed.HashTag)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			HashSet<EloixClient.IndexServer.feed.HashTag> arr = (HashSet<EloixClient.IndexServer.feed.HashTag>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.feed.HashTag obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

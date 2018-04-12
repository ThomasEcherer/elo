//
// Serializer for java.util.List<de.elo.ix.client.feed.HashTagRelation>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1403472717 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1403472717();
		
		public BSerializer_1403472717() 
			: base(1403472717) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.feed.HashTagRelation> arr = new List<EloixClient.IndexServer.feed.HashTagRelation>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.feed.HashTagRelation obj = (EloixClient.IndexServer.feed.HashTagRelation)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.feed.HashTagRelation> arr = (IList<EloixClient.IndexServer.feed.HashTagRelation>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.feed.HashTagRelation obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

//
// Serializer for java.util.List<de.elo.ix.client.feed.ActionHistory>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1399835671 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1399835671();
		
		public BSerializer_1399835671() 
			: base(1399835671) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.feed.ActionHistory> arr = new List<EloixClient.IndexServer.feed.ActionHistory>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.feed.ActionHistory obj = (EloixClient.IndexServer.feed.ActionHistory)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.feed.ActionHistory> arr = (IList<EloixClient.IndexServer.feed.ActionHistory>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.feed.ActionHistory obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

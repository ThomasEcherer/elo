//
// Serializer for java.util.List<de.elo.ix.client.feed.EActionType>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1644858720 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1644858720();
		
		public BSerializer_1644858720() 
			: base(1644858720) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.feed.EActionType> arr = new List<EloixClient.IndexServer.feed.EActionType>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.feed.EActionType obj = (EloixClient.IndexServer.feed.EActionType)bbuf.getInt();
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.feed.EActionType> arr = (IList<EloixClient.IndexServer.feed.EActionType>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.feed.EActionType obj in arr) {
				bbuf.putInt((int)((EloixClient.IndexServer.feed.EActionType)obj));
			}
		}
		
	}
} // namespace

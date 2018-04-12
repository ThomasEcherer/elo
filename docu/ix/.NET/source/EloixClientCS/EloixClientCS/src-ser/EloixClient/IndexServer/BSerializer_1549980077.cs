//
// Serializer for java.util.ArrayList<de.elo.ix.client.WFNodeHistory>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1549980077 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1549980077();
		
		public BSerializer_1549980077() 
			: base(1549980077) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.WFNodeHistory> arr = new List<EloixClient.IndexServer.WFNodeHistory>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.WFNodeHistory obj = (EloixClient.IndexServer.WFNodeHistory)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			List<EloixClient.IndexServer.WFNodeHistory> arr = (List<EloixClient.IndexServer.WFNodeHistory>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.WFNodeHistory obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

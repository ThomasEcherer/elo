//
// Serializer for java.util.List<de.elo.ix.client.Sord>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2106404937 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_2106404937();
		
		public BSerializer_2106404937() 
			: base(2106404937) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.Sord> arr = new List<EloixClient.IndexServer.Sord>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.Sord obj = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.Sord> arr = (IList<EloixClient.IndexServer.Sord>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.Sord obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

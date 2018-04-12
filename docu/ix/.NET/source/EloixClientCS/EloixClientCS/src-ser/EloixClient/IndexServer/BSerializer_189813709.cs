//
// Serializer for java.util.List<de.elo.ix.client.InvalidateCacheInfoParam>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_189813709 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_189813709();
		
		public BSerializer_189813709() 
			: base(189813709) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.InvalidateCacheInfoParam> arr = new List<EloixClient.IndexServer.InvalidateCacheInfoParam>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.InvalidateCacheInfoParam obj = (EloixClient.IndexServer.InvalidateCacheInfoParam)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.InvalidateCacheInfoParam> arr = (IList<EloixClient.IndexServer.InvalidateCacheInfoParam>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.InvalidateCacheInfoParam obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

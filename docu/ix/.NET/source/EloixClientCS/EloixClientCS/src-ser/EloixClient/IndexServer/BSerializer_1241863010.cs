//
// Serializer for java.util.List<de.elo.ix.client.ValueClass>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1241863010 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1241863010();
		
		public BSerializer_1241863010() 
			: base(1241863010) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.ValueClass> arr = new List<EloixClient.IndexServer.ValueClass>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.ValueClass obj = (EloixClient.IndexServer.ValueClass)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.ValueClass> arr = (IList<EloixClient.IndexServer.ValueClass>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.ValueClass obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

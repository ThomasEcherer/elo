//
// Serializer for java.util.List<de.elo.ix.client.Note>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2111020589 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_2111020589();
		
		public BSerializer_2111020589() 
			: base(2111020589) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.Note> arr = new List<EloixClient.IndexServer.Note>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.Note obj = (EloixClient.IndexServer.Note)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.Note> arr = (IList<EloixClient.IndexServer.Note>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.Note obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

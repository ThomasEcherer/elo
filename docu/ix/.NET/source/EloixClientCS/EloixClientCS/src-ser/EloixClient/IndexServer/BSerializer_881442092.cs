//
// Serializer for java.util.List<de.elo.ix.client.PublicDownload>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_881442092 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_881442092();
		
		public BSerializer_881442092() 
			: base(881442092) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.PublicDownload> arr = new List<EloixClient.IndexServer.PublicDownload>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.PublicDownload obj = (EloixClient.IndexServer.PublicDownload)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.PublicDownload> arr = (IList<EloixClient.IndexServer.PublicDownload>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.PublicDownload obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

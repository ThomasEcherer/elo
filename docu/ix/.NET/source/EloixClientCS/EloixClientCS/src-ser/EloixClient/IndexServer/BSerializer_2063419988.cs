//
// Serializer for java.util.ArrayList<de.elo.ix.client.WFDiagram>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2063419988 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_2063419988();
		
		public BSerializer_2063419988() 
			: base(2063419988) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.WFDiagram> arr = new List<EloixClient.IndexServer.WFDiagram>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.WFDiagram obj = (EloixClient.IndexServer.WFDiagram)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			List<EloixClient.IndexServer.WFDiagram> arr = (List<EloixClient.IndexServer.WFDiagram>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.WFDiagram obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

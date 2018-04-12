//
// Serializer for java.util.List<de.elo.ix.client.system.LicenseCounter>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2005491011 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_2005491011();
		
		public BSerializer_2005491011() 
			: base(2005491011) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.Indexserver.system.LicenseCounter> arr = new List<EloixClient.Indexserver.system.LicenseCounter>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.Indexserver.system.LicenseCounter obj = (EloixClient.Indexserver.system.LicenseCounter)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.Indexserver.system.LicenseCounter> arr = (IList<EloixClient.Indexserver.system.LicenseCounter>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.Indexserver.system.LicenseCounter obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

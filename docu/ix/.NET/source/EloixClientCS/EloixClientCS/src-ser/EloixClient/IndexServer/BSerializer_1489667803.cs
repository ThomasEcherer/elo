//
// Serializer for java.util.List<java.util.List<java.lang.String>>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1489667803 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1489667803();
		
		public BSerializer_1489667803() 
			: base(1489667803) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<IList<String>> arr = new List<IList<String>>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				IList<String> obj = (IList<String>)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<IList<String>> arr = (IList<IList<String>>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (IList<String> obj in arr) {
				bout.writeObj(obj, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
			}
		}
		
	}
} // namespace

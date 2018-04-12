//
// Serializer for java.util.List<java.util.Map<java.lang.String,java.lang.String>>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1319324274 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_1319324274();
		
		public BSerializer_1319324274() 
			: base(1319324274) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<IDictionary<String,String>> arr = new List<IDictionary<String,String>>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				IDictionary<String,String> obj = (IDictionary<String,String>)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<IDictionary<String,String>> arr = (IList<IDictionary<String,String>>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (IDictionary<String,String> obj in arr) {
				bout.writeObj(obj, false, EloixClient.IndexServer.BSerializer_1710660846.instance);
			}
		}
		
	}
} // namespace

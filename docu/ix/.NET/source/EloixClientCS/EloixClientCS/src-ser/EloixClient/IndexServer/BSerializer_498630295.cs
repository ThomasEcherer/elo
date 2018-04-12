//
// Serializer for java.util.Map<java.lang.Integer,java.lang.String>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_498630295 : BSerializer_13 {
		
		public readonly static new BSerializer instance = new BSerializer_498630295();
		
		public BSerializer_498630295()
			: base(498630295) {}		
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			Dictionary<int,String> map = new Dictionary<int,String>();
			bin.onObjectCreated(map);
			int n = bbuf.getLength();
			for (int i = 0; i < n; i++) {
				int key = bbuf.getInt();
				String value = bbuf.getString();
				map[key] = value;
			}
			return map;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			Dictionary<int,String> map = (Dictionary<int,String>)obj1;
			int n = map.Count;
			bout.bbuf.putLength(n);
			foreach (KeyValuePair<int,String> obj in map) {
				bbuf.putInt(obj.Key);
				bbuf.putString(obj.Value);
			}
		}
		
	}
} // namespace

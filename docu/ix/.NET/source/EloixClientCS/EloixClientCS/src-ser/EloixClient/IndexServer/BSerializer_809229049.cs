//
// Serializer for de.elo.ix.client.CryptInfo[]
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_809229049 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_809229049();
		
		public BSerializer_809229049() : 
			base(809229049) {}
		
		public override Object read(Object obj1, BInput bin1, long version) {
			BInputBin bin = (BInputBin)bin1;
			BBufferBin bbuf = bin.bbuf;
			
			// lengths
			int n0 = bbuf.getLength();
			
			// create array
			CryptInfo[] arr =  new EloixClient.IndexServer.CryptInfo[n0];
			bin.onObjectCreated(arr);
			
			// read
			for (int i0 = 0; i0 < n0; i0++) {
				arr[i0] = (EloixClient.IndexServer.CryptInfo)bin.readObj(false, null);
			}
			
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version) {
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			
			CryptInfo[] arr = (CryptInfo[])obj1;
			
			// lengths
			int n0 = arr.GetLength(0);
			bbuf.putLength(n0);
			
			// write
			for (int i0 = 0; i0 < n0; i0++) {
				bout.writeObj(arr[i0], false, null);
			}
		}
		
	}
} // namespace

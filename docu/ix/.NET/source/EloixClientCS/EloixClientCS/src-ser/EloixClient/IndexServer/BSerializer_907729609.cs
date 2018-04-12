﻿//
// Serializer for java.util.List<de.elo.ix.client.ResolveRightsResult>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_907729609 : BSerializer_12 {
		
		public readonly static new BSerializer instance = new BSerializer_907729609();
		
		public BSerializer_907729609() 
			: base(907729609) {}
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			int n = bbuf.getLength();
			List<EloixClient.IndexServer.ResolveRightsResult> arr = new List<EloixClient.IndexServer.ResolveRightsResult>(n);
			bin.onObjectCreated(arr);
			for (int i = 0; i < n; i++) {
				EloixClient.IndexServer.ResolveRightsResult obj = (EloixClient.IndexServer.ResolveRightsResult)bin.readObj(false, null);
				arr.Add(obj);
			}
			return arr;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			IList<EloixClient.IndexServer.ResolveRightsResult> arr = (IList<EloixClient.IndexServer.ResolveRightsResult>)obj1;
			int n = arr.Count;
			bout.bbuf.putLength(n);
			foreach (EloixClient.IndexServer.ResolveRightsResult obj in arr) {
				bout.writeObj(obj, false, null);
			}
		}
		
	}
} // namespace

﻿//
// Serializer for java.util.Map<java.lang.Integer,de.elo.ix.client.UserName>
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1874463571 : BSerializer_13 {
		
		public readonly static new BSerializer instance = new BSerializer_1874463571();
		
		public BSerializer_1874463571()
			: base(1874463571) {}		
		
		public override Object read(object obj1, BInput bin1, long version) {
			BInputBin bin = ((BInputBin)bin1);
			BBufferBin bbuf = bin.bbuf;
			Dictionary<int,EloixClient.IndexServer.UserName> map = new Dictionary<int,EloixClient.IndexServer.UserName>();
			bin.onObjectCreated(map);
			int n = bbuf.getLength();
			for (int i = 0; i < n; i++) {
				int key = bbuf.getInt();
				EloixClient.IndexServer.UserName value = (EloixClient.IndexServer.UserName)bin.readObj(false, null);
				map[key] = value;
			}
			return map;
		}
		
		public override void write(Object obj1, BOutput bout1, long version)  {
			BOutputBin bout = ((BOutputBin)bout1);
			BBufferBin bbuf = bout.bbuf;
			Dictionary<int,EloixClient.IndexServer.UserName> map = (Dictionary<int,EloixClient.IndexServer.UserName>)obj1;
			int n = map.Count;
			bout.bbuf.putLength(n);
			foreach (KeyValuePair<int,EloixClient.IndexServer.UserName> obj in map) {
				bbuf.putInt(obj.Key);
				bout.writeObj(obj.Value, false, null);
			}
		}
		
	}
} // namespace

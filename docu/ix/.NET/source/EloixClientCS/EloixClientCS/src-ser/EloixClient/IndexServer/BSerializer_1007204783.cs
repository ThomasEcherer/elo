﻿//
// Serializer for de.elo.ix.client.BResult_881442092
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1007204783 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1007204783();
		
		public BSerializer_1007204783()
			: base(1007204783) {}
		
		public BSerializer_1007204783(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_881442092 obj = (BResult_881442092)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_881442092.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_881442092 obj = (BResult_881442092)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_881442092()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (IList<EloixClient.IndexServer.PublicDownload>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

﻿//
// Serializer for de.elo.ix.client.PhysDelDocs
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_855528761 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_855528761();
		
		public BSerializer_855528761()
			: base(855528761) {}
		
		public BSerializer_855528761(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PhysDelDocs obj = (PhysDelDocs)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PhysDelDocs obj = (PhysDelDocs)(obj1 != null ? obj1 : bin.onObjectCreated(new PhysDelDocs()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace

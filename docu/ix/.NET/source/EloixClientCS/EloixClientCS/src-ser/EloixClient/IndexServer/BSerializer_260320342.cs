﻿//
// Serializer for de.elo.ix.client.UserTaskPriorityC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_260320342 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_260320342();
		
		public BSerializer_260320342()
			: base(260320342) {}
		
		public BSerializer_260320342(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			UserTaskPriorityC obj = (UserTaskPriorityC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserTaskPriorityC obj = (UserTaskPriorityC)(obj1 != null ? obj1 : bin.onObjectCreated(new UserTaskPriorityC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

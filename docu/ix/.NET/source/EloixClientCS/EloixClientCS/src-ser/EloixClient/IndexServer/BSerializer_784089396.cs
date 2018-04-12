//
// Serializer for de.elo.ix.client.IXExceptionData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_784089396 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_784089396();
		
		public BSerializer_784089396()
			: base(784089396) {}
		
		public BSerializer_784089396(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			IXExceptionData obj = (IXExceptionData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.callId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.details);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.exceptionType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.message);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ticket);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			IXExceptionData obj = (IXExceptionData)(obj1 != null ? obj1 : bin.onObjectCreated(new IXExceptionData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.callId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.details = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exceptionType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.message = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ticket = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

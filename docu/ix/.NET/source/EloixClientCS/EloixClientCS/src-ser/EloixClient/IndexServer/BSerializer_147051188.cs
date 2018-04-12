//
// Serializer for de.elo.ix.client.ProcessCopyElements
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_147051188 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_147051188();
		
		public BSerializer_147051188()
			: base(147051188) {}
		
		public BSerializer_147051188(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ProcessCopyElements obj = (ProcessCopyElements)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 900000014000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.createMapping);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.copyOptions, false, null);
			if (version >= 900000014000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.copyResult, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessCopyElements obj = (ProcessCopyElements)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessCopyElements()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 900000014000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.createMapping = bbuf.getBoolean();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.copyOptions = (EloixClient.IndexServer.CopyOptions)bin.readObj(false, null);
			if (version >= 900000014000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.copyResult = (EloixClient.IndexServer.CopyResult)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace

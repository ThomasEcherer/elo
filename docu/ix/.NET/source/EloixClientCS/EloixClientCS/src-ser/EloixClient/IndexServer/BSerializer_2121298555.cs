//
// Serializer for de.elo.ix.client.ActivityProject
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2121298555 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2121298555();
		
		public BSerializer_2121298555()
			: base(2121298555) {}
		
		public BSerializer_2121298555(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ActivityProject obj = (ActivityProject)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.major);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.minor);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.optValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.project);
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.lockedWhenFinished);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.protectedProject);
			}
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.options, false, EloixClient.IndexServer.BSerializer_1831677187.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActivityProject obj = (ActivityProject)(obj1 != null ? obj1 : bin.onObjectCreated(new ActivityProject()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.major = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.minor = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.project = bbuf.getString();
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lockedWhenFinished = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.protectedProject = bbuf.getBoolean();
			}
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.options = (EloixClient.IndexServer.ActivityOption[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1831677187.instance);
			}
			
			return obj;
		}
		
	}
} // namespace

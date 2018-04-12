//
// Serializer for de.elo.ix.client.FindBackgroundThreadOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1054287589 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1054287589();
		
		public BSerializer_1054287589()
			: base(1054287589) {}
		
		public BSerializer_1054287589(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindBackgroundThreadOptions obj = (FindBackgroundThreadOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dateAfter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dateBefore);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclActiveJobs);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclFinishedJobs);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclFullInfo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.sortOrder);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.guids, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userInfo, false, EloixClient.IndexServer.BSerializer_1132956238.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindBackgroundThreadOptions obj = (FindBackgroundThreadOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new FindBackgroundThreadOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dateAfter = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dateBefore = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclActiveJobs = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclFinishedJobs = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclFullInfo = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sortOrder = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guids = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userInfo = (EloixClient.IndexServer.UserInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1132956238.instance);
			
			return obj;
		}
		
	}
} // namespace

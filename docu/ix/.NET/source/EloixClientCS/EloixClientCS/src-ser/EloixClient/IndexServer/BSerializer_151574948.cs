//
// Serializer for de.elo.ix.client.FindActivityProjectsInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_151574948 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_151574948();
		
		public BSerializer_151574948()
			: base(151574948) {}
		
		public BSerializer_151574948(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindActivityProjectsInfo obj = (FindActivityProjectsInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.projectName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindActivityProjectsInfo obj = (FindActivityProjectsInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindActivityProjectsInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.projectName = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace

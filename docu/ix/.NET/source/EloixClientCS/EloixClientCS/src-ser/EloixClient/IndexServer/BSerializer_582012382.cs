//
// Serializer for de.elo.ix.client.ConfigFile
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_582012382 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_582012382();
		
		public BSerializer_582012382()
			: base(582012382) {}
		
		public BSerializer_582012382(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ConfigFile obj = (ConfigFile)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dir);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.isDirectory);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastModifiedISO);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.size);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.uploadResult);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.url);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fileData, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ConfigFile obj = (ConfigFile)(obj1 != null ? obj1 : bin.onObjectCreated(new ConfigFile()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dir = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.isDirectory = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastModifiedISO = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.size = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.uploadResult = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.url = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileData = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace

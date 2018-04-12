//
// Serializer for de.elo.ix.client.License
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1330120264 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1330120264();
		
		public BSerializer_1330120264()
			: base(1330120264) {}
		
		public BSerializer_1330120264(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			License obj = (License)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.backup);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.cold);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.demoVersion);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.dispatchFolder);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.domea);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.emailOnly);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.fultext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.httpServer);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.indexServer);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.limitedIg);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.limitedVersion);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nbOfIgLicenses);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nbOfServerLicenses);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.professional);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.replication);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.sapALink);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.serno);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.signature);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.stack);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.tobid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.xmlImport);
			if (version >= 800000024000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.nbOfFulltextLangs);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.features, false, EloixClient.IndexServer.BSerializer_100361105.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			License obj = (License)(obj1 != null ? obj1 : bin.onObjectCreated(new License()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backup = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cold = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.demoVersion = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dispatchFolder = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.domea = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.emailOnly = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fultext = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.httpServer = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.indexServer = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.limitedIg = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.limitedVersion = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nbOfIgLicenses = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nbOfServerLicenses = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.professional = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replication = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sapALink = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.serno = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.signature = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stack = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tobid = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.xmlImport = bbuf.getBoolean();
			if (version >= 800000024000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.nbOfFulltextLangs = bbuf.getInt();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.features = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			
			return obj;
		}
		
	}
} // namespace

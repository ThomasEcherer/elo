//
// Serializer for de.elo.ix.client.EditInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_820228328 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_820228328();
		
		public BSerializer_820228328()
			: base(820228328) {}
		
		public BSerializer_820228328(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EditInfo obj = (EditInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.docTemplates, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.document, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.keywords, false, EloixClient.IndexServer.BSerializer_206201524.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.markerNames, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.mask, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.maskNames, false, EloixClient.IndexServer.BSerializer_248117584.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.notes, false, EloixClient.IndexServer.BSerializer_776454091.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.pathNames, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.replNames, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sord, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordTypes, false, EloixClient.IndexServer.BSerializer_133130047.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EditInfo obj = (EditInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new EditInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docTemplates = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.document = (EloixClient.IndexServer.Document)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keywords = (EloixClient.IndexServer.Keyword[])bin.readObj(false, EloixClient.IndexServer.BSerializer_206201524.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.markerNames = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mask = (EloixClient.IndexServer.DocMask)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maskNames = (EloixClient.IndexServer.MaskName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_248117584.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notes = (EloixClient.IndexServer.Note[])bin.readObj(false, EloixClient.IndexServer.BSerializer_776454091.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathNames = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replNames = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sord = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordTypes = (EloixClient.IndexServer.SordType[])bin.readObj(false, EloixClient.IndexServer.BSerializer_133130047.instance);
			
			return obj;
		}
		
	}
} // namespace

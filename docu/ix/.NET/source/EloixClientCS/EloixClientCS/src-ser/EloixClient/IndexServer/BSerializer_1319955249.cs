//
// Serializer for de.elo.ix.client.NoteC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1319955249 : EloixClient.IndexServer.BSerializer_1521483547 {
		
		public readonly static new BSerializer instance = new BSerializer_1319955249();
		
		public BSerializer_1319955249()
			: base(1319955249) {}
		
		public BSerializer_1319955249(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			NoteC obj = (NoteC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteC obj = (NoteC)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace

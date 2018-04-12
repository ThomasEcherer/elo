//
// Serializer for de.elo.ix.client.myelo.MyELOContent
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BSerializer_1585309177 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1585309177();
		
		public BSerializer_1585309177()
			: base(1585309177) {}
		
		public BSerializer_1585309177(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MyELOContent obj = (MyELOContent)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actions, false, EloixClient.IndexServer.BSerializer_433625553.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.feeds, false, EloixClient.IndexServer.BSerializer_425536672.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.hashTagRelations, false, EloixClient.IndexServer.BSerializer_1403472717.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.hashTags, false, EloixClient.IndexServer.BSerializer_1239602222.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.notifications, false, EloixClient.IndexServer.BSerializer_1147263971.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sords, false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.subscriptions, false, EloixClient.IndexServer.BSerializer_1862275569.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.tasks, false, EloixClient.IndexServer.BSerializer_829657911.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflows, false, EloixClient.IndexServer.BSerializer_838894319.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MyELOContent obj = (MyELOContent)(obj1 != null ? obj1 : bin.onObjectCreated(new MyELOContent()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actions = (EloixClient.IndexServer.feed.Action[])bin.readObj(false, EloixClient.IndexServer.BSerializer_433625553.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.feeds = (IDictionary<String,EloixClient.IndexServer.feed.Feed>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashTagRelations = (IList<EloixClient.IndexServer.feed.HashTagRelation>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashTags = (IDictionary<String,EloixClient.IndexServer.feed.HashTag>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notifications = (IDictionary<String,EloixClient.IndexServer.Notification>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sords = (EloixClient.IndexServer.Sord[])bin.readObj(false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subscriptions = (IDictionary<String,EloixClient.IndexServer.Subscription>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tasks = (EloixClient.IndexServer.UserTask[])bin.readObj(false, EloixClient.IndexServer.BSerializer_829657911.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflows = (EloixClient.IndexServer.WFDiagram[])bin.readObj(false, EloixClient.IndexServer.BSerializer_838894319.instance);
			
			return obj;
		}
		
	}
} // namespace

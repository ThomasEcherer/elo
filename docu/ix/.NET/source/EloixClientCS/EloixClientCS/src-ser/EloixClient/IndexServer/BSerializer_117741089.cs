//
// Serializer for de.elo.ix.client.DocMaskLineTemplate
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_117741089 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_117741089();
		
		public BSerializer_117741089()
			: base(117741089) {}
		
		public BSerializer_117741089(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMaskLineTemplate obj = (DocMaskLineTemplate)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStampSync);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.commentTranslationKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.defaultValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.disableWordWheel);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.externalData);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.hidden);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.important);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inherit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inheritFromParent);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.key);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lockName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.max);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.min);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nameTranslationKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.notTokenized);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyBuzzwords);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.postfixAsterix);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.prefixAsterix);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.readOnly);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.serverScriptName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.translate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.version);
			if (version >= 1000000020000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.required);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.validateExpression);
				if (version >= 1000000020000023L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.excludeFromISearch);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskLineTemplate obj = (DocMaskLineTemplate)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskLineTemplate()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStampSync = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.commentTranslationKey = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.defaultValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.disableWordWheel = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.externalData = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hidden = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.important = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inherit = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inheritFromParent = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.key = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.max = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.min = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nameTranslationKey = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notTokenized = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyBuzzwords = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.postfixAsterix = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prefixAsterix = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.readOnly = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.serverScriptName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.translate = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.version = bbuf.getBoolean();
			if (version >= 1000000020000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.required = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.validateExpression = bbuf.getString();
				if (version >= 1000000020000023L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.excludeFromISearch = bbuf.getBoolean();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			
			return obj;
		}
		
	}
} // namespace

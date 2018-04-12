//
// Serializer for de.elo.ix.client.DocMaskLine
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1291500689 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1291500689();
		
		public BSerializer_1291500689()
			: base(1291500689) {}
		
		public BSerializer_1291500689(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMaskLine obj = (DocMaskLine)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.canEdit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.editCol);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.editRow);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.editWidth);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.hidden);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.key);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.labelCol);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.labelRow);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maskId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.max);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.min);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.nextTab);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyBuzzwords);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.postfixAsterix);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.prefixAsterix);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.readOnly);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.tabOrder);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.externalData);
				if (version >= 700000000000004L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.important);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.translate);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.version);
					if (version >= 700000000000047L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.access);
						if (version >= 700000040000015L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.disableWordWheel);
							if (version >= 700000040000016L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.defaultValue);
								if (version >= 900000000000000L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putInt(obj.tabIndex);
									if (version >= 900000000000001L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putString(obj.serverScriptName);
										if (version >= 900000016000011L) {
											// checkpoint byps.gen.cs.PrintContext:494
											bbuf.putBoolean(obj.inherit);
											if (version >= 900000018000005L) {
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putString(obj.commentTranslationKey);
												// checkpoint byps.gen.cs.PrintContext:494
												bbuf.putString(obj.nameTranslationKey);
												if (version >= 900000022000000L) {
													// checkpoint byps.gen.cs.PrintContext:494
													bbuf.putBoolean(obj.notTokenized);
													if (version >= 900000030000019L) {
														// checkpoint byps.gen.cs.PrintContext:494
														bbuf.putBoolean(obj.inheritFromParent);
														if (version >= 900000039000001L) {
															// checkpoint byps.gen.cs.PrintContext:494
															bbuf.putBoolean(obj.valueArray);
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
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskLine obj = (DocMaskLine)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskLine()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.canEdit = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.editCol = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.editRow = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.editWidth = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hidden = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.key = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.labelCol = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.labelRow = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maskId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.max = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.min = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nextTab = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyBuzzwords = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.postfixAsterix = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prefixAsterix = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.readOnly = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tabOrder = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.externalData = bbuf.getString();
				if (version >= 700000000000004L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.important = bbuf.getBoolean();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.translate = bbuf.getBoolean();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.version = bbuf.getBoolean();
					if (version >= 700000000000047L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.access = bbuf.getInt();
						if (version >= 700000040000015L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.disableWordWheel = bbuf.getBoolean();
							if (version >= 700000040000016L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.defaultValue = bbuf.getString();
								if (version >= 900000000000000L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.tabIndex = bbuf.getInt();
									if (version >= 900000000000001L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.serverScriptName = bbuf.getString();
										if (version >= 900000016000011L) {
											// checkpoint byps.gen.cs.PrintContext:449
											obj.inherit = bbuf.getBoolean();
											if (version >= 900000018000005L) {
												// checkpoint byps.gen.cs.PrintContext:449
												obj.commentTranslationKey = bbuf.getString();
												// checkpoint byps.gen.cs.PrintContext:449
												obj.nameTranslationKey = bbuf.getString();
												if (version >= 900000022000000L) {
													// checkpoint byps.gen.cs.PrintContext:449
													obj.notTokenized = bbuf.getBoolean();
													if (version >= 900000030000019L) {
														// checkpoint byps.gen.cs.PrintContext:449
														obj.inheritFromParent = bbuf.getBoolean();
														if (version >= 900000039000001L) {
															// checkpoint byps.gen.cs.PrintContext:449
															obj.valueArray = bbuf.getBoolean();
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
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			
			return obj;
		}
		
	}
} // namespace

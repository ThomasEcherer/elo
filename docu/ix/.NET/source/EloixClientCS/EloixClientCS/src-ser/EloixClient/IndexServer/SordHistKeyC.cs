//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class SordHistKeyC : EloixClient.IndexServer.ObjHistKeyC, BSerializable
	{
	
		#region Constructors
		
		public SordHistKeyC() {
		}		
		
		public SordHistKeyC(SordHistKeyC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Entry IDs greater or equal of this value are used for Sord.name, Sord.xDate etc.
		/// </summary>
		public const int ID_RESERVED_MIN = 200;

		/// <summary>
		/// Entry ID for Sord.name.
		/// </summary>
		public const int ID_SORD_NAME = 200;

		/// <summary>
		/// Entry name for Sord.name.
		/// </summary>
		public const String NAME_SORD_NAME = "OBJSHORT";

		/// <summary>
		/// Entry ID for Sord.xDate.
		/// </summary>
		public const int ID_SORD_XDATE = 201;

		/// <summary>
		/// Entry name for Sord.xDate.
		/// </summary>
		public const String NAME_SORD_XDATE = "DOCDATE";

		/// <summary>
		/// Entry ID for Sord.desc.
		/// </summary>
		public const int ID_SORD_DESC = 202;

		/// <summary>
		/// Entry name for Sord.desc.
		/// </summary>
		public const String NAME_SORD_DESC = "MEMO";

		/// <summary>
		/// Entry ID for Sord.mask.
		/// </summary>
		public const int ID_DOCMASK_NAME = 203;

		/// <summary>
		/// Entry mame for Sord.name.
		/// </summary>
		public const String NAME_DOCMASK_NAME = "MNAME";

		/// <summary>
		/// Entry ID for Sord.acl
		/// </summary>
		public const int ID_SORD_ACL = 204;

		/// <summary>
		/// Entry ID for Sord.acl
		/// </summary>
		public const String NAME_SORD_ACL = "ACL";

		/// <summary>
		/// Entry ID for Sord.delDate.
		/// </summary>
		public const int ID_SORD_DELDATE = 205;

		/// <summary>
		/// Entry name for Sord.delDate.
		/// </summary>
		public const String NAME_SORD_DELDATE = "DELDATE";

		#endregion
		
		
		public static readonly new long serialVersionUID = 762601968L;		
	} // end class
}  // end namespace

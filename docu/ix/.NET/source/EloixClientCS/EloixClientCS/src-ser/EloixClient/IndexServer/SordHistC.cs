//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// Constanst for class SordHist.
	/// </summary>
	public class SordHistC : EloixClient.IndexServer.ObjHistC, BSerializable
	{
	
		#region Constructors
		
		public SordHistC() {
		}		
		
		public SordHistC(SordHistC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// History entry created by unknown program.
		/// </summary>
		public const int SRC_NONE = 0;

		/// <summary>
		/// History entry created by ELO Windows Client.
		/// </summary>
		public const int SRC_CLIENT = 1;

		/// <summary>
		/// History entry created by ELO Automation Interface.
		/// </summary>
		public const int SRC_OLE = 2;

		/// <summary>
		/// History entry created by ELO Internet Gateway.
		/// </summary>
		public const int SRC_IGW = 3;

		/// <summary>
		/// History entry created by ELO XML Importer
		/// </summary>
		public const int SRC_XML = 4;

		/// <summary>
		/// History entry created by ELO SAPALINK.
		/// </summary>
		public const int SRC_SAP = 5;

		/// <summary>
		/// History entry created by ELO IndexServer.
		/// </summary>
		public const int SRC_IX = 6;

		/// <summary>
		/// History entry created by ELO Replication.
		/// </summary>
		public const int SRC_REPL = 7;

		/// <summary>
		/// History entry created by ELO Archive Synchronisation.
		/// </summary>
		public const int SRC_SYNC = 8;

		#endregion
		
		
		public static readonly new long serialVersionUID = 520610723L;		
	} // end class
}  // end namespace

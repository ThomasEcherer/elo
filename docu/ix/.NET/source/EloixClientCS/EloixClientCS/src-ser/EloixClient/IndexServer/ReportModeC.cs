//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class ReportModeC : BSerializable
	{
	
		#region Constructors
		
		public ReportModeC() {
		}		
		
		public ReportModeC(ReportModeC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long bsetNO = 0L;

		public const long bsetLIMITED = 1L;

		public const long bsetVERBOSE = 2L;

		public const long bsetFULL = 3L;

		/// <summary>
		/// Do not write report.
		/// </summary>
		public readonly static EloixClient.IndexServer.ReportModeZ NO = new ReportModeZ(0L);

		/// <summary>
		/// Write limited report.
		/// </summary>
		public readonly static EloixClient.IndexServer.ReportModeZ LIMITED = new ReportModeZ(1L);

		/// <summary>
		/// Write verbose report.
		/// </summary>
		public readonly static EloixClient.IndexServer.ReportModeZ VERBOSE = new ReportModeZ(2L);

		/// <summary>
		/// Write full report.
		/// </summary>
		public readonly static EloixClient.IndexServer.ReportModeZ FULL = new ReportModeZ(3L);

		#endregion
		
		
		public static readonly long serialVersionUID = 1594659914L;		
	} // end class
}  // end namespace

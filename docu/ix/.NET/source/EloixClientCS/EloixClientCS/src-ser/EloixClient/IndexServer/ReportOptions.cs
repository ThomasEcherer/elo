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
	/// This class contains the codes for the activities/processes that are to be
	/// protocolled in a report.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ReportOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReportOptions() {
		}		
		
		public ReportOptions(EloixClient.IndexServer.ReportErpCode[] @erpCodes, EloixClient.IndexServer.ReportModeZ @mode) {
			this.erpCodesValue = @erpCodes;
			this.modeValue = @mode;
		}		
		
		public ReportOptions(ReportOptions rhs) : base(rhs)
		{
			this.erpCodesValue = rhs.erpCodesValue;
			this.modeValue = rhs.modeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ERP codes
		/// </summary>
		public EloixClient.IndexServer.ReportErpCode[] erpCodes
		{
			get
			{
				return erpCodesValue;
			}
			set
			{
				this.erpCodesValue = value;
			}
		}
		
		
		/// <summary>
		/// A ReportOptionsZ constant
		/// </summary>
		public EloixClient.IndexServer.ReportModeZ mode
		{
			get
			{
				return modeValue;
			}
			set
			{
				this.modeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.ReportErpCode[] erpCodesValue;

		protected EloixClient.IndexServer.ReportModeZ modeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1057373949L;		
	} // end class
}  // end namespace

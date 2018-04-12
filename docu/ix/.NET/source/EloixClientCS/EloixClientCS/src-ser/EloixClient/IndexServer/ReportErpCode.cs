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
	/// This class describes an ERP code - a filter code number in the ELO report.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH </p>
	/// </remarks>
	public class ReportErpCode : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReportErpCode() {
		}		
		
		public ReportErpCode(int @id, bool @limited, String @name, bool @verbose) {
			this.idValue = @id;
			this.limitedValue = @limited;
			this.nameValue = @name;
			this.verboseValue = @verbose;
		}		
		
		public ReportErpCode(ReportErpCode rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.limitedValue = rhs.limitedValue;
			this.nameValue = rhs.nameValue;
			this.verboseValue = rhs.verboseValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ERP code
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// This code is wirtten in limited report
		/// </summary>
		public bool limited
		{
			get
			{
				return limitedValue;
			}
			set
			{
				this.limitedValue = value;
			}
		}
		
		
		/// <summary>
		/// ERP name
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// This code is written in verbose report
		/// </summary>
		public bool verbose
		{
			get
			{
				return verboseValue;
			}
			set
			{
				this.verboseValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected bool limitedValue;

		protected String nameValue;

		protected bool verboseValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 508806040L;		
	} // end class
}  // end namespace

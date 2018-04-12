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
	/// This class encapsulates the constants of the WFDiagramC class.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class WFDiagramZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFDiagramZ() {
		}		
		
		public WFDiagramZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public WFDiagramZ(WFDiagramZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the WFDiagramC class.
		/// </summary>
		public long bset
		{
			get
			{
				return bsetValue;
			}
			set
			{
				this.bsetValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long bsetValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1717407429L;		
	} // end class
}  // end namespace

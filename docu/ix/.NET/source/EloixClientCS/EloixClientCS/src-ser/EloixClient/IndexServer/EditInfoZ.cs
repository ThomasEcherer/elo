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
	/// This class encapsulates the constants of the EditInfoC class.
	/// </summary>
	/// <remarks>
	/// EditInfo also returns a Sord object and a SordZ member is included
	/// to control the Sord data returned.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class EditInfoZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EditInfoZ() {
		}		
		
		public EditInfoZ(long @bset, EloixClient.IndexServer.SordZ @sordZ) {
			this.bsetValue = @bset;
			this.sordZValue = @sordZ;
		}		
		
		public EditInfoZ(EditInfoZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
			this.sordZValue = rhs.sordZValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the EditInfoC class.
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
		
		
		/// <summary>
		/// SordZ object to control the SordC elements returned.
		/// </summary>
		public EloixClient.IndexServer.SordZ sordZ
		{
			get
			{
				return sordZValue;
			}
			set
			{
				this.sordZValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long bsetValue;

		protected EloixClient.IndexServer.SordZ sordZValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 878901868L;		
	} // end class
}  // end namespace

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
	/// This class encapsulates the constants of the DocMaskLineTemplateC class.
	/// </summary>
	public class DocMaskLineTemplateZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocMaskLineTemplateZ() {
		}		
		
		public DocMaskLineTemplateZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public DocMaskLineTemplateZ(DocMaskLineTemplateZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
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
		
		
		public static readonly new long serialVersionUID = 1687510263L;		
	} // end class
}  // end namespace

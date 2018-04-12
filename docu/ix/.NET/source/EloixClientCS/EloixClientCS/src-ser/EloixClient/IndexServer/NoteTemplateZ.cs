//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class NoteTemplateZ : BSerializable
	{
	
		#region Constructors
		
		public NoteTemplateZ() {
		}		
		
		public NoteTemplateZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public NoteTemplateZ(NoteTemplateZ rhs)
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
		
		
		public static readonly long serialVersionUID = 1483878971L;		
	} // end class
}  // end namespace

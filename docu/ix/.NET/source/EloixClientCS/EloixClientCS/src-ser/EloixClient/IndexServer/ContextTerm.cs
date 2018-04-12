//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class ContextTerm : BSerializable
	{
	
		#region Constructors
		
		public ContextTerm() {
		}		
		
		public ContextTerm(String @term, int @docNum) {
			this.termValue = @term;
			this.docNumValue = @docNum;
		}		
		
		public ContextTerm(ContextTerm rhs)
		{
			this.termValue = rhs.termValue;
			this.docNumValue = rhs.docNumValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String term
		{
			get
			{
				return termValue;
			}
			set
			{
				this.termValue = value;
			}
		}
		
		
		public int docNum
		{
			get
			{
				return docNumValue;
			}
			set
			{
				this.docNumValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String termValue;

		protected int docNumValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1464223403L;		
	} // end class
}  // end namespace

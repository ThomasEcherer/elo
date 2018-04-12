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
	/// Finds an object according to the objects notes (sticky notes) content.
	/// </summary>
	public class FindByNotes : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByNotes() {
		}		
		
		public FindByNotes(String @term, int @type) {
			this.termValue = @term;
			this.typeValue = @type;
		}		
		
		public FindByNotes(FindByNotes rhs) : base(rhs)
		{
			this.termValue = rhs.termValue;
			this.typeValue = rhs.typeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The search term to be found within the notes.
		/// </summary>
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
		
		
		/// <summary>
		/// Find notes of this type.
		/// </summary>
		/// <remarks>
		/// Use TYPE_NONE (=0) to find all notes.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String termValue;

		protected int typeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 735083434L;		
	} // end class
}  // end namespace

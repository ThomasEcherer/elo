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
	/// Fulltext-Property to be added to/removed from an object.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2008</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ProcessFulltext : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessFulltext() {
		}		
		
		public ProcessFulltext(bool @addToFulltext) {
			this.addToFulltextValue = @addToFulltext;
		}		
		
		public ProcessFulltext(ProcessFulltext rhs) : base(rhs)
		{
			this.addToFulltextValue = rhs.addToFulltextValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Add to the fulltext-service
		/// </summary>
		public bool addToFulltext
		{
			get
			{
				return addToFulltextValue;
			}
			set
			{
				this.addToFulltextValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool addToFulltextValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1125907212L;		
	} // end class
}  // end namespace

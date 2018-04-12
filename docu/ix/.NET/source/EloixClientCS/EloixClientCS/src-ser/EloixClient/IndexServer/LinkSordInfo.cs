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
	/// Additional parameters for function {@link IXServicePortIF#linkSords2}
	/// </summary>
	public class LinkSordInfo : BSerializable
	{
	
		#region Constructors
		
		public LinkSordInfo() {
		}		
		
		public LinkSordInfo(bool @linkPermanent) {
			this.linkPermanentValue = @linkPermanent;
		}		
		
		public LinkSordInfo(LinkSordInfo rhs)
		{
			this.linkPermanentValue = rhs.linkPermanentValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// If true, Sords will be linked permanently.
		/// </summary>
		/// <remarks>
		/// The new links between the
		/// provided Sords cannot be deleted.
		/// </remarks>
		public bool linkPermanent
		{
			get
			{
				return linkPermanentValue;
			}
			set
			{
				this.linkPermanentValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool linkPermanentValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1427691295L;		
	} // end class
}  // end namespace

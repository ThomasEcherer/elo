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
	/// Constants for linkSord(...).
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class LinkSordC : BSerializable
	{
	
		#region Constructors
		
		public LinkSordC() {
		}		
		
		public LinkSordC(EloixClient.IndexServer.LinkSordZ @NOTHING) {
			this.NOTHINGValue = @NOTHING;
		}		
		
		public LinkSordC(LinkSordC rhs)
		{
			this.NOTHINGValue = rhs.NOTHINGValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Used as standard in linkSord(...).
		/// </summary>
		public EloixClient.IndexServer.LinkSordZ NOTHING
		{
			get
			{
				return NOTHINGValue;
			}
			set
			{
				this.NOTHINGValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.LinkSordZ NOTHINGValue;

		/// <summary>
		/// Link Sord objects in PAIR.
		/// </summary>
		public readonly static EloixClient.IndexServer.LinkSordZ PAIR = new LinkSordZ(0L);

		/// <summary>
		/// Link each Sord to each other Sord.
		/// </summary>
		public readonly static EloixClient.IndexServer.LinkSordZ CROSS_LINK = new LinkSordZ(1L);

		#endregion
		
		
		public static readonly long serialVersionUID = 4981037L;		
	} // end class
}  // end namespace

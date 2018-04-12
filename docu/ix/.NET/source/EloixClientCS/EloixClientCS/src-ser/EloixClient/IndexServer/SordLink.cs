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
	/// This class represents a link to an archive entry.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class SordLink : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SordLink() {
		}		
		
		public SordLink(String @id, String @linkId, bool @permanent) {
			this.idValue = @id;
			this.linkIdValue = @linkId;
			this.permanentValue = @permanent;
		}		
		
		public SordLink(SordLink rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.linkIdValue = rhs.linkIdValue;
			this.permanentValue = rhs.permanentValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Numerical ID of referenced Sord.
		/// </summary>
		public String id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(SordLinkC.mbId);
			}
		}
		
		
		/// <summary>
		/// Link ID.
		/// </summary>
		public String linkId
		{
			get
			{
				return linkIdValue;
			}
			set
			{
				this.linkIdValue = value;
				setChangedMember(SordLinkC.mbLinkId);
			}
		}
		
		
		/// <summary>
		/// True, if this SordLink is permanent.
		/// </summary>
		/// <remarks>
		/// Permanent links between Sords cannot
		/// be deleted.
		/// </remarks>
		public bool permanent
		{
			get
			{
				return permanentValue;
			}
			set
			{
				this.permanentValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String idValue;

		protected String linkIdValue;

		protected bool permanentValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 200815802L;		
	} // end class
}  // end namespace

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
	/// Version information for a workflow template.
	/// </summary>
	public class WFVersion : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFVersion() {
		}		
		
		public WFVersion(int @id, String @comment, int @userId, String @userName, String @version, String @createDateIso) {
			this.idValue = @id;
			this.commentValue = @comment;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
			this.versionValue = @version;
			this.createDateIsoValue = @createDateIso;
		}		
		
		public WFVersion(WFVersion rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.commentValue = rhs.commentValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
			this.versionValue = rhs.versionValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Version ID.
		/// </summary>
		/// <remarks>
		/// Set this member -1, to check in a new workflow template version.
		/// A value of 0 indicates the current working version.
		/// </remarks>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// Version comment.
		/// </summary>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the user who created the version.
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Name of the user who created the version.
		/// </summary>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Version number.
		/// </summary>
		public String version
		{
			get
			{
				return versionValue;
			}
			set
			{
				this.versionValue = value;
			}
		}
		
		
		/// <summary>
		/// Create date in ISO format.
		/// </summary>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String commentValue;

		protected int userIdValue;

		protected String userNameValue;

		protected String versionValue;

		protected String createDateIsoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 914434915L;		
	} // end class
}  // end namespace

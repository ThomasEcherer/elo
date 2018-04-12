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
	/// Constants for WFVersion
	/// </summary>
	public class WFVersionC : BSerializable
	{
	
		#region Constructors
		
		public WFVersionC() {
		}		
		
		public WFVersionC(int @lnComment, int @lnVersion) {
			this.lnCommentValue = @lnComment;
			this.lnVersionValue = @lnVersion;
		}		
		
		public WFVersionC(WFVersionC rhs)
		{
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnVersionValue = rhs.lnVersionValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Length of WFVersion.comment.
		/// </summary>
		public int lnComment
		{
			get
			{
				return lnCommentValue;
			}
			set
			{
				this.lnCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// Length of WFVersion.version.
		/// </summary>
		public int lnVersion
		{
			get
			{
				return lnVersionValue;
			}
			set
			{
				this.lnVersionValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int lnCommentValue;

		protected int lnVersionValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1378592156L;		
	} // end class
}  // end namespace

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
	/// This class describes the files to select from a postbox directory or
	/// from a configuration directory.
	/// </summary>
	public class FindConfigFileInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindConfigFileInfo() {
		}		
		
		public FindConfigFileInfo(String[] @names, bool @inclDeputy, String @postboxUserId) {
			this.namesValue = @names;
			this.inclDeputyValue = @inclDeputy;
			this.postboxUserIdValue = @postboxUserId;
		}		
		
		public FindConfigFileInfo(FindConfigFileInfo rhs) : base(rhs)
		{
			this.namesValue = rhs.namesValue;
			this.inclDeputyValue = rhs.inclDeputyValue;
			this.postboxUserIdValue = rhs.postboxUserIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Find files with this names or in this directory.
		/// </summary>
		/// <remarks>
		/// To specify a directory, put the directory name into names[.] and append "/*".
		/// If this member is set, <code>inclDeputy</code> and <code>postboxUserId</code> is ignored.
		/// </remarks>
		public String[] names
		{
			get
			{
				return namesValue;
			}
			set
			{
				this.namesValue = value;
			}
		}
		
		
		/// <summary>
		/// Find files in the in-tray folder of all deputized users.
		/// </summary>
		/// <remarks>
		/// This member is ignored, if <code>names</code> is set.
		/// </remarks>
		public bool inclDeputy
		{
			get
			{
				return inclDeputyValue;
			}
			set
			{
				this.inclDeputyValue = value;
			}
		}
		
		
		/// <summary>
		/// Find files in the in-tray of the user specified by ID or name.
		/// </summary>
		/// <remarks>
		/// This member is ignored, if <code>names</code> is set.
		/// If neither <code>names</code> nor <code>postboxUserId</code> is set, the
		/// in-tray of the current user is listed.
		/// </remarks>
		public String postboxUserId
		{
			get
			{
				return postboxUserIdValue;
			}
			set
			{
				this.postboxUserIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] namesValue;

		protected bool inclDeputyValue;

		protected String postboxUserIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1887106523L;		
	} // end class
}  // end namespace

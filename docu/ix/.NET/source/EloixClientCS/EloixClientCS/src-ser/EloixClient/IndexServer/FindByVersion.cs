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
	/// This class holds additional information for FindInfo, in order to restrict
	/// a search using the document history (version).
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class FindByVersion : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByVersion() {
		}		
		
		public FindByVersion(String @versionComment, String @versionMD5, String @versionNumber, bool @workVersionOnly) {
			this.versionCommentValue = @versionComment;
			this.versionMD5Value = @versionMD5;
			this.versionNumberValue = @versionNumber;
			this.workVersionOnlyValue = @workVersionOnly;
		}		
		
		public FindByVersion(FindByVersion rhs) : base(rhs)
		{
			this.versionCommentValue = rhs.versionCommentValue;
			this.versionMD5Value = rhs.versionMD5Value;
			this.versionNumberValue = rhs.versionNumberValue;
			this.workVersionOnlyValue = rhs.workVersionOnlyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// User defined version description.
		/// </summary>
		/// <remarks>
		/// The wildcard * is allowed,
		/// it matches any number of characters.
		/// </remarks>
		public String versionComment
		{
			get
			{
				return versionCommentValue;
			}
			set
			{
				this.versionCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// The md5 Hash value for the file.
		/// </summary>
		public String versionMD5
		{
			get
			{
				return versionMD5Value;
			}
			set
			{
				this.versionMD5Value = value;
			}
		}
		
		
		/// <summary>
		/// User defined version number or version id.
		/// </summary>
		/// <remarks>
		/// The wildcard * is allowed,
		/// it matches any number of characters.
		/// </remarks>
		public String versionNumber
		{
			get
			{
				return versionNumberValue;
			}
			set
			{
				this.versionNumberValue = value;
			}
		}
		
		
		/// <summary>
		/// Optional flag to restrict the search to active versions only.
		/// </summary>
		public bool workVersionOnly
		{
			get
			{
				return workVersionOnlyValue;
			}
			set
			{
				this.workVersionOnlyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String versionCommentValue;

		protected String versionMD5Value;

		protected String versionNumberValue;

		protected bool workVersionOnlyValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 925953882L;		
	} // end class
}  // end namespace

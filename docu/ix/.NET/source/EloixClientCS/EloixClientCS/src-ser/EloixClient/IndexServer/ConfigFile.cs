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
	/// Used for accessing directories or files on the server.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ConfigFile : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ConfigFile() {
		}		
		
		public ConfigFile(String @dir, EloixClient.IndexServer.FileData @fileData, bool @isDirectory, String @lastModifiedISO, String @name, long @size, String @uploadResult, String @url) {
			this.dirValue = @dir;
			this.fileDataValue = @fileData;
			this.isDirectoryValue = @isDirectory;
			this.lastModifiedISOValue = @lastModifiedISO;
			this.nameValue = @name;
			this.sizeValue = @size;
			this.uploadResultValue = @uploadResult;
			this.urlValue = @url;
		}		
		
		public ConfigFile(ConfigFile rhs) : base(rhs)
		{
			this.dirValue = rhs.dirValue;
			this.fileDataValue = rhs.fileDataValue;
			this.isDirectoryValue = rhs.isDirectoryValue;
			this.lastModifiedISOValue = rhs.lastModifiedISOValue;
			this.nameValue = rhs.nameValue;
			this.sizeValue = rhs.sizeValue;
			this.uploadResultValue = rhs.uploadResultValue;
			this.urlValue = rhs.urlValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The path to the file.
		/// </summary>
		public String dir
		{
			get
			{
				return dirValue;
			}
			set
			{
				this.dirValue = value;
			}
		}
		
		
		/// <summary>
		/// The content of the file.
		/// </summary>
		public EloixClient.IndexServer.FileData fileData
		{
			get
			{
				return fileDataValue;
			}
			set
			{
				this.fileDataValue = value;
				setChangedMember(ConfigFileC.mbFileData);
			}
		}
		
		
		/// <summary>
		/// Returns true if the object is a directory, false if it is a file.
		/// </summary>
		public bool isDirectory
		{
			get
			{
				return isDirectoryValue;
			}
			set
			{
				this.isDirectoryValue = value;
			}
		}
		
		
		/// <summary>
		/// The last-modified date of the script file.
		/// </summary>
		/// <remarks>
		/// This value is related to the UTC time-zone.
		/// </remarks>
		public String lastModifiedISO
		{
			get
			{
				return lastModifiedISOValue;
			}
			set
			{
				this.lastModifiedISOValue = value;
			}
		}
		
		
		/// <summary>
		/// The name of the file or the extension.
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
				setChangedMember(ConfigFileC.mbName);
			}
		}
		
		
		/// <summary>
		/// File size.
		/// </summary>
		public long size
		{
			get
			{
				return sizeValue;
			}
			set
			{
				this.sizeValue = value;
				setChangedMember(ConfigFileC.mbSize);
			}
		}
		
		
		/// <summary>
		/// HTTP-Response returned when file is uploaded.
		/// </summary>
		public String uploadResult
		{
			get
			{
				return uploadResultValue;
			}
			set
			{
				this.uploadResultValue = value;
			}
		}
		
		
		/// <summary>
		/// Download or upload URL.
		/// </summary>
		public String url
		{
			get
			{
				return urlValue;
			}
			set
			{
				this.urlValue = value;
				setChangedMember(ConfigFileC.mbUrl);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String dirValue;

		protected EloixClient.IndexServer.FileData fileDataValue;

		protected bool isDirectoryValue;

		protected String lastModifiedISOValue;

		protected String nameValue;

		protected long sizeValue;

		protected String uploadResultValue;

		protected String urlValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 582012382L;		
	} // end class
}  // end namespace

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
	/// This class contains additional information for image stamps.
	/// </summary>
	public class NoteImage : BSerializable
	{
	
		#region Constructors
		
		public NoteImage() {
		}		
		
		public NoteImage(String @fileName, EloixClient.IndexServer.FileData @fileData) {
			this.fileNameValue = @fileName;
			this.fileDataValue = @fileData;
		}		
		
		public NoteImage(NoteImage rhs)
		{
			this.fileNameValue = rhs.fileNameValue;
			this.fileDataValue = rhs.fileDataValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Image file name.
		/// </summary>
		public String fileName
		{
			get
			{
				return fileNameValue;
			}
			set
			{
				this.fileNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Image file content.
		/// </summary>
		/// <remarks>
		/// Read only.
		/// </remarks>
		public EloixClient.IndexServer.FileData fileData
		{
			get
			{
				return fileDataValue;
			}
			set
			{
				this.fileDataValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String fileNameValue;

		protected EloixClient.IndexServer.FileData fileDataValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1753613701L;		
	} // end class
}  // end namespace

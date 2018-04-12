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
	/// Class for the data contained in a file.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2004
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class FileData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FileData() {
		}		
		
		public FileData(String @contentType, byte[] @data, System.IO.Stream @stream) {
			this.contentTypeValue = @contentType;
			this.dataValue = @data;
			this.streamValue = @stream;
		}		
		
		public FileData(FileData rhs) : base(rhs)
		{
			this.contentTypeValue = rhs.contentTypeValue;
			this.dataValue = rhs.dataValue;
			this.streamValue = rhs.streamValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// MIME-Type/document extension, for example text/xml or image/tiff or txt.
		/// </summary>
		public String contentType
		{
			get
			{
				return contentTypeValue;
			}
			set
			{
				this.contentTypeValue = value;
				setChangedMember(FileDataC.mbContentType);
			}
		}
		
		
		/// <summary>
		/// File data as byte array.
		/// </summary>
		public byte[] data
		{
			get
			{
				return dataValue;
			}
			set
			{
				this.dataValue = value;
				setChangedMember(FileDataC.mbData);
			}
		}
		
		
		/// <summary>
		/// File data as input stream.
		/// </summary>
		/// <remarks>
		/// This member can only be used if the FileData object is a member of
		/// {@link MapValue} or {@link DocVersion}.
		/// </remarks>
		public System.IO.Stream stream
		{
			get
			{
				return streamValue;
			}
			set
			{
				this.streamValue = value;
				setChangedMember(FileDataC.mbStream);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String contentTypeValue;

		protected byte[] dataValue;

		protected System.IO.Stream streamValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 888671717L;		
	} // end class
}  // end namespace

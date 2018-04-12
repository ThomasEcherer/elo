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
	/// This class contains the informations about an OCR result.
	/// </summary>
	public class OcrResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrResult() {
		}		
		
		public OcrResult(long @eventId, String @exception, int @exceptionID, EloixClient.IndexServer.OcrResultRecognizeFile @recognizeFile, EloixClient.IndexServer.OcrResultQueryLanguages @queryLanguages) {
			this.eventIdValue = @eventId;
			this.exceptionValue = @exception;
			this.exceptionIDValue = @exceptionID;
			this.recognizeFileValue = @recognizeFile;
			this.queryLanguagesValue = @queryLanguages;
		}		
		
		public OcrResult(OcrResult rhs) : base(rhs)
		{
			this.eventIdValue = rhs.eventIdValue;
			this.exceptionValue = rhs.exceptionValue;
			this.exceptionIDValue = rhs.exceptionIDValue;
			this.recognizeFileValue = rhs.recognizeFileValue;
			this.queryLanguagesValue = rhs.queryLanguagesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Event ID.
		/// </summary>
		/// <remarks>
		/// The same value as submitted in {@link OcrInfo#eventId}.
		/// </remarks>
		public long eventId
		{
			get
			{
				return eventIdValue;
			}
			set
			{
				this.eventIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Error message.
		/// </summary>
		/// <remarks>
		/// Null or empty, if no error has occurred.
		/// This value is used only in asynchronous processing in order to inform the client application,
		/// that an error has occured. In synchronous processing, the error is thrown as an exception.
		/// </remarks>
		public String exception
		{
			get
			{
				return exceptionValue;
			}
			set
			{
				this.exceptionValue = value;
			}
		}
		
		
		/// <summary>
		/// Error id.
		/// 0, if no error has occurred
		/// </summary>
		public int exceptionID
		{
			get
			{
				return exceptionIDValue;
			}
			set
			{
				this.exceptionIDValue = value;
			}
		}
		
		
		/// <summary>
		/// Recognize file result.
		/// </summary>
		/// <remarks>
		/// This member is returned, if {@link OcrInfo#recognizeFile} was set.
		/// </remarks>
		public EloixClient.IndexServer.OcrResultRecognizeFile recognizeFile
		{
			get
			{
				return recognizeFileValue;
			}
			set
			{
				this.recognizeFileValue = value;
			}
		}
		
		
		/// <summary>
		/// Supported languages.
		/// </summary>
		/// <remarks>
		/// This member is returned, if {@link OcrInfo#queryLanguages} was set.
		/// </remarks>
		public EloixClient.IndexServer.OcrResultQueryLanguages queryLanguages
		{
			get
			{
				return queryLanguagesValue;
			}
			set
			{
				this.queryLanguagesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long eventIdValue;

		protected String exceptionValue;

		protected int exceptionIDValue;

		protected EloixClient.IndexServer.OcrResultRecognizeFile recognizeFileValue;

		protected EloixClient.IndexServer.OcrResultQueryLanguages queryLanguagesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 998509414L;		
	} // end class
}  // end namespace

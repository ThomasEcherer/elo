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
	/// This class defines the properties of an OCR request.
	/// </summary>
	public class OcrInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrInfo() {
		}		
		
		public OcrInfo(long @busId, long @eventId, int @messagesLanguage, EloixClient.IndexServer.OcrInfoRecognizeFile @recognizeFile, EloixClient.IndexServer.OcrInfoQueryLanguages @queryLanguages) {
			this.busIdValue = @busId;
			this.eventIdValue = @eventId;
			this.messagesLanguageValue = @messagesLanguage;
			this.recognizeFileValue = @recognizeFile;
			this.queryLanguagesValue = @queryLanguages;
		}		
		
		public OcrInfo(OcrInfo rhs) : base(rhs)
		{
			this.busIdValue = rhs.busIdValue;
			this.eventIdValue = rhs.eventIdValue;
			this.messagesLanguageValue = rhs.messagesLanguageValue;
			this.recognizeFileValue = rhs.recognizeFileValue;
			this.queryLanguagesValue = rhs.queryLanguagesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Return OCR result over this event bus.
		/// </summary>
		/// <remarks>
		/// If the OCR request should be performed asynchronously,
		/// this value must contain the event bus ID on which the result event is sent.
		/// If this value is 0, the OCR request is performed synchronously.
		/// </remarks>
		public long busId
		{
			get
			{
				return busIdValue;
			}
			set
			{
				this.busIdValue = value;
			}
		}
		
		
		/// <summary>
		/// OCR result should be sent in an event with this event ID.
		/// </summary>
		/// <remarks>
		/// This member helps to map the OCR request to the OCR result.
		/// Optional.
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
		/// Language of error messages produced by the OCR engine.
		/// </summary>
		/// <remarks>
		/// One of the OcrInfoC.MESSAGES_LANGUAGE_ constants.
		/// Optional.
		/// </remarks>
		public int messagesLanguage
		{
			get
			{
				return messagesLanguageValue;
			}
			set
			{
				this.messagesLanguageValue = value;
			}
		}
		
		
		/// <summary>
		/// Recognize file information.
		/// </summary>
		/// <remarks>
		/// Set this member in order to process OCR on a file or an archive document.
		/// Optional.
		/// </remarks>
		public EloixClient.IndexServer.OcrInfoRecognizeFile recognizeFile
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
		/// This member is set in order to query the languages supported by the OCR engine.
		/// </summary>
		/// <remarks>
		/// Optional.
		/// </remarks>
		public EloixClient.IndexServer.OcrInfoQueryLanguages queryLanguages
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
		
		protected long busIdValue;

		protected long eventIdValue;

		protected int messagesLanguageValue;

		protected EloixClient.IndexServer.OcrInfoRecognizeFile recognizeFileValue;

		protected EloixClient.IndexServer.OcrInfoQueryLanguages queryLanguagesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1803060225L;		
	} // end class
}  // end namespace

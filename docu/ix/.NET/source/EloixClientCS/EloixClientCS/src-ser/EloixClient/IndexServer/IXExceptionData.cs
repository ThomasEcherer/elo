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
	/// This class describes an exception that can occur during the execution of an
	/// Index server function.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class IXExceptionData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public IXExceptionData() {
		}		
		
		public IXExceptionData(String @callId, String @details, int @exceptionType, String @message, String @ticket) {
			this.callIdValue = @callId;
			this.detailsValue = @details;
			this.exceptionTypeValue = @exceptionType;
			this.messageValue = @message;
			this.ticketValue = @ticket;
		}		
		
		public IXExceptionData(IXExceptionData rhs) : base(rhs)
		{
			this.callIdValue = rhs.callIdValue;
			this.detailsValue = rhs.detailsValue;
			this.exceptionTypeValue = rhs.exceptionTypeValue;
			this.messageValue = rhs.messageValue;
			this.ticketValue = rhs.ticketValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// String containing the ClientInfo.callId for the ClientInfo object.
		/// </summary>
		/// <remarks>
		/// This is
		/// given to the function which triggered/caused the error.
		/// </remarks>
		public String callId
		{
			get
			{
				return callIdValue;
			}
			set
			{
				this.callIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Detail text for the exception.
		/// </summary>
		public String details
		{
			get
			{
				return detailsValue;
			}
			set
			{
				this.detailsValue = value;
			}
		}
		
		
		/// <summary>
		/// This is the type of exception.
		/// </summary>
		/// <remarks>
		/// This is one of the constants from IXExceptionC.
		/// </remarks>
		public int exceptionType
		{
			get
			{
				return exceptionTypeValue;
			}
			set
			{
				this.exceptionTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// The error message text for the exception.
		/// </summary>
		public String message
		{
			get
			{
				return messageValue;
			}
			set
			{
				this.messageValue = value;
			}
		}
		
		
		/// <summary>
		/// Ticket given to the function.
		/// </summary>
		public String ticket
		{
			get
			{
				return ticketValue;
			}
			set
			{
				this.ticketValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String callIdValue;

		protected String detailsValue;

		protected int exceptionTypeValue;

		protected String messageValue;

		protected String ticketValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 784089396L;		
	} // end class
}  // end namespace

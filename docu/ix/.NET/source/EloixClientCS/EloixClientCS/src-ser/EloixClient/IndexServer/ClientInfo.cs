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
	/// Contains the session ticket and the users language and country.
	/// </summary>
	/// <remarks>
	/// Each
	/// IndexServer interface function, except the login, requires a <code>ClientInfo</code>
	/// object as parameter with a valid session ticket.
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ClientInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ClientInfo() {
		}		
		
		public ClientInfo(String @callId, String @country, String @language, String @ticket, String @timeZone, int @options) {
			this.callIdValue = @callId;
			this.countryValue = @country;
			this.languageValue = @language;
			this.ticketValue = @ticket;
			this.timeZoneValue = @timeZone;
			this.optionsValue = @options;
		}		
		
		public ClientInfo(ClientInfo rhs) : base(rhs)
		{
			this.callIdValue = rhs.callIdValue;
			this.countryValue = rhs.countryValue;
			this.languageValue = rhs.languageValue;
			this.ticketValue = rhs.ticketValue;
			this.timeZoneValue = rhs.timeZoneValue;
			this.optionsValue = rhs.optionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// This string is used for debugging purposes only.
		/// </summary>
		/// <remarks>
		/// It is displayed in error messages and reports.
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
		/// Country in ISO 3166 format - this is the country for the ELO Client.
		/// </summary>
		/// <remarks>
		/// <table border="2" summary=""><tr></tr>
		/// <tr><td>CZ</td><td>Czeach Republic</td></tr>
		/// <tr><td>FR</td><td>France</td></tr>
		/// <tr><td>DE</td><td>Germany</td></tr>
		/// <tr><td>GR</td><td>Greece</td></tr>
		/// <tr><td>ES</td><td>Spain</td></tr>
		/// <tr><td>PL</td><td>Poland</td></tr>
		/// <tr><td>GB</td><td>United Kingdom</td></tr>
		/// <tr><td>US</td><td>United States</td></tr>
		/// </table>
		/// </remarks>
		public String country
		{
			get
			{
				return countryValue;
			}
			set
			{
				this.countryValue = value;
			}
		}
		
		
		/// <summary>
		/// The users language in ISO 639 format.
		/// </summary>
		/// <remarks>
		/// Exception messages will be supplied in this language.
		/// <table border="2" summary=""><tr></tr>
		/// <tr><td>cs</td><td>Czech</td></tr>
		/// <tr><td>de</td><td>German</td></tr>
		/// <tr><td>el</td><td>Greek</td></tr>
		/// <tr><td>en</td><td>English</td></tr>
		/// <tr><td>es</td><td>Spanish</td></tr>
		/// <tr><td>fr</td><td>French</td></tr>
		/// <tr><td>pl</td><td>Polish</td></tr>
		/// </table>
		/// Only languages for which the localisations of the IndexServer resources exist
		/// can be selected, otherwise the messages are displayed in the default language.
		/// </remarks>
		public String language
		{
			get
			{
				return languageValue;
			}
			set
			{
				this.languageValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>This is the session ID in the communication between the client and the IndexServer.
		/// </summary>
		/// <remarks>
		/// It has a limited lifetime. The lifetime can be configured at the ELOAM
		/// (access manager server). The IndexServer returns a valid ticket if the
		/// IXServicePortIF.login call succeeds. The lifetime of the ticket can be extended by calling
		/// IXServicePortIF.alive. </p>
		/// </remarks>
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
		
		
		/// <summary>
		/// The time zone for the ELO client.
		/// </summary>
		/// <remarks>
		/// Can be one of the predefined time zone IDs in the Java platform or a string
		/// of format "GMT" + sign + hh + ":" + mm.
		/// </remarks>
		public String timeZone
		{
			get
			{
				return timeZoneValue;
			}
			set
			{
				this.timeZoneValue = value;
			}
		}
		
		
		/// <summary>
		/// Internal use only.
		/// </summary>
		/// <remarks>
		/// Bit 0 of this member is set for requests that are send from one Indexserver instance to
		/// another instance in load balancing scenarios.
		/// </remarks>
		public int options
		{
			get
			{
				return optionsValue;
			}
			set
			{
				this.optionsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String callIdValue;

		protected String countryValue;

		protected String languageValue;

		protected String ticketValue;

		protected String timeZoneValue;

		protected int optionsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1258190913L;		
	} // end class
}  // end namespace

//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class ActionHistory : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ActionHistory() {
		}		
		
		public ActionHistory(String @actionGuid, String @createDateIso, String @text) {
			this.actionGuidValue = @actionGuid;
			this.createDateIsoValue = @createDateIso;
			this.textValue = @text;
		}		
		
		public ActionHistory(ActionHistory rhs) : base(rhs)
		{
			this.actionGuidValue = rhs.actionGuidValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.textValue = rhs.textValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Action GUID.
		/// </summary>
		/// <remarks>
		/// Unique identifier.
		/// </remarks>
		public String actionGuid
		{
			get
			{
				return actionGuidValue;
			}
			set
			{
				this.actionGuidValue = value;
				setChangedMember(ActionHistoryC.mbActionGuid);
			}
		}
		
		
		/// <summary>
		/// Create date.
		/// </summary>
		/// <remarks>
		/// This element is the ISO formatted create date of the action in the time zone of the client application.
		/// In order to convert this value into a date object, invoke function {@link de.elo.ix.client.IXConnection#isoToDate}.
		/// </remarks>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
				setChangedMember(ActionHistoryC.mbCreateDateIso);
			}
		}
		
		
		/// <summary>
		/// Comment text.
		/// </summary>
		/// <remarks>
		/// This element is only valid for {@link EActionType#UserComment},
		/// and {@link EActionType#AutoComment}.
		/// </remarks>
		public String text
		{
			get
			{
				return textValue;
			}
			set
			{
				this.textValue = value;
				setChangedMember(ActionHistoryC.mbText);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String actionGuidValue;

		protected String createDateIsoValue;

		protected String textValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 598833764L;		
	} // end class
}  // end namespace

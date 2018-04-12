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
	/// This class describes a report/protocol entry for an action carried out in
	/// the archive.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ReportInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReportInfo() {
		}		
		
		public ReportInfo(int @actTime, int @actionNo, int @extra1, int @extra2, String @id, int @objId, int @sessionNo, String @text, int @userId, String @actTimeISO, String @action, String @comment, String @userName, String @extra3, Object @extraInfo) {
			this.actTimeValue = @actTime;
			this.actionNoValue = @actionNo;
			this.extra1Value = @extra1;
			this.extra2Value = @extra2;
			this.idValue = @id;
			this.objIdValue = @objId;
			this.sessionNoValue = @sessionNo;
			this.textValue = @text;
			this.userIdValue = @userId;
			this.actTimeISOValue = @actTimeISO;
			this.actionValue = @action;
			this.commentValue = @comment;
			this.userNameValue = @userName;
			this.extra3Value = @extra3;
			this.extraInfoValue = @extraInfo;
		}		
		
		public ReportInfo(ReportInfo rhs) : base(rhs)
		{
			this.actTimeValue = rhs.actTimeValue;
			this.actionNoValue = rhs.actionNoValue;
			this.extra1Value = rhs.extra1Value;
			this.extra2Value = rhs.extra2Value;
			this.idValue = rhs.idValue;
			this.objIdValue = rhs.objIdValue;
			this.sessionNoValue = rhs.sessionNoValue;
			this.textValue = rhs.textValue;
			this.userIdValue = rhs.userIdValue;
			this.actTimeISOValue = rhs.actTimeISOValue;
			this.actionValue = rhs.actionValue;
			this.commentValue = rhs.commentValue;
			this.userNameValue = rhs.userNameValue;
			this.extra3Value = rhs.extra3Value;
			this.extraInfoValue = rhs.extraInfoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Reserved - internal function.
		/// </summary>
		public int actTime
		{
			get
			{
				return actTimeValue;
			}
			set
			{
				this.actTimeValue = value;
				setChangedMember(ReportInfoC.mbActTimeISO);
			}
		}
		
		
		/// <summary>
		/// Action number in numeric form.
		/// </summary>
		public int actionNo
		{
			get
			{
				return actionNoValue;
			}
			set
			{
				this.actionNoValue = value;
				setChangedMember(ReportInfoC.mbActionNo);
			}
		}
		
		
		/// <summary>
		/// Reserved - internal,  dependant on actionNo.
		/// </summary>
		public int extra1
		{
			get
			{
				return extra1Value;
			}
			set
			{
				this.extra1Value = value;
				setChangedMember(ReportInfoC.mbExtra1);
			}
		}
		
		
		/// <summary>
		/// Reserved - internal,  dependant on actionNo
		/// </summary>
		public int extra2
		{
			get
			{
				return extra2Value;
			}
			set
			{
				this.extra2Value = value;
				setChangedMember(ReportInfoC.mbExtra2);
			}
		}
		
		
		/// <summary>
		/// Identifier
		/// </summary>
		public String id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(ReportInfoC.mbId);
			}
		}
		
		
		/// <summary>
		/// Id of the object for which the action is entered in the protocoll.
		/// </summary>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(ReportInfoC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// Id of the session which carried out the action.
		/// </summary>
		public int sessionNo
		{
			get
			{
				return sessionNoValue;
			}
			set
			{
				this.sessionNoValue = value;
				setChangedMember(ReportInfoC.mbSessionNo);
			}
		}
		
		
		/// <summary>
		/// Reserved - internal,  dependant on actionNo
		/// </summary>
		public String text
		{
			get
			{
				return textValue;
			}
			set
			{
				this.textValue = value;
				setChangedMember(ReportInfoC.mbText);
			}
		}
		
		
		/// <summary>
		/// Id of the user who carried out the action.
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
				setChangedMember(ReportInfoC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// Time of the action in ISO format.
		/// </summary>
		public String actTimeISO
		{
			get
			{
				return actTimeISOValue;
			}
			set
			{
				this.actTimeISOValue = value;
				setChangedMember(ReportInfoC.mbActTimeISO);
			}
		}
		
		
		/// <summary>
		/// ActionNo as name.
		/// </summary>
		public String action
		{
			get
			{
				return actionValue;
			}
			set
			{
				this.actionValue = value;
				setChangedMember(ReportInfoC.mbAction);
			}
		}
		
		
		/// <summary>
		/// Descriptive text or details.
		/// </summary>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
				setChangedMember(ReportInfoC.mbComment);
			}
		}
		
		
		/// <summary>
		/// Name of the user who carried out the action.
		/// </summary>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
				setChangedMember(ReportInfoC.mbUserName);
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public String extra3
		{
			get
			{
				return extra3Value;
			}
			set
			{
				this.extra3Value = value;
				setChangedMember(ReportInfoC.mbExtra3);
			}
		}
		
		
		/// <summary>
		/// Extra information.
		/// </summary>
		/// <remarks>
		/// This member is always null for report entries written by Windows-Client or by ELOix versions older than 9.00.016.
		/// The type of data depends on {@link #actionNo} as shown in the following table:
		/// <table>
		/// <tr><td>ReportInfoC.ACT_LOGIN_IX</td><td>{@link ReportInfoUserProps} object, member userInfo is set to the user logged on.</td></tr>
		/// <tr><td>ReportInfoC.ACT_IX_CREATE_USER</td><td>{@link ReportInfoUserModified} object, member newProps is set to the new user.</td></tr>
		/// <tr><td>ReportInfoC.ACT_IX_DELETE_USER</td><td>{@link ReportInfoUserModified} object, member newProps is set to deleted user.</td></tr>
		/// <tr><td>ReportInfoC.ACT_IX_CHECKIN_USER</td>
		/// <td>{@link ReportInfoUserModified} object, member newProps is set to the modified values.
		/// Member oldProps is set to the values before modification.
		/// </td></tr>
		/// </table>
		/// </remarks>
		public Object extraInfo
		{
			get
			{
				return extraInfoValue;
			}
			set
			{
				this.extraInfoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int actTimeValue;

		protected int actionNoValue;

		protected int extra1Value;

		protected int extra2Value;

		protected String idValue;

		protected int objIdValue;

		protected int sessionNoValue;

		protected String textValue;

		protected int userIdValue;

		protected String actTimeISOValue;

		protected String actionValue;

		protected String commentValue;

		protected String userNameValue;

		protected String extra3Value;

		protected Object extraInfoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1280848136L;		
	} // end class
}  // end namespace

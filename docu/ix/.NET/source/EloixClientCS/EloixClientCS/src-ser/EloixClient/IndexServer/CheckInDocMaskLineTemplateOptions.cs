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
	/// Option class for the methode CheckInDocMaskLineTemplate
	/// </summary>
	public class CheckInDocMaskLineTemplateOptions : BSerializable
	{
	
		#region Constructors
		
		public CheckInDocMaskLineTemplateOptions() {
		}		
		
		public CheckInDocMaskLineTemplateOptions(EloixClient.IndexServer.DocMaskLineTemplateZ @dmltZ, bool @onlyModifiedTemplateMembers, bool @keepModifiedLineMembers) {
			this.dmltZValue = @dmltZ;
			this.onlyModifiedTemplateMembersValue = @onlyModifiedTemplateMembers;
			this.keepModifiedLineMembersValue = @keepModifiedLineMembers;
		}		
		
		public CheckInDocMaskLineTemplateOptions(CheckInDocMaskLineTemplateOptions rhs)
		{
			this.dmltZValue = rhs.dmltZValue;
			this.onlyModifiedTemplateMembersValue = rhs.onlyModifiedTemplateMembersValue;
			this.keepModifiedLineMembersValue = rhs.keepModifiedLineMembersValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Specifies which elements are passed to the document mask lines, which are using this template.
		/// </summary>
		public EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ
		{
			get
			{
				return dmltZValue;
			}
			set
			{
				this.dmltZValue = value;
			}
		}
		
		
		/// <summary>
		/// Only change template members are passed to the document mask lines, which are using this template.
		/// </summary>
		/// <remarks>
		/// This variable is ignored if dmltZ does not equal NULL.
		/// </remarks>
		public bool onlyModifiedTemplateMembers
		{
			get
			{
				return onlyModifiedTemplateMembersValue;
			}
			set
			{
				this.onlyModifiedTemplateMembersValue = value;
			}
		}
		
		
		/// <summary>
		/// Modified line members in the table masklines are kept.
		/// </summary>
		public bool keepModifiedLineMembers
		{
			get
			{
				return keepModifiedLineMembersValue;
			}
			set
			{
				this.keepModifiedLineMembersValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.DocMaskLineTemplateZ dmltZValue;

		protected bool onlyModifiedTemplateMembersValue;

		protected bool keepModifiedLineMembersValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1586163042L;		
	} // end class
}  // end namespace

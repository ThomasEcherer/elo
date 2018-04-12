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
	/// This class describes the template information for a stamp.
	/// </summary>
	public class NoteTemplate : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public NoteTemplate() {
		}		
		
		public NoteTemplate(int @id, String @name, String @userId, EloixClient.IndexServer.NoteText @noteText, EloixClient.IndexServer.NoteImage @noteImage, String @acl, EloixClient.IndexServer.AclItem[] @aclItems) {
			this.idValue = @id;
			this.nameValue = @name;
			this.userIdValue = @userId;
			this.noteTextValue = @noteText;
			this.noteImageValue = @noteImage;
			this.aclValue = @acl;
			this.aclItemsValue = @aclItems;
		}		
		
		public NoteTemplate(NoteTemplate rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.userIdValue = rhs.userIdValue;
			this.noteTextValue = rhs.noteTextValue;
			this.noteImageValue = rhs.noteImageValue;
			this.aclValue = rhs.aclValue;
			this.aclItemsValue = rhs.aclItemsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Stamp ID.
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(NoteTemplateC.mbId);
			}
		}
		
		
		/// <summary>
		/// Stamp name.
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
				setChangedMember(NoteTemplateC.mbName);
			}
		}
		
		
		/// <summary>
		/// User ID or name.
		/// </summary>
		/// <remarks>
		/// NoteTemplate objects can be defined for all users and for a specific user.
		/// </remarks>
		public String userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
				setChangedMember(NoteTemplateC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// Text information, if this is a textual stamp.
		/// </summary>
		/// <remarks>
		/// The text information can contain the placeholders defined in NoteTemplateC.
		/// Either noteText or noteImage can be set.
		/// class NoteTemplateC
		/// </remarks>
		public EloixClient.IndexServer.NoteText noteText
		{
			get
			{
				return noteTextValue;
			}
			set
			{
				this.noteTextValue = value;
				setChangedMember(NoteTemplateC.mbNoteText);
			}
		}
		
		
		/// <summary>
		/// Image information, if this is stamp is an image.
		/// </summary>
		/// <remarks>
		/// Either noteText or noteImage can be set.
		/// </remarks>
		public EloixClient.IndexServer.NoteImage noteImage
		{
			get
			{
				return noteImageValue;
			}
			set
			{
				this.noteImageValue = value;
				setChangedMember(NoteTemplateC.mbNoteImage);
			}
		}
		
		
		/// <summary>
		/// ACL.
		/// </summary>
		/// <remarks>
		/// Member aclItems has preceedence on checkin.
		/// </remarks>
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
				setChangedMember(NoteTemplateC.mbAcl);
			}
		}
		
		
		/// <summary>
		/// ACL as an array of AclItem objects.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String nameValue;

		protected String userIdValue;

		protected EloixClient.IndexServer.NoteText noteTextValue;

		protected EloixClient.IndexServer.NoteImage noteImageValue;

		protected String aclValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1995912373L;		
	} // end class
}  // end namespace

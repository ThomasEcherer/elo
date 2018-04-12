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
	/// <p>This helper class inherits all members from <code>NoteData</code> and
	/// adds a static member to access the bit constants for the <code>NoteData</code>
	/// members.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class Note : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Note() {
		}		
		
		public Note(String @TStamp, int @XPos, int @YPos, String @desc, String @guid, int @height, int @id, int @ownerId, int @pageNo, int @type, int @width, String @createDateIso, bool @deleted, int @lockId, String @lockName, String @objId, String @ownerName, String @acl, EloixClient.IndexServer.AclItem[] @aclItems, int @color, EloixClient.IndexServer.NoteText @noteText, EloixClient.IndexServer.NoteImage @noteImage, EloixClient.IndexServer.NoteFreehand @noteFreehand, int @access, String @deleteDateIso, String @TStampSync) {
			this.TStampValue = @TStamp;
			this.XPosValue = @XPos;
			this.YPosValue = @YPos;
			this.descValue = @desc;
			this.guidValue = @guid;
			this.heightValue = @height;
			this.idValue = @id;
			this.ownerIdValue = @ownerId;
			this.pageNoValue = @pageNo;
			this.typeValue = @type;
			this.widthValue = @width;
			this.createDateIsoValue = @createDateIso;
			this.deletedValue = @deleted;
			this.lockIdValue = @lockId;
			this.lockNameValue = @lockName;
			this.objIdValue = @objId;
			this.ownerNameValue = @ownerName;
			this.aclValue = @acl;
			this.aclItemsValue = @aclItems;
			this.colorValue = @color;
			this.noteTextValue = @noteText;
			this.noteImageValue = @noteImage;
			this.noteFreehandValue = @noteFreehand;
			this.accessValue = @access;
			this.deleteDateIsoValue = @deleteDateIso;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public Note(Note rhs) : base(rhs)
		{
			this.TStampValue = rhs.TStampValue;
			this.XPosValue = rhs.XPosValue;
			this.YPosValue = rhs.YPosValue;
			this.descValue = rhs.descValue;
			this.guidValue = rhs.guidValue;
			this.heightValue = rhs.heightValue;
			this.idValue = rhs.idValue;
			this.ownerIdValue = rhs.ownerIdValue;
			this.pageNoValue = rhs.pageNoValue;
			this.typeValue = rhs.typeValue;
			this.widthValue = rhs.widthValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.deletedValue = rhs.deletedValue;
			this.lockIdValue = rhs.lockIdValue;
			this.lockNameValue = rhs.lockNameValue;
			this.objIdValue = rhs.objIdValue;
			this.ownerNameValue = rhs.ownerNameValue;
			this.aclValue = rhs.aclValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.colorValue = rhs.colorValue;
			this.noteTextValue = rhs.noteTextValue;
			this.noteImageValue = rhs.noteImageValue;
			this.noteFreehandValue = rhs.noteFreehandValue;
			this.accessValue = rhs.accessValue;
			this.deleteDateIsoValue = rhs.deleteDateIsoValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Timestamp of the last change to the note.
		/// </summary>
		/// <remarks>
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(NoteC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// The position in the x axis when the note is displayed on a document in ELO.
		/// </summary>
		/// <remarks>
		/// Taken from the top left corner of the document.
		/// <p>
		/// For NoteC.TYPE_ANNOTATION_FREEHAND and NoteC.TYPE_ANNOTATION_HORIZONTAL_LINE
		/// the values XPos, YPos, Width, Height describe the enveloping rectangle
		/// of the line including the line width. This values are computed by the IndexServer
		/// if the note is stored.
		/// </p>
		/// </remarks>
		public int XPos
		{
			get
			{
				return XPosValue;
			}
			set
			{
				this.XPosValue = value;
				setChangedMember(NoteC.mbXPos);
			}
		}
		
		
		/// <summary>
		/// The position in the Y axis when the note is displayed on a document in ELO.
		/// </summary>
		/// <remarks>
		/// Taken from the top left corner of the document.
		/// </remarks>
		public int YPos
		{
			get
			{
				return YPosValue;
			}
			set
			{
				this.YPosValue = value;
				setChangedMember(NoteC.mbYPos);
			}
		}
		
		
		/// <summary>
		/// The text for the note.
		/// </summary>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
				setChangedMember(NoteC.mbDesc);
			}
		}
		
		
		/// <summary>
		/// The GUID for the note.
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(NoteC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// The height of the note (y axis), when displayed on a document in ELO.
		/// </summary>
		public int height
		{
			get
			{
				return heightValue;
			}
			set
			{
				this.heightValue = value;
				setChangedMember(NoteC.mbHeight);
			}
		}
		
		
		/// <summary>
		/// The unique id for the note.
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
				setChangedMember(NoteC.mbId);
			}
		}
		
		
		/// <summary>
		/// The ID of the user who created the note.
		/// </summary>
		/// <remarks>
		/// Administrators can set the ownerId to an arbitary user ID in checkinNotes.
		/// Set ownerName=&quot;&quot; in this case.
		/// </remarks>
		public int ownerId
		{
			get
			{
				return ownerIdValue;
			}
			set
			{
				this.ownerIdValue = value;
				setChangedMember(NoteC.mbOwnerId);
			}
		}
		
		
		/// <summary>
		/// The page number to which the note is attached.
		/// </summary>
		public int pageNo
		{
			get
			{
				return pageNoValue;
			}
			set
			{
				this.pageNoValue = value;
				setChangedMember(NoteC.mbPageNo);
			}
		}
		
		
		/// <summary>
		/// The note type.
		/// </summary>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(NoteC.mbType);
			}
		}
		
		
		/// <summary>
		/// Width ( x axis) of the note when displayed on a document in ELO.
		/// </summary>
		public int width
		{
			get
			{
				return widthValue;
			}
			set
			{
				this.widthValue = value;
				setChangedMember(NoteC.mbWidth);
			}
		}
		
		
		/// <summary>
		/// ISO encoded external (user defined) date.
		/// </summary>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
				setChangedMember(NoteC.mbCreateDateIso);
			}
		}
		
		
		/// <summary>
		/// True if the note is deleted, otherwise false.
		/// </summary>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
				setChangedMember(NoteC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// The ID of the user that holds the lock or -1, if the note is not locked.
		/// </summary>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(NoteC.mbLockId);
			}
		}
		
		
		/// <summary>
		/// The user name that holds the lock or an empty string if the note is not locked.
		/// </summary>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Object ID of the associated Sord object or any of the  ID specifiers that
		/// are valid for checkoutSord too.
		/// </summary>
		/// <remarks>
		/// Functions createNote and checkoutNotes return only numerical object IDs.
		/// </remarks>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(NoteC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// The name of the user that has created the note.
		/// </summary>
		/// <remarks>
		/// Administrators can set the ownerName to an arbitary user name in checkinNotes.
		/// Set ownerId=-1 in this case.
		/// </remarks>
		public String ownerName
		{
			get
			{
				return ownerNameValue;
			}
			set
			{
				this.ownerNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Access control list.
		/// </summary>
		/// <remarks>
		/// Only used for notes of type TYPE_ANNOTATION_MARKER.
		/// Set member aclItems=null on check in otherwise it is ignored.
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
				setChangedMember(NoteC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// Access control list as item array.
		/// </summary>
		/// <remarks>
		/// Only used for notes of type TYPE_ANNOTATION_MARKER.
		/// If this member is not null, member acl is ignored on check in.
		/// </remarks>
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
				setChangedMember(NoteC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// RGB value.
		/// </summary>
		/// <remarks>
		/// Undefined for notes of type TYPE_ANNOTATION_STAMP and TYPE_ANNOTATION_NOTE_WITHFONT.
		/// </remarks>
		public int color
		{
			get
			{
				return colorValue;
			}
			set
			{
				this.colorValue = value;
				setChangedMember(NoteC.mbColor);
			}
		}
		
		
		/// <summary>
		/// Additional information for textual stamps.
		/// </summary>
		/// <remarks>
		/// Valid only for notes of type
		/// TYPE_ANNOTATION_NOTE, TYPE_ANNOTATION_STAMP and TYPE_ANNOTATION_NOTE_WITHFONT.
		/// Either desc, noteText, noteImage or noteFreehand can be set.
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
				setChangedMember(NoteC.mbNoteText);
			}
		}
		
		
		/// <summary>
		/// Additional information for image stamps.
		/// </summary>
		/// <remarks>
		/// Valid only for notes of type TYPE_ANNOTATION_STAMP.
		/// Either desc, noteText, noteImage or noteFreehand can be set.
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
				setChangedMember(NoteC.mbNoteImage);
			}
		}
		
		
		/// <summary>
		/// Point information for a freehand line.
		/// </summary>
		/// <remarks>
		/// Valid only for notes of type TYPE_ANNOTATION_FREEHAND and TYPE_ANNOTATION_HORIZONTAL_LINE.
		/// Either desc, noteText, noteImage or noteFreehand can be set.
		/// </remarks>
		public EloixClient.IndexServer.NoteFreehand noteFreehand
		{
			get
			{
				return noteFreehandValue;
			}
			set
			{
				this.noteFreehandValue = value;
				setChangedMember(NoteC.mbNoteFreehand);
			}
		}
		
		
		/// <summary>
		/// Access rights for the current user.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public int access
		{
			get
			{
				return accessValue;
			}
			set
			{
				this.accessValue = value;
			}
		}
		
		
		/// <summary>
		/// The Note is deleted at this date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>Is undefined if isDeleted() returns false.</p>
		/// </remarks>
		public String deleteDateIso
		{
			get
			{
				return deleteDateIsoValue;
			}
			set
			{
				this.deleteDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(NoteC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String TStampValue;

		protected int XPosValue;

		protected int YPosValue;

		protected String descValue;

		protected String guidValue;

		protected int heightValue;

		protected int idValue;

		protected int ownerIdValue;

		protected int pageNoValue;

		protected int typeValue;

		protected int widthValue;

		protected String createDateIsoValue;

		protected bool deletedValue;

		protected int lockIdValue;

		protected String lockNameValue;

		protected String objIdValue;

		protected String ownerNameValue;

		protected String aclValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected int colorValue;

		protected EloixClient.IndexServer.NoteText noteTextValue;

		protected EloixClient.IndexServer.NoteImage noteImageValue;

		protected EloixClient.IndexServer.NoteFreehand noteFreehandValue;

		protected int accessValue;

		protected String deleteDateIsoValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 937420667L;		
	} // end class
}  // end namespace

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
	/// Structure for the options for the copy-process.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2009
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class CopyOptions : BSerializable
	{
	
		#region Constructors
		
		public CopyOptions() {
		}		
		
		public CopyOptions(String @targetName, int @newParentId, bool @copyOnlyBaseElement, bool @copyStructuresAndDocuments, bool @copyOnlyWorkAttachment, bool @keepOriginalOwner, bool @keepCurrentNotes, bool @inclAttachments, bool @keepOriginalPermissions, bool @takeTargetPermissions, bool @acceptChanges, bool @keepReferences, bool @copyOnlyWorkversion, bool @moveOnly, bool @adjustAclDifference) {
			this.targetNameValue = @targetName;
			this.newParentIdValue = @newParentId;
			this.copyOnlyBaseElementValue = @copyOnlyBaseElement;
			this.copyStructuresAndDocumentsValue = @copyStructuresAndDocuments;
			this.copyOnlyWorkAttachmentValue = @copyOnlyWorkAttachment;
			this.keepOriginalOwnerValue = @keepOriginalOwner;
			this.keepCurrentNotesValue = @keepCurrentNotes;
			this.inclAttachmentsValue = @inclAttachments;
			this.keepOriginalPermissionsValue = @keepOriginalPermissions;
			this.takeTargetPermissionsValue = @takeTargetPermissions;
			this.acceptChangesValue = @acceptChanges;
			this.keepReferencesValue = @keepReferences;
			this.copyOnlyWorkversionValue = @copyOnlyWorkversion;
			this.moveOnlyValue = @moveOnly;
			this.adjustAclDifferenceValue = @adjustAclDifference;
		}		
		
		public CopyOptions(CopyOptions rhs)
		{
			this.targetNameValue = rhs.targetNameValue;
			this.newParentIdValue = rhs.newParentIdValue;
			this.copyOnlyBaseElementValue = rhs.copyOnlyBaseElementValue;
			this.copyStructuresAndDocumentsValue = rhs.copyStructuresAndDocumentsValue;
			this.copyOnlyWorkAttachmentValue = rhs.copyOnlyWorkAttachmentValue;
			this.keepOriginalOwnerValue = rhs.keepOriginalOwnerValue;
			this.keepCurrentNotesValue = rhs.keepCurrentNotesValue;
			this.inclAttachmentsValue = rhs.inclAttachmentsValue;
			this.keepOriginalPermissionsValue = rhs.keepOriginalPermissionsValue;
			this.takeTargetPermissionsValue = rhs.takeTargetPermissionsValue;
			this.acceptChangesValue = rhs.acceptChangesValue;
			this.keepReferencesValue = rhs.keepReferencesValue;
			this.copyOnlyWorkversionValue = rhs.copyOnlyWorkversionValue;
			this.moveOnlyValue = rhs.moveOnlyValue;
			this.adjustAclDifferenceValue = rhs.adjustAclDifferenceValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Name of the target archive element.
		/// </summary>
		public String targetName
		{
			get
			{
				return targetNameValue;
			}
			set
			{
				this.targetNameValue = value;
			}
		}
		
		
		/// <summary>
		/// ParentId of the new element.
		/// </summary>
		public int newParentId
		{
			get
			{
				return newParentIdValue;
			}
			set
			{
				this.newParentIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Copy only the base element.
		/// </summary>
		public bool copyOnlyBaseElement
		{
			get
			{
				return copyOnlyBaseElementValue;
			}
			set
			{
				this.copyOnlyBaseElementValue = value;
			}
		}
		
		
		/// <summary>
		/// Copy all structures with the documents.
		/// </summary>
		public bool copyStructuresAndDocuments
		{
			get
			{
				return copyStructuresAndDocumentsValue;
			}
			set
			{
				this.copyStructuresAndDocumentsValue = value;
			}
		}
		
		
		/// <summary>
		/// If inclAttachments and copyOnlyWorkAttachment are true, copy only the work attachments.
		/// </summary>
		/// <remarks>
		/// Setting
		/// copyOnlyWorkAttachment to true when inclAttachments is false is invalid.
		/// </remarks>
		public bool copyOnlyWorkAttachment
		{
			get
			{
				return copyOnlyWorkAttachmentValue;
			}
			set
			{
				this.copyOnlyWorkAttachmentValue = value;
			}
		}
		
		
		/// <summary>
		/// Keep the original owner of the archive element.
		/// </summary>
		public bool keepOriginalOwner
		{
			get
			{
				return keepOriginalOwnerValue;
			}
			set
			{
				this.keepOriginalOwnerValue = value;
			}
		}
		
		
		/// <summary>
		/// Keep the current documentnotes.
		/// </summary>
		public bool keepCurrentNotes
		{
			get
			{
				return keepCurrentNotesValue;
			}
			set
			{
				this.keepCurrentNotesValue = value;
			}
		}
		
		
		/// <summary>
		/// Also copy all attachments.
		/// </summary>
		public bool inclAttachments
		{
			get
			{
				return inclAttachmentsValue;
			}
			set
			{
				this.inclAttachmentsValue = value;
			}
		}
		
		
		/// <summary>
		/// Keep the current permissions.
		/// </summary>
		/// <remarks>
		/// Only one of the three options keepOriginalPermissions, takeTargetPermissions and acceptChanges can be true.
		/// </remarks>
		public bool keepOriginalPermissions
		{
			get
			{
				return keepOriginalPermissionsValue;
			}
			set
			{
				this.keepOriginalPermissionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Take the target permissions.
		/// </summary>
		/// <remarks>
		/// Only one of the three options keepOriginalPermissions, takeTargetPermissions and acceptChanges can be true.
		/// </remarks>
		public bool takeTargetPermissions
		{
			get
			{
				return takeTargetPermissionsValue;
			}
			set
			{
				this.takeTargetPermissionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Accept the change.
		/// </summary>
		/// <remarks>
		/// Only one of the three options keepOriginalPermissions, takeTargetPermissions and acceptChanges can be true.
		/// </remarks>
		public bool acceptChanges
		{
			get
			{
				return acceptChangesValue;
			}
			set
			{
				this.acceptChangesValue = value;
			}
		}
		
		
		/// <summary>
		/// Keep references to original objects in copied parents.
		/// </summary>
		/// <remarks>
		/// This member is ignored, if ProcessInfo.inclReferences=false.
		/// If this member is true or only the parent is included in the tree,
		/// the copied reference links the copied parent to the original object.
		/// If this member is false and both the parent and object of a reference is included
		/// in the tree, the copied reference links the copied parent to the copied object.
		/// </remarks>
		public bool keepReferences
		{
			get
			{
				return keepReferencesValue;
			}
			set
			{
				this.keepReferencesValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not copy all documents versions but only workversion
		/// </summary>
		public bool copyOnlyWorkversion
		{
			get
			{
				return copyOnlyWorkversionValue;
			}
			set
			{
				this.copyOnlyWorkversionValue = value;
			}
		}
		
		
		/// <summary>
		/// Only move the element.
		/// </summary>
		public bool moveOnly
		{
			get
			{
				return moveOnlyValue;
			}
			set
			{
				this.moveOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// The permissions of the moved objects are modified.
		/// </summary>
		/// <remarks>
		/// The permissions inherited from the old parent
		/// are substracted and the permissions of the new parent are added to the object.
		/// </remarks>
		public bool adjustAclDifference
		{
			get
			{
				return adjustAclDifferenceValue;
			}
			set
			{
				this.adjustAclDifferenceValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String targetNameValue;

		protected int newParentIdValue;

		protected bool copyOnlyBaseElementValue;

		protected bool copyStructuresAndDocumentsValue;

		protected bool copyOnlyWorkAttachmentValue;

		protected bool keepOriginalOwnerValue;

		protected bool keepCurrentNotesValue;

		protected bool inclAttachmentsValue;

		protected bool keepOriginalPermissionsValue;

		protected bool takeTargetPermissionsValue;

		protected bool acceptChangesValue;

		protected bool keepReferencesValue;

		protected bool copyOnlyWorkversionValue;

		protected bool moveOnlyValue;

		protected bool adjustAclDifferenceValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1427182574L;		
	} // end class
}  // end namespace

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
	/// This class contains options for deleting archive SORDs using the deleteSord function.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class DeleteOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DeleteOptions() {
		}		
		
		public DeleteOptions(bool @deleteFinally, String @maxIDate, bool @deleteExpiredOnly, String @maxTStamp, bool @deleteDocumentVersionsOnly, bool @deleteCertainDocumentVersionsOnly, bool @deleteResidueFree, bool @folderMustBeEmpty, bool @deleteExpiredFolders) {
			this.deleteFinallyValue = @deleteFinally;
			this.maxIDateValue = @maxIDate;
			this.deleteExpiredOnlyValue = @deleteExpiredOnly;
			this.maxTStampValue = @maxTStamp;
			this.deleteDocumentVersionsOnlyValue = @deleteDocumentVersionsOnly;
			this.deleteCertainDocumentVersionsOnlyValue = @deleteCertainDocumentVersionsOnly;
			this.deleteResidueFreeValue = @deleteResidueFree;
			this.folderMustBeEmptyValue = @folderMustBeEmpty;
			this.deleteExpiredFoldersValue = @deleteExpiredFolders;
		}		
		
		public DeleteOptions(DeleteOptions rhs) : base(rhs)
		{
			this.deleteFinallyValue = rhs.deleteFinallyValue;
			this.maxIDateValue = rhs.maxIDateValue;
			this.deleteExpiredOnlyValue = rhs.deleteExpiredOnlyValue;
			this.maxTStampValue = rhs.maxTStampValue;
			this.deleteDocumentVersionsOnlyValue = rhs.deleteDocumentVersionsOnlyValue;
			this.deleteCertainDocumentVersionsOnlyValue = rhs.deleteCertainDocumentVersionsOnlyValue;
			this.deleteResidueFreeValue = rhs.deleteResidueFreeValue;
			this.folderMustBeEmptyValue = rhs.folderMustBeEmptyValue;
			this.deleteExpiredFoldersValue = rhs.deleteExpiredFoldersValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// deleteFinally=true causes the objects to be removed physically.
		/// </summary>
		/// <remarks>
		/// When used together with <code>cleanupStart</code>, this option is always true.
		/// Exception: see {@link #deleteExpiredOnly}
		/// </remarks>
		public bool deleteFinally
		{
			get
			{
				return deleteFinallyValue;
			}
			set
			{
				this.deleteFinallyValue = value;
			}
		}
		
		
		/// <summary>
		/// maxIDate ist the ISO representation of the local date used to mark the upper limit for deleting.
		/// </summary>
		public String maxIDate
		{
			get
			{
				return maxIDateValue;
			}
			set
			{
				this.maxIDateValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete only expired objects.
		/// </summary>
		/// <remarks>
		/// Only supported in function <code>cleanupStart</code>.
		/// This option can be combined with <code>deleteFinally</code>.
		/// <table border="2" summary="">
		/// <tr><td><code>deleteFinally</code></td><td>Action</td></tr>
		/// <tr><td><code>false</code></td>
		/// <td>
		/// All expired objects will be marked as deleted (but not finally deleted).
		/// The objects ACL is checked before it is deleted.
		/// LockC.FORCE is applied when deleting an object.
		/// </td>
		/// </tr>
		/// <tr><td><code>true</code></td><td>Objects that are expired and marked are deleted finally.</td></tr>
		/// </table>
		/// </remarks>
		public bool deleteExpiredOnly
		{
			get
			{
				return deleteExpiredOnlyValue;
			}
			set
			{
				this.deleteExpiredOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete objects modified last time before this date.
		/// </summary>
		/// <remarks>
		/// Only supported in function <code>cleanupStart</code>.
		/// If deleteFinally is true and this member is set, ony
		/// those objects are deleted finally, which were deleted
		/// logically before the given time.
		/// It must be an ISO value in the local time zone.
		/// </remarks>
		public String maxTStamp
		{
			get
			{
				return maxTStampValue;
			}
			set
			{
				this.maxTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete the document versions of the objects but keep
		/// keywording information.
		/// </summary>
		/// <remarks>
		/// In order to delete only the
		/// document versions, call deleteSord on an maybe undeleted
		/// object and set DeleteOptions.deleteFinally=true and
		/// DeleteOptions.deleteDocumentVersionsOnly=true.
		/// </remarks>
		public bool deleteDocumentVersionsOnly
		{
			get
			{
				return deleteDocumentVersionsOnlyValue;
			}
			set
			{
				this.deleteDocumentVersionsOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete physically certain document versions of the objects.
		/// </summary>
		/// <remarks>
		/// In order to delete physically certain document versions, first mark
		/// document versions as deleted (using DocVersion.setDeleted, followed
		/// by checkinDocEnd). Then call deleteSord after having set
		/// DeleteOptions.deleteFinally=true and
		/// DeleteOptions.deleteCertainDocumentVersionsOnly=true.
		/// (In order to delete all document versions, use field
		/// deleteDocumentVersionsOnly)
		/// </remarks>
		public bool deleteCertainDocumentVersionsOnly
		{
			get
			{
				return deleteCertainDocumentVersionsOnlyValue;
			}
			set
			{
				this.deleteCertainDocumentVersionsOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete all references to the objects in the database.
		/// </summary>
		/// <remarks>
		/// This includes reporting, replication control information,
		/// fulltext, etc.
		/// This option is ignroed, if deleteFinally is false.
		/// </remarks>
		public bool deleteResidueFree
		{
			get
			{
				return deleteResidueFreeValue;
			}
			set
			{
				this.deleteResidueFreeValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete a folder only if it is empty.
		/// </summary>
		/// <remarks>
		/// Set this member to true, if deleteSord should delete only empty folders.
		/// If the parameters to deleteSord specify the original location of a
		/// non-empty folder, the exception IXExceptionC.ACCESS_DENIED is thrown.
		/// This option is ignored, if deleteSord is invokded with a reference.
		/// </remarks>
		public bool folderMustBeEmpty
		{
			get
			{
				return folderMustBeEmptyValue;
			}
			set
			{
				this.folderMustBeEmptyValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete only expired folders and documents.
		/// </summary>
		/// <remarks>
		/// Only expired empty folders can be deleted.
		/// Only supported in function <code>cleanupStart</code>.
		/// This option can be combined with <code>deleteFinally</code>.
		/// <table border="2" summary="">
		/// <tr><td><code>deleteFinally</code></td><td>Action</td></tr>
		/// <tr><td><code>false</code></td>
		/// <td>
		/// All expired objects will be marked as deleted (but not finally deleted).
		/// The objects ACL is checked before it is deleted.
		/// LockC.FORCE is applied when deleting an object.
		/// </td>
		/// </tr>
		/// <tr><td><code>true</code></td><td>Objects that are expired and marked are deleted finally.</td></tr>
		/// </table>
		/// </remarks>
		public bool deleteExpiredFolders
		{
			get
			{
				return deleteExpiredFoldersValue;
			}
			set
			{
				this.deleteExpiredFoldersValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool deleteFinallyValue;

		protected String maxIDateValue;

		protected bool deleteExpiredOnlyValue;

		protected String maxTStampValue;

		protected bool deleteDocumentVersionsOnlyValue;

		protected bool deleteCertainDocumentVersionsOnlyValue;

		protected bool deleteResidueFreeValue;

		protected bool folderMustBeEmptyValue;

		protected bool deleteExpiredFoldersValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 329713511L;		
	} // end class
}  // end namespace

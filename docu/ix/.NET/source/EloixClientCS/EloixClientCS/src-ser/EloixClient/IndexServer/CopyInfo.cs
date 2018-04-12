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
	/// Controls the options of de.elo.ix.IXServicePortIF.copySord().
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2004
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class CopyInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public CopyInfo() {
		}		
		
		public CopyInfo(int @depth, int @manSortIdx, String @name, bool @adjustAclDifference, bool @adjustAclOverwrite, bool @adjustAclIgnoreFolders, bool @adjustAclIgnoreDocuments, bool @adjustAclInBackground, bool @checkRecursion, String @oldParentId) {
			this.depthValue = @depth;
			this.manSortIdxValue = @manSortIdx;
			this.nameValue = @name;
			this.adjustAclDifferenceValue = @adjustAclDifference;
			this.adjustAclOverwriteValue = @adjustAclOverwrite;
			this.adjustAclIgnoreFoldersValue = @adjustAclIgnoreFolders;
			this.adjustAclIgnoreDocumentsValue = @adjustAclIgnoreDocuments;
			this.adjustAclInBackgroundValue = @adjustAclInBackground;
			this.checkRecursionValue = @checkRecursion;
			this.oldParentIdValue = @oldParentId;
		}		
		
		public CopyInfo(CopyInfo rhs) : base(rhs)
		{
			this.depthValue = rhs.depthValue;
			this.manSortIdxValue = rhs.manSortIdxValue;
			this.nameValue = rhs.nameValue;
			this.adjustAclDifferenceValue = rhs.adjustAclDifferenceValue;
			this.adjustAclOverwriteValue = rhs.adjustAclOverwriteValue;
			this.adjustAclIgnoreFoldersValue = rhs.adjustAclIgnoreFoldersValue;
			this.adjustAclIgnoreDocumentsValue = rhs.adjustAclIgnoreDocumentsValue;
			this.adjustAclInBackgroundValue = rhs.adjustAclInBackgroundValue;
			this.checkRecursionValue = rhs.checkRecursionValue;
			this.oldParentIdValue = rhs.oldParentIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Depth up to which the structure is to be copied.
		/// </summary>
		/// <remarks>
		/// THIS FUNCTION IS NOT CURRENTLY SUPPORTED!
		/// </remarks>
		public int depth
		{
			get
			{
				return depthValue;
			}
			set
			{
				this.depthValue = value;
			}
		}
		
		
		/// <summary>
		/// Manually determine the position.
		/// </summary>
		/// <remarks>
		/// Use 0 to insert at the beginning of the child list. Use -1 to
		/// insert at the end of the child list ( this is the fastest mode). A value n greater then 0
		/// inserts the object at the position n.
		/// </remarks>
		public int manSortIdx
		{
			get
			{
				return manSortIdxValue;
			}
			set
			{
				this.manSortIdxValue = value;
			}
		}
		
		
		/// <summary>
		/// COPY-Mode: Name of the destination archive entry.
		/// </summary>
		/// <remarks>
		/// THIS FUNCTION IS NOT CURRENTLY SUPPORTED!
		/// </remarks>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// The permissions of the moved object are modified.
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
		
		
		/// <summary>
		/// Set the permissions of the moved object equal to the permissions of the new parent.
		/// </summary>
		public bool adjustAclOverwrite
		{
			get
			{
				return adjustAclOverwriteValue;
			}
			set
			{
				this.adjustAclOverwriteValue = value;
			}
		}
		
		
		/// <summary>
		/// Recursivly adjust the permissions of the sub-folders of the moved object too.
		/// </summary>
		public bool adjustAclIgnoreFolders
		{
			get
			{
				return adjustAclIgnoreFoldersValue;
			}
			set
			{
				this.adjustAclIgnoreFoldersValue = value;
			}
		}
		
		
		/// <summary>
		/// Recursivly adjust the permissions of the child-documents of the moved object too.
		/// </summary>
		public bool adjustAclIgnoreDocuments
		{
			get
			{
				return adjustAclIgnoreDocumentsValue;
			}
			set
			{
				this.adjustAclIgnoreDocumentsValue = value;
			}
		}
		
		
		/// <summary>
		/// Recursivly adjust the permissions of the child-elements in the background.
		/// </summary>
		public bool adjustAclInBackground
		{
			get
			{
				return adjustAclInBackgroundValue;
			}
			set
			{
				this.adjustAclInBackgroundValue = value;
			}
		}
		
		
		/// <summary>
		/// Check for recursion.
		/// </summary>
		/// <remarks>
		/// If this member is set, the function {@link IXServicePortIF#copySord(ClientInfo, String, String, CopyInfo, CopySordZ)} checks
		/// whether the copy or move operation causes a recursion in the archive hierarchy. If so, the function throws an exception with
		/// {@link IXExceptionC#ACCESS_DENIED}.
		/// </remarks>
		public bool checkRecursion
		{
			get
			{
				return checkRecursionValue;
			}
			set
			{
				this.checkRecursionValue = value;
			}
		}
		
		
		/// <summary>
		/// Parent ID for move operation.
		/// </summary>
		/// <remarks>
		/// Set this element to the old parent ID when a reference has to be moved.
		/// If an original entry has to be moved, set the main parent ID or leave the value empty.
		/// </remarks>
		public String oldParentId
		{
			get
			{
				return oldParentIdValue;
			}
			set
			{
				this.oldParentIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int depthValue;

		protected int manSortIdxValue;

		protected String nameValue;

		protected bool adjustAclDifferenceValue;

		protected bool adjustAclOverwriteValue;

		protected bool adjustAclIgnoreFoldersValue;

		protected bool adjustAclIgnoreDocumentsValue;

		protected bool adjustAclInBackgroundValue;

		protected bool checkRecursionValue;

		protected String oldParentIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2138439536L;		
	} // end class
}  // end namespace

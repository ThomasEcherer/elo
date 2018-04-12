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
	/// This class controls the search function findFirstSords.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class FindInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindInfo() {
		}		
		
		public FindInfo(EloixClient.IndexServer.FindByFulltext @findByFulltext, EloixClient.IndexServer.FindDirect @findDirect, EloixClient.IndexServer.FindByIndex @findByIndex, EloixClient.IndexServer.FindByNotes @findByNotes, EloixClient.IndexServer.FindBySordHist @findBySordHist, EloixClient.IndexServer.FindByType @findByType, EloixClient.IndexServer.FindByVersion @findByVersion, EloixClient.IndexServer.FindChildren @findChildren, EloixClient.IndexServer.FindOptions @findOptions, EloixClient.IndexServer.FindByAcl @findByAcl, EloixClient.IndexServer.FindByPreviewCtrl @findByPreviewCtrl, EloixClient.IndexServer.FindByFulltextCtrl @findByFulltextCtrl, EloixClient.IndexServer.FindByRegisteredFunction @findByRegisteredFunction, EloixClient.IndexServer.FindLinks @findLinks) {
			this.findByFulltextValue = @findByFulltext;
			this.findDirectValue = @findDirect;
			this.findByIndexValue = @findByIndex;
			this.findByNotesValue = @findByNotes;
			this.findBySordHistValue = @findBySordHist;
			this.findByTypeValue = @findByType;
			this.findByVersionValue = @findByVersion;
			this.findChildrenValue = @findChildren;
			this.findOptionsValue = @findOptions;
			this.findByAclValue = @findByAcl;
			this.findByPreviewCtrlValue = @findByPreviewCtrl;
			this.findByFulltextCtrlValue = @findByFulltextCtrl;
			this.findByRegisteredFunctionValue = @findByRegisteredFunction;
			this.findLinksValue = @findLinks;
		}		
		
		public FindInfo(FindInfo rhs) : base(rhs)
		{
			this.findByFulltextValue = rhs.findByFulltextValue;
			this.findDirectValue = rhs.findDirectValue;
			this.findByIndexValue = rhs.findByIndexValue;
			this.findByNotesValue = rhs.findByNotesValue;
			this.findBySordHistValue = rhs.findBySordHistValue;
			this.findByTypeValue = rhs.findByTypeValue;
			this.findByVersionValue = rhs.findByVersionValue;
			this.findChildrenValue = rhs.findChildrenValue;
			this.findOptionsValue = rhs.findOptionsValue;
			this.findByAclValue = rhs.findByAclValue;
			this.findByPreviewCtrlValue = rhs.findByPreviewCtrlValue;
			this.findByFulltextCtrlValue = rhs.findByFulltextCtrlValue;
			this.findByRegisteredFunctionValue = rhs.findByRegisteredFunctionValue;
			this.findLinksValue = rhs.findLinksValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// If not null the results are constrained to documents including this
		/// fulltext term (or terms).
		/// </summary>
		public EloixClient.IndexServer.FindByFulltext findByFulltext
		{
			get
			{
				return findByFulltextValue;
			}
			set
			{
				this.findByFulltextValue = value;
			}
		}
		
		
		/// <summary>
		/// Terms for google-like search in Java-Client.
		/// </summary>
		public EloixClient.IndexServer.FindDirect findDirect
		{
			get
			{
				return findDirectValue;
			}
			set
			{
				this.findDirectValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null the function searches through the indexing information.
		/// </summary>
		public EloixClient.IndexServer.FindByIndex findByIndex
		{
			get
			{
				return findByIndexValue;
			}
			set
			{
				this.findByIndexValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null the function searches through the notes.
		/// </summary>
		/// <remarks>
		/// (NOT CURRENTLY IMPLEMENTED!)
		/// </remarks>
		public EloixClient.IndexServer.FindByNotes findByNotes
		{
			get
			{
				return findByNotesValue;
			}
			set
			{
				this.findByNotesValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null the function searches in versioning history of indexing information.
		/// </summary>
		public EloixClient.IndexServer.FindBySordHist findBySordHist
		{
			get
			{
				return findBySordHistValue;
			}
			set
			{
				this.findBySordHistValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null the function searches using objtype.
		/// </summary>
		public EloixClient.IndexServer.FindByType findByType
		{
			get
			{
				return findByTypeValue;
			}
			set
			{
				this.findByTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null the function searches using histversion and histcomment.
		/// </summary>
		public EloixClient.IndexServer.FindByVersion findByVersion
		{
			get
			{
				return findByVersionValue;
			}
			set
			{
				this.findByVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null, the results are constrained to child entries of the
		/// specified parent in this object.
		/// </summary>
		/// <remarks>
		/// To retrieve child lists for an archive
		/// entry this member must be set with the related parent ID and
		/// all others members in this class must be null.
		/// </remarks>
		public EloixClient.IndexServer.FindChildren findChildren
		{
			get
			{
				return findChildrenValue;
			}
			set
			{
				this.findChildrenValue = value;
			}
		}
		
		
		/// <summary>
		/// This member controls several options, e. g. sorting, time limitation.
		/// </summary>
		public EloixClient.IndexServer.FindOptions findOptions
		{
			get
			{
				return findOptionsValue;
			}
			set
			{
				this.findOptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Find sords by ACL.
		/// </summary>
		public EloixClient.IndexServer.FindByAcl findByAcl
		{
			get
			{
				return findByAclValue;
			}
			set
			{
				this.findByAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Find sords by preview control information.
		/// </summary>
		public EloixClient.IndexServer.FindByPreviewCtrl findByPreviewCtrl
		{
			get
			{
				return findByPreviewCtrlValue;
			}
			set
			{
				this.findByPreviewCtrlValue = value;
			}
		}
		
		
		/// <summary>
		/// Find the sords that have to be indexed by the fulltext engine.
		/// </summary>
		public EloixClient.IndexServer.FindByFulltextCtrl findByFulltextCtrl
		{
			get
			{
				return findByFulltextCtrlValue;
			}
			set
			{
				this.findByFulltextCtrlValue = value;
			}
		}
		
		
		public EloixClient.IndexServer.FindByRegisteredFunction findByRegisteredFunction
		{
			get
			{
				return findByRegisteredFunctionValue;
			}
			set
			{
				this.findByRegisteredFunctionValue = value;
			}
		}
		
		
		/// <summary>
		/// If not null, the results are constrained to entries linked to the specified
		/// object in findLinks.
		/// </summary>
		public EloixClient.IndexServer.FindLinks findLinks
		{
			get
			{
				return findLinksValue;
			}
			set
			{
				this.findLinksValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.FindByFulltext findByFulltextValue;

		protected EloixClient.IndexServer.FindDirect findDirectValue;

		protected EloixClient.IndexServer.FindByIndex findByIndexValue;

		protected EloixClient.IndexServer.FindByNotes findByNotesValue;

		protected EloixClient.IndexServer.FindBySordHist findBySordHistValue;

		protected EloixClient.IndexServer.FindByType findByTypeValue;

		protected EloixClient.IndexServer.FindByVersion findByVersionValue;

		protected EloixClient.IndexServer.FindChildren findChildrenValue;

		protected EloixClient.IndexServer.FindOptions findOptionsValue;

		protected EloixClient.IndexServer.FindByAcl findByAclValue;

		protected EloixClient.IndexServer.FindByPreviewCtrl findByPreviewCtrlValue;

		protected EloixClient.IndexServer.FindByFulltextCtrl findByFulltextCtrlValue;

		protected EloixClient.IndexServer.FindByRegisteredFunction findByRegisteredFunctionValue;

		protected EloixClient.IndexServer.FindLinks findLinksValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1017838205L;		
	} // end class
}  // end namespace

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
	/// This class controls the search for child objects of an archive entry.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class FindChildren : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindChildren() {
		}		
		
		public FindChildren(bool @mainParent, String @parentId, int @endLevel) {
			this.mainParentValue = @mainParent;
			this.parentIdValue = @parentId;
			this.endLevelValue = @endLevel;
		}		
		
		public FindChildren(FindChildren rhs) : base(rhs)
		{
			this.mainParentValue = rhs.mainParentValue;
			this.parentIdValue = rhs.parentIdValue;
			this.endLevelValue = rhs.endLevelValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Include only main parent relations.
		/// </summary>
		public bool mainParent
		{
			get
			{
				return mainParentValue;
			}
			set
			{
				this.mainParentValue = value;
			}
		}
		
		
		/// <summary>
		/// Search child objects of the parent entry with this object ID or GUID.
		/// </summary>
		public String parentId
		{
			get
			{
				return parentIdValue;
			}
			set
			{
				this.parentIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Search child objects up to this level below parentId.
		/// </summary>
		/// <remarks>
		/// A value of 0 or 1 means, that only the sub entries
		/// directly under the parent are included.
		/// Set this value to -1, to search over all levels. In this
		/// case the level is internally constrained to 32 to avoid
		/// an endless loop, if the tree under the parent contains
		/// recursive references.
		/// </remarks>
		public int endLevel
		{
			get
			{
				return endLevelValue;
			}
			set
			{
				this.endLevelValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool mainParentValue;

		protected String parentIdValue;

		protected int endLevelValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 752202075L;		
	} // end class
}  // end namespace

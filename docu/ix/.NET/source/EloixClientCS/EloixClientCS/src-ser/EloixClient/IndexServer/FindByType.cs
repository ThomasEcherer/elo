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
	/// This class holds additional information for FindInfo, in order to restrict
	/// a search using document types.
	/// </summary>
	/// <remarks>
	/// The default resolving sequence is ordered by the grade of restriction: <br>
	/// 1. typeIDs, typeNames, typeExtensions is the most specialised information, <br>
	/// 2. typeDocuments containing all document types (IDs, Names, Extensions), <br>
	/// 3. and typeStructures including all levels of structure elements. <br>
	/// 4. If none of the parameters above is valid, the complete restriction
	/// FindByType is omitted. <br>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class FindByType : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByType() {
		}		
		
		public FindByType(bool @typeDocuments, String[] @typeExtensions, int[] @typeIDs, String[] @typeNames, bool @typeStructures) {
			this.typeDocumentsValue = @typeDocuments;
			this.typeExtensionsValue = @typeExtensions;
			this.typeIDsValue = @typeIDs;
			this.typeNamesValue = @typeNames;
			this.typeStructuresValue = @typeStructures;
		}		
		
		public FindByType(FindByType rhs) : base(rhs)
		{
			this.typeDocumentsValue = rhs.typeDocumentsValue;
			this.typeExtensionsValue = rhs.typeExtensionsValue;
			this.typeIDsValue = rhs.typeIDsValue;
			this.typeNamesValue = rhs.typeNamesValue;
			this.typeStructuresValue = rhs.typeStructuresValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Include all document types
		/// </summary>
		public bool typeDocuments
		{
			get
			{
				return typeDocumentsValue;
			}
			set
			{
				this.typeDocumentsValue = value;
			}
		}
		
		
		/// <summary>
		/// Associated document extensions; must be resolved to typeIDs
		/// </summary>
		public String[] typeExtensions
		{
			get
			{
				return typeExtensionsValue;
			}
			set
			{
				this.typeExtensionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Type identifiers; a direct mapping of objtype
		/// </summary>
		public int[] typeIDs
		{
			get
			{
				return typeIDsValue;
			}
			set
			{
				this.typeIDsValue = value;
			}
		}
		
		
		/// <summary>
		/// Type names; must be resolved to typeIDs
		/// </summary>
		public String[] typeNames
		{
			get
			{
				return typeNamesValue;
			}
			set
			{
				this.typeNamesValue = value;
			}
		}
		
		
		/// <summary>
		/// Include all structure elements
		/// </summary>
		public bool typeStructures
		{
			get
			{
				return typeStructuresValue;
			}
			set
			{
				this.typeStructuresValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool typeDocumentsValue;

		protected String[] typeExtensionsValue;

		protected int[] typeIDsValue;

		protected String[] typeNamesValue;

		protected bool typeStructuresValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 151307616L;		
	} // end class
}  // end namespace

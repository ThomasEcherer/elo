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
	/// Contains the archive destination returned by a call to {@link IXServicePortIF#evalAutoFiling(ClientInfo, String, Sord, AutoFilingOptions)}.
	/// </summary>
	public class AutoFilingResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public AutoFilingResult() {
		}		
		
		public AutoFilingResult(String[] @pathsAsString, int[] @parentIds) {
			this.pathsAsStringValue = @pathsAsString;
			this.parentIdsValue = @parentIds;
		}		
		
		public AutoFilingResult(AutoFilingResult rhs) : base(rhs)
		{
			this.pathsAsStringValue = rhs.pathsAsStringValue;
			this.parentIdsValue = rhs.parentIdsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Destination archive paths.
		/// </summary>
		/// <remarks>
		/// The first array element is the main path used to store the object.
		/// The other elements are archive paths for references to the object.
		/// The first character of each path is the separator.
		/// A path element is empty, if 1. the filing definition is an asterix (*, "chaos" folder) or if 2. the filing definition
		/// does not specify an archive path (e.g. "longest match" definition) and the destination path does not exist.
		/// A path element is the separator, if the destination path is the topmost archive level.
		/// If the filing definition given in {@link IXServicePortIF#evalAutoFiling(ClientInfo, String, Sord, AutoFilingOptions)} is empty,
		/// the array has one element of value "Â¶".
		/// </remarks>
		public String[] pathsAsString
		{
			get
			{
				return pathsAsStringValue;
			}
			set
			{
				this.pathsAsStringValue = value;
			}
		}
		
		
		/// <summary>
		/// Destination object IDs.
		/// </summary>
		/// <remarks>
		/// The first array element belongs to the main path. The other elements belong to reference paths.
		/// The element value is the object ID of the last entry in the path, if the path exists.
		/// If the path does not exist, the element value is -1.
		/// An element value of 0 indicates that the object is stored in the "chaos" folder. This happens if an asterix * is used as filing definition.
		/// If the filing definition given in {@link IXServicePortIF#evalAutoFiling(ClientInfo, String, Sord, AutoFilingOptions)} is empty,
		/// the array has one element of value 1.
		/// </remarks>
		public int[] parentIds
		{
			get
			{
				return parentIdsValue;
			}
			set
			{
				this.parentIdsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] pathsAsStringValue;

		protected int[] parentIdsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1881161566L;		
	} // end class
}  // end namespace

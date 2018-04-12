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
	/// Results of a {@link ProcessCopyElements}-Operation.
	/// </summary>
	public class CopyResult : BSerializable
	{
	
		#region Constructors
		
		public CopyResult() {
		}		
		
		public CopyResult(IDictionary<int,int> @mapIdsSource2Copy, IDictionary<String,String> @mapGuidsSource2Copy) {
			this.mapIdsSource2CopyValue = @mapIdsSource2Copy;
			this.mapGuidsSource2CopyValue = @mapGuidsSource2Copy;
		}		
		
		public CopyResult(CopyResult rhs)
		{
			this.mapIdsSource2CopyValue = rhs.mapIdsSource2CopyValue;
			this.mapGuidsSource2CopyValue = rhs.mapGuidsSource2CopyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maps the Ids of the source elements to the copied element's Ids.
		/// </summary>
		/// <remarks>
		/// <p>
		/// To reduce memory consumption, this map only contains the mapping for
		/// elements in the {@link NavigationInfo#startIDs} when using
		/// {@link IXServicePortIF#processTrees(ClientInfo, NavigationInfo, ProcessInfo)}
		/// .
		/// </p>
		/// <p>
		/// In case of using
		/// {@link IXServicePortIF#processFindResult(ClientInfo, String, ProcessInfo)},
		/// each element found by the search will be listed in this map!
		/// </p>
		/// </remarks>
		public IDictionary<int,int> mapIdsSource2Copy
		{
			get
			{
				return mapIdsSource2CopyValue;
			}
			set
			{
				this.mapIdsSource2CopyValue = value;
			}
		}
		
		
		/// <summary>
		/// Maps the GUIDs of the source elements to the copied element's GUIDs.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The same rules apply as for {@link CopyResult#mapIdsSource2Copy}.
		/// </p>
		/// </remarks>
		public IDictionary<String,String> mapGuidsSource2Copy
		{
			get
			{
				return mapGuidsSource2CopyValue;
			}
			set
			{
				this.mapGuidsSource2CopyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IDictionary<int,int> mapIdsSource2CopyValue;

		protected IDictionary<String,String> mapGuidsSource2CopyValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1904597264L;		
	} // end class
}  // end namespace

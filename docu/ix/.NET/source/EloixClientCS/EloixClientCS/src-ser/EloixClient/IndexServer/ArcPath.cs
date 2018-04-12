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
	/// Archive path.
	/// </summary>
	public class ArcPath : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ArcPath() {
		}		
		
		public ArcPath(EloixClient.IndexServer.IdName[] @path, String @pathAsString) {
			this.pathValue = @path;
			this.pathAsStringValue = @pathAsString;
		}		
		
		public ArcPath(ArcPath rhs) : base(rhs)
		{
			this.pathValue = rhs.pathValue;
			this.pathAsStringValue = rhs.pathAsStringValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// IdName array.
		/// </summary>
		/// <remarks>
		/// Contains the identifiers and names for the archive paths.
		/// The first element is for the cabinet level. An entry does not exist for the archive level.
		/// </remarks>
		public EloixClient.IndexServer.IdName[] path
		{
			get
			{
				return pathValue;
			}
			set
			{
				this.pathValue = value;
			}
		}
		
		
		/// <summary>
		/// Path as string.
		/// </summary>
		/// <remarks>
		/// The first charachter is the path separator.
		/// </remarks>
		public String pathAsString
		{
			get
			{
				return pathAsStringValue;
			}
			set
			{
				this.pathAsStringValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.IdName[] pathValue;

		protected String pathAsStringValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 945258954L;		
	} // end class
}  // end namespace

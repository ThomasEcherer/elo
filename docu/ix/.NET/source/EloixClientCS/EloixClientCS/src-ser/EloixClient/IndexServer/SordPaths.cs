//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class SordPaths : BSerializable
	{
	
		#region Constructors
		
		public SordPaths() {
		}		
		
		public SordPaths(IList<EloixClient.IndexServer.SordPath> @sordPaths) {
			this.sordPathsValue = @sordPaths;
		}		
		
		public SordPaths(SordPaths rhs)
		{
			this.sordPathsValue = rhs.sordPathsValue;
		}		
		
		#endregion
		
		#region Properties
		
		public IList<EloixClient.IndexServer.SordPath> sordPaths
		{
			get
			{
				return sordPathsValue;
			}
			set
			{
				this.sordPathsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IList<EloixClient.IndexServer.SordPath> sordPathsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1835331414L;		
	} // end class
}  // end namespace

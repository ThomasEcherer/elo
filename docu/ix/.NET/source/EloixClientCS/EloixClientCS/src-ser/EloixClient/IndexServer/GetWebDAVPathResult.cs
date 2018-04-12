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
	/// Class for the result of the IX function {@link IXServicePortIF#getWebDAVPathFromObjID2}
	/// </summary>
	public class GetWebDAVPathResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public GetWebDAVPathResult() {
		}		
		
		public GetWebDAVPathResult(String @path) {
			this.pathValue = @path;
		}		
		
		public GetWebDAVPathResult(GetWebDAVPathResult rhs) : base(rhs)
		{
			this.pathValue = rhs.pathValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The generated WEBDAV path.
		/// </summary>
		public String path
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
		
		
		#endregion
		
		#region Fields
		
		protected String pathValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 148564345L;		
	} // end class
}  // end namespace

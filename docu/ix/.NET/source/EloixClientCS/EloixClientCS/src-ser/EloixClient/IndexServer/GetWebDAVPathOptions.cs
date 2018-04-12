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
	/// Parameter class for the function {@link IXServicePortIF#getWebDAVPathFromObjID2}
	/// </summary>
	public class GetWebDAVPathOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public GetWebDAVPathOptions() {
		}		
		
		public GetWebDAVPathOptions(bool @tickketInPath, String @objId) {
			this.tickketInPathValue = @tickketInPath;
			this.objIdValue = @objId;
		}		
		
		public GetWebDAVPathOptions(GetWebDAVPathOptions rhs) : base(rhs)
		{
			this.tickketInPathValue = rhs.tickketInPathValue;
			this.objIdValue = rhs.objIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// If true, the ticket is inserted in the path.
		/// </summary>
		public bool tickketInPath
		{
			get
			{
				return tickketInPathValue;
			}
			set
			{
				this.tickketInPathValue = value;
			}
		}
		
		
		/// <summary>
		/// ObjectId or GUID of the sord to get the path.
		/// </summary>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool tickketInPathValue;

		protected String objIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1410517836L;		
	} // end class
}  // end namespace

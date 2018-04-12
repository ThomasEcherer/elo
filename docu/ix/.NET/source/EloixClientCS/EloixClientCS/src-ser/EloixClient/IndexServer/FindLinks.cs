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
	/// Finds the links of an object.
	/// </summary>
	public class FindLinks : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindLinks() {
		}		
		
		public FindLinks(String @objectId) {
			this.objectIdValue = @objectId;
		}		
		
		public FindLinks(FindLinks rhs) : base(rhs)
		{
			this.objectIdValue = rhs.objectIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The Object to search for its links.
		/// </summary>
		public String objectId
		{
			get
			{
				return objectIdValue;
			}
			set
			{
				this.objectIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String objectIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 832548178L;		
	} // end class
}  // end namespace

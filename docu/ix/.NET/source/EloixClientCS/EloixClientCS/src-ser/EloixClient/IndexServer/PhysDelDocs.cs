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
	/// Internal class.
	/// </summary>
	public class PhysDelDocs : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PhysDelDocs() {
		}		
		
		public PhysDelDocs(int @objId) {
			this.objIdValue = @objId;
		}		
		
		public PhysDelDocs(PhysDelDocs rhs) : base(rhs)
		{
			this.objIdValue = rhs.objIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: objid
		/// </summary>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(PhysDelDocsC.mbObjId);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int objIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 855528761L;		
	} // end class
}  // end namespace

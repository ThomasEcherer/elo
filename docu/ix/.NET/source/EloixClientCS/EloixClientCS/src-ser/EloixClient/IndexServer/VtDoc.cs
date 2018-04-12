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
	public class VtDoc : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public VtDoc() {
		}		
		
		public VtDoc(int @objId, int @docId, int @code) {
			this.objIdValue = @objId;
			this.docIdValue = @docId;
			this.codeValue = @code;
		}		
		
		public VtDoc(VtDoc rhs) : base(rhs)
		{
			this.objIdValue = rhs.objIdValue;
			this.docIdValue = rhs.docIdValue;
			this.codeValue = rhs.codeValue;
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
				setChangedMember(VtDocC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// DB column: objdoc
		/// </summary>
		public int docId
		{
			get
			{
				return docIdValue;
			}
			set
			{
				this.docIdValue = value;
				setChangedMember(VtDocC.mbDocId);
			}
		}
		
		
		/// <summary>
		/// DB column: vtcode
		/// </summary>
		public int code
		{
			get
			{
				return codeValue;
			}
			set
			{
				this.codeValue = value;
				setChangedMember(VtDocC.mbCode);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int objIdValue;

		protected int docIdValue;

		protected int codeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1935852595L;		
	} // end class
}  // end namespace

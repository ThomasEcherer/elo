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
	/// <p>Bit constants for members of VtDoc</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class VtDocC : BSerializable
	{
	
		#region Constructors
		
		public VtDocC() {
		}		
		
		public VtDocC(VtDocC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: objid
		/// </summary>
		public const long mbObjId = 1L;

		/// <summary>
		/// DB column: objdoc
		/// </summary>
		public const long mbDocId = 2L;

		/// <summary>
		/// DB column: vtcode
		/// </summary>
		public const long mbCode = 4L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1585149555L;		
	} // end class
}  // end namespace

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
	/// These constants describe the type of connection between two nodes.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class WFNodeMatrixC : BSerializable
	{
	
		#region Constructors
		
		public WFNodeMatrixC() {
		}		
		
		public WFNodeMatrixC(WFNodeMatrixC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Connection type for non-decision nodes.
		/// </summary>
		/// <remarks>
		/// The connection will always be
		/// utilised to reach the next node. No conditions have to be fulfilled.
		/// </remarks>
		public const int ALWAYS = -3;

		/// <summary>
		/// This connection is the FALSE connection following a decision node.
		/// </summary>
		/// <remarks>
		/// This
		/// connection will be utilised when the IF requirement is not fulfilled.
		/// </remarks>
		public const int IF_FALSE = -2;

		/// <summary>
		/// This connection is the TRUE connection following a decision node.
		/// </summary>
		/// <remarks>
		/// This
		/// connection will be utilised when the IF requirement is fulfilled.
		/// </remarks>
		public const int IF_TRUE = -1;

		/// <summary>
		/// This connection is only for the case of overtime.
		/// </summary>
		public const int IF_OVERTIME = 1;

		#endregion
		
		
		public static readonly long serialVersionUID = 171864975L;		
	} // end class
}  // end namespace

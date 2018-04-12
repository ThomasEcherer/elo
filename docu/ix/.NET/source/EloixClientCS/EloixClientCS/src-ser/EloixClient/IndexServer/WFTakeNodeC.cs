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
	/// Constant class for controlling the taking over(passing to another user) of a workflow object.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class WFTakeNodeC : BSerializable
	{
	
		#region Constructors
		
		public WFTakeNodeC() {
		}		
		
		public WFTakeNodeC(WFTakeNodeC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Standard action.
		/// </summary>
		/// <remarks>
		/// Neither WFNode.department2 nor WFNode.inUseDateIso are returned.
		/// </remarks>
		public const int DEFAULT = 0;

		/// <summary>
		/// WFNode.department2 is set when the node is taken over by another user.
		/// </summary>
		public const int RESET_DEPARTMENT2 = 2;

		/// <summary>
		/// WFNode.inUseDateIso is set when the node is taken over by another user.
		/// </summary>
		public const int RESET_IN_USE_DATE = 1;

		#endregion
		
		
		public static readonly long serialVersionUID = 1164251184L;		
	} // end class
}  // end namespace

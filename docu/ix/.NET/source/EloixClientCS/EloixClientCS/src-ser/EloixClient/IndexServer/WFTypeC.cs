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
	/// Constants class for WFType.
	/// </summary>
	/// <remarks>
	/// This class describes the workflow type/status.
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class WFTypeC : BSerializable
	{
	
		#region Constructors
		
		public WFTypeC() {
		}		
		
		public WFTypeC(WFTypeC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long bsetACTIVE = 0L;

		public const long bsetFINISHED = 1L;

		public const long bsetTEMPLATE = 2L;

		/// <summary>
		/// The workflow is active.
		/// </summary>
		public readonly static EloixClient.IndexServer.WFTypeZ ACTIVE = new WFTypeZ(0L);

		/// <summary>
		/// The workflow is finished (completed).
		/// </summary>
		public readonly static EloixClient.IndexServer.WFTypeZ FINISHED = new WFTypeZ(1L);

		/// <summary>
		/// The workflow is a template workflow.
		/// </summary>
		public readonly static EloixClient.IndexServer.WFTypeZ TEMPLATE = new WFTypeZ(2L);

		#endregion
		
		
		public static readonly long serialVersionUID = 1842783874L;		
	} // end class
}  // end namespace

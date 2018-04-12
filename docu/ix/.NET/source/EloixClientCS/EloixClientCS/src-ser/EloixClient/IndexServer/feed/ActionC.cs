//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// Constants for class Action.
	/// </summary>
	public class ActionC : EloixClient.IndexServer.feed.ActionDataC, BSerializable
	{
	
		#region Constructors
		
		public ActionC() {
		}		
		
		public ActionC(ActionC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long mbDocVersion = 1099511627776L;

		public const long mbWorkflow = 2199023255552L;

		public const long mbHistory = 4398046511104L;

		public new const long mbAllMembers = -1L;

		/// <summary>
		/// All Action members without text, docVersion and workflow.
		/// </summary>
		public readonly static EloixClient.IndexServer.feed.ActionZ mbMin = new ActionZ(-7696581394689L);

		/// <summary>
		/// All Action members.
		/// </summary>
		public readonly static EloixClient.IndexServer.feed.ActionZ mbAll = new ActionZ(-1L);

		#endregion
		
		
		public static readonly new long serialVersionUID = 1988394652L;		
	} // end class
}  // end namespace

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
	public class ServerState : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ServerState() {
		}		
		
		public ServerState(int @actionId, int @subKey, String @action) {
			this.actionIdValue = @actionId;
			this.subKeyValue = @subKey;
			this.actionValue = @action;
		}		
		
		public ServerState(ServerState rhs) : base(rhs)
		{
			this.actionIdValue = rhs.actionIdValue;
			this.subKeyValue = rhs.subKeyValue;
			this.actionValue = rhs.actionValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: actionid
		/// </summary>
		public int actionId
		{
			get
			{
				return actionIdValue;
			}
			set
			{
				this.actionIdValue = value;
				setChangedMember(ServerStateC.mbActionId);
			}
		}
		
		
		/// <summary>
		/// DB column: subkey
		/// </summary>
		public int subKey
		{
			get
			{
				return subKeyValue;
			}
			set
			{
				this.subKeyValue = value;
				setChangedMember(ServerStateC.mbSubKey);
			}
		}
		
		
		/// <summary>
		/// DB column: action
		/// </summary>
		public String action
		{
			get
			{
				return actionValue;
			}
			set
			{
				this.actionValue = value;
				setChangedMember(ServerStateC.mbActionId);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int actionIdValue;

		protected int subKeyValue;

		protected String actionValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1076606418L;		
	} // end class
}  // end namespace

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
	/// This class contains infomation about the filing paths of the document manager (DM).
	/// </summary>
	public class ServerInfoDM : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ServerInfoDM() {
		}		
		
		public ServerInfoDM(int[] @basisStoreIds, int[] @backupStoreIds, int @restoreStoreId, int @storeMode, int @proxyMode, bool @blackeningEnabled) {
			this.basisStoreIdsValue = @basisStoreIds;
			this.backupStoreIdsValue = @backupStoreIds;
			this.restoreStoreIdValue = @restoreStoreId;
			this.storeModeValue = @storeMode;
			this.proxyModeValue = @proxyMode;
			this.blackeningEnabledValue = @blackeningEnabled;
		}		
		
		public ServerInfoDM(ServerInfoDM rhs) : base(rhs)
		{
			this.basisStoreIdsValue = rhs.basisStoreIdsValue;
			this.backupStoreIdsValue = rhs.backupStoreIdsValue;
			this.restoreStoreIdValue = rhs.restoreStoreIdValue;
			this.storeModeValue = rhs.storeModeValue;
			this.proxyModeValue = rhs.proxyModeValue;
			this.blackeningEnabledValue = rhs.blackeningEnabledValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// IDs of the paths to be used for filing docments.
		/// </summary>
		/// <remarks>
		/// The first path ID is the ID of the default
		/// filing path. This array can contain up to 4 elements.
		/// </remarks>
		public int[] basisStoreIds
		{
			get
			{
				return basisStoreIdsValue;
			}
			set
			{
				this.basisStoreIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// reserved.
		/// </summary>
		public int[] backupStoreIds
		{
			get
			{
				return backupStoreIdsValue;
			}
			set
			{
				this.backupStoreIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of restore path.
		/// </summary>
		public int restoreStoreId
		{
			get
			{
				return restoreStoreIdValue;
			}
			set
			{
				this.restoreStoreIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Mode to be used to fill the filing paths.
		/// </summary>
		/// <remarks>
		/// This value is a bitset of the
		/// ServerInfoDMC.STOREMODE_* constants.
		/// </remarks>
		public int storeMode
		{
			get
			{
				return storeModeValue;
			}
			set
			{
				this.storeModeValue = value;
			}
		}
		
		
		/// <summary>
		/// DM proxy mode.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// <table>
		/// <tr>
		/// <td>-1</td>
		/// <td>Proxy mode is not active</td>
		/// </tr>
		/// <tr>
		/// <td>0</td>
		/// <td>Main instance</td>
		/// </tr>
		/// <tr>
		/// <td>&gt;0</td>
		/// <td>Branch instance</td>
		/// </tr>
		/// </table>
		/// </remarks>
		public int proxyMode
		{
			get
			{
				return proxyModeValue;
			}
			set
			{
				this.proxyModeValue = value;
			}
		}
		
		
		/// <summary>
		/// DM is enabled for blackening of document parts.
		/// </summary>
		public bool blackeningEnabled
		{
			get
			{
				return blackeningEnabledValue;
			}
			set
			{
				this.blackeningEnabledValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int[] basisStoreIdsValue;

		protected int[] backupStoreIdsValue;

		protected int restoreStoreIdValue;

		protected int storeModeValue;

		protected int proxyModeValue;

		protected bool blackeningEnabledValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1425760760L;		
	} // end class
}  // end namespace

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
	/// <p>License key, version and list of other IndexServers</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH </p>
	/// </summary>
	public class ServerInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ServerInfo() {
		}		
		
		public ServerInfo(EloixClient.IndexServer.IndexServerForArchive[] @indexServers, EloixClient.IndexServer.License @license, String @version, String @replProcessOnServerId, String @databaseEngine, String @instanceName) {
			this.indexServersValue = @indexServers;
			this.licenseValue = @license;
			this.versionValue = @version;
			this.replProcessOnServerIdValue = @replProcessOnServerId;
			this.databaseEngineValue = @databaseEngine;
			this.instanceNameValue = @instanceName;
		}		
		
		public ServerInfo(ServerInfo rhs) : base(rhs)
		{
			this.indexServersValue = rhs.indexServersValue;
			this.licenseValue = rhs.licenseValue;
			this.versionValue = rhs.versionValue;
			this.replProcessOnServerIdValue = rhs.replProcessOnServerIdValue;
			this.databaseEngineValue = rhs.databaseEngineValue;
			this.instanceNameValue = rhs.instanceNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// List of other Index Servers.
		/// </summary>
		/// <remarks>
		/// Read only.
		/// </remarks>
		public EloixClient.IndexServer.IndexServerForArchive[] indexServers
		{
			get
			{
				return indexServersValue;
			}
			set
			{
				this.indexServersValue = value;
			}
		}
		
		
		/// <summary>
		/// License key for the Index Server.
		/// </summary>
		/// <remarks>
		/// Read only.
		/// </remarks>
		public EloixClient.IndexServer.License license
		{
			get
			{
				return licenseValue;
			}
			set
			{
				this.licenseValue = value;
			}
		}
		
		
		/// <summary>
		/// The version of the Index Server.
		/// </summary>
		/// <remarks>
		/// Read only.
		/// </remarks>
		public String version
		{
			get
			{
				return versionValue;
			}
			set
			{
				this.versionValue = value;
			}
		}
		
		
		/// <summary>
		/// This value defines the server ID which is checked
		/// when a workflow is forwared.
		/// </summary>
		public String replProcessOnServerId
		{
			get
			{
				return replProcessOnServerIdValue;
			}
			set
			{
				this.replProcessOnServerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Database engine name.
		/// </summary>
		/// <remarks>
		/// E. g. MSSQL, ORACLE, DB2
		/// If connected to DB2, the character set UTF-8 is assumed for
		/// database columns that store Strings. In this case the length members
		/// of the constant classes (e.g. SordC.lnName resp. CONST.SORD.lnName)
		/// contain the column widths in bytes rather than characters. Use
		/// the IXConnection.truncate function to truncate a String value to
		/// fit the corresponding database column.
		/// </remarks>
		public String databaseEngine
		{
			get
			{
				return databaseEngineValue;
			}
			set
			{
				this.databaseEngineValue = value;
			}
		}
		
		
		/// <summary>
		/// Indexserver name.
		/// </summary>
		/// <remarks>
		/// This is the name configured in config.xml or web.xml as "ixid".
		/// </remarks>
		public String instanceName
		{
			get
			{
				return instanceNameValue;
			}
			set
			{
				this.instanceNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.IndexServerForArchive[] indexServersValue;

		protected EloixClient.IndexServer.License licenseValue;

		protected String versionValue;

		protected String replProcessOnServerIdValue;

		protected String databaseEngineValue;

		protected String instanceNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1701204890L;		
	} // end class
}  // end namespace

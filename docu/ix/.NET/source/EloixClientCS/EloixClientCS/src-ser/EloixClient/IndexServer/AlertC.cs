//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class AlertC : EloixClient.IndexServer.AlertDataC, BSerializable
	{
	
		#region Constructors
		
		public AlertC() {
		}		
		
		public AlertC(AlertC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKALARM = 1;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKWV = 16;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKPOST = 32;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKWF = 64;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKSONST = 128;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKVERT = 256;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKWVEDMSG = 4096;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MASKWVDELMSG = 8192;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int WVSEEN = 1;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int WVDELETED = 2;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int WVEDITED = 3;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int POSTMOVE = 4;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int WFSTART = 5;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int WFARRIVED = 6;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int MESSAGE = 7;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int NEWVERT = 8;

		/// <summary>
		/// (to be defined)
		/// </summary>
		public const int DELVERT = 9;

		/// <summary>
		/// Alert is a message from the replication module
		/// </summary>
		public const int REPLERR = 10;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1426544289L;		
	} // end class
}  // end namespace

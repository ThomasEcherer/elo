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
	/// Constants for the PhysDel.type member.
	/// </summary>
	public class PhysDelC : EloixClient.IndexServer.PhysDelDataC, BSerializable
	{
	
		#region Constructors
		
		public PhysDelC() {
		}		
		
		public PhysDelC(PhysDelC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Unknown object type deleted.
		/// </summary>
		public const int ERROR = 0;

		/// <summary>
		/// User deleted.
		/// </summary>
		public const int USER = 1;

		/// <summary>
		/// Keywording form deleted.
		/// </summary>
		public const int MASK = 2;

		/// <summary>
		/// Color deleted.
		/// </summary>
		public const int COLOR = 3;

		/// <summary>
		/// Keyword list deleted.
		/// </summary>
		public const int KEYWORDLIST = 4;

		/// <summary>
		/// Folder or document deleted.
		/// </summary>
		public const int SORD = 20;

		/// <summary>
		/// Relation deleted.
		/// </summary>
		public const int RELATION = 21;

		/// <summary>
		/// Document version or attachment deleted.
		/// </summary>
		public const int VERSION = 22;

		/// <summary>
		/// Note or annotation deleted.
		/// </summary>
		public const int NOTE = 23;

		/// <summary>
		/// Activity deleted.
		/// </summary>
		public const int ACTIVITY = 24;

		/// <summary>
		/// Workflow deleted.
		/// </summary>
		public const int WORKFLOW = 25;

		/// <summary>
		/// Map deleted.
		/// </summary>
		public const int MAP = 26;

		/// <summary>
		/// Link deleted.
		/// </summary>
		public const int LINK = 27;

		#endregion
		
		
		public static readonly new long serialVersionUID = 278631137L;		
	} // end class
}  // end namespace

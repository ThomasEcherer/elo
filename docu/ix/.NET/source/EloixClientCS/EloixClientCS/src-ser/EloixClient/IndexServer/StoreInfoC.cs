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
	/// Definition of a document path.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class StoreInfoC : BSerializable
	{
	
		#region Constructors
		
		public StoreInfoC() {
		}		
		
		public StoreInfoC(StoreInfoC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// No sub directories.
		/// </summary>
		public const int SP_FLAT = 0;

		/// <summary>
		/// 64k documents per sub directory
		/// </summary>
		public const int SP_64K = 1;

		/// <summary>
		/// 16k documents per sub directory
		/// </summary>
		public const int SP_16 = 2;

		/// <summary>
		/// 4k documents per sub directory
		/// </summary>
		public const int SP_4K = 3;

		/// <summary>
		/// 1k documents per sub directory
		/// </summary>
		public const int SP_1K = 4;

		/// <summary>
		/// 256 folders with 256 documents
		/// </summary>
		public const int SP_FULL = 6;

		/// <summary>
		/// Store using MD5 hash.
		/// </summary>
		public const int SP_MD5_HASH = 8;

		/// <summary>
		/// Store on CENTERA device.
		/// </summary>
		public const int SP_CENTERA = 9;

		/// <summary>
		/// Store on TSM device.
		/// </summary>
		public const int SP_TSM = 10;

		/// <summary>
		/// External storage definition.
		/// </summary>
		/// <remarks>
		/// A physical (relative) path is specified for each document.
		/// </remarks>
		public const int SP_REL_FILE_PATH = 11;

		/// <summary>
		/// Store in KGS Activator.
		/// </summary>
		public const int SP_ACTIVATOR = 12;

		/// <summary>
		/// Only ELO 5.0: path has been changed.
		/// </summary>
		public const int FLAG_ELO5_PATH_CHANGED = 1;

		/// <summary>
		/// Only ELO 5.0: path is protected.
		/// </summary>
		public const int FLAG_ELO5_PATH_PROTECTED = 2;

		/// <summary>
		/// Only ELO 5.0: no NT security.
		/// </summary>
		public const int FLAG_ELO5_NO_NT_SECURITY = 8;

		/// <summary>
		/// Backup path.
		/// </summary>
		public const int FLAG_BACKUP = 4;

		/// <summary>
		/// Path is read-only.
		/// </summary>
		public const int FLAG_READONLY = 16;

		/// <summary>
		/// Used with FLAG_BACKUP, document files are not restored in a normal path.
		/// </summary>
		public const int FLAG_NO_RESTORE = 32;

		/// <summary>
		/// Path can only be written once.
		/// </summary>
		/// <remarks>
		/// DM does not use temporary files.
		/// </remarks>
		public const int FLAG_WORM = 64;

		/// <summary>
		/// Reserved path name.
		/// </summary>
		/// <remarks>
		/// Documents stored within DMPATH_ELOSYS will not be purged.
		/// </remarks>
		public const String DMPATH_ELOSYS = "elosys";

		#endregion
		
		
		public static readonly long serialVersionUID = 979653235L;		
	} // end class
}  // end namespace

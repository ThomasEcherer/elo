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
	/// Constants for the ConfigFile class.
	/// </summary>
	/// <remarks>
	/// These are used for accessing server directories.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ConfigFileC : BSerializable
	{
	
		#region Constructors
		
		public ConfigFileC() {
		}		
		
		public ConfigFileC(ConfigFileC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Directory for COLD background files.
		/// </summary>
		public const String COLD = "cold";

		/// <summary>
		/// Directory for scripts.
		/// </summary>
		public const String ELO_SCRIPTS = "eloscripts";

		/// <summary>
		/// Directory of initialization data.
		/// </summary>
		public const String INIT_DATA = "initdata";

		/// <summary>
		/// Directory of Intray/postbox.
		/// </summary>
		public const String POSTBOX = "postbox";

		/// <summary>
		/// Server side checkout directory.
		/// </summary>
		public const String CHECKOUT = "checkout";

		/// <summary>
		/// Old document template directory (ELO 5.0).
		/// </summary>
		public const String TEMPLATE = "template";

		/// <summary>
		/// RESERVED
		/// </summary>
		public const String VIEWER_POSTBOX = "viewerpostbox";

		/// <summary>
		/// Member bit: name
		/// </summary>
		public const long mbName = 1L;

		/// <summary>
		/// Member bit: fileData
		/// </summary>
		public const long mbFileData = 2L;

		/// <summary>
		/// Member bit: lastModified
		/// </summary>
		public const long mbLastModified = 4L;

		/// <summary>
		/// Member bit: size
		/// </summary>
		public const long mbSize = 8L;

		/// <summary>
		/// Member bit: URL
		/// </summary>
		public const long mbUrl = 16L;

		/// <summary>
		/// Member bit set: all members.
		/// </summary>
		public const long mbAllMembers = 31L;

		/// <summary>
		/// Constant object for mbAllMembers.
		/// </summary>
		public readonly static EloixClient.IndexServer.ConfigFileZ mbAll = new ConfigFileZ(31L);

		/// <summary>
		/// Constant object for mbAllmembers without file data.
		/// </summary>
		public readonly static EloixClient.IndexServer.ConfigFileZ mbNoFileData = new ConfigFileZ(29L);

		#endregion
		
		
		public static readonly long serialVersionUID = 2098566124L;		
	} // end class
}  // end namespace

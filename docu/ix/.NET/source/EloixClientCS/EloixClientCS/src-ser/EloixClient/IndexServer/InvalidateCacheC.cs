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
	/// Constants for cache invalidation.
	/// </summary>
	/// <remarks>
	/// This constans can be used as bit combination in function invalidateCache.
	/// </remarks>
	public class InvalidateCacheC : BSerializable
	{
	
		#region Constructors
		
		public InvalidateCacheC() {
		}		
		
		public InvalidateCacheC(InvalidateCacheC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Flag used to specify that the cached DocMask objects are invalid.
		/// </summary>
		public const int MASKS = 1;

		/// <summary>
		/// Flag used to specify that the cached ColorData objects are invalid.
		/// </summary>
		public const int MARKERS = 2;

		/// <summary>
		/// Flag used to specify that the cached Path objects are invalid.
		/// </summary>
		public const int PATHS = 4;

		/// <summary>
		/// Flag used to specify that the cached SordType objects are invalid.
		/// </summary>
		public const int SORD_TYPES = 8;

		/// <summary>
		/// Flag used to specify that the cached ReplName objects are invalid.
		/// </summary>
		public const int REPL_NAMES = 16;

		/// <summary>
		/// Flag used to specify that the cached crypt keys are invalid.
		/// </summary>
		public const int CRYPT_INFO = 32;

		/// <summary>
		/// Flag used to specify that the cached users are invalid.
		/// </summary>
		public const int USERS = 64;

		/// <summary>
		/// Flag used to specify that the cached keys are invalid.
		/// </summary>
		public const int KEYS = 128;

		/// <summary>
		/// Flag used to specify that the translate terms are invalid.
		/// </summary>
		public const int TRANSLATE_TERMS = 256;

		/// <summary>
		/// Flag used to specify that the note and cold background images are invalid.
		/// </summary>
		public const int NOTE_AND_COLD_IMAGES = 512;

		/// <summary>
		/// Flag used to specify that the workflow cache is invalid.
		/// </summary>
		public const int WORKFLOWS = 1024;

		/// <summary>
		/// Flag used to specify that the subscription cache is invalid.
		/// </summary>
		public const int SUBSCRIPTIONS = 2048;

		/// <summary>
		/// Flag used to specify that the hashtag count cache is invalid.
		/// </summary>
		public const int HASHTAGCOUNT = 4096;

		/// <summary>
		/// Do not invalidate the caches of the other servers.
		/// </summary>
		public const int NO_FORWARD_TO_OTHER_IXS = 65536;

		/// <summary>
		/// Flag used to specify that all cached objects are invalid.
		/// </summary>
		public const int ALL = 65535;

		#endregion
		
		
		public static readonly long serialVersionUID = 320503229L;		
	} // end class
}  // end namespace

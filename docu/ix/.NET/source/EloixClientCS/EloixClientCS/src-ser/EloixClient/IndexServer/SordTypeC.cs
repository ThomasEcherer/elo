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
	/// Constants for folder or document types.
	/// </summary>
	public class SordTypeC : BSerializable
	{
	
		#region Constructors
		
		public SordTypeC() {
		}		
		
		public SordTypeC(SordTypeC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Maximum number of folder types (=253).
		/// </summary>
		public const int MAX_FOLDER_TYPES = 253;

		/// <summary>
		/// Maximum number of document types (=56).
		/// </summary>
		public const int MAX_DOCUMENT_TYPES = 56;

		/// <summary>
		/// ID, name, extension.
		/// </summary>
		public const long mbIdNameExt = 1L;

		/// <summary>
		/// Return icon file data in <code>checkoutSordType</code>.
		/// </summary>
		public const long mbIconMember = 2L;

		/// <summary>
		/// Return file data of workflow icon in <code>checkoutSordType</code>.
		/// </summary>
		public const long mbWorkflowIconMember = 4L;

		/// <summary>
		/// Return file data of disabled icon in <code>checkoutSordType</code>.
		/// </summary>
		public const long mbDisabledIconMember = 8L;

		public const long mbJPG = 16L;

		public const long mbBMP = 32L;

		public const long mbICO = 64L;

		public const long mbPNG = 128L;

		/// <summary>
		/// Return only ID, name, extension - no icon data.
		/// </summary>
		public readonly static EloixClient.IndexServer.SordTypeZ mbNoIcons = new SordTypeZ(1L);

		/// <summary>
		/// Return icon file data in <code>checkoutSordType</code>.
		/// </summary>
		public readonly static EloixClient.IndexServer.SordTypeZ mbIconJPG = new SordTypeZ(18L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbIconBMP = new SordTypeZ(34L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbIconICO = new SordTypeZ(66L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbIconPNG = new SordTypeZ(130L);

		/// <summary>
		/// Return file data of normal icon and disabled icon in <code>checkoutSordType</code>.
		/// </summary>
		public readonly static EloixClient.IndexServer.SordTypeZ mbIconsJPG = new SordTypeZ(26L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbIconsBMP = new SordTypeZ(42L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbIconsICO = new SordTypeZ(74L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbIconsPNG = new SordTypeZ(138L);

		/// <summary>
		/// Return file data of normal, workflow and disabled icon in <code>checkoutSordType</code>.
		/// </summary>
		public readonly static EloixClient.IndexServer.SordTypeZ mbAllJPG = new SordTypeZ(30L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbAllBMP = new SordTypeZ(46L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbAllICO = new SordTypeZ(78L);

		public readonly static EloixClient.IndexServer.SordTypeZ mbAllPNG = new SordTypeZ(142L);

		#endregion
		
		
		public static readonly long serialVersionUID = 635922924L;		
	} // end class
}  // end namespace

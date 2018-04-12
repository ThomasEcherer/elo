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
	/// Element selectors for class MapHist.
	/// </summary>
	public class MapHistC : EloixClient.IndexServer.MapHistHeadC, BSerializable
	{
	
		#region Constructors
		
		public MapHistC() {
		}		
		
		public MapHistC(MapHistC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long mbHistItems = 1048576L;

		public new const long mbAllMembers = 2097151L;

		public const long mbAllMembersNoItems = 1048575L;

		/// <summary>
		/// All members.
		/// </summary>
		public readonly static EloixClient.IndexServer.MapHistZ mbAll = new MapHistZ(2097151L);

		/// <summary>
		/// All members but without {@link MapHist#histItems}.
		/// </summary>
		public readonly static EloixClient.IndexServer.MapHistZ mbAllNoItems = new MapHistZ(1048575L);

		#endregion
		
		
		public static readonly new long serialVersionUID = 379654790L;		
	} // end class
}  // end namespace

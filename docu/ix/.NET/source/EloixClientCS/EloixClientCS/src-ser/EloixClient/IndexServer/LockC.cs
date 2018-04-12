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
	/// <p>Constants to lock data against concurrent modification.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class LockC : BSerializable
	{
	
		#region Constructors
		
		public LockC() {
		}		
		
		public LockC(LockC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long bsetNO = 0L;

		public const long bsetYES = 1L;

		public const long bsetFORCE = 2L;

		public const long bsetIF_FREE = 4L;

		public const long bsetSORD = 8L;

		public const long bsetDOC = 16L;

		/// <summary>
		/// Do not lock the requested record(s).
		/// </summary>
		public readonly static EloixClient.IndexServer.LockZ NO = new LockZ(0L);

		/// <summary>
		/// Lock or unlock.
		/// </summary>
		/// <remarks>
		/// The lock is set, if the record is unlocked or
		/// locked by the current user. With respect to locking the indexing
		/// information (LockC.SORD) and document versions (LockC.DOC), LockC.YES
		/// locks and unlocks both since ELO 10. In order to successfully complete an
		/// operation with this type of Lock, another user must not hold even one of
		/// them.
		/// </remarks>
		public readonly static EloixClient.IndexServer.LockZ YES = new LockZ(1L);

		/// <summary>
		/// Lock or unlock regardless of whether the data is locked by another user.
		/// </summary>
		/// <remarks>
		/// This requires main adminstration privilleges in most cases.
		/// </remarks>
		public readonly static EloixClient.IndexServer.LockZ FORCE = new LockZ(2L);

		/// <summary>
		/// A lock is only set, if the record is unlocked.
		/// </summary>
		/// <remarks>
		/// A lock request is refused too, if the record is already a lock by the
		/// current user.
		/// </remarks>
		public readonly static EloixClient.IndexServer.LockZ IF_FREE = new LockZ(4L);

		/// <summary>
		/// Lock or unlock the indexing information.
		/// </summary>
		/// <remarks>
		/// Works like {@link LockC#YES} but
		/// is only valid at check*Sord() and check*Doc() respectively.
		/// </remarks>
		public readonly static EloixClient.IndexServer.LockZ SORD = new LockZ(8L);

		/// <summary>
		/// Lock or unlock document versions.
		/// </summary>
		/// <remarks>
		/// Works like {@link LockC#YES} but
		/// is only valid at check*Sord() and check*Doc() respectively.
		/// </remarks>
		public readonly static EloixClient.IndexServer.LockZ DOC = new LockZ(16L);

		#endregion
		
		
		public static readonly long serialVersionUID = 837669511L;		
	} // end class
}  // end namespace

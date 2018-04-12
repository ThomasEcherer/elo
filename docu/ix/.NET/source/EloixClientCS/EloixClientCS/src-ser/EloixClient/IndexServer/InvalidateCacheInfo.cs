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
	/// This class contains the parameters for the API function invalidateCache2
	/// </summary>
	public class InvalidateCacheInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public InvalidateCacheInfo() {
		}		
		
		public InvalidateCacheInfo(int @flags, int @id, IList<EloixClient.IndexServer.InvalidateCacheInfoParam> @parameters) {
			this.flagsValue = @flags;
			this.idValue = @id;
			this.parametersValue = @parameters;
		}		
		
		public InvalidateCacheInfo(InvalidateCacheInfo rhs) : base(rhs)
		{
			this.flagsValue = rhs.flagsValue;
			this.idValue = rhs.idValue;
			this.parametersValue = rhs.parametersValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// A combination of bits defined in InvalidateCacheC.
		/// </summary>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		/// <summary>
		/// A numeric ID to specify an object, workflow etc.
		/// </summary>
		/// <remarks>
		/// If <code>flags</code> contains <code>InvalidateC.WORKFLOWS</code> this element defines the ID
		/// of the active workflow to be updated in the cache.
		/// </remarks>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		public IList<EloixClient.IndexServer.InvalidateCacheInfoParam> parameters
		{
			get
			{
				return parametersValue;
			}
			set
			{
				this.parametersValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int flagsValue;

		protected int idValue;

		protected IList<EloixClient.IndexServer.InvalidateCacheInfoParam> parametersValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1441686860L;		
	} // end class
}  // end namespace

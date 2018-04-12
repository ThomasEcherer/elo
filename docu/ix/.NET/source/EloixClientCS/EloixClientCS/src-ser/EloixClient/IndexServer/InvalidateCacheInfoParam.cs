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
	/// ParamObject for InvalidateCacheInfo
	/// </summary>
	public class InvalidateCacheInfoParam : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public InvalidateCacheInfoParam() {
		}		
		
		public InvalidateCacheInfoParam(String @guid, int @flag, int @count) {
			this.guidValue = @guid;
			this.flagValue = @flag;
			this.countValue = @count;
		}		
		
		public InvalidateCacheInfoParam(InvalidateCacheInfoParam rhs) : base(rhs)
		{
			this.guidValue = rhs.guidValue;
			this.flagValue = rhs.flagValue;
			this.countValue = rhs.countValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
			}
		}
		
		
		public int flag
		{
			get
			{
				return flagValue;
			}
			set
			{
				this.flagValue = value;
			}
		}
		
		
		public int count
		{
			get
			{
				return countValue;
			}
			set
			{
				this.countValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String guidValue;

		protected int flagValue;

		protected int countValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 102205772L;		
	} // end class
}  // end namespace

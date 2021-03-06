﻿//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// This class encapsulates the constants of the UserTaskSortOrderC class.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class UserTaskSortOrderZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserTaskSortOrderZ() {
		}		
		
		public UserTaskSortOrderZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public UserTaskSortOrderZ(UserTaskSortOrderZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the UserTaskSortOrderC class.
		/// </summary>
		public long bset
		{
			get
			{
				return bsetValue;
			}
			set
			{
				this.bsetValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long bsetValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1199296467L;		
	} // end class
}  // end namespace

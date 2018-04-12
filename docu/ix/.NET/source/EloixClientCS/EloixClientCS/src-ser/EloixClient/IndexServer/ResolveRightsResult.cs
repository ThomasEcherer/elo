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
	/// Class for the result of the IX-Function
	/// {@link IXServicePortIF#resolveRights(ClientInfo, UserInfo, ResolveRightsInfo)}
	/// .
	/// </summary>
	public class ResolveRightsResult : BSerializable
	{
	
		#region Constructors
		
		public ResolveRightsResult() {
		}		
		
		public ResolveRightsResult(int @right, int @right2, int @type, IList<String> @members) {
			this.rightValue = @right;
			this.right2Value = @right2;
			this.typeValue = @type;
			this.membersValue = @members;
		}		
		
		public ResolveRightsResult(ResolveRightsResult rhs)
		{
			this.rightValue = rhs.rightValue;
			this.right2Value = rhs.right2Value;
			this.typeValue = rhs.typeValue;
			this.membersValue = rhs.membersValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The right the user got by {@link ResolveRightsResult#type}.
		/// </summary>
		/// <remarks>
		/// Values will be
		/// of {@link AccessC}.FLAG_*.
		/// </remarks>
		public int right
		{
			get
			{
				return rightValue;
			}
			set
			{
				this.rightValue = value;
			}
		}
		
		
		/// <summary>
		/// The right the user got by {@link ResolveRightsResult#type}.
		/// </summary>
		/// <remarks>
		/// Values will be
		/// of {@link AccessC}.FLAG2_*.
		/// </remarks>
		public int right2
		{
			get
			{
				return right2Value;
			}
			set
			{
				this.right2Value = value;
			}
		}
		
		
		/// <summary>
		/// The kind of way the user got this right.
		/// </summary>
		/// <remarks>
		/// See {@link ResolveRightsResultC}
		/// for valid values.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		/// <summary>
		/// Path of members that explains why the user got this right.
		/// </summary>
		/// <remarks>
		/// The first item
		/// in this list is the name of the object directly assigned to the user. The
		/// last item is the name of the object which obtains the right.
		/// </remarks>
		public IList<String> members
		{
			get
			{
				return membersValue;
			}
			set
			{
				this.membersValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int rightValue;

		protected int right2Value;

		protected int typeValue;

		protected IList<String> membersValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 973279163L;		
	} // end class
}  // end namespace

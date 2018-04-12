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
	/// This class contains the results returned by the function combineAcl.
	/// </summary>
	public class CombineAclResult : BSerializable
	{
	
		#region Constructors
		
		public CombineAclResult() {
		}		
		
		public CombineAclResult(int @compareCode, int @compareIgnoreAccessCode, EloixClient.IndexServer.AclItem[] @intersection, String @intersectionAclStr, EloixClient.IndexServer.AclItem[] @sum, String @sumAclStr, EloixClient.IndexServer.AclItem[] @difference, String @differenceAclStr, EloixClient.IndexServer.AclItem[] @inverseDifference, String @inverseDifferenceAclStr) {
			this.compareCodeValue = @compareCode;
			this.compareIgnoreAccessCodeValue = @compareIgnoreAccessCode;
			this.intersectionValue = @intersection;
			this.intersectionAclStrValue = @intersectionAclStr;
			this.sumValue = @sum;
			this.sumAclStrValue = @sumAclStr;
			this.differenceValue = @difference;
			this.differenceAclStrValue = @differenceAclStr;
			this.inverseDifferenceValue = @inverseDifference;
			this.inverseDifferenceAclStrValue = @inverseDifferenceAclStr;
		}		
		
		public CombineAclResult(CombineAclResult rhs)
		{
			this.compareCodeValue = rhs.compareCodeValue;
			this.compareIgnoreAccessCodeValue = rhs.compareIgnoreAccessCodeValue;
			this.intersectionValue = rhs.intersectionValue;
			this.intersectionAclStrValue = rhs.intersectionAclStrValue;
			this.sumValue = rhs.sumValue;
			this.sumAclStrValue = rhs.sumAclStrValue;
			this.differenceValue = rhs.differenceValue;
			this.differenceAclStrValue = rhs.differenceAclStrValue;
			this.inverseDifferenceValue = rhs.inverseDifferenceValue;
			this.inverseDifferenceAclStrValue = rhs.inverseDifferenceAclStrValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Compare result.
		/// </summary>
		/// <remarks>
		/// Negative if ACL lhs is less than rhs.
		/// Posiitve if ACL lhs is greater than rhs.
		/// Zero if ACLs are equal.
		/// </remarks>
		public int compareCode
		{
			get
			{
				return compareCodeValue;
			}
			set
			{
				this.compareCodeValue = value;
			}
		}
		
		
		/// <summary>
		/// Compare result by ignoring the member AclItem.access.
		/// </summary>
		/// <remarks>
		/// Negative if ACL lhs is less than rhs.
		/// Posiitve if ACL lhs is greater than rhs.
		/// Zero if ACLs are equal.
		/// </remarks>
		public int compareIgnoreAccessCode
		{
			get
			{
				return compareIgnoreAccessCodeValue;
			}
			set
			{
				this.compareIgnoreAccessCodeValue = value;
			}
		}
		
		
		/// <summary>
		/// Contains the ACL items that are in both ACLs.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] intersection
		{
			get
			{
				return intersectionValue;
			}
			set
			{
				this.intersectionValue = value;
			}
		}
		
		
		/// <summary>
		/// String representation of AclItem array intersection.
		/// </summary>
		public String intersectionAclStr
		{
			get
			{
				return intersectionAclStrValue;
			}
			set
			{
				this.intersectionAclStrValue = value;
			}
		}
		
		
		/// <summary>
		/// Contains the sum of both ACLs.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] sum
		{
			get
			{
				return sumValue;
			}
			set
			{
				this.sumValue = value;
			}
		}
		
		
		/// <summary>
		/// String representation of AclItem array sum.
		/// </summary>
		public String sumAclStr
		{
			get
			{
				return sumAclStrValue;
			}
			set
			{
				this.sumAclStrValue = value;
			}
		}
		
		
		/// <summary>
		/// Contains the ACL items that are in ACL lhs but not in rhs.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] difference
		{
			get
			{
				return differenceValue;
			}
			set
			{
				this.differenceValue = value;
			}
		}
		
		
		/// <summary>
		/// String representation of AclItem array difference.
		/// </summary>
		public String differenceAclStr
		{
			get
			{
				return differenceAclStrValue;
			}
			set
			{
				this.differenceAclStrValue = value;
			}
		}
		
		
		/// <summary>
		/// Contains the ACL items that are in ACL rhs but not in lhs.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] inverseDifference
		{
			get
			{
				return inverseDifferenceValue;
			}
			set
			{
				this.inverseDifferenceValue = value;
			}
		}
		
		
		/// <summary>
		/// String representation of AclItem array inverseDifference.
		/// </summary>
		public String inverseDifferenceAclStr
		{
			get
			{
				return inverseDifferenceAclStrValue;
			}
			set
			{
				this.inverseDifferenceAclStrValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int compareCodeValue;

		protected int compareIgnoreAccessCodeValue;

		protected EloixClient.IndexServer.AclItem[] intersectionValue;

		protected String intersectionAclStrValue;

		protected EloixClient.IndexServer.AclItem[] sumValue;

		protected String sumAclStrValue;

		protected EloixClient.IndexServer.AclItem[] differenceValue;

		protected String differenceAclStrValue;

		protected EloixClient.IndexServer.AclItem[] inverseDifferenceValue;

		protected String inverseDifferenceAclStrValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1034263904L;		
	} // end class
}  // end namespace

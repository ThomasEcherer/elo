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
	/// Objects of this class contain the returned data from IXServicePortIF.getDistinctValuesOfObjKey.
	/// </summary>
	public class ValuesOfObjKey : BSerializable
	{
	
		#region Constructors
		
		public ValuesOfObjKey() {
		}		
		
		public ValuesOfObjKey(String[] @values, int[] @usageCounts, int @totalCount) {
			this.valuesValue = @values;
			this.usageCountsValue = @usageCounts;
			this.totalCountValue = @totalCount;
		}		
		
		public ValuesOfObjKey(ValuesOfObjKey rhs)
		{
			this.valuesValue = rhs.valuesValue;
			this.usageCountsValue = rhs.usageCountsValue;
			this.totalCountValue = rhs.totalCountValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ObjKey values.
		/// </summary>
		public String[] values
		{
			get
			{
				return valuesValue;
			}
			set
			{
				this.valuesValue = value;
			}
		}
		
		
		/// <summary>
		/// For each entry values[i] the corresponding usageCount[i]
		/// tells how often the value is used.
		/// </summary>
		public int[] usageCounts
		{
			get
			{
				return usageCountsValue;
			}
			set
			{
				this.usageCountsValue = value;
			}
		}
		
		
		/// <summary>
		/// The sum of all usageCounts.
		/// </summary>
		public int totalCount
		{
			get
			{
				return totalCountValue;
			}
			set
			{
				this.totalCountValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] valuesValue;

		protected int[] usageCountsValue;

		protected int totalCountValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1153931872L;		
	} // end class
}  // end namespace

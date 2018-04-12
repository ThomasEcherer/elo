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
	/// Internal class.
	/// </summary>
	public class EloIxOpt_old : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EloIxOpt_old() {
		}		
		
		public EloIxOpt_old(int @optNo, String @optVal, String @remark) {
			this.optNoValue = @optNo;
			this.optValValue = @optVal;
			this.remarkValue = @remark;
		}		
		
		public EloIxOpt_old(EloIxOpt_old rhs) : base(rhs)
		{
			this.optNoValue = rhs.optNoValue;
			this.optValValue = rhs.optValValue;
			this.remarkValue = rhs.remarkValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optno
		/// </summary>
		public int optNo
		{
			get
			{
				return optNoValue;
			}
			set
			{
				this.optNoValue = value;
				setChangedMember(EloIxOpt_oldC.mbOptNo);
			}
		}
		
		
		/// <summary>
		/// DB column: optval
		/// </summary>
		public String optVal
		{
			get
			{
				return optValValue;
			}
			set
			{
				this.optValValue = value;
				setChangedMember(EloIxOpt_oldC.mbOptVal);
			}
		}
		
		
		/// <summary>
		/// DB column: remark
		/// </summary>
		public String remark
		{
			get
			{
				return remarkValue;
			}
			set
			{
				this.remarkValue = value;
				setChangedMember(EloIxOpt_oldC.mbRemark);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int optNoValue;

		protected String optValValue;

		protected String remarkValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 399031267L;		
	} // end class
}  // end namespace

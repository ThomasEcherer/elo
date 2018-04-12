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
	/// This class contains the results returned by the function checkoutWorkflowHistory.
	/// </summary>
	public class CheckoutWorkflowHistoryResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public CheckoutWorkflowHistoryResult() {
		}		
		
		public CheckoutWorkflowHistoryResult(IDictionary<int,List<EloixClient.IndexServer.WFNodeHistory>> @nodeHistories) {
			this.nodeHistoriesValue = @nodeHistories;
		}		
		
		public CheckoutWorkflowHistoryResult(CheckoutWorkflowHistoryResult rhs) : base(rhs)
		{
			this.nodeHistoriesValue = rhs.nodeHistoriesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Map of the node histories.
		/// </summary>
		/// <remarks>
		/// Node ID is the key.
		/// </remarks>
		public IDictionary<int,List<EloixClient.IndexServer.WFNodeHistory>> nodeHistories
		{
			get
			{
				return nodeHistoriesValue;
			}
			set
			{
				this.nodeHistoriesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IDictionary<int,List<EloixClient.IndexServer.WFNodeHistory>> nodeHistoriesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1754570852L;		
	} // end class
}  // end namespace

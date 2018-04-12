//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class FindBySordHist : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindBySordHist() {
		}		
		
		public FindBySordHist(EloixClient.IndexServer.SordHistKey[] @histKeys) {
			this.histKeysValue = @histKeys;
		}		
		
		public FindBySordHist(FindBySordHist rhs) : base(rhs)
		{
			this.histKeysValue = rhs.histKeysValue;
		}		
		
		#endregion
		
		#region Properties
		
		public EloixClient.IndexServer.SordHistKey[] histKeys
		{
			get
			{
				return histKeysValue;
			}
			set
			{
				this.histKeysValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.SordHistKey[] histKeysValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2098788325L;		
	} // end class
}  // end namespace

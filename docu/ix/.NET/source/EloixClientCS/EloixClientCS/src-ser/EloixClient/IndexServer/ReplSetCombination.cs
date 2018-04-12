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
	public class ReplSetCombination : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReplSetCombination() {
		}		
		
		public ReplSetCombination(String @guid, byte[] @combi) {
			this.guidValue = @guid;
			this.combiValue = @combi;
		}		
		
		public ReplSetCombination(ReplSetCombination rhs) : base(rhs)
		{
			this.guidValue = rhs.guidValue;
			this.combiValue = rhs.combiValue;
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
		
		
		public byte[] combi
		{
			get
			{
				return combiValue;
			}
			set
			{
				this.combiValue = value;
				setChangedMember(ReplSetCombinationC.mbCombiGuid);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String guidValue;

		protected byte[] combiValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2078338937L;		
	} // end class
}  // end namespace

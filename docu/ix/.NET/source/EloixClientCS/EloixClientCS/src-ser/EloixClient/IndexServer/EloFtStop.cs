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
	public class EloFtStop : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EloFtStop() {
		}		
		
		public EloFtStop(String @stopword) {
			this.stopwordValue = @stopword;
		}		
		
		public EloFtStop(EloFtStop rhs) : base(rhs)
		{
			this.stopwordValue = rhs.stopwordValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: stopword
		/// </summary>
		public String stopword
		{
			get
			{
				return stopwordValue;
			}
			set
			{
				this.stopwordValue = value;
				setChangedMember(EloFtStopC.mbStopword);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String stopwordValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2135577346L;		
	} // end class
}  // end namespace

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
	/// This class provides counters for use by the access manager.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class CounterInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public CounterInfo() {
		}		
		
		public CounterInfo(String @name, int @value) {
			this.nameValue = @name;
			this.valueValue = @value;
		}		
		
		public CounterInfo(CounterInfo rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.valueValue = rhs.valueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Name of the counter
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// The current value of the counter
		/// </summary>
		public int value
		{
			get
			{
				return valueValue;
			}
			set
			{
				this.valueValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected int valueValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1809378891L;		
	} // end class
}  // end namespace

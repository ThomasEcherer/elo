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
	/// This class contains a name and an associated value.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class KeyValue : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public KeyValue() {
		}		
		
		public KeyValue(String @key, String @value) {
			this.keyValue = @key;
			this.valueValue = @value;
		}		
		
		public KeyValue(KeyValue rhs) : base(rhs)
		{
			this.keyValue = rhs.keyValue;
			this.valueValue = rhs.valueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Key or identifying name.
		/// </summary>
		public String key
		{
			get
			{
				return keyValue;
			}
			set
			{
				this.keyValue = value;
			}
		}
		
		
		/// <summary>
		/// Associated value.
		/// </summary>
		public String value
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
		
		protected String keyValue;

		protected String valueValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 516301248L;		
	} // end class
}  // end namespace

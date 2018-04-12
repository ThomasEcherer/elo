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
	/// Objects of this class hold an array of options that are used to manipulate the
	/// current IndexServer session.
	/// </summary>
	public class SessionOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SessionOptions() {
		}		
		
		public SessionOptions(EloixClient.IndexServer.KeyValue[] @options) {
			this.optionsValue = @options;
		}		
		
		public SessionOptions(SessionOptions rhs) : base(rhs)
		{
			this.optionsValue = rhs.optionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Array containing options used for the Index Server session.
		/// </summary>
		public EloixClient.IndexServer.KeyValue[] options
		{
			get
			{
				return optionsValue;
			}
			set
			{
				this.optionsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.KeyValue[] optionsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1197100286L;		
	} // end class
}  // end namespace

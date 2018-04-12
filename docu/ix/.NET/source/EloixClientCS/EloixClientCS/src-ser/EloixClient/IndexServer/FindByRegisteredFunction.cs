//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class FindByRegisteredFunction : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByRegisteredFunction() {
		}		
		
		public FindByRegisteredFunction(String @functionName, EloixClient.IndexServer.Any @args) {
			this.functionNameValue = @functionName;
			this.argsValue = @args;
		}		
		
		public FindByRegisteredFunction(FindByRegisteredFunction rhs) : base(rhs)
		{
			this.functionNameValue = rhs.functionNameValue;
			this.argsValue = rhs.argsValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String functionName
		{
			get
			{
				return functionNameValue;
			}
			set
			{
				this.functionNameValue = value;
			}
		}
		
		
		public EloixClient.IndexServer.Any args
		{
			get
			{
				return argsValue;
			}
			set
			{
				this.argsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String functionNameValue;

		protected EloixClient.IndexServer.Any argsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 700871698L;		
	} // end class
}  // end namespace

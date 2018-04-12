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
	/// Options for function {@link IXServicePortIF#evalAutoFiling(ClientInfo, String, Sord, AutoFilingOptions)}
	/// </summary>
	public class AutoFilingOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public AutoFilingOptions() {
		}		
		
		public AutoFilingOptions(String @autoFilingDefinition) {
			this.autoFilingDefinitionValue = @autoFilingDefinition;
		}		
		
		public AutoFilingOptions(AutoFilingOptions rhs) : base(rhs)
		{
			this.autoFilingDefinitionValue = rhs.autoFilingDefinitionValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Auto filing index string.
		/// </summary>
		/// <remarks>
		/// If this option is set, paramter <code>maskId</code> in {@link IXServicePortIF#evalAutoFiling(ClientInfo, String, Sord, AutoFilingOptions)}
		/// is ignored.
		/// </remarks>
		public String autoFilingDefinition
		{
			get
			{
				return autoFilingDefinitionValue;
			}
			set
			{
				this.autoFilingDefinitionValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String autoFilingDefinitionValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 225606439L;		
	} // end class
}  // end namespace

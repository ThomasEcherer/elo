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
	/// This class make possible the count of the archive elements.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2008</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ProcessCountElements : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessCountElements() {
		}		
		
		public ProcessCountElements(EloixClient.IndexServer.CountResult @countResult) {
			this.countResultValue = @countResult;
		}		
		
		public ProcessCountElements(ProcessCountElements rhs) : base(rhs)
		{
			this.countResultValue = rhs.countResultValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Result of the countprocess.
		/// </summary>
		public EloixClient.IndexServer.CountResult countResult
		{
			get
			{
				return countResultValue;
			}
			set
			{
				this.countResultValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.CountResult countResultValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1130489422L;		
	} // end class
}  // end namespace

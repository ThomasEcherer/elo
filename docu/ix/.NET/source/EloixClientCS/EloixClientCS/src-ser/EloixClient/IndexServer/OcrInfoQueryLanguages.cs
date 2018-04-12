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
	/// This class describes a request for querying the supported languages of the OCR.
	/// </summary>
	public class OcrInfoQueryLanguages : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrInfoQueryLanguages() {
		}		
		
		public OcrInfoQueryLanguages(int @ctrl) {
			this.ctrlValue = @ctrl;
		}		
		
		public OcrInfoQueryLanguages(OcrInfoQueryLanguages rhs) : base(rhs)
		{
			this.ctrlValue = rhs.ctrlValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public int ctrl
		{
			get
			{
				return ctrlValue;
			}
			set
			{
				this.ctrlValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int ctrlValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 648095775L;		
	} // end class
}  // end namespace

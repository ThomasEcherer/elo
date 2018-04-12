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
	/// This class contains the result of a OcrInfoQueryLanguages request.
	/// </summary>
	public class OcrResultQueryLanguages : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrResultQueryLanguages() {
		}		
		
		public OcrResultQueryLanguages(String[] @externalLangs, String[] @internalLangs) {
			this.externalLangsValue = @externalLangs;
			this.internalLangsValue = @internalLangs;
		}		
		
		public OcrResultQueryLanguages(OcrResultQueryLanguages rhs) : base(rhs)
		{
			this.externalLangsValue = rhs.externalLangsValue;
			this.internalLangsValue = rhs.internalLangsValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String[] externalLangs
		{
			get
			{
				return externalLangsValue;
			}
			set
			{
				this.externalLangsValue = value;
			}
		}
		
		
		public String[] internalLangs
		{
			get
			{
				return internalLangsValue;
			}
			set
			{
				this.internalLangsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] externalLangsValue;

		protected String[] internalLangsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 916614291L;		
	} // end class
}  // end namespace

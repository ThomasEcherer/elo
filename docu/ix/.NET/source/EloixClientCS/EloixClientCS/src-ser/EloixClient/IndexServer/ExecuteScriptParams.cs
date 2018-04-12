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
	/// This class is used to specify which script has to be executed in
	/// function executeScript.
	/// </summary>
	/// <remarks>
	/// The script has to be an ELO Windows CLIENT OLE-Automation script.
	/// </remarks>
	public class ExecuteScriptParams : BSerializable
	{
	
		#region Constructors
		
		public ExecuteScriptParams() {
		}		
		
		public ExecuteScriptParams(String @scriptEngine, EloixClient.IndexServer.FileData @scriptCode, String @scriptString, String @scriptObjId, String @functionName, String[] @functionParams) {
			this.scriptEngineValue = @scriptEngine;
			this.scriptCodeValue = @scriptCode;
			this.scriptStringValue = @scriptString;
			this.scriptObjIdValue = @scriptObjId;
			this.functionNameValue = @functionName;
			this.functionParamsValue = @functionParams;
		}		
		
		public ExecuteScriptParams(ExecuteScriptParams rhs)
		{
			this.scriptEngineValue = rhs.scriptEngineValue;
			this.scriptCodeValue = rhs.scriptCodeValue;
			this.scriptStringValue = rhs.scriptStringValue;
			this.scriptObjIdValue = rhs.scriptObjIdValue;
			this.functionNameValue = rhs.functionNameValue;
			this.functionParamsValue = rhs.functionParamsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// This value defines the scripting engine to be used to execute the script.
		/// </summary>
		/// <remarks>
		/// Currently, this value must be null or empty or "EloixAuto".
		/// If the value is null or empty, EloixAuto is used by default.
		/// </remarks>
		public String scriptEngine
		{
			get
			{
				return scriptEngineValue;
			}
			set
			{
				this.scriptEngineValue = value;
			}
		}
		
		
		/// <summary>
		/// This object contains the script code to be executed as a byte array.
		/// </summary>
		/// <remarks>
		/// The FileData.contentType is either "text/javascript" or "text/vbscript".
		/// FileData.data has to be encoded in UTF-8.
		/// The scriptCode.data length must be less or equal than 65535.
		/// If this member is set, the members scriptString and scriptObjId should be null.
		/// </remarks>
		public EloixClient.IndexServer.FileData scriptCode
		{
			get
			{
				return scriptCodeValue;
			}
			set
			{
				this.scriptCodeValue = value;
			}
		}
		
		
		/// <summary>
		/// This object contains the script code to be executed as a string object.
		/// </summary>
		/// <remarks>
		/// The string must either start with "javascript:" or "vbscript:".
		/// The maximum scriptString length is 65535 UTF-8 characters.
		/// If this member is set, the members scriptCode and scriptObjId should be null.
		/// </remarks>
		public String scriptString
		{
			get
			{
				return scriptStringValue;
			}
			set
			{
				this.scriptStringValue = value;
			}
		}
		
		
		/// <summary>
		/// If the script to be executed is available in the ELO archive,
		/// this member can specify the object ID (or ARCPATH: - see checkoutSord)
		/// of the script document.
		/// </summary>
		/// <remarks>
		/// The file is assumed to be encoded in characterset ISO-8859-1, if it does not start with a BOM.
		/// If this member is set, the members scriptCode and scriptString should be null.
		/// </remarks>
		public String scriptObjId
		{
			get
			{
				return scriptObjIdValue;
			}
			set
			{
				this.scriptObjIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Call this function in the script code.
		/// </summary>
		/// <remarks>
		/// A function defined in script code that was supplied in a previsious call can be invoked too,
		/// as long as this object does not specify scriptCode, scriptString or scriptObjId.
		/// </remarks>
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
		
		
		/// <summary>
		/// Function parameters.
		/// </summary>
		public String[] functionParams
		{
			get
			{
				return functionParamsValue;
			}
			set
			{
				this.functionParamsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String scriptEngineValue;

		protected EloixClient.IndexServer.FileData scriptCodeValue;

		protected String scriptStringValue;

		protected String scriptObjIdValue;

		protected String functionNameValue;

		protected String[] functionParamsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 936440117L;		
	} // end class
}  // end namespace

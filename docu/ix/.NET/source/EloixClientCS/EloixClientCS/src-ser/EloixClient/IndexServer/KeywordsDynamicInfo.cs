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
	/// This Class contains parameters for the IX call
	/// {@link IXServicePortIF#checkoutKeywordsDynamic(ClientInfo, KeywordsDynamicInfo)}
	/// .
	/// </summary>
	/// <remarks>
	/// <p>
	/// There are two ways to execute the script for dynamic keyword lists. According
	/// to the parameter in this class, the one way or the other is chosen. The first
	/// way is to specify {@link KeywordsDynamicInfo#sord} and
	/// {@link KeywordsDynamicInfo#maskLineFocus}. Then, the IX passes these
	/// parameters to the script via the script-function open(ec, sord, fieldName).
	/// The other parameters will be overwritten by <code>null</code> and completely
	/// ignored. The other way is to set the fields
	/// {@link KeywordsDynamicInfo#mapData}, {@link KeywordsDynamicInfo#mapLineFocus}
	/// and {@link KeywordsDynamicInfo#mapScriptName}. In this case, the IX passes
	/// these parameters to the scripting function openMap(ec, data, fieldName). To
	/// achieve this, <code>sord</code> as well as <code>maskLineFocus</code> must be
	/// <code>null</code>.
	/// </p>
	/// </remarks>
	public class KeywordsDynamicInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public KeywordsDynamicInfo() {
		}		
		
		public KeywordsDynamicInfo(EloixClient.IndexServer.Sord @sord, EloixClient.IndexServer.DocMaskLine @maskLineFocus, String @mapScriptName, String @mapLineFocus, IDictionary<String,String> @mapData) {
			this.sordValue = @sord;
			this.maskLineFocusValue = @maskLineFocus;
			this.mapScriptNameValue = @mapScriptName;
			this.mapLineFocusValue = @mapLineFocus;
			this.mapDataValue = @mapData;
		}		
		
		public KeywordsDynamicInfo(KeywordsDynamicInfo rhs) : base(rhs)
		{
			this.sordValue = rhs.sordValue;
			this.maskLineFocusValue = rhs.maskLineFocusValue;
			this.mapScriptNameValue = rhs.mapScriptNameValue;
			this.mapLineFocusValue = rhs.mapLineFocusValue;
			this.mapDataValue = rhs.mapDataValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// <p>
		/// This value contains data gathered by the client.
		/// </summary>
		/// <remarks>
		/// The contents of sord will
		/// be given to the script to execute.
		/// </p>
		/// </remarks>
		public EloixClient.IndexServer.Sord sord
		{
			get
			{
				return sordValue;
			}
			set
			{
				this.sordValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// At the client, set this value to the mask line that currently has the
		/// focus.
		/// </summary>
		/// <remarks>
		/// This value determines the server script to be executed. The server
		/// only reads the members maskId and id. For the server-side processing
		/// necessary residual values are read from the database.
		/// </p>
		/// <p>
		/// The focused mask line is passed to the script to execute. Ignoring this
		/// value in the script is a valid use case.
		/// </p>
		/// </remarks>
		public EloixClient.IndexServer.DocMaskLine maskLineFocus
		{
			get
			{
				return maskLineFocusValue;
			}
			set
			{
				this.maskLineFocusValue = value;
			}
		}
		
		
		/// <summary>
		/// Determines the script to execute.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This value has only an effect if sord and maskLineFocus are set to null.
		/// Setting this value requires to set the values mapLineFocus and mapData
		/// also.
		/// </p>
		/// </remarks>
		public String mapScriptName
		{
			get
			{
				return mapScriptNameValue;
			}
			set
			{
				this.mapScriptNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Represents the id of a field in a form.
		/// </summary>
		public String mapLineFocus
		{
			get
			{
				return mapLineFocusValue;
			}
			set
			{
				this.mapLineFocusValue = value;
			}
		}
		
		
		/// <summary>
		/// Represents the input data of a form.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The script to execute uses the values in this map to filter the resulting
		/// data set.
		/// </p>
		/// </remarks>
		public IDictionary<String,String> mapData
		{
			get
			{
				return mapDataValue;
			}
			set
			{
				this.mapDataValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.Sord sordValue;

		protected EloixClient.IndexServer.DocMaskLine maskLineFocusValue;

		protected String mapScriptNameValue;

		protected String mapLineFocusValue;

		protected IDictionary<String,String> mapDataValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2008405893L;		
	} // end class
}  // end namespace

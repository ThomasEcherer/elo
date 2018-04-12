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
	/// <p>
	/// The class KeywordsDynamicResult defines the return value of the IX call
	/// {@link IXServicePortIF#checkoutKeywordsDynamic(ClientInfo, KeywordsDynamicInfo)}
	/// .
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class KeywordsDynamicResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public KeywordsDynamicResult() {
		}		
		
		public KeywordsDynamicResult(IList<IList<String>> @table, IList<String> @header, IList<String> @keyNames, String @message, bool @moreResults, String @title, IList<IDictionary<String,String>> @columnProperties) {
			this.tableValue = @table;
			this.headerValue = @header;
			this.keyNamesValue = @keyNames;
			this.messageValue = @message;
			this.moreResultsValue = @moreResults;
			this.titleValue = @title;
			this.columnPropertiesValue = @columnProperties;
		}		
		
		public KeywordsDynamicResult(KeywordsDynamicResult rhs) : base(rhs)
		{
			this.tableValue = rhs.tableValue;
			this.headerValue = rhs.headerValue;
			this.keyNamesValue = rhs.keyNamesValue;
			this.messageValue = rhs.messageValue;
			this.moreResultsValue = rhs.moreResultsValue;
			this.titleValue = rhs.titleValue;
			this.columnPropertiesValue = rhs.columnPropertiesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// <p>
		/// This value contains the result set as a table.
		/// </summary>
		/// <remarks>
		/// Each entry of the outer list
		/// represents a row in the table. Thus, the entry <b>i</b> of an inner list
		/// represents the value of the <b>i</b>. column of the actual row. The length
		/// of each inner list is identical to the total amount of columns. Entries
		/// without a value are represented by an empty string.
		/// </p>
		/// </remarks>
		public IList<IList<String>> table
		{
			get
			{
				return tableValue;
			}
			set
			{
				this.tableValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// This list contains the column descriptions to be displayed as the header of
		/// the <code>table</code> at the client.
		/// </summary>
		/// <remarks>
		/// The size of this list matches the
		/// amount of columns in <code>table</code>. The value at index <b>i</b>
		/// represents the column description of the column <b>i</b>. The first column
		/// index is 0. Columns without a header value must be represented by an empty
		/// or undefined string.
		/// </p>
		/// </remarks>
		public IList<String> header
		{
			get
			{
				return headerValue;
			}
			set
			{
				this.headerValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// List of key names.
		/// </summary>
		/// <remarks>
		/// The size of this list equals to <code>header</code>. In
		/// this list, columns without a key name are represented by null or an empty
		/// String.
		/// </p>
		/// </remarks>
		public IList<String> keyNames
		{
			get
			{
				return keyNamesValue;
			}
			set
			{
				this.keyNamesValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// The executed script may provide additional informations to the client such
		/// as "Please fill field XYZ".
		/// </summary>
		/// <remarks>
		/// Such informations are stored in the value
		/// <code>message</code>. The script has to provide the translation to the
		/// client's language.
		/// </p>
		/// </remarks>
		public String message
		{
			get
			{
				return messageValue;
			}
			set
			{
				this.messageValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Is true if there are more results.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
		public bool moreResults
		{
			get
			{
				return moreResultsValue;
			}
			set
			{
				this.moreResultsValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// A brief and succinctly description about the represented data.
		/// </summary>
		/// <remarks>
		/// The script
		/// developer must provide a title, otherwise an exception is thrown.
		/// </p>
		/// </remarks>
		public String title
		{
			get
			{
				return titleValue;
			}
			set
			{
				this.titleValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// List of column properties.
		/// </summary>
		/// <remarks>
		/// The size of this list equals to
		/// <code>header</code>. If the value at position <i>i</i> is null, the client
		/// will use a default value for the properties of column <i>i</i>.
		/// </p>
		/// </remarks>
		public IList<IDictionary<String,String>> columnProperties
		{
			get
			{
				return columnPropertiesValue;
			}
			set
			{
				this.columnPropertiesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IList<IList<String>> tableValue;

		protected IList<String> headerValue;

		protected IList<String> keyNamesValue;

		protected String messageValue;

		protected bool moreResultsValue;

		protected String titleValue;

		protected IList<IDictionary<String,String>> columnPropertiesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1552114559L;		
	} // end class
}  // end namespace

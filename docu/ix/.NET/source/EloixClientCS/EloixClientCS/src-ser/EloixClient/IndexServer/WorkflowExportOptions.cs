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
	/// Structure for the options for the workflow-export.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2009
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class WorkflowExportOptions : BSerializable
	{
	
		#region Constructors
		
		public WorkflowExportOptions() {
		}		
		
		public WorkflowExportOptions(String @flowId, String @flowVersId, String @characterSet, String @wordWrap, int @format) {
			this.flowIdValue = @flowId;
			this.flowVersIdValue = @flowVersId;
			this.characterSetValue = @characterSet;
			this.wordWrapValue = @wordWrap;
			this.formatValue = @format;
		}		
		
		public WorkflowExportOptions(WorkflowExportOptions rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.flowVersIdValue = rhs.flowVersIdValue;
			this.characterSetValue = rhs.characterSetValue;
			this.wordWrapValue = rhs.wordWrapValue;
			this.formatValue = rhs.formatValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Id of the workflow, that will be exported.
		/// </summary>
		public String flowId
		{
			get
			{
				return flowIdValue;
			}
			set
			{
				this.flowIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public String flowVersId
		{
			get
			{
				return flowVersIdValue;
			}
			set
			{
				this.flowVersIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Character set for the export-data.
		/// </summary>
		public String characterSet
		{
			get
			{
				return characterSetValue;
			}
			set
			{
				this.characterSetValue = value;
			}
		}
		
		
		/// <summary>
		/// Word wrap for the export-data.
		/// </summary>
		public String wordWrap
		{
			get
			{
				return wordWrapValue;
			}
			set
			{
				this.wordWrapValue = value;
			}
		}
		
		
		/// <summary>
		/// Export format.
		/// </summary>
		public int format
		{
			get
			{
				return formatValue;
			}
			set
			{
				this.formatValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String flowIdValue;

		protected String flowVersIdValue;

		protected String characterSetValue;

		protected String wordWrapValue;

		protected int formatValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 402835780L;		
	} // end class
}  // end namespace

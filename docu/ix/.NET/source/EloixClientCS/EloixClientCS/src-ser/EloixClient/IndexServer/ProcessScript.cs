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
	/// NOT CURRENTLY SUPPORTED
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ProcessScript : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessScript() {
		}		
		
		public ProcessScript(String @name, bool @processPostfix, String @tag) {
			this.nameValue = @name;
			this.processPostfixValue = @processPostfix;
			this.tagValue = @tag;
		}		
		
		public ProcessScript(ProcessScript rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.processPostfixValue = rhs.processPostfixValue;
			this.tagValue = rhs.tagValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Script name.
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// execution position in tree walks.
		/// </summary>
		public bool processPostfix
		{
			get
			{
				return processPostfixValue;
			}
			set
			{
				this.processPostfixValue = value;
			}
		}
		
		
		/// <summary>
		/// user defined tag.
		/// </summary>
		public String tag
		{
			get
			{
				return tagValue;
			}
			set
			{
				this.tagValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected bool processPostfixValue;

		protected String tagValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1122555546L;		
	} // end class
}  // end namespace

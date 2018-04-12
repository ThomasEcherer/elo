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
	/// This class defines the options for IXServicePortIF.findActivityProjects.
	/// </summary>
	public class FindActivityProjectsInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindActivityProjectsInfo() {
		}		
		
		public FindActivityProjectsInfo(String @projectName) {
			this.projectNameValue = @projectName;
		}		
		
		public FindActivityProjectsInfo(FindActivityProjectsInfo rhs) : base(rhs)
		{
			this.projectNameValue = rhs.projectNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Project name.
		/// </summary>
		/// <remarks>
		/// This value can contain wildcards.
		/// </remarks>
		public String projectName
		{
			get
			{
				return projectNameValue;
			}
			set
			{
				this.projectNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String projectNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 151574948L;		
	} // end class
}  // end namespace

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
	/// <p>Bit constants for members of ActivityProject</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ActivityProjectDataC : BSerializable
	{
	
		#region Constructors
		
		public ActivityProjectDataC() {
		}		
		
		public ActivityProjectDataC(int @lnProject, int @lnOptValue) {
			this.lnProjectValue = @lnProject;
			this.lnOptValueValue = @lnOptValue;
		}		
		
		public ActivityProjectDataC(ActivityProjectDataC rhs)
		{
			this.lnProjectValue = rhs.lnProjectValue;
			this.lnOptValueValue = rhs.lnOptValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: project
		/// </summary>
		public int lnProject
		{
			get
			{
				return lnProjectValue;
			}
			set
			{
				this.lnProjectValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: optvalue
		/// </summary>
		public int lnOptValue
		{
			get
			{
				return lnOptValueValue;
			}
			set
			{
				this.lnOptValueValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: project
		/// </summary>
		public const long mbProject = 1L;

		protected int lnProjectValue;

		/// <summary>
		/// DB column: major
		/// </summary>
		public const long mbMajor = 2L;

		/// <summary>
		/// DB column: minor
		/// </summary>
		public const long mbMinor = 4L;

		/// <summary>
		/// DB column: optvalue
		/// </summary>
		public const long mbOptValue = 8L;

		protected int lnOptValueValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 15L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1946995741L;		
	} // end class
}  // end namespace

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
	/// This class represents an activity project.
	/// </summary>
	/// <remarks>
	/// An activity project is a template for an activity.
	/// </remarks>
	public class ActivityProject : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ActivityProject() {
		}		
		
		public ActivityProject(String @project, int @major, int @minor, String @optValue, EloixClient.IndexServer.ActivityOption[] @options, bool @protectedProject, bool @lockedWhenFinished) {
			this.projectValue = @project;
			this.majorValue = @major;
			this.minorValue = @minor;
			this.optValueValue = @optValue;
			this.optionsValue = @options;
			this.protectedProjectValue = @protectedProject;
			this.lockedWhenFinishedValue = @lockedWhenFinished;
		}		
		
		public ActivityProject(ActivityProject rhs) : base(rhs)
		{
			this.projectValue = rhs.projectValue;
			this.majorValue = rhs.majorValue;
			this.minorValue = rhs.minorValue;
			this.optValueValue = rhs.optValueValue;
			this.optionsValue = rhs.optionsValue;
			this.protectedProjectValue = rhs.protectedProjectValue;
			this.lockedWhenFinishedValue = rhs.lockedWhenFinishedValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Project name.
		/// </summary>
		/// <remarks>
		/// This can be one of the predefined project names: ActivityProjectC.DEFAULT, ActivityProjectC.REQUEST, ActivityProjectC.NOTIFY.
		/// Or an arbitrary name for an application defined use case.
		/// The name must be unique because it is internally used as an ID.
		/// It has to start with a letter and must only contain letters, numbers or underscores.
		/// </remarks>
		public String project
		{
			get
			{
				return projectValue;
			}
			set
			{
				this.projectValue = value;
				setChangedMember(ActivityProjectC.mbProject);
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public int major
		{
			get
			{
				return majorValue;
			}
			set
			{
				this.majorValue = value;
				setChangedMember(ActivityProjectC.mbMajor);
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public int minor
		{
			get
			{
				return minorValue;
			}
			set
			{
				this.minorValue = value;
				setChangedMember(ActivityProjectC.mbMinor);
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public String optValue
		{
			get
			{
				return optValueValue;
			}
			set
			{
				this.optValueValue = value;
				setChangedMember(ActivityProjectC.mbOptValue);
			}
		}
		
		
		/// <summary>
		/// Options.
		/// </summary>
		public EloixClient.IndexServer.ActivityOption[] options
		{
			get
			{
				return optionsValue;
			}
			set
			{
				this.optionsValue = value;
				setChangedMember(ActivityProjectC.mbOptions);
			}
		}
		
		
		/// <summary>
		/// Activity project is protected.
		/// </summary>
		public bool protectedProject
		{
			get
			{
				return protectedProjectValue;
			}
			set
			{
				this.protectedProjectValue = value;
			}
		}
		
		
		/// <summary>
		/// Activity project is locked when finished.
		/// </summary>
		public bool lockedWhenFinished
		{
			get
			{
				return lockedWhenFinishedValue;
			}
			set
			{
				this.lockedWhenFinishedValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String projectValue;

		protected int majorValue;

		protected int minorValue;

		protected String optValueValue;

		protected EloixClient.IndexServer.ActivityOption[] optionsValue;

		protected bool protectedProjectValue;

		protected bool lockedWhenFinishedValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2121298555L;		
	} // end class
}  // end namespace

//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class MyELOState : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MyELOState() {
		}		
		
		public MyELOState(String @userGuid, bool @newFeed, bool @newWorkflow, bool @newTask) {
			this.userGuidValue = @userGuid;
			this.newFeedValue = @newFeed;
			this.newWorkflowValue = @newWorkflow;
			this.newTaskValue = @newTask;
		}		
		
		public MyELOState(MyELOState rhs) : base(rhs)
		{
			this.userGuidValue = rhs.userGuidValue;
			this.newFeedValue = rhs.newFeedValue;
			this.newWorkflowValue = rhs.newWorkflowValue;
			this.newTaskValue = rhs.newTaskValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String userGuid
		{
			get
			{
				return userGuidValue;
			}
			set
			{
				this.userGuidValue = value;
			}
		}
		
		
		public bool newFeed
		{
			get
			{
				return newFeedValue;
			}
			set
			{
				this.newFeedValue = value;
			}
		}
		
		
		public bool newWorkflow
		{
			get
			{
				return newWorkflowValue;
			}
			set
			{
				this.newWorkflowValue = value;
			}
		}
		
		
		public bool newTask
		{
			get
			{
				return newTaskValue;
			}
			set
			{
				this.newTaskValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String userGuidValue;

		protected bool newFeedValue;

		protected bool newWorkflowValue;

		protected bool newTaskValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1426941339L;		
	} // end class
}  // end namespace

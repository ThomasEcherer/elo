//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class MyELOInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MyELOInfo() {
		}		
		
		public MyELOInfo(EloixClient.IndexServer.feed.FindNotificationInfo @notificationInfo, EloixClient.IndexServer.FindWorkflowInfo @workflowInfo, EloixClient.IndexServer.FindTasksInfo @taskInfo, String @date, int @max) {
			this.notificationInfoValue = @notificationInfo;
			this.workflowInfoValue = @workflowInfo;
			this.taskInfoValue = @taskInfo;
			this.dateValue = @date;
			this.maxValue = @max;
		}		
		
		public MyELOInfo(MyELOInfo rhs) : base(rhs)
		{
			this.notificationInfoValue = rhs.notificationInfoValue;
			this.workflowInfoValue = rhs.workflowInfoValue;
			this.taskInfoValue = rhs.taskInfoValue;
			this.dateValue = rhs.dateValue;
			this.maxValue = rhs.maxValue;
		}		
		
		#endregion
		
		#region Properties
		
		public EloixClient.IndexServer.feed.FindNotificationInfo notificationInfo
		{
			get
			{
				return notificationInfoValue;
			}
			set
			{
				this.notificationInfoValue = value;
			}
		}
		
		
		public EloixClient.IndexServer.FindWorkflowInfo workflowInfo
		{
			get
			{
				return workflowInfoValue;
			}
			set
			{
				this.workflowInfoValue = value;
			}
		}
		
		
		public EloixClient.IndexServer.FindTasksInfo taskInfo
		{
			get
			{
				return taskInfoValue;
			}
			set
			{
				this.taskInfoValue = value;
			}
		}
		
		
		public String date
		{
			get
			{
				return dateValue;
			}
			set
			{
				this.dateValue = value;
			}
		}
		
		
		public int max
		{
			get
			{
				return maxValue;
			}
			set
			{
				this.maxValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.feed.FindNotificationInfo notificationInfoValue;

		protected EloixClient.IndexServer.FindWorkflowInfo workflowInfoValue;

		protected EloixClient.IndexServer.FindTasksInfo taskInfoValue;

		protected String dateValue;

		protected int maxValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 455864090L;		
	} // end class
}  // end namespace

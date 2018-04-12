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
	/// This class is used as a parameter in the function {@link IXServicePortIF#delegateWorkFlowNode(ClientInfo, WFDelegateNodeInfo, LockZ)}.
	/// </summary>
	public class WFDelegateNodeInfo : BSerializable
	{
	
		#region Constructors
		
		public WFDelegateNodeInfo() {
		}		
		
		public WFDelegateNodeInfo(String @flowId, int @nodeId, String @delegateToUserId, IList<String> @delegateToUserIds, bool @delegateParallel, String @delegateNodeName, String @delegateNodeComment, String @backNodeName, String @backNodeComment, int @delegateNodeMoveX, int @delegateNodeMoveY, int @backNodeMoveX, int @backNodeMoveY, EloixClient.IndexServer.WFNodeZ @copyMembersToDelegateNodeZ, EloixClient.IndexServer.WFNodeZ @copyMembersToBackNodeZ) {
			this.flowIdValue = @flowId;
			this.nodeIdValue = @nodeId;
			this.delegateToUserIdValue = @delegateToUserId;
			this.delegateToUserIdsValue = @delegateToUserIds;
			this.delegateParallelValue = @delegateParallel;
			this.delegateNodeNameValue = @delegateNodeName;
			this.delegateNodeCommentValue = @delegateNodeComment;
			this.backNodeNameValue = @backNodeName;
			this.backNodeCommentValue = @backNodeComment;
			this.delegateNodeMoveXValue = @delegateNodeMoveX;
			this.delegateNodeMoveYValue = @delegateNodeMoveY;
			this.backNodeMoveXValue = @backNodeMoveX;
			this.backNodeMoveYValue = @backNodeMoveY;
			this.copyMembersToDelegateNodeZValue = @copyMembersToDelegateNodeZ;
			this.copyMembersToBackNodeZValue = @copyMembersToBackNodeZ;
		}		
		
		public WFDelegateNodeInfo(WFDelegateNodeInfo rhs)
		{
			this.flowIdValue = rhs.flowIdValue;
			this.nodeIdValue = rhs.nodeIdValue;
			this.delegateToUserIdValue = rhs.delegateToUserIdValue;
			this.delegateToUserIdsValue = rhs.delegateToUserIdsValue;
			this.delegateParallelValue = rhs.delegateParallelValue;
			this.delegateNodeNameValue = rhs.delegateNodeNameValue;
			this.delegateNodeCommentValue = rhs.delegateNodeCommentValue;
			this.backNodeNameValue = rhs.backNodeNameValue;
			this.backNodeCommentValue = rhs.backNodeCommentValue;
			this.delegateNodeMoveXValue = rhs.delegateNodeMoveXValue;
			this.delegateNodeMoveYValue = rhs.delegateNodeMoveYValue;
			this.backNodeMoveXValue = rhs.backNodeMoveXValue;
			this.backNodeMoveYValue = rhs.backNodeMoveYValue;
			this.copyMembersToDelegateNodeZValue = rhs.copyMembersToDelegateNodeZValue;
			this.copyMembersToBackNodeZValue = rhs.copyMembersToBackNodeZValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Workflow ID, GUID or name
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
		/// Node ID
		/// </summary>
		public int nodeId
		{
			get
			{
				return nodeIdValue;
			}
			set
			{
				this.nodeIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Name or ID of user or group to whom the workflow is delegated.
		/// </summary>
		public String delegateToUserId
		{
			get
			{
				return delegateToUserIdValue;
			}
			set
			{
				this.delegateToUserIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Names or IDs of users or groups to whom the workflow is delegated.
		/// </summary>
		/// <remarks>
		/// The delegation nodes are organized serial or parallel as defined by member {@link #delegateParallel}.
		/// </remarks>
		public IList<String> delegateToUserIds
		{
			get
			{
				return delegateToUserIdsValue;
			}
			set
			{
				this.delegateToUserIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// Delegate parallel or serial to the list of users.
		/// </summary>
		/// <remarks>
		/// if {@link #delegateToUserIds} is not null or empty, this member describes how the
		/// nodes created for delegation are connected.
		/// <p>Set this member as true, if all delegation nodes
		/// should be activated directly. The delegation returns, if at least one of the users forwards
		/// her/his node.
		/// </p>
		/// <p>
		/// Set this member as false, if the delegation nodes should be lined up one after another.
		/// The delegation returns, if all users have forwarded their nodes.
		/// </p>
		/// Ignored, if {@link #delegateToUserIds} is null or empty.
		/// </remarks>
		public bool delegateParallel
		{
			get
			{
				return delegateParallelValue;
			}
			set
			{
				this.delegateParallelValue = value;
			}
		}
		
		
		/// <summary>
		/// Name of the new node
		/// </summary>
		public String delegateNodeName
		{
			get
			{
				return delegateNodeNameValue;
			}
			set
			{
				this.delegateNodeNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Description of the new node
		/// </summary>
		public String delegateNodeComment
		{
			get
			{
				return delegateNodeCommentValue;
			}
			set
			{
				this.delegateNodeCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// Name of the back node.
		/// </summary>
		public String backNodeName
		{
			get
			{
				return backNodeNameValue;
			}
			set
			{
				this.backNodeNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Description of the back node.
		/// </summary>
		public String backNodeComment
		{
			get
			{
				return backNodeCommentValue;
			}
			set
			{
				this.backNodeCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// Horizontal distance between the active node and the delegation node.
		/// </summary>
		/// <remarks>
		/// Recommended value is 240.
		/// </remarks>
		public int delegateNodeMoveX
		{
			get
			{
				return delegateNodeMoveXValue;
			}
			set
			{
				this.delegateNodeMoveXValue = value;
			}
		}
		
		
		/// <summary>
		/// Vertical distance between the active node and the delegation node.
		/// </summary>
		/// <remarks>
		/// Recommended value is 0.
		/// </remarks>
		public int delegateNodeMoveY
		{
			get
			{
				return delegateNodeMoveYValue;
			}
			set
			{
				this.delegateNodeMoveYValue = value;
			}
		}
		
		
		/// <summary>
		/// Horizontal distance between the active node and the back node.
		/// </summary>
		/// <remarks>
		/// Recommended value is 0.
		/// </remarks>
		public int backNodeMoveX
		{
			get
			{
				return backNodeMoveXValue;
			}
			set
			{
				this.backNodeMoveXValue = value;
			}
		}
		
		
		/// <summary>
		/// Vertical distance between the active node and the back node.
		/// </summary>
		/// <remarks>
		/// Recommended value is 80.
		/// </remarks>
		public int backNodeMoveY
		{
			get
			{
				return backNodeMoveYValue;
			}
			set
			{
				this.backNodeMoveYValue = value;
			}
		}
		
		
		/// <summary>
		/// This selector defines which members of the node specified by nodeId are copied
		/// to the delegated node.
		/// </summary>
		/// <remarks>
		/// If this value is null, all node members are copied except the following:
		/// WFNodeC.mbId|
		/// WFNodeC.mbDelayDate|WFNodeC.mbDelayDateIso|
		/// WFNodeC.mbEnterDate|WFNodeC.mbEnterDateIso|
		/// WFNodeC.mbExitDate|WFNodeC.mbExitDateIso|
		/// WFNodeC.mbInUseDate|WFNodeC.mbInUseDateIso|
		/// WFNodeC.mbUserDelayDate|WFNodeC.mbUserDelayDateIso|
		/// WFNodeC.mbIsNext
		/// overwrite the members copied due copyMembersToDelegateNodeZ.
		/// The member WFNode.formSpec is always copied from the current node and need not to be included in copyMembersToDelegateNodeZ.
		/// </remarks>
		public EloixClient.IndexServer.WFNodeZ copyMembersToDelegateNodeZ
		{
			get
			{
				return copyMembersToDelegateNodeZValue;
			}
			set
			{
				this.copyMembersToDelegateNodeZValue = value;
			}
		}
		
		
		/// <summary>
		/// This selector defines which members of the current node are copied
		/// to the node that leads back to the current user.
		/// </summary>
		/// <remarks>
		/// If this value is null, the following members are copied by default:
		/// <code>WFNodeC.mbFlags|WFNodeC.mbMoveCyclePosX|WFNodeC.mbObjKeyNames|WFNodeC.mbScriptNames|WFNodeC.mbTag|WFNodeC.mbTimeLimit|WFNodeC.mbTimeLimitEscalations</code>.
		/// The members given or evaluated by backNodeName, backNodeComment, backNodeMoveX and backNodeMoveY overwrite the members copied due copyMembersToBackNodeZ.
		/// The following members are always copied from the current node:
		/// WFNode.userId, WFNode.userName, WFNode.designDepartment, WFNode.department2, WFNode.formSpec and need not to be included in copyMembersToBackNodeZ.
		/// </remarks>
		public EloixClient.IndexServer.WFNodeZ copyMembersToBackNodeZ
		{
			get
			{
				return copyMembersToBackNodeZValue;
			}
			set
			{
				this.copyMembersToBackNodeZValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String flowIdValue;

		protected int nodeIdValue;

		protected String delegateToUserIdValue;

		protected IList<String> delegateToUserIdsValue;

		protected bool delegateParallelValue;

		protected String delegateNodeNameValue;

		protected String delegateNodeCommentValue;

		protected String backNodeNameValue;

		protected String backNodeCommentValue;

		protected int delegateNodeMoveXValue;

		protected int delegateNodeMoveYValue;

		protected int backNodeMoveXValue;

		protected int backNodeMoveYValue;

		protected EloixClient.IndexServer.WFNodeZ copyMembersToDelegateNodeZValue;

		protected EloixClient.IndexServer.WFNodeZ copyMembersToBackNodeZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 20892334L;		
	} // end class
}  // end namespace

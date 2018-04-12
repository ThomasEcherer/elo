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
	/// <p>Constants for workflows.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class WFDiagramC : BSerializable
	{
	
		#region Constructors
		
		public WFDiagramC() {
		}		
		
		public WFDiagramC(int @lnName, int @lnGuid, int @lnTStamp, int @lnProcessOnServerId, int @lnNameTranslationKey) {
			this.lnNameValue = @lnName;
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnProcessOnServerIdValue = @lnProcessOnServerId;
			this.lnNameTranslationKeyValue = @lnNameTranslationKey;
		}		
		
		public WFDiagramC(WFDiagramC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnProcessOnServerIdValue = rhs.lnProcessOnServerIdValue;
			this.lnNameTranslationKeyValue = rhs.lnNameTranslationKeyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum length of workflow name.
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of workflow GUID.
		/// </summary>
		public int lnGuid
		{
			get
			{
				return lnGuidValue;
			}
			set
			{
				this.lnGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of workflow TStamp.
		/// </summary>
		public int lnTStamp
		{
			get
			{
				return lnTStampValue;
			}
			set
			{
				this.lnTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of processOnServerId.
		/// </summary>
		public int lnProcessOnServerId
		{
			get
			{
				return lnProcessOnServerIdValue;
			}
			set
			{
				this.lnProcessOnServerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of the name's translation key.
		/// </summary>
		public int lnNameTranslationKey
		{
			get
			{
				return lnNameTranslationKeyValue;
			}
			set
			{
				this.lnNameTranslationKeyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Maximum number of subnodes.
		/// </summary>
		public const int MAX_SUBNODES = 20;

		/// <summary>
		/// ID
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// Name
		/// </summary>
		public const long mbName = 2L;

		protected int lnNameValue;

		/// <summary>
		/// Object ID
		/// </summary>
		public const long mbObjId = 4L;

		/// <summary>
		/// Object type.
		/// </summary>
		public const long mbObjType = 8L;

		/// <summary>
		/// Completed at this date.
		/// </summary>
		public const long mbCompletionDate = 16L;

		/// <summary>
		/// Nodes.
		/// </summary>
		public const long mbNodes = 32L;

		/// <summary>
		/// Node matrix.
		/// </summary>
		public const long mbMatrix = 64L;

		/// <summary>
		/// Member bit: Alert user.
		/// </summary>
		public const long mbTimeLimitUserId = 128L;

		/// <summary>
		/// Member bit: Time-limit.
		/// </summary>
		public const long mbTimeLimit = 256L;

		/// <summary>
		/// Member bit: StartDate.
		/// </summary>
		public const long mbStartDate = 512L;

		/// <summary>
		/// Member bit: acl and aclItems.
		/// </summary>
		public const long mbAcl = 1024L;

		/// <summary>
		/// Member bit: ownerId and ownerName
		/// </summary>
		public const long mbOwnerId = 2048L;

		/// <summary>
		/// Member bit: lockId and lockName
		/// </summary>
		public const long mbLockId = 4096L;

		/// <summary>
		/// Member bit: prio
		/// </summary>
		public const long mbPrio = 8192L;

		/// <summary>
		/// Member bit: deleted
		/// </summary>
		public const long mbDeleted = 16384L;

		/// <summary>
		/// Member bit: templateId
		/// </summary>
		public const long mbTemplateId = 32768L;

		/// <summary>
		/// Member bit: flags
		/// </summary>
		public const long mbFlags = 65536L;

		/// <summary>
		/// Member bit: access
		/// </summary>
		public const long mbAccess = 131072L;

		/// <summary>
		/// Member bit: access
		/// </summary>
		public const long mbVersion = 262144L;

		/// <summary>
		/// Member bit: Guid
		/// </summary>
		public const long mbGuid = 524288L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: TStamp
		/// </summary>
		public const long mbTStamp = 1048576L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: processOnServerId
		/// </summary>
		public const long mbProcessOnServerId = 2097152L;

		protected int lnProcessOnServerIdValue;

		/// <summary>
		/// Member bit: timeLimitEscalation
		/// </summary>
		public const long mbTimeLimitEscalations = 4194304L;

		/// <summary>
		/// Member bit: objName
		/// </summary>
		public const long mbObjName = 8388608L;

		/// <summary>
		/// Nodes required for worfklow overview in ELO Java Client.
		/// </summary>
		/// <remarks>
		/// Includes begin node, active nodes, exceeded nodes.
		/// </remarks>
		public const long mbNodesOverview = 16777216L;

		/// <summary>
		/// Member bit: TStampSync
		/// </summary>
		public const long mbTStampSync = 33554432L;

		protected int lnNameTranslationKeyValue;

		/// <summary>
		/// Member bit: nameTranslationKey
		/// </summary>
		public const long mbNameTranslationKey = 33554432L;

		/// <summary>
		/// Member bit: {@link WFDiagram#subWorkflows}.
		/// </summary>
		public const long mbSubWorkflows = 67108864L;

		/// <summary>
		/// Member bit: {@link WFDiagram#callNodeId}.
		/// </summary>
		public const long mbCallNodeId = 134217728L;

		/// <summary>
		/// Prefix of all scripts selectable as finish scripts for adhoc workflows
		/// </summary>
		public const String ADHOC_WF_FINISH_SCRIPT_PREFIX = "adhoc_";

		/// <summary>
		/// All elements.
		/// </summary>
		public const long mbAllMembers = 268435455L;

		public const long mbLeanMembers = 268435359L;

		public readonly static EloixClient.IndexServer.WFDiagramZ mbLean = new WFDiagramZ(268435359L);

		public readonly static EloixClient.IndexServer.WFDiagramZ mbAll = new WFDiagramZ(268435455L);

		public readonly static EloixClient.IndexServer.WFDiagramZ mbOnlyLock = new WFDiagramZ(4096L);

		public const long mbAclItems = 1024L;

		public const long mbCompletionDateIso = 16L;

		public const long mbOwnerName = 2048L;

		public const long mbStartDateIso = 512L;

		public const long mbTemplateName = 32768L;

		public const long mbTimeLimitIso = 256L;

		public const long mbTimeLimitUserName = 128L;

		public const long mbType = 1L;

		/// <summary>
		/// Compare this value to WFDiagram.templateId to check whether the workflow
		/// was started as an adhoc workflow.
		/// </summary>
		/// <remarks>
		/// This member is for convenience. You can
		/// also check the flag FLAG_ROOT_ADHOC of the root node.
		/// </remarks>
		public const int TEMPLATE_ID_ADHOC = -2;

		#endregion
		
		
		public static readonly long serialVersionUID = 1231341428L;		
	} // end class
}  // end namespace

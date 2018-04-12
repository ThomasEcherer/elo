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
	/// Specific processing information for each node of processTrees(...) or processFindResults(...).
	/// </summary>
	/// <remarks>
	/// The operations will be for existence (not null) in order of their appearance in ProcessInfo.
	/// Some of the underlying structures may allow toggling between prefix and postfix processing
	/// when used with processTrees.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ProcessInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessInfo() {
		}		
		
		public ProcessInfo(int @delStatus, String @desc, int @errorMode, bool @ignoreDocuments, bool @ignoreStructures, EloixClient.IndexServer.LockZ @lockZ, EloixClient.IndexServer.ProcessAcl @procAcl, EloixClient.IndexServer.ProcessFulltext @procFulltext, EloixClient.IndexServer.ProcessCountElements @procCountElem, EloixClient.IndexServer.ProcessMoveDocumentsToStoragePath @procMoveDocumentsToStoragePath, EloixClient.IndexServer.ProcessCopyElements @procCopyElements, int @procMsgMax, String[] @procMsgs, EloixClient.IndexServer.ProcessReplSet @procReplSet, EloixClient.IndexServer.ProcessScript @procScript, bool @forceOperation, bool @inclReferences, EloixClient.IndexServer.ProcessReleaseLock @procReleaseLock, EloixClient.IndexServer.ProcessInheritKeywording @procInheritKeywording) {
			this.delStatusValue = @delStatus;
			this.descValue = @desc;
			this.errorModeValue = @errorMode;
			this.ignoreDocumentsValue = @ignoreDocuments;
			this.ignoreStructuresValue = @ignoreStructures;
			this.lockZValue = @lockZ;
			this.procAclValue = @procAcl;
			this.procFulltextValue = @procFulltext;
			this.procCountElemValue = @procCountElem;
			this.procMoveDocumentsToStoragePathValue = @procMoveDocumentsToStoragePath;
			this.procCopyElementsValue = @procCopyElements;
			this.procMsgMaxValue = @procMsgMax;
			this.procMsgsValue = @procMsgs;
			this.procReplSetValue = @procReplSet;
			this.procScriptValue = @procScript;
			this.forceOperationValue = @forceOperation;
			this.inclReferencesValue = @inclReferences;
			this.procReleaseLockValue = @procReleaseLock;
			this.procInheritKeywordingValue = @procInheritKeywording;
		}		
		
		public ProcessInfo(ProcessInfo rhs) : base(rhs)
		{
			this.delStatusValue = rhs.delStatusValue;
			this.descValue = rhs.descValue;
			this.errorModeValue = rhs.errorModeValue;
			this.ignoreDocumentsValue = rhs.ignoreDocumentsValue;
			this.ignoreStructuresValue = rhs.ignoreStructuresValue;
			this.lockZValue = rhs.lockZValue;
			this.procAclValue = rhs.procAclValue;
			this.procFulltextValue = rhs.procFulltextValue;
			this.procCountElemValue = rhs.procCountElemValue;
			this.procMoveDocumentsToStoragePathValue = rhs.procMoveDocumentsToStoragePathValue;
			this.procCopyElementsValue = rhs.procCopyElementsValue;
			this.procMsgMaxValue = rhs.procMsgMaxValue;
			this.procMsgsValue = rhs.procMsgsValue;
			this.procReplSetValue = rhs.procReplSetValue;
			this.procScriptValue = rhs.procScriptValue;
			this.forceOperationValue = rhs.forceOperationValue;
			this.inclReferencesValue = rhs.inclReferencesValue;
			this.procReleaseLockValue = rhs.procReleaseLockValue;
			this.procInheritKeywordingValue = rhs.procInheritKeywordingValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// pass 0 for valid (undeleted) nodes, &gt;0 otherwise.
		/// </summary>
		public int delStatus
		{
			get
			{
				return delStatusValue;
			}
			set
			{
				this.delStatusValue = value;
			}
		}
		
		
		/// <summary>
		/// Holds the user defined description of a specific call.
		/// </summary>
		/// <remarks>
		/// This member
		/// must not be null or empty.
		/// </remarks>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
			}
		}
		
		
		/// <summary>
		/// From ProcessInfoC: ERRORMODE_ALL, ERRORMODE_SKIP_SUBTREE,
		/// ERRORMODE_SKIP_PROCINFO or ERRORMODE_CRITICAL_ONLY.
		/// </summary>
		public int errorMode
		{
			get
			{
				return errorModeValue;
			}
			set
			{
				this.errorModeValue = value;
			}
		}
		
		
		/// <summary>
		/// processing flag for documents.
		/// </summary>
		public bool ignoreDocuments
		{
			get
			{
				return ignoreDocumentsValue;
			}
			set
			{
				this.ignoreDocumentsValue = value;
			}
		}
		
		
		/// <summary>
		/// processing flag for structure elements.
		/// </summary>
		public bool ignoreStructures
		{
			get
			{
				return ignoreStructuresValue;
			}
			set
			{
				this.ignoreStructuresValue = value;
			}
		}
		
		
		/// <summary>
		/// Use this parameter to access potentially locked nodes.
		/// </summary>
		public EloixClient.IndexServer.LockZ lockZ
		{
			get
			{
				return lockZValue;
			}
			set
			{
				this.lockZValue = value;
			}
		}
		
		
		/// <summary>
		/// Prefix processing, valid ProcessAcl data.
		/// </summary>
		public EloixClient.IndexServer.ProcessAcl procAcl
		{
			get
			{
				return procAclValue;
			}
			set
			{
				this.procAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Prefix processing, valid ProcessFulltext data.
		/// </summary>
		public EloixClient.IndexServer.ProcessFulltext procFulltext
		{
			get
			{
				return procFulltextValue;
			}
			set
			{
				this.procFulltextValue = value;
			}
		}
		
		
		/// <summary>
		/// Prefix processing count all elements
		/// </summary>
		public EloixClient.IndexServer.ProcessCountElements procCountElem
		{
			get
			{
				return procCountElemValue;
			}
			set
			{
				this.procCountElemValue = value;
			}
		}
		
		
		/// <summary>
		/// Move documents to storage path.
		/// </summary>
		public EloixClient.IndexServer.ProcessMoveDocumentsToStoragePath procMoveDocumentsToStoragePath
		{
			get
			{
				return procMoveDocumentsToStoragePathValue;
			}
			set
			{
				this.procMoveDocumentsToStoragePathValue = value;
			}
		}
		
		
		/// <summary>
		/// Copy the elements into other archive location.
		/// </summary>
		public EloixClient.IndexServer.ProcessCopyElements procCopyElements
		{
			get
			{
				return procCopyElementsValue;
			}
			set
			{
				this.procCopyElementsValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum amount of recorded errors in procMsgs; from ProcessInfoC: PROCMSGMAX.
		/// </summary>
		public int procMsgMax
		{
			get
			{
				return procMsgMaxValue;
			}
			set
			{
				this.procMsgMaxValue = value;
			}
		}
		
		
		/// <summary>
		/// Recorded error messages; specify their amount using procMsgMax.
		/// </summary>
		public String[] procMsgs
		{
			get
			{
				return procMsgsValue;
			}
			set
			{
				this.procMsgsValue = value;
			}
		}
		
		
		/// <summary>
		/// Prefix processing, valid ProcessReplSet data.
		/// </summary>
		public EloixClient.IndexServer.ProcessReplSet procReplSet
		{
			get
			{
				return procReplSetValue;
			}
			set
			{
				this.procReplSetValue = value;
			}
		}
		
		
		/// <summary>
		/// Either prefix or postfix processing.
		/// </summary>
		public EloixClient.IndexServer.ProcessScript procScript
		{
			get
			{
				return procScriptValue;
			}
			set
			{
				this.procScriptValue = value;
			}
		}
		
		
		/// <summary>
		/// Defines, if the data allways have to be written
		/// </summary>
		public bool forceOperation
		{
			get
			{
				return forceOperationValue;
			}
			set
			{
				this.forceOperationValue = value;
			}
		}
		
		
		/// <summary>
		/// Process references (logical copies) too.
		/// </summary>
		public bool inclReferences
		{
			get
			{
				return inclReferencesValue;
			}
			set
			{
				this.inclReferencesValue = value;
			}
		}
		
		
		/// <summary>
		/// Release the locks on processed elements.
		/// </summary>
		public EloixClient.IndexServer.ProcessReleaseLock procReleaseLock
		{
			get
			{
				return procReleaseLockValue;
			}
			set
			{
				this.procReleaseLockValue = value;
			}
		}
		
		
		/// <summary>
		/// Inherit keywording.
		/// </summary>
		public EloixClient.IndexServer.ProcessInheritKeywording procInheritKeywording
		{
			get
			{
				return procInheritKeywordingValue;
			}
			set
			{
				this.procInheritKeywordingValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int delStatusValue;

		protected String descValue;

		protected int errorModeValue;

		protected bool ignoreDocumentsValue;

		protected bool ignoreStructuresValue;

		protected EloixClient.IndexServer.LockZ lockZValue;

		protected EloixClient.IndexServer.ProcessAcl procAclValue;

		protected EloixClient.IndexServer.ProcessFulltext procFulltextValue;

		protected EloixClient.IndexServer.ProcessCountElements procCountElemValue;

		protected EloixClient.IndexServer.ProcessMoveDocumentsToStoragePath procMoveDocumentsToStoragePathValue;

		protected EloixClient.IndexServer.ProcessCopyElements procCopyElementsValue;

		protected int procMsgMaxValue;

		protected String[] procMsgsValue;

		protected EloixClient.IndexServer.ProcessReplSet procReplSetValue;

		protected EloixClient.IndexServer.ProcessScript procScriptValue;

		protected bool forceOperationValue;

		protected bool inclReferencesValue;

		protected EloixClient.IndexServer.ProcessReleaseLock procReleaseLockValue;

		protected EloixClient.IndexServer.ProcessInheritKeywording procInheritKeywordingValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1037318967L;		
	} // end class
}  // end namespace

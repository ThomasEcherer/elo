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
	/// Constants for replication codes.
	/// </summary>
	public class ReplCode : BSerializable
	{
	
		#region Constructors
		
		public ReplCode() {
		}		
		
		public ReplCode(ReplCode rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Change code: Modify the indexing information (without
		/// <code>Sord.getObjKeys()</code>) of an archive entry (<code>Sord</code>).
		/// </summary>
		public const int ARCR_OBJECT_DATA = 2;

		public const String ARCR_OBJECT_DATA_S = "obj";

		/// <summary>
		/// Change code: Modify the indexing information (only
		/// <code>Sord.getObjKeys()</code>) of an archive entry (<code>Sord</code>).
		/// </summary>
		public const int ARCR_OBJECT_KEYS = 4;

		public const String ARCR_OBJECT_KEYS_S = "key";

		/// <summary>
		/// Change code: Create or modify a note.
		/// </summary>
		public const int ARCR_NOTE_DATA = 8;

		public const String ARCR_NOTE_DATA_S = "not";

		/// <summary>
		/// Change code: Delete a note.
		/// </summary>
		public const int ARCR_NOTE_DELETE = 16;

		public const String ARCR_NOTE_DELETE_S = "ndl";

		/// <summary>
		/// Change code: Changed document comment
		/// </summary>
		public const int ARCR_VERSION_COMMENT = 32;

		public const String ARCR_VERSION_COMMENT_S = "dvc";

		/// <summary>
		/// Change code: Change all references to children.
		/// </summary>
		public const int ARCR_OBJECT_RELATIONS = 64;

		public const String ARCR_OBJECT_RELATIONS_S = "orl";

		/// <summary>
		/// Change code: Insert a (logical) reference inside an archive entry.
		/// </summary>
		public const int ARCR_OBJECT_INSERT_REF = 128;

		public const String ARCR_OBJECT_INSERT_REF_S = "irl";

		/// <summary>
		/// Change code: Delete a (logical) reference inside an archive entry.
		/// </summary>
		public const int ARCR_OBJECT_DELETE_REF = 256;

		public const String ARCR_OBJECT_DELETE_REF_S = "drl";

		/// <summary>
		/// Change code: Insert a document and change the work version of the
		/// associated archive entry.
		/// </summary>
		public const int ARCR_DOCUMENT_DATA = 512;

		public const String ARCR_DOCUMENT_DATA_S = "doc";

		/// <summary>
		/// Change code: Insert a document but do not change the work version of the
		/// associated archive entry.
		/// </summary>
		public const int ARCR_DOCUMENT_INSERT = 1024;

		public const String ARCR_DOCUMENT_INSERT_S = "din";

		/// <summary>
		/// Change code: Select another work version from the document history.
		/// </summary>
		public const int ARCR_DOCUMENT_SWITCH = 2048;

		public const String ARCR_DOCUMENT_SWITCH_S = "dsw";

		/// <summary>
		/// Change code: Insert or change an attachment.
		/// </summary>
		public const int ARCR_ATTACHMENT_DATA = 4096;

		public const String ARCR_ATTACHMENT_DATA_S = "att";

		/// <summary>
		/// Change code: Create a document signature
		/// </summary>
		public const int ARCR_SIGNATURE_DATA = 8192;

		public const String ARCR_SIGNATURE_DATA_S = "sig";

		/// <summary>
		/// Change code: Ignore the optional broker optimization anyway a) selective
		/// export b) VDS
		/// </summary>
		public const int ARCR_IGNORE_BROKER_OPTZ = 16384;

		public const String ARCR_IGNORE_BROKER_OPTZ_S = "ibo";

		/// <summary>
		/// Change code: Document flags and/or document delete status have been changed
		/// </summary>
		public const int ARCR_DOCUMENT_STATUS = 32768;

		public const String ARCR_DOCUMENT_STATUS_S = "dst";

		/// <summary>
		/// Change code: Master data.
		/// </summary>
		/// <remarks>
		/// Exports the names of storage masks, keys, users.
		/// </remarks>
		public const int ARCR_BASEDATA_VERIFY = 65536;

		public const String ARCR_BASEDATA_VERIFY_S = "bvy";

		/// <summary>
		/// Change code: Exports the storage masks.
		/// </summary>
		public const int ARCR_DOCMASKS_DATA = 131072;

		public const String ARCR_DOCMASKS_DATA_S = "dms";

		/// <summary>
		/// Change code: Delete object finally.
		/// </summary>
		public const int ARCR_OBJECT_DELETE_PHYS = 262144;

		public const String ARCR_OBJECT_DELETE_PHYS_S = "dpy";

		/// <summary>
		/// Change code: Change the replication sets of an archive entry.
		/// </summary>
		public const int ARCR_OBJECT_REPLSET = 524288;

		public const String ARCR_OBJECT_REPLSET_S = "orp";

		/// <summary>
		/// Change code: Change a workflow.
		/// </summary>
		public const int ARCR_WORKFLOW_DATA = 1048576;

		public const String ARCR_WORKFLOW_DATA_S = "wfl";

		/// <summary>
		/// Change flag: This flag is added to ARCR_OBJECT_DATA if replication performs
		/// a full export.
		/// </summary>
		public const int ARCR_INITIAL_DATA = 2097152;

		public const String ARCR_INITIAL_DATA_S = "ini";

		/// <summary>
		/// Change code: Set a replication marker.
		/// </summary>
		public const int ARCR_MARKER = 4194304;

		public const String ARCR_MARKER_S = "mrk";

		/// <summary>
		/// Change code: Create a new entry for the object history
		/// </summary>
		public const int ARCR_OBJECT_HIST = 8388608;

		public const String ARCR_OBJECT_HIST_S = "hst";

		/// <summary>
		/// Change flag: This flag is contained in some change codes to extend the
		/// number of possible change codes.
		/// </summary>
		public const int ARCR_SET2 = 16777216;

		/// <summary>
		/// Change flag: This flag is contained in some change codes to extend the
		/// number of possible change codes.
		/// </summary>
		public const int ARCR_SET16 = 234881024;

		/// <summary>
		/// Change flags: Bits of this value are contained in some change codes to
		/// extend the number of possible change codes.
		/// </summary>
		public const int ARCR_EXTENDED_SET = 251658240;

		/// <summary>
		/// Change code: Insert, modify, delete activities.
		/// </summary>
		public const int ARCR_ACTION = 16777217;

		public const String ARCR_ACTION_S = "act";

		/// <summary>
		/// Change code: Insert or modify user data.
		/// </summary>
		public const int ARCR_USER_DATA = 16777218;

		public const String ARCR_USER_DATA_S = "usr";

		/// <summary>
		/// Change code: Delete a user.
		/// </summary>
		public const int ARCR_USER_DELETE = 16777219;

		public const String ARCR_USER_DELETE_S = "usd";

		/// <summary>
		/// Change code: Insert or modify storage mask data.
		/// </summary>
		/// <remarks>
		/// (reserved)
		/// </remarks>
		public const int ARCR_TRANSLATION = 16777220;

		public const String ARCR_TRANSLATION_S = "tra";

		/// <summary>
		/// Change code: Delete a storage mask.
		/// </summary>
		/// <remarks>
		/// (reserved)
		/// </remarks>
		public const int ARCR_DOCMASK_DELETE = 16777221;

		public const String ARCR_DOCMASK_DELETE_S = "dmd";

		public const int ARCR_DOCUMENT_FEED = 16777224;

		public const String ARCR_DOCUMENT_FEED_S = "fed";

		public const int ARCR_LINK = 16777232;

		public const String ARCR_LINK_S = "lnk";

		/// <summary>
		/// Change code: map changed
		/// </summary>
		public const int ARCR_MAP_CHANGED = 16777221;

		public const String ARCR_MAP_CHANGED_S = "map";

		/// <summary>
		/// Change code: A keyword list has been modified Param: 1 fÃ¼r Stichwortliste
		/// geÃ¤ndert, 2 fÃ¼r Stichwortliste gelÃ¶scht
		/// </summary>
		public const int ARCR_SWL_DATA = 16777222;

		public const String ARCR_SWL_DATA_S = "dwl";

		public const int PARAM_SWL_UPDATED = 1;

		public const int PARAM_SWL_DELETED = 2;

		/// <summary>
		/// Change code: A VDS has been created
		/// </summary>
		public const int ARCR_CONTROL_VDS = 16777223;

		public const String ARCR_CONTROL_VDS_S = "vds";

		/// <summary>
		/// Change code: Transformation table for master data (broker-to-broker
		/// replication).
		/// </summary>
		public const int ARCR_TRAFO = 1073741824;

		public const String ARCR_TRAFO_S = "tra";

		/// <summary>
		/// Change flag: This flag marks a change record to be a control record for the
		/// broker.
		/// </summary>
		public const int ARCR_BROKER = -2147483648;

		public const String ARCR_BROKER_S = "brk";

		public const String ARCR_CODE_SEP = "|";

		public const String ARCR_EXT_CODE_UNDEF_S = "???";

		#endregion
		
		
		public static readonly long serialVersionUID = 1235558040L;		
	} // end class
}  // end namespace

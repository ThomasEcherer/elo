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
	/// Constants related to the event bus API.
	/// </summary>
	public class EventBusC : BSerializable
	{
	
		#region Constructors
		
		public EventBusC() {
		}		
		
		public EventBusC(EventBusC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Broadcast bus ID.
		/// </summary>
		/// <remarks>
		/// The EventBusC.BUSID_BROADCAST refers to a
		/// public communication channel that can used by all applications and users.
		/// Any user can send events to this bus and is allowed to listen to it.
		/// </remarks>
		public const long BUSID_BROADCAST = -1L;

		/// <summary>
		/// User related bus ID.
		/// </summary>
		/// <remarks>
		/// For each user, an event bus exists with the bus ID EventBusC.BUSID_USER + user-ID. Any user can send
		/// events to this bus but only the owning user can listen to it.
		/// </remarks>
		public const long BUSID_USER = 0L;

		/// <summary>
		/// Reserved.
		/// </summary>
		public const long BUSID_MAX_SYSTEM = 1000000L;

		/// <summary>
		/// Open chat event type.
		/// </summary>
		/// <remarks>
		/// Events of this type are used to invite subscribers
		/// to open a public final static chat channel.
		/// </remarks>
		public const long EVENT_TYPE_OPEN_CHAT = 2L;

		/// <summary>
		/// Chat event type.
		/// </summary>
		/// <remarks>
		/// Events of this type contain chat text.
		/// </remarks>
		public const long EVENT_TYPE_CHAT = 3L;

		/// <summary>
		/// Close chat event type.
		/// </summary>
		/// <remarks>
		/// An event of this type is sent to notify the subscribers that the
		/// chat channel (resp. event bus) will be closed shortly.
		/// </remarks>
		public const long EVENT_TYPE_CLOSE_CHAT = 4L;

		/// <summary>
		/// Watch folder event.
		/// </summary>
		/// <remarks>
		/// An event of this type is sent, if the contents of a given folder have been changed.
		/// <p>
		/// In order to register a listener for such events, the folder to be watched has to be
		/// specified with an object ID expression in <code>EventFilter.param2</code>(see checkoutSord):
		/// <pre><code>
		/// IXConnection conn = ...
		/// 
		/// // Folder to be watched
		/// int folderId = ...
		/// 
		/// // Register listener
		/// conn.getEventBusApi().getBroadcastBus().addListener(
		/// EventBusC.EVENT_TYPE_WATCH_FOLDER,
		/// Integer.toString(folderId) );
		/// </code></pre>
		/// </p><p>
		/// For each modified Sord object in the watched folder, the client application receives one <code>Event</code>,
		/// whereby the data members are set as follows:
		/// <pre><code>
		/// Event ev = ...
		/// 
		/// // Folder being watched
		/// int folderId = Integer.parseInt(ev.getParam2());
		/// 
		/// // Arguments
		/// Object[] args = (Object[])AnyToObject.toObject(ev.getAny());
		/// 
		/// // Inserted, updated (e.g. locked) or deleted Sord
		/// Sord sord = (Sord)args[0];
		/// 
		/// // Valid members of args[0]
		/// SordZ sordMembersZ = (SordZ)args[1];
		/// 
		/// // What has happened: EventBusC.WATCH_INSERT, EventBusC.WATCH_UPDATE, EventBusC.WATCH_DELETE
		/// int what = (Integer)args[2];
		/// </code></pre>
		/// </p><p>
		/// Watch folder events are sent to every current acitve connection, provided that a listener
		/// was registered for it and the associated user has at least read access to the changed object.
		/// It is also sent to the connection that fires this event.
		/// </p>
		/// </remarks>
		public const long EVENT_TYPE_WATCH_FOLDER = 10L;

		/// <summary>
		/// An object was inserted.
		/// </summary>
		public const int WATCH_INSERT = 1;

		/// <summary>
		/// An object was updated, locked or unlocked.
		/// </summary>
		public const int WATCH_UPDATE = 2;

		/// <summary>
		/// An object was deleted.
		/// </summary>
		public const int WATCH_DELETE = 4;

		/// <summary>
		/// OCR Request Event.
		/// </summary>
		/// <remarks>
		/// OCR Worker Processes listen to this event and process OCR on the supplied image data.
		/// In order to listen for this event, the session user must have the permission FLAG_ADMIN.
		/// </remarks>
		public const long EVENT_OCR_REQUEST = 101L;

		/// <summary>
		/// OCR Finished Event.
		/// </summary>
		/// <remarks>
		/// OCR Worker Process sends this event if the OCR processing is finished.
		/// The client application initiates a OCR request by calling API function processOCR.
		/// It receives an Event ID
		/// </remarks>
		public const long EVENT_OCR_RESULT = 102L;

		/// <summary>
		/// Notify about status change in fulltext indexing.
		/// </summary>
		public const long EVENT_FULLTEXT_INDEXING_STATUS_UPDATE = 201L;

		/// <summary>
		/// User defined events must have a higher type value than this limit.
		/// </summary>
		public const long EVENT_TYPE_MAX_SYSTEM = 1000000L;

		#endregion
		
		
		public static readonly long serialVersionUID = 572745886L;		
	} // end class
}  // end namespace

//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// Types of document feed entries.
	/// </summary>
	public enum EActionType
	{
		/// <summary>
		/// Reserved.
		/// </summary>
		Undefined, // ordinal=0
		/// <summary>
		/// Reserved.
		/// </summary>
		FeedCreated, // ordinal=1
		/// <summary>
		/// Comment created by a user.
		/// </summary>
		UserComment, // ordinal=2
		/// <summary>
		/// Comment created by a program or script.
		/// </summary>
		AutoComment, // ordinal=3
		/// <summary>
		/// Document version created.
		/// </summary>
		/// <remarks>
		/// An action of this type is automatically created by the system,
		/// if a new document version is checked in and this version
		/// is not set as the work version.
		/// </remarks>
		VersionCreated, // ordinal=4
		/// <summary>
		/// Document work version created.
		/// </summary>
		/// <remarks>
		/// An action of this type is automatically created by the system,
		/// if a new version of a non-release document is checked in and this version
		/// is set as the work version.
		/// </remarks>
		WorkVersionCreated, // ordinal=5
		/// <summary>
		/// Document work version switched.
		/// </summary>
		/// <remarks>
		/// An action of this type is automatically created by the system,
		/// if the work version of a non-release document is set and no content
		/// is uploaded.
		/// </remarks>
		WorkVersionSwitched, // ordinal=6
		/// <summary>
		/// Document work version switched.
		/// </summary>
		/// <remarks>
		/// An action of this type is automatically created by the system,
		/// if the work version of a release document is set.
		/// </remarks>
		Released, // ordinal=7
		/// <summary>
		/// Sord created.
		/// </summary>
		/// <remarks>
		/// An action of this type is automatically created by the system
		/// when the feed is initialized.
		/// The create date is set to the archiving date.
		/// For documents, member {@link Action#docVersion} represents
		/// the first version.
		/// </remarks>
		SordCreated, // ordinal=8
	}  // end enum
}  // end namespace

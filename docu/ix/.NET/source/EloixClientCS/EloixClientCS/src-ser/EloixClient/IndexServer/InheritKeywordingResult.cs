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
	/// Return values for server event {@link IXServerEvents#onInheritKeywording}.
	/// </summary>
	public enum InheritKeywordingResult
	{
		/// <summary>
		/// Indexserver should stop processing of children of the given Sord.
		/// </summary>
		NOTHING, // ordinal=0
		/// <summary>
		/// The event function has not modified keywording of the given Sord.
		/// </summary>
		/// <remarks>
		/// Indexserver applies the default inheritance algorithm to the given Sord and continues processing of children.
		/// </remarks>
		APPLY_DEFAULT, // ordinal=1
		/// <summary>
		/// The event function has modified keywording of the given Sord.
		/// </summary>
		/// <remarks>
		/// Indexserver updates the given Sord in the database and continues processing of children.
		/// </remarks>
		INHERITED, // ordinal=2
	}  // end enum
}  // end namespace

//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	/// <summary>
	/// Defines the operation to process when updating a value.
	/// </summary>
	public enum HealthCheckValueOperation
	{
		/// <summary>
		/// Overwrite the value.
		/// </summary>
		UPDATE_VALUE, // ordinal=0
		/// <summary>
		/// Compute an arithmetic mean.
		/// </summary>
		COMPUTE_MEAN, // ordinal=1
		/// <summary>
		/// Add the value.
		/// </summary>
		COMPUTE_ADD, // ordinal=2
		/// <summary>
		/// Select the minimum value.
		/// </summary>
		COMPUTE_MINIMUM, // ordinal=3
		/// <summary>
		/// Select the maximum value.
		/// </summary>
		COMPUTE_MAXIMUM, // ordinal=4
	}  // end enum
}  // end namespace

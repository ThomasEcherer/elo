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
	/// This class specifies the options for moving a document into another storage path.
	/// </summary>
	/// <remarks>
	/// It is used as member in <code>ProcessInfo</code> and is interpreted in the functions
	/// <code>processFindResult</code> and <code>processTrees</code>.
	/// </remarks>
	public class ProcessMoveDocumentsToStoragePath : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessMoveDocumentsToStoragePath() {
		}		
		
		public ProcessMoveDocumentsToStoragePath(String @pathId) {
			this.pathIdValue = @pathId;
		}		
		
		public ProcessMoveDocumentsToStoragePath(ProcessMoveDocumentsToStoragePath rhs) : base(rhs)
		{
			this.pathIdValue = rhs.pathIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Name or ID of the storage path
		/// </summary>
		public String pathId
		{
			get
			{
				return pathIdValue;
			}
			set
			{
				this.pathIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String pathIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 3376635L;		
	} // end class
}  // end namespace

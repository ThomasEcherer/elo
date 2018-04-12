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
	/// Replication sets to be added to/removed from an object.
	/// </summary>
	/// <remarks>
	/// The replication set parameter must refer to existing objects that may contain empty lists. Null values are not allowed.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ProcessReplSet : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessReplSet() {
		}		
		
		public ProcessReplSet(EloixClient.IndexServer.IdName[] @addReplSets, EloixClient.IndexServer.IdName[] @andReplSets, EloixClient.IndexServer.IdName[] @setReplSets, EloixClient.IndexServer.IdName[] @subReplSets) {
			this.addReplSetsValue = @addReplSets;
			this.andReplSetsValue = @andReplSets;
			this.setReplSetsValue = @setReplSets;
			this.subReplSetsValue = @subReplSets;
		}		
		
		public ProcessReplSet(ProcessReplSet rhs) : base(rhs)
		{
			this.addReplSetsValue = rhs.addReplSetsValue;
			this.andReplSetsValue = rhs.andReplSetsValue;
			this.setReplSetsValue = rhs.setReplSetsValue;
			this.subReplSetsValue = rhs.subReplSetsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Replication sets to be added.
		/// </summary>
		public EloixClient.IndexServer.IdName[] addReplSets
		{
			get
			{
				return addReplSetsValue;
			}
			set
			{
				this.addReplSetsValue = value;
			}
		}
		
		
		/// <summary>
		/// Replication sets to be intersected with.
		/// </summary>
		public EloixClient.IndexServer.IdName[] andReplSets
		{
			get
			{
				return andReplSetsValue;
			}
			set
			{
				this.andReplSetsValue = value;
			}
		}
		
		
		/// <summary>
		/// Replication sets to be set directly overriding any former settings.
		/// </summary>
		public EloixClient.IndexServer.IdName[] setReplSets
		{
			get
			{
				return setReplSetsValue;
			}
			set
			{
				this.setReplSetsValue = value;
			}
		}
		
		
		/// <summary>
		/// Replication sets to be subtracted.
		/// </summary>
		public EloixClient.IndexServer.IdName[] subReplSets
		{
			get
			{
				return subReplSetsValue;
			}
			set
			{
				this.subReplSetsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.IdName[] addReplSetsValue;

		protected EloixClient.IndexServer.IdName[] andReplSetsValue;

		protected EloixClient.IndexServer.IdName[] setReplSetsValue;

		protected EloixClient.IndexServer.IdName[] subReplSetsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 712209598L;		
	} // end class
}  // end namespace

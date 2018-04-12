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
	/// <p>Stores the relationship between workflow nodes </p>
	/// <p>Administers the bridges(connections) in a workflow diagram.
	/// </summary>
	/// <remarks>
	/// These are
	/// objects of type WorkFlowNodeAssoc.</p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office </p>
	/// </remarks>
	public class WFNodeMatrix : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFNodeMatrix() {
		}		
		
		public WFNodeMatrix(EloixClient.IndexServer.WFNodeAssoc[] @assocs) {
			this.assocsValue = @assocs;
		}		
		
		public WFNodeMatrix(WFNodeMatrix rhs) : base(rhs)
		{
			this.assocsValue = rhs.assocsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Array of the edges.
		/// </summary>
		/// <remarks>
		/// Since 9.00.030, IX stores the order of the items in the database. When reading a workflow, the saved element order is restored.
		/// </remarks>
		public EloixClient.IndexServer.WFNodeAssoc[] assocs
		{
			get
			{
				return assocsValue;
			}
			set
			{
				this.assocsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.WFNodeAssoc[] assocsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 425879495L;		
	} // end class
}  // end namespace

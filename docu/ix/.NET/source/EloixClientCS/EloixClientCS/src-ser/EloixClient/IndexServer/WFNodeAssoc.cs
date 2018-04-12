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
	/// <p>Represents a bridge (connection) in a workflow diagram</p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class WFNodeAssoc : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFNodeAssoc() {
		}		
		
		public WFNodeAssoc(bool @done, int @nodeFrom, int @nodeTo, int @type) {
			this.doneValue = @done;
			this.nodeFromValue = @nodeFrom;
			this.nodeToValue = @nodeTo;
			this.typeValue = @type;
		}		
		
		public WFNodeAssoc(WFNodeAssoc rhs) : base(rhs)
		{
			this.doneValue = rhs.doneValue;
			this.nodeFromValue = rhs.nodeFromValue;
			this.nodeToValue = rhs.nodeToValue;
			this.typeValue = rhs.typeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Indicates whether the bridge has been passed through/over (used).
		/// </summary>
		/// <remarks>
		/// For a condition node, this member is true for both paths (TRUE and FALSE) if either has been passed.
		/// Thus it cannot be used in a client application to find out, which path the workflow has taken.
		/// </remarks>
		public bool done
		{
			get
			{
				return doneValue;
			}
			set
			{
				this.doneValue = value;
			}
		}
		
		
		/// <summary>
		/// Start node (starting location)
		/// </summary>
		public int nodeFrom
		{
			get
			{
				return nodeFromValue;
			}
			set
			{
				this.nodeFromValue = value;
			}
		}
		
		
		/// <summary>
		/// Destination (end) node
		/// </summary>
		public int nodeTo
		{
			get
			{
				return nodeToValue;
			}
			set
			{
				this.nodeToValue = value;
			}
		}
		
		
		/// <summary>
		/// Type of bridge (connection).
		/// </summary>
		/// <remarks>
		/// {@link WFNodeMatrixC#ALWAYS}, {@link WFNodeMatrixC#IF_TRUE}, {@link WFNodeMatrixC#IF_FALSE}.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool doneValue;

		protected int nodeFromValue;

		protected int nodeToValue;

		protected int typeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1042649178L;		
	} // end class
}  // end namespace

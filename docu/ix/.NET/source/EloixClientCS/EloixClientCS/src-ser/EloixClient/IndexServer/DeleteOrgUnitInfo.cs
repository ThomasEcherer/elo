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
	/// Objects of this class specify the selection criteria for
	/// <code>deleteOrgUnits</code>.
	/// </summary>
	/// <remarks>
	/// OU IDs or names can be set or both.
	/// 
	/// <p>Copyright: Copyright (c) 2013</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class DeleteOrgUnitInfo : BSerializable
	{
	
		#region Constructors
		
		public DeleteOrgUnitInfo() {
		}		
		
		public DeleteOrgUnitInfo(int[] @ids, String[] @names) {
			this.idsValue = @ids;
			this.namesValue = @names;
		}		
		
		public DeleteOrgUnitInfo(DeleteOrgUnitInfo rhs)
		{
			this.idsValue = rhs.idsValue;
			this.namesValue = rhs.namesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// OU identifiers
		/// </summary>
		public int[] ids
		{
			get
			{
				return idsValue;
			}
			set
			{
				this.idsValue = value;
			}
		}
		
		
		/// <summary>
		/// OU names
		/// </summary>
		public String[] names
		{
			get
			{
				return namesValue;
			}
			set
			{
				this.namesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int[] idsValue;

		protected String[] namesValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 537993523L;		
	} // end class
}  // end namespace

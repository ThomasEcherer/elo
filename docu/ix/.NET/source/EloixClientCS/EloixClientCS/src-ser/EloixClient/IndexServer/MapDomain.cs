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
	/// This class contains the information of a map domain.
	/// </summary>
	/// <remarks>
	/// A map is a set of key value pairs and can be addressed
	/// by a map domain name and a map ID.
	/// All maps with the same domain name are stored in the same
	/// database tables. These maps are distinguished by their
	/// ID, which can be an arbitary string.
	/// A map can be attached to a Sord object by setting
	/// the map ID to the Sord ID. Attached maps are deleted,
	/// when the Sord object is finally deleted. Furthermore
	/// they can be copied with the Sord object.
	/// </remarks>
	public class MapDomain : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapDomain() {
		}		
		
		public MapDomain(String @name, bool @copy, bool @replicate, bool @history) {
			this.nameValue = @name;
			this.copyValue = @copy;
			this.replicateValue = @replicate;
			this.historyValue = @history;
		}		
		
		public MapDomain(MapDomain rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.copyValue = rhs.copyValue;
			this.replicateValue = rhs.replicateValue;
			this.historyValue = rhs.historyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Map domain name.
		/// </summary>
		/// <remarks>
		/// This can be a user definined name or one of the predefined names in MapDomainC.
		/// The value is internally used as part of a database table name. Thus only alphanumeric
		/// characters are allowed.
		/// </remarks>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
				setChangedMember(MapDomainC.mbName);
			}
		}
		
		
		/// <summary>
		/// This value is true, if the map items should be copied when the
		/// associated Sord object is copied.
		/// </summary>
		public bool copy
		{
			get
			{
				return copyValue;
			}
			set
			{
				this.copyValue = value;
			}
		}
		
		
		/// <summary>
		/// This value is true, if the map items should be replicated
		/// with the associated Sord object.
		/// </summary>
		public bool replicate
		{
			get
			{
				return replicateValue;
			}
			set
			{
				this.replicateValue = value;
			}
		}
		
		
		/// <summary>
		/// This value is true, if a history should be maintained for map items.
		/// </summary>
		/// <remarks>
		/// A history is always available for {@link MapDomainC#DOMAIN_SORD} and {@link MapDomainC#DOMAIN_WORKFLOW_ACTIVE}.
		/// </remarks>
		public bool history
		{
			get
			{
				return historyValue;
			}
			set
			{
				this.historyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected bool copyValue;

		protected bool replicateValue;

		protected bool historyValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 42339713L;		
	} // end class
}  // end namespace

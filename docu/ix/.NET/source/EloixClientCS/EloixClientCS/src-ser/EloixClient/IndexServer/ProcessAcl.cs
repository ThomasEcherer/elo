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
	/// This class is used to assign or remove ACLs to an object.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ProcessAcl : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessAcl() {
		}		
		
		public ProcessAcl(EloixClient.IndexServer.AclItem[] @addAclItems, EloixClient.IndexServer.AclItem[] @andAclItems, EloixClient.IndexServer.AclItem[] @setAclItems, EloixClient.IndexServer.AclItem[] @subAclItems, String @addAcl, String @subAcl, String @andAcl, String @setAcl) {
			this.addAclItemsValue = @addAclItems;
			this.andAclItemsValue = @andAclItems;
			this.setAclItemsValue = @setAclItems;
			this.subAclItemsValue = @subAclItems;
			this.addAclValue = @addAcl;
			this.subAclValue = @subAcl;
			this.andAclValue = @andAcl;
			this.setAclValue = @setAcl;
		}		
		
		public ProcessAcl(ProcessAcl rhs) : base(rhs)
		{
			this.addAclItemsValue = rhs.addAclItemsValue;
			this.andAclItemsValue = rhs.andAclItemsValue;
			this.setAclItemsValue = rhs.setAclItemsValue;
			this.subAclItemsValue = rhs.subAclItemsValue;
			this.addAclValue = rhs.addAclValue;
			this.subAclValue = rhs.subAclValue;
			this.andAclValue = rhs.andAclValue;
			this.setAclValue = rhs.setAclValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ACL to be added.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] addAclItems
		{
			get
			{
				return addAclItemsValue;
			}
			set
			{
				this.addAclItemsValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be intersected with.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] andAclItems
		{
			get
			{
				return andAclItemsValue;
			}
			set
			{
				this.andAclItemsValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be set directly overriding any former settings.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] setAclItems
		{
			get
			{
				return setAclItemsValue;
			}
			set
			{
				this.setAclItemsValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be subtracted.
		/// </summary>
		public EloixClient.IndexServer.AclItem[] subAclItems
		{
			get
			{
				return subAclItemsValue;
			}
			set
			{
				this.subAclItemsValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be added in raw database format.
		/// </summary>
		/// <remarks>
		/// Ignored, if addAclItems is not null.
		/// </remarks>
		public String addAcl
		{
			get
			{
				return addAclValue;
			}
			set
			{
				this.addAclValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be added in raw database format.
		/// </summary>
		/// <remarks>
		/// Ignored, if subAclItems is not null.
		/// </remarks>
		public String subAcl
		{
			get
			{
				return subAclValue;
			}
			set
			{
				this.subAclValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be added in raw database format.
		/// </summary>
		/// <remarks>
		/// Ignored, if andAclItems is not null.
		/// </remarks>
		public String andAcl
		{
			get
			{
				return andAclValue;
			}
			set
			{
				this.andAclValue = value;
			}
		}
		
		
		/// <summary>
		/// ACL to be added in raw database format.
		/// </summary>
		/// <remarks>
		/// Ignored, if setAclItems is not null.
		/// </remarks>
		public String setAcl
		{
			get
			{
				return setAclValue;
			}
			set
			{
				this.setAclValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.AclItem[] addAclItemsValue;

		protected EloixClient.IndexServer.AclItem[] andAclItemsValue;

		protected EloixClient.IndexServer.AclItem[] setAclItemsValue;

		protected EloixClient.IndexServer.AclItem[] subAclItemsValue;

		protected String addAclValue;

		protected String subAclValue;

		protected String andAclValue;

		protected String setAclValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 402225782L;		
	} // end class
}  // end namespace

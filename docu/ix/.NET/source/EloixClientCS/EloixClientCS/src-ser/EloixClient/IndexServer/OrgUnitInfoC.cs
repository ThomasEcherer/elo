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
	/// <p>Constants related to organizational unit information.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2013</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class OrgUnitInfoC : BSerializable
	{
	
		#region Constructors
		
		public OrgUnitInfoC() {
		}		
		
		public OrgUnitInfoC(int @lnName, int @lnDesc, int @lnOuProp) {
			this.lnNameValue = @lnName;
			this.lnDescValue = @lnDesc;
			this.lnOuPropValue = @lnOuProp;
		}		
		
		public OrgUnitInfoC(OrgUnitInfoC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnDescValue = rhs.lnDescValue;
			this.lnOuPropValue = rhs.lnOuPropValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum OU name length
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum OU desc length
		/// </summary>
		public int lnDesc
		{
			get
			{
				return lnDescValue;
			}
			set
			{
				this.lnDescValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum OU property length
		/// </summary>
		public int lnOuProp
		{
			get
			{
				return lnOuPropValue;
			}
			set
			{
				this.lnOuPropValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Maximum number of OU properties.
		/// </summary>
		public const int MAX_OU_PROP = 4;

		/// <summary>
		/// Maximum number of OUs.
		/// </summary>
		public const int MAX_ORG_UNITS = 10000;

		protected int lnNameValue;

		protected int lnDescValue;

		protected int lnOuPropValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 864257789L;		
	} // end class
}  // end namespace

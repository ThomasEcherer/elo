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
	/// <p>Data class containing organizational unit information data.
	/// </summary>
	/// <remarks>
	/// Information includes ID, name, etc.</p>
	/// <p>Copyright: Copyright (c) 2013</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class OrgUnitInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OrgUnitInfo() {
		}		
		
		public OrgUnitInfo(int @id, String @name, String @desc, String[] @ouProps, String @tStamp, String @guid) {
			this.idValue = @id;
			this.nameValue = @name;
			this.descValue = @desc;
			this.ouPropsValue = @ouProps;
			this.tStampValue = @tStamp;
			this.guidValue = @guid;
		}		
		
		public OrgUnitInfo(OrgUnitInfo rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.descValue = rhs.descValue;
			this.ouPropsValue = rhs.ouPropsValue;
			this.tStampValue = rhs.tStampValue;
			this.guidValue = rhs.guidValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// OU identifier
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// OU name
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// OU description.
		/// </summary>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
			}
		}
		
		
		/// <summary>
		/// Additional OU properties
		/// Index this array with constants named PROP_* in class OrgUnitInfoC.
		/// </summary>
		public String[] ouProps
		{
			get
			{
				return ouPropsValue;
			}
			set
			{
				this.ouPropsValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </summary>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String nameValue;

		protected String descValue;

		protected String[] ouPropsValue;

		protected String tStampValue;

		protected String guidValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 413918850L;		
	} // end class
}  // end namespace

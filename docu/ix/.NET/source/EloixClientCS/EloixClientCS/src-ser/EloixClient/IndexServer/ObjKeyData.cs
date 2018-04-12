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
	/// <p>Internal use.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class ObjKeyData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ObjKeyData() {
		}		
		
		public ObjKeyData(int @objId, int @id, String @name, String @data, String @udata, String @sdata, double @odouble) {
			this.objIdValue = @objId;
			this.idValue = @id;
			this.nameValue = @name;
			this.dataValue = @data;
			this.udataValue = @udata;
			this.sdataValue = @sdata;
			this.odoubleValue = @odouble;
		}		
		
		public ObjKeyData(ObjKeyData rhs) : base(rhs)
		{
			this.objIdValue = rhs.objIdValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.dataValue = rhs.dataValue;
			this.udataValue = rhs.udataValue;
			this.sdataValue = rhs.sdataValue;
			this.odoubleValue = rhs.odoubleValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: parentid
		/// </summary>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(ObjKeyDataC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// DB column: okeyno
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
				setChangedMember(ObjKeyDataC.mbId);
			}
		}
		
		
		/// <summary>
		/// DB column: okeyname
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
				setChangedMember(ObjKeyDataC.mbName);
			}
		}
		
		
		/// <summary>
		/// DB column: okeydata
		/// </summary>
		public String data
		{
			get
			{
				return dataValue;
			}
			set
			{
				this.dataValue = value;
				setChangedMember(ObjKeyDataC.mbData);
			}
		}
		
		
		/// <summary>
		/// DB column: okeyudata
		/// </summary>
		public String udata
		{
			get
			{
				return udataValue;
			}
			set
			{
				this.udataValue = value;
				setChangedMember(ObjKeyDataC.mbUdata);
			}
		}
		
		
		/// <summary>
		/// DB column: okeysdata
		/// </summary>
		public String sdata
		{
			get
			{
				return sdataValue;
			}
			set
			{
				this.sdataValue = value;
				setChangedMember(ObjKeyDataC.mbSdata);
			}
		}
		
		
		/// <summary>
		/// DB column: odouble
		/// </summary>
		public double odouble
		{
			get
			{
				return odoubleValue;
			}
			set
			{
				this.odoubleValue = value;
				setChangedMember(ObjKeyDataC.mbOdouble);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int objIdValue;

		protected int idValue;

		protected String nameValue;

		protected String dataValue;

		protected String udataValue;

		protected String sdataValue;

		protected double odoubleValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1508164560L;		
	} // end class
}  // end namespace

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
	/// This class wraps the ObjKeyData class to provide a convenient way to access
	/// the index lines that have multiple columns.
	/// </summary>
	/// <remarks>
	/// Unlike ObjKeyData the getData and
	/// setData functions work with String arrays inspite of single String objects.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ObjKey : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ObjKey() {
		}		
		
		public ObjKey(String[] @data, int @id, String @name, int @objId) {
			this.dataValue = @data;
			this.idValue = @id;
			this.nameValue = @name;
			this.objIdValue = @objId;
		}		
		
		public ObjKey(ObjKey rhs) : base(rhs)
		{
			this.dataValue = rhs.dataValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.objIdValue = rhs.objIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Internal data array.
		/// </summary>
		/// <remarks>
		/// The values can be translated into resp. from the system language, if
		/// <code>SessionOptionsC.TRANSLATE_TERMS</code> is set and the corresponding
		/// <code>DocMaskLine</code> has set the property <code>translate</code>.
		/// </remarks>
		public String[] data
		{
			get
			{
				return dataValue;
			}
			set
			{
				this.dataValue = value;
				setChangedMember(ObjKeyC.mbData);
			}
		}
		
		
		/// <summary>
		/// ID of the index line
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
				setChangedMember(ObjKeyC.mbId);
			}
		}
		
		
		/// <summary>
		/// The group name of the index line
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
				setChangedMember(ObjKeyC.mbName);
			}
		}
		
		
		/// <summary>
		/// The ELO object ID this object belongs to
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
				setChangedMember(ObjKeyC.mbObjId);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] dataValue;

		protected int idValue;

		protected String nameValue;

		protected int objIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 237417996L;		
	} // end class
}  // end namespace

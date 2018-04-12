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
	/// <p>Colours for marking entries in the archive.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class ColorData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ColorData() {
		}		
		
		public ColorData(int @RGB, int @id, String @name, String @guid, String @TStamp, bool @deleted, String @TStampSync) {
			this.RGBValue = @RGB;
			this.idValue = @id;
			this.nameValue = @name;
			this.guidValue = @guid;
			this.TStampValue = @TStamp;
			this.deletedValue = @deleted;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public ColorData(ColorData rhs) : base(rhs)
		{
			this.RGBValue = rhs.RGBValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.guidValue = rhs.guidValue;
			this.TStampValue = rhs.TStampValue;
			this.deletedValue = rhs.deletedValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// RGB value.
		/// </summary>
		public int RGB
		{
			get
			{
				return RGBValue;
			}
			set
			{
				this.RGBValue = value;
				setChangedMember(ColorDataC.mbRGB);
			}
		}
		
		
		/// <summary>
		/// Colour number (ID).
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
				setChangedMember(ColorDataC.mbId);
			}
		}
		
		
		/// <summary>
		/// Colour name
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
				setChangedMember(ColorDataC.mbName);
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
				setChangedMember(ColorDataC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// TStamp
		/// </summary>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(ColorDataC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Deleted
		/// </summary>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
				setChangedMember(ColorDataC.mbDeleted);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(ColorDataC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int RGBValue;

		protected int idValue;

		protected String nameValue;

		protected String guidValue;

		protected String TStampValue;

		protected bool deletedValue;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1735048729L;		
	} // end class
}  // end namespace

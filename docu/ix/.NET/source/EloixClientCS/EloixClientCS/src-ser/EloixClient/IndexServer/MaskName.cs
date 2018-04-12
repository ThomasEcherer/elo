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
	/// Mask name object.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class MaskName : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MaskName() {
		}		
		
		public MaskName(bool @documentMask, int @id, String @name, bool @searchMask, bool @folderMask, String @guid, int @access, bool @barcodeMask, String @nameTranslationKey) {
			this.documentMaskValue = @documentMask;
			this.idValue = @id;
			this.nameValue = @name;
			this.searchMaskValue = @searchMask;
			this.folderMaskValue = @folderMask;
			this.guidValue = @guid;
			this.accessValue = @access;
			this.barcodeMaskValue = @barcodeMask;
			this.nameTranslationKeyValue = @nameTranslationKey;
		}		
		
		public MaskName(MaskName rhs) : base(rhs)
		{
			this.documentMaskValue = rhs.documentMaskValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.searchMaskValue = rhs.searchMaskValue;
			this.folderMaskValue = rhs.folderMaskValue;
			this.guidValue = rhs.guidValue;
			this.accessValue = rhs.accessValue;
			this.barcodeMaskValue = rhs.barcodeMaskValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Mask can be used as storage mask for indexing.
		/// </summary>
		public bool documentMask
		{
			get
			{
				return documentMaskValue;
			}
			set
			{
				this.documentMaskValue = value;
			}
		}
		
		
		/// <summary>
		/// Mask ID.
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
		/// Mask name.
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
		/// Mask can be used for searching.
		/// </summary>
		public bool searchMask
		{
			get
			{
				return searchMaskValue;
			}
			set
			{
				this.searchMaskValue = value;
			}
		}
		
		
		/// <summary>
		/// Mask can be used as storage mask for folders.
		/// </summary>
		public bool folderMask
		{
			get
			{
				return folderMaskValue;
			}
			set
			{
				this.folderMaskValue = value;
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
		
		
		/// <summary>
		/// Access mode for the current user.
		/// </summary>
		/// <remarks>
		/// A combination of AccessC.LUR_* constants.
		/// </remarks>
		public int access
		{
			get
			{
				return accessValue;
			}
			set
			{
				this.accessValue = value;
			}
		}
		
		
		/// <summary>
		/// Mask has a barcode definition.
		/// </summary>
		public bool barcodeMask
		{
			get
			{
				return barcodeMaskValue;
			}
			set
			{
				this.barcodeMaskValue = value;
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link MaskName#name}.
		/// </summary>
		public String nameTranslationKey
		{
			get
			{
				return nameTranslationKeyValue;
			}
			set
			{
				this.nameTranslationKeyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool documentMaskValue;

		protected int idValue;

		protected String nameValue;

		protected bool searchMaskValue;

		protected bool folderMaskValue;

		protected String guidValue;

		protected int accessValue;

		protected bool barcodeMaskValue;

		protected String nameTranslationKeyValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 458953805L;		
	} // end class
}  // end namespace

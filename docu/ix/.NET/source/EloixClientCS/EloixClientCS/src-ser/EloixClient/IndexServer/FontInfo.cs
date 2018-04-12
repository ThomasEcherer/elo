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
	/// This class describes a font.
	/// </summary>
	public class FontInfo : BSerializable
	{
	
		#region Constructors
		
		public FontInfo() {
		}		
		
		public FontInfo(String @faceName, bool @bold, bool @italic, bool @strikeOut, bool @underline, int @RGB, int @height, bool @heightPerCell, int @escapement) {
			this.faceNameValue = @faceName;
			this.boldValue = @bold;
			this.italicValue = @italic;
			this.strikeOutValue = @strikeOut;
			this.underlineValue = @underline;
			this.RGBValue = @RGB;
			this.heightValue = @height;
			this.heightPerCellValue = @heightPerCell;
			this.escapementValue = @escapement;
		}		
		
		public FontInfo(FontInfo rhs)
		{
			this.faceNameValue = rhs.faceNameValue;
			this.boldValue = rhs.boldValue;
			this.italicValue = rhs.italicValue;
			this.strikeOutValue = rhs.strikeOutValue;
			this.underlineValue = rhs.underlineValue;
			this.RGBValue = rhs.RGBValue;
			this.heightValue = rhs.heightValue;
			this.heightPerCellValue = rhs.heightPerCellValue;
			this.escapementValue = rhs.escapementValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Font face name
		/// </summary>
		public String faceName
		{
			get
			{
				return faceNameValue;
			}
			set
			{
				this.faceNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Bold
		/// </summary>
		public bool bold
		{
			get
			{
				return boldValue;
			}
			set
			{
				this.boldValue = value;
			}
		}
		
		
		/// <summary>
		/// Italic
		/// </summary>
		public bool italic
		{
			get
			{
				return italicValue;
			}
			set
			{
				this.italicValue = value;
			}
		}
		
		
		/// <summary>
		/// Strike out
		/// </summary>
		public bool strikeOut
		{
			get
			{
				return strikeOutValue;
			}
			set
			{
				this.strikeOutValue = value;
			}
		}
		
		
		/// <summary>
		/// Underline
		/// </summary>
		public bool underline
		{
			get
			{
				return underlineValue;
			}
			set
			{
				this.underlineValue = value;
			}
		}
		
		
		/// <summary>
		/// Read-green-blue value.
		/// </summary>
		/// <remarks>
		/// On byte each color.
		/// Read is at the lowest significant byte.
		/// </remarks>
		public int RGB
		{
			get
			{
				return RGBValue;
			}
			set
			{
				this.RGBValue = value;
			}
		}
		
		
		/// <summary>
		/// Font heigth.
		/// </summary>
		public int height
		{
			get
			{
				return heightValue;
			}
			set
			{
				this.heightValue = value;
			}
		}
		
		
		/// <summary>
		/// The font height is related to the cell height of the font rather than the
		/// character heigth.
		/// </summary>
		public bool heightPerCell
		{
			get
			{
				return heightPerCellValue;
			}
			set
			{
				this.heightPerCellValue = value;
			}
		}
		
		
		/// <summary>
		/// Specifies the angle, in tenths of degrees, between the escapement vector and the x-axis of the device.
		/// </summary>
		/// <remarks>
		/// The escapement vector is parallel to the base line of a row of text.
		/// </remarks>
		public int escapement
		{
			get
			{
				return escapementValue;
			}
			set
			{
				this.escapementValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String faceNameValue;

		protected bool boldValue;

		protected bool italicValue;

		protected bool strikeOutValue;

		protected bool underlineValue;

		protected int RGBValue;

		protected int heightValue;

		protected bool heightPerCellValue;

		protected int escapementValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1478273890L;		
	} // end class
}  // end namespace

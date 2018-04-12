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
	/// This class describes a freehand line annotation.
	/// </summary>
	public class NoteFreehand : BSerializable
	{
	
		#region Constructors
		
		public NoteFreehand() {
		}		
		
		public NoteFreehand(int @width, EloixClient.IndexServer.PointInfo[] @points, int @strikeoutWidth, int @strikeoutColor) {
			this.widthValue = @width;
			this.pointsValue = @points;
			this.strikeoutWidthValue = @strikeoutWidth;
			this.strikeoutColorValue = @strikeoutColor;
		}		
		
		public NoteFreehand(NoteFreehand rhs)
		{
			this.widthValue = rhs.widthValue;
			this.pointsValue = rhs.pointsValue;
			this.strikeoutWidthValue = rhs.strikeoutWidthValue;
			this.strikeoutColorValue = rhs.strikeoutColorValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Line width.
		/// </summary>
		public int width
		{
			get
			{
				return widthValue;
			}
			set
			{
				this.widthValue = value;
			}
		}
		
		
		/// <summary>
		/// Points.
		/// </summary>
		public EloixClient.IndexServer.PointInfo[] points
		{
			get
			{
				return pointsValue;
			}
			set
			{
				this.pointsValue = value;
			}
		}
		
		
		/// <summary>
		/// Line width for strikeout pen (only TYPE_ANNOTATION_STRIKEOUT).
		/// </summary>
		public int strikeoutWidth
		{
			get
			{
				return strikeoutWidthValue;
			}
			set
			{
				this.strikeoutWidthValue = value;
			}
		}
		
		
		/// <summary>
		/// Color for strikeout pen (only TYPE_ANNOTATION_STRIKEOUT).
		/// </summary>
		public int strikeoutColor
		{
			get
			{
				return strikeoutColorValue;
			}
			set
			{
				this.strikeoutColorValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int widthValue;

		protected EloixClient.IndexServer.PointInfo[] pointsValue;

		protected int strikeoutWidthValue;

		protected int strikeoutColorValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 611837980L;		
	} // end class
}  // end namespace

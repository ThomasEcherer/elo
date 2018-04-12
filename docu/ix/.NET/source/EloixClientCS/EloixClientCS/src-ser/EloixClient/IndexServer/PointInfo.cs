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
	/// This class describes a 2D point.
	/// </summary>
	public class PointInfo : BSerializable
	{
	
		#region Constructors
		
		public PointInfo() {
		}		
		
		public PointInfo(int @x, int @y) {
			this.xValue = @x;
			this.yValue = @y;
		}		
		
		public PointInfo(PointInfo rhs)
		{
			this.xValue = rhs.xValue;
			this.yValue = rhs.yValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// X coordinate
		/// </summary>
		public int x
		{
			get
			{
				return xValue;
			}
			set
			{
				this.xValue = value;
			}
		}
		
		
		/// <summary>
		/// Y coordinate
		/// </summary>
		public int y
		{
			get
			{
				return yValue;
			}
			set
			{
				this.yValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int xValue;

		protected int yValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1225068828L;		
	} // end class
}  // end namespace

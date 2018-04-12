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
	/// This class contains the coordinates of a rectangle and is used by the {@link OcrInfoRecognizeFile} class.
	/// </summary>
	public class OcrRect : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrRect() {
		}		
		
		public OcrRect(int @left, int @top, int @right, int @bottom) {
			this.leftValue = @left;
			this.topValue = @top;
			this.rightValue = @right;
			this.bottomValue = @bottom;
		}		
		
		public OcrRect(OcrRect rhs) : base(rhs)
		{
			this.leftValue = rhs.leftValue;
			this.topValue = rhs.topValue;
			this.rightValue = rhs.rightValue;
			this.bottomValue = rhs.bottomValue;
		}		
		
		#endregion
		
		#region Properties
		
		public int left
		{
			get
			{
				return leftValue;
			}
			set
			{
				this.leftValue = value;
			}
		}
		
		
		public int top
		{
			get
			{
				return topValue;
			}
			set
			{
				this.topValue = value;
			}
		}
		
		
		public int right
		{
			get
			{
				return rightValue;
			}
			set
			{
				this.rightValue = value;
			}
		}
		
		
		public int bottom
		{
			get
			{
				return bottomValue;
			}
			set
			{
				this.bottomValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int leftValue;

		protected int topValue;

		protected int rightValue;

		protected int bottomValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1044855049L;		
	} // end class
}  // end namespace

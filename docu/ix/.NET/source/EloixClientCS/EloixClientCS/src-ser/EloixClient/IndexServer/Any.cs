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
	/// This class is a container for one value of a serializable type.
	/// </summary>
	public class Any : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Any() {
		}		
		
		public Any(int @type, bool @booleanValue, int @intValue, long @longValue, double @doubleValue, String @stringValue, EloixClient.IndexServer.ValueClass @objectValue, byte[] @byteArray, EloixClient.IndexServer.Any[] @anyArray) {
			this.typeValue = @type;
			this.booleanValueValue = @booleanValue;
			this.intValueValue = @intValue;
			this.longValueValue = @longValue;
			this.doubleValueValue = @doubleValue;
			this.stringValueValue = @stringValue;
			this.objectValueValue = @objectValue;
			this.byteArrayValue = @byteArray;
			this.anyArrayValue = @anyArray;
		}		
		
		public Any(Any rhs) : base(rhs)
		{
			this.typeValue = rhs.typeValue;
			this.booleanValueValue = rhs.booleanValueValue;
			this.intValueValue = rhs.intValueValue;
			this.longValueValue = rhs.longValueValue;
			this.doubleValueValue = rhs.doubleValueValue;
			this.stringValueValue = rhs.stringValueValue;
			this.objectValueValue = rhs.objectValueValue;
			this.byteArrayValue = rhs.byteArrayValue;
			this.anyArrayValue = rhs.anyArrayValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Type.
		/// </summary>
		/// <remarks>
		/// One of the type constants given in AnyC.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		/// <summary>
		/// Boolean value.
		/// </summary>
		public bool booleanValue
		{
			get
			{
				return booleanValueValue;
			}
			set
			{
				this.booleanValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Integer value.
		/// </summary>
		public int intValue
		{
			get
			{
				return intValueValue;
			}
			set
			{
				this.intValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Long value.
		/// </summary>
		public long longValue
		{
			get
			{
				return longValueValue;
			}
			set
			{
				this.longValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Double value.
		/// </summary>
		public double doubleValue
		{
			get
			{
				return doubleValueValue;
			}
			set
			{
				this.doubleValueValue = value;
			}
		}
		
		
		/// <summary>
		/// String value.
		/// </summary>
		public String stringValue
		{
			get
			{
				return stringValueValue;
			}
			set
			{
				this.stringValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Object value.
		/// </summary>
		public EloixClient.IndexServer.ValueClass objectValue
		{
			get
			{
				return objectValueValue;
			}
			set
			{
				this.objectValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Byte array.
		/// </summary>
		public byte[] byteArray
		{
			get
			{
				return byteArrayValue;
			}
			set
			{
				this.byteArrayValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of Any.
		/// </summary>
		public EloixClient.IndexServer.Any[] anyArray
		{
			get
			{
				return anyArrayValue;
			}
			set
			{
				this.anyArrayValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int typeValue;

		protected bool booleanValueValue;

		protected int intValueValue;

		protected long longValueValue;

		protected double doubleValueValue;

		protected String stringValueValue;

		protected EloixClient.IndexServer.ValueClass objectValueValue;

		protected byte[] byteArrayValue;

		protected EloixClient.IndexServer.Any[] anyArrayValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1191976387L;		
	} // end class
}  // end namespace

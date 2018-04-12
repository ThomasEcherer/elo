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
	/// Constants for class ActivityOption
	/// </summary>
	public class ActivityOptionC : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ActivityOptionC() {
		}		
		
		public ActivityOptionC(ActivityOptionC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Option ID for receiver.
		/// </summary>
		public const int ID_RECEIVER = 10;

		/// <summary>
		/// Option ID for shipping type.
		/// </summary>
		public const int ID_TYPE = 11;

		/// <summary>
		/// Option ID for receiving status.
		/// </summary>
		public const int ID_STATUS = 12;

		/// <summary>
		/// Option ID for transmission number.
		/// </summary>
		public const int ID_TRANS = 13;

		/// <summary>
		/// Application defined IDs must be greater or equal to this value.
		/// </summary>
		/// <remarks>
		/// Up to 10 application defined IDs can be defined.
		/// Their values have to be in the range from ID_VALUE+0 to ID_VALUE+9.
		/// </remarks>
		public const int ID_VALUE = 30;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1364827052L;		
	} // end class
}  // end namespace

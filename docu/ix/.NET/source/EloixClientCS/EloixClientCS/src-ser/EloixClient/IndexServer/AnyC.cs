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
	/// This class defines the constants for the type member in Any.
	/// </summary>
	public class AnyC : BSerializable
	{
	
		#region Constructors
		
		public AnyC() {
		}		
		
		public AnyC(AnyC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const int TYPE_OBJECT = 0;

		public const int TYPE_BOOLEAN = 1;

		public const int TYPE_INT = 5;

		public const int TYPE_LONG = 6;

		public const int TYPE_DOUBLE = 7;

		public const int TYPE_STRING = 8;

		public const int TYPE_HANDLE = 10;

		public const int TYPE_ARRAY_BYTE = 1001;

		public const int TYPE_ARRAY_ANY = 1002;

		#endregion
		
		
		public static readonly long serialVersionUID = 908393697L;		
	} // end class
}  // end namespace

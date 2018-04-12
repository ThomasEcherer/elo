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
	/// This class represents an option for an activity project.
	/// </summary>
	public class ActivityOption : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ActivityOption() {
		}		
		
		public ActivityOption(int @id, String @name, bool @onlyKeyword, bool @readOnly, bool @sorted, bool @stamp, bool @mandatory, String[] @keywords) {
			this.idValue = @id;
			this.nameValue = @name;
			this.onlyKeywordValue = @onlyKeyword;
			this.readOnlyValue = @readOnly;
			this.sortedValue = @sorted;
			this.stampValue = @stamp;
			this.mandatoryValue = @mandatory;
			this.keywordsValue = @keywords;
		}		
		
		public ActivityOption(ActivityOption rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.onlyKeywordValue = rhs.onlyKeywordValue;
			this.readOnlyValue = rhs.readOnlyValue;
			this.sortedValue = rhs.sortedValue;
			this.stampValue = rhs.stampValue;
			this.mandatoryValue = rhs.mandatoryValue;
			this.keywordsValue = rhs.keywordsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Option ID.
		/// </summary>
		/// <remarks>
		/// This value can be one of the predefined option IDs in ActivityOptionC.
		/// Or you can use an application defined value greater or equal to ActivityOptionC.ID_VALUE.
		/// </remarks>
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
		/// Activity option name.
		/// </summary>
		/// <remarks>
		/// The name must not contain one of this characters: ! $ - + *
		/// </remarks>
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
		/// The value can only be selected from the associated keyword list.
		/// </summary>
		/// <remarks>
		/// This option has to be checked by the client application. It is not checked by Indexserver.
		/// </remarks>
		public bool onlyKeyword
		{
			get
			{
				return onlyKeywordValue;
			}
			set
			{
				this.onlyKeywordValue = value;
			}
		}
		
		
		/// <summary>
		/// The value can not be edited in the user interface.
		/// </summary>
		/// <remarks>
		/// This option has to be checked by the client application. It is not checked by Indexserver.
		/// </remarks>
		public bool readOnly
		{
			get
			{
				return readOnlyValue;
			}
			set
			{
				this.readOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// The value has to be displayed in an appropriate order.
		/// </summary>
		/// <remarks>
		/// This option has to be checked by the client application. It is not checked by Indexserver.
		/// </remarks>
		public bool sorted
		{
			get
			{
				return sortedValue;
			}
			set
			{
				this.sortedValue = value;
			}
		}
		
		
		/// <summary>
		/// This option is a stamp field.
		/// </summary>
		/// <remarks>
		/// This option has to be checked by the client application. It is not checked by Indexserver.
		/// </remarks>
		public bool stamp
		{
			get
			{
				return stampValue;
			}
			set
			{
				this.stampValue = value;
			}
		}
		
		
		/// <summary>
		/// A value must be defined for this option.
		/// </summary>
		/// <remarks>
		/// This option has to be checked by the client application. It is not checked by Indexserver.
		/// </remarks>
		public bool mandatory
		{
			get
			{
				return mandatoryValue;
			}
			set
			{
				this.mandatoryValue = value;
			}
		}
		
		
		/// <summary>
		/// Keywords.
		/// </summary>
		/// <remarks>
		/// This array defines the values that can or must be used to set the option.
		/// If no keywords are defined, this member is null or an empty array.
		/// </remarks>
		public String[] keywords
		{
			get
			{
				return keywordsValue;
			}
			set
			{
				this.keywordsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String nameValue;

		protected bool onlyKeywordValue;

		protected bool readOnlyValue;

		protected bool sortedValue;

		protected bool stampValue;

		protected bool mandatoryValue;

		protected String[] keywordsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 595132669L;		
	} // end class
}  // end namespace

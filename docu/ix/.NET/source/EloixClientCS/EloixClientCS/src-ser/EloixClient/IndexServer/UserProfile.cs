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
	/// User profile options
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class UserProfile : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserProfile() {
		}		
		
		public UserProfile(EloixClient.IndexServer.KeyValue[] @options, String @userId, bool @excludeGroupValues, bool @excludeDefaultValues, EloixClient.IndexServer.KeyValue[] @userOptions, EloixClient.IndexServer.KeyValue[] @groupOptions, EloixClient.IndexServer.KeyValue[] @defaultOptions, int @groupId, bool @includeAllGroupAndDefaultOptions) {
			this.optionsValue = @options;
			this.userIdValue = @userId;
			this.excludeGroupValuesValue = @excludeGroupValues;
			this.excludeDefaultValuesValue = @excludeDefaultValues;
			this.userOptionsValue = @userOptions;
			this.groupOptionsValue = @groupOptions;
			this.defaultOptionsValue = @defaultOptions;
			this.groupIdValue = @groupId;
			this.includeAllGroupAndDefaultOptionsValue = @includeAllGroupAndDefaultOptions;
		}		
		
		public UserProfile(UserProfile rhs) : base(rhs)
		{
			this.optionsValue = rhs.optionsValue;
			this.userIdValue = rhs.userIdValue;
			this.excludeGroupValuesValue = rhs.excludeGroupValuesValue;
			this.excludeDefaultValuesValue = rhs.excludeDefaultValuesValue;
			this.userOptionsValue = rhs.userOptionsValue;
			this.groupOptionsValue = rhs.groupOptionsValue;
			this.defaultOptionsValue = rhs.defaultOptionsValue;
			this.groupIdValue = rhs.groupIdValue;
			this.includeAllGroupAndDefaultOptionsValue = rhs.includeAllGroupAndDefaultOptionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Options as name-value-pairs.
		/// </summary>
		/// <remarks>
		/// This array contains the sum of default options, group options and user options.
		/// </remarks>
		public EloixClient.IndexServer.KeyValue[] options
		{
			get
			{
				return optionsValue;
			}
			set
			{
				this.optionsValue = value;
			}
		}
		
		
		/// <summary>
		/// The user name or UserProfileC.USERID_ALL, if the options for all users are represented by this object.
		/// </summary>
		/// <remarks>
		/// The values null or empty are equal to UserProfileC.USERID_ALL.
		/// </remarks>
		public String userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not read values of option groups.
		/// </summary>
		/// <remarks>
		/// Only valid for checkoutUserProfile.
		/// </remarks>
		public bool excludeGroupValues
		{
			get
			{
				return excludeGroupValuesValue;
			}
			set
			{
				this.excludeGroupValuesValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not read values for all users.
		/// </summary>
		/// <remarks>
		/// Only valid for checkoutUserProfile.
		/// </remarks>
		public bool excludeDefaultValues
		{
			get
			{
				return excludeDefaultValuesValue;
			}
			set
			{
				this.excludeDefaultValuesValue = value;
			}
		}
		
		
		/// <summary>
		/// Options as name-value-pairs.
		/// </summary>
		/// <remarks>
		/// This array contains the options defined for the given user.
		/// Read-only.
		/// </remarks>
		public EloixClient.IndexServer.KeyValue[] userOptions
		{
			get
			{
				return userOptionsValue;
			}
			set
			{
				this.userOptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Options as name-value-pairs.
		/// </summary>
		/// <remarks>
		/// This array contains the options defined for the users option group.
		/// Read-only.
		/// </remarks>
		public EloixClient.IndexServer.KeyValue[] groupOptions
		{
			get
			{
				return groupOptionsValue;
			}
			set
			{
				this.groupOptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Options as name-value-pairs.
		/// </summary>
		/// <remarks>
		/// This array contains the default options valid for all users.
		/// Read-only.
		/// </remarks>
		public EloixClient.IndexServer.KeyValue[] defaultOptions
		{
			get
			{
				return defaultOptionsValue;
			}
			set
			{
				this.defaultOptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// The users option group ID.
		/// </summary>
		/// <remarks>
		/// This value is -1, if the user is not member of an option group.
		/// Read-only.
		/// </remarks>
		public int groupId
		{
			get
			{
				return groupIdValue;
			}
			set
			{
				this.groupIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Include all group and default options.
		/// </summary>
		/// <remarks>
		/// Set this member as true, if all group and default options shall be returned.
		/// If the value is false, only those options are returned that are not particularly defined for the user.
		/// </remarks>
		public bool includeAllGroupAndDefaultOptions
		{
			get
			{
				return includeAllGroupAndDefaultOptionsValue;
			}
			set
			{
				this.includeAllGroupAndDefaultOptionsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.KeyValue[] optionsValue;

		protected String userIdValue;

		protected bool excludeGroupValuesValue;

		protected bool excludeDefaultValuesValue;

		protected EloixClient.IndexServer.KeyValue[] userOptionsValue;

		protected EloixClient.IndexServer.KeyValue[] groupOptionsValue;

		protected EloixClient.IndexServer.KeyValue[] defaultOptionsValue;

		protected int groupIdValue;

		protected bool includeAllGroupAndDefaultOptionsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1401065069L;		
	} // end class
}  // end namespace

//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class LicenseCounter : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public LicenseCounter() {
		}		
		
		public LicenseCounter(EloixClient.IndexServer.UserInfo @userInfo, Dictionary<int,int> @accessMap, int @sumAccess, bool @disabled, int @countType) {
			this.userInfoValue = @userInfo;
			this.accessMapValue = @accessMap;
			this.sumAccessValue = @sumAccess;
			this.disabledValue = @disabled;
			this.countTypeValue = @countType;
		}		
		
		public LicenseCounter(LicenseCounter rhs) : base(rhs)
		{
			this.userInfoValue = rhs.userInfoValue;
			this.accessMapValue = rhs.accessMapValue;
			this.sumAccessValue = rhs.sumAccessValue;
			this.disabledValue = rhs.disabledValue;
			this.countTypeValue = rhs.countTypeValue;
		}		
		
		#endregion
		
		#region Properties
		
		public EloixClient.IndexServer.UserInfo userInfo
		{
			get
			{
				return userInfoValue;
			}
			set
			{
				this.userInfoValue = value;
			}
		}
		
		
		public Dictionary<int,int> accessMap
		{
			get
			{
				return accessMapValue;
			}
			set
			{
				this.accessMapValue = value;
			}
		}
		
		
		/// <summary>
		/// sum of AccessMap without keys 0,6,9
		/// </summary>
		public int sumAccess
		{
			get
			{
				return sumAccessValue;
			}
			set
			{
				this.sumAccessValue = value;
			}
		}
		
		
		public bool disabled
		{
			get
			{
				return disabledValue;
			}
			set
			{
				this.disabledValue = value;
			}
		}
		
		
		public int countType
		{
			get
			{
				return countTypeValue;
			}
			set
			{
				this.countTypeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		public const int JAVA_CLIENT = 0;

		public const int WINWOS_CLIENT = 6;

		public const int FULL_USER = 0;

		public const int IX_USER = 1;

		public const int DELETED_USER = 2;

		public const int FREE_USER = -1;

		protected EloixClient.IndexServer.UserInfo userInfoValue;

		protected Dictionary<int,int> accessMapValue;

		protected int sumAccessValue;

		protected bool disabledValue;

		protected int countTypeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 189487184L;		
	} // end class
}  // end namespace

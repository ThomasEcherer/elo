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
	/// Additional report information for user modifications.
	/// </summary>
	public class ReportInfoUserProps : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ReportInfoUserProps() {
		}		
		
		public ReportInfoUserProps(EloixClient.IndexServer.UserInfo @userInfo, EloixClient.IndexServer.UserInfo @userInfoEff, IList<EloixClient.IndexServer.SubsInfo> @subsInfos, IDictionary<int,String> @idsToNames) {
			this.userInfoValue = @userInfo;
			this.userInfoEffValue = @userInfoEff;
			this.subsInfosValue = @subsInfos;
			this.idsToNamesValue = @idsToNames;
		}		
		
		public ReportInfoUserProps(ReportInfoUserProps rhs) : base(rhs)
		{
			this.userInfoValue = rhs.userInfoValue;
			this.userInfoEffValue = rhs.userInfoEffValue;
			this.subsInfosValue = rhs.subsInfosValue;
			this.idsToNamesValue = rhs.idsToNamesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// UserInfo object.
		/// </summary>
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
		
		
		/// <summary>
		/// UserInfo object with effective permissions.
		/// </summary>
		public EloixClient.IndexServer.UserInfo userInfoEff
		{
			get
			{
				return userInfoEffValue;
			}
			set
			{
				this.userInfoEffValue = value;
			}
		}
		
		
		/// <summary>
		/// Substitution information.
		/// </summary>
		public IList<EloixClient.IndexServer.SubsInfo> subsInfos
		{
			get
			{
				return subsInfosValue;
			}
			set
			{
				this.subsInfosValue = value;
			}
		}
		
		
		/// <summary>
		/// Map of user IDs to user names.
		/// </summary>
		/// <remarks>
		/// This map contains all users referred by {@link #userInfo}, {@link #userInfoEff}, and {@link #subsInfos}.
		/// </remarks>
		public IDictionary<int,String> idsToNames
		{
			get
			{
				return idsToNamesValue;
			}
			set
			{
				this.idsToNamesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.UserInfo userInfoValue;

		protected EloixClient.IndexServer.UserInfo userInfoEffValue;

		protected IList<EloixClient.IndexServer.SubsInfo> subsInfosValue;

		protected IDictionary<int,String> idsToNamesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2088129978L;		
	} // end class
}  // end namespace

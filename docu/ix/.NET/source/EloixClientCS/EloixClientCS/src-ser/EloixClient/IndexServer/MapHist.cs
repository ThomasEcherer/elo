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
	/// Version history for maps.
	/// </summary>
	public class MapHist : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapHist() {
		}		
		
		public MapHist(String @histGuid, int @histSource, String @mapGuid, String @timeStampLocal, String @timeStampUTC, String @userName, int @userId, String @workStation, EloixClient.IndexServer.MapHistItem[] @histItems, String @mapId) {
			this.histGuidValue = @histGuid;
			this.histSourceValue = @histSource;
			this.mapGuidValue = @mapGuid;
			this.timeStampLocalValue = @timeStampLocal;
			this.timeStampUTCValue = @timeStampUTC;
			this.userNameValue = @userName;
			this.userIdValue = @userId;
			this.workStationValue = @workStation;
			this.histItemsValue = @histItems;
			this.mapIdValue = @mapId;
		}		
		
		public MapHist(MapHist rhs) : base(rhs)
		{
			this.histGuidValue = rhs.histGuidValue;
			this.histSourceValue = rhs.histSourceValue;
			this.mapGuidValue = rhs.mapGuidValue;
			this.timeStampLocalValue = rhs.timeStampLocalValue;
			this.timeStampUTCValue = rhs.timeStampUTCValue;
			this.userNameValue = rhs.userNameValue;
			this.userIdValue = rhs.userIdValue;
			this.workStationValue = rhs.workStationValue;
			this.histItemsValue = rhs.histItemsValue;
			this.mapIdValue = rhs.mapIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of the SordHist object.
		/// </summary>
		public String histGuid
		{
			get
			{
				return histGuidValue;
			}
			set
			{
				this.histGuidValue = value;
				setChangedMember(MapHistC.mbHistGuid);
			}
		}
		
		
		/// <summary>
		/// Identifies the application with which changes were made to the keywording.
		/// </summary>
		public int histSource
		{
			get
			{
				return histSourceValue;
			}
			set
			{
				this.histSourceValue = value;
				setChangedMember(MapHistC.mbHistSource);
			}
		}
		
		
		/// <summary>
		/// GUID of the map object.
		/// </summary>
		public String mapGuid
		{
			get
			{
				return mapGuidValue;
			}
			set
			{
				this.mapGuidValue = value;
				setChangedMember(MapHistC.mbMapGuid);
			}
		}
		
		
		/// <summary>
		/// Timestamp of the change in the timezone of the client.
		/// </summary>
		/// <remarks>
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String timeStampLocal
		{
			get
			{
				return timeStampLocalValue;
			}
			set
			{
				this.timeStampLocalValue = value;
				setChangedMember(MapHistC.mbTimeStampLocal);
			}
		}
		
		
		/// <summary>
		/// Timestamp of the change in the timezone of the client, in UTC form.
		/// </summary>
		/// <remarks>
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String timeStampUTC
		{
			get
			{
				return timeStampUTCValue;
			}
			set
			{
				this.timeStampUTCValue = value;
				setChangedMember(MapHistC.mbTimeStampUTC);
			}
		}
		
		
		/// <summary>
		/// The name of the user who carried out the changes.
		/// </summary>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
				setChangedMember(MapHistC.mbUserName);
			}
		}
		
		
		/// <summary>
		/// The user who carried out the changes.
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
				setChangedMember(MapHistC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// The name of the computer from which the change was carried out.
		/// </summary>
		/// <remarks>
		/// This is the parameter
		/// clientComputer which is provided by the ix.login function.
		/// </remarks>
		public String workStation
		{
			get
			{
				return workStationValue;
			}
			set
			{
				this.workStationValue = value;
				setChangedMember(MapHistC.mbWorkStation);
			}
		}
		
		
		/// <summary>
		/// An array of the keywording changes.
		/// </summary>
		public EloixClient.IndexServer.MapHistItem[] histItems
		{
			get
			{
				return histItemsValue;
			}
			set
			{
				this.histItemsValue = value;
				setChangedMember(MapHistC.mbHistItems);
			}
		}
		
		
		/// <summary>
		/// ID of the map object.
		/// </summary>
		public String mapId
		{
			get
			{
				return mapIdValue;
			}
			set
			{
				this.mapIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String histGuidValue;

		protected int histSourceValue;

		protected String mapGuidValue;

		protected String timeStampLocalValue;

		protected String timeStampUTCValue;

		protected String userNameValue;

		protected int userIdValue;

		protected String workStationValue;

		protected EloixClient.IndexServer.MapHistItem[] histItemsValue;

		protected String mapIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 303505086L;		
	} // end class
}  // end namespace

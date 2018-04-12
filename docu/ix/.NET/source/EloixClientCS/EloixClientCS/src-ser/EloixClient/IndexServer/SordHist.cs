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
	/// Version history for the keywording from an object.
	/// </summary>
	/// <remarks>
	/// A version history is
	/// created for a sord object when the keywording is
	/// changed for the first time (a newly created sord has no version history).
	/// Once created only one SordHist object exist for the sord object and is
	/// assigned to the sord object via the Sord.guid = SordHist.objGuid relationship.
	/// The keywording properties that were altered in the change process are saved in
	/// an array of SordHistKey objects.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class SordHist : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SordHist() {
		}		
		
		public SordHist(String @histGuid, int @histSource, String @objGuid, String @timeStampLocal, String @timeStampUTC, String @userName, int @userNo, String @workStation, EloixClient.IndexServer.SordHistKey[] @histKeys) {
			this.histGuidValue = @histGuid;
			this.histSourceValue = @histSource;
			this.objGuidValue = @objGuid;
			this.timeStampLocalValue = @timeStampLocal;
			this.timeStampUTCValue = @timeStampUTC;
			this.userNameValue = @userName;
			this.userNoValue = @userNo;
			this.workStationValue = @workStation;
			this.histKeysValue = @histKeys;
		}		
		
		public SordHist(SordHist rhs) : base(rhs)
		{
			this.histGuidValue = rhs.histGuidValue;
			this.histSourceValue = rhs.histSourceValue;
			this.objGuidValue = rhs.objGuidValue;
			this.timeStampLocalValue = rhs.timeStampLocalValue;
			this.timeStampUTCValue = rhs.timeStampUTCValue;
			this.userNameValue = rhs.userNameValue;
			this.userNoValue = rhs.userNoValue;
			this.workStationValue = rhs.workStationValue;
			this.histKeysValue = rhs.histKeysValue;
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
				setChangedMember(SordHistC.mbHistGuid);
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
				setChangedMember(SordHistC.mbHistSource);
			}
		}
		
		
		/// <summary>
		/// GUID of the sord object.
		/// </summary>
		public String objGuid
		{
			get
			{
				return objGuidValue;
			}
			set
			{
				this.objGuidValue = value;
				setChangedMember(SordHistC.mbObjGuid);
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
				setChangedMember(SordHistC.mbTimeStampLocal);
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
				setChangedMember(SordHistC.mbTimeStampUTC);
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
				setChangedMember(SordHistC.mbUserName);
			}
		}
		
		
		/// <summary>
		/// The user who carried out the changes.
		/// </summary>
		public int userNo
		{
			get
			{
				return userNoValue;
			}
			set
			{
				this.userNoValue = value;
				setChangedMember(SordHistC.mbUserNo);
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
				setChangedMember(SordHistC.mbWorkStation);
			}
		}
		
		
		/// <summary>
		/// An array of the keywording changes.
		/// </summary>
		public EloixClient.IndexServer.SordHistKey[] histKeys
		{
			get
			{
				return histKeysValue;
			}
			set
			{
				this.histKeysValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String histGuidValue;

		protected int histSourceValue;

		protected String objGuidValue;

		protected String timeStampLocalValue;

		protected String timeStampUTCValue;

		protected String userNameValue;

		protected int userNoValue;

		protected String workStationValue;

		protected EloixClient.IndexServer.SordHistKey[] histKeysValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2121567102L;		
	} // end class
}  // end namespace

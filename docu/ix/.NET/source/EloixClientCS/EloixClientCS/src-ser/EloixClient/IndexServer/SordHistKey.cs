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
	/// This class provides the version information for a keywording attribute
	/// that has been modified.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class SordHistKey : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SordHistKey() {
		}		
		
		public SordHistKey(String @histGuid, String @keyData, String @keyName, int @keyNo, int @keyIndex, int @keyId) {
			this.histGuidValue = @histGuid;
			this.keyDataValue = @keyData;
			this.keyNameValue = @keyName;
			this.keyNoValue = @keyNo;
			this.keyIndexValue = @keyIndex;
			this.keyIdValue = @keyId;
		}		
		
		public SordHistKey(SordHistKey rhs) : base(rhs)
		{
			this.histGuidValue = rhs.histGuidValue;
			this.keyDataValue = rhs.keyDataValue;
			this.keyNameValue = rhs.keyNameValue;
			this.keyNoValue = rhs.keyNoValue;
			this.keyIndexValue = rhs.keyIndexValue;
			this.keyIdValue = rhs.keyIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID of the assigned SordHist object.
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
				setChangedMember(SordHistKeyC.mbHistGuid);
			}
		}
		
		
		/// <summary>
		/// Value of dat of the attribute.
		/// </summary>
		public String keyData
		{
			get
			{
				return keyDataValue;
			}
			set
			{
				this.keyDataValue = value;
				setChangedMember(SordHistKeyC.mbKeyData);
			}
		}
		
		
		/// <summary>
		/// Name of the attribute.
		/// </summary>
		public String keyName
		{
			get
			{
				return keyNameValue;
			}
			set
			{
				this.keyNameValue = value;
				setChangedMember(SordHistKeyC.mbKeyName);
			}
		}
		
		
		/// <summary>
		/// ID of the attribute.
		/// </summary>
		public int keyNo
		{
			get
			{
				return keyNoValue;
			}
			set
			{
				this.keyNoValue = value;
				setChangedMember(SordHistKeyC.mbKeyNo);
			}
		}
		
		
		/// <summary>
		/// Index of the attribute within an array of attributes.
		/// </summary>
		public int keyIndex
		{
			get
			{
				return keyIndexValue;
			}
			set
			{
				this.keyIndexValue = value;
			}
		}
		
		
		/// <summary>
		/// External ID of the attribute, serves as an identifier for keyNames.
		/// </summary>
		public int keyId
		{
			get
			{
				return keyIdValue;
			}
			set
			{
				this.keyIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String histGuidValue;

		protected String keyDataValue;

		protected String keyNameValue;

		protected int keyNoValue;

		protected int keyIndexValue;

		protected int keyIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 251810638L;		
	} // end class
}  // end namespace

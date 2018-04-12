//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class TranslateTermData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public TranslateTermData() {
		}		
		
		public TranslateTermData(String @guid, String @TStamp, int @status, String @lang1, String @lang2, String @lang3, String @lang4, String @lang5, String @lang6, String @lang7, String @lang8, String @lang9, String @TStampSync) {
			this.guidValue = @guid;
			this.TStampValue = @TStamp;
			this.statusValue = @status;
			this.lang1Value = @lang1;
			this.lang2Value = @lang2;
			this.lang3Value = @lang3;
			this.lang4Value = @lang4;
			this.lang5Value = @lang5;
			this.lang6Value = @lang6;
			this.lang7Value = @lang7;
			this.lang8Value = @lang8;
			this.lang9Value = @lang9;
			this.TStampSyncValue = @TStampSync;
		}		
		
		public TranslateTermData(TranslateTermData rhs) : base(rhs)
		{
			this.guidValue = rhs.guidValue;
			this.TStampValue = rhs.TStampValue;
			this.statusValue = rhs.statusValue;
			this.lang1Value = rhs.lang1Value;
			this.lang2Value = rhs.lang2Value;
			this.lang3Value = rhs.lang3Value;
			this.lang4Value = rhs.lang4Value;
			this.lang5Value = rhs.lang5Value;
			this.lang6Value = rhs.lang6Value;
			this.lang7Value = rhs.lang7Value;
			this.lang8Value = rhs.lang8Value;
			this.lang9Value = rhs.lang9Value;
			this.TStampSyncValue = rhs.TStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// GUID
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
				setChangedMember(TranslateTermDataC.mbGuid);
			}
		}
		
		
		/// <summary>
		/// Timestamp.
		/// </summary>
		/// <remarks>
		/// Last mofified time, ISO date with dots measured in UTC
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(TranslateTermDataC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Status.
		/// </summary>
		/// <remarks>
		/// The object is not deleted, if <code>status</code> is -1.
		/// </remarks>
		public int status
		{
			get
			{
				return statusValue;
			}
			set
			{
				this.statusValue = value;
				setChangedMember(TranslateTermDataC.mbStatus);
			}
		}
		
		
		/// <summary>
		/// Language 1.
		/// </summary>
		/// <remarks>
		/// System language.
		/// </remarks>
		public String lang1
		{
			get
			{
				return lang1Value;
			}
			set
			{
				this.lang1Value = value;
				setChangedMember(TranslateTermDataC.mbLang1);
			}
		}
		
		
		/// <summary>
		/// Language 2
		/// </summary>
		public String lang2
		{
			get
			{
				return lang2Value;
			}
			set
			{
				this.lang2Value = value;
				setChangedMember(TranslateTermDataC.mbLang2);
			}
		}
		
		
		/// <summary>
		/// Language 3
		/// </summary>
		public String lang3
		{
			get
			{
				return lang3Value;
			}
			set
			{
				this.lang3Value = value;
				setChangedMember(TranslateTermDataC.mbLang3);
			}
		}
		
		
		/// <summary>
		/// Language 4
		/// </summary>
		public String lang4
		{
			get
			{
				return lang4Value;
			}
			set
			{
				this.lang4Value = value;
				setChangedMember(TranslateTermDataC.mbLang4);
			}
		}
		
		
		/// <summary>
		/// Language 5
		/// </summary>
		public String lang5
		{
			get
			{
				return lang5Value;
			}
			set
			{
				this.lang5Value = value;
				setChangedMember(TranslateTermDataC.mbLang5);
			}
		}
		
		
		/// <summary>
		/// Language 6
		/// </summary>
		public String lang6
		{
			get
			{
				return lang6Value;
			}
			set
			{
				this.lang6Value = value;
				setChangedMember(TranslateTermDataC.mbLang6);
			}
		}
		
		
		/// <summary>
		/// Language 7
		/// </summary>
		public String lang7
		{
			get
			{
				return lang7Value;
			}
			set
			{
				this.lang7Value = value;
				setChangedMember(TranslateTermDataC.mbLang7);
			}
		}
		
		
		/// <summary>
		/// Language 8
		/// </summary>
		public String lang8
		{
			get
			{
				return lang8Value;
			}
			set
			{
				this.lang8Value = value;
				setChangedMember(TranslateTermDataC.mbLang8);
			}
		}
		
		
		/// <summary>
		/// Language 9
		/// </summary>
		public String lang9
		{
			get
			{
				return lang9Value;
			}
			set
			{
				this.lang9Value = value;
				setChangedMember(TranslateTermDataC.mbLang9);
			}
		}
		
		
		/// <summary>
		/// Timestamp.
		/// </summary>
		/// <remarks>
		/// Timestamp of this object's last export by the replication.
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(TranslateTermDataC.mbTStampSync);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String guidValue;

		protected String TStampValue;

		protected int statusValue;

		protected String lang1Value;

		protected String lang2Value;

		protected String lang3Value;

		protected String lang4Value;

		protected String lang5Value;

		protected String lang6Value;

		protected String lang7Value;

		protected String lang8Value;

		protected String lang9Value;

		protected String TStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 486835904L;		
	} // end class
}  // end namespace

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
	/// Objects of this class represent one term in different languages.
	/// </summary>
	public class TranslateTerm : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public TranslateTerm() {
		}		
		
		public TranslateTerm(String @guid, bool @deleted, String @tStamp, String[] @termLangs, String[] @langs, String @tStampSync, String @translationKey) {
			this.guidValue = @guid;
			this.deletedValue = @deleted;
			this.tStampValue = @tStamp;
			this.termLangsValue = @termLangs;
			this.langsValue = @langs;
			this.tStampSyncValue = @tStampSync;
			this.translationKeyValue = @translationKey;
		}		
		
		public TranslateTerm(TranslateTerm rhs) : base(rhs)
		{
			this.guidValue = rhs.guidValue;
			this.deletedValue = rhs.deletedValue;
			this.tStampValue = rhs.tStampValue;
			this.termLangsValue = rhs.termLangsValue;
			this.langsValue = rhs.langsValue;
			this.tStampSyncValue = rhs.tStampSyncValue;
			this.translationKeyValue = rhs.translationKeyValue;
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
			}
		}
		
		
		/// <summary>
		/// True, if this entry is logically deleted.
		/// </summary>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
			}
		}
		
		
		/// <summary>
		/// Last modified.
		/// </summary>
		/// <remarks>
		/// ISO date with seaparator "." measured in UTC.
		/// </remarks>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Term in its languages.
		/// </summary>
		/// <remarks>
		/// The Term <code>termLangs[i]</code> is in Language <code>langs[i]</code>.
		/// If a translation does not exist, the corresponding <code>termLangs[.]</code> is an empty string.
		/// </remarks>
		public String[] termLangs
		{
			get
			{
				return termLangsValue;
			}
			set
			{
				this.termLangsValue = value;
			}
		}
		
		
		/// <summary>
		/// The languages of the term in <code>termLangs</code>.
		/// </summary>
		/// <remarks>
		/// In an array of TranslateTerm objects returned in FindResult or
		/// returned by checkoutTranslateTerm, all objects share the same
		/// array <code>langs</code>.
		/// </remarks>
		public String[] langs
		{
			get
			{
				return langsValue;
			}
			set
			{
				this.langsValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String tStampSync
		{
			get
			{
				return tStampSyncValue;
			}
			set
			{
				this.tStampSyncValue = value;
			}
		}
		
		
		/// <summary>
		/// Read-only member.
		/// </summary>
		/// <remarks>
		/// The IX sets this member when a client searches for
		/// translation keys from property files.
		/// </remarks>
		public String translationKey
		{
			get
			{
				return translationKeyValue;
			}
			set
			{
				this.translationKeyValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String guidValue;

		protected bool deletedValue;

		protected String tStampValue;

		protected String[] termLangsValue;

		protected String[] langsValue;

		protected String tStampSyncValue;

		protected String translationKeyValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 356302605L;		
	} // end class
}  // end namespace

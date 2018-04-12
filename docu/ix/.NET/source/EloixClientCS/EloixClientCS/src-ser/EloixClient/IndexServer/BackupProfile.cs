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
	/// This class represents settings of a ELOdm backup profile.
	/// </summary>
	public class BackupProfile : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public BackupProfile() {
		}		
		
		public BackupProfile(String @name, int @pathId, int @slot, bool @writeKeywording, String @sqlDocSelect, int @nbOfDocsPerLoop, int @retention) {
			this.nameValue = @name;
			this.pathIdValue = @pathId;
			this.slotValue = @slot;
			this.writeKeywordingValue = @writeKeywording;
			this.sqlDocSelectValue = @sqlDocSelect;
			this.nbOfDocsPerLoopValue = @nbOfDocsPerLoop;
			this.retentionValue = @retention;
		}		
		
		public BackupProfile(BackupProfile rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.pathIdValue = rhs.pathIdValue;
			this.slotValue = rhs.slotValue;
			this.writeKeywordingValue = rhs.writeKeywordingValue;
			this.sqlDocSelectValue = rhs.sqlDocSelectValue;
			this.nbOfDocsPerLoopValue = rhs.nbOfDocsPerLoopValue;
			this.retentionValue = rhs.retentionValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Backup profile name
		/// </summary>
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
		/// Storage path id
		/// </summary>
		public int pathId
		{
			get
			{
				return pathIdValue;
			}
			set
			{
				this.pathIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Backup slot
		/// </summary>
		public int slot
		{
			get
			{
				return slotValue;
			}
			set
			{
				this.slotValue = value;
			}
		}
		
		
		/// <summary>
		/// Store keywording too
		/// </summary>
		public bool writeKeywording
		{
			get
			{
				return writeKeywordingValue;
			}
			set
			{
				this.writeKeywordingValue = value;
			}
		}
		
		
		/// <summary>
		/// Optional SQL command to select the documents to be stored.
		/// </summary>
		public String sqlDocSelect
		{
			get
			{
				return sqlDocSelectValue;
			}
			set
			{
				this.sqlDocSelectValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum number of documents per backup loop.
		/// </summary>
		public int nbOfDocsPerLoop
		{
			get
			{
				return nbOfDocsPerLoopValue;
			}
			set
			{
				this.nbOfDocsPerLoopValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved
		/// </summary>
		public int retention
		{
			get
			{
				return retentionValue;
			}
			set
			{
				this.retentionValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected int pathIdValue;

		protected int slotValue;

		protected bool writeKeywordingValue;

		protected String sqlDocSelectValue;

		protected int nbOfDocsPerLoopValue;

		protected int retentionValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1230334315L;		
	} // end class
}  // end namespace

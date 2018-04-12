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
	/// <p>This class represents a storage path.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class StoreInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public StoreInfo() {
		}		
		
		public StoreInfo(String @createDateISO, String @dir, int @flags, int @id, String @name, int @scatter, bool @stdPath, String @updateDateISO, String @previewDir, String @fulltextDir) {
			this.createDateISOValue = @createDateISO;
			this.dirValue = @dir;
			this.flagsValue = @flags;
			this.idValue = @id;
			this.nameValue = @name;
			this.scatterValue = @scatter;
			this.stdPathValue = @stdPath;
			this.updateDateISOValue = @updateDateISO;
			this.previewDirValue = @previewDir;
			this.fulltextDirValue = @fulltextDir;
		}		
		
		public StoreInfo(StoreInfo rhs) : base(rhs)
		{
			this.createDateISOValue = rhs.createDateISOValue;
			this.dirValue = rhs.dirValue;
			this.flagsValue = rhs.flagsValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.scatterValue = rhs.scatterValue;
			this.stdPathValue = rhs.stdPathValue;
			this.updateDateISOValue = rhs.updateDateISOValue;
			this.previewDirValue = rhs.previewDirValue;
			this.fulltextDirValue = rhs.fulltextDirValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Create date (UTC).
		/// </summary>
		public String createDateISO
		{
			get
			{
				return createDateISOValue;
			}
			set
			{
				this.createDateISOValue = value;
			}
		}
		
		
		/// <summary>
		/// Physical directory where the documents of this path are stored.
		/// </summary>
		/// <remarks>
		/// Length of the field in database: 255byte.
		/// </remarks>
		public String dir
		{
			get
			{
				return dirValue;
			}
			set
			{
				this.dirValue = value;
			}
		}
		
		
		/// <summary>
		/// Bitset of options.
		/// </summary>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		/// <summary>
		/// Path ID
		/// Set this value to -1 in order to create a new storage path.
		/// </summary>
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
		/// Path name.
		/// </summary>
		/// <remarks>
		/// Length of the field in database: 16byte.
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
		/// Granularity of subdirectories in the physical directory.
		/// </summary>
		public int scatter
		{
			get
			{
				return scatterValue;
			}
			set
			{
				this.scatterValue = value;
			}
		}
		
		
		/// <summary>
		/// standard path?
		/// </summary>
		/// <remarks>
		/// read-only
		/// </remarks>
		public bool stdPath
		{
			get
			{
				return stdPathValue;
			}
			set
			{
				this.stdPathValue = value;
			}
		}
		
		
		/// <summary>
		/// Update date (UTC).
		/// </summary>
		public String updateDateISO
		{
			get
			{
				return updateDateISOValue;
			}
			set
			{
				this.updateDateISOValue = value;
			}
		}
		
		
		/// <summary>
		/// Physical directory where previews stored.
		/// </summary>
		/// <remarks>
		/// Length of the field in database: 255byte.
		/// </remarks>
		public String previewDir
		{
			get
			{
				return previewDirValue;
			}
			set
			{
				this.previewDirValue = value;
			}
		}
		
		
		/// <summary>
		/// Physical directory where fulltext content is stored.
		/// </summary>
		/// <remarks>
		/// Length of the field in database: 255byte.
		/// </remarks>
		public String fulltextDir
		{
			get
			{
				return fulltextDirValue;
			}
			set
			{
				this.fulltextDirValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String createDateISOValue;

		protected String dirValue;

		protected int flagsValue;

		protected int idValue;

		protected String nameValue;

		protected int scatterValue;

		protected bool stdPathValue;

		protected String updateDateISOValue;

		protected String previewDirValue;

		protected String fulltextDirValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 964052256L;		
	} // end class
}  // end namespace

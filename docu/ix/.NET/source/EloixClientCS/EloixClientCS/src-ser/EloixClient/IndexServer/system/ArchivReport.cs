//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class ArchivReport : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ArchivReport() {
		}		
		
		public ArchivReport(String @archivGUID, IList<EloixClient.Indexserver.system.ArchivValue> @elodmdocs, IList<EloixClient.Indexserver.system.ArchivValue> @objecte) {
			this.archivGUIDValue = @archivGUID;
			this.elodmdocsValue = @elodmdocs;
			this.objecteValue = @objecte;
		}		
		
		public ArchivReport(ArchivReport rhs) : base(rhs)
		{
			this.archivGUIDValue = rhs.archivGUIDValue;
			this.elodmdocsValue = rhs.elodmdocsValue;
			this.objecteValue = rhs.objecteValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String archivGUID
		{
			get
			{
				return archivGUIDValue;
			}
			set
			{
				this.archivGUIDValue = value;
			}
		}
		
		
		public IList<EloixClient.Indexserver.system.ArchivValue> elodmdocs
		{
			get
			{
				return elodmdocsValue;
			}
			set
			{
				this.elodmdocsValue = value;
			}
		}
		
		
		public IList<EloixClient.Indexserver.system.ArchivValue> objecte
		{
			get
			{
				return objecteValue;
			}
			set
			{
				this.objecteValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String archivGUIDValue;

		protected IList<EloixClient.Indexserver.system.ArchivValue> elodmdocsValue;

		protected IList<EloixClient.Indexserver.system.ArchivValue> objecteValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1383534582L;		
	} // end class
}  // end namespace

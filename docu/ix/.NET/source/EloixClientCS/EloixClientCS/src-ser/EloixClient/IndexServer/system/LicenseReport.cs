//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public class LicenseReport : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public LicenseReport() {
		}		
		
		public LicenseReport(int @nbOfServerLicenses, int @nbOfIgLicenses, String @serno, IList<EloixClient.Indexserver.system.LicenseCounter> @counterList, int @fullUser, int @ixUser, int @deletedUser, int @freeUser) {
			this.nbOfServerLicensesValue = @nbOfServerLicenses;
			this.nbOfIgLicensesValue = @nbOfIgLicenses;
			this.sernoValue = @serno;
			this.counterListValue = @counterList;
			this.fullUserValue = @fullUser;
			this.ixUserValue = @ixUser;
			this.deletedUserValue = @deletedUser;
			this.freeUserValue = @freeUser;
		}		
		
		public LicenseReport(LicenseReport rhs) : base(rhs)
		{
			this.nbOfServerLicensesValue = rhs.nbOfServerLicensesValue;
			this.nbOfIgLicensesValue = rhs.nbOfIgLicensesValue;
			this.sernoValue = rhs.sernoValue;
			this.counterListValue = rhs.counterListValue;
			this.fullUserValue = rhs.fullUserValue;
			this.ixUserValue = rhs.ixUserValue;
			this.deletedUserValue = rhs.deletedUserValue;
			this.freeUserValue = rhs.freeUserValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Number of server licenses.
		/// </summary>
		public int nbOfServerLicenses
		{
			get
			{
				return nbOfServerLicensesValue;
			}
			set
			{
				this.nbOfServerLicensesValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of ELO Internet Gateway users.
		/// </summary>
		public int nbOfIgLicenses
		{
			get
			{
				return nbOfIgLicensesValue;
			}
			set
			{
				this.nbOfIgLicensesValue = value;
			}
		}
		
		
		/// <summary>
		/// License key.
		/// </summary>
		public String serno
		{
			get
			{
				return sernoValue;
			}
			set
			{
				this.sernoValue = value;
			}
		}
		
		
		public IList<EloixClient.Indexserver.system.LicenseCounter> counterList
		{
			get
			{
				return counterListValue;
			}
			set
			{
				this.counterListValue = value;
			}
		}
		
		
		public int fullUser
		{
			get
			{
				return fullUserValue;
			}
			set
			{
				this.fullUserValue = value;
			}
		}
		
		
		public int ixUser
		{
			get
			{
				return ixUserValue;
			}
			set
			{
				this.ixUserValue = value;
			}
		}
		
		
		public int deletedUser
		{
			get
			{
				return deletedUserValue;
			}
			set
			{
				this.deletedUserValue = value;
			}
		}
		
		
		public int freeUser
		{
			get
			{
				return freeUserValue;
			}
			set
			{
				this.freeUserValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int nbOfServerLicensesValue;

		protected int nbOfIgLicensesValue;

		protected String sernoValue;

		protected IList<EloixClient.Indexserver.system.LicenseCounter> counterListValue;

		protected int fullUserValue;

		protected int ixUserValue;

		protected int deletedUserValue;

		protected int freeUserValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1320348587L;		
	} // end class
}  // end namespace

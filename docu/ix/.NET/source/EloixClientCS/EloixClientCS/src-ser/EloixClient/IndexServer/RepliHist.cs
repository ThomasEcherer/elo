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
	/// Internal class
	/// </summary>
	public class RepliHist : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public RepliHist() {
		}		
		
		public RepliHist(int @id, String @tSDate, int @imEx, int @succ, String @arcGuid, String @arcShort, String @arcDesc, String @tSBegin, String @tSEnd, int @arcPriorityLocal, int @arcPriorityRemote) {
			this.idValue = @id;
			this.tSDateValue = @tSDate;
			this.imExValue = @imEx;
			this.succValue = @succ;
			this.arcGuidValue = @arcGuid;
			this.arcShortValue = @arcShort;
			this.arcDescValue = @arcDesc;
			this.tSBeginValue = @tSBegin;
			this.tSEndValue = @tSEnd;
			this.arcPriorityLocalValue = @arcPriorityLocal;
			this.arcPriorityRemoteValue = @arcPriorityRemote;
		}		
		
		public RepliHist(RepliHist rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.tSDateValue = rhs.tSDateValue;
			this.imExValue = rhs.imExValue;
			this.succValue = rhs.succValue;
			this.arcGuidValue = rhs.arcGuidValue;
			this.arcShortValue = rhs.arcShortValue;
			this.arcDescValue = rhs.arcDescValue;
			this.tSBeginValue = rhs.tSBeginValue;
			this.tSEndValue = rhs.tSEndValue;
			this.arcPriorityLocalValue = rhs.arcPriorityLocalValue;
			this.arcPriorityRemoteValue = rhs.arcPriorityRemoteValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: rhrowid
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
				setChangedMember(RepliHistC.mbId);
			}
		}
		
		
		/// <summary>
		/// DB column: rhtsdate
		/// </summary>
		public String tSDate
		{
			get
			{
				return tSDateValue;
			}
			set
			{
				this.tSDateValue = value;
				setChangedMember(RepliHistC.mbTSDate);
			}
		}
		
		
		/// <summary>
		/// DB column: rhimex
		/// </summary>
		public int imEx
		{
			get
			{
				return imExValue;
			}
			set
			{
				this.imExValue = value;
				setChangedMember(RepliHistC.mbImEx);
			}
		}
		
		
		/// <summary>
		/// DB column: rhsucc
		/// </summary>
		public int succ
		{
			get
			{
				return succValue;
			}
			set
			{
				this.succValue = value;
				setChangedMember(RepliHistC.mbSucc);
			}
		}
		
		
		/// <summary>
		/// DB column: rharcguid
		/// </summary>
		public String arcGuid
		{
			get
			{
				return arcGuidValue;
			}
			set
			{
				this.arcGuidValue = value;
				setChangedMember(RepliHistC.mbArcGuid);
			}
		}
		
		
		/// <summary>
		/// DB column: rharcshort
		/// </summary>
		public String arcShort
		{
			get
			{
				return arcShortValue;
			}
			set
			{
				this.arcShortValue = value;
				setChangedMember(RepliHistC.mbArcShort);
			}
		}
		
		
		/// <summary>
		/// DB column: rharcdesc
		/// </summary>
		public String arcDesc
		{
			get
			{
				return arcDescValue;
			}
			set
			{
				this.arcDescValue = value;
				setChangedMember(RepliHistC.mbArcDesc);
			}
		}
		
		
		/// <summary>
		/// DB column: rhtsbegin
		/// </summary>
		public String tSBegin
		{
			get
			{
				return tSBeginValue;
			}
			set
			{
				this.tSBeginValue = value;
				setChangedMember(RepliHistC.mbTSBegin);
			}
		}
		
		
		/// <summary>
		/// DB column: rhtsend
		/// </summary>
		public String tSEnd
		{
			get
			{
				return tSEndValue;
			}
			set
			{
				this.tSEndValue = value;
				setChangedMember(RepliHistC.mbTSEnd);
			}
		}
		
		
		public int arcPriorityLocal
		{
			get
			{
				return arcPriorityLocalValue;
			}
			set
			{
				this.arcPriorityLocalValue = value;
				setChangedMember(RepliHistC.mbArcPriorityLocal);
			}
		}
		
		
		public int arcPriorityRemote
		{
			get
			{
				return arcPriorityRemoteValue;
			}
			set
			{
				this.arcPriorityRemoteValue = value;
				setChangedMember(RepliHistC.mbArcPriorityRemote);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int idValue;

		protected String tSDateValue;

		protected int imExValue;

		protected int succValue;

		protected String arcGuidValue;

		protected String arcShortValue;

		protected String arcDescValue;

		protected String tSBeginValue;

		protected String tSEndValue;

		protected int arcPriorityLocalValue;

		protected int arcPriorityRemoteValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 899503054L;		
	} // end class
}  // end namespace

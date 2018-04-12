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
	/// Internal class.
	/// </summary>
	public class Thesaurus : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Thesaurus() {
		}		
		
		public Thesaurus(int @groupId, int @prio, String @data, String @compare, int @listId) {
			this.groupIdValue = @groupId;
			this.prioValue = @prio;
			this.dataValue = @data;
			this.compareValue = @compare;
			this.listIdValue = @listId;
		}		
		
		public Thesaurus(Thesaurus rhs) : base(rhs)
		{
			this.groupIdValue = rhs.groupIdValue;
			this.prioValue = rhs.prioValue;
			this.dataValue = rhs.dataValue;
			this.compareValue = rhs.compareValue;
			this.listIdValue = rhs.listIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: groupid
		/// </summary>
		public int groupId
		{
			get
			{
				return groupIdValue;
			}
			set
			{
				this.groupIdValue = value;
				setChangedMember(ThesaurusC.mbGroupId);
			}
		}
		
		
		/// <summary>
		/// DB column: prio
		/// </summary>
		public int prio
		{
			get
			{
				return prioValue;
			}
			set
			{
				this.prioValue = value;
				setChangedMember(ThesaurusC.mbPrio);
			}
		}
		
		
		/// <summary>
		/// DB column: data
		/// </summary>
		public String data
		{
			get
			{
				return dataValue;
			}
			set
			{
				this.dataValue = value;
				setChangedMember(ThesaurusC.mbData);
			}
		}
		
		
		/// <summary>
		/// DB column: compare
		/// </summary>
		public String compare
		{
			get
			{
				return compareValue;
			}
			set
			{
				this.compareValue = value;
				setChangedMember(ThesaurusC.mbCompare);
			}
		}
		
		
		/// <summary>
		/// DB column: listid
		/// </summary>
		public int listId
		{
			get
			{
				return listIdValue;
			}
			set
			{
				this.listIdValue = value;
				setChangedMember(ThesaurusC.mbListId);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int groupIdValue;

		protected int prioValue;

		protected String dataValue;

		protected String compareValue;

		protected int listIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1664944753L;		
	} // end class
}  // end namespace

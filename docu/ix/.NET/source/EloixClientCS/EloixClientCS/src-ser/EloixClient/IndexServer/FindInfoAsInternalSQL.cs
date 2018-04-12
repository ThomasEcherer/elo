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
	/// SQL command that is built from a FindInfo object.
	/// </summary>
	/// <remarks>
	/// This class contains the elements of an internal SQL statement for finding Sord objects.
	/// Modifying this elements might cause errors or wrong results in subsequent versions of IX.
	/// </remarks>
	public class FindInfoAsInternalSQL : BSerializable
	{
	
		#region Constructors
		
		public FindInfoAsInternalSQL() {
		}		
		
		public FindInfoAsInternalSQL(String @fromTables, String @whereClause, String @orderByClause, String @groupByClause) {
			this.fromTablesValue = @fromTables;
			this.whereClauseValue = @whereClause;
			this.orderByClauseValue = @orderByClause;
			this.groupByClauseValue = @groupByClause;
		}		
		
		public FindInfoAsInternalSQL(FindInfoAsInternalSQL rhs)
		{
			this.fromTablesValue = rhs.fromTablesValue;
			this.whereClauseValue = rhs.whereClauseValue;
			this.orderByClauseValue = rhs.orderByClauseValue;
			this.groupByClauseValue = rhs.groupByClauseValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Comma separated list of table names.
		/// </summary>
		public String fromTables
		{
			get
			{
				return fromTablesValue;
			}
			set
			{
				this.fromTablesValue = value;
			}
		}
		
		
		/// <summary>
		/// SQL WHERE clause.
		/// </summary>
		public String whereClause
		{
			get
			{
				return whereClauseValue;
			}
			set
			{
				this.whereClauseValue = value;
			}
		}
		
		
		/// <summary>
		/// SQL ORDER BY clause.
		/// </summary>
		public String orderByClause
		{
			get
			{
				return orderByClauseValue;
			}
			set
			{
				this.orderByClauseValue = value;
			}
		}
		
		
		/// <summary>
		/// SQL GROUP BY clause.
		/// </summary>
		public String groupByClause
		{
			get
			{
				return groupByClauseValue;
			}
			set
			{
				this.groupByClauseValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String fromTablesValue;

		protected String whereClauseValue;

		protected String orderByClauseValue;

		protected String groupByClauseValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 2003160309L;		
	} // end class
}  // end namespace

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
	/// Finds an object according to the object's index properties.
	/// </summary>
	/// <remarks>
	/// The search terms are concatinated by the operator specified with
	/// FindOptions.searchMode. If FindOptionsC.OPERATOR_OR is the specified
	/// searchMode the members of this class are concatinated in the search string
	/// with the boolean operator "OR". Any other searchMode concatinates with "AND".
	/// 
	/// Exception: userId and maskId are always used as "AND" terms.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class FindByIndex : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByIndex() {
		}		
		
		public FindByIndex(String @delDateIso, String @desc, String @iDateIso, String @maskId, String @name, bool @exactName, EloixClient.IndexServer.ObjKey[] @objKeys, String @ownerId, String @xDateIso, String @acl, String @pathId, String @kind, String @lockId, String[] @maskIds, String @deleteUser, String @deleteDateIso) {
			this.delDateIsoValue = @delDateIso;
			this.descValue = @desc;
			this.iDateIsoValue = @iDateIso;
			this.maskIdValue = @maskId;
			this.nameValue = @name;
			this.exactNameValue = @exactName;
			this.objKeysValue = @objKeys;
			this.ownerIdValue = @ownerId;
			this.xDateIsoValue = @xDateIso;
			this.aclValue = @acl;
			this.pathIdValue = @pathId;
			this.kindValue = @kind;
			this.lockIdValue = @lockId;
			this.maskIdsValue = @maskIds;
			this.deleteUserValue = @deleteUser;
			this.deleteDateIsoValue = @deleteDateIso;
		}		
		
		public FindByIndex(FindByIndex rhs) : base(rhs)
		{
			this.delDateIsoValue = rhs.delDateIsoValue;
			this.descValue = rhs.descValue;
			this.iDateIsoValue = rhs.iDateIsoValue;
			this.maskIdValue = rhs.maskIdValue;
			this.nameValue = rhs.nameValue;
			this.exactNameValue = rhs.exactNameValue;
			this.objKeysValue = rhs.objKeysValue;
			this.ownerIdValue = rhs.ownerIdValue;
			this.xDateIsoValue = rhs.xDateIsoValue;
			this.aclValue = rhs.aclValue;
			this.pathIdValue = rhs.pathIdValue;
			this.kindValue = rhs.kindValue;
			this.lockIdValue = rhs.lockIdValue;
			this.maskIdsValue = rhs.maskIdsValue;
			this.deleteUserValue = rhs.deleteUserValue;
			this.deleteDateIsoValue = rhs.deleteDateIsoValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Find objects with this due date.
		/// </summary>
		/// <remarks>
		/// It is a single date value or a
		/// date range in ISO format.
		/// </remarks>
		public String delDateIso
		{
			get
			{
				return delDateIsoValue;
			}
			set
			{
				this.delDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects with this term included in the description of the object
		/// (case insensitive).
		/// </summary>
		/// <remarks>
		/// This value can be a list of terms separated by blanks.
		/// The terms are concatinated with the operator specified by
		/// FindOptions.searchMode. The wildcard * is allowed, it matches any number
		/// of characters. If desc is to be ignored this value must be set to null.
		/// </remarks>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects with this internal date.
		/// </summary>
		/// <remarks>
		/// It is a single date value or a
		/// date range in ISO format.
		/// </remarks>
		public String iDateIso
		{
			get
			{
				return iDateIsoValue;
			}
			set
			{
				this.iDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects related to this mask ID or name.
		/// </summary>
		/// <remarks>
		/// If the mask relation
		/// is to be ignored this value must be set to an empty string or null.
		/// </remarks>
		public String maskId
		{
			get
			{
				return maskIdValue;
			}
			set
			{
				this.maskIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects with this term(s) included in the name of the object
		/// (case insensitive).
		/// </summary>
		/// <remarks>
		/// This value can be a list of terms separated with
		/// blanks. They are concatinated with the operator specified by
		/// FindOptions.searchMode. The wildcard * is allowed, it matches any number
		/// of characters. If name is to be ignored this value must be set to null.
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
		/// If this option is false, all objects are found that contain the
		/// term specified in <code>name</code> anywhere in their short description
		/// (Sord.name).
		/// </summary>
		/// <remarks>
		/// In other words: a search by <code>*name*</code> is executed.
		/// Set this option true, if wildcards should not added implicitly to the
		/// search term.
		/// </remarks>
		public bool exactName
		{
			get
			{
				return exactNameValue;
			}
			set
			{
				this.exactNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects with this indexing attributes.
		/// </summary>
		/// <remarks>
		/// The values of the attributes
		/// can contain a value range. The wildcard * is allowed in ObjKey.name and
		/// ObjKey.data[], it matches any number of characters. If objKeys is to be
		/// ignored this value must be set to null. The ObjKey.id is ignored, if
		/// ObjKey.name is not empty or ObjKey.id &eq; 0. Searching over ObjKey.id
		/// can only handle one element in ObjKey.data.
		/// </remarks>
		public EloixClient.IndexServer.ObjKey[] objKeys
		{
			get
			{
				return objKeysValue;
			}
			set
			{
				this.objKeysValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects owned by the user with this user ID or name.
		/// </summary>
		/// <remarks>
		/// If the owner
		/// is to be ignored this value must be set to null.
		/// </remarks>
		public String ownerId
		{
			get
			{
				return ownerIdValue;
			}
			set
			{
				this.ownerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects with this external date.
		/// </summary>
		/// <remarks>
		/// It is a single date value or a
		/// date range in ISO format.
		/// 
		/// <p>
		/// IX versions from 9.00.060 support relative date values. Relative date values give
		/// an offset to the current date and use a format similar to ISO format:
		/// "{+|-}YYYY-MM-DD hh:mm:ss", whereby the separator characters can be omitted: "{+|-}YYYYMMDDhhmmss".
		/// A relative date has to be prefixed by + (date is added) or - (date is subtracted).
		/// </p><p>
		/// Examples, assuming the current date is 2016-06-24 16:29:00
		/// <table border="2">
		/// <tr><td>Relative date</td><td>Resulting absolute date</td><td>Remark</td></tr>
		/// <tr><td>+0001-00-00 00:00:00</td><td>2017-06-24 16:29</td><td>Next year, same month etc.</td></tr>
		/// <tr><td>-0000-01-00 00:00:00</td><td>2016-05-24 16:29</td><td>Previous month, same day etc.</td></tr>
		/// <tr><td>+0000</td><td>2016-01-01 00:00...2016-12-31 23:59</td><td>Search documents of this year. Incomplete relative dates are automatically expanded to a date range.</td></tr>
		/// <tr><td>+0000-00</td><td>2016-06-01 00:00...2016-06-30 23:59</td><td>Search documents of this month.</td></tr>
		/// <tr><td>-0000-01</td><td>2016-05-01 00:00...2016-05-31 23:59</td><td>Search documents of the last month.</td></tr>
		/// <tr><td>-0000-00-10...+0000-00-00 00:00:00</td><td>2016-06-14 00:00...2016-06-24 16:29</td><td>Search documents from the last 10 days.</td></tr>
		/// <tr><td>-0001...</td><td>2015-01-01 00:00...</td><td>Search documents from last year or newer.</td></tr>
		/// </table>
		/// </p>
		/// <p>
		/// <i>Hint: Only relative date values are allowed that could also be an absolute date. E.g. a relative date of 100 days or 13 months cannot be specified.</i>
		/// </p>
		/// </remarks>
		public String xDateIso
		{
			get
			{
				return xDateIsoValue;
			}
			set
			{
				this.xDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Constrain results to objects with this access control list.
		/// </summary>
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
			}
		}
		
		
		/// <summary>
		/// Storage path ID or name
		/// </summary>
		public String pathId
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
		/// Colour.
		/// </summary>
		/// <remarks>
		/// If the colour is to be ignored this value must be set to null.
		/// </remarks>
		public String kind
		{
			get
			{
				return kindValue;
			}
			set
			{
				this.kindValue = value;
			}
		}
		
		
		/// <summary>
		/// Set this value to an user's id or name to search for objects currently
		/// locked by that user.
		/// </summary>
		/// <remarks>
		/// To ignore this option, set this value to
		/// <code>null</code> (default).
		/// </remarks>
		public String lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of maskIds.
		/// </summary>
		/// <remarks>
		/// Find objects associated to one of this keywording forms.
		/// </remarks>
		public String[] maskIds
		{
			get
			{
				return maskIdsValue;
			}
			set
			{
				this.maskIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects deleted by the user with this user ID or name.
		/// </summary>
		/// <remarks>
		/// If the deleted user
		/// is to be ignored this value must be set to null.
		/// </remarks>
		public String deleteUser
		{
			get
			{
				return deleteUserValue;
			}
			set
			{
				this.deleteUserValue = value;
			}
		}
		
		
		/// <summary>
		/// Find objects with this delete date.
		/// </summary>
		/// <remarks>
		/// It is a single date value or a
		/// date range in ISO format.
		/// </remarks>
		public String deleteDateIso
		{
			get
			{
				return deleteDateIsoValue;
			}
			set
			{
				this.deleteDateIsoValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String delDateIsoValue;

		protected String descValue;

		protected String iDateIsoValue;

		protected String maskIdValue;

		protected String nameValue;

		protected bool exactNameValue;

		protected EloixClient.IndexServer.ObjKey[] objKeysValue;

		protected String ownerIdValue;

		protected String xDateIsoValue;

		protected String aclValue;

		protected String pathIdValue;

		protected String kindValue;

		protected String lockIdValue;

		protected String[] maskIdsValue;

		protected String deleteUserValue;

		protected String deleteDateIsoValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1985205034L;		
	} // end class
}  // end namespace

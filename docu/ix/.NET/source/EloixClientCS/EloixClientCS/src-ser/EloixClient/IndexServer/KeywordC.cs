//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class KeywordC : BSerializable
	{
	
		#region Constructors
		
		public KeywordC() {
		}		
		
		public KeywordC(int @lnRootId, int @lnId, int @lnText) {
			this.lnRootIdValue = @lnRootId;
			this.lnIdValue = @lnId;
			this.lnTextValue = @lnText;
		}		
		
		public KeywordC(KeywordC rhs)
		{
			this.lnRootIdValue = rhs.lnRootIdValue;
			this.lnIdValue = rhs.lnIdValue;
			this.lnTextValue = rhs.lnTextValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum length of a root keyword ID.
		/// </summary>
		/// <remarks>
		/// If a new keyword list is checked in,
		/// the ID of the root keyword must not exceed this length.
		/// </remarks>
		public int lnRootId
		{
			get
			{
				return lnRootIdValue;
			}
			set
			{
				this.lnRootIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of keyword ID.
		/// </summary>
		public int lnId
		{
			get
			{
				return lnIdValue;
			}
			set
			{
				this.lnIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of keyword text.
		/// </summary>
		public int lnText
		{
			get
			{
				return lnTextValue;
			}
			set
			{
				this.lnTextValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Root ID of standard keyword list.
		/// </summary>
		public const String KWID_STANDARD_LIST = "ELOSTDSWL";

		/// <summary>
		/// Root ID of keyword list used for version numbers.
		/// </summary>
		public const String KWID_VERSION = "ELOSTDVER";

		/// <summary>
		/// Root ID of keyword list used for version comments.
		/// </summary>
		public const String KWID_VERSION_COMMENT = "ELOSTDCOM";

		/// <summary>
		/// Root ID of keyword list used for workflows.
		/// </summary>
		public const String KWID_WORKFLOW = "ELOSTDWFW";

		/// <summary>
		/// Root ID of user keyword list.
		/// </summary>
		public const String KWID_USER_LIST = "USERLIST";

		/// <summary>
		/// Placeholder for current date.
		/// </summary>
		/// <remarks>
		/// The format depends on the date format <code>UserProfileC.SORD_DATE_FORMAT</code>
		/// specified in the user or standard profile.
		/// </remarks>
		public const String PLACEHOLDER_DATE = "%%D%";

		/// <summary>
		/// Placeholder for year (4 digits).
		/// </summary>
		public const String PLACEHOLDER_YEAR = "%%Y%";

		/// <summary>
		/// Placeholder for month (2 digits).
		/// </summary>
		public const String PLACEHOLDER_MONTH = "%%M%";

		/// <summary>
		/// Placeholder for day of month (2 digits).
		/// </summary>
		public const String PLACEHOLDER_DAY = "%%T%";

		/// <summary>
		/// Placeholder for current user name.
		/// </summary>
		public const String PLACEHOLDER_USER_NAME = "%%E%";

		/// <summary>
		/// Placeholder for the value of the specified counter name.
		/// </summary>
		/// <remarks>
		/// The counter name follows the place holder and is suffixed with an extra "%".
		/// E. g. <code>text=PLACEHOLDER_COUNTER_BEGIN + "myRecordCounter" + PLACEHOLDER_COUNTER_END + ". record"</code> is expanded to
		/// <code>text="17. record"</code> assuming myRecordCounter has value 17.
		/// </remarks>
		public const String PLACEHOLDER_COUNTER_BEGIN = "%%C%";

		/// <summary>
		/// End of placeholder for counter name.
		/// </summary>
		public const String PLACEHOLDER_COUNTER_END = "%";

		/// <summary>
		/// Return raw text in <code>checkoutKeywords</code>.
		/// </summary>
		/// <remarks>
		/// Placeholders are not substituted.
		/// </remarks>
		public const long mbRawText = 2L;

		/// <summary>
		/// Return raw text in <code>checkoutKeywords</code>.
		/// </summary>
		/// <remarks>
		/// Placeholders except counters are substituted.
		/// </remarks>
		public const long mbPreCookedText = 4L;

		/// <summary>
		/// The purpose of this constant object is to control the behavior of
		/// <code>checkoutKeywords</code>.
		/// </summary>
		/// <remarks>
		/// Supplying it, <code>checkoutKeywords</code>
		/// will return the raw text (including placeholders) in the returned Keyword
		/// objects. Use this constant, if you want to read keywords into an editor.
		/// </remarks>
		public readonly static EloixClient.IndexServer.KeywordZ mbEdit = new KeywordZ(2L);

		/// <summary>
		/// The purpose of this constant object is to control the behavior of
		/// <code>checkoutKeywords</code>.
		/// </summary>
		/// <remarks>
		/// Supplying it, <code>checkoutKeywords</code>
		/// will return substituted placeholders in the text members of the returned
		/// Keyword objects. Use this constant, if you want to read keywords into a
		/// dialog that lets the user select one of it.
		/// </remarks>
		public readonly static EloixClient.IndexServer.KeywordZ mbView = new KeywordZ(4L);

		/// <summary>
		/// The maximum number of children per keyword.
		/// </summary>
		/// <remarks>
		/// This value is valid for all
		/// keyword lists except the user keyword list (<code>KWID_USER_LIST</code>).
		/// The user keyword list might contain more children below a keyword node.
		/// </remarks>
		public const int MAX_CHILDREN = 676;

		/// <summary>
		/// Maximum depth of a keyword tree.
		/// </summary>
		/// <remarks>
		/// This value is valid for all
		/// keyword lists except the user keyword list (<code>KWID_USER_LIST</code>).
		/// The user keyword list might contain a deeper tree.
		/// </remarks>
		public const int MAX_TREE_DEPTH = 15;

		protected int lnRootIdValue;

		protected int lnIdValue;

		protected int lnTextValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1338796818L;		
	} // end class
}  // end namespace

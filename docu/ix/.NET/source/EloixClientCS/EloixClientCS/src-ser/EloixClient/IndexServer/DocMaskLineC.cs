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
	/// <p>Constants for class <code>DocMaskLine</code></p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH </p>
	/// </summary>
	public class DocMaskLineC : EloixClient.IndexServer.DocMaskLineDataC, BSerializable
	{
	
		#region Constructors
		
		public DocMaskLineC() {
		}		
		
		public DocMaskLineC(int @lnAcl) {
			this.lnAclValue = @lnAcl;
		}		
		
		public DocMaskLineC(DocMaskLineC rhs) : base(rhs)
		{
			this.lnAclValue = rhs.lnAclValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ACL length
		/// </summary>
		public int lnAcl
		{
			get
			{
				return lnAclValue;
			}
			set
			{
				this.lnAclValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: The type of the line information.
		/// </summary>
		/// <remarks>
		/// This can be one of the <code>DocMaskLineC.LINETYPE_*</code> constants.
		/// </remarks>
		public const long mbType = 4L;

		/// <summary>
		/// Member bit: Line flags
		/// </summary>
		public const long mbFlags = 256L;

		/// <summary>
		/// Member bit: ACL
		/// </summary>
		public const long mbAcl = 2048L;

		protected int lnAclValue;

		/// <summary>
		/// Used to check wether a correct constant is used.
		/// </summary>
		public const int _TYPE_TYPE_ID = 3000;

		/// <summary>
		/// Index line contains text information.
		/// </summary>
		public const int TYPE_TEXT = 3000;

		/// <summary>
		/// Index line contains a date.
		/// </summary>
		public const int TYPE_DATE = 3001;

		/// <summary>
		/// Index line contains a number.
		/// </summary>
		/// <remarks>
		/// The number is internally stored as a string
		/// value without any padding. Thus it is not possible to search over an interval.
		/// Use one of the TYPE_NUMBER_F* types to be able to search over intervals.
		/// The number must be formatted according to the locale information of the server.
		/// </remarks>
		public const int TYPE_NUMBER = 3002;

		/// <summary>
		/// Index line contains a reference number ("Aktenzeichen").
		/// </summary>
		public const int TYPE_AZ = 3003;

		/// <summary>
		/// Index line contains a date in ISO format.
		/// </summary>
		public const int TYPE_ISO_DATE = 3004;

		/// <summary>
		/// Index line contains a list entry.
		/// </summary>
		public const int TYPE_LIST = 3005;

		/// <summary>
		/// Index line contains a user name.
		/// </summary>
		public const int TYPE_USER = 3006;

		/// <summary>
		/// Thesaurus
		/// </summary>
		public const int TYPE_THES = 3007;

		/// <summary>
		/// Index line contains a number value with an arbitrary number of fraction digits.
		/// </summary>
		/// <remarks>
		/// The value is internally stored with a padding of &amp; (positive numbers)
		/// or @ (negative numbers). This gives the possibility to search over an interval
		/// of numeric values, e. b. search for "1 ... 12" finds objects with index values 1,2,3,4,...12.
		/// The number must be formatted according to the locale information given in the ClientInfo object.
		/// With this type, the user is responsible to enter always the same number of fraction digits.
		/// Otherwise, a search over a number range will not return the correct results.
		/// The meaning of this field was changed in 8.00.032. The meaning before was a field without any fraction digits.
		/// </remarks>
		public const int TYPE_NUMBER_F0 = 3008;

		/// <summary>
		/// Index line contains a number value with one digit after the decimal point.
		/// </summary>
		public const int TYPE_NUMBER_F1 = 3009;

		/// <summary>
		/// Index line contains a number value with one digit after the decimal point.
		/// </summary>
		public const int TYPE_NUMBER_F2 = 3010;

		/// <summary>
		/// Index line contains a number value of with four digits after the decimal point.
		/// </summary>
		public const int TYPE_NUMBER_F4 = 3011;

		/// <summary>
		/// Index line contains a number value with six digits after the decimal point.
		/// </summary>
		public const int TYPE_NUMBER_F6 = 3012;

		/// <summary>
		/// Index line contains a number value without fraction in the range of (-2^31) to (2^31)-1.
		/// </summary>
		/// <remarks>
		/// This type can only be used for keywording forms with {@link DocMaskC#DATA_ORGANISATION_TABLE}.
		/// </remarks>
		public const int TYPE_INTEGER = 3013;

		/// <summary>
		/// Index line contains a number value without fraction in the range of (-2^63) to (2^63)-1.
		/// </summary>
		/// <remarks>
		/// This type can only be used for keywording forms with {@link DocMaskC#DATA_ORGANISATION_TABLE}.
		/// </remarks>
		public const int TYPE_LONG = 3014;

		/// <summary>
		/// Index line contains a floating point number value with 7 significant digits.
		/// </summary>
		/// <remarks>
		/// This type can only be used for keywording forms with {@link DocMaskC#DATA_ORGANISATION_TABLE}.
		/// To assign a value of this type to {@link ObjKey#data}, the String representation has to conform to the Float.toString() method of Java.
		/// Use dot to separate the fraction part and character 'E' to prefix the exponent.
		/// </remarks>
		public const int TYPE_FLOAT = 3015;

		/// <summary>
		/// Index line contains a floating point number value with 15 significant digits.
		/// </summary>
		/// <remarks>
		/// This type can only be used for keywording forms with {@link DocMaskC#DATA_ORGANISATION_TABLE}.
		/// To assign a value of this type to {@link ObjKey#data}, the String representation has to conform to the Double.toString() method of Java.
		/// Use dot to separate the fraction part and character 'E' to prefix the exponent.
		/// </remarks>
		public const int TYPE_DOUBLE = 3016;

		/// <summary>
		/// Default ist text
		/// </summary>
		public const int DEFAULT = 3000;

		/// <summary>
		/// Index line ID of links.
		/// </summary>
		/// <remarks>
		/// Sord.linksGoOut and Sord.linksComeIn provide a
		/// more convinient way to access links. Links can be added and removed with
		/// the functions linkSords resp. unlinkSords.
		/// </remarks>
		public const int ID_LINK = 50;

		/// <summary>
		/// Index line name of links.
		/// </summary>
		public const String NAME_LINK = "ELO_XLINK";

		/// <summary>
		/// Index line ID of original file name
		/// </summary>
		public const int ID_FILENAME = 51;

		/// <summary>
		/// Index line name of original file name
		/// </summary>
		public const String NAME_FILENAME = "ELO_FNAME";

		/// <summary>
		/// Index line ID to store informations used by "Versendemappe".
		/// </summary>
		public const int DOCKEY_VSL = 52;

		/// <summary>
		/// Index line name to store informations used by "Versendemappe".
		/// </summary>
		public const String DOCNAME_VSL = "ELO_VSL";

		/// <summary>
		/// This constant defines a limit for ObjKey.id values.
		/// </summary>
		/// <remarks>
		/// The following table defines which ObjKey.id values are allowed.
		/// <p><table border="2" summary="">
		/// <tr><td>ObjKey.id</td><td>Comment</td></tr>
		/// <tr><td>0 ... MAX_ID_DOCMASK_LINE</td><td>ObjKeys with ObjKey.data.length &gt; 1 allowed.</td></tr>
		/// <tr><td>MAX_ID_DOCMASK_LINE+1 ... MAX_ID_VALUE_ARRAY</td><td>ObjKeys for Special purposes, e.g. ID_FILE_NAME</td></tr>
		/// </table>
		/// </p><p>
		/// <table border="2">
		/// <tr><td>Symbol</td><td>Value</td></tr>
		/// <tr><td>MAX_ID_DOCMASK_LINE</td><td>49</td></tr>
		/// <tr><td>MAX_ID_VALUE_ARRAY</td><td>59</td></tr>
		/// </table></p>
		/// </remarks>
		public const int MAX_ID_DOCMASK_LINE = 49;

		/// <summary>
		/// This constant defines a limit for ObjKey.id values.
		/// </summary>
		public const int MAX_ID_VALUE_ARRAY = 59;

		public const int MIN_ID_HIDDEN_VALUE = 1000;

		public const int MAX_ID_HIDDEN_VALUE = 100000;

		public const long mbAclItems = 2048L;

		public const long mbHidden = 256L;

		public const long mbNextTab = 256L;

		public const long mbOnlyBuzzwords = 256L;

		public const long mbPostfixAsterix = 256L;

		public const long mbPrefixAsterix = 256L;

		public const long mbReadOnly = 256L;

		public const long mbTabOrder = 256L;

		public const long mbTranslate = 256L;

		public const long mbImportant = 256L;

		public const long mbVersion = 256L;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1453574806L;		
	} // end class
}  // end namespace

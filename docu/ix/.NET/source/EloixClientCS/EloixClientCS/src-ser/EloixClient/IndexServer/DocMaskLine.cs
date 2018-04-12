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
	/// This class contains data for a line in the document mask.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class DocMaskLine : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocMaskLine() {
		}		
		
		public DocMaskLine(String @comment, int @id, String @key, int @maskId, int @max, int @min, String @name, EloixClient.IndexServer.AclItem[] @aclItems, bool @canEdit, int @editCol, int @editRow, int @editWidth, bool @hidden, int @labelCol, int @labelRow, bool @nextTab, bool @onlyBuzzwords, bool @postfixAsterix, bool @prefixAsterix, bool @readOnly, int @tabOrder, int @type, String @externalData, bool @important, bool @notTokenized, bool @excludeFromISearch, bool @version, bool @translate, String @acl, int @access, bool @disableWordWheel, String @defaultValue, int @tabIndex, String @serverScriptName, bool @inherit, bool @inheritFromParent, String @nameTranslationKey, String @commentTranslationKey, bool @valueArray, String @validateExpression, bool @required) {
			this.commentValue = @comment;
			this.idValue = @id;
			this.keyValue = @key;
			this.maskIdValue = @maskId;
			this.maxValue = @max;
			this.minValue = @min;
			this.nameValue = @name;
			this.aclItemsValue = @aclItems;
			this.canEditValue = @canEdit;
			this.editColValue = @editCol;
			this.editRowValue = @editRow;
			this.editWidthValue = @editWidth;
			this.hiddenValue = @hidden;
			this.labelColValue = @labelCol;
			this.labelRowValue = @labelRow;
			this.nextTabValue = @nextTab;
			this.onlyBuzzwordsValue = @onlyBuzzwords;
			this.postfixAsterixValue = @postfixAsterix;
			this.prefixAsterixValue = @prefixAsterix;
			this.readOnlyValue = @readOnly;
			this.tabOrderValue = @tabOrder;
			this.typeValue = @type;
			this.externalDataValue = @externalData;
			this.importantValue = @important;
			this.notTokenizedValue = @notTokenized;
			this.excludeFromISearchValue = @excludeFromISearch;
			this.versionValue = @version;
			this.translateValue = @translate;
			this.aclValue = @acl;
			this.accessValue = @access;
			this.disableWordWheelValue = @disableWordWheel;
			this.defaultValueValue = @defaultValue;
			this.tabIndexValue = @tabIndex;
			this.serverScriptNameValue = @serverScriptName;
			this.inheritValue = @inherit;
			this.inheritFromParentValue = @inheritFromParent;
			this.nameTranslationKeyValue = @nameTranslationKey;
			this.commentTranslationKeyValue = @commentTranslationKey;
			this.valueArrayValue = @valueArray;
			this.validateExpressionValue = @validateExpression;
			this.requiredValue = @required;
		}		
		
		public DocMaskLine(DocMaskLine rhs) : base(rhs)
		{
			this.commentValue = rhs.commentValue;
			this.idValue = rhs.idValue;
			this.keyValue = rhs.keyValue;
			this.maskIdValue = rhs.maskIdValue;
			this.maxValue = rhs.maxValue;
			this.minValue = rhs.minValue;
			this.nameValue = rhs.nameValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.canEditValue = rhs.canEditValue;
			this.editColValue = rhs.editColValue;
			this.editRowValue = rhs.editRowValue;
			this.editWidthValue = rhs.editWidthValue;
			this.hiddenValue = rhs.hiddenValue;
			this.labelColValue = rhs.labelColValue;
			this.labelRowValue = rhs.labelRowValue;
			this.nextTabValue = rhs.nextTabValue;
			this.onlyBuzzwordsValue = rhs.onlyBuzzwordsValue;
			this.postfixAsterixValue = rhs.postfixAsterixValue;
			this.prefixAsterixValue = rhs.prefixAsterixValue;
			this.readOnlyValue = rhs.readOnlyValue;
			this.tabOrderValue = rhs.tabOrderValue;
			this.typeValue = rhs.typeValue;
			this.externalDataValue = rhs.externalDataValue;
			this.importantValue = rhs.importantValue;
			this.notTokenizedValue = rhs.notTokenizedValue;
			this.excludeFromISearchValue = rhs.excludeFromISearchValue;
			this.versionValue = rhs.versionValue;
			this.translateValue = rhs.translateValue;
			this.aclValue = rhs.aclValue;
			this.accessValue = rhs.accessValue;
			this.disableWordWheelValue = rhs.disableWordWheelValue;
			this.defaultValueValue = rhs.defaultValueValue;
			this.tabIndexValue = rhs.tabIndexValue;
			this.serverScriptNameValue = rhs.serverScriptNameValue;
			this.inheritValue = rhs.inheritValue;
			this.inheritFromParentValue = rhs.inheritFromParentValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
			this.commentTranslationKeyValue = rhs.commentTranslationKeyValue;
			this.valueArrayValue = rhs.valueArrayValue;
			this.validateExpressionValue = rhs.validateExpressionValue;
			this.requiredValue = rhs.requiredValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Quickinfo text for the attribute.
		/// </summary>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
				setChangedMember(DocMaskLineC.mbComment);
			}
		}
		
		
		/// <summary>
		/// The ID of the line information.
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
				setChangedMember(DocMaskLineC.mbId);
			}
		}
		
		
		/// <summary>
		/// The attribute group name.
		/// </summary>
		/// <remarks>
		/// This member corresponds to <code>ObjKey.name</code>.
		/// </remarks>
		public String key
		{
			get
			{
				return keyValue;
			}
			set
			{
				this.keyValue = value;
				setChangedMember(DocMaskLineC.mbKey);
			}
		}
		
		
		/// <summary>
		/// This line information belongs to a storage mask with the ID MaskId.
		/// </summary>
		public int maskId
		{
			get
			{
				return maskIdValue;
			}
			set
			{
				this.maskIdValue = value;
				setChangedMember(DocMaskLineC.mbMaskId);
			}
		}
		
		
		/// <summary>
		/// The maximum value of this attribute.
		/// </summary>
		public int max
		{
			get
			{
				return maxValue;
			}
			set
			{
				this.maxValue = value;
				setChangedMember(DocMaskLineC.mbMax);
			}
		}
		
		
		/// <summary>
		/// The minimum value of this attribute.
		/// </summary>
		public int min
		{
			get
			{
				return minValue;
			}
			set
			{
				this.minValue = value;
				setChangedMember(DocMaskLineC.mbMin);
			}
		}
		
		
		/// <summary>
		/// The name of the attribute.
		/// </summary>
		/// <remarks>
		/// This value is displayed in the lable before the edit field.
		/// It can be translated into reps. from the users language:
		/// set <code>SessionOptionsC.TRANSLATE_TERM</code>.
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
				setChangedMember(DocMaskLineC.mbName);
			}
		}
		
		
		/// <summary>
		/// Access control for mask line.
		/// </summary>
		/// <remarks>
		/// Currently this can only be null or one item representing a key.
		/// </remarks>
		public EloixClient.IndexServer.AclItem[] aclItems
		{
			get
			{
				return aclItemsValue;
			}
			set
			{
				this.aclItemsValue = value;
				setChangedMember(DocMaskLineC.mbAclItems);
			}
		}
		
		
		/// <summary>
		/// Determines whether the index line can be modified.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public bool canEdit
		{
			get
			{
				return canEditValue;
			}
			set
			{
				this.canEditValue = value;
			}
		}
		
		
		/// <summary>
		/// Column position of edit control
		/// </summary>
		public int editCol
		{
			get
			{
				return editColValue;
			}
			set
			{
				this.editColValue = value;
			}
		}
		
		
		/// <summary>
		/// Row postion of edit control
		/// </summary>
		public int editRow
		{
			get
			{
				return editRowValue;
			}
			set
			{
				this.editRowValue = value;
			}
		}
		
		
		/// <summary>
		/// With of edit control
		/// </summary>
		public int editWidth
		{
			get
			{
				return editWidthValue;
			}
			set
			{
				this.editWidthValue = value;
			}
		}
		
		
		/// <summary>
		/// This value should not be displayed to the user.
		/// </summary>
		public bool hidden
		{
			get
			{
				return hiddenValue;
			}
			set
			{
				this.hiddenValue = value;
				setChangedMember(DocMaskLineC.mbHidden);
			}
		}
		
		
		/// <summary>
		/// Column position of label control
		/// </summary>
		public int labelCol
		{
			get
			{
				return labelColValue;
			}
			set
			{
				this.labelColValue = value;
			}
		}
		
		
		/// <summary>
		/// Row position of label control
		/// </summary>
		public int labelRow
		{
			get
			{
				return labelRowValue;
			}
			set
			{
				this.labelRowValue = value;
			}
		}
		
		
		/// <summary>
		/// Creates a new tab in the keywording dialogue.
		/// </summary>
		public bool nextTab
		{
			get
			{
				return nextTabValue;
			}
			set
			{
				this.nextTabValue = value;
				setChangedMember(DocMaskLineC.mbNextTab);
			}
		}
		
		
		/// <summary>
		/// The index line can only contain buzzwords.
		/// </summary>
		public bool onlyBuzzwords
		{
			get
			{
				return onlyBuzzwordsValue;
			}
			set
			{
				this.onlyBuzzwordsValue = value;
				setChangedMember(DocMaskLineC.mbOnlyBuzzwords);
			}
		}
		
		
		/// <summary>
		/// Add "*" after index value in search operation.
		/// </summary>
		public bool postfixAsterix
		{
			get
			{
				return postfixAsterixValue;
			}
			set
			{
				this.postfixAsterixValue = value;
				setChangedMember(DocMaskLineC.mbPostfixAsterix);
			}
		}
		
		
		/// <summary>
		/// Add "*" before index value in search operation.
		/// </summary>
		public bool prefixAsterix
		{
			get
			{
				return prefixAsterixValue;
			}
			set
			{
				this.prefixAsterixValue = value;
				setChangedMember(DocMaskLineC.mbPrefixAsterix);
			}
		}
		
		
		/// <summary>
		/// This value should not be edited in a user interface (convention).
		/// </summary>
		/// <remarks>
		/// Scripts are allowed to edit the value.
		/// </remarks>
		public bool readOnly
		{
			get
			{
				return readOnlyValue;
			}
			set
			{
				this.readOnlyValue = value;
				setChangedMember(DocMaskLineC.mbReadOnly);
			}
		}
		
		
		/// <summary>
		/// Tabulator order of edit control
		/// </summary>
		public int tabOrder
		{
			get
			{
				return tabOrderValue;
			}
			set
			{
				this.tabOrderValue = value;
				setChangedMember(DocMaskLineC.mbTabOrder);
			}
		}
		
		
		/// <summary>
		/// The type of the line information.
		/// </summary>
		/// <remarks>
		/// This can be one of the <code>DocMaskLineC.TYPE_*</code> constants.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
				setChangedMember(DocMaskLineC.mbType);
			}
		}
		
		
		/// <summary>
		/// External data.
		/// </summary>
		/// <remarks>
		/// Can be used to store an arbitary string.
		/// </remarks>
		public String externalData
		{
			get
			{
				return externalDataValue;
			}
			set
			{
				this.externalDataValue = value;
				setChangedMember(DocMaskLineC.mbExternalData);
			}
		}
		
		
		/// <summary>
		/// Display index value next to the objects short description.
		/// </summary>
		/// <remarks>
		/// This element has to be interpreted by the client application.
		/// IndexServer ignores this value.
		/// </remarks>
		public bool important
		{
			get
			{
				return importantValue;
			}
			set
			{
				this.importantValue = value;
				setChangedMember(DocMaskLineC.mbImportant);
			}
		}
		
		
		/// <summary>
		/// Defines whether a index value should be searchable as TOKENIZED or UN_TOKENIZED
		/// </summary>
		public bool notTokenized
		{
			get
			{
				return notTokenizedValue;
			}
			set
			{
				this.notTokenizedValue = value;
			}
		}
		
		
		/// <summary>
		/// If true a index value will not be searchable via iSearch.
		/// </summary>
		/// <remarks>
		/// Does not affect the index search.
		/// </remarks>
		public bool excludeFromISearch
		{
			get
			{
				return excludeFromISearchValue;
			}
			set
			{
				this.excludeFromISearchValue = value;
			}
		}
		
		
		/// <summary>
		/// Display index value in version information dialog when
		/// checking in a document.
		/// </summary>
		/// <remarks>
		/// This element has to be interpreted by the client application.
		/// IndexServer ignores this value.
		/// </remarks>
		public bool version
		{
			get
			{
				return versionValue;
			}
			set
			{
				this.versionValue = value;
				setChangedMember(DocMaskLineC.mbVersion);
			}
		}
		
		
		/// <summary>
		/// Translate index values into or from the users language.
		/// </summary>
		public bool translate
		{
			get
			{
				return translateValue;
			}
			set
			{
				this.translateValue = value;
				setChangedMember(DocMaskLineC.mbTranslate);
			}
		}
		
		
		/// <summary>
		/// Access control for mask line.
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
				setChangedMember(DocMaskLineC.mbAcl);
			}
		}
		
		
		/// <summary>
		/// Bitset of AccessC.LUR_* constants.
		/// </summary>
		/// <remarks>
		/// It contains the access bits for the current user.
		/// Only AccessC.LUR_READ and AccessC.LUR_WRITE are used.
		/// </remarks>
		public int access
		{
			get
			{
				return accessValue;
			}
			set
			{
				this.accessValue = value;
			}
		}
		
		
		/// <summary>
		/// Disable word wheel.
		/// </summary>
		/// <remarks>
		/// Clients should not provide a function to list all
		/// existing values for this index vlaue.
		/// The IndexServer does not set or test this value.
		/// </remarks>
		public bool disableWordWheel
		{
			get
			{
				return disableWordWheelValue;
			}
			set
			{
				this.disableWordWheelValue = value;
			}
		}
		
		
		/// <summary>
		/// This value is assigned to the ObjKey.data element for a new Sord object.
		/// </summary>
		public String defaultValue
		{
			get
			{
				return defaultValueValue;
			}
			set
			{
				this.defaultValueValue = value;
				setChangedMember(DocMaskLineC.mbDefaultValue);
			}
		}
		
		
		/// <summary>
		/// This value represents the number of the tab, this line has to appear on.
		/// </summary>
		/// <remarks>
		/// The first tab's index value is 0. It is on the client's hand to set valid
		/// values when checking in document masks.
		/// </remarks>
		public int tabIndex
		{
			get
			{
				return tabIndexValue;
			}
			set
			{
				this.tabIndexValue = value;
				setChangedMember(DocMaskLineC.mbTabIndex);
			}
		}
		
		
		/// <summary>
		/// A script at the server can serve as the data source of a dynamic keyword
		/// list.
		/// </summary>
		/// <remarks>
		/// This value represents the name of that script. If the value is not
		/// empty, the client can request a list of available input values by calling
		/// the function {@link IXServicePortIF#checkoutKeywordsDynamic(ClientInfo, KeywordsDynamicInfo)}.
		/// </remarks>
		public String serverScriptName
		{
			get
			{
				return serverScriptNameValue;
			}
			set
			{
				this.serverScriptNameValue = value;
				setChangedMember(DocMaskLineC.mbServerScriptName);
			}
		}
		
		
		/// <summary>
		/// Inherit this keywording field to subordinated entries.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This option is used to make sure, that all entries in an archive sub-tree
		/// have the same value for this keywording field. Thereby the field is identified
		/// by its group name ({@link DocMaskLine#key} and {@link ObjKey#name}).
		/// </p><p>
		/// The option corresponds to {@link #inheritFromParent}. As far as {@link #inheritFromParent} is also true
		/// in the keywording forms definition of all sub-items, the option {@link #inherit} effects the following:
		/// <ul><li>The value of the keywording field can only be changed in the parent entry
		/// of the sub-tree. This is the uppermost entry that has the field, which means that the parent's
		/// parent does not have this field.
		/// </li><li>
		/// All sub-items of the parent inherit this value
		/// during a background process. The value is forwarded recursively to the entire
		/// sub-tree under the parent. The recursion stops at items that are assigned to a keywording form
		/// without this field.
		/// </li><li>
		/// When a child entry under the parent is updated, this field is always corrected to the parent's value.
		/// </li><li>
		/// For an object moved into a parent, the object and all sub-items inherit
		/// the keywording field.
		/// </li></ul>
		/// </p><p>
		/// If {@link #inheritFromParent} is false in the keywording form definition of a sub-item, inheritance stops for
		/// the sub-item. Thus, the index field is treated as a different field although it has the same group name.
		/// </p>
		/// </remarks>
		public bool inherit
		{
			get
			{
				return inheritValue;
			}
			set
			{
				this.inheritValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not inherit the parent's value.
		/// </summary>
		public bool inheritFromParent
		{
			get
			{
				return inheritFromParentValue;
			}
			set
			{
				this.inheritFromParentValue = value;
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link DocMaskLine#name}.
		/// </summary>
		public String nameTranslationKey
		{
			get
			{
				return nameTranslationKeyValue;
			}
			set
			{
				this.nameTranslationKeyValue = value;
				setChangedMember(DocMaskLineC.mbNameTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Translation-keyword for {@link DocMaskLine#comment}.
		/// </summary>
		public String commentTranslationKey
		{
			get
			{
				return commentTranslationKeyValue;
			}
			set
			{
				this.commentTranslationKeyValue = value;
				setChangedMember(DocMaskLineC.mbCommentTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Allows multiple values for keywording tables.
		/// </summary>
		/// <remarks>
		/// For keywording forms organized as tables, see {@link DocMaskC#DATA_ORGANISATION_TABLE},
		/// index lines must be explicitly declared for storing multiple values. If this member is true,
		/// the index line is able to store an arbitrary number of values. For keywording forms organized
		/// as name-value pairs, see {@link DocMaskC#DATA_ORGANISATION_OBJKEYS}, index lines can store
		/// multiple values by default and this member has to be ignored.
		/// </remarks>
		public bool valueArray
		{
			get
			{
				return valueArrayValue;
			}
			set
			{
				this.valueArrayValue = value;
			}
		}
		
		
		/// <summary>
		/// RegEx to validate user input for entry.
		/// </summary>
		public String validateExpression
		{
			get
			{
				return validateExpressionValue;
			}
			set
			{
				this.validateExpressionValue = value;
				setChangedMember(DocMaskLineC.mbValidateExpression);
			}
		}
		
		
		/// <summary>
		/// Entry is required.
		/// </summary>
		public bool required
		{
			get
			{
				return requiredValue;
			}
			set
			{
				this.requiredValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String commentValue;

		protected int idValue;

		protected String keyValue;

		protected int maskIdValue;

		protected int maxValue;

		protected int minValue;

		protected String nameValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected bool canEditValue;

		protected int editColValue;

		protected int editRowValue;

		protected int editWidthValue;

		protected bool hiddenValue;

		protected int labelColValue;

		protected int labelRowValue;

		protected bool nextTabValue;

		protected bool onlyBuzzwordsValue;

		protected bool postfixAsterixValue;

		protected bool prefixAsterixValue;

		protected bool readOnlyValue;

		protected int tabOrderValue;

		protected int typeValue;

		protected String externalDataValue;

		protected bool importantValue;

		protected bool notTokenizedValue;

		protected bool excludeFromISearchValue;

		protected bool versionValue;

		protected bool translateValue;

		protected String aclValue;

		protected int accessValue;

		protected bool disableWordWheelValue;

		protected String defaultValueValue;

		protected int tabIndexValue;

		protected String serverScriptNameValue;

		protected bool inheritValue;

		protected bool inheritFromParentValue;

		protected String nameTranslationKeyValue;

		protected String commentTranslationKeyValue;

		protected bool valueArrayValue;

		protected String validateExpressionValue;

		protected bool requiredValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1291500689L;		
	} // end class
}  // end namespace

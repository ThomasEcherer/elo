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
	/// This class contains data for a document mask line template.
	/// </summary>
	public class DocMaskLineTemplate : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocMaskLineTemplate() {
		}		
		
		public DocMaskLineTemplate(String @TStamp, String @TStampSync, int @lockId, String @comment, int @id, String @key, int @max, int @min, String @name, EloixClient.IndexServer.AclItem[] @aclItems, bool @hidden, bool @onlyBuzzwords, bool @postfixAsterix, bool @prefixAsterix, bool @readOnly, int @type, String @externalData, bool @important, bool @notTokenized, bool @excludeFromISearch, bool @version, bool @translate, String @acl, bool @disableWordWheel, String @defaultValue, String @serverScriptName, bool @inherit, bool @inheritFromParent, String @nameTranslationKey, String @commentTranslationKey, String @lockName, String @validateExpression, bool @required) {
			this.TStampValue = @TStamp;
			this.TStampSyncValue = @TStampSync;
			this.lockIdValue = @lockId;
			this.commentValue = @comment;
			this.idValue = @id;
			this.keyValue = @key;
			this.maxValue = @max;
			this.minValue = @min;
			this.nameValue = @name;
			this.aclItemsValue = @aclItems;
			this.hiddenValue = @hidden;
			this.onlyBuzzwordsValue = @onlyBuzzwords;
			this.postfixAsterixValue = @postfixAsterix;
			this.prefixAsterixValue = @prefixAsterix;
			this.readOnlyValue = @readOnly;
			this.typeValue = @type;
			this.externalDataValue = @externalData;
			this.importantValue = @important;
			this.notTokenizedValue = @notTokenized;
			this.excludeFromISearchValue = @excludeFromISearch;
			this.versionValue = @version;
			this.translateValue = @translate;
			this.aclValue = @acl;
			this.disableWordWheelValue = @disableWordWheel;
			this.defaultValueValue = @defaultValue;
			this.serverScriptNameValue = @serverScriptName;
			this.inheritValue = @inherit;
			this.inheritFromParentValue = @inheritFromParent;
			this.nameTranslationKeyValue = @nameTranslationKey;
			this.commentTranslationKeyValue = @commentTranslationKey;
			this.lockNameValue = @lockName;
			this.validateExpressionValue = @validateExpression;
			this.requiredValue = @required;
		}		
		
		public DocMaskLineTemplate(DocMaskLineTemplate rhs) : base(rhs)
		{
			this.TStampValue = rhs.TStampValue;
			this.TStampSyncValue = rhs.TStampSyncValue;
			this.lockIdValue = rhs.lockIdValue;
			this.commentValue = rhs.commentValue;
			this.idValue = rhs.idValue;
			this.keyValue = rhs.keyValue;
			this.maxValue = rhs.maxValue;
			this.minValue = rhs.minValue;
			this.nameValue = rhs.nameValue;
			this.aclItemsValue = rhs.aclItemsValue;
			this.hiddenValue = rhs.hiddenValue;
			this.onlyBuzzwordsValue = rhs.onlyBuzzwordsValue;
			this.postfixAsterixValue = rhs.postfixAsterixValue;
			this.prefixAsterixValue = rhs.prefixAsterixValue;
			this.readOnlyValue = rhs.readOnlyValue;
			this.typeValue = rhs.typeValue;
			this.externalDataValue = rhs.externalDataValue;
			this.importantValue = rhs.importantValue;
			this.notTokenizedValue = rhs.notTokenizedValue;
			this.excludeFromISearchValue = rhs.excludeFromISearchValue;
			this.versionValue = rhs.versionValue;
			this.translateValue = rhs.translateValue;
			this.aclValue = rhs.aclValue;
			this.disableWordWheelValue = rhs.disableWordWheelValue;
			this.defaultValueValue = rhs.defaultValueValue;
			this.serverScriptNameValue = rhs.serverScriptNameValue;
			this.inheritValue = rhs.inheritValue;
			this.inheritFromParentValue = rhs.inheritFromParentValue;
			this.nameTranslationKeyValue = rhs.nameTranslationKeyValue;
			this.commentTranslationKeyValue = rhs.commentTranslationKeyValue;
			this.lockNameValue = rhs.lockNameValue;
			this.validateExpressionValue = rhs.validateExpressionValue;
			this.requiredValue = rhs.requiredValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Last update time of the storage template data.
		/// </summary>
		public String TStamp
		{
			get
			{
				return TStampValue;
			}
			set
			{
				this.TStampValue = value;
				setChangedMember(DocMaskLineTemplateC.mbTStamp);
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's last export by the replication.
		/// </summary>
		public String TStampSync
		{
			get
			{
				return TStampSyncValue;
			}
			set
			{
				this.TStampSyncValue = value;
				setChangedMember(DocMaskLineTemplateC.mbTStampSync);
			}
		}
		
		
		/// <summary>
		/// User ID of the user that has locked the mask line template.
		/// </summary>
		/// <remarks>
		/// If -1, no lock is held.
		/// </remarks>
		public int lockId
		{
			get
			{
				return lockIdValue;
			}
			set
			{
				this.lockIdValue = value;
				setChangedMember(DocMaskLineTemplateC.mbLockId);
			}
		}
		
		
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
				setChangedMember(DocMaskLineTemplateC.mbComment);
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
				setChangedMember(DocMaskLineTemplateC.mbId);
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
				setChangedMember(DocMaskLineTemplateC.mbKey);
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
				setChangedMember(DocMaskLineTemplateC.mbMax);
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
				setChangedMember(DocMaskLineTemplateC.mbMin);
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
				setChangedMember(DocMaskLineTemplateC.mbName);
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
				setChangedMember(DocMaskLineTemplateC.mbAclItems);
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
				setChangedMember(DocMaskLineTemplateC.mbHidden);
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
				setChangedMember(DocMaskLineTemplateC.mbOnlyBuzzwords);
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
				setChangedMember(DocMaskLineTemplateC.mbPostfixAsterix);
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
				setChangedMember(DocMaskLineTemplateC.mbPrefixAsterix);
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
				setChangedMember(DocMaskLineTemplateC.mbReadOnly);
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
				setChangedMember(DocMaskLineTemplateC.mbType);
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
				setChangedMember(DocMaskLineTemplateC.mbExternalData);
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
				setChangedMember(DocMaskLineTemplateC.mbImportant);
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
				setChangedMember(DocMaskLineTemplateC.mbVersion);
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
				setChangedMember(DocMaskLineTemplateC.mbTranslate);
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
				setChangedMember(DocMaskLineTemplateC.mbAcl);
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
				setChangedMember(DocMaskLineTemplateC.mbDefaultValue);
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
				setChangedMember(DocMaskLineTemplateC.mbServerScriptName);
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
				setChangedMember(DocMaskLineTemplateC.mbNameTranslationKey);
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
				setChangedMember(DocMaskLineTemplateC.mbCommentTranslationKey);
			}
		}
		
		
		/// <summary>
		/// Name of the user that has locked the mask line template.
		/// </summary>
		/// <remarks>
		/// Read-only, ignored in checkinDocMaskLineTemplate.
		/// </remarks>
		public String lockName
		{
			get
			{
				return lockNameValue;
			}
			set
			{
				this.lockNameValue = value;
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
				setChangedMember(DocMaskLineTemplateC.mbValidateExpression);
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
		
		protected String TStampValue;

		protected String TStampSyncValue;

		protected int lockIdValue;

		protected String commentValue;

		protected int idValue;

		protected String keyValue;

		protected int maxValue;

		protected int minValue;

		protected String nameValue;

		protected EloixClient.IndexServer.AclItem[] aclItemsValue;

		protected bool hiddenValue;

		protected bool onlyBuzzwordsValue;

		protected bool postfixAsterixValue;

		protected bool prefixAsterixValue;

		protected bool readOnlyValue;

		protected int typeValue;

		protected String externalDataValue;

		protected bool importantValue;

		protected bool notTokenizedValue;

		protected bool excludeFromISearchValue;

		protected bool versionValue;

		protected bool translateValue;

		protected String aclValue;

		protected bool disableWordWheelValue;

		protected String defaultValueValue;

		protected String serverScriptNameValue;

		protected bool inheritValue;

		protected bool inheritFromParentValue;

		protected String nameTranslationKeyValue;

		protected String commentTranslationKeyValue;

		protected String lockNameValue;

		protected String validateExpressionValue;

		protected bool requiredValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 117741089L;		
	} // end class
}  // end namespace

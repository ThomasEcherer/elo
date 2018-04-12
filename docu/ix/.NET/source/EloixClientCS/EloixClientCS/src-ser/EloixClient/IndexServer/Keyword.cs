//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class Keyword : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Keyword() {
		}		
		
		public Keyword(bool @add, EloixClient.IndexServer.Keyword[] @children, bool @enabled, String @id, bool @raw, String @text) {
			this.addValue = @add;
			this.childrenValue = @children;
			this.enabledValue = @enabled;
			this.idValue = @id;
			this.rawValue = @raw;
			this.textValue = @text;
		}		
		
		public Keyword(Keyword rhs) : base(rhs)
		{
			this.addValue = rhs.addValue;
			this.childrenValue = rhs.childrenValue;
			this.enabledValue = rhs.enabledValue;
			this.idValue = rhs.idValue;
			this.rawValue = rhs.rawValue;
			this.textValue = rhs.textValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// <p>Prefix the text of a child keyword with the text of this keyword.
		/// </summary>
		/// <remarks>
		/// This member is interpreted in <code>cookKeywords</code>.
		/// The following relationship exists between the members <code>enabled, add, raw</code></p>
		/// <table border="2">
		/// <tr><td>condition</td><td>conclusion</td></tr>
		/// <tr><td><code>add=true</code></td><td><code>enabled=false, raw=true</code></td></tr>
		/// <tr><td><code>enabled=true</code></td><td><code>add=false, raw=any</code></td></tr>
		/// </table>
		/// </remarks>
		public bool add
		{
			get
			{
				return addValue;
			}
			set
			{
				this.addValue = value;
			}
		}
		
		
		/// <summary>
		/// Child array.
		/// </summary>
		public EloixClient.IndexServer.Keyword[] children
		{
			get
			{
				return childrenValue;
			}
			set
			{
				this.childrenValue = value;
			}
		}
		
		
		/// <summary>
		/// If true, this keyword can be used as a value for an index property.
		/// </summary>
		/// <remarks>
		/// Otherwise its only purpose is to structure the keyword hierachy.
		/// </remarks>
		public bool enabled
		{
			get
			{
				return enabledValue;
			}
			set
			{
				this.enabledValue = value;
			}
		}
		
		
		/// <summary>
		/// Keyword ID.
		/// </summary>
		/// <remarks>
		/// Consists of: groupid + orderid, orderid begins with a ".".
		/// </remarks>
		public String id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// The function <code>cookKeyword()</code> must be called for this keyword in
		/// order to use it for an index property.
		/// </summary>
		/// <remarks>
		/// This is because it contains placeholders
		/// that must be substituted or one of the parent keywords should be added.
		/// </remarks>
		public bool raw
		{
			get
			{
				return rawValue;
			}
			set
			{
				this.rawValue = value;
				setChangedMember(KeywordC.mbRawText);
			}
		}
		
		
		/// <summary>
		/// Keyword text.
		/// </summary>
		/// <remarks>
		/// This term is assigned to an index property. The member
		/// <code>raw</code> should be checked before this term is used.
		/// This text can be translated into reps. from the users language:
		/// set <code>SessionOptionsC.TRANSLATE_TERM</code>.
		/// </remarks>
		public String text
		{
			get
			{
				return textValue;
			}
			set
			{
				this.textValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool addValue;

		protected EloixClient.IndexServer.Keyword[] childrenValue;

		protected bool enabledValue;

		protected String idValue;

		protected bool rawValue;

		protected String textValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1426243550L;		
	} // end class
}  // end namespace

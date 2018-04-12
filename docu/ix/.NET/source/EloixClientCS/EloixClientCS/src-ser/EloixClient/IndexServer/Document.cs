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
	/// Document object with identifier and version arrays for
	/// the document and attachments.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class Document : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Document() {
		}		
		
		public Document(EloixClient.IndexServer.DocVersion[] @atts, EloixClient.IndexServer.DocVersion[] @docs, String @objId) {
			this.attsValue = @atts;
			this.docsValue = @docs;
			this.objIdValue = @objId;
		}		
		
		public Document(Document rhs) : base(rhs)
		{
			this.attsValue = rhs.attsValue;
			this.docsValue = rhs.docsValue;
			this.objIdValue = rhs.objIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Attachment versions for the document.
		/// </summary>
		public EloixClient.IndexServer.DocVersion[] atts
		{
			get
			{
				return attsValue;
			}
			set
			{
				this.attsValue = value;
			}
		}
		
		
		/// <summary>
		/// Versions of the document.
		/// </summary>
		public EloixClient.IndexServer.DocVersion[] docs
		{
			get
			{
				return docsValue;
			}
			set
			{
				this.docsValue = value;
			}
		}
		
		
		/// <summary>
		/// Object ID for the document.
		/// </summary>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.DocVersion[] attsValue;

		protected EloixClient.IndexServer.DocVersion[] docsValue;

		protected String objIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 341056676L;		
	} // end class
}  // end namespace

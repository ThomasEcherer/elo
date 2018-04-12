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
	/// This class can be used to find the documents for
	/// which preview files have to be created.
	/// </summary>
	/// <remarks>
	/// The main purpose is to control the automatic
	/// preview generation in a server process.
	/// </remarks>
	public class FindByPreviewCtrl : BSerializable
	{
	
		#region Constructors
		
		public FindByPreviewCtrl() {
		}		
		
		public FindByPreviewCtrl(bool @previewAvailable, bool @previewError, String[] @fileExtensions) {
			this.previewAvailableValue = @previewAvailable;
			this.previewErrorValue = @previewError;
			this.fileExtensionsValue = @fileExtensions;
		}		
		
		public FindByPreviewCtrl(FindByPreviewCtrl rhs)
		{
			this.previewAvailableValue = rhs.previewAvailableValue;
			this.previewErrorValue = rhs.previewErrorValue;
			this.fileExtensionsValue = rhs.fileExtensionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Finds all documents with previews.
		/// </summary>
		public bool previewAvailable
		{
			get
			{
				return previewAvailableValue;
			}
			set
			{
				this.previewAvailableValue = value;
			}
		}
		
		
		/// <summary>
		/// Finds all documents for which the preview generation failed.
		/// </summary>
		public bool previewError
		{
			get
			{
				return previewErrorValue;
			}
			set
			{
				this.previewErrorValue = value;
			}
		}
		
		
		/// <summary>
		/// Select only those documents with one of this extension.
		/// </summary>
		public String[] fileExtensions
		{
			get
			{
				return fileExtensionsValue;
			}
			set
			{
				this.fileExtensionsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool previewAvailableValue;

		protected bool previewErrorValue;

		protected String[] fileExtensionsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 78436038L;		
	} // end class
}  // end namespace

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
	/// Each file structure element is assigned a SordType.
	/// </summary>
	/// <remarks>
	/// This SordType has three
	/// icons , which are used in the different view in the client: a standard icon,
	/// a disabled icon (empty folders or references) and a workflow icon.<br>
	/// The icons are available in BMP, ICO and JPEG format.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// 
	/// see@ SordTypeC SordTypeC
	/// </remarks>
	public class SordType : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SordType() {
		}		
		
		public SordType(EloixClient.IndexServer.FileData @disabledIcon, String[] @extensions, EloixClient.IndexServer.FileData @icon, int @id, String @name, EloixClient.IndexServer.FileData @workflowIcon) {
			this.disabledIconValue = @disabledIcon;
			this.extensionsValue = @extensions;
			this.iconValue = @icon;
			this.idValue = @id;
			this.nameValue = @name;
			this.workflowIconValue = @workflowIcon;
		}		
		
		public SordType(SordType rhs) : base(rhs)
		{
			this.disabledIconValue = rhs.disabledIconValue;
			this.extensionsValue = rhs.extensionsValue;
			this.iconValue = rhs.iconValue;
			this.idValue = rhs.idValue;
			this.nameValue = rhs.nameValue;
			this.workflowIconValue = rhs.workflowIconValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// File data of disabled icon.
		/// </summary>
		public EloixClient.IndexServer.FileData disabledIcon
		{
			get
			{
				return disabledIconValue;
			}
			set
			{
				this.disabledIconValue = value;
				setChangedMember(SordTypeC.mbDisabledIconMember);
			}
		}
		
		
		/// <summary>
		/// For document types, this array lists the associated file extensions.
		/// </summary>
		public String[] extensions
		{
			get
			{
				return extensionsValue;
			}
			set
			{
				this.extensionsValue = value;
			}
		}
		
		
		/// <summary>
		/// File data of normal icon.
		/// </summary>
		public EloixClient.IndexServer.FileData icon
		{
			get
			{
				return iconValue;
			}
			set
			{
				this.iconValue = value;
				setChangedMember(SordTypeC.mbIconMember);
			}
		}
		
		
		/// <summary>
		/// Sord type ID.
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
				setChangedMember(SordTypeC.mbIdNameExt);
			}
		}
		
		
		/// <summary>
		/// Type name.
		/// </summary>
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
		/// File data of workflow icon.
		/// </summary>
		public EloixClient.IndexServer.FileData workflowIcon
		{
			get
			{
				return workflowIconValue;
			}
			set
			{
				this.workflowIconValue = value;
				setChangedMember(SordTypeC.mbWorkflowIconMember);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.FileData disabledIconValue;

		protected String[] extensionsValue;

		protected EloixClient.IndexServer.FileData iconValue;

		protected int idValue;

		protected String nameValue;

		protected EloixClient.IndexServer.FileData workflowIconValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2065094749L;		
	} // end class
}  // end namespace

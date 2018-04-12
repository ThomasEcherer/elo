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
	/// Copy archive elements in other position in the archive.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2009
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class ProcessCopyElements : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public ProcessCopyElements() {
		}		
		
		public ProcessCopyElements(EloixClient.IndexServer.CopyOptions @copyOptions, bool @createMapping, EloixClient.IndexServer.CopyResult @copyResult) {
			this.copyOptionsValue = @copyOptions;
			this.createMappingValue = @createMapping;
			this.copyResultValue = @copyResult;
		}		
		
		public ProcessCopyElements(ProcessCopyElements rhs) : base(rhs)
		{
			this.copyOptionsValue = rhs.copyOptionsValue;
			this.createMappingValue = rhs.createMappingValue;
			this.copyResultValue = rhs.copyResultValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Options for the copy-process
		/// </summary>
		public EloixClient.IndexServer.CopyOptions copyOptions
		{
			get
			{
				return copyOptionsValue;
			}
			set
			{
				this.copyOptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// If createMapping is true, at the copyResult, the maps source-id to copy-id
		/// will be filled.
		/// </summary>
		/// <remarks>
		/// Defaults to false.
		/// </remarks>
		public bool createMapping
		{
			get
			{
				return createMappingValue;
			}
			set
			{
				this.createMappingValue = value;
			}
		}
		
		
		/// <summary>
		/// Result of copy process.
		/// </summary>
		public EloixClient.IndexServer.CopyResult copyResult
		{
			get
			{
				return copyResultValue;
			}
			set
			{
				this.copyResultValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.CopyOptions copyOptionsValue;

		protected bool createMappingValue;

		protected EloixClient.IndexServer.CopyResult copyResultValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 147051188L;		
	} // end class
}  // end namespace

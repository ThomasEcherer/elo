using System;
using de.elo.ix.client;
using EloixClient.IndexServerFW.Content;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// Wrapper class for accessing document versions and attachments.
  /// </summary>
  public class FSDocVersion : FWDocVersion
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Content interface object</param>
    /// <param name="dv">DocVersion object</param>
    /// <param name="sord">Sord object</param>
    /// <param name="type">Type of DocVersion object (version, attachment, signature, preview). </param>
    public FSDocVersion(FSContentInterface ifc, DocVersion dv, FWSord sord, FWDocVersionType type)
      : base(ifc, dv, sord, type)
    {
    }

    /// <summary>
    /// Version, attachment, signature, preview file path
    /// </summary>
    /// <remarks>
    /// The file of a document version resides in the ELOFS drive. 
    /// Files of attachments, signatures or previews are requested from 
    /// IndexServer and downloaded into the local temporary directory.
    /// </remarks>
    public override String File
    {
      get
      {
        if (dvVal.workVersion)
        {
          if (fileVal == null)
          {
            // Ensure RefPaths are read
            string s = sord.ArcPathString;
            fileVal = ((FSContentInterface)ifc).GetFileSystemPath(sord.Core, dvVal);
          }
          return fileVal;
        }
        else
        {
          return base.File;
        }
      }

      set
      {
        base.File = value;
      }
    }

   }
}

using System;
using System.Collections;
using System.Collections.Generic;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{
  /// <summary>
  /// This class manages the document versions or attachment versions of a archive document.
  /// </summary>
  public class FWDocVersions : FWContentBase, IEnumerable<FWDocVersion>
  {
    /// <summary>
    /// List of document versions
    /// </summary>
    protected List<FWDocVersion> docs;
    /// <summary>
    /// Type of version, either FWDocVersionType.VERSION or FWDocVersionType.ATTACHMENT
    /// </summary>
    protected FWDocVersionType typeVal;
    /// <summary>
    /// Sord object
    /// </summary>
    protected FWSord sord;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Content interface object</param>
    /// <param name="dvs">DocVersion objects from IndexServer API</param>
    /// <param name="sord">Sord object from IndexServer API</param>
    /// <param name="type">Type of versions</param>
    public FWDocVersions(FWContentInterface ifc, DocVersion[] dvs, FWSord sord, FWDocVersionType type)
      : base(ifc)
    {
      this.docs = new List<FWDocVersion>(dvs != null ? dvs.Length : 0);
      if (dvs != null) foreach (DocVersion v in dvs) InternalAdd(v);
      this.typeVal = type;
      this.sord = sord;
    }

    /// <summary>
    /// Gets the number of versions
    /// </summary>
    public int Count
    {
      get { return docs.Count; }
    }

    /// <summary>
    /// Gets the version at index i
    /// </summary>
    /// <param name="i">Index</param>
    /// <returns>Version object</returns>
    public FWDocVersion this[int i]
    {
      get
      {
        return docs[i];
      }
    }

    /// <summary>
    /// Get type of versions
    /// </summary>
    public FWDocVersionType Type
    {
      get { return typeVal; }
    }

    /// <summary>
    /// Adds a new version object to the list of versions.
    /// </summary>
    /// <param name="file">File path</param>
    /// <param name="verNo">This value is stored in FWDocVersion.Version</param>
    /// <param name="comment">This value is stored in FWDocVersions.Comment</param>
    /// <returns>The newly created version object</returns>
    /// <remarks>
    /// This method only has to be called when adding a new file, which is not controlled by the DownloadManager.
    /// </remarks>
    public FWDocVersion Add(String file, String verNo, String comment)
    {
      FWDocVersion ver = ifc.ClassFactory.NewDocVersion(null, sord, typeVal);
      ver.File = file;
      ver.Version = verNo;
      ver.Comment = comment;
      ver.Modified = true;
      docs.Add(ver);
      WorkVersion = ver;
      return ver;
    }

    /// <summary>
    /// Adds a new version object to the list of versions.
    /// </summary>
    /// <param name="file">File path</param>
    /// <returns>The newly created version object</returns>
    /// <remarks>
    /// This method only has to be called when adding a new file, which is not controlled by the DownloadManager.
    /// </remarks>
    public FWDocVersion Add(String file)
    {
      return Add(file, "", new System.IO.FileInfo(file).Name);
    }

    /// <summary>
    /// Adds a new version object initialized with the values from the given DocVersion object.
    /// </summary>
    /// <param name="dv">DocVersion object</param>
    /// <returns>The newly created version object</returns>
    internal FWDocVersion InternalAdd(DocVersion dv)
    {
      FWDocVersion ver = ifc.ClassFactory.NewDocVersion(dv, sord, typeVal);
      docs.Add(ver);
      return ver;
    }

    /// <summary>
    /// Gets/sets the working version
    /// </summary>
    public FWDocVersion WorkVersion
    {
      get
      {
        foreach (FWDocVersion xdv in docs)
        {
          if (xdv.WorkVersion) return xdv;
        }
        return null;
      }
      set
      {
        for (int i = 0; i < docs.Count; i++)
        {
          FWDocVersion xdv = docs[i];
          if (xdv.Id != value.Id || xdv.Id == 0)
          {
            xdv.WorkVersion = false;
          }
          else if (xdv != value)
          {
            docs[i] = value;
          }
        }
        value.WorkVersion = true;
      }
    }

    /// <summary>
    /// Returns an enumerator for iterating over the list of versions
    /// </summary>
    /// <returns>Enumerator object</returns>
    public IEnumerator<FWDocVersion> GetEnumerator()
    {
      return docs.GetEnumerator();
    }
    /// <summary>
    /// Returns an enumerator for iterating over the list of versions
    /// </summary>
    /// <returns>Enumerator object</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
      return docs.GetEnumerator();
    }
  }
}

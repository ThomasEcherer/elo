using System;
using System.Collections.Generic;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.Content
{
  /// <summary>
  /// This class represents a folder object in the archive.
  /// </summary>
  public class FWFolder : FWSord {

    protected IResultCache<FWSord> foldersValue;
    protected IResultCache<FWSord> documentsValue;
    protected IResultCache<FWSord> sordsValue;
    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="ifc">Content interface object</param>
    /// <param name="sord">Sord object from IndexServer API</param>
    public FWFolder(FWContentInterface ifc, Sord sord) : base(ifc, sord)
    {
    }

    public void ResetChildren()
    {
      foldersValue = documentsValue = sordsValue = null;
    }

    protected IResultCache<FWSord> GetChildren(bool inclFolders, bool inclDocs)
    {
      IResultCache<FWSord> myObjects = null;
      IResultCache<FWSord> mySords = sordsValue;

      if (inclFolders && inclDocs)
      {
        myObjects = mySords;
      }
      else
      {
        myObjects = inclFolders ? foldersValue : documentsValue;
        if (myObjects == null)
        {
          myObjects = FilterObjects(mySords, inclFolders, inclDocs);
        }
      }

      if (myObjects == null)
      {
        if (this.Id >= 1)
        {
          myObjects = ClassFactory.NewFindChildrenCache<FWSord>(this, inclFolders, inclDocs);
        }
        else
        {
          // new folder does not have children
          myObjects = new FWResultCacheList<FWSord>();
        }
      }

      return myObjects;
    }

    protected IResultCache<FWSord> FilterObjects(IResultCache<FWSord> mySords, bool inclFolders, bool inclDocs)
    {
      IResultCache<FWSord> ret = null;
      if (mySords != null)
      {
        List<FWSord> myList = new List<FWSord>(mySords.CountEstimated);
        foreach (FWSord s in mySords)
        {
          if (
            (inclDocs && (s is FWDocument)) || 
            (inclFolders && (s is FWFolder))
            )
          {
            myList.Add(s);
          }
        }
        ret = new FWResultCacheList<FWSord>(myList);
      }
      return ret;
    }

    /// <summary>
    /// Gets the list of contained items (folders and documents).
    /// </summary>
    public virtual IResultCache<FWSord> Sords
    {
      get
      {
        IResultCache<FWSord> myObjects = sordsValue;
        if (myObjects == null)
        {
          myObjects = GetChildren(true, true);
          sordsValue = myObjects;
        }
        return myObjects;
      }
    }

    /// <summary>
    /// Gets the list of contained documents.
    /// </summary>
    public virtual IResultCache<FWSord> Documents
    {
      get
      {
        IResultCache<FWSord> myObjects = documentsValue;
        if (myObjects == null)
        {
          myObjects = GetChildren(false, true);
          documentsValue = myObjects;
        }
        return myObjects;
      }
    }

    /// <summary>
    /// Gets the list of sub folders.
    /// </summary>
    public virtual IResultCache<FWSord> Folders
    {
      get
      {
        IResultCache<FWSord> myObjects = foldersValue;
        if (myObjects == null)
        {
          myObjects = GetChildren(true, false);
          foldersValue = myObjects;
        }
        return myObjects;
      }
    }


    public override void Refresh()
    {
        base.Refresh();
        ResetChildren();
    }
  }
}

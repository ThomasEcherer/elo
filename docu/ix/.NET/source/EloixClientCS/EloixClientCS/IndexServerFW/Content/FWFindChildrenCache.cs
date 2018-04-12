using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{
  /// <summary>
  /// This class implements a cache for child lists. 
  /// </summary>
  /// <typeparam name="T">FWSord, FWDocument or FWFolder</typeparam>
  public class FWFindChildrenCache<T> : FWFindSordsCache<T> where T : FWSord
  {
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="ifc">Content interface object.</param>
    /// <param name="parentFolder">The children of this folder are cached.</param>
    /// <param name="inclFolders">True, if child folders have to be included.</param>
    /// <param name="inclDocs">True, if child documents have to be included.</param>
    /// <remarks>
    /// If <c>inclFolders</c> and <c>inclDocs</c> are set to false, no restiction is made.
    /// </remarks>
    public FWFindChildrenCache(FWContentInterface ifc, FWFolder parentFolder, 
      bool inclFolders, bool inclDocs)
      : base(ifc, makeFindInfo(parentFolder, inclFolders, inclDocs), FWFindSordsCache<T>.DEFAULT_SORDZ)
    {
      
    }

    /// <summary>
    /// Create a FindInfo object initialized by the given parameters.
    /// </summary>
    /// <param name="parentFolder">List children of this folder.</param>
    /// <param name="inclFolders">Include child folders.</param>
    /// <param name="inclDocs">Include child documents.</param>
    /// <returns></returns>
    protected static FindInfo makeFindInfo(FWFolder parentFolder, bool inclFolders, bool inclDocs)
    {
      FindInfo fi = new FindInfo();
      FindChildren fc = new FindChildren();
      fc.parentId = Convert.ToString(parentFolder.Id);
      fi.findChildren = fc;

      if (inclFolders && inclDocs)
      {
        // do not need to constrain
      }
      else //(inclFolders || inclDocs) 
      {
        FindByType ft = new FindByType();
        ft.typeStructures = inclFolders;
        ft.typeDocuments = inclDocs;
        fi.findByType = ft;
      }

      //FindOptions fo = new FindOptions();
      //fo.sortOrder = SortOrderC.NONE;
      //fi.findOptions = fo;
        
      return fi;
    }

  }
}

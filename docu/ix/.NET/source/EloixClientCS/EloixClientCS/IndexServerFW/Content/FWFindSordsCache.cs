using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{

  /// <summary>
  /// This class implements a find result cache for finding Sord objects.
  /// The interface functions and properties can be found at IResultCache.
  /// </summary>
  public class FWFindSordsCache<T> : FindResultCache<T, FindInfo> where T : FWSord
  { 
    /// <summary>
    /// Sord objects are read with this members by default.
    /// </summary>  
    public static SordZ DEFAULT_SORDZ = new SordZ(ObjDataC.mbAllMembers | 
      SordC.mbObjKeys | SordC.mbAclItems | SordC.mbDocVersionMembers);
    /// <summary>
    /// Sord objects are read with this members.
    /// </summary>
    protected SordZ sordZVal;
    /// <summary>
    /// Content interface object.
    /// </summary>
    protected FWContentInterface ifc;

    /// <summary>
    /// Constructor. 
    /// </summary>
    /// <param name="ifc">Content interface object</param>
    /// <param name="findInfo">Find info object</param>
    /// <param name="sordZ">Element selector</param>
    public FWFindSordsCache(FWContentInterface ifc, FindInfo findInfo, SordZ sordZ) 
      : base(ifc.Conn.Ix, findInfo)
    {
      this.ifc = ifc;
      this.sordZVal = new SordZ(sordZ != null ? sordZ.bset : 0L);
      this.sordZVal.bset |= SordC.mbMinMembers;
    }

    /// <summary>
    /// Constructs for each Sord object in the given FindResult a framework object.
    /// For Sord objects that refer to documents, FWDocument objects are created.
    /// For Sord objects that refer to folders, FWFolder objects are created.
    /// </summary>
    /// <param name="fr">FindResult object</param>
    /// <returns>Array of framework objects</returns>
    protected override T[] GetItemsFromResult(FindResult fr)
    {
      Sord[] sords = fr.sords;
      T[] xsords = new T[sords.Length];
      for (int i = 0; i < sords.Length; i++)
      {
        Sord sord = sords[i];
        if (sord.id > 1 && sord.type >= SordC.LBT_DOCUMENT)
        {
          T x = (T)(object)new FWDocument(ifc, sord);
          xsords[i] = x;
        }
        else
        {
          xsords[i] = (T)(object)new FWFolder(ifc, sord);
        }
      }
      return xsords;
    }

    /// <summary>
    /// Implements the FindFirst function of the result cache.
    /// </summary>
    /// <param name="findInfo">FindInfo object</param>
    /// <param name="max"></param>
    /// <returns></returns>
    protected override FindResult FindFirst(FindInfo findInfo, int max)
    {
      FindResult fr = this.ix.findFirstSords(findInfo, max, sordZVal);
      return makeFindResultForCache(fr);
    }

    /// <summary>
    /// Find the next sords starting from the given index.
    /// </summary>
    /// <param name="searchId">Search ID returned in FindResult of the call to FindFirst</param>
    /// <param name="idx">Return results starting from this index</param>
    /// <param name="max">Return this number of results at maximum</param>
    /// <returns>FindResult object</returns>
    protected override FindResult FindNext(String searchId, int idx, int max)
    {
      FindResult fr = this.ix.findNextSords(searchId, idx, max, sordZVal);
      return makeFindResultForCache(fr);
    }

    /// <summary>
    /// This function sets the changedMembers member of the Sord objects
    /// to the element selector supplied in the constructor. 
    /// </summary>
    /// <param name="fr">FindResult object</param>
    /// <returns>The object supplied in parameter fr</returns>
    protected FindResult makeFindResultForCache(FindResult fr)
    {
      foreach (Sord sord in fr.sords)
      {
        sord.changedMembers = sordZVal.bset;
      }
      return fr;
    }

    /// <summary>
    /// Updates the internal values for searchId, moreResults etc. after a
    /// call to findFirst or findNext.
    /// </summary>
    /// <param name="startIdx">Results have been read starting from this index</param>
    /// <param name="fr">FindResult object</param>
    protected override int UpdateValues(int startIdx, FindResult fr)
    {
      int n = base.UpdateValues(startIdx, fr);

      if (FindInfo.findOptions != null && FindInfo.findOptions.evalCount)
      {
        if (startIdx == 0)
        {
          CountEstimated = fr.count;
        }
      }

      return n;
    }

    /// <summary>
    /// Elements to be read from DB.
    /// </summary>
    public SordZ SordZ
    {
      get { return sordZVal; }
      set { sordZVal = value; }
    }
  }
}

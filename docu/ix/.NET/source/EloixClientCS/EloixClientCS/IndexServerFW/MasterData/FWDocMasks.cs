using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.MasterData
{
    public class FWDocMasks : FWMasterDataMap<FWDocMask, DocMask>
    {
        /// <summary>
        /// Object collection
        /// </summary>
        FWResultCacheList<FWDocMask> resultCache;

        /// <summary>
        /// Construcor
        /// </summary>
        /// <param name="ifc">Master data interface object</param>
        public FWDocMasks(FWMasterDataInterface ifc)
            : base(ifc)
        {
        }

        /// <summary>
        /// Construcor
        /// </summary>
        /// <param name="ifc">Master data interface object</param>
        /// <param name="subList">List of either only users or groups.</param>
        protected FWDocMasks(FWMasterDataInterface ifc, FWResultCacheList<FWDocMask> subList)
            : base(ifc)
        {
            this.resultCache = subList;
        }

        /// <summary>
        /// Find user masks starting with the given string.
        /// </summary>
        /// <param name="searchExpr">Name</param>
        /// <param name="inclDocMasks">Include masks for documents</param>
        /// <param name="inclFolderMasks">Include masks for folders</param>
        /// <param name="inclSearchMasks">Include masks for searches</param>
        /// <returns></returns>
        public IResultCache<FWDocMask> Find(String searchExpr, bool inclDocMasks, bool inclFolderMasks, bool inclSearchMasks)
        {
            return InternalFind(searchExpr, inclDocMasks, inclFolderMasks, inclSearchMasks);
        }

        /// <summary>
        /// Find user or group names starting with the given string.
        /// </summary>
        /// <param name="searchExpr">Name</param>
        /// <param name="inclDocMasks">Include masks for documents</param>
        /// <param name="inclFolderMasks">Include masks for folders</param>
        /// <param name="inclSearchMasks">Include masks for searches</param>
        /// <returns></returns>
        protected FWResultCacheList<FWDocMask> InternalFind(String searchExpr, bool inclDocMasks, bool inclFolderMasks, bool inclSearchMasks)
        {
            bool isStartWithExpression = false;
            if (searchExpr != null && searchExpr.Length != 0 && !searchExpr.Equals("*"))
            {
                searchExpr = searchExpr.ToLower();
                isStartWithExpression = (searchExpr.EndsWith("*"));
                if (isStartWithExpression) searchExpr = searchExpr.Substring(0, searchExpr.Length - 1);
            }
            else
            {
                searchExpr = "";
            }

            List<FWDocMask> ret = new List<FWDocMask>();
            if (resultCache != null)
            {
                foreach (FWDocMask dm in resultCache)
                {

                    if ((inclDocMasks && dm.Core.details.documentMask) ||
                        (inclFolderMasks && dm.Core.details.folderMask) ||
                        (inclSearchMasks && dm.Core.details.searchMask))
                    {
                        if (searchExpr.Length == 0 ||
                            (isStartWithExpression && dm.Name.ToLower().StartsWith(searchExpr)) ||
                            (!isStartWithExpression && dm.Name.ToLower().Equals(searchExpr)))
                        {
                            ret.Add(dm);
                        }
                    }
                }
            }
            else
            {
                foreach (DocMask dm in Conn.internalConnection.DocMaskCache.Items)
                {

                    if ((inclDocMasks && dm.details.documentMask) ||
                        (inclFolderMasks && dm.details.folderMask) ||
                        (inclSearchMasks && dm.details.searchMask))
                    {
                        if (searchExpr.Length == 0 ||
                            (isStartWithExpression && dm.name.ToLower().StartsWith(searchExpr)) ||
                            (!isStartWithExpression && dm.name.ToLower().Equals(searchExpr)))
                        {
                            ret.Add(CreateWrapper(dm));
                        }
                    }
                }
            }
            return new FWResultCacheList<FWDocMask>(ret);
        }

        /// <summary>
        /// Get masks for documents.
        /// </summary>
        public FWDocMasks DocumentMasks
        {
            get
            {
                return new FWDocMasks(ifc, InternalFind("", true, false, false));
            }
        }
        /// <summary>
        /// Get masks for folders.
        /// </summary>
        public FWDocMasks FolderMasks
        {
            get
            {
                return new FWDocMasks(ifc, InternalFind("", false, true, false));
            }
        }
        /// <summary>
        /// Get masks for searches.
        /// </summary>
        public FWDocMasks SearchMasks
        {
            get
            {
                return new FWDocMasks(ifc, InternalFind("", false, false, true));
            }
        }

        /// <summary>
        /// Set all elements invalid. 
        /// </summary>
        /// <remarks>
        /// The elements are read from the server in the next 
        /// call to a member.
        /// </remarks>
        public override void Invalidate()
        {
            if (resultCache == null)
            {
                Conn.internalConnection.DocMaskCache.Invalidate();
            }
        }

        /// <summary>
        /// Return the internal object cache.
        /// </summary>
        public override IResultCache<FWDocMask> ResultCache
        {
            get
            {
                return InternalFind("", true, true, true);
            }
        }

        /// <summary>
        /// Returns a collection of mask names.
        /// </summary>
        public ReadOnlyCollection<MaskName> MaskNames
        {
            get 
            {
                return Conn.internalConnection.DocMaskCache.MaskNames;
            }
        }

        internal override FWDocMask CreateWrapper(DocMask coreObj)
        {
            return ClassFactory.NewFWDocMask(coreObj);
        }

        internal override bool TryGetCoreObject(string key, out DocMask v)
        {
            return Conn.internalConnection.DocMaskCache.TryGetValue(key, out v);
        }

        internal override DocMask[] CoreItems
        {
            get { return Conn.internalConnection.DocMaskCache.Items; }
        }

        public override FWDocMask GetDefaultValue(string name, int id, string guid)
        {
            //DocMask dm = Conn.Ix.createDocMask("");
            //return CreateWrapper(dm);
            DocMask dm = Conn.Ix.createDocMask("");
            dm.name = name;
            dm.id = id;
            dm.guid = guid;
            return CreateWrapper(dm);
        }

        public override void Lock()
        {
            Conn.Ix.checkoutDocMask(null, DocMaskC.mbOnlyLock, LockC.IF_FREE);
        }

        public override void Unlock()
        {
            Conn.Ix.checkinDocMask(null, DocMaskC.mbOnlyLock, LockC.YES);
        }
    }


    /// <summary>
    /// Compare masks by name.
    /// </summary>
    public class FWCompareFWDocMaskByName : FWCompareObject<FWDocMask>
    {
        /// <summary>
        /// Compare function
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>see IComparable.Compare </returns>
        protected override int internalCompare(FWDocMask o1, FWDocMask o2)
        {
            return o1.Name.CompareTo(o2.Name);
        }
    }

    /// <summary>
    /// Compare masks by ID.
    /// </summary>
    public class FWCompareFWDocMaskById : FWCompareObject<FWDocMask>
    {
        /// <summary>
        /// Compare function
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>see IComparable.Compare </returns>
        protected override int internalCompare(FWDocMask o1, FWDocMask o2)
        {
            return o1.Id - o2.Id;
        }
    }
}
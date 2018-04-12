using System;
using System.Collections.Generic;
using System.Threading;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// Cache of SordType objects (icons for archive folders and documents)
    /// </summary>
    public class SordTypeCache : ItemCache<SordType>
    {
        /// <summary>
        /// Array of SordType objects for folders.
        /// </summary>
        protected ItemObj<SordType[]> itemArrayFolders;
        /// <summary>
        /// Array of SordType objects for documents.
        /// </summary>
        protected ItemObj<SordType[]> itemArrayDocuments;
        /// <summary>
        /// Image list containing all icons
        /// </summary>
        protected SordTypeImageList imageListsValue;

        /// <summary>
        /// ReadAll uses this element selector to read objects.
        /// </summary>
        protected SordTypeZ readMembersZVal;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="lifetimeSeconds">Cache object lifetime</param>
        internal SordTypeCache(IXConnIXServicePortIF_2 ix, int lifetimeSeconds)
            : base(ix, lifetimeSeconds)
        {
            readMembersZVal = SordTypeC.mbAllICO;
        }

        /// <summary>
        /// The cache contains SordType objects that are read by this element selector.
        /// </summary>
        public SordTypeZ SordTypeZ
        {
            get
            {
                return readMembersZVal;
            }
            set
            {
                readMembersZVal = value;
            }
        }

        /// <summary>
        /// Get SordType objects for folders from the cache. 
        /// Does not make an IndexServer request.
        /// </summary>
        /// <returns>Array of SordType objects</returns>
        public virtual SordType[] GetFolderItems()
        {
            return internalGetDocumentNotFolderItems(false);
        }

        /// <summary>
        /// Get SordType objects for documents from the cache. 
        /// Does not make an IndexServer request.
        /// </summary>
        /// <returns>Array of SordType objects</returns>
        public virtual SordType[] GetDocumentItems()
        {
            return internalGetDocumentNotFolderItems(true);
        }

        /// <summary>
        /// Adds or replaces SordType objects in the cache.
        /// </summary>
        /// <param name="ts">Array of SordType objects</param>
        internal override void AddItems(SordType[] ts)
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                itemArrayFolders = null;
                itemArrayDocuments = null;
                imageListsValue = null;

                foreach (SordType sordType in ts)
                {
                    ProtectedAddUnsync(sordType);
                }
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        protected override void ProtectedAddUnsync(SordType sordType)
        {
            String key = Convert.ToString(sordType.id);
            ItemObj<SordType> item = makeItemObj(sordType);
            ProtectedPutUnsync(key, item);
        }

        /// <summary>
        /// Gets SordType objects for folders or documents from the cache.
        /// Does not make a server request.
        /// </summary>
        /// <param name="docNotFolder">True for reading document objects</param>
        /// <returns>Array of SordType objects</returns>
        private SordType[] internalGetDocumentNotFolderItems(bool docNotFolder)
        {
            SordType[] ret = null;
            ItemObj<SordType[]> itemArrayDocsNotFolders = docNotFolder ? itemArrayDocuments : itemArrayFolders;

            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                if (itemArrayDocsNotFolders != null && !itemArrayDocsNotFolders.Expired)
                {
                    ret = itemArrayDocsNotFolders.Value;
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }

            if (ret == null)
            {
                SordType[] allItems = Items;

                if (allItems != null)
                {
                    List<SordType> lst = new List<SordType>(allItems.Length);

                    rwl.AcquireWriterLock(Timeout.Infinite);
                    try
                    {
                        foreach (SordType st in allItems)
                        {
                            if (docNotFolder)
                            {
                                if (st.id >= SordC.LBT_DOCUMENT && st.id != SordC.LBT_ARCHIVE)
                                {
                                    lst.Add(st);
                                }
                            }
                            else
                            {
                                if (st.id < SordC.LBT_DOCUMENT || st.id == SordC.LBT_ARCHIVE)
                                {
                                    lst.Add(st);
                                }
                            }
                        }

                        ItemObj<SordType[]> myItemArray = new ItemObj<SordType[]>(lst.ToArray(), lifetimeTicks);
                        if (docNotFolder)
                        {
                            itemArrayDocuments = myItemArray;
                        }
                        else
                        {
                            itemArrayFolders = myItemArray;
                        }

                        ret = myItemArray.Value;

                    }
                    finally
                    {
                        rwl.ReleaseWriterLock();
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// Reads all SordType objects from IndexServer and update the cache.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
            ProtectedLoadAllObjectsUnsync();
        }
        
        /// <summary>
        /// Reads all SordType objects from IndexServer and update the cache.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        {
            SordType[] sordTypes = ix.checkoutSordTypes(null, readMembersZVal, LockC.NO);
            Items = sordTypes;
            itemArrayFolders = null;
            itemArrayDocuments = null;
            imageListsValue = null;
        }

        /// <summary>
        /// Clear cache.
        /// </summary>
        public override void Invalidate()
        {
            rwl.AcquireWriterLock(Timeout.Infinite);

            base.Invalidate();
            try
            {
                itemArrayFolders = null;
                itemArrayDocuments = null;
                imageListsValue = null;
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }
        /// <summary>
        /// Get the ImageList with all SordType icons (documents + folders)
        /// </summary>
        public virtual SordTypeImageList ImageList
        {
            get
            {
                SordTypeImageList ret = imageListsValue;

                if (ret == null || !ret.Valid)
                {
                    ret = new SordTypeImageList(Items);
                    imageListsValue = ret;
                }

                return ret;
            }
        }
        /// <summary>
        /// Return the SordType for the given file name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <remarks>Only the extension of fileName is used.
        /// If no SordType is defined for the extension, the function returns
        /// the SordType object with ID SordC.LBT_DOCUMENT.</remarks>
        /// <returns></returns>
        public virtual SordType FindSordTypeByExtension(string fileName)
        {
            string ext = fileName;
            int p = ext.LastIndexOf(".");
            if (p >= 0) ext = ext.Substring(p + 1);
            string extLC = ext.ToLower();

            SordType[] allItems = Items;
            foreach (SordType st in allItems)
            {
                if (st.extensions == null) continue;
                foreach (string s in st.extensions)
                {
                    if (s.ToLower().Equals(extLC.ToLower()))
                    {
                        return st;
                    }
                }
            }

            return this[SordC.LBT_DOCUMENT];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// Cache for keywording forms (DocMask)
    /// </summary>
    public class DocMaskCache : ItemCache<DocMask>
    {
        /// <summary>
        /// Array of mask names
        /// </summary>
        private ItemObj<MaskName[]> maskNamesItem;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ix">IndexServer connection object</param>
        /// <param name="lifetimeSeconds">Object lifetime</param>
        public DocMaskCache(IXConnIXServicePortIF_2 ix, int lifetimeSeconds)
            : base(ix, lifetimeSeconds)
        {
        }

        /// <summary>
        /// Internal function used to set the mask names. 
        /// Aquires synchronized access to the internal buffer.
        /// </summary>
        /// <param name="v">Array of mask names</param>
        internal void SetMaskNames(MaskName[] v)
        {
            ItemObj<MaskName[]> myMaskNamesItem = new ItemObj<MaskName[]>(v, lifetimeTicks);

            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                maskNamesItem = myMaskNamesItem;
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        /// <summary>
        /// Gets the mask names. If the names are not read jet or timed out, 
        /// a request to the IndexServer updates the internal cache.
        /// </summary>
        public ReadOnlyCollection<MaskName> MaskNames
        {
            get
            {
                MaskName[] ret = GetMaskNames();
                if (ret == null)
                {
                    ProtectedLoadAllObjects();
                    ret = GetMaskNames();
                }
                return new ReadOnlyCollection<MaskName>(ret);
            }
        }

        /// <summary>
        /// Returns the mask names from the internal buffer. 
        /// Does not make an IndexServer request. 
        /// Aquires synchronized access to the internal buffer.
        /// </summary>
        /// <returns>Array of color names</returns>
        internal MaskName[] GetMaskNames()
        {
            MaskName[] ret = null;

            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                if (maskNamesItem != null && !maskNamesItem.Expired)
                {
                    ret = maskNamesItem.Value;
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }

            return ret;
        }

        /// <summary>
        /// Adds a mask object into the cache.
        /// Aquires synchronized access to the cache.
        /// </summary>
        /// <param name="obj">DocMask object</param>
        protected override void ProtectedAddUnsync(DocMask obj)
        {
            String key1 = Convert.ToString(obj.id, CultureInfo.InvariantCulture);
            ItemObj<DocMask> item = makeItemObj(obj);
            ProtectedPutUnsync(key1, item);
            ProtectedPutUnsync(obj.name, item);
            if (obj.guid != null && obj.guid.Length != 0)
            {
                ProtectedPutUnsync(obj.guid, item);
            }
        }

        /// <summary>
        /// Removes a mask object from the cache.
        /// </summary>
        /// <param name="obj">Object to be removed</param>
        public void Remove(DocMask obj)
        {
            List<String> keysToRemove = new List<String>();
            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                foreach (String key in map.Keys)
                {
                    ItemObj<DocMask> item = map[key];
                    if (item != null && !item.Expired)
                    {
                        DocMask cachedMask = item.Value;
                        if (cachedMask.id == obj.id)
                        {
                            keysToRemove.Add(key);
                        }
                    }
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }

            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                if (keysToRemove.Count != 0)
                {
                    foreach (String key in keysToRemove)
                    {
                        ProtectedRemoveUnsync(key);
                    }
                }
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        /// <summary>
        /// Remove the mask object specified by the given key.
        /// </summary>
        /// <param name="key">Mask ID, GUID, or name</param>
        /// <returns></returns>
        internal override DocMask Remove(String key)
        {
            DocMask dm = null;
            if (TryGetValue(key, out dm))
            {
                Remove(dm);
            }
            return dm;
        }

        /// <summary>
        /// Reads all masks and updates the cache.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
            ProtectedLoadAllObjects();
        }

        /// <summary>
        /// Reads all masks and updates the cache.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        {
            EditInfoZ editZ = new EditInfoZ(EditInfoC.mbMaskNames, new SordZ(0));
            EditInfo ed = ix.createSord(null, null, editZ);
            DocMask[] dms = new DocMask[ed.maskNames.Length];
            int idx = 0;
            foreach (MaskName mn in ed.maskNames)
            {
                dms[idx++] = ix.checkoutDocMask(Convert.ToString(mn.id, CultureInfo.InvariantCulture), DocMaskC.mbAll, LockC.NO);
            }

            Invalidate();
            AddItems(dms);
            SetMaskNames(ed.maskNames);
        }

    }
}

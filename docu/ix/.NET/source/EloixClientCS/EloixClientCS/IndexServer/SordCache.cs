using System;
using System.Collections.Generic;
using System.Threading;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// Cache of Sord objects
    /// </summary>
    public class SordCache : ItemCache<Sord>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ix">IndexServer interface</param>
        /// <param name="lifetimeSeconds">Object cache lifetime</param>
        public SordCache(IXConnIXServicePortIF_2 ix, int lifetimeSeconds)
            : base(ix, lifetimeSeconds)
        {
        }

        /// <summary>
        /// Add a sord into the cache.
        /// </summary>
        /// <param name="sord">Sord object</param>
        protected override void ProtectedAddUnsync(Sord sord)
        {
            if (lifetimeTicks != 0)
            {
                ItemObj<Sord> item = makeItemObj(sord);
                ProtectedPutUnsync(sord.guid, item);
                if (sord.id > 0)
                {
                    ProtectedPutUnsync(Convert.ToString(sord.id), item);
                }
            }
        }

        /// <summary>
        /// Remove Sord object from cache
        /// </summary>
        /// <param name="sord"></param>
        internal virtual void Remove(Sord sord)
        {
            if (lifetimeTicks != 0)
            {
                List<String> keysToRemove = new List<String>();
                rwl.AcquireReaderLock(Timeout.Infinite);
                try
                {
                    foreach (String key in map.Keys)
                    {
                        ItemObj<Sord> item = map[key];
                        if (item != null && !item.Expired)
                        {
                            Sord cacheSord = item.Value;
                            if (cacheSord.id == sord.id)
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
                            map.Remove(key);
                        }
                    }
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
        }

        /// <summary>
        /// Remove sord object from cache
        /// </summary>
        /// <param name="key">Key used to map the sord</param>
        /// <returns>Sord object</returns>
        internal override Sord Remove(String key)
        {
            Sord sord = null;
            if (lifetimeTicks != 0)
            {
                if (TryGetValue(key, out sord))
                {
                    Remove(sord);
                }
            }
            return sord;
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        { 
        }
    }
}

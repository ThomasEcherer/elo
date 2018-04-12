

namespace EloixClient.IndexServer
{
    /// <summary>
    /// Cache of keywords.
    /// </summary>
    public class KeywordCache : ItemCache<Keyword>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ix">IndexServer interface</param>
        /// <param name="lifetimeSeconds">Cache lifetime</param>
        public KeywordCache(IXConnIXServicePortIF_2 ix, int lifetimeSeconds)
            : base(ix, lifetimeSeconds)
        {
        }

        /// <summary>
        /// Reads all root keywords and updates the cache.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
            ProtectedLoadAllObjectsUnsync();
        }

        /// <summary>
        /// Reads all root keywords and updates the cache.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        {
            if (lifetimeTicks != 0)
            {
                Keyword[] rootKeywords = ix.checkoutKeywords(null, KeywordC.mbView, 0, LockC.NO);
                foreach (Keyword kw in rootKeywords)
                {
                    ProtectedAddUnsync(kw);
                }
            }
        }

        /// <summary>
        /// Adds a Keyword to the cache
        /// </summary>
        /// <param name="obj">Keyword object</param>
        protected override void ProtectedAddUnsync(Keyword obj)
        {
            if (lifetimeTicks != 0)
            {
                map[obj.id] = makeItemObj(obj);
            }
        }
    }
}

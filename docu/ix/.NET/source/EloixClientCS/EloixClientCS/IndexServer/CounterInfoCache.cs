
namespace EloixClient.IndexServer
{
    public class CounterInfoCache : ItemCache<CounterInfo>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">IndexServer connection object</param>
        /// <param name="lifetimeSeconds">Object lifetime</param>
        internal CounterInfoCache(IXConnIXServicePortIF_2 conn, int lifetimeSeconds)
          : base(conn, lifetimeSeconds)
        {
        }

        /// <summary>
        /// Loads all objects from the IndexServer.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
            ProtectedLoadAllObjectsUnsync();
        }

        /// <summary>
        /// Loads all objects from the IndexServer.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        {
            CounterInfo[] counterInfos = ix.checkoutCounters(null, false, LockC.NO);
            Invalidate();
            foreach (CounterInfo c in counterInfos)
            {
                ProtectedAddUnsync(c);
            }
        }

        /// <summary>
        /// Maps the CounterInfo object to its name in the internal cache.
        /// </summary>
        protected override void ProtectedAddUnsync(CounterInfo obj)
        {
            map[obj.name] = makeItemObj(obj);
        }
    }
}

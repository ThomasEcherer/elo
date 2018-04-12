using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    public class FWCounters : FWMasterDataMap<FWCounter, CounterInfo>
    {
        public FWCounters(FWMasterDataInterface ifc)
            : base(ifc)
        {
        }

        internal override FWCounter CreateWrapper(CounterInfo coreObj)
        {
            return ClassFactory.NewFWCounter(coreObj);
        }

        /// <summary>
        /// Reads the CounterInfo object from the IndexServer
        /// </summary>
        /// <param name="key"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        internal override bool TryGetCoreObject(string key, out CounterInfo v)
        {
            return Conn.internalConnection.CounterInfoCache.TryGetValue(key, out v);
        }

        internal override CounterInfo[] CoreItems
        {
            get { return Conn.internalConnection.CounterInfoCache.Items; }
        }

        public override void Invalidate()
        {
            Conn.internalConnection.CounterInfoCache.Invalidate();
        }

        public override FWCounter GetDefaultValue(string name, int id, string guid)
        {
            //CounterInfo coreObj = new CounterInfo();
            //return CreateWrapper(coreObj);
            CounterInfo coreObj = new CounterInfo();
            coreObj.name = name;
            return CreateWrapper(coreObj);
        }

        public override void Lock()
        {
            Conn.Ix.checkoutCounters(null, false, LockC.IF_FREE);
        }

        public override void Unlock()
        {
            Conn.Ix.checkinCounters(null, LockC.NO);
        }
    }
}

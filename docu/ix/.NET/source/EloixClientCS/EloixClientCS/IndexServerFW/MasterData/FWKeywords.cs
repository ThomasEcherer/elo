using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    public class FWKeywords : FWMasterDataMap<FWKeyword, Keyword>
    {
        public FWKeywords(FWMasterDataInterface ifc)
            : base(ifc)
        {
        }

        internal override FWKeyword CreateWrapper(Keyword coreObj)
        {
            return ClassFactory.NewFWKeyword(coreObj, null);
        }

        internal override bool TryGetCoreObject(string key, out Keyword v)
        {
            return Conn.internalConnection.KeywordCache.TryGetValue(key, out v);
        }

        internal override Keyword[] CoreItems
        {
            get { return Conn.internalConnection.KeywordCache.Items; }
        }

        public override void Invalidate()
        {
            Conn.internalConnection.KeywordCache.Invalidate();
        }

        public override FWKeyword GetDefaultValue(string name, int id, string guid)
        {
            //Keyword kw = new Keyword();
            //return ClassFactory.NewFWKeyword(kw, null);
            Keyword kw = new Keyword();
            kw.id = name;
            return ClassFactory.NewFWKeyword(kw, null);
        }

        public override void Lock()
        {
            Conn.Ix.checkoutKeywords(null, null, 0, LockC.IF_FREE);
        }

        public override void Unlock()
        {
            Conn.Ix.checkinKeywords(null, LockC.YES);
        }
    }
}

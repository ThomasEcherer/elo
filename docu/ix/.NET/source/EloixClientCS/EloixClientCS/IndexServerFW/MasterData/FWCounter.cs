using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    public class FWCounter : FWMasterDataBase
    {
        protected CounterInfo coreVal;

        public FWCounter(FWMasterDataInterface ifc, CounterInfo coreVal)
            : base(ifc)
        {
            this.coreVal = coreVal;
        }

        public CounterInfo Core 
        {
            get { return coreVal; }
        }

        public virtual string Name
        {
            get { return Core.name; }
            set { Core.name = value; }
        }


        public virtual void Checkin()
        {

        }
    }
}

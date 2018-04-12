using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    /// <summary>
    /// This class keeps a cache of FWColor objects.
    /// </summary>
    public class FWColors : FWMasterDataMap<FWColor, ColorData>
    {
        public FWColors(FWMasterDataInterface ifc)
            : base(ifc)
        {
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
            Conn.internalConnection.ColorDataCache.Invalidate();
        }

        public override FWColor GetDefaultValue(string name, int id, string guid)
        {
            //ColorData colorData = new ColorData();
            //colorData.id = -1;
            //return new FWColor(ifc, colorData);
            ColorData colorData = new ColorData();
            colorData.id = id;
            colorData.name = name;
            colorData.guid = guid;
            return new FWColor(ifc, colorData);
        }

        public override void Lock()
        {
            ColorData[] colorData = Conn.Ix.checkoutColors(LockC.IF_FREE);
        }

        public override void Unlock()
        {
            Conn.Ix.checkinColors(null, LockC.YES);
        }
        
        internal override FWColor CreateWrapper(ColorData coreObj)
        {
            return ClassFactory.NewFWColor(coreObj);
        }

        internal override bool TryGetCoreObject(string key, out ColorData v)
        {
            return Conn.internalConnection.ColorDataCache.TryGetValue(key, out v);
        }

        internal override ColorData[] CoreItems
        {
            get { return Conn.internalConnection.ColorDataCache.Items; }
        }
    }
}

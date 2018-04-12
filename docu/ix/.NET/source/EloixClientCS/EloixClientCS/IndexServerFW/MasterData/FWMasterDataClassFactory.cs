using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    /// <summary>
    /// This class creates objects of classes of this package 
    /// inside virtual functions. It can be overloaded to create 
    /// objects of inherited classes.
    /// </summary>
    public class FWMasterDataClassFactory
    {
        /// <summary>
        /// Back-pointer to interface object.
        /// </summary>
        FWMasterDataInterface ifc;
        /// <summary>
        /// Constructor
        /// </summary>
        public FWMasterDataClassFactory(FWMasterDataInterface ifc)
        {
            this.ifc = ifc;
        }

        /// <summary>
        /// Create cache object for user names.
        /// </summary>
        /// <param name="lifetimeSeconds">Object lifetime in seconds.</param>
        /// <returns></returns>
        public virtual FWUserNamesCache NewFWUserNamesCache(int lifetimeSeconds)
        {
            return new FWUserNamesCache(ifc, lifetimeSeconds);
        }

        /// <summary>
        /// Factory for new FWColor objects
        /// </summary>
        /// <param name="colorData">ELO IXClient ColorData object</param>
        /// <returns>FWColor object</returns>
        public virtual FWColor NewFWColor(ColorData colorData)
        {
            return new FWColor(ifc, colorData);
        }

        public virtual FWColors NewFWColors()
        {
            return new FWColors(ifc);
        }

        public virtual FWKeyword NewFWKeyword(Keyword kw, FWKeyword kwParent)
        {
            return new FWKeyword(ifc, kw, kwParent);
        }

        public virtual FWKeywords NewFWKeywords()
        {
            return new FWKeywords(ifc);
        }

        public virtual FWDocMasks NewFWDocMasks()
        {
            return new FWDocMasks(ifc);
        }

        public virtual FWDocMask NewFWDocMask(DocMask core)
        {
            return new FWDocMask(ifc.Conn, core);
        }

        public virtual FWCounter NewFWCounter(CounterInfo core)
        {
            return new FWCounter(ifc, core);
        }

        public virtual FWCounters NewFWCounters(CounterInfo core)
        {
            return new FWCounters(ifc);
        }
    }
}

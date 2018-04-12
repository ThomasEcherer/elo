using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    /// <summary>
    /// This class summarizes master data related functions and objects.
    /// </summary>
    public class FWMasterDataInterface
    {
        /// <summary>
        /// The class factory creates all objects of the classes in this package.
        /// </summary>
        protected FWMasterDataClassFactory classFactoryVal;
        /// <summary>
        /// IndexServer connection
        /// </summary>
        protected FWConnection connVal;

        /// <summary>
        /// Cache of UserName objects
        /// </summary>
        protected FWUserNamesCache userNamesCacheVal;

        /// <summary>
        /// Cache of DocMask objects.
        /// </summary>
        protected FWDocMasks docMaskCacheVal;

        /// <summary>
        /// Cache of Color objects
        /// </summary>
        protected FWColors colorCacheVal;

        protected FWKeywords keywordCacheValue;

        protected FWCounters counterInfoCacheValue;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">Connection to IndexServer</param>
        /// <param name="connProps">Connection properties</param>
        public FWMasterDataInterface(FWConnection conn, IXProperties connProps)
        {
            this.classFactoryVal = new FWMasterDataClassFactory(this);
            this.connVal = conn;
        }

        /// <summary>
        /// Gets current class factory.
        /// </summary>
        public FWMasterDataClassFactory ClassFactory
        {
            get { return classFactoryVal; }
            set { classFactoryVal = value; }
        }

        /// <summary>
        /// Gets the IndexServer connection.
        /// </summary>
        public FWConnection Conn
        {
            get { return connVal; }
        }
        /// <summary>
        /// Get the user and group names.
        /// </summary>
        public virtual FWUserNamesCache UserNames
        {
            get
            {
                FWUserNamesCache ret = userNamesCacheVal;
                if (ret == null)
                {
                    int cacheLifetimeSecondsLong = Conn.internalConnection.ConnProperties.Get(IXConnFactory.PROP_CACHE_MASTERDATA_LIFETIME_SECONDS, 10 * 60);
                    ret = ClassFactory.NewFWUserNamesCache(cacheLifetimeSecondsLong);
                    userNamesCacheVal = ret;
                }
                return ret;
            }
        }
        /// <summary>
        /// Get the mask names.
        /// </summary>
        public virtual FWDocMasks DocMasks
        {
            get
            {
                FWDocMasks ret = docMaskCacheVal;
                if (ret == null)
                {
                    ret = ClassFactory.NewFWDocMasks();
                    docMaskCacheVal = ret;
                }
                return ret;
            }
        }

        /// <summary>
        /// Get the color list.
        /// </summary>
        public virtual FWColors Colors
        {
            get
            {
                FWColors ret = colorCacheVal;
                if (ret == null)
                {
                    int cacheLifetimeSecondsLong = Conn.internalConnection.ConnProperties.Get(IXConnFactory.PROP_CACHE_MASTERDATA_LIFETIME_SECONDS, 10 * 60);
                    ret = ClassFactory.NewFWColors();
                    colorCacheVal = ret;
                }
                return ret;
            }
        }

        public virtual FWKeywords Keywords
        {
            get
            {
                FWKeywords ret = keywordCacheValue;
                if (ret == null)
                {
                    ret = ClassFactory.NewFWKeywords();
                    keywordCacheValue = ret;
                }
                return ret;
            }
        }

        public virtual FWCounters Counters
        {
            get
            {
                FWCounters counterCache = counterInfoCacheValue;
                if (counterCache == null)
                {
                    counterInfoCacheValue = counterCache = new FWCounters(this);
                }
                return counterCache;
            }
        }

        /// <summary>
        /// Cache of SordType objects.
        /// </summary>
        public virtual SordTypeCache SordTypes
        {
            get { return Conn.internalConnection.SordTypeCache; }
        }


    }
}

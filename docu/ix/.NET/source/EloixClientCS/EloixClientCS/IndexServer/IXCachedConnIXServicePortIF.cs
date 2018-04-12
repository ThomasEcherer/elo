using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// This class overrides some functions of the IndexServer API 
    /// to inject caches for master data and content items.
    /// </summary>
    internal class IXCachedConnIXServicePortIF : IXConnIXServicePortIF_2_BYPS, ICleanupEvent
    {
        /// <summary>
        /// Cache for keywording forms (DocMask objects)
        /// </summary>
        internal DocMaskCache docMaskCache;
        /// <summary>
        /// Cache for root keywords.
        /// </summary>
        internal KeywordCache keywordCache;
        /// <summary>
        /// Cache for colors (markers).
        /// </summary>
        internal ColorDataCache colorCache;
        /// <summary>
        /// Cache for counters.
        /// </summary>
        internal CounterInfoCache counterCache;
        /// <summary>
        /// Cache for folder types.
        /// </summary>
        internal SordTypeCache sordTypeCache;
        /// <summary>
        /// Cache for user names.
        /// </summary>
        internal UserNameCache userNameCache;
        /// <summary>
        /// Cache of Sord objects
        /// </summary>
        internal SordCache sordCache;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="transport">BYPS Transport</param>
        /// <param name="connProps">Connection properties</param>
        public IXCachedConnIXServicePortIF(BTransport transport, IXProperties connProps)
            : base(transport)
        {
            int cacheLifetimeSecondsLong = connProps.Get(IXConnFactory.PROP_CACHE_MASTERDATA_LIFETIME_SECONDS, 10 * 60);
            int cacheLifetimeSecondsShort = connProps.Get(IXConnFactory.PROP_CACHE_CONTENT_LIFETIME_SECONDS, 0);

            sordCache = new SordCache(this, cacheLifetimeSecondsShort);
            docMaskCache = new DocMaskCache(this, cacheLifetimeSecondsLong);
            colorCache = new ColorDataCache(this, cacheLifetimeSecondsLong);
            keywordCache = new KeywordCache(this, cacheLifetimeSecondsLong);
            sordTypeCache = new SordTypeCache(this, cacheLifetimeSecondsLong);
            colorCache = new ColorDataCache(this, cacheLifetimeSecondsLong);
            counterCache = new CounterInfoCache(this, cacheLifetimeSecondsLong);
            userNameCache = new UserNameCache(this, cacheLifetimeSecondsLong);
        }

        /// <summary>
        /// Cleans up expired internally cached data.
        /// </summary>
        public void OnCleanup()
        {
            if (sordCache != null)
            {
                sordCache.OnCleanup();
            }

            // this caches are always updated by readAll() which replaces all items
            //docMaskCache.Cleanup();
            //colorCache.Cleanup();
            //sordTypeCache.Cleanup();
            //colorCache.Cleanup();
            //keywordCache.OnCleanup();

        }


        public override DocMask checkoutDocMask(string maskId, DocMaskZ docMaskZ, LockZ lockZ)
        {
            return base.checkoutDocMask(maskId, docMaskZ, lockZ);
        }

        public override int checkinDocMask(DocMask docMask, DocMaskZ docMaskZ, LockZ unlockZ)
        {
            int ret = base.checkinDocMask(docMask, docMaskZ, unlockZ);
            docMaskCache.Remove(docMask);
            return ret;
        }

        public override bool deleteDocMask(string maskId, string assignMaskId, LockZ unlockZ)
        {
            bool ret = base.deleteDocMask(maskId, assignMaskId, unlockZ);
            docMaskCache.Remove(maskId);
            return ret;
        }

        public override void checkinKeywords(Keyword[] kws, LockZ unlockZ)
        {
            base.checkinKeywords(kws, unlockZ);
            keywordCache.Invalidate();
        }

        public override void deleteKeywords(string[] kwids, LockZ unlockZ)
        {
            base.deleteKeywords(kwids, unlockZ);
            keywordCache.Invalidate();
        }

        public override Keyword[] checkoutKeywords(string[] kwids, KeywordZ keywordZ, int max, LockZ lockZ)
        {
            Keyword[] ret = base.checkoutKeywords(kwids, keywordZ, max, lockZ);
            keywordCache.Invalidate();
            return ret;
        }

        public override void checkinSordTypes(SordType[] sordTypes, LockZ unlockZ)
        {
            base.checkinSordTypes(sordTypes, unlockZ);
            sordTypeCache.Invalidate();
        }

        public override void deleteSordTypes(int[] sordTypeIds, LockZ unlockZ)
        {
            base.deleteSordTypes(sordTypeIds, unlockZ);
            sordTypeCache.Invalidate();
        }

        public override void checkinColors(ColorData[] colors, LockZ unlockZ)
        {
            base.checkinColors(colors, unlockZ);
            colorCache.Invalidate();
        }

        public override void checkinCounters(CounterInfo[] counterInfos, LockZ unlockZ)
        {
            base.checkinCounters(counterInfos, unlockZ);
            counterCache.Invalidate();
        }

        public override void deleteCounters(string[] counterNames, LockZ unlockZ)
        {
            base.deleteCounters(counterNames, unlockZ);
            counterCache.Invalidate();
        }

        public override int[] checkinUsers(UserInfo[] userInfos, CheckinUsersZ checkinUsersZ, LockZ unlockZ)
        {
            int[] ret = base.checkinUsers(userInfos, checkinUsersZ, unlockZ);
            userNameCache.Invalidate();
            return ret;
        }

        public override void deleteUsers(string[] ids, LockZ unlockZ)
        {
            base.deleteUsers(ids, unlockZ);
            userNameCache.Invalidate();
        }
    }
}

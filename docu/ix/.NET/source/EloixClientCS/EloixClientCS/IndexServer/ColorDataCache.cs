using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// Color (Marker) cache
    /// </summary>
    public class ColorDataCache : ItemCache<ColorData>
    {
        /// <summary>
        /// Array of color names
        /// </summary>
        private ItemObj<IdName[]> colorNamesItem;
        /// <summary>
        /// Element selector for reading colors
        /// </summary>
        private EditInfoZ EDITZ_FOR_NAMES = new EditInfoZ(EditInfoC.mbMarkerNames, new SordZ(0));

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">IndexServer connection object</param>
        /// <param name="lifetimeSeconds">Object lifetime</param>
        internal ColorDataCache(IXConnIXServicePortIF_2 conn, int lifetimeSeconds)
            : base(conn, lifetimeSeconds)
        {
        }

        /// <summary>
        /// Internal function used to set the color names. 
        /// Aquires synchronized access to the internal buffer.
        /// </summary>
        /// <param name="v">Array of color names</param>
        internal void SetMarkerNames(IdName[] v)
        {
            ItemObj<IdName[]> myColorNamesItem = new ItemObj<IdName[]>(v, lifetimeTicks);

            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                colorNamesItem = myColorNamesItem;
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        /// <summary>
        /// Gets the color (marker) names. If the names are not read jet or timed out, 
        /// a request to the IndexServer updates the internal cache.
        /// </summary>
        public ReadOnlyCollection<IdName> MarkerNames
        {
            get
            {
                IdName[] ret = GetMarkerNames();
                if (ret == null)
                {
                    ret = ix.createSord(null, null, EDITZ_FOR_NAMES).markerNames;
                    SetMarkerNames(ret);
                }
                return new ReadOnlyCollection<IdName>(ret);
            }
        }

        /// <summary>
        /// Returns the color names from the internal buffer. 
        /// Does not make an IndexServer request. 
        /// Aquires synchronized access to the internal buffer.
        /// </summary>
        /// <returns>Array of color names</returns>
        internal IdName[] GetMarkerNames()
        {
            IdName[] ret = null;

            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                if (colorNamesItem != null && !colorNamesItem.Expired)
                {
                    ret = colorNamesItem.Value;
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }

            return ret;
        }

        /// <summary>
        /// Reads all colors and updates the cache.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
            ProtectedLoadAllObjectsUnsync();
        }

        /// <summary>
        /// Reads all colors and updates the cache.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        {
            ColorData[] colorDatas = ix.checkoutColors(LockC.NO);
            IdName[] myMarkerNames = new IdName[colorDatas.Length];
            int idx = 0;
            foreach (ColorData c in colorDatas)
            {
                IdName idn = new IdName();
                idn.id = c.id;
                idn.guid = c.guid;
                idn.name = c.name;
                myMarkerNames[idx++] = idn;
            }

            Invalidate();
            foreach (ColorData c in colorDatas)
            {
                ProtectedAddUnsync(c);
            }
            SetMarkerNames(myMarkerNames);
        }


        /// <summary>
        /// Puts the given color object into the cache. 
        /// The caller is responsible for synchronization.
        /// </summary>
        /// <param name="obj"></param>
        protected override void ProtectedAddUnsync(ColorData obj)
        {
            colorNamesItem = null;
            ItemObj<ColorData> itemObj = makeItemObj(obj);
            ProtectedPutUnsync(Convert.ToString(obj.id, CultureInfo.InvariantCulture), itemObj);
            ProtectedPutUnsync(obj.name, itemObj);
            if (obj.guid != null && obj.guid.Length != 0)
            {
                ProtectedPutUnsync(obj.guid, itemObj);
            }
        }

    }
}
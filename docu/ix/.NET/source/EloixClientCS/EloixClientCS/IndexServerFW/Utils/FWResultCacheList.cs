using System;
using System.Collections;
using System.Collections.Generic;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Utils
{
    /// <summary>
    /// This class wraps a List object into a IResultCache.
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public class FWResultCacheList<T> : IResultCache<T>
    {
        /// <summary>
        /// List
        /// </summary>
        protected List<T> listVal;

        /// <summary>
        /// Constructor
        /// </summary>
        public FWResultCacheList()
        {
            this.listVal = new List<T>();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="list">This list is beeing wrapped.</param>
        public FWResultCacheList(List<T> list)
        {
            this.listVal = list;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="collection">The contents of this collection are copied into the internal list</param>
        public FWResultCacheList(IEnumerable<T> collection)
        {
            listVal = new List<T>();
            foreach (T t in collection) listVal.Add(t);
        }

        /// <summary>
        /// Add all items of the given collection to the internal list.
        /// </summary>
        /// <param name="collection">Items to be added.</param>
        /// <returns>this</returns>
        public FWResultCacheList<T> Add(IEnumerable<T> collection)
        {
            foreach (T t in collection) listVal.Add(t);
            return this;
        }

        /// <summary>
        /// Get/Set the internal list.
        /// </summary>
        public List<T> List
        {
            get { return listVal; }
            set { listVal = value; }
        }

        Object IResultCache.this[int idx]
        {
            get { return (idx < listVal.Count) ? ((Object)listVal[idx]) : ((Object)null); }
        }
        void IResultCache.Sort(IComparer comp)
        {
            listVal.Sort(new CastComparer<T>(comp));
        }
        int IResultCache.Count
        {
            get { return listVal.Count; }
        }
        int IResultCache.CountEstimated
        {
            get { return listVal.Count; }
            set { }
        }
        bool IResultCache.BreakTimeout
        {
            get { return false; }
        }
        bool IResultCache.BreakTotalCount
        {
            get { return false; }
        }
        void IResultCache.Clear()
        {
            listVal.Clear();
        }
        T IResultCache<T>.this[int idx]
        {
            get { return (idx < listVal.Count) ? listVal[idx] : default(T); }
        }
        void IResultCache<T>.Sort(IComparer<T> comp)
        {
            listVal.Sort(comp);
        }
        void IDisposable.Dispose()
        {
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listVal.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return listVal.GetEnumerator();
        }

        event EventHandler IResultCache.BeginRead
        {
            add { }
            remove { }
        }

        event EventHandler IResultCache.EndRead
        {
            add { }
            remove { }
        }


    }
}

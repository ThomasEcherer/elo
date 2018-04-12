using System.Collections.Generic;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.MasterData
{
    public interface IFWMasterDataMap<T> : IEnumerable<T>
    {

        /// <summary>
        /// Gets the <see cref="T"/> with the specified name or id.
        /// </summary>
        /// <remarks>
        /// If the specified name or id is not contained, the <see cref="T"/>
        /// provided by <c>GetDefaultValue(string name, int id, string guid)</c>
        /// will be returned.
        /// </remarks>
        T this[string nameOrId] { get; }
        /// <summary>
        /// Gets the <see cref="T"/> with the specified key.
        /// </summary>
        /// <remarks>
        /// If the specified key is not contained, the <see cref="T"/>
        /// provided by <c>GetDefaultValue(string name, int id, string guid)</c>
        /// will be returned.
        /// </remarks>
        T this[int key] { get; }
        /// <summary>
        /// Tries to get the value with the specified name or id and stores it in <c>value</c>.
        /// </summary>
        /// <param name="nameOrId">The name or id.</param>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if succeeded, <c>false</c> otherwise.</returns>
        bool TryGetValue(string nameOrId, out T value);
        /// <summary>
        /// Tries to get the value with the specified key and stores it in <c>value</c>.
        /// </summary>
        /// <param name="nameOrId">The name or id.</param>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if succeeded, <c>false</c> otherwise.</returns>
        bool TryGetValue(int key, out T value);
        /// <summary>
        /// Invalidates this instance.
        /// </summary>
        void Invalidate();
        /// <summary>
        /// Gets the default value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="id">The id.</param>
        /// <param name="guid">The GUID.</param>
        /// <returns>The default value.</returns>
        T GetDefaultValue(string name, int id, string guid);
        /// <summary>
        /// Locks this instance.
        /// </summary>
        void Lock();
        /// <summary>
        /// Unlocks this instance.
        /// </summary>
        void Unlock();
        IResultCache<T> ResultCache { get; }
    }

    public abstract class FWMasterDataMap<T, TCore> : FWMasterDataBase, IFWMasterDataMap<T>
    {
        internal abstract T CreateWrapper(TCore coreObj);
        internal abstract bool TryGetCoreObject(string key, out TCore v); 
        internal abstract TCore[] CoreItems { get; }

        public abstract void Invalidate();
        public abstract T GetDefaultValue(string name, int id, string guid);
        public abstract void Lock();
        public abstract void Unlock();

        internal FWMasterDataMap(FWMasterDataInterface ifc)
            : base(ifc)
        {
        }

        public virtual T this[string nameOrId]
        {
            get
            {
                T val = default(T);
                if (TryGetValue(nameOrId, out val)) 
                    return val;

                int id = 0;
                string name = nameOrId;
                string guid = string.Empty;

                try
                {
                    id = System.Convert.ToInt32(nameOrId);
                }
                catch { }

                if (StringUtils.IsGuid(nameOrId))
                    guid = nameOrId;

                return GetDefaultValue(name, id, guid);
            }
        }

        public virtual T this[int key]
        {
            get
            {
                return this[key.ToString()];
            }
        }

        public virtual T GetValueOrDefault(int key, T defaultValue)
        {
            return GetValueOrDefault(key.ToString(), defaultValue);
        }

        public virtual T GetValueOrDefault(string nameOrId, T defaultValue)
        {
            T val = default(T);
            if (TryGetValue(nameOrId, out val))
                return val;
            else
                return defaultValue;
        }

        public virtual bool TryGetValue(string nameOrId, out T val)
        {
            val = default(T);
            TCore coreValue = default(TCore);
            if (!TryGetCoreObject(nameOrId, out coreValue)) return false;
            val = CreateWrapper(coreValue);
            return true;
        }

        public virtual bool TryGetValue(int key, out T val)
        {
            return TryGetValue(key.ToString(), out val);
        }

        public virtual IResultCache<T> ResultCache
        {
            get
            {
                List<T> list = new List<T>();
                foreach (T obj in this)
                {
                    list.Add(obj);
                }
                return new FWResultCacheList<T>(list);
            }
        }

        #region IEnumerable<T> Member

        internal class MyEnumerator : IEnumerator<T>
        {
            FWMasterDataMap<T, TCore> cache;
            //IEnumerator<TCore> coreEnumerator;
            TCore[] coreItems;
            int coreItemsIndex;

            internal MyEnumerator(FWMasterDataMap<T, TCore> cache)
            {
                this.cache = cache;
                //this.coreEnumerator = cache.GetCoreEnumerator();
                this.coreItems = cache.CoreItems;
                Reset();
            }

            public T Current { get { return cache.CreateWrapper(coreItems[coreItemsIndex]); } }
            object System.Collections.IEnumerator.Current { get { return cache.CreateWrapper(coreItems[coreItemsIndex]); } }
            public void Dispose() { }
            public bool MoveNext() { return (++coreItemsIndex) < coreItems.Length; }
            public void Reset() { coreItemsIndex = -1; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        #endregion
    }
}

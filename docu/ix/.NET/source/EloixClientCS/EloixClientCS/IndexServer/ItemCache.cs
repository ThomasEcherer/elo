using System;
using System.Collections.Generic;
using System.Threading;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// This interface summarizes the functions of the ItemCache class.
    /// </summary>
    /// <typeparam name="T">Objects of this type are cached.</typeparam>
    public interface IItemCache<T>
    {
        /// <summary>
        /// Lifetime of objects in the cache before they expire.
        /// </summary>
        int LifetimeSeconds { get; set; }

        /// <summary>
        /// Returns the object stored under this key. 
        /// </summary>
        /// <remarks>
        /// If the object cannot be found, a request 
        /// to the server might occur to read it.
        /// </remarks>
        /// <param name="key">Key</param>
        /// <returns>Reference to an object or null, if the object is not available.</returns>
        T this[String key] { get; }

        /// <summary>
        /// Returns the object stored under this key.
        /// </summary>
        /// <remarks>
        /// If the object cannot be found, a request 
        /// to the server might occur to read it.
        /// </remarks>
        /// <param name="key">Key</param>
        /// <returns>Reference to an object or null, if the object is not available.</returns>
        T this[int key] { get; }

        /// <summary>
        /// Returns an array of all objects in the cache. 
        /// </summary>
        /// <remarks>
        /// If the cache is empty or some of the objects are expired, 
        /// a request to the server might occur to read all required objects.
        /// </remarks>
        T[] Items { get; }

        /// <summary>
        /// Returns the object stored under this key.
        /// </summary>
        /// <remarks>
        /// If the object cannot be found, this function tries to load it from the IndexServer.
        /// </remarks>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <returns>Reference to an object or null, if the object is not in the cache.</returns>
        bool TryGetValue(String key, out T value);

        /// <summary>
        /// Returns the object stored under this key.
        /// </summary>
        /// <remarks>
        /// If the object cannot be found, this function tries to load it from the IndexServer.
        /// </remarks>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <returns>Reference to an object or null, if the object is not in the cache or is expired.</returns>
        bool TryGetValue(int key, out T value);

        /// <summary>
        /// Invalidates all items in the cache.
        /// </summary>
        void Invalidate();
    }


    /// <summary>
    /// This class implements a cache for various types of objects.
    /// </summary>
    /// <typeparam name="T">Object type to be cached.</typeparam>
    public abstract class ItemCache<T> : IItemCache<T>
    {
        /// <summary>
        /// Initializes a new cache.
        /// </summary>
        /// <param name="ix">IndexServer interface.</param>
        /// <param name="lifetimeSeconds">Lifetime of objects in the cache, measured in seconds.</param>
        public ItemCache(IXConnIXServicePortIF_2 ix, int lifetimeSeconds)
        {
            this.ix = ix;
            map = new Dictionary<String, ItemObj<T>>();
            LifetimeSeconds = lifetimeSeconds;
        }

        #region IItemCache implemenation

        /// <summary>
        /// Lifetime of objects in the cache measured in seconds.
        /// </summary>
        public virtual int LifetimeSeconds
        {
            get
            {
                return (int)(lifetimeTicks / (10L * 1000L * 1000L));
            }
            set
            {
                lifetimeTicks = ((long)value) * 10L * 1000L * 1000L;
            }
        }

        /// <summary>
        /// Get the object at the given key. If the object is not available, readAll is called.
        /// </summary>
        /// <param name="key">Key to identify the object.</param>
        /// <returns>Object or null, if the object does not exist.</returns>
        public virtual T this[String key]
        {
            get
            {
                T v = default(T);
                if (!TryGetValue(key, out v))
                {
                    throw new KeyNotFoundException(key);
                }
                return v;
            }
            internal set
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    ItemObj<T> item = makeItemObj(value);
                    ProtectedPutUnsync(key, item);

                    //itemArray = null;
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
        }

        /// <summary>
        /// Get the object at the given key. If the object is not available, readAll is called.
        /// </summary>
        /// <param name="key">Key to identify the object.</param>
        /// <returns>Object or null, if the object does not exist.</returns>
        public virtual T this[int key]
        {
            get
            {
                return this[Convert.ToString(key)];
            }
            internal set
            {
                this[Convert.ToString(key)] = value;
            }
        }

        /// <summary>
        /// Try to read the value associated to the given key.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="t">Value</param>
        /// <returns>True, if the key was found.</returns>
        public virtual bool TryGetValue(int key, out T t)
        {
            return TryGetValue(Convert.ToString(key), out t);
        }

        /// <summary>
        /// Try to read the value associated to the given key.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="t">Value</param>
        /// <returns>True, if the key was found.</returns>
        /// <remarks>If the object is not found in the cache, function ProtectedLoadObject
        /// is called to read the object from the IndexServer.</remarks>
        public virtual bool TryGetValue(String key, out T t)
        {
            t = default(T);

            t = ProtectedGet(key);

            if (t == null)
            {
                ProtectedLoadObject(key);
                t = ProtectedGet(key);
            }
            
            return t != null;
        }

        /// <summary>
        /// Tries to lookup the object by the given key.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="t">Object</param>
        /// <returns>True, if the object was found and is not expired.</returns>
        /// <remarks>This function does not make a server request</remarks>
        internal virtual bool TryGetValueFromCache(int key, out T t)
        {
            return TryGetValueFromCache(key.ToString(), out t);
        }

        /// <summary>
        /// Tries to lookup the object by the given key.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="t">Object</param>
        /// <returns>True, if the object was found and is not expired.</returns>
        /// <remarks>This function does not make a server request</remarks>
        internal virtual bool TryGetValueFromCache(string key, out T t)
        {
            t = ProtectedGet(key);
            return t != null;
        }

        /// <summary>
        /// Returns true, if the object associated to the given key is found in the cache. 
        /// </summary>
        /// <param name="key">Object key.</param>
        /// <returns>True, if the key is included and the associated object is not expired.</returns>
        /// <remarks>This function does not make a server request.</remarks>
        public virtual bool ContainsKey(string key)
        {
            bool ret = false;
            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                ItemObj<T> item = null;
                ret = map.TryGetValue(key, out item);
                if (ret)
                {
                    ret = !item.Expired;
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }
            return ret;
        }

        /// <summary>
        /// Return the cached objects as an array.
        /// </summary>
        /// <remarks>If the cache is empty, the function ReadAll is called to 
        /// read the data from the IndexServer</remarks>
        public virtual T[] Items
        {
            get
            {
                T[] ret = ProtectedGetItems();
                if (ret.Length == 0)
                {
                    ProtectedLoadAllObjects();
                    ret = ProtectedGetItems();
                }
                return ret;
            }
            internal set
            {
                Invalidate();
                AddItems(value);
            }
        }

        /// <summary>
        /// Clears all items in the cache.
        /// </summary>
        public virtual void Invalidate()
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                map.Clear();
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        #endregion 

        #region Add functions

        /// <summary>
        /// Add the given items to the cache or replace all items in the cache with the given ones.
        /// This function calls ProtectedAddUnsyn() for each element in ts.
        /// </summary>
        /// <param name="ts">Array of objects</param>
        /// <remarks>This function handles synchronization.</remarks>
        internal virtual void AddItems(T[] ts)
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                foreach (T obj in ts)
                {
                    ProtectedAddUnsync(obj);
                }
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        /// <summary>
        /// Add an object to the cache.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <remarks>This function handles synchronisation. It calls ProtectedAddUnsyn for the given object.</remarks>
        internal virtual void Add(T obj)
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                ProtectedAddUnsync(obj);
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        /// <summary>
        /// Add an object to the cache.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <remarks>The caller is responsible for synchronisation.</remarks>
        protected abstract void ProtectedAddUnsync(T obj);

        #endregion

        #region Remove functions
        /// <summary>
        /// Remove the cached object at the given key.
        /// </summary>
        /// <param name="key">Key to identify the object.</param>
        /// <returns>Removed object.</returns>
        /// <remarks>This function handles synchronization.</remarks>
        internal virtual T Remove(int key)
        {
            return Remove(Convert.ToString(key));
        }
        /// <summary>
        /// Remove the cached object at the given key.
        /// </summary>
        /// <param name="key">Key to identify the object.</param>
        /// <returns>Removed object.</returns>
        /// <remarks>This function handles synchronization.</remarks>
        internal virtual T Remove(String key)
        {
            T ret = ProtectedGet(key);

            if (ret != null)
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    ProtectedRemoveUnsync(key);
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }

            return ret;
        }

        /// <summary>
        /// Internal function used to remove an object from the cache. The caller
        /// is responsible for synchronization.
        /// </summary>
        /// <param name="key">Key</param>
        protected virtual void ProtectedRemoveUnsync(String key)
        {
            map.Remove(key);
        }
        #endregion

        #region Get and Put functions
        /// <summary>
        /// Return the cached objects as an array.
        /// </summary>
        /// <returns>Item array</returns>
        /// <remarks>The caller is responsible for synchronisation. 
        /// The function does not make IndexServer calls.</remarks>
        protected virtual T[] ProtectedGetItemsUnsync()
        {
            Dictionary<T, T> set = new Dictionary<T, T>(map.Count);

            foreach (ItemObj<T> itemObj in map.Values)
            {
                if (itemObj.Expired)
                {
                    set.Clear();
                    break;
                }
                set[itemObj.Value] = itemObj.Value;
            }

            T[] ret = new T[set.Count];
            int i = 0;
            foreach (T v in set.Values) ret[i++] = v;

            return ret;
        }

        /// <summary>
        /// Get all items from the cache
        /// </summary>
        /// <returns>Item array</returns>
        /// <remarks>This function handles synchronisation. It does not make IndexServer calls.</remarks>
        protected virtual T[] ProtectedGetItems()
        {
            T[] ret = null;
            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                ret = ProtectedGetItemsUnsync();
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }
            return ret;
        }


        /// <summary>
        /// Gets the object associated to the given key from the cache.
        /// </summary>
        /// <param name="key">Object key.</param>
        /// <returns>Object or null, if the object cannot be found or is expired.</returns>
        protected virtual T ProtectedGet(string key)
        {
            T ret = default(T);
            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                ItemObj<T> item = ProtectedGetUnsync(key);
                if (item != null)
                {
                    if (!item.Expired)
                    {
                        ret = item.Value;
                    }
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }
            return ret;
        }

        /// <summary>
        /// Internal function used to retrieve an object without aquiring 
        /// synchronized access to the map. The caller is responsible 
        /// for synchronization.
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Object or null, if the object cannot be found or is expired.</returns>
        protected virtual ItemObj<T> ProtectedGetUnsync(String key)
        {
            ItemObj<T> item = null;
            if (map.TryGetValue(key, out item))
            {
                if (item.Expired)
                {
                    item = null;
                }
            }
            return item;
        }

        /// <summary>
        /// Internal function used to add or replace objects. The caller is
        /// responsible for synchronization.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="item">Item</param>
        protected virtual void ProtectedPutUnsync(String key, ItemObj<T> item)
        {
            map[key] = item;
        }

        #endregion

        #region Load functions
        /// <summary>
        /// Loads the object with the given key into the cache.
        /// </summary>
        /// <param name="key">Key of object to be loaded</param>
        /// <remarks>The caller has to aquire a writer lock before calling this method.</remarks>
        protected abstract void ProtectedLoadObjectUnsync(string key);
        /// <summary>
        /// Loads all objects into the cache.
        /// </summary>
        /// <remarks>The caller has to aquire a writer lock before calling this method.</remarks>
        protected abstract void ProtectedLoadAllObjectsUnsync();

        /// <summary>
        /// Loads the object with the given key into the cache by calling 
        /// </summary>
        /// <param name="key">Key of object to be loaded</param>
        /// <remarks>This function handles synchronisation.</remarks>
        protected virtual void ProtectedLoadObject(string key)
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                ProtectedLoadObjectUnsync(key);
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }

        /// <summary>
        /// Loads the object with the given key into the cache by calling 
        /// </summary>
        /// <remarks>This function handles synchronisation.</remarks>
        protected virtual void ProtectedLoadAllObjects()
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                ProtectedLoadAllObjectsUnsync();
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }
        #endregion

        #region ICleanup implementation

        /// <summary>
        /// Removes expired objects from the cache.
        /// </summary>
        public void OnCleanup()
        {
            List<String> keysOfExpiredObjs = new List<String>();
            rwl.AcquireReaderLock(Timeout.Infinite);
            try
            {
                foreach (String key in map.Keys)
                {
                    ItemObj<T> item = map[key];
                    if (item.Expired)
                    {
                        keysOfExpiredObjs.Add(key);
                    }
                }
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }

            if (keysOfExpiredObjs.Count != 0)
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    foreach (String key in keysOfExpiredObjs)
                    {
                        map.Remove(key);
                    }
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
        }
        #endregion

        #region ItemObj helper class
        /// <summary>
        /// The cached objects are wrapped with this class, 
        /// it adds a best before date the object.
        /// </summary>
        /// <typeparam name="T1">Object type to be cached.</typeparam>
        protected class ItemObj<T1>
        {
            /// <summary>
            /// Cached object.
            /// </summary>
            internal T1 valueVal;
            /// <summary>
            /// Cached object is valid until this system ticks.
            /// </summary>
            internal long bestBefore;

            /// <summary>
            /// Expired is true, if the object is no more valid.
            /// </summary>
            internal bool Expired
            {
                get { return (bestBefore < DateTime.Now.Ticks); }
            }

            /// <summary>
            /// The cached object.
            /// </summary>
            internal T1 Value
            {
                get { return valueVal; }
            }

            /// <summary>
            /// Initialiszation with lifetime.
            /// </summary>
            /// <param name="value">Cached object.</param>
            /// <param name="lifetimeTicks">Lifetime in system ticks.</param>
            internal ItemObj(T1 value, long lifetimeTicks)
            {
                this.valueVal = value;
                this.bestBefore = DateTime.Now.Ticks + lifetimeTicks;
            }
        }

        /// <summary>
        /// Helper function to initialize an ItemObj object.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns></returns>
        protected virtual ItemObj<T> makeItemObj(T obj)
        {
            ItemObj<T> item = new ItemObj<T>(obj, lifetimeTicks);
            return item;
        }

        #endregion

        #region Data members
        /// <summary>
        /// Objects are valid for this time, measured in ticks.
        /// </summary>
        protected long lifetimeTicks;

        /// <summary>
        /// This map holds the cached objects.
        /// </summary>
        protected System.Collections.Generic.Dictionary<String, ItemObj<T>> map;

        /// <summary>
        /// This lock object synchronizes the access to the map.
        /// </summary>
        protected ReaderWriterLock rwl = new ReaderWriterLock();

        /// <summary>
        /// IndexServer interface with implicit reconnection.
        /// </summary>
        protected IXConnIXServicePortIF_2 ix;

        #endregion

    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Session
{
    /// <summary>
    /// User profile options
    /// </summary>
    public class FWUserProfile : FWSessionBase
    {
        private const string DEFAULT_DOCMASK_DOC = "Client.1163.2.0.Options.DocType.";
        private const string DEFAULT_DOCMASK_FOLDER = "Client.1162.2.0.Options.SORTYPE.";

        /// <summary>
        /// Map of profile options
        /// </summary>
        protected ProfileMap userProfileMap;
        /// <summary>
        /// User ID or UserProfileC.USERID_ALL
        /// </summary>
        protected String userId;
        /// <summary>
        /// Prefix of application specific options. 
        /// Defaults to the application name given in the FWConnFactory
        /// </summary>
        protected String applicationKeyValue;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ifc">Session interface object</param>
        /// <param name="userId">Read options for this user ID, should be empty (current user) or UserProfileC.USERID_ALL</param>
        /// <remarks>Initializes the ApplicationKey property with 
        /// the client application name given in the constructor 
        /// of the connection factory.</remarks>
        public FWUserProfile(FWSessionInterface ifc, String userId)
            : base(ifc)
        {
            String appName = ifc.Conn.internalConnection.SessionOptions[SessionOptionsC.CLIENT_APP_NAME];
            this.applicationKeyValue = appName + ".";

            this.userId = userId;
            if (this.userId == null || this.userId.Length == 0)
            {
                this.userId = Convert.ToString(ifc.Conn.internalConnection.UserId);
            }

        }

        public virtual String ApplicationKey
        {
            get
            {
                return applicationKeyValue;
            }
            set
            {
                applicationKeyValue = value;
            }
        }

        public virtual IDictionary<String, String> All
        {
            get
            {
                ProfileMap map = EnsureProfileMap();
                return map;
            }
        }

        public virtual IDictionary<String, String> Application
        {
            get
            {
                ProfileMap map = EnsureProfileMap();
                return new ProfileMap(ApplicationKey, map);
            }
        }

        protected virtual ProfileMap EnsureProfileMap()
        {
            ProfileMap map = userProfileMap;
            if (map == null)
            {
                map = readUserProfile();
                userProfileMap = map;
            }
            return map;
        }

        private ProfileMap readUserProfile()
        {
            UserProfile up = new UserProfile();
            up.userId = this.userId;
            up = ifc.Conn.Ix.checkoutUserProfile(up, LockC.NO);
            Dictionary<string, string> map = new Dictionary<string, string>();
            foreach (KeyValue kv in up.options)
            {
                map.Add(kv.key, kv.value);
            }
            return new ProfileMap(map);
        }

        /// <summary>
        /// Gets the default keywording form for new documents.
        /// </summary>
        /// <remarks>The returned value might be an ID or GUID</remarks>
        /// <seealso cref="DefaultDocumentMaskIdAsInteger"/>
        public virtual String DefaultDocumentMaskId
        {
            get
            {
                IDictionary<String, String> map = All;
                String myValue = null;
                map.TryGetValue(DEFAULT_DOCMASK_DOC, out myValue);
                if (myValue == null || myValue.Length == 0)
                {
                    myValue = Conn.CONST.DOC_MASK.GUID_BASIC;
                }
                return myValue;
            }
        }
        /// <summary>
        /// Gets the numeric ID of the default keywording form for new documents.
        /// </summary>
        public virtual int DefaultDocumentMaskIdAsInteger
        {
            get 
            {
                int maskId = Conn.MasterData.DocMasks[DefaultDocumentMaskId].Id;
                return maskId;
            }
        }

        /// <summary>
        /// Gets the default keywording form for new folders.
        /// </summary>
        /// <remarks>The returned value might be an ID or GUID</remarks>
        /// <seealso cref="DefaultFolderMaskIdAsInteger"/>
        public virtual String DefaultFolderMaskId
        {
            get
            {
                IDictionary<String, String> map = All;
                String myValue = null;
                map.TryGetValue(DEFAULT_DOCMASK_FOLDER, out myValue);
                if (myValue == null || myValue.Length == 0)
                {
                    myValue = Conn.CONST.DOC_MASK.GUID_FOLDER;
                }
                return myValue;
            }
        }
        /// <summary>
        /// Gets the numeric ID of the default keywording form for new documents.
        /// </summary>
        public virtual int DefaultFolderMaskIdAsInteger
        {
            get
            {
                int maskId = Conn.MasterData.DocMasks[DefaultFolderMaskId].Id;
                return maskId;
            }
        }

        /// <summary>
        /// Store changes.
        /// </summary>
        public virtual void Checkin()
        {
            if (userProfileMap == null) return;
            userProfileMap.rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                KeyValue[] modifiedKeys = userProfileMap.GetModifiedKeys(true);
                KeyValue[] deletedKeys = userProfileMap.GetModifiedKeys(false);

                UserProfile up = new UserProfile();
                up.userId = this.userId;

                if (modifiedKeys.Length != 0)
                {
                    up.options = modifiedKeys;
                    Conn.Ix.checkinUserProfile(up, LockC.NO);
                }

                if (deletedKeys.Length != 0)
                {
                    up.options = deletedKeys;
                    Conn.Ix.deleteUserProfile(up, LockC.NO);
                }

                userProfileMap.ClearModifiedKeys();
            }
            finally
            {
                userProfileMap.rwl.ReleaseWriterLock();
            }
        }


        protected class ProfileMap : IDictionary<String, String>
        {
            String keyPrefix;
            internal ReaderWriterLock rwl;

            Dictionary<String, String> map;
            List<String> mapKeys;
            List<String> mapValues;

            /// <summary>
            /// Keys of modified options. If value is false, the key was deleted.
            /// </summary>
            protected IDictionary<String, bool> modifiedKeys;

            internal ProfileMap(Dictionary<String, String> map)
            {
                this.map = map;
                this.modifiedKeys = new Dictionary<String, bool>();
                this.rwl = new ReaderWriterLock();
            }

            internal ProfileMap(String keyPrefix, ProfileMap map)
            {
                this.keyPrefix = keyPrefix;
                this.map = map.map;
                this.modifiedKeys = map.modifiedKeys;
                this.rwl = map.rwl;
            }

            internal void ClearModifiedKeys()
            {
                this.modifiedKeys.Clear();
            }

            internal KeyValue[] GetModifiedKeys(bool modifiedNotDeleted)
            {
                List<KeyValue> list = new List<KeyValue>();
                foreach (KeyValuePair<String, bool> keyValue in this.modifiedKeys)
                {
                    if (keyValue.Value == modifiedNotDeleted)
                    {
                        KeyValue kv = new KeyValue();
                        kv.key = keyValue.Key;
                        if (modifiedNotDeleted)
                        {
                            kv.value = map[keyValue.Key];
                        }
                        list.Add(kv);
                    }
                }
                return list.ToArray();
            }

            internal bool AddModifiedKey(String key, String newValue)
            {
                bool ret = false;
                if (newValue != null)
                {
                    String oldValue = null;
                    if (map.TryGetValue(key, out oldValue))
                    {
                        if (!oldValue.Equals(newValue))
                        {
                            this.modifiedKeys.Add(key, true);
                            ret = true;
                        }
                    }
                    else
                    {
                        this.modifiedKeys.Add(key, true);
                        ret = true;
                    }
                }
                else
                {
                    if (map.ContainsKey(key))
                    {
                        this.modifiedKeys.Add(key, false);
                        ret = true;
                    }
                }

                if (ret)
                {
                    mapKeys = null;
                    mapValues = null;
                }

                return ret;
            }

            private ICollection<KeyValuePair<String, String>> AsCollection()
            {
                return (ICollection<KeyValuePair<String, String>>)map;
            }

            int ICollection<KeyValuePair<String, String>>.Count
            {
                get
                {
                    rwl.AcquireWriterLock(Timeout.Infinite);
                    try
                    {
                        return map.Count;
                    }
                    finally
                    {
                        rwl.ReleaseWriterLock();
                    }
                }
            }
            bool ICollection<KeyValuePair<String, String>>.IsReadOnly
            {
                get
                {
                    rwl.AcquireWriterLock(Timeout.Infinite);
                    try
                    {
                        return AsCollection().IsReadOnly;
                    }
                    finally
                    {
                        rwl.ReleaseWriterLock();
                    }
                }
            }
            void ICollection<KeyValuePair<String, String>>.Add(KeyValuePair<String, String> item)
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    if (AddModifiedKey(item.Key, item.Value))
                    {
                        AsCollection().Add(item);
                    }
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            void ICollection<KeyValuePair<String, String>>.Clear()
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    foreach (KeyValuePair<String, String> keyValue in map)
                    {
                        AddModifiedKey(keyValue.Key, null);
                    }
                    map.Clear();
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            bool ICollection<KeyValuePair<String, String>>.Contains(KeyValuePair<String, String> item)
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    return AsCollection().Contains(item);
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            void ICollection<KeyValuePair<String, String>>.CopyTo(KeyValuePair<String, String>[] array, int arrayIndex)
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    AsCollection().CopyTo(array, arrayIndex);
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            bool ICollection<KeyValuePair<String, String>>.Remove(KeyValuePair<String, String> item)
            {
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    AddModifiedKey(item.Key, null);
                    return AsCollection().Remove(item);
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return map.GetEnumerator();
            }

            IEnumerator<KeyValuePair<String, String>> IEnumerable<KeyValuePair<String, String>>.GetEnumerator()
            {
                return map.GetEnumerator();
            }

            public ICollection<String> Keys
            {
                get
                {
                    List<String> list = mapKeys;
                    if (list == null)
                    {
                        rwl.AcquireWriterLock(Timeout.Infinite);
                        try
                        {
                            if (keyPrefix != null && keyPrefix.Length != 0)
                            {
                                ICollection<String> internalKeys = map.Keys;
                                list = new List<String>(internalKeys.Count);
                                foreach (String s in internalKeys)
                                {
                                    if (s.StartsWith(keyPrefix))
                                    {
                                        list.Add(s.Substring(0, keyPrefix.Length));
                                    }
                                }
                            }
                            else
                            {
                                list = new List<String>(map.Keys);
                            }

                            mapKeys = list;
                        }
                        finally
                        {
                            rwl.ReleaseWriterLock();
                        }
                    }
                    return list;
                }
            }
            public ICollection<String> Values
            {
                get
                {
                    List<String> list = mapValues;
                    if (list == null)
                    {
                        rwl.AcquireWriterLock(Timeout.Infinite);
                        try
                        {
                            if (keyPrefix != null && keyPrefix.Length != 0)
                            {
                                ICollection<String> internalKeys = map.Keys;
                                list = new List<String>(internalKeys.Count);
                                foreach (String s in internalKeys)
                                {
                                    if (s.StartsWith(keyPrefix))
                                    {
                                        list.Add(map[s]);
                                    }
                                }
                            }
                            else
                            {
                                list = new List<String>(map.Values);
                            }

                            mapValues = list;
                        }
                        finally
                        {
                            rwl.ReleaseWriterLock();
                        }
                    }
                    return list;
                }
            }
            public String this[String key]
            {
                get
                {
                    String k = MakeKey(key);
                    rwl.AcquireWriterLock(Timeout.Infinite);
                    try
                    {
                        return map[k];
                    }
                    finally
                    {
                        rwl.ReleaseWriterLock();
                    }
                }
                set
                {
                    String k = MakeKey(key);
                    rwl.AcquireWriterLock(Timeout.Infinite);
                    try
                    {
                        if (AddModifiedKey(k, value))
                        {
                            map[k] = value;
                        }
                    }
                    finally
                    {
                        rwl.ReleaseWriterLock();
                    }
                }
            }
            public void Add(String key, String value)
            {
                String k = MakeKey(key);
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    if (AddModifiedKey(k, value))
                    {
                        map.Add(k, value);
                    }
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            public bool ContainsKey(String key)
            {
                String k = MakeKey(key);
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    return map.ContainsKey(k);
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            public bool Remove(String key)
            {
                String k = MakeKey(key);
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    bool ret = false;
                    if (AddModifiedKey(k, null))
                    {
                        ret = map.Remove(k);
                    }
                    return ret;
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            public bool TryGetValue(String key, out String value)
            {
                String k = MakeKey(key);
                rwl.AcquireWriterLock(Timeout.Infinite);
                try
                {
                    return map.TryGetValue(k, out value);
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
            private String MakeKey(String key)
            {
                String k = (keyPrefix != null && keyPrefix.Length != 0) ? (keyPrefix + key) : key;
                return k;
            }

        }
    }
}

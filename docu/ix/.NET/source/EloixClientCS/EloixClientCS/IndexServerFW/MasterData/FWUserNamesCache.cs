using System;
using System.Collections.Generic;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.MasterData
{
    /// <summary>
    /// This class caches UserName objects.
    /// </summary>
    public class FWUserNamesCache : FWMasterDataBase
    {
        /// <summary>
        /// Map of UserName objects, key is user ID or name 
        /// </summary>
        Dictionary<object, UserName> map;

        /// <summary>
        /// The cache elements are valid until this time (ticks).
        /// </summary>
        protected long bestBefore;

        /// <summary>
        /// Lifetime of objects in seconds.
        /// </summary>
        protected int lifetimeSeconds;

        /// <summary>
        /// Object collection
        /// </summary>
        FWResultCacheList<UserName> resultCache;

        /// <summary>
        /// Construcor
        /// </summary>
        /// <param name="ifc">Master data interface object</param>
        /// <param name="lifetimeSeconds">Object lifetime in seconds</param>
        public FWUserNamesCache(FWMasterDataInterface ifc, int lifetimeSeconds)
            : base(ifc)
        {
            this.ifc = ifc;
            this.lifetimeSeconds = lifetimeSeconds;
        }

        /// <summary>
        /// Construcor
        /// </summary>
        /// <param name="ifc">Master data interface object</param>
        /// <param name="subList">List of either only users or groups.</param>
        protected FWUserNamesCache(FWMasterDataInterface ifc, FWResultCacheList<UserName> subList)
            : base(ifc)
        {
            this.ifc = ifc;
            this.resultCache = subList;

            // never update this cache
            this.lifetimeSeconds = int.MaxValue;
            this.bestBefore = long.MaxValue;
        }

        /// <summary>
        /// Reads the user names form the IndexServer if nessesary.
        /// </summary>
        protected void ensureCache()
        {
            if (resultCache == null || DateTime.Now.Ticks > bestBefore)
            {
                resultCache = new FWResultCacheList<UserName>();
                map = new Dictionary<object, UserName>(resultCache.List.Count);
                UserName[] userNames = ifc.Conn.Ix.getUserNames(null, CheckoutUsersC.ALL_USERS_AND_GROUPS);
                foreach (UserName un in userNames)
                {
                    try
                    {
                        resultCache.List.Add(un);
                        map.Add(un.id, un);
                        map.Add(un.name, un);
                        //mapByName.Add(un.guid, un);
                    }
                    catch { }
                }
                bestBefore = DateTime.Now.Ticks + (10L * 1000L * 1000L * (long)lifetimeSeconds);
            }
        }
        /// <summary>
        /// Find user or group names starting with the given string.
        /// </summary>
        /// <param name="searchExpr">Name</param>
        /// <param name="inclGroups">Include groups</param>
        /// <param name="inclUsers">Include users</param>
        /// <param name="excludeIds">Do not return users with this IDs; can be null</param>
        /// <returns></returns>
        public IResultCache<UserName> Find(String searchExpr, bool inclUsers, bool inclGroups, IDictionary<int, int> excludeIds)
        {
            return InternalFind(searchExpr, inclGroups, inclGroups, excludeIds);
        }

        /// <summary>
        /// Find user or group names starting with the given string.
        /// </summary>
        /// <param name="searchExpr">Name</param>
        /// <param name="inclGroups">Include groups</param>
        /// <param name="inclUsers">Include users</param>
        /// <param name="excludeIds">Do not return users with this IDs; can be null</param>
        /// <returns></returns>
        protected FWResultCacheList<UserName> InternalFind(String searchExpr, bool inclUsers, bool inclGroups, IDictionary<int, int> excludeIds)
        {
            ensureCache();

            bool isStartWithExpression = false;
            if (searchExpr != null && searchExpr.Length != 0 && !searchExpr.Equals("*"))
            {
                searchExpr = searchExpr.ToLower();
                isStartWithExpression = (searchExpr.EndsWith("*"));
                if (isStartWithExpression) searchExpr = searchExpr.Substring(0, searchExpr.Length - 1);
            }
            else
            {
                searchExpr = "";
            }

            List<UserName> ret = new List<UserName>();
            foreach (UserName un in resultCache.List)
            {
                if (!inclUsers && un.type == UserInfoC.TYPE_USER) continue;
                if (!inclGroups && un.type == UserInfoC.TYPE_GROUP) continue;
                if (excludeIds != null && excludeIds.ContainsKey(un.id)) continue;
                if (searchExpr.Length != 0 && isStartWithExpression && !un.name.ToLower().StartsWith(searchExpr)) continue;
                if (searchExpr.Length != 0 && !isStartWithExpression && !un.name.ToLower().Equals(searchExpr)) continue;

                ret.Add(un);
            }
            return new FWResultCacheList<UserName>(ret);
        }

        /// <summary>
        /// Get UserName object by name or ID
        /// </summary>
        /// <param name="userNameOrId">User name or ID</param>
        /// <returns>UserName object</returns>
        public UserName this[string userNameOrId]
        {
            get
            {
                ensureCache();
                return map[userNameOrId];
            }
        }

        /// <summary>
        /// Try to get UserName object by name or ID
        /// </summary>
        /// <param name="userNameOrId">User name or ID</param>
        /// <param name="userName">Output parameter for UserName object</param>
        /// <returns>True, if user was found.</returns>
        public bool TryGetValue(string userNameOrId, out UserName userName)
        {
            ensureCache();
            return map.TryGetValue(userNameOrId, out userName);
        }

        /// <summary>
        /// Get UserName object by ID
        /// </summary>
        /// <param name="userId">User name or ID</param>
        /// <returns>UserName object</returns>
        public UserName this[int userId]
        {
            get
            {
                ensureCache();
                return map[userId];
            }
        }

        /// <summary>
        /// Try to get UserName object by ID
        /// </summary>
        /// <param name="userId">User name or ID</param>
        /// <param name="userName">Output parameter for UserName object</param>
        /// <returns>True, if user was found.</returns>
        public bool TryGetValue(int userId, out UserName userName)
        {
            ensureCache();
            return map.TryGetValue(userId, out userName);
        }


        /// <summary>
        /// Get all users.
        /// </summary>
        public FWUserNamesCache Users
        {
            get
            {
                return new FWUserNamesCache(ifc, InternalFind("", true, false, null));
            }
        }
        /// <summary>
        /// Get all groups.
        /// </summary>
        public FWUserNamesCache Groups
        {
            get
            {
                return new FWUserNamesCache(ifc, InternalFind("", false, true, null));
            }
        }

        /// <summary>
        /// Set all elements invalid. 
        /// </summary>
        /// <remarks>
        /// The elements are read from the server in the next 
        /// call to a member.
        /// </remarks>
        public void Invalidate()
        {
            if (lifetimeSeconds != int.MaxValue)
            {
                resultCache = null;
                map = null;
            }
        }

        /// <summary>
        /// Return the internal object cache.
        /// </summary>
        public IResultCache<UserName> ResultCache
        {
            get
            {
                ensureCache();
                return resultCache;
            }
        }


    }


    /// <summary>
    /// Compare users by name.
    /// </summary>
    public class FWCompareUserNameByName : FWCompareObject<UserName>
    {
        /// <summary>
        /// Compare function
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>see IComparable.Compare </returns>
        protected override int internalCompare(UserName o1, UserName o2)
        {
            return o1.name.CompareTo(o2.name);
        }
    }

    /// <summary>
    /// Compare users by type.
    /// </summary>
    public class FWCompareUserNameByType : FWCompareObject<UserName>
    {
        private String typeNameUser;
        private String typeNameGroup;
        /// <summary>
        /// Constructor. Types will be compared by their integer value.
        /// </summary>
        public FWCompareUserNameByType()
        {
        }
        /// <summary>
        /// Constructor. Types will be compared by the supplied type names.
        /// </summary>
        /// <param name="typeNameUser">Type name for user.</param>
        /// <param name="typeNameGroup">Type name for group.</param>
        public FWCompareUserNameByType(String typeNameUser, String typeNameGroup)
        {
            this.typeNameUser = typeNameUser;
            this.typeNameGroup = typeNameGroup;
        }
        /// <summary>
        /// Compare function
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>see IComparable.Compare </returns>
        protected override int internalCompare(UserName o1, UserName o2)
        {
            if (typeNameUser != null && typeNameGroup != null)
            {
                String s1 = o1.type == UserInfoC.TYPE_USER ? typeNameUser : typeNameGroup;
                String s2 = o2.type == UserInfoC.TYPE_USER ? typeNameUser : typeNameGroup;
                return s1.CompareTo(s2);
            }
            else
            {
                return o1.type - o2.type;
            }
        }
    }
    /// <summary>
    /// Compare users by ID.
    /// </summary>
    public class FWCompareUserNameById : FWCompareObject<UserName>
    {
        /// <summary>
        /// Compare function
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>see IComparable.Compare </returns>
        protected override int internalCompare(UserName o1, UserName o2)
        {
            return o1.id - o2.id;
        }
    }


}

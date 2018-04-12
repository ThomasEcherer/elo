
namespace EloixClient.IndexServer
{
    public class UserNameCache : ItemCache<UserName>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">IndexServer connection object</param>
        /// <param name="lifetimeSeconds">Object lifetime</param>
        internal UserNameCache(IXConnIXServicePortIF_2 conn, int lifetimeSeconds)
            : base(conn, lifetimeSeconds)
        {
        }

        /// <summary>
        /// Reads all user names and updates the cache.
        /// </summary>
        /// <param name="key">ignored</param>
        protected override void ProtectedLoadObjectUnsync(string key)
        {
            ProtectedLoadAllObjectsUnsync();
        }

        /// <summary>
        /// Reads all user names and updates the cache.
        /// </summary>
        protected override void ProtectedLoadAllObjectsUnsync()
        {
            UserName[] userNames = ix.getUserNames(null, CheckoutUsersC.ALL_USERS_AND_GROUPS);

            Invalidate();
            foreach (UserName c in userNames)
            {
                ProtectedAddUnsync(c);
            }
        }

        /// <summary>
        /// Maps the UserName object by its ID and name.
        /// </summary>
        /// <param name="obj">UserName object</param>
        protected override void ProtectedAddUnsync(UserName obj)
        {
            ItemObj<UserName> un = makeItemObj(obj);
            map[obj.id.ToString()] = un;
            map[obj.name] = un;
        }

    }
}

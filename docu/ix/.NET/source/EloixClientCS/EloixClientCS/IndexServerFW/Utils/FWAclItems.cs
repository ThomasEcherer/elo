using System.Collections.Generic;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Utils
{
    /// <summary>
    /// This class helps to modify ACL lists.
    /// </summary>
    /// <remarks>
    /// Each of the Add, Remove, Compare functions call CombineAcl which
    /// does an IndexServer request. 
    /// The operations are applied to an array of AclItems that is accessed
    /// via the abstract property Items. It has to be implemented in subclasses.
    /// </remarks>
    public abstract class FWAclItems : IEnumerable<AclItem>
    {
        /// <summary>
        /// Connection object
        /// </summary>
        private FWConnection _conn;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">Connection object</param>
        public FWAclItems(FWConnection conn)
        {
            _conn = conn;
        }

        /// <summary>
        /// Access the ACL items.
        /// </summary>
        /// <remarks>
        /// Subclasses have to implement this property.
        /// </remarks>
        public abstract AclItem[] Items { get; set; }

        /// <summary>
        /// Access the connection object supplied in the constructor.
        /// </summary>
        public FWConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        /// <summary>
        /// Computes the difference, sum and intersection of the given ACLs.
        /// </summary>
        /// <param name="lhs">First ACL</param>
        /// <param name="rhs">Second ACL</param>
        /// <param name="opts">Reserved, should be null.</param>
        /// <returns>Result object of ACL operations</returns>
        /// <remarks>
        /// This function is called from the Add, Remove and Compare functions
        /// and calls the IndexServer function combineAcl.
        /// </remarks>
        public virtual CombineAclResult CombineAcl(AclItem[] lhs, AclItem[] rhs, CombineAclOptions opts)
        {
            CombineAclResult combineResult = _conn.Ix.combineAcl(lhs, rhs, opts);
            return combineResult;
        }

        /// <summary>
        /// Adds the given ACL items to the list.
        /// </summary>
        /// <param name="ais">ACL items to be added</param>
        /// <returns>this</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public virtual FWAclItems Add(AclItem[] ais)
        {
            CombineAclResult combineResult = CombineAcl(Items, ais, null);
            Items = combineResult.sum;
            return this;
        }

        /// <summary>
        /// Remove the given ACL items from the list.
        /// </summary>
        /// <param name="ais">ACL items to be removed.</param>
        /// <returns>this</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public virtual FWAclItems Remove(AclItem[] ais)
        {
            CombineAclResult combineResult = CombineAcl(Items, ais, null);
            Items = combineResult.difference;
            return this;
        }

        /// <summary>
        /// Returns true, if the list contains all of the given ACL items.
        /// </summary>
        /// <param name="ais">ACL items</param>
        /// <returns>True, if the list contains all of the given ACL items.</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public virtual bool Contains(AclItem[] ais)
        {
            CombineAclResult combineResult = CombineAcl(Items, ais, null);
            return combineResult.inverseDifference.Length == 0;
        }

        /// <summary>
        /// Compares the list with the given array of ACL items.
        /// </summary>
        /// <param name="ais">ACL items</param>
        /// <returns>Returns 0, if the ACLs are equal.</returns>
        public virtual int Compare(AclItem[] ais)
        {
            CombineAclResult combineResult = CombineAcl(Items, ais, null);
            return combineResult.compareCode;
        }

        /// <summary>
        /// Replace the internal list with a copy of the supplied items.
        /// </summary>
        /// <param name="rhs">Items to be copied</param>
        public void Copy(AclItem[] rhs)
        {
            AclItem[] lhs = new AclItem[rhs.Length];
            for (int i = 0; i < rhs.Length; i++) lhs[i] = new AclItem(rhs[i]);
            Items = lhs;
        }

        /// <summary>
        /// Compares the internal list with the given ACL items.
        /// </summary>
        /// <param name="obj">ACL items as AclItem[] list, FWAclItems object or AclItem object.</param>
        /// <returns>true, if both have the same meaning.</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public override bool Equals(object obj)
        {
            AclItem[] lhs = null;
            if (obj is AclItem)
            {
                lhs = new AclItem[] { (AclItem)obj };
            }
            else if (obj is AclItem[])
            {
                lhs = (AclItem[])obj;
            }
            else if (obj is FWAclItems)
            {
                lhs = ((FWAclItems)obj).Items;
            }
            if (lhs != null)
            {
                return Compare(lhs) == 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Directs to Items.GetHashCode
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return Items.GetHashCode();
        }

        /// <summary>
        /// Adds an ACL item to the list.
        /// </summary>
        /// <param name="ai">ACL item</param>
        /// <returns>this</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public FWAclItems Add(AclItem ai)
        {
            return Add(new AclItem[] {ai});
        }

        /// <summary>
        /// Removes an ACL item from the list.
        /// </summary>
        /// <param name="ai">ACL item</param>
        /// <returns>this</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public FWAclItems Remove(AclItem ai)
        {
            return Remove(new AclItem[] { ai });
        }

        /// <summary>
        /// Checks wether the given ACL item is included in the list.
        /// </summary>
        /// <param name="ai">ACL item</param>
        /// <returns>True, if the ACL item is found.</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public bool Contains(AclItem ai)
        {
            return Contains(new AclItem[] { ai });
        }
        
        /// <summary>
        /// Removes duplicated entries from the list.
        /// </summary>
        /// <returns>this</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public virtual FWAclItems RemoveDuplicates()
        {
            return Add(new AclItem[0]);
        }

        /// <summary>
        /// Adds an ACL item to the list.
        /// </summary>
        /// <param name="id">User, group or key ID</param>
        /// <param name="type">ACL item type, see AclItemC.TYPE_*</param>
        /// <param name="name">User, group or key name.</param>
        /// <param name="access">User or group access rights, see AccessC.LUR_*</param>
        /// <returns>this</returns>
        /// <remarks>This function calls CombineAcl which makes a server request.</remarks>
        public FWAclItems Add(int id, int type, string name, int access)
        {
            return Add(CreateItem(id, type, name, access));
        }

        /// <summary>
        /// Adds an inherit entry to the list.
        /// </summary>
        /// <returns>this</returns>
        public FWAclItems AddInherit()
        {
            return Add(CreateItemInherit());
        }

        /// <summary>
        /// Adds an owner entry to the list.
        /// </summary>
        /// <returns>this</returns>
        public FWAclItems AddOwner()
        {
            return Add(CreateItemOwner());
        }

        /// <summary>
        /// Add an ACL item for an user or a group and assign access rights.
        /// </summary>
        /// <param name="v">UserInfo object</param>
        /// <param name="access">Access rights, AccessC.LUR*</param>
        /// <returns>This</returns>
        public FWAclItems Add(UserInfo v, int access)
        {
            return Add(CreateItem(v, access));
        }

        /// <summary>
        /// Adds an ACL item for an and-group and assign access rights.
        /// </summary>
        /// <param name="v">UserInfo objects of groups</param>
        /// <param name="access">Access rights, AccessC.LUR*</param>
        /// <returns>This</returns>
        public FWAclItems Add(UserInfo[] v, int access)
        {
            return Add(CreateItem(v, access));
        }

        /// <summary>
        /// Adds a key item to the list.
        /// </summary>
        /// <param name="v">KeyInfo object</param>
        /// <returns>this</returns>
        public FWAclItems Add(KeyInfo v)
        {
            return Add(CreateItem(v));
        }

        /// <summary>
        /// Removes the given acces rights from the user or group items
        /// in the list with the same ID.
        /// </summary>
        /// <param name="v">UserInfo object</param>
        /// <param name="access">Access rights, see AccessC.LUR_*</param>
        /// <returns>this</returns>
        public FWAclItems Remove(UserInfo v, int access)
        {
            return Remove(CreateItem(v, access));
        }

        /// <summary>
        /// Removes the given acces rights from AND-group items
        /// in the list with the same IDs.
        /// </summary>
        /// <param name="v">UserInfo objects</param>
        /// <param name="access">Access rights, see AccessC.LUR_*</param>
        /// <returns>this</returns>
        public FWAclItems Remove(UserInfo[] v, int access)
        {
            return Remove(CreateItem(v, access));
        }

        /// <summary>
        /// Removes an ACL item.
        /// </summary>
        /// <param name="id">User, group or key ID</param>
        /// <param name="type">ACL item type, see AclItemC.TYPE_*</param>
        /// <param name="access">Access rights, see AccessC.LUR_*</param>
        /// <returns>this</returns>
        public FWAclItems Remove(int id, int type, int access)
        {
            return Remove(CreateItem(id, type, "", access));
        }

        /// <summary>
        /// Checks wether the list contains an user or group entry with at 
        /// least the rights specified in parameter access.
        /// </summary>
        /// <param name="v">UserInfo object</param>
        /// <param name="access">Access rights, see AccessC.LUR_*</param>
        /// <returns>True, if the list contains the requested ACL item.</returns>
        public bool Contains(UserInfo v, int access)
        {
            return Contains(CreateItem(v, access));
        }

        /// <summary>
        /// Checks wether the list contains an AND-group entry with at 
        /// least the rights specified in parameter access.
        /// </summary>
        /// <param name="v">UserInfo objects</param>
        /// <param name="access">Access rights, see AccessC.LUR_*</param>
        /// <returns>True, if the list contains the requested ACL item.</returns>
        public bool Contains(UserInfo[] v, int access)
        {
            return Contains(CreateItem(v, access));
        }

        /// <summary>
        /// Checks wether the list contains key entry for the given key.
        /// </summary>
        /// <param name="v">UserInfo object</param>
        /// <returns>True, if the list contains the requested ACL item.</returns>
        public bool Contains(KeyInfo v)
        {
            return Contains(CreateItem(v));
        }

        /// <summary>
        /// Removes all items from the list;
        /// </summary>
        public void Clear()
        {
            Items = new AclItem[0];
        }

        /// <summary>
        /// Create an ACL item.
        /// </summary>
        /// <param name="id">User, group or key ID (0 for inherit or owner entries)</param>
        /// <param name="type">ACL item type, see AclItemC.TYPE_*</param>
        /// <param name="name">User, group or key name (optional)</param>
        /// <param name="access">Acces rights, see AccessC.LUR_* (0 for non user or group entries)</param>
        /// <returns>The initialized ACL item</returns>
        public static AclItem CreateItem(int id, int type, string name, int access)
        {
            AclItem ai = new AclItem();
            ai.id = id;
            ai.name = name;
            ai.type = type;
            ai.access = access;
            return ai;
        }

        /// <summary>
        /// Create an ACL placeholder item for the owner.
        /// </summary>
        /// <returns>AclItem object</returns>
        public static AclItem CreateItemOwner()
        {
            return CreateItem(0, AclItemC.TYPE_OWNER, "", 0);
        }

        /// <summary>
        /// Creates an ACL placeholder item to inherit the ACL from the parent.
        /// </summary>
        /// <returns>AclItem object</returns>
        public static AclItem CreateItemInherit()
        {
            return CreateItem(0, AclItemC.TYPE_INHERIT, "", 0);
        }

        /// <summary>
        /// Create an ACL item for a key.
        /// </summary>
        /// <param name="v">KeyInfo object</param>
        /// <returns>AclItem object</returns>
        public static AclItem CreateItem(KeyInfo v)
        {
            return CreateItem(v.id, AclItemC.TYPE_KEY, v.name, 0);
        }

        /// <summary>
        /// Create an ACL item for an user or group.
        /// </summary>
        /// <param name="v">UserInfo object</param>
        /// <param name="access">Access rights, AccessC.LUR_*</param>
        /// <returns>AclItem object</returns>
        public static AclItem CreateItem(UserInfo v, int access)
        {
            int type = v.type == UserInfoC.TYPE_USER ? AclItemC.TYPE_USER : AclItemC.TYPE_GROUP;
            return CreateItem(v.id, type, v.name, access);
        }

        /// <summary>
        /// Create an ACL item for an user or group.
        /// </summary>
        /// <param name="v">UserInfo object</param>
        /// <param name="access">Access rights, AccessC.LUR_*</param>
        /// <returns>AclItem object</returns>
        public static AclItem CreateItem(UserName v, int access)
        {
            int type = v.type == UserInfoC.TYPE_USER ? AclItemC.TYPE_USER : AclItemC.TYPE_GROUP;
            return CreateItem(v.id, type, v.name, access);
        }

        /// <summary>
        /// Create an ACL item for an AND group.
        /// </summary>
        /// <param name="v">UserInfo objects</param>
        /// <param name="access">Access rights, AccessC.LUR_*</param>
        /// <returns>AclItem object</returns>
        public static AclItem CreateItem(UserInfo[] v, int access)
        {
            AclItem ai = CreateItem(v[0], access);

            if (v.Length > 1)
            {
                ai.andGroups = new IdName[v.Length - 1];
                for (int i = 0; i < ai.andGroups.Length; i++)
                {
                    IdName idn = ai.andGroups[i] = new IdName();
                    idn.id = v[i + 1].id;
                    idn.name = v[i + 1].name;
                }
            }

            return ai;
        }

        /// <summary>
        /// This class implements the IEnumerator interface and helps to 
        /// provide an iteration over the ACL list.
        /// </summary>
        protected class MyEnumerator : IEnumerator<AclItem>
        {
            /// <summary>
            /// ACL items array
            /// </summary>
            protected AclItem[] items;
            /// <summary>
            /// Current index
            /// </summary>
            protected int itemIndex;
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="items"></param>
            internal MyEnumerator(AclItem[] items)
            {
                this.items = items;
                itemIndex = -1;
            }
            /// <summary>
            /// Returns the current object
            /// </summary>
            public AclItem Current
            {
                get { return items[itemIndex]; }
            }
            /// <summary>
            /// Does nothing
            /// </summary>
            public void Dispose()
            {
            }
            /// <summary>
            /// Returns the current ACL item as object.
            /// </summary>
            object System.Collections.IEnumerator.Current
            {
                get { return items[itemIndex]; }
            }
            /// <summary>
            /// Moves to the next object.
            /// </summary>
            /// <returns>false, if the end of the list is reached.</returns>
            public bool MoveNext()
            {
                return (++itemIndex < items.Length);
            }
            /// <summary>
            /// Resets the iterator to the start postition.
            /// </summary>
            public void Reset()
            {
                itemIndex = -1;
            }
        }

        #region IEnumerable<AclItem> Member

        /// <summary>
        /// Returns the typed iterator for the list.
        /// </summary>
        /// <returns>Enumerator object</returns>
        public IEnumerator<AclItem> GetEnumerator()
        {
            return new MyEnumerator(Items);
        }

        #endregion

        #region IEnumerable Member

        /// <summary>
        /// Returns an untyped iterator for the list.
        /// </summary>
        /// <returns>Enumerator object</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(Items);
        }

        #endregion
    }

    /// <summary>
    /// This subclass of FWAclItems implements the abstract property Items 
    /// by using an internal AclItem array. 
    /// </summary>
    public class FWAclItemsImpl : FWAclItems
    {
        /// <summary>
        /// AclItem array
        /// </summary>
        private AclItem[] _items = new AclItem[0];
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public FWAclItemsImpl(FWConnection conn)
            : base(conn)
        { 
        }
        /// <summary>
        /// Gets or sets the internal AclItem array.
        /// </summary>
        public override AclItem[] Items
        {
            get { return _items; }
            set { _items = value; }
        }
    }
}

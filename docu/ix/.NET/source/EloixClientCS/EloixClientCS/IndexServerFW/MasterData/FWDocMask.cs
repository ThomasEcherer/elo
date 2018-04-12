using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.MasterData
{
    public class FWDocMask
    {
        protected DocMask docMaskVal;

        protected FWConnection connVal;

        public FWDocMask(FWConnection conn, DocMask docMask)
        {
            connVal = conn;
            docMaskVal = docMask;
        }


        public DocMask Core
        {
            get { return docMaskVal; }
        }

        public int Id
        {
            get { return Core.id; }
            set { Core.id = value; }
        }

        public string Name
        {
            get { return Core.name; }
            set { Core.name = value; }
        }

        public FWConnection Conn
        {
            get { return connVal; }
            set { connVal = value; }
        }

        /// <summary>
        /// Implementation class for ACL items that operates on this.Core.aclItems.
        /// </summary>
        private class MyAclItems : FWAclItems
        {
            private FWDocMask _obj;

            internal MyAclItems(FWDocMask obj)
                : base(obj.Conn)
            {
                this._obj = obj;
            }

            public override AclItem[] Items
            {
                get { return _obj.Core.aclItems; }
                set { _obj.Core.aclItems = value; _obj.Core.acl = ""; }
            }
        }

        public FWAclItems AclItems
        {
            get { return new MyAclItems(this); }
        }

    }
}

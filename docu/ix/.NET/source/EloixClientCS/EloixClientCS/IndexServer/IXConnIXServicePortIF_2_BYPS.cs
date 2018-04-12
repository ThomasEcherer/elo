using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using byps;

namespace EloixClient.IndexServer
{
    public class IXConnIXServicePortIF_2_BYPS : BStub_IXServicePortIF, IXConnIXServicePortIF_2
    {
        public IXConnIXServicePortIF_2_BYPS(BTransport transport)
            : base(transport)
        {
        }

        public virtual Sord checkoutSord(String objId, SordZ sordZ, LockZ lockZ)
        {
            return checkoutSord(objId, new EditInfoZ(0L, sordZ), lockZ).sord;
        }

        public virtual Sord createSord(String parentId, String maskId, SordZ sordZ)
        {
            return createSord(parentId, maskId, new EditInfoZ(0L, sordZ)).sord;
        }
    }
}

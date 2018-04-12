using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EloixClient.IndexServer
{
    public interface IXConnIXServicePortIF_2 : IXServicePortIFAuth
    {

        Sord checkoutSord(String objId, SordZ sordZ, LockZ lockZ);

        Sord createSord(String parentId, String maskId, SordZ sordZ);

    }
}

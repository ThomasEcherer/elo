using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using byps;

namespace EloixClient.IndexServer
{
    public class IXWireClient : HWireClient
    {
        public IXWireClient(String url, BWireFlags flags, int timeoutSeconds)
            : base(url, flags, timeoutSeconds)
        {
        }

        public override String getServletPathForNegotiationAndAuthentication()
        {
            return "/byps";
        }

        public String getUrlForAuthentication()
        {
            String authUrl = this.url;
            int p = authUrl.LastIndexOf('/');
            if (p >= 0)
            {
                authUrl = authUrl.Substring(0, p);
            }
            authUrl += "/bypsauth/auth";
            return authUrl;
        }

    }
}

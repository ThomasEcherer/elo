using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EloixClient.IndexServer
{
    /**
     * Authentication type.
     *
     */
    public enum EAuthenticationType
    {
        /**
         * IXConnection created for reading constants.
         * @see IXConnFactory#getCONST() 
         */
        NOT_AUTHENTICATED,
        /**
         * Session created with user name and password.
         * @see IXConnFactory#create(String, String, String, String) 
         */
        NAME_PASSWORD,

        /**
         * Session created with user name and password and run-as-user.
         * @see IXConnFactory#create(String, String, String, String) 
         */
        RUN_AS,
        /**
         * Session created with user name and password and report-as-user.
         * @see IXConnFactory#createAdmin(String, String, String, String) 
         */
        REPORT_AS,
        /**
         * Session created with SSO.
         * @see IXConnFactory#createSso(String)
         */
        SSO,
        /**
         * Session create with Kerberos login.
         * @see IXConnFactory#createKrb(ClientInfo, String, String, String, String)
         */
        KERBEROS,
        /**
         * Session created from a foreign ticket.
         * @see IXConnFactory#createFromTicket(ClientInfo) 
         */
        FROM_TICKET, 

    }
}

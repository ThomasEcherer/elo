using System;

namespace EloixClient.IndexServerFW.Session
{
    /// <summary>
    /// This class creates objects of classes of this package 
    /// inside virtual functions. It can be overloaded to create 
    /// objects of inherited classes.
    /// </summary>
    public class FWSessionClassFactory
    {
        /// <summary>
        /// Back-pointer to interface object.
        /// </summary>
        FWSessionInterface ifc;
        /// <summary>
        /// Constructor
        /// </summary>
        public FWSessionClassFactory(FWSessionInterface ifc)
        {
            this.ifc = ifc;
        }
        /// <summary>
        /// Create a FWUserProfile object
        /// </summary>
        /// <param name="userId">The object contains profile options for this user. </param>
        /// <returns>FWUserProfile object</returns>
        /// <seealso cref="FWUserProfile"/>
        public virtual FWUserProfile NewUserProfile(String userId)
        {
            return new FWUserProfile(ifc, userId);
        }
        /// <summary>
        /// Creates a map to store the passwords for the document encryption.
        /// </summary>
        /// <returns></returns>
        public virtual FWEncrPasswords NewEncrPasswords()
        {
            return new FWEncrPasswords(ifc);
        }
        /// <summary>
        /// Creates a map to store the session options.
        /// </summary>
        /// <returns></returns>
        public virtual FWSessionOptions NewSessionOptions()
        {
            return new FWSessionOptions(ifc);
        }
    }
}

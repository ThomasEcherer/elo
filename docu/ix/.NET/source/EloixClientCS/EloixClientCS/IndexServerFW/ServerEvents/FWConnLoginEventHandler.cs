using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.ServerEvents
{
    /// <summary>
    /// Login helper class for the connection factory for server events.
    /// A relogin is not possible because we do not know the user password
    /// in the event handler.
    /// </summary>
    /// <seealso cref="FWConnFactoryEventHandler"/>
    public class FWConnLoginEventHandler : IXConnLogin
    {
        /// <summary>
        /// Constructor. IXConnFactory calls this constructor.
        /// </summary>
        /// <param name="ix">IndexServer interface object</param>
        /// <param name="ci">ClientInfo object.</param>
        public FWConnLoginEventHandler(IXClient ix, ClientInfo ci)
            : base(ix, ci, "", new IXProperties(), new IXProperties())
        {
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <param name="prevLoginCount">Login count before the function was called</param>
        /// <param name="loopCount">Login count that was incremented in the outer loop</param>
        /// <param name="e">Exception</param>
        /// <returns>Nothing</returns>
        /// <exception>Throws always the supplied exception.</exception>
        public override int reloginOrThrow(int prevLoginCount, int loopCount, Exception e)
        {
            if (e != null) throw e;

            lrVal = ix.getSessionFromTicket(ci, 0);

            return 0;
        }

        /// <summary>
        /// Throws an exception.
        /// </summary>
        /// <exception cref="NotImplementedException" />
        public override void login()
        {
            throw new NotImplementedException();
        }

    }
}
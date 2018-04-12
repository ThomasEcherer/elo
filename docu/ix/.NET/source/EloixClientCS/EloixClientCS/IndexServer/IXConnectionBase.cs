
namespace EloixClient.IndexServer
{
  /// <summary>
  /// Base class for IndexServer connections.
  /// </summary>
  public abstract class IXConnectionBase {

    /// <summary>
    /// Returns true, if a login was successfully and the ticket is still valid.
    /// </summary>
    public abstract bool Valid { get; }

    /// <summary>
    /// This function is called by a timer thread to cleanup internal caches.
    /// </summary>
    public abstract void OnCleanup();
  }
}


namespace EloixClient.IndexServer
{
  /// <summary>
  /// Classes that implement this interfaces are 
  /// periodically called from a background thread
  /// to cleanup expired data.
  /// </summary>
  public interface ICleanupEvent
  {
    /// <summary>
    /// 
    /// </summary>
    void OnCleanup();
  }

}

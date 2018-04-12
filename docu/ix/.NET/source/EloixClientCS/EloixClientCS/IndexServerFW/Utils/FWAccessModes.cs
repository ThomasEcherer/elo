using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Utils
{
  /// <summary>
  /// Defines enumeration constants used when resources (folders, documents, users, etc.)
  /// are accessed.
  /// </summary>
  public enum FWAccessModes
  {
    /// <summary>
    /// Do not lock
    /// </summary>
    Nothing = 0x0000,
    /// <summary>
    /// Lock object, if currently not locked. 
    /// </summary>
    Lock = 0x0001,
    /// <summary>
    /// Unlock object
    /// </summary>
    Unlock = 0x0001,
    /// <summary>
    /// Lock object, if not locked or locked by the current user.
    /// </summary>
    LockAgain = 0x0003,
    /// <summary>
    /// Lock object, ignore current lock.
    /// </summary>
    LockForce = 0x0005,
    /// <summary>
    /// Object must exist
    /// </summary>
    MustExist = 0x0100
  }

  /// <summary>
  /// Helper class used to make a LockZ object from the IndexServer API.
  /// </summary>
  public class FWLockMode
  {
    /// <summary>
    /// Returns true, if the given access mode contains any lock
    /// </summary>
    /// <param name="accessMode">Access mode</param>
    /// <returns>True, if accessMode contains one of the lock constants</returns>
    public static bool HasLock(FWAccessModes accessMode)
    {
      return (accessMode & FWAccessModes.Lock) != 0;
    }

    /// <summary>
    /// Makes a LockZ object from a FWAccessModes enum.
    /// </summary>
    /// <param name="accessMode">Access mode</param>
    /// <returns>Lock object</returns>
    public static LockZ MakeLockZ(FWAccessModes accessMode)
    {
      LockZ lockZ = LockC.NO;
      
      if ((accessMode & FWAccessModes.Lock) == FWAccessModes.Lock)
      {
        lockZ = LockC.IF_FREE;
      }
      if ((accessMode & FWAccessModes.LockAgain) == FWAccessModes.LockAgain)
      {
        lockZ = LockC.YES;
      }
      if ((accessMode & FWAccessModes.LockForce) == FWAccessModes.LockForce)
      {
        lockZ = LockC.FORCE;
      }

      return lockZ;
    }
  }
}

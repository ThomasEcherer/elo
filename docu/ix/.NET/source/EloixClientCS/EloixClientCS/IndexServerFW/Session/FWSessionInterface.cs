using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Session
{
  /// <summary>
  /// This class summarizes session related functions and objects.
  /// </summary>
  public class FWSessionInterface
  {
    /// <summary>
    /// The class factory creates all objects of the classes in this package.
    /// </summary>
    protected FWSessionClassFactory classFactoryVal;
    /// <summary>
    /// IndexServer connection
    /// </summary>
    protected FWConnection connVal;

    /// <summary>
    /// Wrapper object for session options.
    /// </summary>
    protected FWSessionOptions sessOptsVal;

    /// <summary>
    /// Encrypted passwords.
    /// </summary>
    protected FWEncrPasswords encrPasswordsVal;

    /// <summary>
    /// User profile options
    /// </summary>
    protected FWUserProfile userProfileVal;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="conn">Connection to IndexServer</param>
    /// <param name="connProps">Connection properties</param>
    public FWSessionInterface(FWConnection conn, IXProperties connProps)
    {
      this.classFactoryVal = new FWSessionClassFactory(this);
      this.connVal = conn;
      this.sessOptsVal = ClassFactory.NewSessionOptions();
      this.encrPasswordsVal = ClassFactory.NewEncrPasswords();
      this.userProfileVal = ClassFactory.NewUserProfile(null);
    }

    /// <summary>
    /// Gets current class factory.
    /// </summary>
    public FWSessionClassFactory ClassFactory
    {
      get { return classFactoryVal; }
      set { classFactoryVal = value; }
    }

    /// <summary>
    /// Gets the IndexServer connection.
    /// </summary>
    public FWConnection Conn
    {
      get { return connVal; }
    }

    /// <summary>
    /// Gets the session options
    /// </summary>
    public FWSessionOptions Options
    {
      get { return sessOptsVal; }
    }

    /// <summary>
    /// Gets the encrypted passwords.
    /// </summary>
    public FWEncrPasswords EncrPasswords
    {
      get { return encrPasswordsVal; }
    }

    /// <summary>
    /// Gets the user profile options
    /// </summary>
    public FWUserProfile UserProfile
    {
      get { return userProfileVal; }
    }

    /// <summary>
    /// Current user
    /// </summary>
    public UserInfo User
    {
      get 
      {
          if (LoginResult == null)
              return null;
          else
             return LoginResult.user; 
      }
    }

    /// <summary>
    /// Login result
    /// </summary>
    public LoginResult LoginResult
    {
      get { return Conn.internalConnection.LoginResult; }
    }
  }
}

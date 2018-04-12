using System;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Content;

namespace EloixClient.IndexServerFW
{
  /// <summary>
  /// This class represents an IndexServer connection and 
  /// provides access to all IndexServer interface functions.
  /// </summary>
  public class FWConnection : IXConnectionBase {

    internal IXConnection internalConnection;

    /// <summary>
    /// Holds the interface object of the content related functions.
    /// </summary>
    protected Content.FWContentInterface contentInterfaceVal;

    /// <summary>
    /// Holds the interface object of the session related functions.
    /// </summary>
    protected Session.FWSessionInterface sessionInterfaceVal;

    /// <summary>
    /// Holds the interface object of the workflow related functions.
    /// </summary>
    protected Workflow.FWWorkflowInterface workflowInterfaceVal;

    /// <summary>
    /// Holds the interface object of the master data related functions.
    /// </summary>
    protected MasterData.FWMasterDataInterface masterDataInterfaceVal;

    /// <summary>
    /// Archive Sord
    /// </summary>
    protected Sord arcSord;

    /// <summary>
    /// Constructor. Normally, the constructor is called from FWConnFactory.
    /// </summary>
    /// <param name="innerConn">Inner connection</param>
    public FWConnection(IXConnection innerConn) 
    {
      internalConnection = innerConn;
      contentInterfaceVal = new Content.FWContentInterface();
      sessionInterfaceVal = new Session.FWSessionInterface(this, internalConnection.ConnProperties);
      workflowInterfaceVal = new Workflow.FWWorkflowInterface(this, internalConnection.ConnProperties);
      masterDataInterfaceVal = new MasterData.FWMasterDataInterface(this, internalConnection.ConnProperties);

      arcSord = internalConnection.Ix.checkoutSord("1", EditInfoC.mbSordLean, LockC.NO).sord;
      contentInterfaceVal.Init(this, arcSord.name, internalConnection.ConnProperties);
    }

    /// <summary>
    /// Convert ISO date into DateTime object
    /// </summary>
    /// <param name="iso">ISO date in timezone UTC</param>
    /// <returns>DateTime object</returns>
    public virtual DateTime IsoToDate(String iso)
    {
      return internalConnection.IsoToDate(iso);
    }

    /// <summary>
    /// Convert DateTime to ISO date
    /// </summary>
    /// <param name="d">DateTime object</param>
    /// <returns>ISO date in timezone UTC</returns>
    public virtual String DateToIso(DateTime d)
    {
      return internalConnection.DateToIso(d);
    }
    /// <summary>
    /// IndexServer API object
    /// </summary>
    public IXConnIXServicePortIF_2 Ix
    {
      get
      {
        return internalConnection.Ix;
      }
    }
    /// <summary>
    /// IndexServer constants
    /// </summary>
    public IXServicePortC CONST
    {
      get
      {
        return internalConnection.CONST;
      }
    }

    /// <summary>
    /// Gets the interface object to the content related functions.
    /// </summary>
    public Content.FWContentInterface Content
    {
      get { return contentInterfaceVal; }
    }

    /// <summary>
    /// Gets the interface object to the session related functions.
    /// </summary>
    public Session.FWSessionInterface Session
    {
      get { return sessionInterfaceVal; }
    }

    /// <summary>
    /// Gets the interface object to the workflow related functions.
    /// </summary>
    public Workflow.FWWorkflowInterface Workflow
    {
      get { return workflowInterfaceVal; }
    }

    /// <summary>
    /// Gets the interface object to the master data related functions.
    /// </summary>
    public MasterData.FWMasterDataInterface MasterData
    {
      get { return masterDataInterfaceVal; }
    }

    /// <summary>
    /// Logout
    /// </summary>
    public virtual void Logout()
    {
      Session.UserProfile.Checkin();
      internalConnection.Logout();
      Content.DownloadManager.ForceCleanup();
    }
    
    /// <summary>
    /// This function is called every second by the timer object of the
    /// connection factory. It is used to cleanup the caches.
    /// </summary>
    public override void OnCleanup()
    {
      internalConnection.OnCleanup();
      contentInterfaceVal.OnCleanup();
    }

    /// <summary>
    /// Returns true, if a login was successfully and the ticket is still valid.
    /// </summary>
    public override bool Valid
    {
      get { return internalConnection.Valid; }
    }

    /// <summary>
    /// Return the negotiated stream version.
    /// </summary>
    public string StreamVersion
    {
      get { return internalConnection.StreamVersion; }
    }

    /// <summary>
    /// Get IndexServer version and build number.
    /// </summary>
    public String IndexServerVersion
    {
      get { return internalConnection.ImplVersion; }
    }

    /// <summary>
    /// Gets or sets object that contains additionally data for connection.
    /// </summary>
    public object Tag
    {
        get;
        set;
    }

    /// <summary>
    /// Check exception.
    /// </summary>
    /// <param name="e">Exception object</param>
    /// <param name="exceptionType">Exception type constant.</param>
    /// <returns>True, if the given exception is of the given exceptionType.</returns>
    /// <seealso cref="EloixClient.IndexServer.IXExceptionC"/>
    public bool IsException(Exception e, int exceptionType)
    {
      IXExceptionData exd = Ix.parseException(e.ToString());
      return exd.exceptionType == exceptionType;
    }

    /// <summary>
    /// Get the archive name from the database.
    /// </summary>
    public virtual string ArcName
    {
        get
        {
            return arcSord.name;
        }
    }

    /// <summary>
    /// Encrypts passed in password and returns it back.
    /// </summary>
    /// <param name="pwdToEncrypt">Password that have to be encrypted</param>
    /// <returns>
    /// Encrypted password
    /// </returns>
    public string EncryptPassword(string pwdToEncrypt)
    {
        return internalConnection.EncryptPassword(pwdToEncrypt);
    }

    /// <summary>
    /// <seealso cref="IXConnection.Truncate"/>
    /// </summary>
    /// <param name="s"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public string Truncate(string s, int max)
    {
        return internalConnection.Truncate(s, max);
    }
  }
}

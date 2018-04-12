using System;
using EloixClient.IndexServerFW.Content;

namespace EloixClientUI.Common
{
  /// <summary>
  /// Event arguments for checkin events
  /// </summary>
  public class CheckinEventArgs : EventArgs
  {
    /// <summary>
    /// Parent ID or GUID
    /// </summary>
    public String ParentId;
    /// <summary>
    /// File to checkin
    /// </summary>
    public String File;
    /// <summary>
    /// Sord object
    /// </summary>
    public FWSord Sord;
    /// <summary>
    /// Cancel checkin of this Sord
    /// </summary>
    public bool Cancel;
    /// <summary>
    /// Cancel checkin of this and all subsequent Sords
    /// </summary>
    public bool CancelAll;
    /// <summary>
    /// Index-th. document to checkin 
    /// </summary>
    public int Index;
    /// <summary>
    /// Number of documents to checkin
    /// </summary>
    public int Count;
  }
}
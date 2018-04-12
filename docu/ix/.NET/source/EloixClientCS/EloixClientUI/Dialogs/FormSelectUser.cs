using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClientUI.Controls;

namespace EloixClientUI.Dialogs
{
  /// <summary>
  /// Options for the FormSelectUser dialog.
  /// </summary>
  [Flags]
  public enum FormSelectUserFlags
  {
    /// <summary>
    /// Show user names
    /// </summary>
    ShowUsers = 1,
    /// <summary>
    /// Show group names
    /// </summary>
    ShowGroups = 2,
    /// <summary>
    /// Select multiple users 
    /// </summary>
    MultiSelect = 8,
  }
  /// <summary>
  /// This dialog can be used to select users and/or groups.
  /// </summary>
  public partial class FormSelectUser : Form
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public FormSelectUser()
    {
      InitializeComponent();
      this.Text = EloixClientUI.Properties.Resources.FormSelectUserCaption;
      this.SelectUserControl.ListViewControl.DoubleClick += new EventHandler(ListViewControl_DoubleClick);
    }
    /// <summary>
    /// Create and initialize a dialog object.
    /// </summary>
    /// <param name="conn">IndexServer connection</param>
    /// <param name="flags">Options</param>
    /// <param name="selectUserIds">List of user IDs to be selected</param>
    /// <param name="hideUserIds">List of user IDs to be hidden</param>
    /// <returns>Dialog object</returns>
    public static FormSelectUser Create(FWConnection conn,
      FormSelectUserFlags flags,
      IEnumerable<int> selectUserIds,
      IEnumerable<int> hideUserIds)
    {
      FormSelectUser frm = new FormSelectUser();
      frm.SelectUserControl.ShowUsers = (flags & FormSelectUserFlags.ShowUsers) != 0;
      frm.SelectUserControl.ShowGroups = (flags & FormSelectUserFlags.ShowGroups) != 0;
      frm.SelectUserControl.MultiSelect = (flags & FormSelectUserFlags.MultiSelect) != 0;
      frm.SelectUserControl.HiddenUserIds = hideUserIds;
      frm.SelectUserControl.Conn = conn;

      frm.SelectUserControl.SelectedUserIds = selectUserIds;

      return frm;
    }
    /// <summary>
    /// Opens a dialog for selecting users and returns the selection.
    /// </summary>
    /// <param name="conn">IndexServer connection</param>
    /// <param name="flags">Options</param>
    /// <param name="selectUserIds">List of user IDs to be selected</param>
    /// <param name="hideUserIds">reserved</param>
    /// <returns>Selected users</returns>
    public static IEnumerable<UserName> DoSelectUser(FWConnection conn,
      FormSelectUserFlags flags, 
      IEnumerable<int> selectUserIds,
      IEnumerable<int> hideUserIds)
    {
      FormSelectUser frm = Create(conn, flags, selectUserIds, hideUserIds);

      IEnumerable<UserName> ret = null;
      if (frm.ShowDialog() == DialogResult.OK)
      {
        ret = frm.SelectUserControl.SelectedUsers;
      }
      return ret;
    }

    /// <summary>
    /// Gets the UserControl SelectUser
    /// </summary>
    public SelectUser SelectUserControl
    {
      get { return selectUser1; }
    }
    /// <summary>
    /// Gets the selection after the dialog is closed.
    /// </summary>
    public IEnumerable<UserName> SelectedUsers
    {
      get { return selectUser1.SelectedUsers; }
    }

    void ListViewControl_DoubleClick(object sender, EventArgs e)
    {
      if (e is MouseEventArgs)
      {
        MouseEventArgs mouseArgs = (MouseEventArgs)e;
        if (mouseArgs.Button == MouseButtons.Left)
        {
          AcceptButton.PerformClick();
        }
      }
    }

    private void bnOK_Click(object sender, EventArgs e)
    {

    }

  }
}

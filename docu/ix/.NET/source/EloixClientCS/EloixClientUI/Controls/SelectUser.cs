using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;

namespace EloixClientUI.Controls
{

  /// <summary>
  /// This UserControl can be used to select users or groups.
  /// </summary>
  /// <remarks>This control consists of a list for user and group names,
  /// a filter input field and checkboxes to constrain the entries in 
  /// list to users or groups or both.</remarks>
  public partial class SelectUser : UserControl
  {
    /// <summary>
    /// IndexServer connection
    /// </summary>
    protected FWConnection connVal;
    /// <summary>
    /// Timer, used to prepare the list of users in a background thread.
    /// </summary>
    protected System.Threading.Timer timerVal;
    /// <summary>
    /// Object used to synchronize the timer function
    /// </summary>
    protected Object syncTimerMonitor = "dummy";
    /// <summary>
    /// This variable is used to transfer the search text to the 
    /// timer thread. 
    /// </summary>
    protected String nameFilter;
    /// <summary>
    /// The search text of the previsious 
    /// </summary>
    protected String lastNameFilter = "";
    /// <summary>
    /// Underlying cache of user names.
    /// </summary>
    protected IResultCache userNames;
    /// <summary>
    /// List of user IDs to be hidden.
    /// </summary>
    protected Dictionary<int, int> hiddenUserIdsVal = new Dictionary<int, int>();
    /// <summary>
    /// Constructor
    /// </summary>
    public SelectUser()
    {
      InitializeComponent();
      userListView1.ShowHourglass = false;
      lbSearch.Text = EloixClientUI.Properties.Resources.FormSelectUserSearch;
      ckUsers.Text = EloixClientUI.Properties.Resources.Users;
      ckUsers.Tag = true;
      ckGroups.Text = EloixClientUI.Properties.Resources.Groups;
      ckGroups.Tag = true;
    }
    /// <summary>
    /// IndexServer connection
    /// </summary>
    [Browsable(false)]
    public FWConnection Conn
    {
      get
      {
        return connVal;
      }
      set
      {
        FWConnection prevConn = connVal;
        connVal = value;
        if (prevConn != connVal)
        {
          internalRefresh();
        }
      }
    }
    /// <summary>
    /// Get/set the option for showing users.
    /// </summary>
    public bool ShowUsers
    {
      get 
      {
        bool b = (bool)ckUsers.Tag;
        return b;
      }
      set
      {
        ckUsers.Tag = value;
        ckUsers.Checked = value;
        internalRefresh();
      }
    }
    /// <summary>
    /// Get/set the option for showing groups.
    /// </summary>
    public bool ShowGroups
    {
      get 
      {
        bool b = (bool)ckGroups.Tag;
        return b;
      }
      set
      {
        ckGroups.Tag = value;
        ckGroups.Checked = value;
        internalRefresh();
      }
    }
    /// <summary>
    /// Get/set the option for allowing multiple selection.
    /// </summary>
    public bool MultiSelect
    {
      get { return userListView1.MultiSelect; }
      set 
      { 
        userListView1.MultiSelect = value; 
        internalRefresh(); 
      }
    }
    /// <summary>
    /// Get/set the list of users to hide.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<int> HiddenUserIds
    {
      get
      {
        return hiddenUserIdsVal.Keys;
      }
      set
      {
        hiddenUserIdsVal.Clear();
        if (value != null)
        {
          foreach (int id in value)
          {
            hiddenUserIdsVal[id] = id;
          }
        }
        internalRefresh();
      }
    }
    /// <summary>
    /// Get the TextBox control for the search string.
    /// </summary>
    public TextBox SearchTextBox
    {
      get { return edSearch; }
    }
    /// <summary>
    /// Get the ListView control.
    /// </summary>
    public ListView ListViewControl
    {
      get { return userListView1; }
    }
    /// <summary>
    /// Get the CheckBox for showing users.
    /// </summary>
    public CheckBox UsersCheckBox
    {
      get { return ckUsers; }
    }
    /// <summary>
    /// Get the CheckBox for showing groups.
    /// </summary>
    public CheckBox GroupsCheckBox
    {
      get { return ckGroups; }
    }

    /// <summary>
    /// Get the selected user objects.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<UserName> SelectedUsers
    {
      get { return userListView1.SelectedUsers; }
      set { userListView1.SelectedUsers = value; }
    }

    /// <summary>
    /// Get the selected user IDs.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<int> SelectedUserIds
    {
      get { return userListView1.SelectedUserIds; }
      set { userListView1.SelectedUserIds = value; }
    }

    /// <summary>
    /// Evaluates the users to be shown and updates the control contents.
    /// </summary>
    protected virtual void internalRefresh()
    {
      if (Conn != null)
      {
        userListView1.Conn = Conn;

        ckUsers.Visible = ckGroups.Visible = ShowUsers && ShowGroups;

        userListView1.ObjectsCache = Conn.MasterData.UserNames.Find("", ckUsers.Checked, ckGroups.Checked, hiddenUserIdsVal);

        if (timerVal == null)
        {
          System.Threading.TimerCallback timerCb = new System.Threading.TimerCallback(this.onThreadingTimer);
          timerVal = new System.Threading.Timer(timerCb, null, 0, 1000);
        }

        timer1.Enabled = true;

        Refresh();
      }
    }

    private void ckUsers_CheckedChanged(object sender, EventArgs e)
    {
      if (!ckUsers.Checked && ShowGroups && !ckGroups.Checked)
      {
        ckGroups.Checked = true;
      }
      else
      {
        internalRefresh();
      }
    }

    private void ckGroups_CheckedChanged(object sender, EventArgs e)
    {
      if (!ckGroups.Checked && ShowUsers && !ckUsers.Checked)
      {
        ckUsers.Checked = true;
      }
      else
      {
        internalRefresh();
      }
    }

    private void edSearch_TextChanged(object sender, EventArgs e)
    {
      nameFilter = edSearch.Text;
    }

    /// <summary>
    /// This function refreshes the dialog contents, if the 
    /// search string was changed.
    /// </summary>
    /// <param name="stateInfo">ignored</param>
    /// <remarks>This function is called by the System.Threading.Timer object
    /// and is executed in a background thread. Thus, it cannot access the
    /// user interface directly.</remarks>
    protected virtual void onThreadingTimer(object stateInfo)
    {
      // If there is already a thread executing this function,
      // skip this block.
      if (System.Threading.Monitor.TryEnter(syncTimerMonitor))
      {
        try
        {
          // put the current search string into a local variable to 
          // avoid synchronization
          String currentNameFilter = nameFilter;
          if (currentNameFilter == null) currentNameFilter = "";

          // if search string has changed
          if (!currentNameFilter.Equals(lastNameFilter))
          {
            // evaluate a new cache object and assign it to a variable
            // that will be read in the timer1_Tick function
            userNames = Conn.MasterData.UserNames.Find(currentNameFilter + "*", ckUsers.Checked, ckGroups.Checked, hiddenUserIdsVal);

            // memorize the current search string for the next call
            lastNameFilter = currentNameFilter;
            if (lastNameFilter == null) lastNameFilter = "";
          }
        }
        finally
        {
          System.Threading.Monitor.Exit(syncTimerMonitor);
        }
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      // put the current search string and the cache object provided 
      // by the onThreadingTimer into a local variable to 
      // avoid synchronization
      String currentNameFilter = nameFilter;
      IResultCache currentUserNames = userNames;

      // Reset the handover variable, so nothing will be done, 
      // if onThreadingTimer has no new cache object and this function is
      // called the next time.
      userNames = null;

      // If onThreadingTimer provides a new cache object...
      if (currentUserNames != null)
      {
        // ... compare it with the current cache object
        IResultCache oldUserNames = userListView1.ObjectsCache;
        bool eq = oldUserNames.Count == currentUserNames.Count;
        for (int i = 0; eq && i < oldUserNames.Count; i++)
        {
          UserName un1 = (UserName)oldUserNames[i];
          UserName un2 = (UserName)currentUserNames[i];
          eq = un1.id == un2.id;
        }

        // if the cache content has changed ... 
        if (!eq)
        {
          // ... update the controls
          userListView1.SelectAll(false);
          userListView1.ObjectsCache = currentUserNames;

          // select all entries, if the search string is not empty
          userListView1.SelectAll(currentNameFilter != null && currentNameFilter.Length != 0);
        }
      }

    }

    private void userListView1_DoubleClick(object sender, EventArgs e)
    {
      //FindForm().AcceptButton.PerformClick();

    }
  }
}

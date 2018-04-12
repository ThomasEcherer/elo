using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Content;
using EloixClient.IndexServerFW.Utils;
using EloixClient.IndexServerFW.Workflow;
using EloixClientUI.Common;

namespace EloixClientUI.Controls
{
  /// <summary>
  /// ListView control to display a list of user tasks. 
  /// </summary>
  /// <remarks>
  /// This ListView control works in virtual mode. That means, that 
  /// only the visible objects are requested from the underlying
  /// cache. 
  /// </remarks>
  public partial class TaskListView : VirtualListView
  {
    /// <summary>
    /// Image list of Sord type images
    /// </summary>
    protected SordTypeImageList sordTypeImageLists;
    /// <summary>
    /// Helper object used to open documents.
    /// </summary>
    protected OpenDocumentHandler openDocumentHandler;
    /// <summary>
    /// Options for allowed actions and viewing modes.
    /// </summary>
    protected UserTaskListOptions optionsVal;
    /// <summary>
    /// Options for allowed actions and viewing modes.
    /// </summary>
    [Flags]
    protected enum UserTaskListOptions
    {
      /// <summary>
      /// Allow to drag files from the tree view e. g. into the file system.
      /// </summary>
      AllowDrag = (1 << 0),
      //AllowDrop = (1 << 1),
      /// <summary>
      /// Allow to open documents on double click.
      /// </summary>
      AllowOpenDocument = (1 << 2),
    }

    /// <summary>
    /// ColumnHeader object for type of user task (workflow, reminder, activity)
    /// </summary>
    public ColumnHeader ColumnHeaderTaskType = new ColumnHeader();
    /// <summary>
    /// ColumnHeader object for task priority
    /// </summary>
    public ColumnHeader ColumnHeaderPriority = new ColumnHeader();
    /// <summary>
    /// ColumnHeader object for task name
    /// </summary>
    public ColumnHeader ColumnHeaderName = new ColumnHeader();
    /// <summary>
    /// ColumnHeader object for task date
    /// </summary>
    public ColumnHeader ColumnHeaderDate = new ColumnHeader();
    /// <summary>
    /// ColumnHeader object for task description
    /// </summary>
    public ColumnHeader ColumnHeaderMemo = new ColumnHeader();
    /// <summary>
    /// ColumnHeader object for Sord.Version.Owner
    /// </summary>
    public ColumnHeader ColumnHeaderOwner = new ColumnHeader();

    /// <summary>
    /// Constructor
    /// </summary>
    public TaskListView()
    {
      this.ColumnHeaderTaskType.Text = EloixClientUI.Properties.Resources.TaskType;
      this.ColumnHeaderPriority.Text = EloixClientUI.Properties.Resources.Priority;
      this.ColumnHeaderName.Text = EloixClientUI.Properties.Resources.Name;
      this.ColumnHeaderOwner.Text = EloixClientUI.Properties.Resources.Onwer;
      this.ColumnHeaderDate.Text = EloixClientUI.Properties.Resources.TaskDate;
      this.ColumnHeaderMemo.Text = EloixClientUI.Properties.Resources.TaskMemo;
      
      // some columns should be displayed in design mode
      base.Columns.Add(ColumnHeaderName);
      base.Columns.Add(ColumnHeaderPriority);
      base.Columns.Add(ColumnHeaderTaskType);
      base.Columns.Add(ColumnHeaderDate);
      base.Columns.Add(ColumnHeaderOwner);
      base.Columns.Add(ColumnHeaderMemo);

      openDocumentHandler = new OpenDocumentHandler();
    }

    /// <summary>
    /// Get the focused task object.
    /// </summary>
    [Browsable(false)]
    public FWUserTask FocusedTask
    {
      get { return (FWUserTask)FocusedObject; }
    }
    /// <summary>
    /// Get the selected task object.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<FWUserTask> SelectedTasks
    {
      get { return new CastEnumerable<FWUserTask>(SelectedObjects); }
    }
    /// <summary>
    /// Get or set the FWUserTask cache.
    /// </summary>
    [Browsable(false)]
    public IResultCache<FWUserTask> TasksCache
    {
      get { return (IResultCache<FWUserTask>)ObjectsCache; }
      set { ObjectsCache = value; }
    }

    /// <summary>
    /// Returns wether the given bit is set or not
    /// </summary>
    /// <param name="bit">One of the constants defined in UserTaskListOptions</param>
    /// <returns>True, if the option is on.</returns>
    protected virtual bool getOptionBit(UserTaskListOptions bit)
    {
      return (optionsVal & bit) != 0;
    }

    /// <summary>
    /// Sets the given option bit to the specified value.
    /// </summary>
    /// <param name="bit">Option bit.</param>
    /// <param name="value">Value</param>
    protected virtual void setOptionBit(UserTaskListOptions bit, bool value)
    {
      if (value)
      {
        optionsVal |= bit;
      }
      else
      {
        optionsVal &= ~bit;
      }
    }

    /// <summary>
    /// Allow to drag files from the tree view e. g. into the file system.
    /// </summary>
    public virtual bool AllowDrag
    {
      get { return getOptionBit(UserTaskListOptions.AllowDrag); }
      set { setOptionBit(UserTaskListOptions.AllowDrag, value); internalRefresh(); }
    }

    /// <summary>
    /// Allow to open documents on double click.
    /// </summary>
    public virtual bool AllowOpenDocument
    {
      get { return getOptionBit(UserTaskListOptions.AllowOpenDocument); }
      set { setOptionBit(UserTaskListOptions.AllowOpenDocument, value); internalRefresh(); }
    }

    /// <summary>
    /// Opens the FocusedSord, if it is a document.
    /// </summary>
    /// <param name="e">EventArgs object</param>
    protected override void OnDoubleClick(EventArgs e)
    {
      base.OnDoubleClick(e);

      MouseEventArgs mouseArgs = (MouseEventArgs)e;
      if (mouseArgs.Button == MouseButtons.Left)
      {
        if (AllowOpenDocument && FocusedObject != null)
        {
          FWSord sord = FocusedTask.Sord;
          if (sord.IsDocument())
          {
            openDocumentHandler.Open((FWDocument)sord);
          }
        }
      }
    }

    /// <summary>
    /// Starts a drag event for the selected Sord objects.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnItemDrag(ItemDragEventArgs e)
    {
      base.OnItemDrag(e);
      if (AllowDrag)
      {
        ListViewItem li = (ListViewItem)e.Item;
      }
    }
    
    #region Refresh and initialization

    /// <summary>
    /// Re-reads the list content.
    /// </summary>
    protected override void internalRefresh()
    {
      if (connVal != null && objectsCacheValue != null)
      {
        sordTypeImageLists = connVal.MasterData.SordTypes.ImageList;
        this.SmallImageList = sordTypeImageLists.Images;
      }
      base.internalRefresh();
    }

    #endregion

    #region Make List Columns

    /// <summary>
    /// Find the index groups used by the Sords currently contained in the cache.
    /// The function does not cause the Sord cache to read all Sords from the archive.
    /// Create an additional column for each of this groups.
    /// </summary>
    protected override void makeColumns()
    {
      List<ColumnHeader> lstHeaders = new List<ColumnHeader>();

      ColumnHeaderName.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareUserTaskByName()));
      lstHeaders.Add(ColumnHeaderName);

      ColumnHeaderTaskType.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareUserTaskByType()));
      lstHeaders.Add(ColumnHeaderTaskType);

      ColumnHeaderPriority.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareUserTaskByPriority()));
      lstHeaders.Add(ColumnHeaderPriority);

      ColumnHeaderDate.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareUserTaskByDate()));
      lstHeaders.Add(ColumnHeaderDate);

      ColumnHeaderOwner.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareUserTaskByReceiverName()));
      lstHeaders.Add(ColumnHeaderOwner);

      ColumnHeaderMemo.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareUserTaskByDesc()));
      lstHeaders.Add(ColumnHeaderMemo);

      this.Columns.Clear();
      this.Columns.AddRange(lstHeaders.ToArray());

    }

    #endregion 

    #region Make list items

    /// <summary>
    /// Creates a ListViewItem for the given Sord object.
    /// </summary>
    /// <param name="objT">FWUserTask</param>
    /// <returns>ListViewItem object</returns>
    protected override ListViewItem makeItem(Object objT)
    {
      FWUserTask ut = (FWUserTask)objT;
      ListViewItem li = new ListViewItem();
      li.Text = ut.Name;

      li.ImageIndex = ut.SordImageIndex;

      String taskType = "";
      switch (ut.Type)
      {
        case FWUserTaskType.Workflow: 
          taskType = EloixClientUI.Properties.Resources.TaskTypeWorkflow;
          break;
        case FWUserTaskType.Reminder:
          taskType = EloixClientUI.Properties.Resources.TaskTypeReminder;
          break;
        case FWUserTaskType.Activity:
          taskType = EloixClientUI.Properties.Resources.TaskTypeActivity;
          break;
      }

      String prioText = EloixClientUI.Properties.Resources.PriorityMedium;
      switch (ut.Priority)
      {
        case UserTaskPriorityC.LOWEST: 
          prioText = EloixClientUI.Properties.Resources.PriorityLow;
          break;
        case UserTaskPriorityC.HIGHEST: 
          prioText = EloixClientUI.Properties.Resources.PriorityHigh;
          break;
      }

      li.SubItems.Add(taskType);
      li.SubItems.Add(prioText);
      li.SubItems.Add(ut.Date.ToString());
      li.SubItems.Add(ut.ReceiverName);
      li.SubItems.Add(ut.Desc);

      return li;
    }

    #endregion 
  }
}

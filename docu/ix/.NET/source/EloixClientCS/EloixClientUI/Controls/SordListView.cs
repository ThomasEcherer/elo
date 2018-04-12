using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClient.IndexServerFW.Utils;
using EloixClientUI.Common;

namespace EloixClientUI.Controls
{
  /// <summary>
  /// ListView control to display a list of Sord objects. 
  /// </summary>
  /// <remarks>
  /// This ListView control works in virtual mode. That means, that 
  /// only the visible Sord objects are requested from the underlying
  /// Sord cache. 
  /// Beside the standard columns for name, date, version etc., colums
  /// for index groups are created. The Sord objects are scanned for 
  /// the used index group names. For each of this index groups, 
  /// a list view column is created.
  /// </remarks>
  public class SordListView : VirtualListView
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
    protected SordListOptions optionsVal = SordListOptions.ShowDocuments|SordListOptions.ShowFolders;
    /// <summary>
    /// Helper object to checkin documents contained in a COM DataObject.
    /// </summary>
    protected DocumentDataObject checkinDocumentHandler;
    /// <summary>
    /// Options for allowed actions and viewing modes.
    /// </summary>
    [Flags]
    protected enum SordListOptions
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
      /// <summary>
      /// Show documents in the tree view.
      /// </summary>
      ShowDocuments = (1 << 3),
      /// <summary>
      /// Show reverences (logically copies) in the tree view.
      /// </summary>
      ShowFolders = (1 << 4),
      /// <summary>
      /// Show columns for index values.
      /// </summary>
      ShowObjKeyColumns = (1 << 5),
    }

    /// <summary>
    /// ColumnHeader object for Sord.Name
    /// </summary>
    public ColumnHeaderEx ColumnHeaderName = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.XDate
    /// </summary>
    public ColumnHeaderEx ColumnHeaderXDate = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.IDate
    /// </summary>
    public ColumnHeaderEx ColumnHeaderIDate = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Keywording form name.
    /// </summary>
    public ColumnHeaderEx ColumnHeaderMaskName = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.Version.Version
    /// </summary>
    public ColumnHeaderEx ColumnHeaderVersion = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.Version.Size
    /// </summary>
    public ColumnHeaderEx ColumnHeaderFileSize = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.Version.Owner
    /// </summary>
    public ColumnHeaderEx ColumnHeaderOwner = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.Version.CreateDate
    /// </summary>
    public ColumnHeaderEx ColumnHeaderVersionDate = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.Version.Owner
    /// </summary>
    public ColumnHeaderEx ColumnHeaderVersionUser = new ColumnHeaderEx();
    /// <summary>
    /// ColumnHeader object for Sord.ArcPathString
    /// </summary>
    public ColumnHeaderEx ColumnHeaderArcPath = new ColumnHeaderEx();
   /// <summary>
   /// ColumnHeader object for Sord.LockId
   /// </summary>
    public ColumnHeaderEx ColumnHeaderLockId = new ColumnHeaderEx();
      /// <summary>
      /// ColumnHeader object for Sord.LockName
      /// </summary>
    public ColumnHeaderEx ColumnHeaderLockName = new ColumnHeaderEx();

    /// <summary>
    /// Constructor
    /// </summary>
    public SordListView()
    {
      this.ColumnHeaderName.Text = EloixClientUI.Properties.Resources.Name;
      this.ColumnHeaderXDate.Text = EloixClientUI.Properties.Resources.DocumentDate;
      this.ColumnHeaderIDate.Text = EloixClientUI.Properties.Resources.FilingDate;
      this.ColumnHeaderOwner.Text = EloixClientUI.Properties.Resources.Onwer;
      this.ColumnHeaderMaskName.Text = EloixClientUI.Properties.Resources.DocMask;
      this.ColumnHeaderVersion.Text = EloixClientUI.Properties.Resources.Version;
      this.ColumnHeaderFileSize.Text = EloixClientUI.Properties.Resources.Size;
      this.ColumnHeaderFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.ColumnHeaderVersionDate.Text = EloixClientUI.Properties.Resources.CreateDate;
      this.ColumnHeaderVersionUser.Text = EloixClientUI.Properties.Resources.CreateBy;
      this.ColumnHeaderArcPath.Text = EloixClientUI.Properties.Resources.ArcPath;
      this.ColumnHeaderLockId.Text = EloixClientUI.Properties.Resources.LockId;
      this.ColumnHeaderLockName.Text = EloixClientUI.Properties.Resources.LockName;


      this.ColumnHeaderName.Name = "Name";
      this.ColumnHeaderXDate.Name = "XDate";
      this.ColumnHeaderIDate.Name = "IDate";
      this.ColumnHeaderOwner.Name = "Owner";
      this.ColumnHeaderMaskName.Name = "MaskName";
      this.ColumnHeaderVersion.Name = "Version";
      this.ColumnHeaderFileSize.Name = "FileSize";
      this.ColumnHeaderVersionDate.Name = "VersionDate";
      this.ColumnHeaderVersionUser.Name = "VersionUser";
      this.ColumnHeaderArcPath.Name = "ArcPath";
      this.ColumnHeaderLockId.Name = "LockId";
      this.ColumnHeaderLockName.Name = "LockName";

      // some columns should be displayed in design mode
      base.Columns.Add(ColumnHeaderName);
      base.Columns.Add(ColumnHeaderXDate);
      base.Columns.Add(ColumnHeaderIDate);
      base.Columns.Add(ColumnHeaderMaskName);
      base.Columns.Add(ColumnHeaderVersion);
      base.Columns.Add(ColumnHeaderFileSize);
      base.Columns.Add(ColumnHeaderOwner);
      base.Columns.Add(ColumnHeaderVersionDate);
      base.Columns.Add(ColumnHeaderVersionUser);
      base.Columns.Add(ColumnHeaderArcPath);
      base.Columns.Add(ColumnHeaderLockName);
        
      openDocumentHandler = new OpenDocumentHandler();
    }

    /// <summary>
    /// Returns wether the given bit is set or not
    /// </summary>
    /// <param name="bit">One of the constants defined in SordListOptions</param>
    /// <returns>True, if the option is on.</returns>
    protected virtual bool getOptionBit(SordListOptions bit)
    {
      return (optionsVal & bit) != 0;
    }

    /// <summary>
    /// Sets the given option bit to the specified value.
    /// </summary>
    /// <param name="bit">Option bit.</param>
    /// <param name="value">Value</param>
    protected virtual void setOptionBit(SordListOptions bit, bool value)
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
      get { return getOptionBit(SordListOptions.AllowDrag); }
      set { setOptionBit(SordListOptions.AllowDrag, value); internalRefresh(); }
    }

    /// <summary>
    /// Allow to open documents on double click.
    /// </summary>
    public virtual bool AllowOpenDocument
    {
      get { return getOptionBit(SordListOptions.AllowOpenDocument); }
      set { setOptionBit(SordListOptions.AllowOpenDocument, value); internalRefresh(); }
    }

    /// <summary>
    /// Show documents in the list view.
    /// This property does not filter the SordsCache or ObjectsCache.
    /// </summary>
    public virtual bool ShowDocuments
    {
      get { return getOptionBit(SordListOptions.ShowDocuments); }
      set { setOptionBit(SordListOptions.ShowDocuments, value); internalRefresh(); }
    }

    /// <summary>
    /// Show folders in the list view.
    /// This property does not filter the SordsCache or ObjectsCache.
    /// </summary>
    public virtual bool ShowFolders
    {
      get { return getOptionBit(SordListOptions.ShowFolders); }
      set { setOptionBit(SordListOptions.ShowFolders, value); internalRefresh(); }
    }

    /// <summary>
    /// Allow to drag files from the tree view e. g. into the file system.
    /// </summary>
    public virtual bool ShowObjKeyColumns
    {
      get { return getOptionBit(SordListOptions.ShowObjKeyColumns); }
      set { setOptionBit(SordListOptions.ShowObjKeyColumns, value); internalRefresh(); }
    }

    /// <summary>
    /// Get the focused sord object.
    /// </summary>
    [Browsable(false)]
    public FWSord FocusedSord
    {
      get { return (FWSord)FocusedObject; }
    }
    /// <summary>
    /// Get the selected sord objects.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<FWSord> SelectedSords
    {
      get { return new CastEnumerable<FWSord>(SelectedObjects); }
    }
    /// <summary>
    /// Get or set the Sord cache.
    /// </summary>
    [Browsable(false)]
    public IResultCache<FWSord> SordsCache
    {
      get { return (IResultCache<FWSord>)ObjectsCache; }
      set { ObjectsCache = value; }
    }

    /// <summary>
    /// Opens the FocusedSord, if it is a document.
    /// </summary>
    /// <param name="e">EventArgs object</param>
    protected override void OnDoubleClick(EventArgs e)
    {
      base.OnDoubleClick(e);

      using (new EloixClientUI.Utils.Hourglass())
      {
        if (AllowOpenDocument && FocusedSord != null)
        {
          if (FocusedSord.IsDocument())
          {
            openDocumentHandler.Open((FWDocument)FocusedSord);
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
        checkinDocumentHandler.DoDragDrop(this, SelectedSords, e.Item, DragDropEffects.Copy);
      }
    }

    #region Refresh and initialization

    /// <summary>
    /// Re-reads the list content.
    /// </summary>
    protected override void internalRefresh()
    {
      base.internalRefresh();
      if (connVal != null && objectsCacheValue != null)
      {
        sordTypeImageLists = connVal.MasterData.SordTypes.ImageList;
        this.SmallImageList = sordTypeImageLists.Images;
      }
    }
    /// <summary>
    /// Creates a new DocumentDataObject.
    /// </summary>
    /// <param name="oldConn">Old connection</param>
    /// <param name="newConn">New connection</param>
    protected override void OnConnChanged(FWConnection oldConn, FWConnection newConn)
    {
      checkinDocumentHandler = new DocumentDataObject(newConn);
    }

    #endregion 

    #region Make list columns

    /// <summary>
    /// Objects of this class count the usage of index groups.
    /// </summary>
    /// <remarks>
    /// For each group name used in the ObjKey objects of the cached sords,
    /// one DocMaskLineUsage object is created. For each DocMaskLineUsage object
    /// with a valueCount greater than 0, a column is created in the ListView. 
    /// The DocMaskLineUsage objects with the highest valueCount becomes the 
    /// most left column in the ListView (after the default columns).
    /// </remarks>
    protected class DocMaskLineUsage
    {
      /// <summary>
      /// Index group name
      /// </summary>
      public String GroupName;
      /// <summary>
      /// List of index lable names.
      /// </summary>
      /// <remarks>
      /// The group name can be used by serveral DocMaskLine objects in the same 
      /// or in different DocMask objects. This list contains the DocMaskLine.name
      /// values.
      /// </remarks>
      public List<String> lableNames;
      /// <summary>
      /// Counts the usages of group name
      /// </summary>
      public int usageCount;
      /// <summary>
      /// Minimum ObjKey or DocMaskLine ID 
      /// </summary>
      public int minDmlId;
      /// <summary>
      /// Counst the number of ObjKey objects which have a non-empty value 
      /// for the group name.
      /// </summary>
      public int valueCount;
    }

    /// <summary>
    /// Comparer class for comparing DocMaskLineUsage objects by 
    /// valueCount, usageCount and minDmlId
    /// </summary>
    protected class DocMaskLineUsageComparer : IComparer<DocMaskLineUsage>
    {
      /// <summary>
      /// Implementation of IComparer
      /// </summary>
      /// <param name="o1">First object</param>
      /// <param name="o2">Second object</param>
      /// <returns></returns>
      public int Compare(DocMaskLineUsage o1, DocMaskLineUsage o2)
      {
        int c;
        c = o1.valueCount - o2.valueCount;
        if (c != 0) return -c;
        c = o1.usageCount - o2.usageCount;
        if (c != 0) return -c;
        c = o1.minDmlId - o2.minDmlId;
        return -c;
      }
    }
    /// <summary>
    /// 	<see cref="VirtualListView.makeColumns()"/>
    /// </summary>
    /// <remarks>
    /// Create an additional column for each of the index groups used by the cached Sord objects.
    /// It merly looks on the currently available Sords in the cache and does not
    /// read all Sords from the IndexServer.
    /// </remarks>
    protected override void makeColumns()
    {
      if (objectsCacheValue == null) return;

      Dictionary<String, DocMaskLineUsage> mapDmlUsage = new Dictionary<String,DocMaskLineUsage>();

      if (this.ShowObjKeyColumns)
      {
        for (int i = 0; i < objectsCacheValue.CountEstimated; i++)
        {
          FWSord sord = SordsCache[i];

          if (!ShowDocuments && (sord is FWDocument)) continue;
          if (!ShowFolders && (sord is FWFolder)) continue;

          DocMask dm = Conn.MasterData.DocMasks[sord.MaskId].Core;
          for (int dmlIdx = 0; dmlIdx < dm.lines.Length; dmlIdx++)
          {
            DocMaskLine dml = dm.lines[dmlIdx];
            String groupName = dml.key.ToLower();
            DocMaskLineUsage u = null;
            if (!mapDmlUsage.TryGetValue(groupName, out u))
            {
              u = new DocMaskLineUsage();
              u.GroupName = groupName;
              u.lableNames = new List<String>();
              u.lableNames.Add(dml.name);
              mapDmlUsage[groupName] = u;
            }
            u.usageCount++;
            u.minDmlId = Math.Min(u.minDmlId, dmlIdx);
            FWObjKeyValue okeyValue = sord.ObjKeys[dmlIdx].Value;
            if (okeyValue != null && !okeyValue.IsEmpty())
            {
              u.valueCount++;
            }
          }
        }
      }

      List<DocMaskLineUsage> lstDmlUsages = new List<DocMaskLineUsage>(mapDmlUsage.Values);
      lstDmlUsages.Sort(new DocMaskLineUsageComparer());

      List<ColumnHeaderEx> lstHeaders = new List<ColumnHeaderEx>(lstDmlUsages.Count + 11);

      ColumnHeaderName.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByName<FWSord>()));
      lstHeaders.Add(ColumnHeaderName);

      ColumnHeaderXDate.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByXDate<FWSord>()));
      lstHeaders.Add(ColumnHeaderXDate);

      ColumnHeaderIDate.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByIDate<FWSord>()));
      lstHeaders.Add(ColumnHeaderIDate);

      ColumnHeaderMaskName.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByMaskName<FWSord>(this.connVal)));
      lstHeaders.Add(ColumnHeaderMaskName);

      ColumnHeaderOwner.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByOwnerName<FWSord>()));
      lstHeaders.Add(ColumnHeaderOwner);

      ColumnHeaderVersion.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByVersion<FWSord>()));
      lstHeaders.Add(ColumnHeaderVersion);

      ColumnHeaderVersionDate.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByVersionDate<FWSord>()));
      lstHeaders.Add(ColumnHeaderVersionDate);

      ColumnHeaderVersionUser.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByVersionOwner<FWSord>()));
      lstHeaders.Add(ColumnHeaderVersionUser);

      ColumnHeaderFileSize.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByVersionFileSize<FWSord>()));
      lstHeaders.Add(ColumnHeaderFileSize);

      ColumnHeaderArcPath.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByArcPath<FWSord>()));
      lstHeaders.Add(ColumnHeaderArcPath);

      ColumnHeaderLockName.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByLockName<FWSord>()));
      lstHeaders.Add(ColumnHeaderLockName);

      if (this.ShowObjKeyColumns)
      {
        foreach (DocMaskLineUsage u in lstDmlUsages)
        {
          if (u.valueCount > 0)
          {
            ColumnHeaderEx h = new ColumnHeaderEx();
            String hname = "";
            for (int i = 0; i < u.lableNames.Count; i++)
            {
              if (i > 0) hname += "/";
              hname += u.lableNames[i];
            }
            h.Text = hname;
            h.Tag = new ColumnHeaderTag(compareObjectComparersVal.Add(new FWCompareSordByObjKey<FWSord>(u.GroupName)));
            h.Name = hname;
            lstHeaders.Add(h);
          }
        }
      }

      this.Columns.Clear();
      this.Columns.AddRange(lstHeaders.ToArray());
    }

    #endregion 

    #region Make list items

    /// <summary>
    /// Creates a ListViewItem for the given Sord object.
    /// </summary>
    /// <param name="objT">Sord object</param>
    /// <returns>ListViewItem object</returns>
    protected override ListViewItem makeItem(Object objT)
    {
      FWSord sord = (FWSord)objT;
      ListViewItem li = new ListViewItem();
      if (Conn != null && objT != null)
      {
          String fname = sord.Name;
          if (sord is FWDocument)
          {
              String ext = ((FWDocument)sord).Version.Core.ext;
              if (ext != null && ext.Length != 0)
              {
                  fname += "." + ext;
              }
          }

          li.ForeColor = sord.RGBColor;
          //li.Text = fname;
          li.Text = sord.Name;
          li.ImageIndex = sord.ImageIndex;
          if (sord.XDate.Ticks == 0)
              li.SubItems.Add("");
          else if (sord.XDate.Hour == 0 && sord.XDate.Minute == 0)
              li.SubItems.Add(sord.XDate.ToString("d"));
          else
              li.SubItems.Add(sord.XDate.ToString("g"));
          //li.SubItems.Add(sord.XDate.Ticks != 0 ? sord.XDate.ToString("g") : "");
          li.SubItems.Add(sord.IDate.ToString());

          //EloixClient.IndexServerFW.MasterData.FWDocMask docMask = Conn.MasterData.DocMasks.GetValueOrDefault(sord.MaskId, Conn.MasterData.DocMasks[0]);
          EloixClient.IndexServerFW.MasterData.FWDocMask docMask = Conn.MasterData.DocMasks[sord.MaskId];

          //li.SubItems.Add(Conn.MasterData.DocMasks[sord.MaskId].Name);
          li.SubItems.Add(docMask.Name);
          li.SubItems.Add(sord.OwnerName);

          FWDocument doc = (sord is FWDocument) ? (FWDocument)sord : null;
          if (doc != null)
          {
              li.SubItems.Add(doc.Version.Version);
              if (doc.Version.CreateDate.Ticks == 0)
                  li.SubItems.Add("");
              else if (doc.Version.CreateDate.Hour == 0 && doc.Version.CreateDate.Minute == 0)
                  li.SubItems.Add(doc.Version.CreateDate.ToString("d"));
              else
                  li.SubItems.Add(doc.Version.CreateDate.ToString("g"));
              //li.SubItems.Add(doc.Version.CreateDate.Ticks != 0 ? doc.Version.CreateDate.ToString("g") : "");
              li.SubItems.Add(doc.Version.OwnerName);
              li.SubItems.Add(doc.Version.SizeKB);
          }
          else
          {
              li.SubItems.Add("");
              li.SubItems.Add("");
              li.SubItems.Add("");
              li.SubItems.Add("");
          }

          li.SubItems.Add(sord.ArcPathString);
          li.SubItems.Add(sord.LockName);

          if (this.ShowObjKeyColumns)
          {
              for (int colIdx = 11; colIdx < this.Columns.Count; colIdx++)
              {
                  ColumnHeaderTag htag = (ColumnHeaderTag)this.Columns[colIdx].Tag;
                  FWCompareSordByObjKey<FWSord> compByObjKey = (FWCompareSordByObjKey<FWSord>)htag.compareObject;
                  FWObjKey okey = sord.ObjKeys[compByObjKey.groupName];
                  li.SubItems.Add(okey != null ? (String)okey.Value : "");
              }
          }
          li.Tag = sord;
      }
      return li;
    }
    #endregion 

    protected override void BeforeSort(List<int> selectedObjectIDs)
    {
        Dictionary<int, object>.ValueCollection values = selection.Values;
        foreach (FWSord sord in values)
        {
            selectedObjectIDs.Add(sord.Id);
        }
    }

    protected override void AfterSort(object focusedObject, List<int> selectedObjectIDs, List<int> selectedIndizes)
    {
        int focusedItemIndex = -1;

        foreach (int sordID in selectedObjectIDs)
        {
            for (int j = 0; j < objectsCacheValue.Count; j++)
            {
                if (objectsCacheValue[j] != null && objectsCacheValue[j] is FWSord && ((FWSord)objectsCacheValue[j]).Id == sordID)
                {
                    if (((FWSord)objectsCacheValue[j]).Id == ((FWSord)focusedObject).Id) focusedItemIndex = j;
                    selectedIndizes.Add(j);
                    break;
                }
            }
        }

        SelectedIndices = selectedIndizes;
        if (Items != null && Items.Count > 0 && focusedItemIndex >= 0 && focusedItemIndex < Items.Count)
            FocusedItem = Items[focusedItemIndex];
    }
  }
}

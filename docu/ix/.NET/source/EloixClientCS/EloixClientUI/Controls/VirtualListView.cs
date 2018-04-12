using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Utils;
using EloixClientUI.Utils;

namespace EloixClientUI.Controls
{
    /// <summary>
    /// Base class for displaying objects of an IResultCache in a virtual list view.
    /// </summary>
    /// <remarks>Sub-classes have to implement makeColumns and makeItem. 
    /// To display a list of results, the properties Conn and ObjectsCache 
    /// have to be set.</remarks>
    public class VirtualListView : ListViewEx
    {
        // http://www.codeproject.com/KB/list/ObjectListView.aspx


        #region To be implemented by sub-classes

        /// <summary>
        /// The derived class has to override this method to define the 
        /// columns.
        /// </summary>
        /// <remarks>The derived class must store a ColumnHeaderTag object
        /// in each Column.Tag member.</remarks>
        protected virtual void makeColumns() { }
        /// <summary>
        /// The derived class has to override this method to construct
        /// a ListViewItem from the given object.
        /// </summary>
        /// <param name="objT">Object</param>
        /// <returns>ListViewItem</returns>
        protected virtual ListViewItem makeItem(Object objT) { return null; }

        #endregion

        /// <summary>
        /// <seealso cref="ListView.VirtualMode"/>
        /// </summary>
        /// <remarks>This list view is always in virtual mode.</remarks>
        [Browsable(false)]
        public new bool VirtualMode
        {
            get
            {
                return true;
            }
            set
            {
            }
        }

        /// <summary>
        /// <seealso cref="ListView.View"/>
        /// </summary>
        /// <remarks>This list view is always displayed in View.Details mode.</remarks>
        [Browsable(false)]
        public new View View
        {
            get
            {
                return View.Details;
            }
            set
            {
            }
        }

        #region Configuration

        /// <summary>
        /// Show hourglass cursor when calling a potentially time expensive function.
        /// </summary>
        protected bool showHourglassVal = true;

        /// <summary>
        /// Show hourglass cursor when calling a potentially time expensive function.
        /// </summary>
        public bool ShowHourglass
        {
            get
            {
                return showHourglassVal;
            }
            set
            {
                showHourglassVal = value;
            }
        }

        #endregion

        #region Data

        private bool locked = false;
        private bool _columnSelectionEnabled = true;
        private bool _selectColumnsMenuStaysOpen = true;
        private ToolStripMenuItem _lastMenuItemClicked;
        private IListViewSettingsService _settingsService;

        /// <summary>
        /// Connection to IndexServer
        /// </summary>
        protected FWConnection connVal;
        /// <summary>
        /// The Sord objects in this cache are displayed.
        /// </summary>
        protected IResultCache objectsCacheValue;

        /// <summary>
        /// IndexServer connection object.
        /// </summary>
        [Browsable(false)]
        public virtual FWConnection Conn
        {
            get
            {
                return connVal;
            }
            set
            {
                if (value != connVal)
                {
                    FWConnection oldConn = connVal;
                    connVal = value;
                    OnConnChanged(oldConn, connVal);
                    internalRefresh();
                }
            }
        }

        [Browsable(false)]
        public IListViewSettingsService SettingsService
        {
            get { return _settingsService; }
            set 
            { 
                _settingsService = value;
                if (null != value)
                    _settingsService.ApplyVisibleColumns(this);
            }
        }

        [Category("Behavior")]
        [Description("Enables or disables the selection of the columns to be displayed.")]
        [DefaultValue(true)]
        public bool ColumnSelectionEnabled
        {
            get { return _columnSelectionEnabled; }
            set { _columnSelectionEnabled = value; }
        }

        [Category("Behavior")]
        [Description("When the column select menu is open, should it stay open after an item is selected?")]
        [DefaultValue(true)]
        public virtual bool SelectColumnsMenuStaysOpen
        {
            get { return _selectColumnsMenuStaysOpen; }
            set { _selectColumnsMenuStaysOpen = value; }
        }

        /// <summary>
        /// Is called in set method of Conn property.
        /// </summary>
        /// <param name="oldConn">Old connection object</param>
        /// <param name="newConn">New connection object</param>
        protected virtual void OnConnChanged(FWConnection oldConn, FWConnection newConn)
        {
        }

        /// <summary>
        /// The Sord objects in this cache are displayed.
        /// </summary>
        [Browsable(false)]
        public virtual IResultCache ObjectsCache
        {
            get
            {
                return objectsCacheValue;
            }
            set
            {
                if (objectsCacheValue != null)
                {
                    objectsCacheValue.BeginRead -= new EventHandler(objectsCacheVal_BeginRead);
                    objectsCacheValue.EndRead -= new EventHandler(objectsCacheVal_EndRead);
                }

                selection.Clear();
                base.SelectedIndices.Clear();
                objectsCacheValue = value;

                if (objectsCacheValue != null)
                {
                    objectsCacheValue.BeginRead += new EventHandler(objectsCacheVal_BeginRead);
                    objectsCacheValue.EndRead += new EventHandler(objectsCacheVal_EndRead);
                }

                internalRefresh();
            }
        }

        Hourglass hourglass = new Hourglass(false);

        void objectsCacheVal_EndRead(object sender, EventArgs e)
        {
            if (ShowHourglass)
            {
                hourglass.Hide();
            }
        }

        void objectsCacheVal_BeginRead(object sender, EventArgs e)
        {
            if (ShowHourglass)
            {
                hourglass.Show();
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public VirtualListView()
        {
            base.VirtualMode = true;
            base.View = View.Details;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="container">Container</param>
        public VirtualListView(IContainer container)
        {
            base.VirtualMode = true;
            base.View = View.Details;
            container.Add(this);
        }

        #endregion

        #region Selection

        /// <summary>
        /// Gets the selected objects.
        /// </summary>
        [Browsable(false)]
        public IEnumerable SelectedObjects
        {
            get
            {
                return selection.Values;
            }
        }

        /// <summary>
        /// Gets the focused object.
        /// </summary>
        [Browsable(false)]
        public Object FocusedObject
        {
            get
            {
                return (objectsCacheValue != null && FocusedItem != null) ? objectsCacheValue[FocusedItem.Index] : null;
            }
        }

        /// <summary>
        /// Gets/Sets the selected indices.
        /// </summary>
        [Browsable(false)]
        public new IEnumerable<int> SelectedIndices
        {
            get
            {
                return selection.Keys;
            }
            set
            {
                bool selectionChanged = selection.Count > 0;
                selection.Clear();
                base.SelectedIndices.Clear();

                foreach (int idx in value)
                {
                    if (updateSelection(idx, true))
                    {
                        selectionChanged = true;
                        if (this.VirtualListSize < idx)
                        {
                            this.VirtualListSize = idx + 1;
                        }

                        // Selection has to be set in OnRetrieveVirtualItem
                        // base.SelectedIndices.Add(idx);
                    }
                }
                if (locked) return;
                Refresh();
            }
        }
        /// <summary>
        /// Selects all items.
        /// </summary>
        /// <param name="select">true to select all; false to clear selection</param>
        public void SelectAll(bool select)
        {
            List<int> list = new List<int>();
            if (select)
            {
                for (int i = 0; i < objectsCacheValue.Count; i++)
                {
                    list.Add(i);
                    if (!MultiSelect) break;
                }
            }
            SelectedIndices = list;
        }

        #endregion

        #region Refresh and initialization

        /// <summary>
        /// Re-reads the list content.
        /// </summary>
        protected virtual void internalRefresh()
        {
            if (connVal != null && objectsCacheValue != null)
            {
                itemCache = null;
                this.VirtualListSize = objectsCacheValue.CountEstimated;
                makeColumns();
                makeComparerList();
                assignDefaultColumnWidth();
                
                Refresh();
            }
        }

        private void makeComparerList()
        {
            compareObjectComparersVal = new FWCompareObjectByComparers();
            foreach (ColumnHeader ch in Columns)
            {
                ColumnHeaderTag chT = (ColumnHeaderTag)ch.Tag;
                if (chT.compareObject != null)
                {
                    compareObjectComparersVal.Add(chT.compareObject);
                }
            }
        }

        #endregion

        #region Virtual list view control

        /// <summary>
        /// Map of currently selected objT objects.
        /// </summary>
        protected Dictionary<int, Object> selection = new Dictionary<int, Object>();
        /// <summary>
        /// Comparer object used to order the list, when a column header is clicked.
        /// </summary>
        protected FWCompareObjectByComparers compareObjectComparersVal = new FWCompareObjectByComparers();
        /// <summary>
        /// Cache of ListViewItem objects.
        /// </summary>
        protected ListViewItem[] itemCache;
        /// <summary>
        /// The first cached item has this index in the result list (Sord cache).
        /// </summary>
        protected int itemCacheStartIndex;

        /// <summary>
        /// ListView virtual mode handler
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnCacheVirtualItems(CacheVirtualItemsEventArgs e)
        {
            base.OnCacheVirtualItems(e);

            // is the requested range already contained in the itemCache
            int itemCacheEndIndex = itemCacheStartIndex + (itemCache != null ? (itemCache.Length - 1) : 0);
            if (itemCacheStartIndex <= e.StartIndex && e.EndIndex <= itemCacheEndIndex)
            {
                // itemCache contains the requested items
            }
            else
            {
                // need to read the Sord objects from the cache and 
                // create the ListViewItems
                //using(new Hourglass())
                {
                    itemCacheStartIndex = e.StartIndex;
                    int n = e.EndIndex - e.StartIndex + 1;
                    itemCache = new ListViewItem[n];
                    for (int i = 0; i < n; i++)
                    {
                        // get from cache
                        int idx = i + itemCacheStartIndex;
                        Object objT = objectsCacheValue[idx];
                        if (objT != null)
                        {
                            // make ListViewItem
                            itemCache[i] = makeItem(objT);
                        }
                    }
                }
            }

            // Update the virtual list size:
            // The sordsCache will read the next portion of objects,
            // if e.EndIndex+1 is below the range of the contens.
            // Furthermore it updates its CountEstimated value which 
            // becomes the exact value, if all objects are read.
            //using (new Hourglass(ShowHourglass))
            {
                Object objT = objectsCacheValue[e.EndIndex + 1];
                this.VirtualListSize = objectsCacheValue.CountEstimated;
            }
        }

        /// <summary>
        /// ListView virtual mode handler
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnRetrieveVirtualItem(RetrieveVirtualItemEventArgs e)
        {
            base.OnRetrieveVirtualItem(e);

            // Get the items from the cache
            int itemCacheEndIndex = itemCacheStartIndex + (itemCache != null ? (itemCache.Length - 1) : 0);
            int idx = e.ItemIndex;

            if (itemCache != null && itemCacheStartIndex <= idx && idx <= itemCacheEndIndex)
            {
                // items are cached
                e.Item = itemCache[idx - itemCacheStartIndex];
            }
            else
            {
                // Normally, OnCacheVirtualItems should come before OnRetrieveVirtualItem.
                // But it is missing in some situations. 
                Object objT = objectsCacheValue[idx];
                e.Item = makeItem(objT);
            }

            // Set selection
            if (selection.ContainsKey(idx))
            {
                base.SelectedIndices.Add(idx);
            }
        }

        /// <summary>
        /// ListView virtual mode handler
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnVirtualItemsSelectionRangeChanged(ListViewVirtualItemsSelectionRangeChangedEventArgs e)
        {
            //if (locked) return;
            base.OnVirtualItemsSelectionRangeChanged(e);

            // Stupid Event, e.EndIndex is always one index too low.

            // http://mrdotnet.wordpress.com/2005/01/19/getting-along-with-listview’s-virtuallist-mode-part-3/
            // http://connect.microsoft.com/VisualStudio/feedback/ViewFeedback.aspx?FeedbackID=97026


            bool selectionChanged = false;

            for (int idx = e.StartIndex; idx <= e.EndIndex + 1 /* !!! */; idx++)
            {
                if (updateSelection(idx, e.IsSelected))
                {
                    selectionChanged = true;
                }
            }

            if (selectionChanged)
            {
                OnSelectedIndexChanged(new EventArgs());
            }

        }

        /// <summary>
        /// ListView virtual mode handler
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnItemSelectionChanged(ListViewItemSelectionChangedEventArgs e)
        {
            //if (locked) return;

            if (updateSelection(e.ItemIndex, e.IsSelected))
            {
                //OnSelectedIndexChanged(new EventArgs());
            }
        }

        /// <summary>
        /// Updates the internal selection map.
        /// </summary>
        /// <param name="idx">ListView index</param>
        /// <param name="isSelected">True, if the index is selected.</param>
        /// <returns>True, if the selection has changed.</returns>
        private bool updateSelection(int idx, bool isSelected)
        {
            bool selectionChanged = false;
            if (isSelected)
            {
                Object objT = objectsCacheValue[idx];
                if (objT != null)
                {
                    if (!selection.ContainsKey(idx))
                    {
                        selectionChanged = true;
                    }
                    selection[idx] = objT;
                }
            }
            else
            {
                if (selection.ContainsKey(idx))
                {
                    selectionChanged = true;
                }
                selection.Remove(idx);
            }
            return selectionChanged;
        }

        /// <summary>
        /// Ensures that the item at the given position is visible.
        /// </summary>
        /// <param name="idx">Index, supply -1 to show the last item in the list.</param>
        public new void EnsureVisible(int idx)
        {
            if (idx >= 0 && idx < this.VirtualListSize)
            {
                base.EnsureVisible(idx);
            }
            else
            {
                //using (new Hourglass(ShowHourglass))
                {
                    if (idx < 0)
                    {
                        idx = objectsCacheValue.Count - 1;
                    }
                    Object objT = objectsCacheValue[idx];
                    this.VirtualListSize = objectsCacheValue.CountEstimated;
                    this.EnsureVisible(idx);
                }
            }
        }

        #endregion

        #region Columns and sorting

        /// <summary>
        /// Objects of this class are used as the Tag property in the column headers.
        /// </summary>
        protected class ColumnHeaderTag
        {
            /// <summary>
            /// Comparer object
            /// </summary>
            public FWCompareObject compareObject;
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="compareObject">Comparer object</param>
            public ColumnHeaderTag(FWCompareObject compareObject)
            {
                this.compareObject = compareObject;
            }
        }

        /// <summary>
        /// Sorts the list by the clicked column.
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            //locked = true;

            base.OnColumnClick(e);

            //using (new Hourglass(ShowHourglass))
            {
                ColumnHeader columnHeader = this.Columns[e.Column];

                // The comparer is stored in the Tag property
                FWCompareObject comparer = ((ColumnHeaderTag)columnHeader.Tag).compareObject;
                if (compareObjectComparersVal.FirstComparer == comparer)
                {
                    comparer.Ascending ^= true;
                }
                else
                {
                    compareObjectComparersVal.FirstComparer = comparer;
                }


                object focusedObjectCache = FocusedObject;
                List<int> selectedObjectIDs = new List<int>();

                BeforeSort(selectedObjectIDs);

                // Sort the cached objects.
                // The cache will ensure, that all objects are read.
                objectsCacheValue.Sort(compareObjectComparersVal);

                List<int> selectedIndizes = new List<int>();

                AfterSort(focusedObjectCache, selectedObjectIDs, selectedIndizes);

                // The current cache for ListViewItems is invalid now
                itemCache = null;

                // Redraw the list
                Refresh();

                // Set the sort icon (triangle in the column header)
                SortOrder sortOrder = comparer.Ascending ? SortOrder.Ascending : SortOrder.Descending;
                ListViewExtensions.SetSortIcon(this, e.Column, sortOrder);

                //locked = false;
            }
        }

        protected virtual void BeforeSort(List<int> selectedObjectIDs)
        {

        }

        protected virtual void AfterSort(object __focusedObject, List<int> selectedObjectIDs, List<int> selectedIndizes)
        {

        }

        protected override void OnHeaderRightClick(ColumnClickEventArgs e)
        {
            base.OnHeaderRightClick(e);

            if (!ColumnSelectionEnabled) return;

            ShowColumnSelectionMenu(Cursor.Position);
        }

        /// <summary>
        /// This function computes a width for each column 
        /// so that both, the column title and the column values, 
        /// are entirely displayed.
        /// </summary>
        protected virtual void assignDefaultColumnWidth()
        {
            // Read the first objects 
            int endIndex = objectsCacheValue.CountEstimated;

            // Make ListViewItem objects for the first objects
            CacheVirtualItemsEventArgs e = new CacheVirtualItemsEventArgs(0, endIndex);
            OnCacheVirtualItems(e);

            // Any items?...
            if (itemCache != null)
            {
                // ... compute column widths

                // Array of column width
                int[] columnWidths = new int[Columns.Count];

                // Initialize the array of column widths by the column title width.
                for (int i = 0; i < Columns.Count; i++)
                {
                    columnWidths[i] = TextRenderer.MeasureText(Columns[i].Text, Font).Width;
                }

                // Loop over the cached items ...
                foreach (ListViewItem lv in itemCache)
                {
                    // item might be null for the last item
                    if (lv != null)
                    {
                        // compute text widths of the values for each column
                        for (int i = 0; i < Columns.Count; i++)
                        {
                            String s = lv.SubItems[i].Text;
                            int n = TextRenderer.MeasureText(s, Font).Width;
                            columnWidths[i] = Math.Max(n, columnWidths[i]);
                        }
                    }
                }

                // Assign column widths
                for (int i = 0; i < Columns.Count; i++)
                {
                    int offs = (i == 0) ? 22 : 10;
                    if (Columns[i].Width != 0) // if visible
                    {
                        Columns[i].Width = columnWidths[i] + offs;
                    }
                }
            }
        }

        protected virtual void ShowColumnSelectionMenu(Point pt)
        {
            ToolStripDropDown tsdd = this.MakeColumnSelectionMenu(new ContextMenuStrip());
            tsdd.Show(pt);
        }

        public virtual ToolStripDropDown MakeColumnSelectionMenu(ToolStripDropDown strip)
        {
            strip.ItemClicked += new ToolStripItemClickedEventHandler(ColumnSelectionMenu_ItemClicked);
            strip.Closing += new ToolStripDropDownClosingEventHandler(ColumnSelectionMenu_Closing);

            foreach (ColumnHeader colHeader in this.Columns)
            {
                ToolStripMenuItem mi = new ToolStripMenuItem(colHeader.Text);
                mi.Checked = colHeader.Width > 0;
                mi.Tag = colHeader;

                mi.Enabled = colHeader.Width <= 0 || (colHeader.Index > 0);
                strip.Items.Add(mi);
            }

            return strip;
        }

        void ColumnSelectionMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _lastMenuItemClicked = e.ClickedItem as ToolStripMenuItem;
            ColumnHeader colHeader = _lastMenuItemClicked.Tag as ColumnHeader;
            if (null == colHeader)
                return;

            _lastMenuItemClicked.Checked = !_lastMenuItemClicked.Checked;
            bool visible = _lastMenuItemClicked.Checked;
            ColumnHeaderEx colHeaderEx = colHeader as ColumnHeaderEx;
            if (colHeaderEx != null)
            {
                colHeaderEx.Visible = visible;
            }
            else
            {
                if (visible)
                    colHeader.Width = 60;
                else
                    colHeader.Width = 0;
            }
        }

        void ColumnSelectionMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            bool cancel = (this.SelectColumnsMenuStaysOpen &&
                e.CloseReason == ToolStripDropDownCloseReason.ItemClicked &&
                _lastMenuItemClicked != null &&
                _lastMenuItemClicked.Tag is ColumnHeader);

            if (!cancel && _settingsService != null)
            {
                _settingsService.PersistVisibleColumns(this);
            }
            e.Cancel = cancel;
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.MasterData;
using EloixClientUI.Utils;

namespace EloixClientUI.Controls
{
    public partial class KeywordTreeView : TreeView
    {
        private const string DUMMY_CHILD_NAME = "dummychild-0bc5a44c-423f-4055-a343-bf692977cde9";
        private const string NEW_KEYWORD_ID = "newkeywordid-0bc5a44c-423f-4055-a343-bf692977cde9";
        private Font nodeFontEnabled;
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private ToolStripMenuItem mnNew;
        private ToolStripMenuItem mnNewSub;
        private ToolStripMenuItem mnDelete;
        private ToolStripMenuItem mnEdit;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnEnabled;
        private ToolStripMenuItem mnDisabled;
        private ToolStripMenuItem mnAdd;
        private Font nodeFontDisabled;
        private bool lockContextMenu;
        private Timer timer1;
        private bool modifiedValue;
        private bool allowEditValue = true;

        protected FWKeyword completeKeywordListValue;
        protected FWKeyword currentkeywordList;
        protected FWKeyword keywordListToBeDisplayed;

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
        protected String keywordfilterValue;
        private ToolStripMenuItem mnAppendPlaceholder;
        private ToolStripMenuItem mnDate;
        private ToolStripMenuItem mnTime;
        private ToolStripMenuItem mnYear;
        private ToolStripMenuItem mnMonth;
        private ToolStripMenuItem mnDay;
        private ToolStripMenuItem mnUserName;
        private ToolStripMenuItem mnCounters;
        private ToolStripMenuItem mnCounter1;
        /// <summary>
        /// The search text of the previsious 
        /// </summary>
        protected String lastNameFilter = "";

        public event EventHandler KeywordSelected;

        public KeywordTreeView()
        {
            InitializeComponent();
        }

        public virtual FWConnection Conn
        {
            get { return completeKeywordListValue != null ? completeKeywordListValue.Conn : null; }
        }

        public virtual FWKeyword KeywordList
        {
            get { return completeKeywordListValue; }
            set { completeKeywordListValue = currentkeywordList = value; InternalRefresh(); }
        }

        public virtual String KeywordFilter
        {
            get { return keywordfilterValue; }
            set { keywordfilterValue = value; }
        }

        public virtual FWKeyword SelectedKeyword
        {
            get
            {
                FWKeyword ret = null;
                if (SelectedNode != null)
                {
                    FWKeyword kw = GetKeywordFromNode(SelectedNode);
                    if (kw.Enabled)
                    {
                        ret = kw;
                    }
                }
                return ret;
            }
        }

        public virtual bool Modified
        {
            get { return modifiedValue && AllowEdit; }
            set { modifiedValue = value; }
        }

        public virtual bool AllowEdit
        {
            get { return allowEditValue; }
            set { allowEditValue = value; InternalRefresh(); }
        }

        public virtual String GetSelectedKeywordText()
        {
            FWKeyword kw = SelectedKeyword;
            String ret = null;
            if (kw != null)
            {
                ret = Conn.Ix.cookKeyword(kw.Id);
            }
            return ret;
        }

        protected virtual void InitAllowEdit()
        {
            if (allowEditValue)
            {
                allowEditValue = (Conn.Session.User.flags & AccessC.FLAG_EDITSWL) != 0;
            }

            this.LabelEdit = AllowEdit;
            this.ContextMenuStrip = AllowEdit ? contextMenuStrip1 : null;
        }

        protected virtual void InternalRefresh()
        {
            try
            {
                if (timerVal == null)
                {
                    nodeFontEnabled = new Font(this.Font, FontStyle.Regular);
                    nodeFontDisabled = new Font(this.Font, FontStyle.Underline);
                    mnNew.Click += new EventHandler(mnNew_Click);
                    mnNewSub.Click += new EventHandler(mnNewSub_Click);
                    mnEdit.Click += new EventHandler(mnEdit_Click);
                    mnDelete.Click += new EventHandler(mnDelete_Click);
                    mnEnabled.Click += new EventHandler(mnEnabled_Click);
                    mnDisabled.Click += new EventHandler(mnDisabled_Click);
                    mnAdd.Click += new EventHandler(mnAdd_Click);
                    mnDate.Click += new EventHandler(mnAppendPlaceholder_Click);
                    mnYear.Click += new EventHandler(mnAppendPlaceholder_Click);
                    mnMonth.Click += new EventHandler(mnAppendPlaceholder_Click);
                    mnDay.Click += new EventHandler(mnAppendPlaceholder_Click);
                    mnUserName.Click += new EventHandler(mnAppendPlaceholder_Click);

                    System.Threading.TimerCallback timerCb = new System.Threading.TimerCallback(this.OnThreadingTimer);
                    timerVal = new System.Threading.Timer(timerCb, null, 0, 300);

                    timer1.Enabled = true;
                }

                if (Conn != null && currentkeywordList != null)
                {
                    mnCounters.DropDownItems.Clear();

                    foreach (FWCounter ci in Conn.MasterData.Counters.ResultCache)
                    {
                        ToolStripItem item = mnCounters.DropDownItems.Add(ci.Name);
                        item.Click += new EventHandler(mnAppendPlaceholder_Click);
                    }
                    mnCounters.Visible = mnCounters.DropDownItems.Count != 0;

                    InitAllowEdit();
                    Refresh();
                }

                Modified = false;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public void mnAppendPlaceholder_Click(object sender, EventArgs e)
        {
            TreeNode node = SelectedNode;
            FWKeyword kw = GetKeywordFromNode(node);
            if (kw == null) return;

            String placeholder = null;
            if (sender == mnDay) placeholder = KeywordC.PLACEHOLDER_DAY;
            else if (sender == mnMonth) placeholder = KeywordC.PLACEHOLDER_MONTH;
            else if (sender == mnYear) placeholder = KeywordC.PLACEHOLDER_YEAR;
            else if (sender == mnDate) placeholder = KeywordC.PLACEHOLDER_DATE;
            else if (sender == mnUserName) placeholder = KeywordC.PLACEHOLDER_USER_NAME;
            else
            {
                // counter
                placeholder = KeywordC.PLACEHOLDER_COUNTER_BEGIN +
                  ((ToolStripItem)sender).Text +
                  KeywordC.PLACEHOLDER_COUNTER_END;
            }

            node.Text += placeholder;
            kw.Text += placeholder;
            Modified = true;

        }

        /// <summary>
        /// Clears all nodes and refreshes the view. 
        /// </summary>
        public override void Refresh()
        {
            base.Refresh();

            this.Nodes.Clear();

            if (Conn != null && currentkeywordList != null)
            {
                FWKeyword kwParent = currentkeywordList;

                FWKeywordChildren kwChildren = kwParent.Children;
                kwChildren.Sort();

                foreach (FWKeyword kwChild in kwParent.Children)
                {
                    TreeNode childNode = MakeTreeNode(kwChild);
                    this.Nodes.Add(childNode);
                }
            }
        }

        public virtual TreeNode MakeTreeNode(FWKeyword kw)
        {
            TreeNode treeNode1 = new TreeNode(kw.Id);
            treeNode1.Name = kw.Id;
            treeNode1.Text = kw.Text;
            treeNode1.Tag = kw;
            treeNode1.NodeFont = kw.Enabled ? nodeFontEnabled : nodeFontDisabled;
            //treeNode1.ForeColor = kw.Enabled ? Color.Black : Color.Gray;

            if (kw.Children.Count > 0)
            {
                TreeNode dummyChild = new TreeNode();
                dummyChild.Name = DUMMY_CHILD_NAME;
                treeNode1.Nodes.Add(dummyChild);
            }
            return treeNode1;
        }

        protected virtual void FillNodes(TreeNode node)
        {
            this.SuspendLayout();

            using (new Hourglass())
            {
                node.Nodes.Clear();

                FWKeyword kwParent = GetKeywordFromNode(node);

                foreach (FWKeyword kwChild in kwParent.Children)
                {
                    TreeNode childNode = MakeTreeNode(kwChild);
                    node.Nodes.Add(childNode);
                }
            }

            this.ResumeLayout();
        }

        /// <summary>
        /// This function is called before a node is expanded. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
        {
            base.OnBeforeExpand(e);
            if (e.Cancel) return;

            TreeNode parentNode = e.Node;
            if (parentNode.Nodes.Count == 1 && parentNode.Nodes[0].Name.Equals(DUMMY_CHILD_NAME))
            {
                FillNodes(parentNode);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNewSub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDisabled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnAppendPlaceholder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnYear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCounters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCounter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnNewSub,
            this.mnDelete,
            this.mnEdit,
            this.mnAppendPlaceholder,
            this.toolStripMenuItem1,
            this.mnEnabled,
            this.mnDisabled,
            this.mnAdd});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 186);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.mnNew.Size = new System.Drawing.Size(208, 22);
            this.mnNew.Text = "New";
            // 
            // mnNewSub
            // 
            this.mnNewSub.Name = "mnNewSub";
            this.mnNewSub.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnNewSub.Size = new System.Drawing.Size(208, 22);
            this.mnNewSub.Text = "New subordinate";
            // 
            // mnDelete
            // 
            this.mnDelete.Name = "mnDelete";
            this.mnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnDelete.Size = new System.Drawing.Size(208, 22);
            this.mnDelete.Text = "Delete";
            // 
            // mnEdit
            // 
            this.mnEdit.Name = "mnEdit";
            this.mnEdit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnEdit.Size = new System.Drawing.Size(208, 22);
            this.mnEdit.Text = "Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // mnEnabled
            // 
            this.mnEnabled.Name = "mnEnabled";
            this.mnEnabled.Size = new System.Drawing.Size(208, 22);
            this.mnEnabled.Text = "Enabled";
            // 
            // mnDisabled
            // 
            this.mnDisabled.Name = "mnDisabled";
            this.mnDisabled.Size = new System.Drawing.Size(208, 22);
            this.mnDisabled.Text = "Disabled";
            // 
            // mnAdd
            // 
            this.mnAdd.Name = "mnAdd";
            this.mnAdd.Size = new System.Drawing.Size(208, 22);
            this.mnAdd.Text = "Add";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnAppendPlaceholder
            // 
            this.mnAppendPlaceholder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDate,
            this.mnYear,
            this.mnMonth,
            this.mnDay,
            this.mnUserName,
            this.mnCounters});
            this.mnAppendPlaceholder.Name = "mnAppendPlaceholder";
            this.mnAppendPlaceholder.Size = new System.Drawing.Size(208, 22);
            this.mnAppendPlaceholder.Text = "Append placeholder";
            // 
            // mnDate
            // 
            this.mnDate.Name = "mnDate";
            this.mnDate.Size = new System.Drawing.Size(136, 22);
            this.mnDate.Text = "Date";
            // 
            // mnTime
            // 
            this.mnTime.Name = "mnTime";
            this.mnTime.Size = new System.Drawing.Size(108, 22);
            this.mnTime.Text = "Time";
            // 
            // mnYear
            // 
            this.mnYear.Name = "mnYear";
            this.mnYear.Size = new System.Drawing.Size(136, 22);
            this.mnYear.Text = "Year";
            // 
            // mnMonth
            // 
            this.mnMonth.Name = "mnMonth";
            this.mnMonth.Size = new System.Drawing.Size(136, 22);
            this.mnMonth.Text = "Month";
            // 
            // mnDay
            // 
            this.mnDay.Name = "mnDay";
            this.mnDay.Size = new System.Drawing.Size(136, 22);
            this.mnDay.Text = "Day";
            // 
            // mnUserName
            // 
            this.mnUserName.Name = "mnUserName";
            this.mnUserName.Size = new System.Drawing.Size(136, 22);
            this.mnUserName.Text = "User name";
            // 
            // mnCounters
            // 
            this.mnCounters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCounter1});
            this.mnCounters.Name = "mnCounters";
            this.mnCounters.Size = new System.Drawing.Size(136, 22);
            this.mnCounters.Text = "Counters";
            // 
            // mnCounter1
            // 
            this.mnCounter1.Name = "mnCounter1";
            this.mnCounter1.Size = new System.Drawing.Size(130, 22);
            this.mnCounter1.Text = "Counter1";
            // 
            // KeywordTreeView
            // 
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.HideSelection = false;
            this.LabelEdit = true;
            this.LineColor = System.Drawing.Color.Black;
            this.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.KeywordTreeView_BeforeLabelEdit);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            MouseEventArgs mouseArgs = (MouseEventArgs)e;
            if (mouseArgs.Button == MouseButtons.Left && SelectedKeyword != null && SelectedKeyword.Enabled)
            {
                if (KeywordSelected != null)
                {
                    KeywordSelected.Invoke(this, e);
                }
            }
        }

        protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
        {
            base.OnNodeMouseClick(e);

            if (e.Button == MouseButtons.Right)
            {
                if (SelectedNode != null)
                {
                    FWKeyword kw = GetKeywordFromNode(SelectedNode);
                    mnEnabled.Checked = kw.Enabled;
                    mnAdd.Checked = kw.Prefixed;
                    mnDisabled.Checked = !kw.Prefixed && !kw.Enabled;
                }
            }
        }

        private void mnNew_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            if (SelectedNode != null)
            {
                TreeNode parentNode = SelectedNode.Parent;
                NewKeywordNode(parentNode);
            }
        }

        protected virtual FWKeyword GetKeywordFromNode(TreeNode treeNode)
        {
            return (treeNode != null) ? ((FWKeyword)treeNode.Tag) : null;
        }

        private void KeywordTreeView_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            lockContextMenu = true;
        }

        private TreeNode FindChildNodeByText(TreeNode parentNode, String text)
        {
            TreeNodeCollection nodes = parentNode != null ? parentNode.Nodes : this.Nodes;
            foreach (TreeNode tn in nodes)
            {
                if (tn.Text == text) return tn;
            }
            return null;
        }

        protected override void OnAfterLabelEdit(NodeLabelEditEventArgs e)
        {
            FWKeyword kw = GetKeywordFromNode(e.Node);
            if (kw != null)
            {
                if (e.Label != null && e.Label.Length != 0)
                {
                    // does this keyword text already exist 
                    TreeNode tnChild = FindChildNodeByText(e.Node.Parent, e.Label);
                    if (tnChild != null)
                    {
                        TreeNodeCollection treeNodes = (e.Node.Parent != null) ? e.Node.Nodes : this.Nodes;
                        treeNodes.Remove(e.Node);

                        System.Windows.Forms.MessageBox.Show(
                          EloixClientUI.Properties.Resources.KeywordAlreadyExists,
                          EloixClientUI.Properties.Resources.MsgBoxConfirm,
                          MessageBoxButtons.OK);
                    }
                    else
                    {
                        kw.Text = e.Label;
                        e.Node.EndEdit(false);

                        if (IsNewNode(e.Node))
                        {
                            FWKeyword kwParent = GetKeywordFromNode(e.Node.Parent);
                            if (kwParent != null)
                            {
                                kwParent.Children.Add(kw);
                            }
                            else
                            {
                                currentkeywordList.Children.Add(kw);
                            }
                        }

                        SelectedNode = e.Node;

                        Modified = true;
                    }
                }
                else
                {
                    if (IsNewNode(e.Node))
                    {
                        TreeNodeCollection treeNodes = (e.Node.Parent != null) ? e.Node.Nodes : this.Nodes;
                        treeNodes.Remove(e.Node);
                    }
                }
            }
            lockContextMenu = false;
        }

        void mnAdd_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            SetKeywordNodeAdd(SelectedNode);
        }

        public virtual void SetKeywordNodeAdd(TreeNode node)
        {
            FWKeyword kw = GetKeywordFromNode(node);
            if (kw != null)
            {
                Modified |= !kw.Prefixed;
                kw.Prefixed = true;
                node.NodeFont = nodeFontDisabled;
            }
        }

        void mnDisabled_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            SetKeywordNodeDisabled(SelectedNode);
        }

        public virtual void SetKeywordNodeDisabled(TreeNode node)
        {
            FWKeyword kw = GetKeywordFromNode(node);
            if (kw != null)
            {
                Modified |= kw.Enabled;
                kw.Enabled = false;
                node.NodeFont = nodeFontDisabled;
            }
        }

        void mnEnabled_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            SetKeywordNodeEnabled(SelectedNode);
        }

        public virtual void SetKeywordNodeEnabled(TreeNode node)
        {
            FWKeyword kw = GetKeywordFromNode(node);
            if (kw != null)
            {
                Modified |= !kw.Enabled;
                kw.Enabled = true;
                node.NodeFont = nodeFontEnabled;
            }
        }

        void mnDelete_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            DeleteKeywordNode(SelectedNode);
        }

        public virtual void DeleteKeywordNode(TreeNode node)
        {
            FWKeyword kw = GetKeywordFromNode(node);
            if (kw != null)
            {
                FWKeyword kwParent = kw.Parent;
                if (kwParent != null)
                {
                    kwParent.Children.Remove(kw.Id);
                    node.Remove();
                    Modified = true;
                }
            }
        }

        void mnEdit_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            if (SelectedNode != null)
            {
                SelectedNode.BeginEdit();
            }
        }

        void mnNewSub_Click(object sender, EventArgs e)
        {
            if (lockContextMenu) return;
            if (SelectedNode != null)
            {
                TreeNode parentNode = SelectedNode;
                NewKeywordNode(parentNode);
            }
        }

        public void NewKeywordNode(TreeNode parentNode)
        {
            if (parentNode != null) parentNode.Expand();

            FWKeyword parentKeyword = GetKeywordFromNode(parentNode);
            if (parentKeyword == null) parentKeyword = currentkeywordList;

            FWKeyword kw = Conn.MasterData.ClassFactory.NewFWKeyword(new Keyword(), parentKeyword);
            kw.Text = EloixClientUI.Properties.Resources.NewKeyword;
            kw.Enabled = true;
            kw.Id = parentKeyword.Id + NEW_KEYWORD_ID;
            kw.Children = new FWKeywordChildren(kw);

            TreeNode newNode = MakeTreeNode(kw);
            if (parentNode != null)
            {
                parentNode.Nodes.Add(newNode);
                parentNode.Expand();
            }
            else
            {
                this.Nodes.Add(newNode);
            }


            newNode.BeginEdit();
        }

        public virtual bool IsNewNode(TreeNode node)
        {
            bool ret = false;
            FWKeyword kw = GetKeywordFromNode(node);
            if (kw != null)
            {
                ret = kw.Id.IndexOf(NEW_KEYWORD_ID) >= 0;
            }
            return ret;
        }

        private List<String> GetSelectedNodePath()
        {
            // TreeNode.FullPath verwendet BS als Trennner. Deshalb 
            // mache ich das hier als Liste, damit BS in Stichwörtern verwendet werden können.
            List<String> path = new List<String>();
            TreeNode tn = this.SelectedNode;
            while (tn != null)
            {
                path.Insert(0, tn.Text);
                tn = tn.Parent;
            }
            return path;
        }

        private static TreeNode FindNodeByText(TreeNodeCollection nodes, String t)
        {
            TreeNode node = null;
            for (int j = 0; j < nodes.Count && node == null; j++)
            {
                TreeNode tnj = nodes[j];
                if (tnj.Text.Equals(t))
                {
                    node = tnj;
                }
            }
            return node;
        }

        private void SelectNodePath(List<String> path)
        {
            TreeNode lastNode = null;
            TreeNodeCollection lastNodeChildren = this.Nodes;
            for (int i = 0; i < path.Count; i++)
            {
                lastNode = FindNodeByText(lastNodeChildren, path[i]);
                if (lastNode == null) break;

                if (i != path.Count - 1)
                {
                    lastNode.Expand();
                    lastNodeChildren = lastNode.Nodes;
                }
            }

            if (lastNode != null)
            {
                this.SelectedNode = lastNode;
            }
        }

        public virtual void Checkin()
        {
            try
            {
                if (Modified)
                {
                    List<String> selectedPath = GetSelectedNodePath();
                    String kwFilter = this.KeywordFilter;

                    using (new Hourglass())
                    {
                        completeKeywordListValue.Checkin();
                    }

                    if (kwFilter != null && kwFilter.Length != 0)
                    {
                        currentkeywordList = ApplyKeywordFilter(kwFilter);
                    }

                    InternalRefresh();

                    SelectNodePath(selectedPath);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // put the cache object provided 
            // by the onThreadingTimer into a local variable to 
            // avoid synchronization
            FWKeyword kw = keywordListToBeDisplayed;

            // Reset the handover variable, so nothing will be done, 
            // if onThreadingTimer has no new cache object and this function is
            // called the next time.
            keywordListToBeDisplayed = null;

            // If onThreadingTimer provides a new cache object...
            if (kw != null)
            {
                currentkeywordList = kw;
                InternalRefresh();

                // Select first node.
                if (this.Nodes.Count > 0)
                {
                    this.SelectedNode = this.Nodes[0];
                }
            }
        }

        private FWKeyword ApplyKeywordFilter(String currentNameFilter)
        {
            FWKeyword myKeywordList = Conn.MasterData.ClassFactory.NewFWKeyword(new Keyword(), null);
            myKeywordList.Id = currentNameFilter;
            List<FWKeyword> filteredKeywordList = KeywordList.Find(currentNameFilter);
            myKeywordList.Children = new FWKeywordChildren(null, filteredKeywordList);
            return myKeywordList;
        }

        protected virtual void OnThreadingTimer(object stateInfo)
        {
            if (System.Threading.Monitor.TryEnter(syncTimerMonitor))
            {
                try
                {
                    // put the current search string into a local variable to 
                    // avoid synchronization
                    String currentNameFilter = keywordfilterValue;
                    if (currentNameFilter == null) currentNameFilter = "";

                    // if search string has changed
                    if (!currentNameFilter.Equals(lastNameFilter))
                    {
                        if (currentNameFilter.Length != 0)
                        {
                            keywordListToBeDisplayed = ApplyKeywordFilter(currentNameFilter);
                        }
                        else
                        {
                            keywordListToBeDisplayed = KeywordList;
                        }

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}

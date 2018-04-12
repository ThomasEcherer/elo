using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClient.IndexServerFW.Utils;
using EloixClientUI.Common;
using EloixClientUI.Utils;
using EloixClientUI.Common;
using EloixClient.IndexServerFW.MasterData;
using EloixClientUI.Properties;
using EloixClient.IndexServerFW.Utils;
using System.Threading;



namespace EloixClientUI.Controls
{
    /// <summary>
    /// Displays the ELO archive hierarchie in a tree view control.
    /// </summary>
    public class ArcTreeView : TreeView
    {
        private ContextMenu _contextMenu;

        /// <summary>
        /// Sord type images.
        /// </summary>
        protected SordTypeImageList sordTypeImageLists;

        /// <summary>
        /// Connection object
        /// </summary>
        protected FWConnection connVal;

        /// <summary>
        /// Parent folder object
        /// </summary>
        protected FWFolder parentFolderVal;

        /// <summary>
        /// View modes and allowd actions.
        /// </summary>
        protected ArcTreeOptions optionsVal;

        /// <summary>
        /// Node name for dummy node 
        /// </summary>
        protected const string DUMMY_CHILD_NAME = "dummychild-0bc5a44c-423f-4055-a343-bf692977cde9";

        /// <summary>
        /// Helper object to checkin documents contained in a COM DataObject.
        /// </summary>
        protected DocumentDataObject documentDataObject;

        /// <summary>
        /// Helper object used to open documents.
        /// </summary>
        protected OpenDocumentHandler openDocumentHandler;

        /// <summary>
        /// Event is raised before a document is checked in.
        /// </summary>
        public event DocumentDataObject.CheckinHandler BeforeCheckin;

        /// <summary>
        /// Event is raised after a document is checked in.
        /// </summary>
        public event DocumentDataObject.CheckinHandler AfterCheckin;

        protected static String PATH_DELIM = "¶";

        private SordListView subItemsListValue;
        protected bool lockSubItemsList;
        protected bool LockSubItemsList { get { return lockSubItemsList; } }

        /// <summary>
        /// Tree view options for allowed actions and viewing modes.
        /// </summary>
        [Flags]
        protected enum ArcTreeOptions
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
            ShowReferences = (1 << 4),
            /// <summary>
            /// Showd deleted elements in Treeview
            /// </summary>
            ShowDeletedElements = (1 << 5)
        }










        /// <summary>
        /// Constructor
        /// </summary>
        public ArcTreeView()
        {
        }









        /// <summary>
        /// Called, when the control is created.
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            init();
        }

        /// <summary>
        /// Is called in OnCreateControl and initializes the CheckinDocumentDataObject and OpenDocumentHandler.
        /// </summary>
        protected virtual void init()
        {
            documentDataObject = new DocumentDataObject(connVal);
            documentDataObject.BeforeCheckin += new DocumentDataObject.CheckinHandler(checkinObj_BeforeCheckin);
            documentDataObject.AfterCheckin += new DocumentDataObject.CheckinHandler(checkinObj_AfterCheckin);
            openDocumentHandler = new OpenDocumentHandler();
        }




        #region Properties

        /// <summary>
        /// IndexServer connection object.
        /// </summary>
        public virtual FWConnection Conn
        {
            get
            {
                return connVal;
            }
            set
            {
                connVal = value;
                if (connVal != null)
                {
                    parentFolderVal = connVal.Content.RootFolder;
                    if (documentDataObject != null)
                    {
                        documentDataObject.Conn = connVal;
                    }
                    if (subItemsListValue != null)
                    {
                        subItemsListValue.Conn = connVal;
                    }
                    internalRefresh();
                }
            }
        }

        /// <summary>
        /// This ListView shows the subitems of the selected folder.
        /// </summary>
        public SordListView SubItemsList
        {
            get
            {
                return subItemsListValue;
            }
            set
            {
                subItemsListValue = value;
                internalRefresh();
            }
        }

        /// <summary>
        /// Allow to drag files from the tree view e. g. into the file system.
        /// </summary>
        public virtual bool AllowDrag
        {
            get { return getOptionBit(ArcTreeOptions.AllowDrag); }
            set { setOptionBit(ArcTreeOptions.AllowDrag, value); internalRefresh(); }
        }

        /// <summary>
        /// Allow to open documents on double click.
        /// </summary>
        public virtual bool AllowOpenDocument
        {
            get { return getOptionBit(ArcTreeOptions.AllowOpenDocument); }
            set { setOptionBit(ArcTreeOptions.AllowOpenDocument, value); internalRefresh(); }
        }

        /// <summary>
        /// Show documents in the tree view.
        /// </summary>
        public virtual bool ShowDocuments
        {
            get { return getOptionBit(ArcTreeOptions.ShowDocuments); }
            set { setOptionBit(ArcTreeOptions.ShowDocuments, value); internalRefresh(); }
        }

        /// <summary>
        /// Shows deleted Elements in ArcTreeView
        /// </summary>
        public virtual bool ShowDeletedElements
        {
            get { return getOptionBit(ArcTreeOptions.ShowDeletedElements); }
            set { setOptionBit(ArcTreeOptions.ShowDeletedElements, value); internalRefresh(); }
        }

        /// <summary>
        /// Show reverences (logically copies) in the tree view.
        /// </summary>
        public virtual bool ShowReferences
        {
            get { return getOptionBit(ArcTreeOptions.ShowReferences); }
            set { setOptionBit(ArcTreeOptions.ShowReferences, value); internalRefresh(); }
        }

        /// <summary>
        /// Selected Sord object or null, if nothing is selected.
        /// </summary>
        public virtual FWSord SelectedSord
        {
            get
            {
                FWSord sord = GetSordFromNode(this.SelectedNode);
                return sord;
            }
        }
        /// <summary>
        /// Path to selected node. 
        /// </summary>
        /// <remarks>The first character works as delimiter between the leves.</remarks>
        public virtual String SelectedPath
        {
            get
            {
                IEnumerable<String> path = GetSelectedNodePath();
                StringBuilder sbuf = new StringBuilder();
                foreach (String s in path) sbuf.Append(PATH_DELIM).Append(s);
                return sbuf.ToString();
            }
            set
            {
                String path = (value != null && value.Length != 0) ? value : PATH_DELIM;
                String[] arr = path.Split(PATH_DELIM.ToCharArray());
                SelectNodePath(arr);
            }
        }

        /// <summary>
        /// Parent folder of the tree.
        /// </summary>
        public virtual FWFolder ParentFolder
        {
            get
            {
                return parentFolderVal;
            }
            set
            {
                parentFolderVal = value;
                if (parentFolderVal != null)
                {
                    connVal = parentFolderVal.Conn;
                    internalRefresh();
                }
            }
        }

        #endregion




        /// <summary>
        /// Returns wether the given bit is set or not
        /// </summary>
        /// <param name="bit">One of the constants defined in ArcTreeOptions</param>
        /// <returns>True, if the option is on.</returns>
        protected virtual bool getOptionBit(ArcTreeOptions bit)
        {
            return (optionsVal & bit) != 0;
        }

        /// <summary>
        /// Sets the given option bit to the specified value.
        /// </summary>
        /// <param name="bit">Option bit.</param>
        /// <param name="value">Value</param>
        protected virtual void setOptionBit(ArcTreeOptions bit, bool value)
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
        /// Extracts the Sord object from the TreeNode.Tag member.
        /// </summary>
        /// <param name="n">TreeNode object</param>
        /// <returns>FWSord object</returns>
        public virtual FWSord GetSordFromNode(TreeNode n)
        {
            return n != null ? ((FWSord)n.Tag) : null;
        }

        /// <summary>
        /// Clears all nodes and refreshes the tree view.
        /// </summary>
        protected virtual void internalRefresh()
        {
            if (connVal != null)
            {
                sordTypeImageLists = connVal.MasterData.SordTypes.ImageList;
                this.ImageList = sordTypeImageLists.Images;

                Refresh();
            }
        }

        public void ReLoad()
        {
            ReLoad(false);
        }

        /// <summary>
        /// This method actualize a content of archiv treeviews node
        /// <param name="refreshReferenceNodes">Refresh reference nodes</param>
        /// </summary>
        public void ReLoad(bool refreshReferenceNodes)
        {
            if (connVal != null)
            {
                // Docmaskchach update
                connVal.MasterData.DocMasks.Invalidate();

                System.Windows.Forms.TreeNode sordTNode;

                if (SelectedSord != null && SelectedNode != null)
                {
                    sordTNode = SelectedNode;
                    RefreshNode(sordTNode, refreshReferenceNodes);
                }
            }
        }

        private void RefreshReferenceNodes(TreeNode treeNode)
        {
            FWSord selectedSord = GetSordFromNode(treeNode);
            if (selectedSord == null)
                return;

            foreach (ArcPath path in selectedSord.RefPaths)
            {
                string absoluteArcPathString = GetAbsoluteArcPathString(path, selectedSord.Id, selectedSord.Name, Conn.Content.RootFolder.Name);

                if (string.IsNullOrEmpty(absoluteArcPathString))
                    continue;

                TreeNode node = FindNodeByArcPath(absoluteArcPathString);

                if (node != null && node != treeNode)
                {
                    FWSord sord = GetSordFromNode(node);
                    if (sord != null)
                    {
                        if (sord.IsDocument())
                        {
                            if (node.Parent == null)
                                continue;

                            node = node.Parent;
                        }

                        RefreshNode(node);
                    }
                }
            }
        }

        /// <summary>
        /// Clears all nodes and refreshes the view. 
        /// </summary>
        public override void Refresh()
        {
            String path = SelectedPath;

            base.Refresh();

            this.Nodes.Clear();

            if (parentFolderVal != null)
            {
                TreeNode treeNode1 = new TreeNode(Convert.ToString(parentFolderVal.Id));
                treeNode1.Text = parentFolderVal.Name;
                //treeNode1.Tag = parentFolderVal;
                treeNode1.Tag = Conn.Content.GetFolder(parentFolderVal.Id);
                this.Nodes.Add(treeNode1);

                FillNodes(treeNode1);
            }

            SelectedPath = path;

        }

        protected virtual void RefreshNodeInternal(TreeNode node)
        {
            string path = SelectedPath;

            FWFolder folder = node.Tag as FWFolder;
            if (null == folder) return;
            node.Tag = Conn.Content.GetFolder(folder.Id);

            Dictionary<int, bool> treeState = SaveTreeState(node);

            ((FWFolder)node.Tag).Sords.Clear();
            FillNodes(node);
            RestoreTreeState(node, treeState);
            if (node == SelectedFolderNode)
                UpdateSubItemsList(node);

            SelectedPath = path;
        }

        /// <summary>
        /// Refreshs the current node.
        /// </summary>
        /// <param name="node">The <c>TreeNode</c> to update.</param>
        /// <remarks>
        /// The contained sord objects will also be updated (cleared and read again).
        /// </remarks>
        public void RefreshNode(TreeNode node)
        {
            RefreshNode(node, false);
        }

        /// <summary>
        /// Refreshs the current node.
        /// </summary>
        /// <param name="node">The <c>TreeNode</c> to update.</param>
        /// <param name="refreshReferenceNodes">Refresh Reference nodes</param>
        /// <remarks>
        /// The contained sord objects will also be updated (cleared and read again).
        /// </remarks>
        public void RefreshNode(TreeNode node, bool refreshReferenceNodes)
        {
            if (node == null)
                return;

            if (GetSordFromNode(node).IsDocument())
                RefreshNodeInternal(node.Parent);
            else
                RefreshNodeInternal(node);

            if (refreshReferenceNodes)
                RefreshReferenceNodes(node);
        }

        /// <summary>
        /// Refreshs the node that belongs to the provided sord.
        /// </summary>
        /// <param name="node">The <c>FWSord</c> whichs TreeNode should be updated.</param>
        /// <remarks>
        /// The contained sord objects will also be updated (cleared and read again).
        /// </remarks>
        public virtual void RefreshNode(FWSord sord)
        {
            RefreshNode(sord, false);
        }

        /// <summary>
        /// Refreshs the node that belongs to the provided sord.
        /// </summary>
        /// <param name="node">The <c>FWSord</c> whichs TreeNode should be updated.</param>
        /// <param name="refreshReferenceNodes">Refresh Reference nodes</param>
        /// <remarks>
        /// The contained sord objects will also be updated (cleared and read again).
        /// </remarks>
        public virtual void RefreshNode(FWSord sord, bool refreshReferenceNodes)
        {
            if (sord == null || sord.Conn == null || sord.Conn.Content == null)
                return;

            string absoluteArchPathString = GetAbsoluteArcPathString(sord);
            if (string.IsNullOrEmpty(absoluteArchPathString))
            {
               return;
            }

            TreeNode node = FindNodeByArcPath(absoluteArchPathString);

            RefreshNode(node, refreshReferenceNodes);
        }

        /// <summary>
        /// Creates a TreeNode object initialized by the given Sords.
        /// </summary>
        /// <param name="parentFolder">Parent Sord</param>
        /// <param name="sord">Sord to be contained in the new node.</param>
        /// <returns>TreeNode object</returns>
        protected virtual TreeNode MakeTreeNode(FWSord parentFolder, FWSord sord)
        {
            TreeNode treeNode1 = new TreeNode(Convert.ToString(sord.Id));
            treeNode1.Text = sord.Name;
            treeNode1.Tag = sord;
            treeNode1.ForeColor = sord.RGBColor;
            treeNode1.ImageIndex = sordTypeImageLists.getImageIndex(sord.Type, parentFolder.Id != sord.ParentId, false, sord.LockId >= 0, ProoveIfEncryptedDocument(sord));
            treeNode1.SelectedImageIndex = treeNode1.ImageIndex;
            //treeNode1.ContextMenu = _contextMenu;

            //if (!sord.IsDocument() && sord.Core.childCount > 0)
            if (!sord.IsDocument())
            {
                //if (((FWFolder)sord).Sords != null && ((FWFolder)sord).Sords.Count > 0)
                //    if (((FWFolder)sord).Sords != null)
                //{
                TreeNode dummyChild = new TreeNode();
                dummyChild.Name = DUMMY_CHILD_NAME;
                treeNode1.Nodes.Add(dummyChild);
                //}
                //else
                //{
                //if (ShowDeletedElements)
                //{
                //    // Proove if sord contains subentries which are deleted
                //    FWFindSordsCache<FWSord> res = GetDeletedSordsOf(sord.Id);
                //    if (res != null && res.Count > 0)
                //    {
                //        TreeNode dummyChild = new TreeNode();
                //        dummyChild.Name = DUMMY_CHILD_NAME;
                //        treeNode1.Nodes.Add(dummyChild);
                //    }
                //}
                //}
            }

            return treeNode1;
        }


        private delegate void FillNodesDelegate(TreeNode node);

        /// <summary>
        /// Clears the children of the given node and 
        /// adds the current children from the archive.
        /// </summary>
        /// <param name="node"></param>
        protected virtual void FillNodes(TreeNode node)
        {
            this.SuspendLayout();
            using (new Hourglass())
            {
                node.Nodes.Clear();
                FWFolder parentFolder = (FWFolder)node.Tag;

                IResultCache<FWSord> sords = null;

                if (subItemsListValue != null || ShowDocuments)
                {
                    sords = parentFolder.Sords;
                }
                else
                {
                    sords = parentFolder.Folders;
                }

                foreach (FWSord s in sords)
                {
                    if (!ShowDocuments && (s is FWDocument)) continue;
                    if (!ShowReferences && parentFolder.Id != s.ParentId) continue;

                    TreeNode tn = MakeTreeNode(parentFolder, s);
                    node.Nodes.Add(tn);
                }

                if (ShowDeletedElements)
                {
                    FWFindSordsCache<FWSord> res = GetDeletedSordsOf(parentFolder.Id);

                    if (res != null)
                    {
                        foreach (FWSord s in res)
                        {
                            AddDeletedSordToParent(node, s);
                        }
                    }
                }
            }
            this.ResumeLayout();
        }

        protected virtual FWFindSordsCache<FWSord> GetDeletedSordsOf(int parentFolderId)
        {
            if (parentFolderId < 0)
                return null;
            else
            {
                FindInfo fi = new FindInfo();
                FindChildren fc = new FindChildren();
                fc.parentId = Convert.ToString(parentFolderId);
                fc.endLevel = 1;
                fi.findChildren = fc;

                FindOptions fo = new FindOptions();
                fo.sortOrder = SortOrderC.ALPHA;
                fo.onlyDeleted = true;
                fi.findOptions = fo;

                return Conn.Content.FindSords(fi);
            }
        }

        protected virtual void AddDeletedSordToParent(TreeNode parentTNode, FWSord deletedSord)
        {
            if (parentTNode != null && deletedSord.Core.deleted)
            {
                // Loading parent folder to which deleted sord have to be add
                FWFolder parentFolder = GetSordFromNode(parentTNode) as FWFolder;
                if (parentFolder == null)
                    return;
                else
                {
                    if (!ShowDocuments && (deletedSord is FWDocument)) return;
                    if (!ShowReferences && parentFolder.Id != deletedSord.ParentId) return;

                    // Proove if deletedsord was alredy add to parent folder
                    bool sordAlredyExistsInParentFolder = false;
                    foreach (FWSord sordInParentFolder in parentFolder.Sords)
                    {
                        if (sordInParentFolder.Id == deletedSord.Id)
                        {
                            sordAlredyExistsInParentFolder = true;
                            break;
                        }
                    }

                    if (!sordAlredyExistsInParentFolder)
                    {
                        TreeNode tn = MakeTreeNode(parentFolder, deletedSord);
                        parentTNode.Nodes.Add(tn);
                    }
                }
            }
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

                //foreach (TreeNode node in parentNode.Nodes)
                //{
                //    if (node.Nodes.Count == 1 && node.Nodes[0].Name.Equals(DUMMY_CHILD_NAME))
                //    {
                //        //ThreadPool.QueueUserWorkItem(state =>
                //        //    {
                //        //        BeginInvoke((MethodInvoker)delegate
                //        //        {
                //        //            FillNodes(node);
                //        //        });
                //        //    });
                //        FillNodes(node);
                //    }
                //}
            }
        }

        protected override void OnAfterSelect(TreeViewEventArgs e)
        {
            UpdateSubItemsList(e.Node);
            base.OnAfterSelect(e);
        }

        protected virtual void UpdateSubItemsList(TreeNode node)
        {
            if (subItemsListValue != null && !lockSubItemsList)
            {
                FWSord sord = GetSordFromNode(node);
                if (sord is FWFolder)
                {
                    if (subItemsListValue.Conn == null)
                    {
                        subItemsListValue.Conn = Conn;
                    }

                    if (subItemsListValue.ShowDocuments && subItemsListValue.ShowFolders)
                    {
                        subItemsListValue.SordsCache = ((FWFolder)sord).Sords;
                    }
                    else if (subItemsListValue.ShowDocuments)
                    {
                        subItemsListValue.SordsCache = ((FWFolder)sord).Documents;
                    }
                    else if (subItemsListValue.ShowFolders)
                    {
                        subItemsListValue.SordsCache = ((FWFolder)sord).Folders;
                    }
                }
                else
                {
                    subItemsListValue.ObjectsCache = new FWResultCacheList<FWSord>();
                    subItemsListValue.SordsCache = new FWResultCacheList<FWSord>();
                }
            }
        }

        /// <summary>
        /// Opens the selected document.
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            MouseEventArgs mouseArgs = (MouseEventArgs)e;
            if (mouseArgs.Button == MouseButtons.Left && AllowOpenDocument)
            {

                using (new Hourglass())
                {
                    if (SelectedSord != null)
                    {
                        if (SelectedSord.IsDocument())
                        {
                            int encryptionSet = ((FWDocument)SelectedSord).Core.details.encryptionSet;
                            if (encryptionSet > 0 && SelectedSord.Conn.Session.EncrPasswords[encryptionSet.ToString()] == null)
                            {
                                string documentFile = FWSordUtils.GetDocumentFile(SelectedSord);
                                SelectedSord.Refresh();
                                RefreshNode(SelectedNode);
                                openDocumentHandler.OpenFile(documentFile);
                            }
                            else
                            {
                                openDocumentHandler.OpenFile(((FWDocument)SelectedSord).File);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Selected folder.
        /// </summary>
        /// <seealso cref="SelectedFolderNode"/>
        public virtual FWFolder SelectedFolder
        {
            get
            {
                FWFolder folder = (FWFolder)GetSordFromNode(SelectedFolderNode);
                return folder;
            }
        }

        /// <summary>
        /// Returns the selected node, if the node is a document. Otherwise it returns the parent node of the selected node.
        /// </summary>
        public virtual TreeNode SelectedFolderNode
        {
            get
            {
                TreeNode treeNode = this.SelectedNode;
                if (treeNode != null)
                {

                    FWSord selectedSord = GetSordFromNode(treeNode);
                    if (!(selectedSord is FWFolder))
                    {
                        treeNode = treeNode.Parent;
                    }
                }
                return treeNode;
            }
        }

        private TreeNode FindNodeByTextOrSordName(TreeNodeCollection nodes, string t)
        {
            TreeNode node = null;
            for (int j = 0; j < nodes.Count && node == null; j++)
            {
                TreeNode tnj = nodes[j];
                FWSord sord;

                if (tnj.Text.Equals(t) || ((sord = GetSordFromNode(tnj)) != null && sord.Name.Equals(t)))
                {
                    node = tnj;
                }
            }
            return node;
        }

        protected TreeNode FindNodeByArcPath(string arcPath)
        {
            TreeNode lastNode = null;

            IEnumerable<string> path = arcPath.Split(PATH_DELIM.ToCharArray());

            TreeNodeCollection lastNodeChildren = this.Nodes;

            foreach (string s in path)
            {
                if (string.IsNullOrEmpty(s))
                    continue;

                lastNode = FindNodeByTextOrSordName(lastNodeChildren, s);
                if (lastNode == null)
                    break;


                lastNodeChildren = lastNode.Nodes;
            }

            return lastNode;
        }

        protected virtual IEnumerable<String> GetSelectedNodePath()
        {
            // TreeNode.FullPath verwendet BS als Trennner. Deshalb 
            // mache ich das hier als Liste, damit BS in Stichwörtern verwendet werden können.
            LinkedList<String> path = new LinkedList<String>();
            TreeNode tn = this.SelectedNode;
            while (tn != null)
            {
                path.AddFirst(tn.Text);
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

        protected virtual void SelectNodePath(IEnumerable<String> path)
        {
            TreeNode lastNode = null;
            TreeNodeCollection lastNodeChildren = this.Nodes;
            foreach (String s in path)
            {
                if (s == null || s.Length == 0) continue;
                lastNode = FindNodeByText(lastNodeChildren, s);
                if (lastNode == null) break;

                // HACK: OnBeforeExpand is not fired, so call it explicitly
                TreeViewCancelEventArgs tvcea = new TreeViewCancelEventArgs(lastNode, false, TreeViewAction.Expand);
                OnBeforeExpand(tvcea);
                lastNode.Expand();
                lastNodeChildren = lastNode.Nodes;
            }

            if (lastNode != null)
            {
                this.SelectedNode = lastNode;
            }
        }

        /// <summary>
        /// Prüft ob das in der Vorschau anzuzeigende Dokument verschlüsselt ist oder nicht.
        /// </summary>
        /// <param name="document">Dokument, bei dem überprüft werden soll, ob es verschlüsselt ist oder nicht.</param>
        /// <returns>
        /// True wenn das Dokument verschlüsselt ist, sonst false
        /// </returns>
        protected virtual bool ProoveIfEncryptedDocument(FWSord sord)
        {
            FWDocument document = sord as FWDocument;

            bool existsDocument = (document != null);
            bool isEncrypted = false;

            try
            {
                if (existsDocument)
                {
                    // Prüfen ob Dokument verschlüsselt ist
                    int encryptionSet = document.Core.details.encryptionSet;
                    if (encryptionSet > 0)
                        isEncrypted = true;
                }
            }
            catch (Exception ex)
            {
                
            }

            return isEncrypted;
        }

        #region Checkin Documents

        /// <summary>
        /// Called after a document is checked in and addes a node for the document.
        /// </summary>
        /// <param name="e">CheckinEventArgs object</param>
        protected virtual void OnAfterCheckin(CheckinEventArgs e)
        {
            // ... add a new child node for the new Sord object
            TreeNode parentNode = SelectedFolderNode;
            FWSord parentSord = GetSordFromNode(SelectedFolderNode);
            if (parentSord != null) // should always be <> null
            {
                ((FWFolder)parentSord).ResetChildren();
                FillNodes(parentNode);
                UpdateSubItemsList(parentNode);
                parentNode.Expand();
            }
            if (AfterCheckin != null)
            {
                AfterCheckin(e);
            }
        }

        /// <summary>
        /// Called before a document is checked in.
        /// </summary>
        /// <param name="e">CheckinEventArgs object</param>
        protected virtual void OnBeforeCheckin(CheckinEventArgs e)
        {
            if (BeforeCheckin != null)
            {
                BeforeCheckin(e);
            }
        }

        /// <summary>
        /// Checkin the documents contained in the given IDataObject. 
        /// </summary>
        /// <param name="dataObject">IDataObject object</param>
        /// <remarks>
        /// This function is called from the Drag &amp; Drop handlers.
        /// It passes the SelectedFolder and the IDataObject to the 
        /// CheckinDocumentHandler.
        /// </remarks>
        /// <seealso cref="DocumentDataObject"/>
        protected virtual void OnCheckin(IDataObject dataObject)
        {
            documentDataObject.Checkin(SelectedFolder, dataObject);
        }

        void checkinObj_AfterCheckin(CheckinEventArgs e)
        {
            OnAfterCheckin(e);
        }

        void checkinObj_BeforeCheckin(CheckinEventArgs e)
        {
            OnBeforeCheckin(e);
        }

        #endregion

        #region DragNDrop

        /// <summary>
        /// This variable counts the number of ticks where the mouse is 
        /// hold on the same position while a file is dragged into the tree.
        /// </summary>
        /// <remarks>
        /// If the mouse is hold over a folder for some time, the folder object
        /// is expanded. If the mouse is hold at the top or at the bottom of
        /// the tree, the tree is scrolled up resp. down.
        /// </remarks>
        protected int dragOverSamePos = 0;
        /// <summary>
        /// If the mouse is hold for this number of ticks at the top or bottom of 
        /// the tree, the tree is scolled up resp. down.  
        /// </summary>
        /// <remarks>
        /// This value starts with dragOverScrollThresholdStart and is decremented
        /// at each tick - as long as the mouse is hold - to accelerate scrolling. 
        /// </remarks>
        /// <seealso cref="dragOverScrollThresholdStart"/>
        protected int dragOverScrollThreshold = 4;
        /// <summary>
        /// Start value for <see cref="dragOverScrollThreshold"/>
        /// </summary>
        protected int dragOverScrollThresholdStart = 5;
        /// <summary>
        /// If the mouse is hold for this number of ticks over a folder object, 
        /// the node is expanded.
        /// </summary>
        protected int dragOverExpandThreshold = 10;
        /// <summary>
        /// This value stores the last mouse point to detect whether the mouse is
        /// hold and not moved.
        /// </summary>
        protected Point dragOverLastPoint = new Point();

        /// <summary>
        /// Detect the drag and drop effects.
        /// </summary>
        /// <param name="e">DragEventArgs object</param>
        /// <returns>True, if drag and drop is allowed.</returns>
        protected virtual bool detectDragDropEffects(DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (AllowDrop && SelectedFolder != null)
            {
                bool fromTree = e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false);
                if (fromTree)
                {
                    // Moving or copying tree nodes is not supported
                    if (e.Data.GetDataPresent(typeof(TreeNode)))
                    {
                        // Strg-Taste gedrück? Prüfung über Bitmaske:
                        if ((e.KeyState & 8) == 8)
                            e.Effect = DragDropEffects.Copy;
                        // nur linke Maustaste
                        else
                            e.Effect = DragDropEffects.Move;
                    }
                    //e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
                }
                else if (documentDataObject.IsFile(e.Data))
                {
                    e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
                }
            }
            return e.Effect != DragDropEffects.None;
        }
        /// <summary>
        /// The mouse is dragged into the tree view.
        /// </summary>
        /// <param name="e">DragEventArgs object</param>
        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
            detectDragDropEffects(e);
        }

        /// <summary>
        /// The mouse is dropped into the tree view.
        /// </summary>
        /// <param name="e">DragEventArgs object</param>
        protected override void OnDragDrop(DragEventArgs e)
        {
            if (previousTNode != null && previousTNode != SelectedNode)
            {
                previousTNode.BackColor = SystemColors.HighlightText;
                previousTNode.ForeColor = SystemColors.ControlText;
                previousTNode = null;
            }

            if (AllowDrop)
            {
                using (new Hourglass())
                {
                    // Is a TreeView item dragged? - this is currently not supported.
                    bool fromTree = e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false);
                    if (fromTree)
                    {
                        Point pt = PointToClient(new Point(e.X, e.Y));
                        TreeNode DestinationNode = GetNodeAt(pt);
                        TreeNode newNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                        if (newNode == null)
                            return;

                        TreeNode parentNode = newNode.Parent;

                        if (DestinationNode == null)
                            return;

                        FWSord destinationSord = GetSordFromNode(DestinationNode);
                        if (destinationSord == null)
                            return;

                        FWSord newSord = GetSordFromNode(newNode);
                        if (newSord == null)
                            return;

                        FWSord oldParentSord = GetSordFromNode(parentNode);

                        if (destinationSord.IsDocument())
                        {
                            destinationSord = GetSordFromNode(DestinationNode.Parent);
                        }

                        if (oldParentSord.Guid == destinationSord.Guid)
                            return;

                        if (e.Effect == DragDropEffects.Copy)
                        {
                            newSord.Copy(destinationSord);
                            RefreshNode(DestinationNode);

                            RaiseDocumentDropped(DropOperationType.Copy, newSord as FWDocument, destinationSord as FWFolder, oldParentSord as FWFolder);
                        }
                        if (e.Effect == DragDropEffects.Move)
                        {
                            newSord.Move(oldParentSord, destinationSord);
                            RefreshNode(parentNode);
                            RefreshNode(DestinationNode);

                            RaiseDocumentDropped(DropOperationType.Move, newSord as FWDocument, destinationSord as FWFolder, oldParentSord as FWFolder);
                        }

                    }
                    else
                    {
                        Point pt = PointToClient(new Point(e.X, e.Y));
                        //TreeNode DestinationNode = GetNodeAt(pt);
                        //if (DestinationNode == null)
                        //    return;

                        //FWSord destinationSord = GetSordFromNode(DestinationNode);
                        //if (destinationSord == null)
                        //    return;

                        //FWFolder destinationFolder = null;
                        //if (destinationSord.IsDocument())
                        //{
                        //    DestinationNode = DestinationNode.Parent;
                        //    if (DestinationNode == null)
                        //        return;
                        //    destinationFolder = GetSordFromNode(DestinationNode) as FWFolder;
                        //}
                        //else
                        //{
                        //    destinationFolder = destinationSord as FWFolder;
                        //}

                        //if (destinationFolder == null)
                        //    return;

                        FWFolder destinationFolder = GetDropTargetFolder(pt);
                        if (null == destinationFolder)
                            return;
                        documentDataObject.Checkin(destinationFolder, e.Data);

                        //OnCheckin(e.Data);
                        //DestinationNode.Expand();
                        RaiseDocumentDropped(DropOperationType.Add, null, destinationFolder);
                    }
                }
            }
        }

        protected FWFolder GetDropTargetFolder(Point pt)
        {
            TreeNode DestinationNode = GetNodeAt(pt);
            if (DestinationNode == null)
                return null;

            FWSord destinationSord = GetSordFromNode(DestinationNode);
            if (destinationSord == null)
                return null;

            FWFolder destinationFolder = null;
            if (destinationSord.IsDocument())
            {
                DestinationNode = DestinationNode.Parent;
                if (DestinationNode == null)
                    return null;
                destinationFolder = GetSordFromNode(DestinationNode) as FWFolder;
            }
            else
            {
                destinationFolder = destinationSord as FWFolder;
            }

            //if (destinationFolder == null)
            //    return null;

            return destinationFolder;
        }

        /// <summary>
        /// Is called, when a TreeViewNode is started to be dragged.
        /// </summary>
        /// <param name="e">EventArgs object</param>
        protected override void OnItemDrag(ItemDragEventArgs e)
        {
            if (AllowDrag)
            {
                // get the related Sord object
                TreeNode node = (TreeNode)e.Item;
                FWSord sord = GetSordFromNode(node);
                //if (sord.IsDocument())
                //{
                //    documentDataObject.DoDragDrop(this, sord, e.Item, DragDropEffects.Copy);
                //}
                //else
                //{
                DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);
                //}
            }
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);

            if (previousTNode != null && previousTNode != SelectedNode)
            {
                previousTNode.BackColor = SystemColors.HighlightText;
                previousTNode.ForeColor = SystemColors.ControlText;
                previousTNode = null;
            }
        }

        protected TreeNode previousTNode;
        protected TreeNode actSelectedTNode;

        /// <summary>
        /// Called periodically during a drag operation.
        /// </summary>
        /// <param name="e">EventArgs e</param>
        protected override void OnDragOver(DragEventArgs e)
        {
            lockSubItemsList = true;

            detectDragDropEffects(e);

            // transform the mouse point into client coordinates
            Point p = this.PointToClient(new Point(e.X, e.Y));

            ///////////////////////////////////////////////////////////
            // Detect wether the mouse was moved. 

            // if the mouse was not moved...
            if (dragOverLastPoint.Equals(p))
            {
                // ... increment the counter 
                dragOverSamePos++;
            }
            else
            {
                // if the mouse is moved, reset the counter
                dragOverSamePos = 0;
                dragOverScrollThreshold = dragOverScrollThresholdStart;
            }

            ///////////////////////////////////////////////////////////
            // Detect wether the tree view shold scroll 

            // We need to know later, if the tree was scrolled. 
            // In this case, we do not want to expand a folder node.
            bool hasScrolled = false;

            // Is the mouse hold long enough over the same position...
            if (dragOverSamePos >= dragOverScrollThreshold)
            {
                // scroll up, if the mouse is near the top of the tree view
                bool up = p.Y <= this.ItemHeight;
                // scroll down, if the mouse is near the bottom of the tree view
                bool down = p.Y >= this.Bottom - this.ItemHeight - 5;

                // get the current scroll position via Windows API 
                TreeViewHelper.ScrollInfoStruct si = new TreeViewHelper.ScrollInfoStruct();
                TreeViewHelper.GetScrollPosition(this, ref si);

                // will be set to +1 or -1 to scroll the tree view
                int scrollIncrement = 0;

                if (up && si.nPos > si.nMin)
                {
                    // scroll up, if the mouse is at the top and the scroll position 
                    // can be decreased.
                    scrollIncrement = -1;
                }
                else if (down && si.nPos < si.nMax)
                {
                    // scroll down, if the mouse is at the bottom and the scroll position 
                    // can be increased.
                    scrollIncrement = +1;
                }

                // scroll tree?
                if (scrollIncrement != 0)
                {
                    // scroll 
                    ScrollTreeView(scrollIncrement);
                    // decrement the threshold so that the next scrolling is performed
                    // earlier - as long as the mouse is over the same point.
                    dragOverScrollThreshold = Math.Max(0, dragOverScrollThreshold - 1);
                    // start counting 
                    dragOverSamePos = 0;

                    // this prevents expanding a folder node - see below
                    hasScrolled = true;
                }
            }

            /////////////////////////////////////////////////////////////
            // If the mouse is hold over a folder, the node is expanded

            // Expansion is inhibited, if the tree was scrolled before.
            if (!hasScrolled)
            {
                // get the node under the mouse pointer
                TreeNode dest = this.GetNodeAt(p);
                if (dest != null)
                {
                    // select this node
                    if (previousTNode != null && previousTNode != dest)
                    {
                        previousTNode.BackColor = SystemColors.HighlightText;
                        previousTNode.ForeColor = SystemColors.ControlText;
                        previousTNode = null;
                    }

                    if (dest != previousTNode)
                    {
                        dest.BackColor = SystemColors.Highlight;
                        dest.ForeColor = SystemColors.HighlightText;
                        previousTNode = dest;
                    }
                    //this.SelectedNode = dest;

                    // check wether the mouse is hold for a long time on the same position
                    if (dragOverSamePos >= dragOverExpandThreshold)
                    {
                        // expand the node
                        dest.Expand();
                        // start counting
                        dragOverSamePos = 0;
                    }
                }

            }

            // store the supplied point to be able to compare it with the mouse point 
            // the next time the function is called.
            dragOverLastPoint = p;

            lockSubItemsList = false;
        }

        /// <summary>
        /// Scrolls the tree view by the given amout of scrolling positions.
        /// </summary>
        /// <param name="scrollIncrement">Scroll positions</param>
        protected virtual void ScrollTreeView(int scrollIncrement)
        {
            TreeViewHelper.ScrollInfoStruct si = new TreeViewHelper.ScrollInfoStruct();
            TreeViewHelper.GetScrollPosition(this, ref si);
            si.nPos = Math.Max(si.nMin, si.nPos + scrollIncrement);
            TreeViewHelper.ScrollToPosition(this, si);
        }

        #endregion

        #region Add and Delete

        /// <summary>
        /// Add a new folder below the selected node. 
        /// </summary>
        /// <param name="parentNode">Parent node</param>
        /// <remarks>The TreeView must have LabelEdit=true.</remarks>
        public void NewFolder(bool labelEditing = true)
        {
            NewFolder(SelectedNode);
        }

        /// <summary>
        /// Add a new folder below the given parent node. 
        /// </summary>
        /// <param name="parentNode">Parent node</param>
        /// <remarks>The TreeView must have LabelEdit=true.</remarks>
        public virtual void NewFolder(TreeNode parentNode, bool labelEditing = true)
        {
            if (!this.LabelEdit) return;

            FWSord parentSord = GetSordFromNode(parentNode);
            if (parentSord == null) return;
            if (!parentNode.IsExpanded)
            {
                parentNode.Expand();
            }

            FWFolder sord = Conn.Content.CreateFolder(parentSord.Guid, Conn.Session.UserProfile.DefaultFolderMaskId);
            sord.Name = Properties.Resources.NewFolderName;

            TreeNode node = MakeTreeNode(parentSord, sord);
            parentNode.Nodes.Add(node);

            

            SelectedNode = node;

            if (labelEditing)
                SelectedNode.BeginEdit();
        }

        public void BeginEditSordName(TreeNode node)
        {
            SelectedNode = node;
            node.BeginEdit();
        }

        public void BeginEditSordName()
        {
            SelectedNode.BeginEdit();
        }

        protected override void OnAfterLabelEdit(NodeLabelEditEventArgs e)
        {
            FWSord sord = GetSordFromNode(e.Node);
            if (sord == null) return;

            bool editSucc = (e.Label != null && e.Label.Length != 0) || (e.Node != null && !string.IsNullOrEmpty(e.Node.Text));
            string oldLabel = sord.Name;

            if (editSucc)
            {
                if (e.Label != null && e.Label.Length != 0)
                    sord.Name = e.Label;
                else
                    sord.Name = e.Node.Text;

                try
                {
                    sord.Checkin();
                    e.Node.EndEdit(false);
                    SelectedNode = e.Node;
                }
                catch (Exception ex)
                {
                    IXExceptionData exceptionData = connVal.Ix.parseException(ex.Message);
                    bool isIxException = connVal.IsException(ex, exceptionData.exceptionType);

                    if (isIxException)
                    {
                        System.Windows.Forms.MessageBox.Show(
                        exceptionData.message + "\n" + exceptionData.details, "ELO Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                        ex.ToString(),
                        EloixClientUI.Properties.Resources.MsgBoxConfirm,
                        MessageBoxButtons.OK);
                    }

                    editSucc = false;
                }
            }

            if (!editSucc)
            {
                e.Node.Text = oldLabel;
                e.CancelEdit = true;
                if (sord.Id < 0)
                {
                    e.Node.Remove();
                }
            }

        }

        public void DeleteSord(TreeNode node)
        {
            FWSord sord = GetSordFromNode(node);
            if (sord == null) return;

            TreeNode parentNode = null;
            bool hasSordSubElements = (!sord.IsDocument() && ((FWFolder)sord).Sords != null && ((FWFolder)sord).Sords.Count > 0);

            DialogResult queryDeleteMsgDialogResult = DialogResult.No;
            if (hasSordSubElements)
                queryDeleteMsgDialogResult = MessageBox.Show(Properties.Resources.QueryDeleteItemAndAllSubItems, Properties.Resources.MsgBoxConfirm, MessageBoxButtons.YesNo);
            else
                queryDeleteMsgDialogResult = MessageBox.Show(Properties.Resources.QueryDelete, Properties.Resources.MsgBoxConfirm, MessageBoxButtons.YesNo);

            if (queryDeleteMsgDialogResult == DialogResult.Yes)
            {
                if (sord.IsDocument())
                    parentNode = node.Parent;

                sord.Delete();
                node.Remove();

                if (null != parentNode)
                    RefreshNode(parentNode);
            }
        }

        public void DeleteSord()
        {
            //FWSord sord = GetSordFromNode(SelectedNode);
            //if (sord == null) return;

            //TreeNode parentNode = null;

            //if (MessageBox.Show(Properties.Resources.QueryDelete, Properties.Resources.MsgBoxConfirm, MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    if (sord.IsDocument())
            //    {
            //        parentNode = SelectedNode.Parent;
            //    }

            //  sord.Delete();
            //  SelectedNode.Remove();


            //  if (null != parentNode)
            //      RefreshNode(parentNode);
            //}
            DeleteSord(SelectedNode);
        }

        #endregion

        /// <summary>
        /// Returns an absolute archive path for the given combination of ArcPath and sordName.
        /// </summary>
        /// <param name="arcPath">The ArcPath of the node</param>
        /// <param name="sordId">The ID of the Sord object (regardless if the path will point to the main sord or a reference node).</param>
        /// <param name="sordName">The name of the Sord object.</param>
        /// <param name="rootFolderName">The name of the root folder (Archive).</param>
        /// <returns>Absolute path</returns>
        public virtual string GetAbsoluteArcPathString(ArcPath arcPath, int sordId, string sordName, string rootFolderName)
        {
            return GetAbsoluteArcPathString(arcPath, sordId, sordName, rootFolderName, PATH_DELIM);
        }

        /// <summary>
        /// Returns an absolute archive path for the given combination of ArcPath and sordName.
        /// </summary>
        /// <param name="arcPath">The ArcPath of the node</param>
        /// <param name="sordId">The ID of the Sord object (regardless if the path will point to the main sord or a reference node).</param>
        /// <param name="sordName">The name of the Sord object.</param>
        /// <param name="rootFolderName">The name of the root folder (Archive).</param>
        /// <param name="pathDelimiter">The path delimiter to use.</param>
        /// <returns>Absolute path</returns>
        public virtual string GetAbsoluteArcPathString(ArcPath arcPath, int sordId, string sordName, string rootFolderName, string pathDelimiter)
        {
            string absoluteArcPathString = null;

            string path = pathDelimiter;

            if (arcPath != null && arcPath.path != null && arcPath.path.Length > 0)
            {
                foreach (IdName idName in arcPath.path)
                {
                    path += idName.name + pathDelimiter;
                }
            }

            if (sordId == 1)
                // Ganzer Pfad zu dem Dokument
                absoluteArcPathString = pathDelimiter + sordName;
            else
                // Ganzer Pfad zu dem Dokument
                absoluteArcPathString = pathDelimiter + rootFolderName + path + sordName;

            return absoluteArcPathString;
        }

        public virtual string GetAbsoluteArcPathString(FWSord sord)
        {
            return GetAbsoluteArcPathString(sord, PATH_DELIM);
        }

        public virtual string GetAbsoluteArcPathString(FWSord sord, string pathDelimiter)
        {
            string path = GetAbsoluteArcPathString(sord.RefPaths[0], sord.Id, sord.Name, sord.Conn.Content.RootFolder.Name, pathDelimiter);
            return path;
        }

        protected Dictionary<int, bool> SaveTreeState(TreeNode node)
        {
            Dictionary<int, bool> nodeStates = new Dictionary<int, bool>();
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Nodes.Count > 0)
                {
                    FWSord sord = GetSordFromNode(node.Nodes[i]);
                    nodeStates.Add(sord.Id, node.Nodes[i].IsExpanded);
                }
            }

            return nodeStates;
        }

        protected void RestoreTreeState(TreeNode node, Dictionary<int, bool> treeState)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                FWSord sord = GetSordFromNode(node.Nodes[i]);
                if (treeState.ContainsKey(sord.Id))
                {
                    if (treeState[sord.Id])
                        node.Nodes[i].Expand();
                    else
                        node.Nodes[i].Collapse();
                }
            }

        }

        public event EventHandler<DocumentDroppedEventArgs> DocumentDropped;

        protected virtual void RaiseDocumentDropped(DropOperationType dropOperationType,
            FWDocument document, FWFolder newFolder, FWFolder oldFolder = null)
        {
            EventHandler<DocumentDroppedEventArgs> handler = DocumentDropped;
            if (handler != null)
            {
                handler(this, new DocumentDroppedEventArgs(dropOperationType,
                    document, newFolder, oldFolder));
            }
        }
    }

    public enum DropOperationType
    {
        Add,
        Move,
        Copy
    }

    public class DocumentDroppedEventArgs : EventArgs
    {
        public DocumentDroppedEventArgs(
            DropOperationType dropOperation,
            FWDocument document,
            FWFolder newParent,
            FWFolder oldParent = null)
        {
            DropOperation = dropOperation;
            Document = document;
            NewParent = newParent;
            OldParent = oldParent;
        }

        public FWDocument Document { get; private set; }
        public FWFolder NewParent { get; private set; }
        public FWFolder OldParent { get; private set; }
        public DropOperationType DropOperation { get; private set; }
    }
}

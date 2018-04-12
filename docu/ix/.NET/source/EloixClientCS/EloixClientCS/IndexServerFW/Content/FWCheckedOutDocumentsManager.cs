using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


using EloixClient.Common;


namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// The class FWCheckedOutDocumentsManager offers functionality for management of checked out documents.
    /// </summary>
    public class FWCheckedOutDocumentsManager : FWContentBase, IFWCheckedOutDocumentsManager
    {
        /// <summary>
        /// Contains path to directory with checked out documents.
        /// </summary>
        protected string checkOutDir;

        /// <summary>
        /// Contains a list of forbidden characters in the windows file system.
        /// </summary>
        protected static String FORBIDDEN_FILESYSTEM_CHARS = "/:\"|*?<>\\";

        /// <summary>
        /// Contains a reference to list with replacement character for each forbidden character in a file name.
        /// </summary>
        protected Dictionary<char, char> replacementCharsForForbiddenChars;

        /// <summary>
        /// Helper variable that counts the calls to cleanup.
        /// </summary>
        protected int cleanupCounter;

        /// <summary>
        /// Contains a reference to an instance of class FileSystemWatcher, which will be used to detect if
        /// any entry of directory for checked out documents has changed.
        /// </summary>
        protected FileSystemWatcher checkOutDirectoryFWatcher;














        #region Initialization
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="checkOutDir">Path to directory with checked out documents.</param>
        public FWCheckedOutDocumentsManager(FWContentInterface contentInterface, string checkOutDir) : base(contentInterface)
        {
            bool existsCheckOutDir = (!string.IsNullOrEmpty(checkOutDir) && Directory.Exists(checkOutDir));
            if (!existsCheckOutDir)
                throw new InvalidOperationException("Initialization of manager for checked out documents was not possible. Checkout directory was not found or does not exists.");
            else
                this.checkOutDir = checkOutDir;

            replacementCharsForForbiddenChars = new Dictionary<char, char>();
            for (int i = 0; i < FORBIDDEN_FILESYSTEM_CHARS.Length; i++)
            {
                replacementCharsForForbiddenChars.Add(FORBIDDEN_FILESYSTEM_CHARS[i], '_');
            }

            // Initialize filesystemwatcher for monitoring of changes in directory for checked out documents
            InitializeFileSystemWatcherForMonintoringCheckOutDir(checkOutDir);
        }
        #endregion















        #region IFWCheckedoutDocumentsManager Members

        /// <summary>
        /// Occures when entries of checkout directory have been changed. 
        /// </summary>
        public event EventHandler CheckOutDirectoryEntriesChanged;

        /// <summary>
        /// Occures when new checked out document was created in a checkout directory.
        /// </summary>
        public event EventHandler NewCheckedOutDocument;

        /// <summary>
        /// Occures if all state and checkout file were removed from checkout directory or only a state file, if deleting of checkout file fails.
        /// </summary>
        public event EventHandler CheckedOutDocumentRemoved;

        /// <summary>
        /// Deletes after sitxtieth call all not more checked out documents in a checkout directory. A document is not more checked out if state file for a
        /// specific document not more exists in a checkout directory.
        /// </summary>
        public void Cleanup()
        {
            // Function is called every second. But check only every minute.
            if (Interlocked.Increment(ref cleanupCounter) != 60) return;
            cleanupCounter = 0;

            ForceCleanup();
        }

        /// <summary>
        /// Deletes imediatelly all not more checked out documents in a checkout directory. A document is not more checked out if state file for a
        /// specific document not more exists in a checkout directory.
        /// </summary>
        public void ForceCleanup()
        {
            bool existsCheckOutDirectory = (!string.IsNullOrEmpty(checkOutDir) && Directory.Exists(checkOutDir));
            if (existsCheckOutDirectory)
            {
                string[] checkOutDirectoryFiles   = Directory.GetFiles(checkOutDir);
                bool existsCheckOutDirectoryFiles = (checkOutDirectoryFiles != null && checkOutDirectoryFiles.Length > 0);

                if (existsCheckOutDirectoryFiles)
                {
                    foreach (string checkedOutFile in checkOutDirectoryFiles)
                    {
                        try
                        {
                            bool existsStateFileForCheckedOutFile = ExistsStateFileForFile(checkedOutFile);
                            if (!existsStateFileForCheckedOutFile)
                            {
                                FileInfo fInfo = new FileInfo(checkedOutFile);
                                if (fInfo.Exists && !fInfo.Extension.Equals(".state") && !fInfo.Attributes.HasFlag(FileAttributes.Hidden))
                                {
                                    fInfo.Attributes = FileAttributes.Normal;
                                    fInfo.Delete();
                                }
                            }
                            else
                            {
                                // Proove if document with specific id exists in archive, if not delete a checked out file
                                StateFile stateFile = new StateFile(checkedOutFile + ".state");
                                if (stateFile.ObjectId.HasValue)
                                {
                                    FWDocument document = Conn.Content.TryGetDocument(stateFile.ObjectId.Value.ToString(), Utils.FWAccessModes.Nothing);
                                    if (document == null)
                                    {
                                        FileInfo fInfo = new FileInfo(checkedOutFile + ".state");
                                        if (fInfo.Exists)
                                        {
                                            fInfo.Attributes = FileAttributes.Normal;
                                            fInfo.Delete();
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
        }

        /// <summary>
        /// Returns back only list with checked out documents, which end whith one of the extensions passed by the parameter allowedExtensionsa all other
        /// checked out documents will not be returned back. Only documents with state file and lockid value unequal -1 in the state file are
        /// valid checked out documents and will be returned back.
        /// </summary>
        /// <param name="allowedExtensions">
        /// List of file extensions, with which checked out documents must end to be returned back.
        /// </param>
        /// <returns>
        /// List of checked out documents, which end with file extensions passed by the parameter allowedExtensions.
        /// </returns>
        public string[] GetCheckedoutFiles(params string[] allowedExtensions)
        {
            List<string> checkedoutFileNames = new List<string>();
            bool existsAllowedExtensions     = (allowedExtensions != null && allowedExtensions.Length > 0);

            if (existsAllowedExtensions)
            {
                List<string> extensions               = new List<string>(allowedExtensions);
                IList<FWDocument> checkedOutDocuments = GetCheckedOutDocuments();
                if (checkedOutDocuments != null)
                {
                    foreach (FWDocument checkedOutDocument in checkedOutDocuments)
                    {
                        try
                        {
                            string fileExt = Path.GetExtension(checkedOutDocument.CheckedoutFile);
                            
                            // Remove dot, if fileextension starts with it
                            if (fileExt.StartsWith("."))
                                fileExt = fileExt.Substring(1);

                            int index = extensions.FindIndex(delegate(string element)
                            {
                                return (0 == string.Compare(fileExt, element, StringComparison.OrdinalIgnoreCase));
                            });

                            if (index >= 0 )
                                checkedoutFileNames.Add(checkedOutDocument.CheckedoutFile);
                        }
                        catch { }
                    }
                }
            }

            return checkedoutFileNames.ToArray();
        }

        /// <summary>
        /// Returns list of checked out documents. Only documents with state file and lockid value unequal -1 in the state file are
        /// valid checked out documents and will be returned back.
        /// </summary>
        /// <returns>
        /// List of checked out documents.
        /// </returns>
        public IList<FWDocument> GetCheckedOutDocuments()
        {
            IList<FWDocument> checkedOutDocs = new List<FWDocument>();

            try
            {
                // Load all checked out files, which have a state file. Only this files are valid.
                string[] checkedOutFilesWithStateFile = GetCheckedOutFilesWithStateFile(checkOutDir);
                bool existsCheckedOutFiles            = (checkedOutFilesWithStateFile != null && checkedOutFilesWithStateFile.Length > 0);

                if (existsCheckedOutFiles)
                {
                    // This dictionary will be used to proove if checked out document exists more than one time
                    Dictionary<int, FWDocument> checkedOutDocsIdsDictionary = new Dictionary<int, FWDocument>();

                    foreach (string checkedOutFilePath in checkedOutFilesWithStateFile)
                    {
                        try
                        {
                            bool existsCheckedOutFile = (!string.IsNullOrEmpty(checkedOutFilePath) && File.Exists(checkedOutFilePath));
                            if (existsCheckedOutFile)
                            {
                                // Load state file that belongs to a specific checked out file
                                StateFile stateFile = new StateFile(checkedOutFilePath + ".state");

                                if (stateFile.ObjectId.HasValue && stateFile.LockId.HasValue)
                                {
                                    if (stateFile.LockId.Value != -1 && stateFile.LockId.Value == Conn.Session.User.id)
                                    {
                                        FWDocument checkedOutDocument = Conn.Content.GetDocument(stateFile.ObjectId.Value);
                                        if (checkedOutDocument != null)
                                        {
                                            if (!checkedOutDocsIdsDictionary.ContainsKey(checkedOutDocument.Id))
                                            {
                                                checkedOutDocsIdsDictionary.Add(checkedOutDocument.Id, checkedOutDocument);
                                                checkedOutDocs.Add(checkedOutDocument);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }

            return checkedOutDocs;
        }

        /// <summary>
        /// Return a FWDocument for the given file.
        /// </summary>
        /// <param name="file">Controlled file</param>
        /// <returns>FWDocument object</returns>
        public virtual FWDocument GetFWDocumentFromFile(string file)
        {
            FWDocument doc = null;
            if (IsControlledFile(file))
            {
                string objId, docId;
                if (GetIdFromFileName(file, out objId, out docId))
                {
                    doc = ifc.Conn.Content.GetDocument(objId);

                    // Wenn die Datei mit AttachNewDocumentWorkFile einem Dokument zugewiesen wurde,
                    // dann ist sie nicht im doc.File eingetragen. 
                    doc.File = file;
                }
            }
            return doc;
        }

        /// <summary>
        /// Returns back a path to the checked out file of specific document. Only if state file exists for a specific document a path
        /// to the checkedout file will be returned back.
        /// </summary>
        /// <param name="document">Reference to document for that path to checked out document have to be returned back.</param>
        /// <returns>
        /// Path to the checked out file or null if no one exists for a specific document.
        /// </returns>
        public string GetCheckedOutFileOf(FWDocument document)
        {
            string filePath     = null;
            bool existsDocument = (document != null);
            if (existsDocument)
            {
                string[]checkedOutFiles    = GetCheckedOutFilesWithStateFile(checkOutDir);
                bool existsCheckedOutFiles = (checkedOutFiles != null && checkedOutFiles.Length > 0);
                if (existsCheckedOutFiles)
                {
                    foreach (string file in checkedOutFiles)
                    {
                        try
                        {
                            // Load state file that belongs to a specific checked out file
                            StateFile stateFile = new StateFile(file + ".state");

                            if (stateFile.ObjectId.HasValue && stateFile.LockId.HasValue)
                            {
                                if (stateFile.LockId.Value != -1 && stateFile.LockId.Value == Conn.Session.User.id && stateFile.ObjectId == document.Id)
                                {
                                    filePath = file;
                                    break;
                                }
                            }
                        }
                        catch { }
                    }
                }
            }

            return filePath;
        }

        /// <summary>
        /// Deletes checked out and state file of selected document if any of them exists. Only for no more locked document
        /// checked out and state file can be deleted.
        /// </summary>
        /// <param name="document">Document, for that checked out and state file have to be deleted in checkout directory.</param>
        public void RemoveCheckedOutDocumentFiles(FWDocument document)
        {
            bool existsDocument          = (document != null);
            bool existsCheckOutDirectory = (!string.IsNullOrEmpty(checkOutDir) && Directory.Exists(checkOutDir));

            if (existsDocument && document.LockId == -1)
            {
                string[] checkedOutFiles   = GetCheckedOutFilesWithStateFile(checkOutDir);
                bool existsCheckedOutFiles = (checkedOutFiles != null && checkedOutFiles.Length > 0);
                if (existsCheckedOutFiles)
                {
                    foreach (string file in checkedOutFiles)
                    {
                        bool isStateFileDeleted = false;

                        try
                        {
                            // Load state file that belongs to a specific checked out file
                            StateFile stateFile = new StateFile(file + ".state");

                            if (stateFile.ObjectId.HasValue && stateFile.ObjectId == document.Id && stateFile.LockId == Conn.Session.User.id)
                            {
                                FileInfo stateFileInfo = new FileInfo(file + ".state");
                                if (stateFileInfo.Exists)
                                {
                                    stateFileInfo.Attributes = FileAttributes.Normal;
                                    stateFileInfo.Delete();

                                    isStateFileDeleted = true;

                                    // Issue event
                                    OnCheckedOutDocumentRemoved(new EventArgs());
                                }
                            }
                        }
                        catch { }

                        if (isStateFileDeleted)
                            break;
                    }
                }

                // Delete all files which dont have a state file
                ForceCleanup();
            }
        }

        /// <summary>
        /// Checks out a selected document and returns back result of checkout. While checkout of selected document checked out and state file will be created in
        /// checkout directory. 
        /// </summary>
        /// <param name="document">Document, that have to be checked out.</param>
        /// <returns>
        /// Result of checkout operation.
        /// </returns>
        public CheckoutResult Checkout(FWDocument document)
        {
            CheckoutResult checkOutResult = new CheckoutResult() { FWDocument = document, Success = false };

            try
            {
                bool existsDocForCheckOut = (document != null);
                bool existsDocUrl         = (document != null && document.Version != null && !string.IsNullOrEmpty(document.Version.Url));
                bool existsIxConn         = (document.Conn != null);

                if (existsDocForCheckOut && existsDocUrl && existsIxConn)
                {
                    // Delete not more checked out documents in checkout directory
                    ForceCleanup();

                    // Actualize data of document
                    document.Refresh();
                    FWConnection ixConn = document.Conn;

                    // Exists checkout file already
                    bool existsCheckedOutFile = (!string.IsNullOrEmpty(document.CheckedoutFile) && File.Exists(document.CheckedoutFile));

                    // If checkout file already exists
                    if (existsCheckedOutFile)
                    {
                        // If document lock, not exists for currently user set one
                        if (document.LockId == -1)
                        {
                            FWDocument lockedDocument = ixConn.Content.LockDocument(document.Id);
                            if (lockedDocument.LockId == ixConn.Session.User.id)
                            {
                                checkOutResult.FWDocument = lockedDocument;
                                checkOutResult.Success    = true;
                            }
                            else
                                checkOutResult.Message = string.Format("Das Dokument {0} kann nicht zur Bearbeitung ausgecheckt werden, da das Sperren des Dokuments für die Bearbeitung nicht erfolgreich durchgeführt werden konnte.", document.Name);
                        }
                        else
                        {
                            if (document.LockId == ixConn.Session.User.id)
                            {
                                checkOutResult.FWDocument = document;
                                checkOutResult.Success    = true;
                            }
                            else
                                checkOutResult.Message = string.Format("Das Dokument {0} kann nicht zur Bearbeitung ausgecheckt werden, da dieses bereits durch einen anderen Benutzer für die Bearbeitung gesperrt worden ist.", document.Name);
                        }
                    }
                    else
                    {
                        if (document.LockId == -1)
                        {
                            FWDocument lockedDocument = ixConn.Content.LockDocument(document.Id);
                            if (lockedDocument.LockId == ixConn.Session.User.id)
                            {
                                // Create checkout file and state file for checked out document
                                CreateCheckedOutDocumentFiles(lockedDocument);

                                lockedDocument.Refresh();

                                checkOutResult.FWDocument = lockedDocument;
                                checkOutResult.Success = true;
                            }
                            else
                                checkOutResult.Message = string.Format("Das Dokument {0} kann nicht zur Bearbeitung ausgecheckt werden, da das Sperren des Dokuments für die Bearbeitung nicht erfolgreich durchgeführt werden konnte.", document.Name);
                        }
                        else if(document.LockId == ixConn.Session.User.id)
                        {
                            // Create checkout file and state file for checked out document
                            CreateCheckedOutDocumentFiles(document);

                            document.Refresh();

                            checkOutResult.FWDocument = document;
                            checkOutResult.Success = true;
                        }
                        else
                            checkOutResult.Message = string.Format("Das Dokument {0} kann nicht zur Bearbeitung ausgecheckt werden, da es durch einen anderen Benutzer bereits für die Bearbeitung gesperrt worden ist.", document.Name);
                    }
                }
                else
                    checkOutResult.Message = "Das Dokument kann nicht zur Bearbeitung ausgecheckt werden. Mögliche Ursachen: Dokument existiert nicht, keine Verbindung zum Indexserver oder die Url des Dokuments ist nicht vorhanden.";
            }
            catch(Exception ex)
            {
                checkOutResult.Success = false;
                checkOutResult.Message = "Das Auschecken des Dokuments zur Bearbeitung ist aufgrund des folgenden Fehlers fehlgeschlagen. Fehler: " +  ex.Message;
            }

            return checkOutResult;
        }

        /// <summary>
        /// Makes a valid and unique file name in the checkout directory. 
        /// </summary>
        /// <param name="name">Related file name, forbidden characters are replaced.</param>
        /// <param name="ext">File extension. A dot is prefixed if missing.</param>
        /// <param name="id">The object id.</param>
        /// <param name="documentId">The document id.</param>
        /// <returns>
        /// New unique checkout file path for a specific document with following structure: ...\checkoutdir\name--objectid-documentid.ext        /// 
        /// </returns>
        public virtual String MakeCheckOutFilePath(String name, String ext, string id, string documentId)
        {
            String fileExt = ext;
            if (!fileExt.StartsWith(".")) fileExt = "." + fileExt;

            String checkOutFileName = ReplaceForbiddenChars(name) + "--" + id + "-" + documentId + fileExt;
            return checkOutDir + "\\" + checkOutFileName;
        }

        /// <summary>
        /// Makes a valid and unique file name in the checkout directory. 
        /// </summary>
        /// <param name="document">Reference to document object, for hat file path have to be created.</param>
        /// <returns>
        /// New unique checkout file path for a specific document with following structure: ...\checkoutdir\documentname--objectid-docid.ext
        /// </returns>
        public virtual string MakeCheckOutFilePath(FWDocument document)
        {
            string name = document.OriginalFileName;
            if (string.IsNullOrEmpty(name))
            {
                name = document.Name;
            }
            else
            {
                int p = name.LastIndexOf('.');
                if (p >= 0) name = name.Substring(0, p);
            }

            return MakeCheckOutFilePath(name, document.Version.Core.ext, document.Id.ToString(), document.Version.Id.ToString());
        }

        /// <summary>
        /// Creates an unique checkout file path for a specific document. A file name has following structure: ...\checkoutdir\documentname_guid--objectid-docid.ext
        /// </summary>
        /// <param name="document">Reference to document for that a unique checkout file path have to be created.</param>
        /// <returns>
        /// New unique checkout file path for a specific document with following structure: ...\checkoutdir\documentname_guid--objectid-docid.ext
        /// </returns>
        public virtual string MakeCheckOutFilePathWithGuid(FWDocument document)
        {
            string name = document.OriginalFileName;
            if (string.IsNullOrEmpty(name))
            {
                name = document.Name;
            }
            else
            {
                int p = name.LastIndexOf('.');
                if (p >= 0) name = name.Substring(0, p);
            }

            name = name + "_" + Guid.NewGuid().ToString();

            return MakeCheckOutFilePath(name, document.Version.Core.ext, document.Id.ToString(), document.Version.Id.ToString());
        }

        /// <summary>
        /// Locks and creates neccessary files for editing of document created from selected template document, by using template document data.
        /// </summary>
        /// <param name="document">Document created from specific document template, for that neccessary files for editing have to be craeted in checkout directory.</param>
        /// <param name="template">Template document, that contains data, which have to be used to create neccessary files in checkout directory for editing of specific document.</param>
        /// <returns>
        /// Returns a reference to document with a checkedout file, which can be used to edit a document created from a selected document template.
        /// </returns>
        public virtual FWDocument ApplyDocumentTemplate(FWDocument document, FWDocument template)
        {
            bool existsDocument         = (document != null);
            bool existsTemplateDocument = (template != null && !string.IsNullOrEmpty(template.File) && File.Exists(template.File));

            if (existsDocument && existsTemplateDocument)
            {
                document.Refresh();

                // Dokumenteintrag im Archiv sperren
                if (document.LockId == -1)
                    document = Conn.Content.LockDocument(document.Id);

                string fileExtension             = Path.GetExtension(template.File);
                string checkedOutFilePath        = MakeCheckOutFilePath(document.Name, fileExtension, document.Id.ToString(), document.Version.Id.ToString());
                bool existsCheckedOutFileAlready = (!string.IsNullOrEmpty(checkedOutFilePath) && File.Exists(checkedOutFilePath));
                if (!existsCheckedOutFileAlready)
                {
                    File.Copy(template.File, checkedOutFilePath);
                    FileInfo fInfo = new FileInfo(checkedOutFilePath);
                    if (fInfo.Exists)
                    {
                        fInfo.Attributes = FileAttributes.Normal;
                        Conn.Content.DownloadManager.CreateStateFile(checkedOutFilePath, document.Id.ToString(), document.Version.Id.ToString(), document.LockId.ToString());
                    }
                }
            }

            return document;
        }

        #endregion

        /// <summary>
        /// Returns back a list of checked out documents, for which state file exists. Only checked out files for which
        /// state file exists are valid checked out files.
        /// </summary>
        /// <param name="checkOutDir">Path to the directory with checked out files.</param>
        /// <returns>
        /// List of checked out files, for which state file exists.
        /// </returns>
        protected virtual string[] GetCheckedOutFilesWithStateFile(string checkOutDir)
        {
            string[] files               = new string[] { };
            bool existsCheckOutDirectory = (!string.IsNullOrEmpty(checkOutDir) && Directory.Exists(checkOutDir));

            if (existsCheckOutDirectory)
            {
                files = Directory.GetFiles(checkOutDir);
                if (files != null && files.Length > 0)
                    return Array.FindAll(files, ExistsStateFileForFile);
            }

            return files;
        }

        /// <summary>
        /// Prooves if to the specific file a state file exists or not.
        /// </summary>
        /// <param name="filePath">Path to the file, for that have to be prooved if state file exists.</param>
        /// <returns>
        /// True if for specific file passed by filePath parameter a state file exists otherwise false.
        /// </returns>
        protected virtual bool ExistsStateFileForFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return false;
            else
            {
                FileInfo stateInfo = new FileInfo(filePath + ".state");
                return stateInfo.Exists;
            }
        }

        /// <summary>
        /// Creates a checked out and state file in a checkout directory for a specific document. For creation of checked out 
        /// and state file document must be locked by actually user. If files already exists no one will be created.
        /// </summary>
        /// <param name="document">
        /// Document locked by actually user, for that checkedout and state file have to be created.
        /// </param>
        /// <exception cref="Exception">
        /// Exception will be issued, if checked out or state file was not created successfully or some error occures, while creating it.
        /// </exception>
        protected virtual void CreateCheckedOutDocumentFiles(FWDocument document)
        {
            bool existsDocument                  = (document != null);
            bool existsIxConn                    = (document.Conn != null);
            bool existsDocUrl                    = (document != null && document.Version != null && !string.IsNullOrEmpty(document.Version.Url));
            bool isDocLockedByActuallyUser       = (document != null && document.LockId == document.Conn.Session.User.id);
            bool existsCheckedOutDocumentAlready = (document != null && !string.IsNullOrEmpty(document.CheckedoutFile) && File.Exists(document.CheckedoutFile));

            if (!existsDocument || !existsIxConn || !existsDocUrl || !isDocLockedByActuallyUser)
                throw new Exception("Für die Bearbeitung des Dokuments konnten im Checkout Verzeichniss nicht die erforderlichen Dateien erstellt werden. Mögliche Ursachen: Dokument oder Verbindung zum Indexserver nicht vorhanden, Url für den Download des Dokuments nicht vorhanden oder das Dokument ist nicht durch den momentanen Benutzer für die Bearbeitung gesperrt.");
            else
            {
                if (!existsCheckedOutDocumentAlready)
                {
                    FWConnection ixConn = document.Conn;
                    string docUrl = document.Version.Url;

                    // download the file, if it's a read-URL 
                    // (DocVersion contains a write-URL after checkinDocBegin)
                    if (docUrl.IndexOf("readdoc") >= 0)
                    {
                        // Create file path to new checked out document
                        string checkedOutFilePath = MakeCheckOutFilePath(document);

                        // If new created checkout file path exists. This can be if old file was not deleted yet or could not be deleted because
                        // it is locked by another process.
                        bool existsCheckedOutFilePath = (!string.IsNullOrEmpty(checkedOutFilePath) && File.Exists(checkedOutFilePath));

                        // If checkout file path created above already exists than create one with guid. This is an unique file path, becuase file path
                        // contains a guid that only appears one time.
                        if (existsCheckedOutFilePath)
                            checkedOutFilePath = MakeCheckOutFilePathWithGuid(document);

                        // Download file into 
                        ixConn.Content.Download(docUrl, checkedOutFilePath);

                        if (string.IsNullOrEmpty(checkedOutFilePath) || !File.Exists(checkedOutFilePath))
                        {
                            string errorMsg = string.Format("Für die Bearbeitung des Dokuments {0} konnten in CheckOut Verzeichniss nicht die notwendigen Dateien erstellt werden.", document.Name);
                            throw new Exception(errorMsg);
                        }

                        // Create state file for checked out document
                        string stateFilePath = ixConn.Content.DownloadManager.CreateStateFile(checkedOutFilePath, document.Id.ToString(), document.Version.Id.ToString(), document.LockId.ToString());

                        if (string.IsNullOrEmpty(stateFilePath) || !File.Exists(stateFilePath))
                        {
                            string errorMsg = string.Format("Für die Bearbeitung des Dokuments {0} konnten in CheckOut Verzeichniss nicht die notwendigen Dateien erstellt werden.", document.Name);
                            throw new Exception(errorMsg);
                        }

                        // If checkout file and state file was created successfully set file attribute to normal, to ensure,
                        // that file can be modified
                        FileInfo checkedOutFileInfo = new FileInfo(checkedOutFilePath);
                        checkedOutFileInfo.Attributes = FileAttributes.Normal;

                        // Issue a event
                        OnNewCheckedOutDocument(new EventArgs());
                    }
                }
            }
        }

        /// <summary>
        /// Replace the forbidden characters in the given name by an underscore.
        /// </summary>
        /// <param name="name">File name that might contain forbidden characters.</param>
        /// <returns>File name without forbidden characters.</returns>
        protected virtual String ReplaceForbiddenChars(String name)
        {
            char[] nameChars = name.ToCharArray();
            for (int i = 0; i < nameChars.Length; i++)
            {
                char replaceChar = '_';
                if (replacementCharsForForbiddenChars.TryGetValue(nameChars[i], out replaceChar))
                {
                    nameChars[i] = replaceChar;
                }
            }
            String name2 = new String(nameChars);
            return name2;
        }

        /// <summary>
        /// Initializes and starts filesystemwatcher for monitoring changes in checkout directory.
        /// </summary>
        /// <returns>
        /// True if Filesystemwatcher is successfully initialized otherwise false.
        /// </returns>
        protected virtual bool InitializeFileSystemWatcherForMonintoringCheckOutDir(string checkOutDirPath)
        {
            bool isFileSystemWatcherInitialized = false;

            try
            {
                bool existsCheckOutDirectory = (!string.IsNullOrEmpty(checkOutDirPath) && Directory.Exists(checkOutDirPath));

                if (existsCheckOutDirectory)
                {
                    // Dispose filesystemwatcher if it was already initialized before initializing it again
                    if (checkOutDirectoryFWatcher != null)
                    {
                        checkOutDirectoryFWatcher.EnableRaisingEvents = false;
                        checkOutDirectoryFWatcher.Dispose();
                        checkOutDirectoryFWatcher = null;
                    }

                    // Initialize filesystemwatcher for monitoring of directory for checked out documents
                    checkOutDirectoryFWatcher = new FileSystemWatcher(checkOutDirPath + "\\");

                    // Monitoring of deleted files
                    checkOutDirectoryFWatcher.Deleted -= new FileSystemEventHandler(CheckOutDirectoryEntry_Changed);
                    checkOutDirectoryFWatcher.Deleted += new FileSystemEventHandler(CheckOutDirectoryEntry_Changed);

                    // Monitoring of created files
                    checkOutDirectoryFWatcher.Created -= new FileSystemEventHandler(CheckOutDirectoryEntry_Changed);
                    checkOutDirectoryFWatcher.Created += new FileSystemEventHandler(CheckOutDirectoryEntry_Changed);

                    // Monitoring of changed files
                    checkOutDirectoryFWatcher.Changed -= new FileSystemEventHandler(CheckOutDirectoryEntry_Changed);
                    checkOutDirectoryFWatcher.Changed += new FileSystemEventHandler(CheckOutDirectoryEntry_Changed);

                    // Start watcher
                    checkOutDirectoryFWatcher.EnableRaisingEvents = true;
                    isFileSystemWatcherInitialized                = true;
                }
            }
            catch { }

            return isFileSystemWatcherInitialized;
        }

        /// <summary>
        /// This method issues a event CheckOutDirectoryEntriesChanged and is called by FileSystemWatcher, if any entry of directory for checked out
        /// documents has changed.
        /// </summary>
        /// <param name="sender">Source of event, here a Filesystemwatcher for directory with checked out documents..</param>
        /// <param name="e">Additional informations to the event.</param>
        private void CheckOutDirectoryEntry_Changed(object sender, FileSystemEventArgs e)
        {
            OnCheckOutDirectoryEntriesChanged(new EventArgs());
        }

        /// <summary>
        /// Issue a event CheckOutDirectoryEntriesChanged.
        /// </summary>
        /// <param name="e">Additionally informations to the event.</param>
        protected virtual void OnCheckOutDirectoryEntriesChanged(EventArgs e)
        {
            if (CheckOutDirectoryEntriesChanged != null)
                CheckOutDirectoryEntriesChanged(this, e);
        }

        /// <summary>
        /// Issue a event NewCheckedOutDocument.
        /// </summary>
        /// <param name="e">Additionally informations to the event.</param>
        protected virtual void OnNewCheckedOutDocument(EventArgs e)
        {
            if (NewCheckedOutDocument != null)
                NewCheckedOutDocument(this, e);
        }

        // <summary>
        /// Issue a event CheckedOutDocumentRemoved.
        /// </summary>
        /// <param name="e">Additionally informations to the event.</param>
        protected virtual void OnCheckedOutDocumentRemoved(EventArgs e)
        {
            if (CheckedOutDocumentRemoved != null)
                CheckedOutDocumentRemoved(this, e);
        }

        /// <summary>
        /// Returns true, if the given file is controlled by the download manager.
        /// </summary>
        /// <param name="filePath">File name to be checked.</param>
        /// <remarks>A file is controlled by the download manager, if it resides in the download managers working directory.</remarks>
        /// <returns>see summary</returns>
        public virtual bool IsControlledFile(string filePath)
        {
            if (null == filePath || filePath.Length == 0) return false;

            return new FileInfo(filePath + ".state").Exists;
        }

        /// <summary>
        /// Return the object ID and document ID contained in the given file name.
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="objId">Object ID</param>
        /// <param name="docId">Document version ID</param>
        /// <returns>True, if IDs could be extracted.</returns>
        public virtual bool GetIdFromFileName(string fileName, out string objId, out string docId)
        {
            objId = docId = "";
            if (fileName == null || fileName.Length == 0) return false;
            int p = fileName.LastIndexOf('.');
            if (p < 0) p = fileName.Length;
            int q = fileName.LastIndexOf('-', p - 1);
            if (q < 0) return false;
            docId = fileName.Substring(q + 1, p - q - 1);
            int r = fileName.LastIndexOf("--", q);
            if (r < 0) return false;
            objId = fileName.Substring(r + 2, q - r - 2);
            return true;
        }

    }
}

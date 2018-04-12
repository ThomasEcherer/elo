using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// This class downloads document files into a directory.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The downloaded files are set read-only.
    /// The files are automatically deleted, if they were older than a configurable lifetime.
    /// They are not deleted, if they were modified. A file is recognized as modified, 
    /// if  the FileAttribute.Archive is set.
    /// </para>
    /// <para>
    /// Each downloaded file has an associated state file. 
    /// A downloaded file can be deleted, if the state file does not exist. 
    /// The state file is a basic condition for a file to be valid. 
    /// If a document is unlocked, the state files of all downloaded 
    /// versions, attachments, signatures, previews are deleted to tell the 
    /// download manager, that the corresponding downloaded files are invalid.
    /// The state files are nessesary, because the version, attachment, etc. files
    /// could be open when the document object is unlocked.
  /// </para>
    /// </remarks>
    public class FWDownloadManager : FWContentBase, EloixClient.IndexServerFW.Content.IFWDownloadManager
    {
        /// <summary>
        /// Forbidden characters in the windows file system.
        /// </summary>
        protected static String FORBIDDEN_FILESYSTEM_CHARS = "/:\"|*?<>\\";
        /// <summary>
        /// Document files are downloaded into this directory.
        /// </summary>
        protected String workDir;
        /// <summary>
        /// Helper map that contains the forbidden file system characters.
        /// </summary>
        protected Dictionary<char, char> mapOfForbiddenChars;
        /// <summary>
        /// Lifetime of documents in the directory.
        /// </summary>
        protected int lifetimeSeconds;
        /// <summary>
        /// Helper variable that counts the calls to cleanup.
        /// </summary>
        protected int cleanupCounter60;

        /// <summary>
        /// Contains list of all controled files with actually file attributes.
        /// </summary>
        protected Dictionary<string, FileAttributes> controledFilesAttributes;




        #region Initialization
        /// <summary>
        /// Create a DownloadManger object for the given content interface.
        /// </summary>
        /// <param name="ifc">Content interface object</param>
        /// <param name="workDir">Working directory, documents are downloaded into this directory.</param>
        /// <param name="lifetimeSeconds">Lifetime seconds for cached document files</param>
        public FWDownloadManager(FWContentInterface ifc, String workDir, int lifetimeSeconds): base(ifc)
        {
            this.workDir = workDir;
            this.lifetimeSeconds = lifetimeSeconds;
            mapOfForbiddenChars = new Dictionary<char, char>();
            for (int i = 0; i < FORBIDDEN_FILESYSTEM_CHARS.Length; i++)
            {
                mapOfForbiddenChars.Add(FORBIDDEN_FILESYSTEM_CHARS[i], '_');
            }

            controledFilesAttributes = new Dictionary<string, FileAttributes>();
        }
        /// <summary>
        /// Create a DownloadManger object for the given content interface.
        /// </summary>
        /// <param name="ifc">Content interface object</param>
        /// <param name="workDir">Working directory, documents are downloaded into this directory.</param>
        /// <param name="lifetimeSeconds">Lifetime seconds for cached document files</param>
        /// <param name="initFWatcherForMonitoringCheckOutDir">
        /// If True Filesystemwachter will be initialized for monitoring of changes in directory for checked out documents otherwise false.
        /// By initialization of Filesystemwatcher event CheckOutDirectoryEntriesChanged can be issued otherwise not.
        /// </param>
        public FWDownloadManager(FWContentInterface ifc, String workDir, int lifetimeSeconds, bool initFWatcherForMonitoringCheckOutDir)
            : base(ifc)
        {
            this.workDir = workDir;
            this.lifetimeSeconds = lifetimeSeconds;
            mapOfForbiddenChars = new Dictionary<char, char>();
            for (int i = 0; i < FORBIDDEN_FILESYSTEM_CHARS.Length; i++)
            {
                mapOfForbiddenChars.Add(FORBIDDEN_FILESYSTEM_CHARS[i], '_');
            }

            // Initialize filesystemwatcher for monitoring of changes in directory for checked out documents
            if (initFWatcherForMonitoringCheckOutDir)
            {
                controledFilesAttributes = new Dictionary<string, FileAttributes>();
            }
        }
        #endregion



        /// <summary>
        /// Replace the forbidden characters in the given name by an underscore.
        /// </summary>
        /// <param name="name">File name that might contain forbidden characters.</param>
        /// <returns>File name without forbidden characters.</returns>
        protected virtual String replaceForbiddenChars(String name)
        {
            char[] nameChars = name.ToCharArray();
            for (int i = 0; i < nameChars.Length; i++)
            {
                char replaceChar = '_';
                if (mapOfForbiddenChars.TryGetValue(nameChars[i], out replaceChar))
                {
                    nameChars[i] = replaceChar;
                }
            }
            String name2 = new String(nameChars);
            return name2;
        }

        /// <summary>
        /// Makes a valid and unique file name in the working directory. 
        /// </summary>
        /// <param name="name">Related file name, forbidden characters are replaced.</param>
        /// <param name="ext">File extension. A dot is prefixed if missing.</param>
        /// <param name="id">The object id.</param>
        /// <param name="documentId">The document id.</param>
        /// <returns>Unique file path in working directory.</returns>
        public virtual String makeTempFilePath(String name, String ext, string id, string documentId)
        {
            String ext2 = ext;
            if (!ext2.StartsWith(".")) ext2 = "." + ext2;

            String name2 = replaceForbiddenChars(name) + "--" + id + "-" + documentId + ext2;

            String filePath = null;
            //int fileIdx = 0;
            //do
            //{
            //  String fileName = name2;
            //  //if (fileIdx++ != 0)
            //  //{
            //    fileName += "-" + fileIdx++;
            //  //}
            //  fileName += ext2;

            //  filePath = workDir + "\\" + fileName;

            //}
            //while (System.IO.File.Exists(filePath));
            filePath = workDir + "\\" + name2;
            return filePath;
        }

        /// <summary>
        /// Makes a valid and unique file name in the working directory. 
        /// </summary>
        /// <param name="document">The doument object.</param>
        /// <returns>Unique file path in working directory.</returns>
        public virtual string makeTempFilePath(FWDocument document)
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

            return makeTempFilePath(name, document.Version.Core.ext, document.Id.ToString(), document.Version.Id.ToString());
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

        /// <summary>
        /// Mark the file as invalid.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <remarks>The next call to Cleanup will delete the file.</remarks>
        public virtual void InvalidateFile(string filePath)
        {
          FWDocument document = GetFWDocumentFromFile(filePath);

          if ((document == null || document.LockId == -1) &&
              workDir.Equals(System.IO.Path.GetDirectoryName(filePath)))
          {
              FileInfo fileInfo = new FileInfo(filePath);
              if (fileInfo.Exists)
              {
                  fileInfo.Attributes = FileAttributes.ReadOnly;
              }

              FileInfo stateInfo = GetStateFileInfo(fileInfo);
              if (stateInfo.Exists)
              {
                  stateInfo.Delete();
              }
          }
        }

        /// <summary>
        /// Return the state helper file.
        /// </summary>
        /// <param name="fileInfo">Downloaded file.</param>
        /// <returns>State helper file</returns>
        private FileInfo GetStateFileInfo(FileInfo fileInfo)
        {
          return new FileInfo(fileInfo.FullName + ".state");
        }

        /// <summary>
        /// Write the state file content.
        /// </summary>
        /// <param name="stateInfo">State file</param>
        /// <param name="id">Object ID</param>
        /// <param name="documentId">Document version ID</param>
        private void WriteStateFile(FileInfo stateInfo, string id, string documentId)
        {
            using (StreamWriter sw = new StreamWriter(stateInfo.FullName))
            {
                sw.WriteLine(id);
                sw.WriteLine(documentId);
            }
            stateInfo.Refresh();
        }

        /// <summary>
        /// Download a file from DM.
        /// </summary>
        /// <param name="url">Download URL</param>
        /// <param name="fileInfo">Destination file</param>
        /// <param name="id">Object ID</param>
        /// <param name="documentId">Document ID</param>
        /// <remarks>
        /// The file is downloaded and constrained to readonly access. The 
        /// archive attribute is reset to mark the file as unchanged. 
        /// A state file is written for the downloaded file.
        /// </remarks>
        private void InternalDownload(string url, FileInfo fileInfo, string id, string documentId)
        {
          Conn.internalConnection.Download(url, fileInfo.FullName);

          fileInfo.Refresh();
          if (fileInfo.Exists)
          {
              FileAttributes attrs = fileInfo.Attributes;
              attrs &= ~FileAttributes.Archive;
              attrs |= FileAttributes.ReadOnly;
              fileInfo.Attributes = attrs;
          }
          FileInfo stateInfo = GetStateFileInfo(fileInfo);
          WriteStateFile(stateInfo, id, documentId);
        }

        /// <summary>
        /// Return true, if the given file is expired.
        /// </summary>
        /// <param name="fileInfo">File</param>
        /// <returns></returns>
        private bool IsFileExpired(FileInfo fileInfo)
        {
          return fileInfo.Exists &&
            ((fileInfo.Attributes & FileAttributes.Archive) == 0) &&
            (fileInfo.LastWriteTime.AddSeconds(lifetimeSeconds) < DateTime.Now);
        }

        /// <summary>
        /// Delete the given file if it is expired or invalid.
        /// </summary>
        /// <param name="fileInfo">File to be checked</param>
        /// <returns>True, if the file was deleted</returns>
        private bool DeleteControlledFileIfExpired(FileInfo fileInfo)
        {
          FileInfo stateInfo = GetStateFileInfo(fileInfo);

          bool isExpired = !stateInfo.Exists || IsFileExpired(fileInfo);

          if (isExpired)
          {
            DeleteControlledFile(fileInfo, stateInfo);
          }

          return isExpired;
        }

        /// <summary>
        /// Delete the given file and its corresponding state file.
        /// </summary>
        /// <param name="fileInfo">File</param>
        /// <param name="stateInfo">State file, might be null.</param>
        private void DeleteControlledFile(FileInfo fileInfo, FileInfo stateInfo)
        {
          if (stateInfo == null) stateInfo = GetStateFileInfo(fileInfo);
          if (fileInfo.Exists) { fileInfo.Attributes = FileAttributes.Normal; fileInfo.Delete(); }
          if (stateInfo.Exists) stateInfo.Delete();
        }

        /// <summary>
        /// Download from given URL into a file named like name.ext.
        /// FileAttributes.Archive is deleted from the file attributes after download.
        /// Function Cleanup checks the file attributes. 
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="name">Related file name. Forbidden chars are replaced by underscores.</param>
        /// <param name="ext">File extension with or without dot.</param>
        /// <param name="id">The object id.</param>
        /// <param name="documentId">The document id.</param>
        /// <returns>Absolute path</returns>
        public virtual String Download(String url, String name, String ext, string id, string documentId)
        {
            String filePath = makeTempFilePath(name, ext, id, documentId);
            FileInfo fi = new FileInfo(filePath);
            if (DeleteControlledFileIfExpired(fi))
            {
              InternalDownload(url, fi, id, documentId);
            }
            return filePath;
        }

        /// <summary>
        /// Delete unchanged files that are older than lifetimeSeconds.
        /// </summary>
        public virtual void Cleanup()
        {
            // Function is called every second. But check only every minute.
            if (Interlocked.Increment(ref cleanupCounter60) != 60) return;
            cleanupCounter60 = 0;

            ForceCleanup();
        }

        /// <summary>
        /// Deletes all unchanged files in the working directory.
        /// </summary>
        public virtual void ForceCleanup()
        {
            string checkOutDir = System.IO.Path.Combine(workDir, "Checkout");

            InternalCleanup(workDir);
            //InternalCleanup(checkOutDir);
        }

        private void InternalCleanup(string directory)
        {
            if (!System.IO.Directory.Exists(directory))
                return;

            String[] files = Directory.GetFiles(directory);
            foreach (String f in files)
            {
                FileInfo fileInfo = new FileInfo(f);
                if (!fileInfo.Extension.Equals(".state") && !fileInfo.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    try { DeleteControlledFileIfExpired(fileInfo); }
                    catch { }
                }
            }

            // zur Sicherheit verwaiste state-Dateien löschen
            foreach (string file in System.IO.Directory.GetFiles(directory, "*.state"))
            {
                try
                {
                    string controlledFileName = file.Substring(0, file.Length - 6);
                    if (!File.Exists(controlledFileName))
                        System.IO.File.Delete(file);
                }
                catch { }
            }
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

        public virtual string TempDir
        {
            get { return workDir; }
        }

        /// <summary>
        /// Returns true, if the given file is controlled by the download manager.
        /// </summary>
        /// <param name="filePath">File name to be checked.</param>
        /// <remarks>A file is controlled by the download manager, if it resides in the download managers working directory.</remarks>
        /// <returns>see summary</returns>
        public virtual bool IsControlledFile(string filePath)
        {
          //return (filePath != null) ? filePath.ToLower().StartsWith(workDir.ToLower()) : false;
            if (null == filePath || filePath.Length == 0) return false;

            //string fileName = Path.GetFileName(filePath);
            //return (!fileName.StartsWith("~") && !fileName.EndsWith(".state"));
            return GetStateFileInfo(new FileInfo(filePath)).Exists;
        }

        private string[] GetControlledFiles(string workDir)
        {
            string[] files = Directory.GetFiles(workDir);

            return Array.FindAll(files, IsControlledFile);
        }

        public virtual string makeWritableFile(string filePath)
        {
            new System.IO.FileInfo(filePath).IsReadOnly = false;
            return filePath;
        }

        public virtual string GetWorkDirForArchiveFolder(string folderPath)
        {
            return workDir;
        }

        public virtual string AttachNewDocumentWorkFile(string sourceFile, string destArcPath, string destName, string objId, string documentId) 
        {
            string destFile = makeTempFilePath(destName, Path.GetExtension(sourceFile), objId.ToString(), documentId);
            File.Copy(sourceFile, destFile);

  	        makeWritableFile(destFile);             

            FileInfo fileInfo = new FileInfo(destFile);
            FileInfo stateInfo = GetStateFileInfo(fileInfo);
            WriteStateFile(stateInfo, objId, documentId);

            return destFile;
        }

        /// <summary>
        /// Prooves if work directory of downloadmanager contains file, whose name consists of values passed by
        /// the three parameters. If file exists a whole path will be returned back.
        /// </summary>
        /// <param name="name">Name of document.</param>
        /// <param name="id">Id of entry.</param>
        /// <param name="documentId">Id of document.</param>
        /// <returns>
        /// Whole path to file, whose name consists of values passed by the parameters or null if no file was found.
        /// </returns>
        public virtual string GetExistingFileForDocument(string name, string id, string documentId)
        {
            string pathOfFoundFile  = null;
            bool existsDocumentName = (name != null);
            bool existsEntryId      = (id != null);
            bool existsDocumentId   = (documentId != null);

            try
            {
                if (existsDocumentName && existsEntryId && existsDocumentId)
                {
                    // Creating filename that have to be found
                    String fileNameToFound = replaceForbiddenChars(name) + "--" + id + "-" + documentId;

                    // Get all files of work directory
                    string[] controledFiles   = GetControlledFiles(workDir);
                    bool existsControledFiles = (controledFiles != null && controledFiles.Length > 0);

                    // Proove if file exists 
                    if (existsControledFiles)
                    {
                        foreach (string controledFile in controledFiles)
                        {
                            // Only consider not state files
                            string controledFileExt = Path.GetExtension(controledFile);
                            if (string.Compare(controledFileExt, ".state", true) != 0)
                            {
                                string controledFileName = Path.GetFileNameWithoutExtension(controledFile);
                                if (controledFileName.Equals(fileNameToFound))
                                {
                                    pathOfFoundFile = controledFile;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                
            }
            return pathOfFoundFile; 
        }

        /// <summary>
        /// Creates a state file for a specific document and writes into it file data passed by the three parameters.
        /// </summary>
        /// <param name="documentFile">Path to the document for that state file have to be created.</param>
        /// <param name="id">Id of object.</param>
        /// <param name="documentId">Id of document.</param>
        /// <param name="lockId">Actually lockid of document.</param>
        /// <returns>
        /// Path to the created state file or null, if no state file was created.
        /// </returns>
        public string CreateStateFile(string documentFile, string id, string documentId, string lockId)
        {
            string pathOfCreatedStateFile = null;
            bool existsDocumentFile       = (!string.IsNullOrEmpty(documentFile) && File.Exists(documentFile));
            if (existsDocumentFile)
            {
                string stateFilePath        = documentFile + ".state";
                bool existsStateFileAlready = (File.Exists(stateFilePath));
                if (!existsStateFileAlready)
                {
                    FileInfo stateFileInfo = new FileInfo(stateFilePath);
                    using (StreamWriter sw = new StreamWriter(stateFileInfo.FullName))
                    {
                        sw.WriteLine(id);
                        sw.WriteLine(documentId);
                        sw.WriteLine(lockId);
                    }
                }

                pathOfCreatedStateFile = stateFilePath;
            }

            return pathOfCreatedStateFile;
        }
    }
}

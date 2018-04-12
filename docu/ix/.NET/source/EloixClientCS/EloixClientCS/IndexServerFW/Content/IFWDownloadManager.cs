using System;
using System.Collections.Generic;



namespace EloixClient.IndexServerFW.Content
{
    public interface IFWDownloadManager
    {
        /// <summary>
        /// Delete unchanged files that are older than lifetimeSeconds.
        /// </summary>
        void Cleanup();

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
        string Download(string url, string name, string ext, string id, string documentId);
        
        /// <summary>
        /// Deletes all unchanged files in the working directory.
        /// </summary>
        void ForceCleanup();
        
        /// <summary>
        /// Return the object ID and document ID contained in the given file name.
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="objId">Object ID</param>
        /// <param name="docId">Document version ID</param>
        /// <returns>True, if IDs could be extracted.</returns>
        bool GetIdFromFileName(string fileName, out string objId, out string docId);
        
        /// <summary>
        /// Mark the file as invalid.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <remarks>The next call to Cleanup will delete the file.</remarks>
        void InvalidateFile(string filePath);
        
        /// <summary>
        /// Returns true, if the given file is controlled by the download manager.
        /// </summary>
        /// <param name="filePath">File name to be checked.</param>
        /// <remarks>A file is controlled by the download manager, if it resides in the download managers working directory.</remarks>
        /// <returns>see summary</returns>
        bool IsControlledFile(string filePath);
        
        /// <summary>
        /// Makes a valid and unique file name in the working directory. 
        /// </summary>
        /// <param name="name">Related file name, forbidden characters are replaced.</param>
        /// <param name="ext">File extension. A dot is prefixed if missing.</param>
        /// <param name="id">The object id.</param>
        /// <param name="documentId">The document id.</param>
        /// <returns>Unique file path in working directory.</returns>
        string makeTempFilePath(string name, string ext, string id, string documentId);

        /// <summary>
        /// Makes a valid and unique file name in the working directory. 
        /// </summary>
        /// <param name="document">The doument object.</param>
        /// <returns>Unique file path in working directory.</returns>
        string makeTempFilePath(FWDocument document);

        /// <summary>
        /// If the given file is read-only, the function makes the file writable or returns a writable copy.
        /// </summary>
        /// <param name="filePath">File</param>
        /// <returns>File</returns>
        string makeWritableFile(string filePath);

        FWDocument GetFWDocumentFromFile(string file);

        string TempDir { get; }

        string AttachNewDocumentWorkFile(string sourceFile, string destArcPath, string destName, string objId, string documentId);

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
        string GetExistingFileForDocument(string name, string id, string documentId);

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
        string CreateStateFile(string documentFile, string id, string documentId, string lockId);
    }

}

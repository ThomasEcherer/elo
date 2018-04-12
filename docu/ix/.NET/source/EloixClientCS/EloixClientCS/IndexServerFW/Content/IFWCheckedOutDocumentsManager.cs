using System;
using System.Collections.Generic;

using EloixClient.Common;


namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// The interface IFWCheckedoutDocumentsManager defines functionallity of component, that is responsilble for management of checked out documents in
    /// a checkout directory.
    /// </summary>
    public interface IFWCheckedOutDocumentsManager
    {
        /// <summary>
        /// Occures when entries of checkout directory have been changed. 
        /// </summary>
        event EventHandler CheckOutDirectoryEntriesChanged;

        /// <summary>
        /// Occures when new checked out document was created in a checkout directory.
        /// </summary>
        event EventHandler NewCheckedOutDocument;

        /// <summary>
        /// Occures if all state and checkout file were removed from checkout directory or only a state file, if deleting of checkout file fails.
        /// </summary>
        event EventHandler CheckedOutDocumentRemoved;

        /// <summary>
        /// Deletes after sitxtieth call all not more checked out documents in a checkout directory. A document is not more checked out if state file for a
        /// specific document not more exists in a checkout directory.
        /// </summary>
        void Cleanup();

        /// <summary>
        /// Deletes imediatelly all not more checked out documents in a checkout directory. A document is not more checked out if state file for a
        /// specific document not more exists in a checkout directory.
        /// </summary>
        void ForceCleanup();

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
        string[] GetCheckedoutFiles(params string[] allowedExtensions);

        /// <summary>
        /// Returns list of checked out documents. Only documents with state file and lockid value unequal -1 in the state file are
        /// valid checked out documents and will be returned back.
        /// </summary>
        /// <returns>
        /// List of checked out documents.
        /// </returns>
        IList<FWDocument> GetCheckedOutDocuments();

        /// <summary>
        /// Return the object ID and document ID contained in the given file name.
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="objId">Object ID</param>
        /// <param name="docId">Document version ID</param>
        /// <returns>True, if IDs could be extracted.</returns>
        bool GetIdFromFileName(string fileName, out string objId, out string docId);

        FWDocument GetFWDocumentFromFile(string file);

        /// <summary>
        /// Returns back a path to the checked out file of specific document. Only if state file exists for a specific document a path
        /// to the checkedout file will be returned back.
        /// </summary>
        /// <param name="document">Reference to document for that path to checked out document have to be returned back.</param>
        /// <returns>
        /// Path to the checked out file or null if no one exists for a specific document.
        /// </returns>
        string GetCheckedOutFileOf(FWDocument document);

        /// <summary>
        /// Deletes checked out and state file of selected document if any of them exists. Only for no more locked document
        /// checked out and state file can be deleted.
        /// </summary>
        /// <param name="document">Document, for that checked out and state file have to be deleted in checkout directory.</param>
        void RemoveCheckedOutDocumentFiles(FWDocument document);

        /// <summary>
        /// Checks out a selected document and returns back result of checkout. While checkout of selected document checked out and state file will be created in
        /// checkout directory. 
        /// </summary>
        /// <param name="document">Document, that have to be checked out.</param>
        /// <returns>
        /// Result of checkout operation.
        /// </returns>
        CheckoutResult Checkout(FWDocument document);

        /// <summary>
        /// Returns true, if the given file is controlled by the download manager.
        /// </summary>
        /// <param name="filePath">File name to be checked.</param>
        /// <remarks>A file is controlled by the download manager, if it resides in the download managers working directory.</remarks>
        /// <returns>see summary</returns>
        bool IsControlledFile(string filePath);

        /// <summary>
        /// Makes a valid and unique file name in the checkout directory. 
        /// </summary>
        /// <param name="name">Related file name, forbidden characters are replaced.</param>
        /// <param name="ext">File extension. A dot is prefixed if missing.</param>
        /// <param name="id">The object id.</param>
        /// <param name="documentId">The document id.</param>
        /// <returns>Unique file path in working directory.</returns>
        String MakeCheckOutFilePath(String name, String ext, string id, string documentId);

        /// <summary>
        /// Makes a valid and unique file name in the checkout directory. 
        /// </summary>
        /// <param name="document">Reference to document object, for hat file path have to be created.</param>
        /// <returns>Unique file path in checkout directory.</returns>
        string MakeCheckOutFilePath(FWDocument document);

        /// <summary>
        /// Locks and creates neccessary files for editing of document created from selected template document, by using template document data.
        /// </summary>
        /// <param name="document">Document created from specific document template, for that neccessary files for editing have to be craeted in checkout directory.</param>
        /// <param name="template">Template document, that contains data, which have to be used to create neccessary files in checkout directory for editing of specific document.</param>
        /// <returns>
        /// Returns a reference to document with a checkedout file, which can be used to edit a document created from a selected document template.
        /// </returns>
        FWDocument ApplyDocumentTemplate(FWDocument document, FWDocument template);

        /// <summary>
        /// Creates an unique checkout file path for a specific document. A file name has following structure: ...\checkoutdir\documentname_guid--objectid-docid.ext
        /// </summary>
        /// <param name="document">Reference to document for that a unique checkout file path have to be created.</param>
        /// <returns>
        /// New unique checkout file path for a specific document with following structure: ...\checkoutdir\documentname_guid--objectid-docid.ext
        /// </returns>
        string MakeCheckOutFilePathWithGuid(FWDocument document);
    }
}

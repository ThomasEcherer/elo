using System;
using System.Collections.Generic;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// This class represens a document object with indexing information,
    /// versions and attachments.
    /// </summary>
    public class FWDocument : FWSord
    {

        /// <summary>
        /// Collection of document versions.
        /// </summary>
        internal FWDocVersions docs;
        /// <summary>
        /// Collection of attachment versions.
        /// </summary>
        internal FWDocVersions atts;
        /// <summary>
        /// True, if all versions have been read
        /// </summary>
        protected bool haveReadAll = false;
        /// <summary>
        /// True, if the current working version has been read
        /// </summary>
        protected bool haveReadWorkVersion = false;

        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="ifc">Content interface object</param>
        /// <param name="sord">Raw Sord object from IndexServer API</param>
        public FWDocument(FWContentInterface ifc, Sord sord)
            : base(ifc, sord)
        {
            Init();
        }

        /// <summary>
        /// Initialize.
        /// </summary>
        protected void Init()
        {
            haveReadAll = false;
            haveReadWorkVersion = false;

            // Provide empty collections for document versions and attachments
            docs = ClassFactory.NewDocVersions(null, this, FWDocVersionType.TYPE_VERSION);
            atts = ClassFactory.NewDocVersions(null, this, FWDocVersionType.TYPE_ATTACHMENT);

            // If the sord object contains a version, put it into the versions collection
            if (sordVal.docVersion != null)
            {
                docs.InternalAdd(sordVal.docVersion);
            }
        }

        /// <summary>
        /// Gets the current working version.
        /// </summary>
        /// <remarks>
        /// If the document does not have an associated file, a new version
        /// object is created. The Id property of the new version is 0 and the File property is null.
        /// </remarks>
        /// <seealso cref="File"/>
        public virtual FWDocVersion Version
        {
            get
            {
                // get working version from the collection of versions
                FWDocVersion v = docs.WorkVersion;

                // if not exist...
                if (v == null)
                {
                    // ... read working version
                    readWorkVersion();

                    // try again to get the current working version from the collection
                    v = docs.WorkVersion;

                    // if not exist ...
                    if (v == null)
                    {
                        // ...maybe a new document, provide a new version object
                        DocVersion dv = new DocVersion();
                        dv.workVersion = true;
                        v = docs.InternalAdd(dv);
                        v.File = ifc.DownloadManager.GetExistingFileForDocument(Name, Id.ToString(), "0");
                    }
                }
                return v;
            }
        }

        /// <summary>
        /// Gets or sets the document file of the current working version.
        /// </summary>
        /// <remarks>
        /// If no file is attached to the document, this property returns null.
        /// </remarks>
        public virtual String File
        {
            get
            {
                FWDocVersion v = Version;
                return v != null ? v.File : null;
            }
            set
            {
                FWDocVersion v = Version;
                if (v != null)
                {
                    v.File = value;
                }
                else
                {
                    v = docs.Add(value);
                }
            }
        }

        /// <summary>
        /// Returns back a path to the checked out file of a document.
        /// </summary>
        public virtual string CheckedoutFile
        {
            get
            {
                return ifc.Conn.Content.CheckedOutDocumentsManager.GetCheckedOutFileOf(this);
            }
        }

        /// <summary>
        /// Gets the current working version of attachments
        /// </summary>
        /// <remarks>
        /// If the document does not have an associated attachment, a new attachment
        /// object is created. The Id property of the new attachment is 0 and the File property is null.
        /// </remarks>
        /// <seealso cref="AttachmentFile"/>
        public virtual FWDocVersion Attachment
        {
            get
            {
                FWDocVersion v = atts.WorkVersion;
                if (v == null)
                {
                    readWorkVersion();
                    v = atts.WorkVersion;
                    // if not exist ...
                    if (v == null)
                    {
                        // ...maybe a new document, provide a new version object
                        DocVersion dv = new DocVersion();
                        dv.workVersion = true;
                        v = atts.InternalAdd(dv);
                    }
                }
                return v;
            }
        }

        /// <summary>
        /// Gets or sets the attachment file of the current working version of attachments
        /// </summary>
        public virtual String AttachmentFile
        {
            get
            {
                FWDocVersion v = Attachment;
                return v != null ? v.File : null;
            }
            set
            {
                FWDocVersion v = Attachment;
                v.File = value;

                if (v.Comment == null || v.Comment.Length == 0)
                {
                    int p = v.File.LastIndexOf("\\");
                    if (p >= 0) v.Comment = v.File.Substring(p + 1);
                }
            }
        }

        /// <summary>
        /// Gets the signature version object from the current working version.
        /// </summary>
        /// <remarks>
        /// If the document does not have an associated signature, a new signature
        /// object is created. The Id property of the new signature is 0 and the File property is null.
        /// </remarks>
        /// <seealso cref="SignatureFile"/>
        public virtual FWDocVersion Signature
        {
            get
            {
                FWDocVersion v = Version;
                FWDocVersion s = v.Signature;
                if (s == null)
                {
                    readWorkVersion();
                    v = Version;

                    s = v.Signature;
                    if (s == null)
                    {
                        v.Signature = s = ClassFactory.NewDocVersion(new DocVersion(), this, FWDocVersionType.TYPE_SIGNATURE);
                    }
                }
                return s;
            }
        }

        /// <summary>
        /// Gets or sets the signature file for the current document working version.
        /// </summary>
        public virtual String SignatureFile
        {
            get
            {
                FWDocVersion v = Signature;
                return v.File;
            }
            set
            {
                FWDocVersion v = Signature;
                v.File = value;
            }
        }

        /// <summary>
        /// Read the working version of the document and attachment.
        /// </summary>
        protected virtual void readWorkVersion()
        {
            if (haveReadWorkVersion) return;
            haveReadWorkVersion = true;

            // Existing object?
            if (sordVal.id >= 0)
            {
                // read versions
                long editC = EditInfoC.mbDocumentMembers | EditInfoC.mbSignatureMembers | EditInfoC.mbAttachmentMembers;
                EditInfoZ editZ = new EditInfoZ(editC, new SordZ(0));

                EditInfo ed = Conn.Ix.checkoutDoc(sordVal.guid, null, editZ, LockC.NO);

                // object has versions and/or attachments
                if (ed.document != null)
                {
                    // The current working versions might have been set by 
                    // a previsious call to Version.File=c:/hello.txt.
                    // Thus do not overwrite the current working versions.

                    FWDocVersion wver = docs.WorkVersion;
                    FWDocVersion watt = atts.WorkVersion;

                    if (ed.document.docs != null && ed.document.docs.Length != 0)
                    {
                        DocVersion dv = ed.document.docs[0];
                        if (wver == null)
                        {
                            // ANPASSUNG
                            if(dv.workVersion)  // <-- Diese Zeile wurde eingefügt
                                wver = docs.InternalAdd(dv);
                        }
                        else if (wver.Signature == null)
                        {
                            wver.Signature = ClassFactory.NewDocVersion(dv.sig, this, FWDocVersionType.TYPE_SIGNATURE);
                        }
                    }

                    if (watt == null)
                    {
                        if (ed.document.atts != null && ed.document.atts.Length != 0)
                        {
                            DocVersion dv = ed.document.atts[0];
                            watt = atts.InternalAdd(dv);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns the collection of all document versions.
        /// </summary>
        public virtual FWDocVersions Versions
        {
            get
            {
                readAllVersions();
                return docs;
            }
        }

        /// <summary>
        /// Returns the collection of all attachment versions.
        /// </summary>
        public virtual FWDocVersions Attachments
        {
            get
            {
                readAllVersions();
                return atts;
            }
        }

        /// <summary>
        /// Read all versions.
        /// </summary>
        /// <returns></returns>
        protected virtual void readAllVersions()
        {
            if (haveReadAll) return;
            haveReadAll = true;
            if (sordVal.id < 0) return;

            FWDocVersion wdoc = Version;
            FWDocVersion watt = Attachment;

            EditInfoZ editZ = new EditInfoZ(EditInfoC.mbDocumentMembers|EditInfoC.mbAttachmentMembers, new SordZ(0));
            EditInfo ed = Conn.Ix.checkoutDoc(sordVal.guid, "-1", editZ, LockC.NO);

            if (ed.document.docs != null)
            {
                foreach (DocVersion dv in ed.document.docs)
                {
                    if (wdoc != null)
                    {
                        if (wdoc.Id == dv.id) continue;
                        dv.workVersion = false;
                    }
                    docs.InternalAdd(dv);
                }
            }
            else

            if (ed.document.atts != null)
            {
                foreach (DocVersion dv in ed.document.atts)
                {
                    FWDocVersion xdv = ClassFactory.NewDocVersion(dv, this, FWDocVersionType.TYPE_ATTACHMENT);
                    if (watt != null)
                    {
                        if (watt.Id == dv.id) continue;
                        dv.workVersion = false;
                    }
                    atts.InternalAdd(dv);
                }
            }
            
        }

        /// <summary>
        /// Call checkinDocBegin for all modified versions.
        /// </summary>
        /// <param name="xdvs">Collection of modified versions.</param>
        /// <returns></returns>
        protected virtual List<FWDocVersion> prepareModifiedVersions(FWDocVersions xdvs)
        {
            List<FWDocVersion> modifiedVersions = new List<FWDocVersion>(xdvs.Count);
            foreach (FWDocVersion xdv in xdvs)
            {
                // File modified?
                if (xdv.FileModified)
                {
                    // prepare for upload: encryption set, path ID
                    xdv.prepareCheckinDocBegin(sordVal);
                    modifiedVersions.Add(xdv);
                }
                else if (xdv.Modified)
                {
                    // only version comment etc. changed 
                    modifiedVersions.Add(xdv);
                }
            }
            return modifiedVersions;
        }

        /// <summary>
        /// Assign the DocVersion objects returned by checkinDocBegin.
        /// </summary>
        /// <param name="modifiedVersions">Collection of modified versions.</param>
        /// <param name="dvs">Array of version objects returned from checkinDocBegin</param>
        protected virtual void assignPreparedDocVersions(List<FWDocVersion> modifiedVersions, DocVersion[] dvs)
        {
            for (int i = 0; i < modifiedVersions.Count; i++)
            {
                FWDocVersion xdv = modifiedVersions[i];
                if (xdv.FileModified)
                {
                    xdv.Core = dvs[i];
                }
                else if (xdv.Modified)
                {
                    // checkinDocBegin sets DocVersion.id=0 because  
                    // upload-URLs in DocVersion.url are created for inserting new Versions.
                    // Since we do not want to insert a new version here (file was not modified),
                    // we restore the version ID.
                    int versionId = xdv.Id;
                    xdv.Core = dvs[i];
                    xdv.Id = versionId;
                }
            }
        }

        /// <summary>
        /// Extracts the DocVersion objects wrapped by the framework objects into an array.
        /// </summary>
        /// <param name="xdvs">Collection of framework version objects.</param>
        /// <returns>Array of DocVersion objects.</returns>
        protected virtual DocVersion[] extractInternalVersionObjects(List<FWDocVersion> xdvs)
        {
            DocVersion[] dvs = new DocVersion[xdvs.Count];
            for (int i = 0; i < xdvs.Count; i++)
            {
                dvs[i] = xdvs[i].Core;
            }
            return dvs;
        }

        /// <summary>
        /// Uploads all modified versions.
        /// </summary>
        /// <returns>Document object upload information.</returns>
        protected virtual Document uploadAllModifiedVersions()
        {
            // get all modified document and attachment versions
            List<FWDocVersion> modifiedDocVersions = prepareModifiedVersions(docs);
            List<FWDocVersion> modifiedAttVersions = prepareModifiedVersions(atts);

            // provide the DocVersion objects to call checkinDocBegin
            Document doc = new Document();
            doc.docs = extractInternalVersionObjects(modifiedDocVersions);
            doc.atts = extractInternalVersionObjects(modifiedAttVersions);

            // if there is anything changed
            if (doc.docs.Length != 0 || doc.atts.Length != 0)
            {
                // set the original file name from the current working version
                setOriginalFileNameFromModifiedVersions(modifiedDocVersions);

                // supply the object ID for checkinDocBegin
                if (sordVal.id > 0)
                {
                    doc.objId = sordVal.guid;
                }

                // checkinDocBegin provides the upload URLs
                doc = Conn.Ix.checkinDocBegin(doc);

                // replace the current DocVersion objects inside the framework objects
                // with the ones returned by checkinDocBegin
                assignPreparedDocVersions(modifiedDocVersions, doc.docs);
                assignPreparedDocVersions(modifiedAttVersions, doc.atts);

                // upload all modified files
                uploadFiles(modifiedDocVersions);
                uploadFiles(modifiedAttVersions);
            }

            return doc;
        }

        /// <summary>
        /// Upload the files in the given version objects.
        /// </summary>
        /// <param name="xdvs">Collection of version objects</param>
        protected virtual void uploadFiles(List<FWDocVersion> xdvs)
        {
            foreach (FWDocVersion xdv in xdvs)
            {
                xdv.upload();
            }
        }

        /// <summary>
        /// Set the original file name in the Sord, if the Sord has not already a working version 
        /// (new document or document without file).
        /// </summary>
        /// <param name="docs">Collection of versions.</param>
        protected virtual void setOriginalFileNameFromModifiedVersions(List<FWDocVersion> docs)
        {
            if (sordVal.doc == 0)
            {
                for (int i = docs.Count - 1; i >= 0; i--)
                {
                    FWDocVersion xdv = docs[i];
                    if (xdv.WorkVersion)
                    {
                        String file = xdv.File;
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        if (file != null)
                        {
                            OriginalFileName = fi.Name;
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Marks the version, preview, signature, attatchment files as invalid.
        /// </summary>
        protected virtual void InvalidateFiles()
        {
            foreach (FWDocVersion dv in docs)
            {
                dv.InvalidateFiles();
            }
            foreach (FWDocVersion dv in atts)
            {
                dv.InvalidateFiles();
            }
        }

        /// <summary>
        /// Checkin or delete the object. 
        /// </summary>
        /// <remarks>
        /// This function uploads all modified versions, attachments, previews, signatures
        /// and resets the lockId.
        /// </remarks>
        public override void Checkin()
        {

            if (sordVal.deleted)
            {
                InvalidateFiles();
                Conn.Ix.deleteSord(null, sordVal.guid, LockC.YES, null);
                sordVal.lockId = -1;
            }
            else
            {

                // Upload all modified versions.
                // This makes the files read-only and the DownloadManager will
                // delete them.
                Document doc = uploadAllModifiedVersions();

                // Write all changed members.
                SordZ sordZ = new SordZ(sordVal.changedMembers);
                doc = Conn.Ix.checkinDocEnd(sordVal, sordZ, doc, LockC.YES);
                sordVal.lockId = -1;
                sordVal.id = Convert.ToInt32(doc.objId);
                // try to refresh internal data
                // fails if user lacks read rights
                try
                {
                    Refresh();
                }
                catch (Exception ex)
                {
                    if (Conn != null && Conn.Valid)
                    {
                        IXExceptionData exceptionData = Conn.Ix.parseException(ex.Message);

                        if (exceptionData == null ||
                            exceptionData.exceptionType != IXExceptionC.ACCESS_DENIED)
                        {
                            throw;
                        }
                    }

                    else
                    {
                        throw;
                    }
                }

                InvalidateFiles();
            }
        }
        
        /// <summary>
        /// Checkin the object as a new object at a new location with a new name.
        /// </summary>
        /// <param name="parentId">Th eparent of the new object.</param>
        /// <param name="name">The name of the new object.</param>
        /// <returns>The ID of the new document.</returns>
        public virtual int CheckinAs(int parentId, string name, string file, Func<FWDocument, bool> keywordingAndCheckinFunction = null)
        {
            FWDocument newDocument = Conn.Content.CreateDocument(parentId, this.MaskId);
            
            //newDocument.Core.copyMembers(Core);
            newDocument.File = file;
            newDocument.Name = name;
            newDocument.Version.Version = "1";

            if (LockId > 0)
                Unlock();

            if (null != keywordingAndCheckinFunction)
                keywordingAndCheckinFunction(newDocument);
            else
                newDocument.Checkin();

            return newDocument.Id;
        }

        /// <summary>
        /// Unlock the document and discard all downloaded or assigned
        /// versions, attachments, previews, signatures.
        /// </summary>
        public override void Unlock()
        {
            //InvalidateFiles();
            base.Unlock();
            InvalidateFiles();
        }

        /// <summary>
        /// obsolete
        /// </summary>
        /// <param name="fileName">obsolete</param>
        [Obsolete("Do not call this method.", true)]
        public void DoDelete(object fileName)
        {
            bool deleted = false;
            while (!deleted)
            {
                System.Threading.Thread.Sleep(100);
                try
                {
                    System.IO.File.Delete((string)fileName);
                    deleted = true;
                }
                catch { }
            }
        }

        /// <summary>
        /// Reinitializes the object.
        /// </summary>
        /// <remarks>
        /// The internal state is beeing read from the IndexServer and 
        /// all modifications get lost.
        /// A possibly assigned lock is not removed.
        /// </remarks>
        public override void Refresh()
        {
            base.Refresh();
            Init();
        }
    }
}

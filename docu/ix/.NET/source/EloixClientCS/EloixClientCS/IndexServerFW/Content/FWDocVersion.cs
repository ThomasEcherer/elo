using System;
using System.IO;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// Type of FWDocVersion. Used in <see cref="FWDocVersion.Type">FWDocVersion.Type</see>.
    /// </summary>
    /// <seealso cref="FWDocVersion.Type"/>
    public enum FWDocVersionType
    {
        /// <summary>
        /// FWDocVersion object is a document version.
        /// </summary>
        TYPE_VERSION,
        /// <summary>
        /// FWDocVersion object is an attachment version.
        /// </summary>
        TYPE_ATTACHMENT,
        /// <summary>
        /// FWDocVersion object is a signature of a document version.
        /// </summary>
        TYPE_SIGNATURE,
        /// <summary>
        /// FWDocVersion object is a preview of a document version.
        /// </summary>
        TYPE_PREVIEW
    };

    /// <summary>
    /// This class represents a document version, attachment version, signature or preview.
    /// It provides access to an existing archived file or can upload a new file.
    /// The version information assigned to a document or attachment version can
    /// be accessed.
    /// </summary>
    public class FWDocVersion : FWContentBase
    {

        /// <summary>
        /// Internal document version object.
        /// </summary>
        protected DocVersion dvVal;
        /// <summary>
        /// File name of the downloaded version on the local computer.
        /// </summary>
        protected String fileVal;
        /// <summary>
        /// Version type.
        /// </summary>
        protected FWDocVersionType typeVal;
        /// <summary>
        /// Only document versions: reference to the versions signature.
        /// </summary>
        protected FWDocVersion sigVal;
        /// <summary>
        /// Only document versions: reference to the versions preview.
        /// </summary>
        protected FWDocVersion previewVal;
        /// <summary>
        /// True, if this object is a new version that will be uploaded.
        /// </summary>
        protected bool forUpload;
        /// <summary>
        /// True, if this object was modified. 
        /// </summary>
        protected bool modifiedVal;
        /// <summary>
        /// Sord object.
        /// </summary>
        protected FWSord sord;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ifc">Content interface object</param>
        /// <param name="dv">Internal document version object</param>
        /// <param name="sord">Sord object</param>
        /// <param name="type">Version type</param>
        public FWDocVersion(FWContentInterface ifc, DocVersion dv, FWSord sord, FWDocVersionType type)
            : base(ifc)
        {
            this.typeVal = type;
            this.dvVal = dv;
            this.sord = sord;
            updateInternalData(false);
        }

        /// <summary>
        /// Makes a file name to be used in the cache directory.
        /// </summary>
        /// <returns>File name</returns>
        protected virtual String internalMakeCacheFileName()
        {
            // Get file name from ObjKey or Sord.name
            String name = sord.OriginalFileName;
            if (name == null || name.Length == 0)
            {
                name = sord.Name;
            }
            else
            {
                // strip extension, will be added from DocVersion.ext
                int p = name.LastIndexOf('.');
                if (p >= 0) name = name.Substring(0, p);
            }

            if (!dvVal.workVersion)
            {
                if (dvVal.version != null && dvVal.version.Length != 0)
                {
                    name = name + "-" + dvVal.version;
                }
                else
                {
                    name = name + "-version";
                }
            }

            switch (typeVal)
            {
                case FWDocVersionType.TYPE_SIGNATURE:
                    name = name + "-signature";
                    break;
                case FWDocVersionType.TYPE_PREVIEW:
                    name = name + "-preview";
                    break;
                case FWDocVersionType.TYPE_ATTACHMENT:
                    name = name + "-attachment";
                    break;
            }

            return name;
        }

        /// <summary>
        /// Document version ID.
        /// </summary>
        public int Id
        {
            get { return dvVal.id; }
            set { dvVal.id = value; }
        }

        /// <summary>
        /// Get or set the modified state.
        /// </summary>
        public virtual bool Modified
        {
            get
            {
                bool ret = modifiedVal ||
                  (sigVal != null && sigVal.Modified) ||
                  (previewVal != null && previewVal.Modified);

                if (!ret)
                {
                    ret = FileModified;
                }

                return ret;
            }
            set { modifiedVal = value; }
        }

        /// <summary>
        /// Gets or sets the modified state (FileAttribute.Archive) of the file.
        /// Modified files are uploaded, if the Commit function of the document 
        /// object is called.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the property is read, it returns true, if the FileAttribute.Archive is set.
        /// </para>
        /// <para>
        /// If the property is set to true, it sets the FileAttribute.Archive and resets 
        /// the FileAttribute.ReadOnly.
        /// </para>
        /// <para>
        /// If the property is set to false, DownloadManager.InvalidateFile is called.
        /// The download manager will delete the file in the next cleanup loop.
        /// </para>
        /// </remarks>
        public virtual bool FileModified
        {
            get
            {
                bool m = false;
                if (fileVal != null)
                {
                    if (ifc.DownloadManager.IsControlledFile(fileVal))
                    {
                        // If file is controlled by the download manager, 
                        // check file attributes.

                        System.IO.FileInfo fi = new System.IO.FileInfo(fileVal);
                        if (fi.Exists)
                        {
                            m = (fi.Attributes & System.IO.FileAttributes.Archive) != 0;
                        }
                    }
                    else
                    {
                        // If file is not controlled by the download manager,
                        // tread this file always as modified. Thus, a Checkin
                        // call will always upload the file.

                        m = true;
                    }
                }
                return m;
            }

            set
            {
                if (fileVal != null)
                {
                    if (ifc.DownloadManager.IsControlledFile(fileVal))
                    {
                        // Modify the attributes only if the file is 
                        // controlled by the download manager.
                        System.IO.FileInfo fi = new System.IO.FileInfo(fileVal);
                        if (fi.Exists)
                        {
                            System.IO.FileAttributes attrs = fi.Attributes;
                            if (value)
                            {
                                fi.Attributes = System.IO.FileAttributes.Archive;
                            }
                            else
                            {
                                fi.Attributes = System.IO.FileAttributes.ReadOnly;
                            }
                        }
                    }
                    else
                    {
                        // If not controlled by the download manager, 
                        // clear the internal file path variable.
                        // This prevents the file to be uploaded in Checkin.
                        if (!value)
                        {
                            fileVal = null;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Converts the values from the internal document version object.
        /// </summary>
        /// <param name="save">true, to save into the internal document object</param>
        protected virtual void updateInternalData(bool save)
        {
            if (save)
            {
            }
            else
            {
                if (dvVal != null)
                {
                    if (dvVal.sig != null)
                    {
                        if (this.sigVal == null)
                        {
                            this.sigVal = ClassFactory.NewDocVersion(dvVal.sig, sord, FWDocVersionType.TYPE_SIGNATURE);
                        }
                        else
                        {
                            this.sigVal.Core = dvVal.sig;
                        }
                    }
                    if (dvVal.preview != null)
                    {
                        if (this.previewVal == null)
                        {
                            this.previewVal = ClassFactory.NewDocVersion(dvVal.preview, sord, FWDocVersionType.TYPE_PREVIEW);
                        }
                        else
                        {
                            this.previewVal.Core = dvVal.preview;
                        }
                    }
                }
                else
                {
                    dvVal = new DocVersion();
                    dvVal.encryptionSet = sord.Core.details.encryptionSet;
                    dvVal.pathId = sord.Core.path;
                }
            }
        }

        /// <summary>
        /// Get or set the internal document version object.
        /// </summary>
        public DocVersion Core
        {
            get { return dvVal; }
            set
            {
                dvVal = value;
                updateInternalData(false);
            }
        }

        /// <summary>
        /// Returns the URL to download the version file.
        /// </summary>
        public String Url
        {
            get { return dvVal.url; }
        }

        internal String checkStringLength(String propName, String propValue, int max)
        {
            if (propValue.Length > max)
            {
                throw new InvalidOperationException(propName + " must not be longer than " + max + " characters.");
            }
            return propValue;
        }

        /// <summary>
        /// Get or set the version number.
        /// </summary>
        public String Version
        {
            get { return dvVal.version; }
            set
            {
                dvVal.version = checkStringLength("Version", value, Conn.CONST.DOC_VERSION.lnVersion);
                Modified = true;
            }
        }

        /// <summary>
        /// Get or set the version comment.
        /// </summary>
        public String Comment
        {
            get { return dvVal.comment; }
            set
            {
                dvVal.comment = checkStringLength("Comment", value, Conn.CONST.DOC_VERSION.lnComment);
                Modified = true;
            }
        }

        /// <summary>
        /// Document version file name
        /// </summary>
        /// <remarks>
        /// <para>
        /// If this property is read the first time, the version file is downloaded
        /// into the cache directory. 
        /// </para>
        /// <para>
        /// If this member is set, the document version object is marked for uploading.
        /// </para>
        /// </remarks>
        public virtual String File
        {
            get
            {
                if (fileVal == null || !System.IO.File.Exists(fileVal))
                {
                    String u = dvVal.url;

                    // download the file, if it's a read-URL 
                    // (DocVersion contains a write-URL after checkinDocBegin)
                    if (u != null && u.IndexOf("readdoc") >= 0)
                    {
                        // download file
                        String name = internalMakeCacheFileName();
                        fileVal = ifc.DownloadManager.Download(Url, name, dvVal.ext, sord.Id.ToString(), dvVal.id.ToString());

                        // if we got a lock on the document, 
                        // make file writable. 
                        if (sord.Core.lockId == Conn.Session.User.id)
                        {
                            FileInfo fi = new FileInfo(fileVal);
                            FileAttributes attrs = fi.Attributes;
                            attrs &= ~FileAttributes.ReadOnly;
                            attrs |= FileAttributes.Archive;
                            fi.Attributes = attrs;
                        }
                    }
                }
                return fileVal;
            }
            set
            {
                if (value != null)
                {
                    if (WorkVersion && (sord.Name == null || sord.Name == ""))
                    {
                        FileInfo fi = new FileInfo(value);
                        String n = fi.Name;
                        int p = n.LastIndexOf('.');
                        sord.Name = (p >= 0) ? n.Substring(0, p) : n;
                    }
                    forUpload = true;
                    fileVal = value;

                    // extVal:
                    {
                        int p = value.LastIndexOf(".");
                        if (p >= 0) dvVal.ext = value.Substring(p + 1, value.Length - p - 1);
                    }

                    Modified = true;
                }
                else
                {
                    forUpload = false;
                    fileVal   = null;
                    Modified  = false;
                    //dvVal.ext = "";
                }

            }
        }

        /// <summary>
        /// Returns the file size of the version.
        /// </summary>
        public virtual long Size
        {
            get { return dvVal.size; }
        }

        /// <summary>
        /// Get the file size formatted in KB.
        /// </summary>
        public virtual String SizeKB
        {
            get
            {
                long l = (dvVal.size / 1024);
                if (dvVal.size % 1024 != 0)
                {
                    l++;
                }
                return l.ToString("N0") + " KB";
            }
        }

        /// <summary>
        /// Gets or sets the flag which determines, wether the version
        /// is the current working version.
        /// </summary>
        public bool WorkVersion
        {
            get { return dvVal.workVersion; }
            set { dvVal.workVersion = value; if (value) Modified = true; }
        }

        /// <summary>
        /// Gets or sets the flag which determines, wether the version
        /// is a milestone version.
        /// </summary>
        public bool Milestone
        {
            get { return dvVal.milestone; }
            set { dvVal.milestone = value; Modified = true; }
        }

        /// <summary>
        /// Gets the document version type.
        /// </summary>
        public FWDocVersionType Type
        {
            get { return typeVal; }
        }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime CreateDate
        {
            get { return Conn.IsoToDate(dvVal.createDateIso); }
            set { dvVal.createDateIso = Conn.DateToIso(value); }
        }

        /// <summary>
        /// Owner ID
        /// </summary>
        public int OwnerId
        {
            get { return dvVal.ownerId; }
            set { dvVal.ownerId = value; }
        }
        /// <summary>
        /// Owner name
        /// </summary>
        public String OwnerName
        {
            get { return dvVal.ownerName; }
            set { dvVal.ownerName = value; }
        }


        /// <summary>
        /// Gets or sets a signature object.
        /// </summary>
        public virtual FWDocVersion Signature
        {
            get { return sigVal; }
            set
            {
                if (typeVal != FWDocVersionType.TYPE_VERSION)
                {
                    throw new InvalidOperationException("Expected TYPE_VERSION");
                }
                this.sigVal = value;
                this.dvVal.sig = value.Core;
                Modified = true;
            }
        }

        /// <summary>
        /// Gets or sets a signature file.
        /// </summary>
        /// <remarks>
        /// This property accesses the File property of the associated signature object.
        /// </remarks>
        /// <seealso cref="Signature"/>
        public virtual String SignatureFile
        {
            get { return this.sigVal != null ? this.sigVal.File : null; }
            set
            {
                if (typeVal != FWDocVersionType.TYPE_VERSION)
                {
                    throw new InvalidOperationException("Expected IXDocVersion.TYPE_VERSION");
                }
                if (sigVal == null)
                {
                    sigVal = ClassFactory.NewDocVersion(new DocVersion(), sord, FWDocVersionType.TYPE_SIGNATURE);
                }
                sigVal.File = value;
                dvVal.sig = sigVal.Core;
                Modified = true;
            }
        }

        /// <summary>
        /// Gets or sets a preview object.
        /// </summary>
        public virtual FWDocVersion Preview
        {
            get { return previewVal; }
            set
            {
                if (typeVal != FWDocVersionType.TYPE_VERSION)
                {
                    throw new InvalidOperationException("Expected IXDocVersion.TYPE_VERSION");
                }
                this.previewVal = value;
                this.dvVal.preview = value.Core;
                Modified = true;
            }
        }

        /// <summary>
        /// Gets or sets a preview file.
        /// </summary>
        /// <remarks>
        /// This property accesses the File property of the associated preview object.
        /// </remarks>
        /// <seealso cref="Preview"/>
        public virtual String PreviewFile
        {
            get { return this.previewVal != null ? this.previewVal.File : null; }
            set
            {
                if (typeVal != FWDocVersionType.TYPE_VERSION)
                {
                    throw new InvalidOperationException("Expected IXDocVersion.TYPE_VERSION");
                }
                previewVal = ClassFactory.NewDocVersion(new DocVersion(), sord, FWDocVersionType.TYPE_PREVIEW);
                previewVal.File = value;
                dvVal.preview = previewVal.Core;
                Modified = true;
            }
        }

        /// <summary>
        /// Helper function to upload the version file.
        /// </summary>
        internal virtual void upload()
        {
            if (forUpload || FileModified)
            {
                String r = Conn.internalConnection.Upload(Core.url, File);
                Core.uploadResult = r;
                FileModified = false;
            }
            if (sigVal != null)
            {
                sigVal.upload();
            }
            if (previewVal != null)
            {
                previewVal.upload();
            }
        }

        /// <summary>
        /// Is called before the version is checked in to supply the 
        /// storage path ID and encryption set ID from the given Sord object.
        /// </summary>
        /// <param name="sord">Sord object with path and encryption set.</param>
        internal void prepareCheckinDocBegin(Sord sord)
        {
            dvVal.pathId = sord.path;

            // set the name and id of the owner of the DocVersion to the 
            // currently logded on user's values.
            if (Conn != null && Conn.Valid && Conn.Session != null && Conn.Session.User != null)
            {
                dvVal.ownerId = Conn.Session.User.id;
                dvVal.ownerName = Conn.Session.User.name;
            }

            if (typeVal == FWDocVersionType.TYPE_VERSION)
            {
                dvVal.encryptionSet = sord.details.encryptionSet;
            }
        }

        /// <summary>
        /// Marks the version, preview, signature, attatchment files as invalid.
        /// </summary>
        public void InvalidateFiles()
        {
            if (fileVal != null)
            {
                ifc.DownloadManager.InvalidateFile(fileVal);
            }
            if (previewVal != null)
            {
                previewVal.InvalidateFiles();
            }
            if (sigVal != null)
            {
                sigVal.InvalidateFiles();
            }
        }

    }
}

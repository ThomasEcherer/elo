using System;
using System.Drawing;
using System.Text;
using System.Linq;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.MasterData;
using EloixClient.IndexServerFW.Utils;
using System.ComponentModel;

namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// This class represents a folder or document. It encapsulates the 
    /// Sord class from the IndexServer API.
    /// </summary>
    public class FWSord : FWContentBase
    {
        /// <summary>
        /// Sord object.
        /// </summary>
        protected Sord sordVal;
        /// <summary>
        /// ObjKey helper object.
        /// </summary>
        /// <remarks
        protected FWObjKeys objKeysVal;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ifc">Content interface object</param>
        /// <param name="sord">Sord object from IndexServer API</param>
        public FWSord(FWContentInterface ifc, Sord sord)
            : base(ifc)
        {
            Init(sord);
        }


        

        /// <summary>
        /// Gets or sets the name (short description) of the entry.
        /// </summary>
        public virtual String Name
        {
            get { return sordVal.name; }
            set 
            { 
                sordVal.name = value;
            }
        }
        /// <summary>
        /// Gets or sets the numeric ID of the entry.
        /// </summary>
        public virtual int Id 
        { 
            get { return sordVal.id; } 
            internal set 
            { 
                sordVal.id = value;
            } 
        }
        /// <summary>
        /// Gets or sets the GUID of the entry.
        /// </summary>
        public virtual String Guid 
        { 
            get { return sordVal.guid; } 
            internal set 
            { 
                sordVal.guid = value;
            } 
        }

        /// <summary>
        /// Gets the RGB Color value of the entry.
        /// </summary>
        public virtual Color RGBColor 
        {
            get
            {
                FWColor col = null;
                if (!Conn.MasterData.Colors.TryGetValue(sordVal.kind, out col))
                {
                    col = Conn.MasterData.Colors[0];
                }
                return col.RGBColor;
            }
        }

        /// <summary>
        /// Gets or sets the description. 
        /// If the description is read on reading, when it is not set.
        /// </summary>
        public virtual String Desc
        {
            get
            {
                if ((sordVal.changedMembers & SordC.mbDesc) == 0)
                {
                    EditInfoZ editZ = new EditInfoZ(0L, new SordZ(SordC.mbDesc));
                    EditInfo ed = Conn.Ix.checkoutSord(sordVal.guid, editZ, LockC.NO);
                    sordVal.desc = ed.sord.desc;
                    sordVal.hiddenText = ed.sord.hiddenText;
                }
                return sordVal.desc;
            }
            set
            {
                sordVal.desc = value;
            }
        }
        /// <summary>
        /// Gets or sets the archiving date of the entry.
        /// </summary>
        public virtual DateTime IDate
        {
            get
            {
                return Conn.IsoToDate(sordVal.IDateIso);
            }
            set
            {
                sordVal.IDateIso = Conn.DateToIso(value);
            }
        }
        /// <summary>
        /// Gets or sets the document date of the entry.
        /// </summary>
        public virtual DateTime XDate
        {
            get
            {
                return Conn.IsoToDate(sordVal.XDateIso);
            }
            set
            {
                sordVal.XDateIso = Conn.DateToIso(value);
            }
        }
        /// <summary>
        /// Gets or sets the keywording form ID (DocMask) of the entry.
        /// If the value is written, the IndexServer API function changeSordMask is called.
        /// </summary>
        public virtual int MaskId
        {
            get
            {
                return sordVal.mask;
            }
            set
            {
                sordVal.mask = value;
                EditInfoZ editZ = new EditInfoZ(0, new SordZ(sordVal.changedMembers));
                sordVal = Conn.Ix.changeSordMask(sordVal, Convert.ToString(value), editZ).sord;
            }
        }
        /// <summary>
        /// Gets the Sord object.
        /// </summary>
        public virtual Sord Core
        {
            get
            {
                return sordVal;
            }
        }
        /// <summary>
        /// Gets the ObjKeys helper object.
        /// </summary>
        public virtual FWObjKeys ObjKeys
        {
            get
            {
                return objKeysVal;
            }
        }
        /// <summary>
        /// Gets/sets the original file name property.
        /// </summary>
        public virtual String OriginalFileName
        {
            get
            {
                return objKeysVal[DocMaskLineC.ID_FILENAME].Value;
            }
            set
            {
                objKeysVal[DocMaskLineC.ID_FILENAME].Value = value;
            }
        }

        /// <summary>
        ///   Gets an value indicating if archive entry is linked to another archive entries.
        /// </summary>
        public bool IsLinked
        {
            get
            {
                // Die Aktualisierung ist notwendig da sonst die Links in FWSord verfügbar sind. Erst nach dem Refresh werden sie geladen.
                Refresh();
                try
                {
                    return ((Core != null && Core.linksGoOut != null && Core.linksGoOut.Count() > 0) || (Core != null && Core.linksComeIn != null && Core.linksComeIn.Count() > 0));
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Deletes the Sord object (logically).
        /// </summary>
        public virtual void Delete()
        {
            sordVal.deleted = true;
            Checkin();
        }
        /// <summary>
        /// Writes all changes to the sord object into the archive and removes the lock.
        /// </summary>
        public virtual void Checkin()
        {
            if (sordVal.deleted)
            { 
                // set the deleted flag according to success or failure of the operation
                sordVal.deleted = Conn.Ix.deleteSord(null, sordVal.guid, LockC.YES, null);
            }
            else
            {
                SordZ sordZ = new SordZ(sordVal.changedMembers);
                int objId = Conn.Ix.checkinSord(sordVal, sordZ, LockC.YES);
                sordVal.id = objId;
                sordVal.lockId = -1;
            }
        }
        /// <summary>
        /// Removes the lock that was set by LockDocument or LockFolder.
        /// </summary>
        public virtual void Unlock()
        {
            if (sordVal.id > 1)
            {
                Sord sord = new Sord();
                sord.id = sordVal.id;
                sord.guid = sordVal.guid;
                Conn.Ix.checkinSord(sord, SordC.mbOnlyUnlock, LockC.YES);
                sordVal.lockId = -1;
            }
        }
        /// <summary>
        /// Returns true, if the object refers to a document.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsDocument()
        {
            return (this is FWDocument);
        }
        /// <summary>
        /// Gets/sets the type of the object.
        /// </summary>
        public virtual int Type
        {
            get { return sordVal.type; }
            set 
            { 
                sordVal.type = value;
            }
        }
        /// <summary>
        /// Prints ID and name into a String.
        /// </summary>
        /// <returns>String [id,name] </returns>
        public override string ToString()
        {
            StringBuilder sbuf = new StringBuilder();
            sbuf.Append("[").Append(this.Id).Append(",").Append(this.Name).Append("]");
            return sbuf.ToString();
        }

        /// <summary>
        /// Gets the image index in the image list of the SortTypeCache.
        /// </summary>
        /// <remarks>This property returns the default image list index - not the index for the reference or workflow image.</remarks>
        /// <seealso cref="SordTypeImageList"/>
        public virtual int ImageIndex
        {
            get
            {
                int v = this.ifc.Conn.MasterData.SordTypes.ImageList.getImageIndex(Type, false, false);
                return v;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                SordTypeImageList sordTypeImageList = this.ifc.Conn.MasterData.SordTypes.ImageList;
                int imageIndex = ImageIndex;
                System.Drawing.Image image = sordTypeImageList.Images.Images[imageIndex];
                return image;
            }
        }

        /// <summary>
        /// Gets or sets the parent ID.
        /// </summary>
        public virtual int ParentId
        {
            get { return sordVal.parentId; }
            set 
            { 
                sordVal.parentId = value;
            }
        }

        /// <summary>
        /// Gets or sets the owner ID.
        /// </summary>
        public virtual int OwnerId
        {
            get { return sordVal.ownerId; }
            set 
            { 
                sordVal.ownerId = value;
            }
        }

        /// <summary>
        /// Gets or sets the owner name.
        /// </summary>
        public virtual String OwnerName
        {
            get { return sordVal.ownerName; }
            set 
            { 
                sordVal.ownerName = value;
            }
        }

        /// <summary>
        /// Gets the id of tje user who has locked the object.
        /// </summary>
        public virtual int LockId
        {
            get { return sordVal.lockId; }
        }

        /// <summary>
        /// The name of the user who has locked the object.
        /// </summary>
        public virtual string LockName
        {
            get { return sordVal.lockName; }
        }

        /// <summary>
        /// Gets the archive path as a string separated by /.
        /// </summary>
        public virtual String ArcPathString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (ParentId != 0)
                {
                    ArcPath refPaths = RefPaths[0];
                    for (int i = 0; i < refPaths.path.Length; i++)
                    {
                        sb.Append("/").Append(refPaths.path[i].name);
                    }
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Gets the archive path and reference paths of the FWSord.
        /// </summary>
        /// <remarks>If the reference paths member is not set, a server request is made to read it.</remarks>
        public virtual ArcPath[] RefPaths
        {
            get
            {
                if ((sordVal.changedMembers & SordC.mbRefPaths) == 0)
                {
                    Sord sordTmp = Conn.Ix.checkoutSord(sordVal.guid, new EditInfoZ(0, new SordZ(SordC.mbRefPaths)), LockC.NO).sord;
                    sordVal.refPaths = sordTmp.refPaths;
                }
                if (sordVal.refPaths == null || sordVal.refPaths.Length == 0)
                {
                    sordVal.refPaths = new ArcPath[] { new ArcPath() };
                    sordVal.refPaths[0].path = new IdName[0];
                }
                return sordVal.refPaths;
            }
        }
        /// <summary>
        /// Create a logical copy (reference) of this in the folder given by destination.
        /// </summary>
        /// <param name="destination">A reference is created in this folder.</param>
        public void Copy(FWSord destination)
        {
            Conn.Ix.refSord(null, destination.Id.ToString(), Id.ToString(), -1);
            destination.Refresh();
        }

        /// <summary>
        /// Move this object from the current parent folder given in source to the destination folder.
        /// </summary>
        /// <param name="source">Source folder, can be null in which case the main parent folder is used.</param>
        /// <param name="destination">Destination folder.</param>
        public void Move(FWSord source, FWSord destination)
        {
            string sourceId = (source != null) ? source.Id.ToString() : null;
            Conn.Ix.refSord(sourceId, destination.Id.ToString(), Id.ToString(), -1);
            Refresh();
            source.Refresh();
            destination.Refresh();
        }

        /// <summary>
        /// Reads the object from the IndexServer.
        /// </summary>
        /// <remarks>
        /// All modifications get lost. 
        /// A possibly existing lock is not released.
        /// </remarks>
        public virtual void Refresh()
        {
            Sord sord = Conn.Ix.checkoutSord(Id.ToString(), Conn.Content.EditZ, LockC.NO).sord;
            Init(sord);
        }
        /// <summary>
        /// Returns the ACL helper class.
        /// </summary>
        public FWAclItems AclItems
        {
            get { return new MyAclItems(this); }
        }

        /// <summary>
        /// Initializes the internal objects by the given Sord.
        /// </summary>
        /// <param name="sord">Sord object</param>
        /// <remarks>This function is called in the constructor and in Refresh()</remarks>
        private void Init(Sord sord)
        {
            this.sordVal = sord;
            this.objKeysVal = new MyObjKeys(this);
        }

        internal class MyObjKeys : FWObjKeys
        {
            private FWSord _sord;

            internal MyObjKeys(FWSord sord) : base(sord.Conn, sord.Core.mask.ToString())
            {
                _sord = sord;
            }

            public override ObjKey[] Items
            {
                get {return _sord.Core.objKeys; }
                set { _sord.Core.objKeys = value; }
            }
        }

        /// <summary>
        /// Implementation class for ACL items that operates on this.Core.aclItems.
        /// </summary>
        private class MyAclItems : FWAclItems
        {
            private FWSord _sord;

            internal MyAclItems(FWSord sord)
                : base(sord.Conn)
            {
                this._sord = sord;
            }

            public override AclItem[] Items
            {
                get { return _sord.Core.aclItems; }
                set { _sord.Core.aclItems = value; _sord.Core.acl = ""; }
            }
        }
    }
}

using System;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// Compares the short descriptions.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByName<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            return CompareString(o1.Name, o2.Name);
        }
    }

    /// <summary>
    /// Compares the external document dates.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByXDate<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            return CompareString(o1.Core.XDateIso, o2.Core.XDateIso);
        }
    }

    /// <summary>
    /// Compares archiving dates.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByIDate<T> : FWCompareSordByXDate<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            return CompareString(o1.Core.IDateIso, o2.Core.IDateIso);
        }
    }

    /// <summary>
    /// Compares the keywording form names (DocMask.name).
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByMaskName<T> : FWCompareObject<T> where T : FWSord
    {
        FWConnection conn;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">Connection object</param>
        public FWCompareSordByMaskName(FWConnection conn)
        {
            this.conn = conn;
        }
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            string name1 = conn.MasterData.DocMasks[o1.MaskId].Name;
            string name2 = conn.MasterData.DocMasks[o2.MaskId].Name;
            return CompareString(name1, name2);
        }
    }

    /// <summary>
    /// Compares the owner names of the Sord objects.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByOwnerName<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            return String.Compare(o1.OwnerName, o2.OwnerName);
        }
    }

    /// <summary>
    /// Compares the version numbers of document versions (DocVersion.version).
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByVersion<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Compare function.
        /// </summary>
        /// <param name="d1">First object</param>
        /// <param name="d2">Second object</param>
        /// <returns></returns>
        public virtual int CompareDocVersion(DocVersion d1, DocVersion d2)
        {
            return String.Compare(d1.version, d2.version);
        }
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            DocVersion d1 = o1.Core.docVersion, d2 = o2.Core.docVersion;
            if (d1 != null && d2 != null)
            {
                return CompareDocVersion(d1, d2);
            }
            if (d1 != null && d2 == null)
            {
                return -1;
            }
            if (d1 == null && d2 != null)
            {
                return 1;
            }
            return 0;
        }
    }

    /// <summary>
    /// Compares the create dates of document versions.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByVersionDate<T> : FWCompareSordByVersion<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="d1">First object</param>
        /// <param name="d2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        public override int CompareDocVersion(DocVersion d1, DocVersion d2)
        {
            return String.Compare(d1.createDateIso, d2.createDateIso);
        }
    }

    /// <summary>
    /// Compares the owner names of document versions.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByVersionOwner<T> : FWCompareSordByVersion<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="d1">First object</param>
        /// <param name="d2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        public override int CompareDocVersion(DocVersion d1, DocVersion d2)
        {
            return String.Compare(d1.ownerName, d2.ownerName);
        }
    }

    /// <summary>
    /// Compares the file sizes of document versions.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByVersionFileSize<T> : FWCompareSordByVersion<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="d1">First object</param>
        /// <param name="d2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        public override int CompareDocVersion(DocVersion d1, DocVersion d2)
        {
            return Math.Sign(d1.size - d2.size);
        }
    }

    /// <summary>
    /// Compares the archiving paths of sord objects.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByArcPath<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            return CompareString(o1.ArcPathString, o2.ArcPathString);
        }
    }

    public class FWCompareSordByLockName<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            return CompareString(o1.LockName, o2.LockName);
        }
    }

    /// <summary>
    /// Compares the index values.
    /// </summary>
    /// <typeparam name="T">FWSord, FWDocument, FWFolder</typeparam>
    public class FWCompareSordByObjKey<T> : FWCompareObject<T> where T : FWSord
    {
        /// <summary>
        /// Group name of index values.
        /// </summary>
        public String groupName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="groupName">Compare index values identified by this group name.</param>
        public FWCompareSordByObjKey(String groupName)
        {
            this.groupName = groupName;
        }
        /// <summary>
        /// Implements the abstract function of FWCompareSord.
        /// </summary>
        /// <param name="o1">First object</param>
        /// <param name="o2">Second object</param>
        /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
        protected override int internalCompare(T o1, T o2)
        {
            FWObjKey okey1 = o1.ObjKeys[groupName];
            FWObjKey okey2 = o2.ObjKeys[groupName];
            return CompareString(
              okey1 != null ? okey1.Data.ToString() : null,
              okey2 != null ? okey2.Data.ToString() : null);
        }
    }

}

using System;
using System.Text;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.MasterData;

namespace EloixClient.IndexServerFW.Content
{
    /// <summary>
    /// Helper class to convert between serveral data types of index values.
    /// </summary>
    public class FWObjKeyValue
    {
        /// <summary>
        /// Value
        /// </summary>
        protected object objectVal;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v">String value</param>
        public FWObjKeyValue(String v)
        {
            objectVal = v != null ? v : "";
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v">DateTime value</param>
        public FWObjKeyValue(DateTime v)
        {
            objectVal = v;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v">Floating point value</param>
        public FWObjKeyValue(double v)
        {
            objectVal = v;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v">Integer value</param>
        public FWObjKeyValue(int v)
        {
            objectVal = v;
        }
        /// <summary>
        /// Returns true if the value is empty.
        /// </summary>
        /// <returns>True, if the value is empty.</returns>
        public bool IsEmpty()
        {
            if (objectVal == null) return true;
            if (objectVal is int) return false;
            if (objectVal is double) return false;
            if (objectVal is DateTime) return false;
            if (objectVal is String) return ((String)objectVal).Length == 0;
            return true;
        }
        /// <summary>
        /// Convert to string
        /// </summary>
        /// <param name="v">Value object</param>
        /// <returns>String value</returns>
        public static implicit operator String(FWObjKeyValue v)
        {
            String ret = "";
            if (v.objectVal is DateTime)
            {
                ret = IXConnection.StaticDateToIso((DateTime)v.objectVal, false);
            }
            else
            {
                ret = v.objectVal.ToString();
            }
            return ret;
        }

        /// <summary>
        /// Convert from string to value class
        /// </summary>
        /// <param name="v">String value</param>
        /// <returns>Value object</returns>
        public static implicit operator FWObjKeyValue(String v)
        {
            return new FWObjKeyValue(v);
        }

        /// <summary>
        /// Convert to DateTime.
        /// </summary>
        /// <param name="v">Value object</param>
        /// <returns>DateTime value</returns>
        /// <remarks>
        /// The supplied value object should either 
        /// contain a DateTime object or an ISO date string. 
        /// </remarks>
        public static implicit operator DateTime(FWObjKeyValue v)
        {
            if (v.objectVal is DateTime)
            {
                return (DateTime)v.objectVal;
            }
            else
            {
                return IXConnection.StaticIsoToDate(v.objectVal.ToString(), false);
            }
        }

        /// <summary>
        /// Convert from DateTime to value class
        /// </summary>
        /// <param name="v">DateTime value</param>
        /// <returns>Value object</returns>
        public static implicit operator FWObjKeyValue(DateTime v)
        {
            return new FWObjKeyValue(v);
        }

        /// <summary>
        /// Convert to floating point value
        /// </summary>
        /// <param name="v">Value object</param>
        /// <returns>Floating point value</returns>
        public static implicit operator double(FWObjKeyValue v)
        {
            if (v.objectVal is double)
            {
                return (double)v.objectVal;
            }
            else
            {
                return Double.Parse(v.objectVal.ToString());
            }
        }

        /// <summary>
        /// Convert from floating point to value class
        /// </summary>
        /// <param name="v">Floating point value</param>
        /// <returns>Value object</returns>
        public static implicit operator FWObjKeyValue(double v)
        {
            return new FWObjKeyValue(v);
        }

        /// <summary>
        /// Convert to integer value
        /// </summary>
        /// <param name="v">Value object</param>
        /// <returns>Integer value</returns>
        public static implicit operator int(FWObjKeyValue v)
        {
            if (v.objectVal is int)
            {
                return (int)v.objectVal;
            }
            else
            {
                return System.Int32.Parse(v.objectVal.ToString());
            }
        }

        /// <summary>
        /// Convert from integer to value class
        /// </summary>
        /// <param name="v">Integer value</param>
        /// <returns>Value object</returns>
        public static implicit operator FWObjKeyValue(int v)
        {
            return new FWObjKeyValue(v);
        }

        /// <summary>
        /// Returns the internal value as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return objectVal.ToString();
        }
    }

    /// <summary>
    /// This helper class simplifies the access of the ObjKey data array.
    /// </summary>
    public class FWObjKeyData
    {
        /// <summary>
        /// Underlying ObjKey object.
        /// </summary>
        protected ObjKey okey;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="okey">ObjKey object</param>
        public FWObjKeyData(ObjKey okey)
        {
            this.okey = okey;
        }

        /// <summary>
        /// Index based accessor
        /// </summary>
        /// <param name="idx">Index</param>
        /// <returns>Value object at the given index. If the index is larger than the internal data array, the returned value object contains an empty string.</returns>
        /// <remarks>The internal data array is resized, if the index is outside the bounds of the current array.</remarks>
        public FWObjKeyValue this[int idx]
        {
            get
            {
                String v = "";
                if (okey.data != null && idx < okey.data.Length)
                {
                    v = okey.data[idx];
                }
                return v;
            }
            set
            {
                if (okey.data == null)
                {
                    okey.data = new String[idx + 1];
                }
                else if (idx >= okey.data.Length)
                {
                    String[] arr = new String[idx + 1];
                    for (int i = 0; i < okey.data.Length; i++) arr[i] = okey.data[i];
                    okey.data = arr;
                }
                okey.data[idx] = value;
            }
        }

        /// <summary>
        /// Gets or sets the length of the internal data array.
        /// </summary>
        public int Count
        {
            get
            {
                int n = okey.data != null ? okey.data.Length : 0;
                return n;
            }
            set
            {
                if (okey.data == null || okey.data.Length != value)
                {
                    String[] newData = new String[value];
                    if (okey.data != null)
                    {
                        int n = Math.Min(okey.data.Length, value);
                        for (int i = 0; i < n; i++) newData[i] = okey.data[i];
                        for (int i = n; i < newData.Length; i++) newData[i] = "";
                        okey.data = newData;
                    }
                }
            }
        }
        /// <summary>
        /// Makes a comma separated list from the internal data values.
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (okey.data != null)
            {
                for (int i = 0; i < okey.data.Length; i++)
                {
                    if (i > 0) sb.Append(",");
                    sb.Append(okey.data[i]);
                }
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// Wrapper class that helps accessing ObjKey objects.
    /// </summary>
    public class FWObjKey
    {
        /// <summary>
        /// Underlying ObjKey object.
        /// </summary>
        internal ObjKey okey;
        /// <summary>
        /// Definition of the index value.
        /// </summary>
        protected DocMaskLine dml;
        /// <summary>
        /// Helper object to access index data.
        /// </summary>
        protected FWObjKeyData okeyData;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="okey">ObjKey object</param>
        /// <param name="dml">Index value definition</param>
        public FWObjKey(ObjKey okey, DocMaskLine dml)
        {
            this.okey = okey;
            this.okeyData = new FWObjKeyData(okey);
            this.dml = dml;
        }
        /// <summary>
        /// ObjKey ID.
        /// </summary>
        public int Id
        {
            get
            {
                return okey.id;
            }
        }
        /// <summary>
        /// ObjKey name.
        /// </summary>
        /// <remarks>
        /// This name is the group name of the index value.
        /// </remarks>
        public String Name
        {
            get
            {
                return okey.name;
            }
            set
            {
                okey.name = value;
            }
        }
        /// <summary>
        /// First data value.
        /// </summary>
        public FWObjKeyValue Value
        {
            get
            {
                return this.okeyData[0];
            }
            set
            {
                this.okeyData[0] = value;
            }
        }
        /// <summary>
        /// Internal helper object to access the data array.
        /// </summary>
        public FWObjKeyData Data
        {
            get
            {
                return this.okeyData;
            }
        }
        /// <summary>
        /// Index value definition.
        /// </summary>
        public DocMaskLine Line
        {
            get
            {
                return dml;
            }
        }
    }
    
    /// <summary>
    /// Helper class to access an array of ObjKeys.
    /// </summary>
    public abstract class FWObjKeys
    {
        /// <summary>
        /// IndexServer connection
        /// </summary>
        private FWConnection _conn;
        /// <summary>
        /// Mask ID, GUID or name
        /// </summary>
        private string _maskId;

        /// <summary>
        /// Access the ObjKey items.
        /// </summary>
        /// <remarks>
        /// Subclasses have to implement this property.
        /// </remarks>
        public abstract ObjKey[] Items { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">IndexServer connection</param>
        /// <param name="maskId">Storage mask ID, GUID, name</param>
        public FWObjKeys(FWConnection conn, string maskId)
        {
            _conn = conn;
            _maskId = maskId;
        }

        /// <summary>
        /// IndexServer connection
        /// </summary>
        public FWConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        /// <summary>
        /// Get/Set ObjKey by ID
        /// </summary>
        /// <param name="okeyId">ObjKey ID</param>
        /// <returns>FWObjKey object</returns>
        /// <remarks>
        /// If no ObjKey with the given ID exists, a new ObjKey Object is created.
        /// </remarks>
        public FWObjKey this[int okeyId]
        {
            get 
            {
                FWObjKey ret = null;
                ObjKey[] arr = Items;
                foreach (ObjKey o in arr) 
                {
                    if (o.id == okeyId)
                    {
                        ret = new FWObjKey(o, GetDML(okeyId));
                        break;
                    }
                }
                if (ret == null)
                {
                    ObjKey okey = new ObjKey();
                    okey.id = okeyId;
                    DocMaskLine dml = GetDML(okeyId);
                    okey.name = (dml != null) ?  dml.key : ("INDEX" + okeyId);
                    ret = new FWObjKey(okey, dml);
                    Items = AddObjKey(arr, okey);
                }
                return ret;
            }
            set
            {
                ObjKey okey = value.okey;
                okey.id = okeyId;

                bool found = false;
                ObjKey[] arr = Items;
                for (int i = 0; i < arr.Length; i++) 
                {
                    ObjKey o = arr[i];
                    if (o.id == okeyId)
                    {
                        arr[i] = okey;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Items = AddObjKey(arr, okey);
                }
            }
        }

        /// <summary>
        /// Get/Set ObjKey by name (group name)
        /// </summary>
        /// <param name="okeyName">ObjKey name</param>
        /// <returns>FWObjKey object</returns>
        /// <remarks>
        /// If no ObjKey with the given name exists, a new ObjKey Object is created.
        /// </remarks>
        public FWObjKey this[string okeyName]
        {
            get
            {
                FWObjKey ret = null;
                string okeyNameLowerCase = okeyName.ToLower();
                ObjKey[] arr = Items;
                int maxOkeyId = -1;
                foreach (ObjKey o in arr)
                {
                    if (o.name.ToLower().Equals(okeyNameLowerCase))
                    {
                        ret = new FWObjKey(o, GetDML(okeyName));
                        break;
                    }
                    maxOkeyId = Math.Max(maxOkeyId, o.id);
                }
                if (ret == null)
                {
                    ObjKey okey = new ObjKey();
                    DocMaskLine dml = GetDML(okeyName);
                    if (dml != null)
                    {
                        okey.id = dml.id;
                        okey.name = dml.key;
                    }
                    else 
                    {
                        okey.id = maxOkeyId + 1;
                        okey.name = "INDEX" + okey.id;
                    }

                    Items = AddObjKey(arr, okey);
                }
                return ret;
            }
            set
            {
                ObjKey okey = value.okey;
                okey.name = okeyName.ToUpper();
                string okeyNameLowerCase = okeyName.ToLower();

                bool found = false;
                ObjKey[] arr = Items;
                for (int i = 0; i < arr.Length; i++)
                {
                    ObjKey o = arr[i];
                    if (o.name.ToLower().Equals(okeyNameLowerCase))
                    {
                        arr[i] = okey;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Items = AddObjKey(arr, okey);
                }
            }
        }

        /// <summary>
        /// Copy the given array and add the ObjKey object.
        /// </summary>
        /// <param name="arr">ObjKey array</param>
        /// <param name="okey">ObjKey object to add</param>
        /// <returns>New ObjKey array</returns>
        private ObjKey[] AddObjKey(ObjKey[] arr, ObjKey okey)
        {
            ObjKey[] newArr = null;
            if (arr != null)
            {
                newArr = new ObjKey[arr.Length + 1];
                for (int i = 0, j = 0; i < newArr.Length; i++)
                {
                    if (j < arr.Length && arr[j].id < okey.id)
                    {
                        newArr[i] = arr[j++];
                    }
                    else
                    {
                        newArr[i] = okey;
                    }
                }
            }
            else
            {
                newArr = new ObjKey[] {okey};
            }
            return newArr;
        }

        /// <summary>
        /// Get the DocMaskLine object for the given ID of the storage mask that was set in the constructor.
        /// </summary>
        /// <param name="okeyId">ObjKey ID</param>
        /// <returns>DocMaskLine object or null, if no line can be found</returns>
        private DocMaskLine GetDML(int okeyId)
        {
            DocMaskLine ret = null;
            if (_maskId != null && _maskId.Length != 0)
            {
                FWDocMask dm = null;
                if (Conn.MasterData.DocMasks.TryGetValue(_maskId, out dm))
                {
                    foreach (DocMaskLine dml in dm.Core.lines)
                    {
                        if (dml.id == okeyId)
                        {
                            ret = dml;
                            break;
                        }
                    }
                }
            }
            return ret;
        }
        /// <summary>
        /// Get the DocMaskLine object for the given group name of the storage mask that was set in the constructor.
        /// </summary>
        /// <param name="okeyName">ObjKey name</param>
        /// <returns>DocMaskLine object or null, if no line can be found</returns>
        private DocMaskLine GetDML(string okeyName)
        {
            DocMaskLine ret = null;
            if (_maskId != null && _maskId.Length != 0)
            {
                FWDocMask dm = null;
                if (Conn.MasterData.DocMasks.TryGetValue(_maskId, out dm))
                {
                    string okeyNameLowerCase = okeyName.ToLower();
                    foreach (DocMaskLine dml in dm.Core.lines)
                    {
                        if (dml.key.ToLower().Equals(okeyNameLowerCase))
                        {
                            ret = dml;
                            break;
                        }
                    }
                }
            }
            return ret;
        }
    }

    /// <summary>
    /// Implementation class of FWObjKey that uses an internal array of ObjKey objects.
    /// </summary>
    public class FWObjKeysImpl : FWObjKeys
    {
        private ObjKey[] _items = new ObjKey[0];

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">IndexServer connection</param>
        /// <param name="maskId">Storage mask ID, GUID or name</param>
        public FWObjKeysImpl(FWConnection conn, string maskId) : base(conn, maskId)
        {
        }
        /// <summary>
        /// Access the ObjKey items array
        /// </summary>
        public override ObjKey[] Items
        {
            get { return _items; }
            set { _items = value; }
        }
    }

}

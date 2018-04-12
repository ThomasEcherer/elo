using System;
using System.Collections.Generic;
using System.IO;

namespace EloixClient.IndexServer
{
  /// <summary>
  /// This helper class stores name value pairs and has a similar interface to
  /// the java.util.Properties class.
  /// </summary>
    public class IXProperties
    {
        /// <summary>
        /// Map for storing properties.
        /// </summary>
        protected Dictionary<String, String> map;

        /// <summary>
        /// Construtor.
        /// </summary>
        public IXProperties()
        {
            map = new Dictionary<String, String>();
        }

        /// <summary>
        /// Constructor with default properties.
        /// </summary>
        /// <param name="defaultProps"></param>
        public IXProperties(IXProperties defaultProps)
        {
            map = new Dictionary<String, String>(defaultProps.map);
        }

        /// <summary>
        /// Collection of keys.
        /// </summary>
        public Dictionary<String, String>.KeyCollection Keys
        {
            get { return map.Keys; }
        }

        /// <summary>
        /// Number of entries.
        /// </summary>
        public int Count
        {
            get { return map.Count; }
        }

        /// <summary>
        /// Gets or sets a value.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public String this[String key]
        {
            get
            {
                return Get(key, null);
            }
            set
            {
                Set(key, value);
            }
        }

        /// <summary>
        /// Sets a value.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public virtual void Set(String key, String value)
        {
            map[key] = value;
        }

        /// <summary>
        /// Gets a value.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Value</returns>
        public virtual String Get(String key, String defaultValue)
        {
            String v = null;
            if (!map.TryGetValue(key, out v))
            {
                v = defaultValue;
            }
            if (v == null)
            {
                v = defaultValue;
            }
            return v;
        }

        /// <summary>
        /// Gets a value as an integer.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Value</returns>
        public virtual int Get(String key, int defaultValue)
        {
            int ret = defaultValue;
            String s = this[key];
            try
            {
                if (s != null && s.Length != 0)
                {
                    ret = Convert.ToInt32(s);
                }
            }
            catch (Exception) { }
            return ret;
        }

        ///// <summary>
        ///// Write properties.
        ///// </summary>
        ///// <remarks>
        ///// This function might be implemented by a sub class.
        ///// </remarks>
        //public virtual void Update()
        //{
        //}

        /// <summary>
        /// Appends to the given string in dest the first idx characters of src and 
        /// finally appends val.
        /// </summary>
        /// <param name="dest">String to be appended</param>
        /// <param name="src">String from which the first idx characters are used</param>
        /// <param name="val">String to be appended at last</param>
        /// <param name="idx">The number of characters from idx that should be appended</param>
        /// <returns></returns>
        protected static String append(String dest, String src, String val, int idx)
        {
            if (dest == null)
            {
                dest = src.Substring(0, idx);
            }
            dest += val;
            return dest;
        }

        /// <summary>
        /// Unescape control characters like line feed an carriage return.
        /// </summary>
        /// <param name="val">Value</param>
        /// <returns>Unescaped value</returns>
        protected static String unescape(String val)
        {
            String val2 = null;
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == '\\' && i < val.Length - 1)
                {
                    switch (val[i + 1])
                    {
                        case 'n': val2 = append(val2, val, "\n", i++); break;
                        case 'r': val2 = append(val2, val, "\r", i++); break;
                        case 't': val2 = append(val2, val, "\t", i++); break;
                        case '\\': val2 = append(val2, val, "\\", i++); break;
                    }
                }
                else if (val2 != null)
                {
                    val2 += val[i];
                }
            }
            return (val2 != null) ? val2 : val;
        }

        /// <summary>
        /// RESERVED
        /// </summary>
        /// <param name="val">RESERVED</param>
        /// <returns>RESERVED</returns>
        protected String escape(String val)
        {
            String val2 = null;
            for (int i = 0; i < val.Length; i++)
            {
                switch (val[i])
                {
                    case '\n': val2 = append(val2, val, "\\n", i); break;
                    case '\r': val2 = append(val2, val, "\\r", i); break;
                    case '\t': val2 = append(val2, val, "\\t", i); break;
                    case '\\': val2 = append(val2, val, "\\\\", i); break;
                    default:
                        if (val2 != null)
                        {
                            val2 += val[i];
                        }
                        break;
                }
            }
            return (val2 != null) ? val2 : val;
        }

        /// <summary>
        /// Detectes the encoding of a text file
        /// </summary>
        /// <param name="fname">File name</param>
        /// <returns>Encoding</returns>
        protected static System.Text.Encoding detectEncoding(String fname)
        {
            System.Text.Encoding enc = System.Text.Encoding.UTF8;
            using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                int b1 = fs.ReadByte();
                int b2 = fs.ReadByte();

                if (b1 == 0xFF && b2 == 0xFE)
                {
                    enc = System.Text.Encoding.Unicode;
                }
                else if (b1 == 0xFE && b2 == 0xFF)
                {
                    enc = System.Text.Encoding.BigEndianUnicode;
                }
                else if (b1 == 0xEF && b2 == 0xBB)
                {
                    int b3 = fs.ReadByte();
                    if (b3 == 0xBF)
                    {
                        enc = System.Text.Encoding.UTF8;
                    }
                }
            }
            return enc;
        }

        /// <summary>
        /// Reads a property file. Might be an UNICODE or UTF-8 encoded file.
        /// </summary>
        /// <param name="fname">File name</param>
        public void Read(String fname)
        {
            if (!File.Exists(fname)) return;
            System.Text.Encoding enc = detectEncoding(fname);
            using (StreamReader sr = new StreamReader(fname, enc))
            {
                String line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length == 0) continue;
                    int eq = line.IndexOf("=");
                    String key = (eq >= 0) ? line.Substring(0, eq) : line;
                    String val = (eq >= 0) ? line.Substring(eq + 1) : "";
                    if (key.Length == 0) continue;
                    if (val.Length == 0) continue;
                    val = unescape(val);
                    Set(key, val);
                }
            }
        }

    }
}

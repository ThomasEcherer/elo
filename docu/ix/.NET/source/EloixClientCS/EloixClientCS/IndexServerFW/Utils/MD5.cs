using System;
using System.IO;
using System.Security.Cryptography;

namespace EloixClient.IndexServerFW.Utils
{
    /// <summary>
    /// Helper object for creating MD5 hashs
    /// </summary>
    public class MD5
    {
        private static MD5CryptoServiceProvider _MD5Service = new MD5CryptoServiceProvider();

        private byte[] _md5;
        private static char[] HEXCHARS = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="file">Create MD5 hash from this file.</param>
        public MD5(String file)
        {
            FileInfo testFile = new FileInfo(file);
            FileStream fstrm = null;
            try
            {
                fstrm = testFile.OpenRead();
                _md5 = _MD5Service.ComputeHash(fstrm);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fstrm != null)
                {
                    fstrm.Close();
                }
            }
        }

        /// <summary>
        /// Initialize an empty MD5 object.
        /// </summary>
        /// <remarks>This constructor is used in ComputeTextHash</remarks>
        protected MD5()
        {
        }

        /// <summary>
        /// Compare MD5 hashs
        /// </summary>
        /// <param name="rhs">Other MD5 hash.</param>
        /// <returns>True, if hash values are equal.</returns>
        public override bool Equals(Object rhs)
        {
            if (rhs is string)
            {
                return this.ToString().Equals((string)rhs);
            }
            else if (rhs is MD5)
            {
                byte[] rhs_md5 = ((MD5)rhs)._md5;
                for (int i = 0; i < _md5.Length; i++)
                {
                    if (_md5[i] != rhs_md5[i]) return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Generate a hash code.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// Convert to string.
        /// </summary>
        /// <returns>String</returns>
        public override String ToString()
        {
            if (_md5 == null) return "";
            
            char[] s = new char[32];
            for (int i = 0; i < _md5.Length; i++)
            {
                int b = (int)_md5[i];
                s[2 * i] = HEXCHARS[(b >> 4) & 0x0F];
                s[2 * i + 1] = HEXCHARS[b & 0x0F];
            }
            return new String(s);
        }

        /// <summary>
        /// Computes the MD5 hash of the given bytes and returns the hash converted to string.
        /// </summary>
        /// <param name="text">Data bytes</param>
        /// <returns>MD5 hash as string</returns>
        public static string ComputeTextHash(byte[] text)
        {
            MD5 m = new MD5();
            m._md5 = _MD5Service.ComputeHash(text);
            return m.ToString();
        }

    }
}

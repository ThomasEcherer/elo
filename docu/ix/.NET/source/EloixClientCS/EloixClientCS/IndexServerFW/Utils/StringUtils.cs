using System;
using System.Collections.Generic;
using System.Text;

namespace EloixClient.IndexServerFW.Utils
{
    internal static class StringUtils
    {
        public static bool IsGuid(string val)
        {
            if (val == null || val.Length != 38)
                return false;

            if (val[0] != '(')
                return false;

            for (int i = 0; i < 37; i++)
            {
                char c = val[i];

                if (!((c >= '0' && c <= '9') ||
                      (c >= 'A' && c <= 'F') ||
                      (c >= 'a' && c <= 'f') ||
                      (c == '-')))
                    return false;
            }

            if (val[37] != ')')
                return false;

            return true;
        }
    }
}

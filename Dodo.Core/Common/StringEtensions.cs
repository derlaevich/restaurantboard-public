using System;
using System.Xml.Linq;

namespace Dodo.Core.Common
{
    public static class StringEtensions
    {
        public static String ReplaceDirectorySeparator(this string value)
        {
            return value.Replace('\\', '/');
        }
    }
}

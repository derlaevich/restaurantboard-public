using System;
using System.Xml.Linq;

namespace Dodo.Core.Common
{
    public static class XElementEtensions
    {
        public static String GetValueOrDefault(this XElement element, String atributName, String defaultValue)
        {
            var attributeValue = element.Attribute(atributName);
            return attributeValue == null ? defaultValue : attributeValue.Value;
        }
    }
}

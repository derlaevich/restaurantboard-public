﻿using System;
using System.Linq;
using System.Xml.Linq;
using Dodo.Core.DomainModel.Departments.Extensions;

namespace Dodo.Core.DomainModel.Departments
{
    [Serializable]
    public class CallCenterPhoneParameter
    {
        public String Number { get; set; }

        /// <summary>
        /// Путь на внешнем сервере (файл сервер)
        /// </summary>
        public String IconPath { set; get; }

        /// <summary>
        /// Путь в текущем каталоге сайта
        /// </summary>
        public String IconSitePath { set; get; }


        public String GetIconUrl(String host)
        {
            if (!String.IsNullOrEmpty(IconPath))
            {
                return (host.TrimEnd('/', '\\') + "/" + IconPath).Replace('\\', '/');
            }

            if (!String.IsNullOrEmpty(IconSitePath))
            {
                return IconSitePath;
            }

            return String.Empty;
        }


        public String NumberWithoutMarks
        {
            get
            {
                if (String.IsNullOrEmpty(Number))
                    return Number;

                String[] replacedMarks = { "-", " ", "(", ")" };
                String replacedNumber = Number;
                foreach (String mark in replacedMarks)
                {
                    replacedNumber = replacedNumber.Replace(mark, "");
                }
                return replacedNumber;
            }
        }



        public XElement CreateXmlNode()
        {
            return new XElement("Phone",
                new XAttribute("number", Number ?? String.Empty),
                new XAttribute("iconPath", IconPath ?? String.Empty),
                new XAttribute("iconSitePath", IconSitePath ?? String.Empty));
        }

        public static CallCenterPhoneParameter[] GetCallCenterPhonesFromXml(XElement container)
        {
            var phns = container.Element("CallCenterPhones");
            if(phns==null)
                return new CallCenterPhoneParameter[0];

            var callCenterPhones = phns.Elements().Select(x => 
                new CallCenterPhoneParameter
                {
                    Number = x.GetAttributeValueByName("number"),
                    IconPath = x.GetAttributeValueByName("iconPath"),
                    IconSitePath = x.GetAttributeValueByName("iconSitePath")
                });

            return callCenterPhones.ToArray();
        }


    }
}
using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace OfxSharpLib
{
    public static class OfxHelperMethods
    {
        /// <summary>
        /// Converts string representation of AccountInfo to enum AccountInfo
        /// </summary>
        /// <param name="bankAccountType">representation of AccountInfo</param>
        /// <returns>AccountInfo</returns>
        public static BankAccountType GetBankAccountType(this string bankAccountType)
        {
            return (BankAccountType)Enum.Parse(typeof(BankAccountType), bankAccountType);
        }

        /// <summary>
        /// Flips date from YYYYMMDD to DDMMYYYY         
        /// </summary>
        /// <param name="date">Date in YYYYMMDD format</param>
        /// <returns>Date in format DDMMYYYY</returns>
        public static DateTime ToDate(this string date)
        {
            try
            {
                var formats = new[]
                {
                    "yyyyMMdd",
                    "yyyy-MM-dd",
                };

                if (DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
                {
                    return result;
                }

                return new DateTime();
            }
            catch
            {
                throw new OfxParseException("Unable to parse date");
            }
        }

        /// <summary>
        /// Returns value of specified node
        /// </summary>
        /// <param name="node">Node to look for specified node</param>
        /// <param name="xpath">XPath for node you want</param>
        /// <returns></returns>
        public static string GetValue(this XmlNode node, string xpath)
        {
            // workaround to search values on root node
            var fixedNode = new XmlDocument();
            fixedNode.Load(new StringReader(node.OuterXml));

            var tempNode = fixedNode.SelectSingleNode(xpath);
            //return tempNode != null ? tempNode.FirstChild.Value : "";
            return tempNode?.FirstChild?.Value ?? "";
        }
    }
}
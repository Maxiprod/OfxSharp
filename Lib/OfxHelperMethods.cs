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
                // Tratar formato especial "yyyyMMddhhMMss[-3:GMT]" para somente data.
                // Por ser um formato de data não padronizado,não é possível escrever uma string de formato
                // que seja compatível com o TryParseExact.
                // SL-60693 (https://app.clickup.com/t/9007115994/SL-60693)
                if (date.Length == 22)
                {
                    date = date.Substring(0, 8);
                }

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
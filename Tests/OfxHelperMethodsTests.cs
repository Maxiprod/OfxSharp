using NUnit.Framework;
using OfxSharpLib;
using System;
using System.Collections.Generic;

namespace OFXSharp.Tests
{
    [TestFixture]
    public class OfxHelperMethodsTests
    {
        [Test, TestCaseSource(nameof(ToDateTestCases))]
        public void ToDateTest(string data, DateTime dataEsperada)
        {
            var resultado = OfxHelperMethods.ToDate(data);

            Assert.That(dataEsperada == resultado);
        }

        private static IEnumerable<TestCaseData> ToDateTestCases()
        {
            yield return new TestCaseData("20250331[-3:BRT]", new DateTime(2025, 3, 31));
            yield return new TestCaseData("20140327120000[-3:BRT]", new DateTime(2014, 3, 27));
            yield return new TestCaseData("20250328", new DateTime(2025, 3, 28));
            yield return new TestCaseData("2025-03-28", new DateTime(2025, 3, 28));
        }
    }
}

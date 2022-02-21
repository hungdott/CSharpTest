using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polly;
using RomanToNumber.Helper;
using System;

namespace TestRoman
{
    [TestClass]
    public class RomanNumberTest
    {
        [TestMethod]
        public void TestValidRoman()
        {
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("  "), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("XXXX"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("IIII"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("CCCC"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("MMMM"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("VV"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("DD"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("LL"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("IL"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("IC"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("IM"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("XD"), "Roman text is not valid. Plz type other value");
            Assert.ThrowsException<Exception>(() => ConvertRomanToNum.ConvertToNum("XM"), "Roman text is not valid. Plz type other value");
        }

        [TestMethod]
        public void TestValueRoman()
        {
            Assert.AreEqual(ConvertRomanToNum.ConvertToNum("MCMXLIV"), 1944);
            Assert.AreEqual(ConvertRomanToNum.ConvertToNum("MCMIII"), 1903);
            Assert.AreEqual(ConvertRomanToNum.ConvertToNum("XI"), 11);
        }
    }
}
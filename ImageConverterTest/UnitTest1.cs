
using Day_or_Night.util;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void One_Equals_One()
        {
            Assert.AreEqual(1.0f, 1.0f, 0.0f, "Something went very wrong...");
        }
    }
}

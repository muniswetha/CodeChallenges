using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WCC01_08_2016.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MustFindElement()
        {
            UInt16[] array = { 11, 20, 8, 31 };
            var element = Program.FindEle(array);
            Assert.IsTrue(element == 8);
        }

        [TestMethod]
        public void MustNotFindElement()
        {
            UInt16[] array = { 1, 2, 3};
            var element = Program.FindEle(array);
            Assert.IsTrue(element == null);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZK.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZK.Utility.Tests
{
    [TestClass()]
    public class FileHelperTests
    {
        [TestMethod()]
        public void GetAbsolutePathTest()
        {
            var a = @"C:\log.log";
            var b=FileHelper.GetAbsolutePath(a);
            Assert.AreEqual(a,b);
        }
    }
}
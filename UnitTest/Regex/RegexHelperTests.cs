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
    public class RegexHelperTests
    {
        
        [TestMethod()]
        public void IsMobileTest()
        {
            var input = "15827395018";
            var r=RegexHelper.IsMobile(input);
            Assert.IsTrue(r);
        }

        [TestMethod()]
        public void IsEmailTest()
        {
            var input = "niubileme@hotmail.com";
            var r = RegexHelper.IsEmail(input);
            Assert.IsTrue(r);
        }

        [TestMethod()]
        public void IsChineseTest()
        {
            var input = "这是汉字";
            var r = RegexHelper.IsChinese(input);
            Assert.IsTrue(r);
        }

        [TestMethod()]
        public void IsIPAddressTest()
        {
            var input = "127.0.0.1";
            var r = RegexHelper.IsIPAddress(input);
            Assert.IsTrue(r);
        }
    }
}
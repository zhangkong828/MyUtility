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
    public class MailHelperTests
    {
        [TestMethod()]
        public void SendMessageTest()
        {
            var r=MailHelper.SendMessage("602488225@qq.com", "这是邮件主题", "这是邮件内容<br/>233...");
            Assert.AreEqual(r, SMSCode.Success);
        }
    }
}
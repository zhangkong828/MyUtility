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
    public class HttpHelperTests
    {
        [TestMethod()]
        public void GetHtmlTest()
        {
            var result = new HttpHelper(new HttpItem()
            {
                URL = "http://www.baidu.com",
                Method = "GET",//URL     可选项 默认为Get    
                Timeout = 100000,//连接超时时间     可选项默认为100000    
                ReadWriteTimeout = 30000,//写入Post数据超时时间     可选项默认为30000    
                IsToLower = false,//得到的HTML代码是否转成小写     可选项默认转小写    
                Cookie = "",//字符串Cookie     可选项    
                UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",//用户的浏览器类型，版本，操作系统     可选项有默认值    
                Accept = "text/html, application/xhtml+xml, */*",//    可选项有默认值    
                ContentType = "text/html",//返回类型    可选项有默认值    
                Referer = "http://www.abc.com",//来源URL     可选项    
                Allowautoredirect = true,//是否根据３０１跳转     可选项    
                                         // CerPath = "d:\123.cer",//证书绝对路径     可选项不需要证书时可以不写这个参数    
                Connectionlimit = 1024,//最大连接数     可选项 默认为1024    
                                       // Postdata = "username=abc&pwd=123",//Post数据     可选项GET时不需要写    
                                       // ProxyIp = "192.168.1.105",//代理服务器ID     可选项 不需要代理 时可以不设置这三个参数    
                                       // ProxyPwd = "123456",//代理服务器密码     可选项    
                                       // ProxyUserName = "administrator",//代理服务器账户名     可选项    

            }).GetHtml();
            var html = result.Html;
            var cookie = result.Cookie;
            var bytes = result.ResultByte;
            Assert.Fail();
        }

        [TestMethod()]
        public void GetFileTest()
        {
            var path = @"d:\2.gif";
            path = FileHelper.GetAbsolutePath(path);
            //下载图片
            var result = new HttpHelper(new HttpItem()
            {
                URL = "http://images.cnblogs.com/cnblogs_com/twobin/520730/o_blue.gif"
            }).GetFile(path);

            Assert.IsTrue(result);
        }
    }
}
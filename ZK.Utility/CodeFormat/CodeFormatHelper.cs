using Newtonsoft.Json;
using System;
using System.Text;

namespace ZK.Utility
{
    /// <summary>
    /// 编码、解码相关帮助类
    /// html编码解码
    /// url编码解码
    /// base64
    /// json序列化 反序列化
    /// </summary>
    public  class CodeFormatHelper
    {
        #region Html 编码 解码
        /// <summary>
        /// html解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HtmlDecode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("参数str空异常！");
            }
            return System.Web.HttpUtility.HtmlDecode(str);
        }

        /// <summary>
        /// html编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HtmlEncode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("参数str空异常！");
            }
            return System.Web.HttpUtility.HtmlEncode(str);
        }
        #endregion

        #region URL 编码 解码
        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string URLDecode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("参数str空异常！");
            }
            return System.Web.HttpUtility.UrlDecode(str);
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string URLEncode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("参数str空异常！");
            }
            return System.Web.HttpUtility.UrlEncode(str);
        }
        #endregion

        #region Base64

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="codeName">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string EncodeBase64(Encoding encode, string source)
        {
            byte[] bytes = encode.GetBytes(source);
            var result = "";
            try
            {
                result = Convert.ToBase64String(bytes);
            }
            catch
            {
                result = source;
            }
            return result;
        }

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string EncodeBase64ByUTF8(string source)
        {
            return EncodeBase64(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(Encoding encode, string result)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64ByUTF8(string result)
        {
            return DecodeBase64(Encoding.UTF8, result);
        }

        #endregion

        #region Json 序列化 反序列化
        /// <summary>
        /// Json 序列化
        /// </summary>
        public static string JsonSerializer(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Json 反序列化
        /// </summary>
        public static T JsonDeserializer<T>(string jsonstr)
        {
            if (string.IsNullOrEmpty(jsonstr))
            {
                return default(T);
            }
           return  JsonConvert.DeserializeObject<T>(jsonstr);
        }
        #endregion
    }
}

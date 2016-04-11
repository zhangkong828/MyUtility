using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZK.Utility
{
    /// <summary>
    /// 时间日期相关帮助类
    /// </summary>
    public class DateTimeHelper
    {

        #region 时间戳转换
        /// <summary>
        /// 时间戳 转 换时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
        /// <summary>
        /// 时间 转换 时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
        #endregion


        /// <summary>
        /// 计算两个日期相隔的天数和小时数
        /// </summary>
        /// <param name="dt1">开始日期</param>
        /// <param name="dt2">截止日期</param>
        /// <returns>相隔的天数和小时数</returns>
        public static string GetDayAndHours(DateTime dt1, DateTime dt2)
        {
            double jg = (dt1 - dt2).TotalDays;
            //取相隔天数
            double iDay = Math.Floor(jg);
            //取相隔小时数
            double iHour = Math.Ceiling((jg - iDay) * 24);
            return string.Format("{0}天{1}小时", iDay, iHour);
        }


    }
}

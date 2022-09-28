
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Lrw.Core.Helper
*│　类    名： DateHelper
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：Koolss
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2020/3/31 星期二 15:29:07
*│　机器名称：HL
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.Extend.Helper.Date
{
    public class DateHelper
    {
        /// <summary>
        /// 中国 时区
        /// </summary>
        private const long _chinaTimeStamp = 621356256000000000;

        /// <summary>
        /// 当前时间
        /// </summary>
        /// <returns></returns>
        public static DateTime Date()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Long类型时间转为{@link DateTime}<br>
        /// 只支持毫秒级别时间戳，如果需要秒级别时间戳，请自行×1000
        /// </summary>
        /// <param name="date">Long类型Date（Unix时间戳）</param>
        /// <returns>时间对象</returns>
        public static DateTime ToDateTime(long timeStamp)
        {
            long tt = _chinaTimeStamp + timeStamp * 10000;
            return new DateTime(tt);
        }

        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <param name="isNano">是否为高精度时间</param>
        /// <returns>时间</returns>
        public static long Current(bool isNano)
        {
            return isNano ? (Date().Ticks - _chinaTimeStamp) / 10000 : CurrentSeconds();
        }

        /// <summary>
        /// 当前时间的时间戳（秒）
        /// </summary>
        /// <returns>当前时间秒数</returns>
        public static long CurrentSeconds()
        {
            return (Date().Ticks - _chinaTimeStamp) / 10000000;
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetTimeStamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }

        /// <summary>
        /// 时间转换为时间戳（秒）
        /// </summary>
        /// <param name="dateTime">需要转换的时间</param>
        /// <returns>转换后的时间戳（秒）</returns>
        public static long ToTimeStamp(DateTime dateTime)
        {
            return (dateTime.Ticks - _chinaTimeStamp) / 10000000;
        }

        /// <summary>
        /// 当前时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <returns>当前时间的标准形式字符串</returns>
        public static string Now()
        {
            return FormatDateTime(Date());
        }

        /// <summary>
        /// 当前日期，格式 yyyy-MM-dd
        /// </summary>
        /// <returns>当前日期的标准形式字符串</returns>
        public static string ToDay()
        {
            return FormatDate(Date());
        }

        /// <summary>
        /// 格式化日期时间<br>
        /// 格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="dateTime">被格式化的日期</param>
        /// <returns>格式化后的日期</returns>
        public static string FormatDateTime(DateTime dateTime)
        {
            if (null == dateTime)
            {
                return null;
            }
            return dateTime.ToString(DatePattern.NORM_DATETIME_PATTERN);
        }

        /// <summary>
        /// 格式化日期部分（不包括时间）<br>
        /// 格式 yyyy-MM-dd
        /// </summary>
        /// <param name="dateTime">被格式化的日期</param>
        /// <returns>格式化后的日期</returns>
        public static string FormatDate(DateTime dateTime)
        {
            if (null == dateTime)
            {
                return "";
            }
            return dateTime.ToString(DatePattern.NORM_DATE_PATTERN);
        }

        /// <summary>
        /// 格式化时间<br>
        /// 格式 HH:mm:ss
        /// </summary>
        /// <param name="dateTime">被格式化的日期</param>
        /// <returns>格式化后的日期</returns>
        public static string FormatTime(DateTime dateTime)
        {
            if (null == dateTime)
            {
                return "";
            }
            return dateTime.ToString(DatePattern.NORM_TIME_PATTERN);
        }

        /// <summary>
        /// 根据特定格式格式化日期
        /// </summary>
        /// <param name="dateTime">被格式化的日期</param>
        /// <param name="format">格式</param>
        /// <returns></returns>
        public static string Format(DateTime dateTime, string format)
        {
            if (null == dateTime || format == null)
            {
                return null;
            }
            return dateTime.ToString(format);
        }

        /// <summary>
        /// 昨天
        /// </summary>
        /// <returns>昨天</returns>
        public static DateTime Yesterday()
        {
            return OffsetDay(Date(), -1);
        }

        /// <summary>
        /// 明天
        /// </summary>
        /// <returns>明天</returns>
        public static DateTime Tomorrow()
        {
            return OffsetDay(Date(), 1);
        }

        /// <summary>
        /// 上周
        /// </summary>
        /// <returns>上周</returns>
        public static DateTime LastWeek()
        {
            return OffsetWeek(Date(), -1);
        }

        /// <summary>
        /// 下周
        /// </summary>
        /// <returns>下周</returns>
        public static DateTime NextWeek()
        {
            return OffsetWeek(Date(), 1);
        }

        /// <summary>
        /// 上个月
        /// </summary>
        /// <returns>上个月</returns>
        public static DateTime LastMonth()
        {
            return OffsetMonth(Date(), -1);
        }

        /// <summary>
        /// 下个月
        /// </summary>
        /// <returns>下个月</returns>
        public static DateTime NextMonth()
        {
            return OffsetMonth(Date(), 1);
        }

        /// <summary>
        /// 偏移毫秒数
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetMillisecond(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.MILLISECOND, offset);
        }

        /// <summary>
        /// 偏移秒数
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetSecond(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.SECOND, offset);
        }

        /// <summary>
        /// 偏移分钟
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetMinute(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.MINUTE, offset);
        }

        /// <summary>
        /// 偏移小时
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetHour(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.HOUR_OF_DAY, offset);
        }

        /// <summary>
        /// 偏移天
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetDay(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.DAY_OF_YEAR, offset);
        }

        /// <summary>
        /// 偏移周
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetWeek(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.WEEK_OF_YEAR, offset);
        }

        /// <summary>
        /// 偏移月
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetMonth(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.MONTH, offset);
        }

        /// <summary>
        /// 偏移年
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="offset">偏移毫秒数，正数向未来偏移，负数向历史偏移</param>
        /// <returns>偏移后的日期</returns>
        public static DateTime OffsetYear(DateTime dateTime, int offset)
        {
            return OffSet(dateTime, DateField.YEAR, offset);
        }

        /// <summary>
        /// 获取指定日期偏移指定时间后的时间，生成的偏移日期不影响原日期
        /// </summary>
        /// <param name="dateTime">基准日期</param>
        /// <param name="dateField">偏移的粒度大小（小时、天、月等）{@link DateField}</param>
        /// <param name="offset">偏移量，正数为向后偏移，负数为向前偏移</param>
        /// <returns></returns>
        public static DateTime OffSet(DateTime dateTime, DateField dateField, int offset)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            switch (dateField)
            {
                case DateField.YEAR:
                    return cal.AddYears(dateTime, offset);
                case DateField.MONTH:
                    return cal.AddMonths(dateTime, offset);
                case DateField.DAY_OF_YEAR:
                    return cal.AddDays(dateTime, offset);
                case DateField.HOUR_OF_DAY:
                    return cal.AddHours(dateTime, offset);
                case DateField.MINUTE:
                    return cal.AddMinutes(dateTime, offset);
                case DateField.SECOND:
                    return cal.AddSeconds(dateTime, offset);
                case DateField.MILLISECOND:
                    return cal.AddMilliseconds(dateTime, offset);
                case DateField.WEEK_OF_YEAR:
                    return cal.AddWeeks(dateTime, offset);
                default:
                    return dateTime;
            }
        }
    }
}

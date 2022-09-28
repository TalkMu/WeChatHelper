using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Lrw.Core.Helper.Date
*│　类    名： DatePattern
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：Koolss
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2020/5/15 星期五 14:50:19
*│　机器名称：HL
*└──────────────────────────────────────────────────────────────┘
*/
namespace WeChat.Extend.Helper.Date
{
    public class DatePattern
    {
		//-------------------------------------------------------------------------------------------------------------------------------- Normal
		/** 标准日期格式：yyyy-MM-dd */
		public const string NORM_DATE_PATTERN = "yyyy-MM-dd";

		/** 标准时间格式：HH:mm:ss */
		public const String NORM_TIME_PATTERN = "HH:mm:ss";

		/** 标准日期时间格式，精确到分：yyyy-MM-dd HH:mm */
		public const String NORM_DATETIME_MINUTE_PATTERN = "yyyy-MM-dd HH:mm";

		/** 标准日期时间格式，精确到秒：yyyy-MM-dd HH:mm:ss */
		public const String NORM_DATETIME_PATTERN = "yyyy-MM-dd HH:mm:ss";

		/** 标准日期时间格式，精确到毫秒：yyyy-MM-dd HH:mm:ss.SSS */
		public const String NORM_DATETIME_MS_PATTERN = "yyyy-MM-dd HH:mm:ss.SSS";

		/** 标准日期格式：yyyy年MM月dd日 */
		public const String CHINESE_DATE_PATTERN = "yyyy年MM月dd日";

		//-------------------------------------------------------------------------------------------------------------------------------- Pure
		/** 标准日期格式：yyyyMMdd */
		public const String PURE_DATE_PATTERN = "yyyyMMdd";

		/** 标准日期格式：HHmmss */
		public const String PURE_TIME_PATTERN = "HHmmss";

		/** 标准日期格式：yyyyMMddHHmmss */
		public const String PURE_DATETIME_PATTERN = "yyyyMMddHHmmss";

		/** 标准日期格式：yyyyMMddHHmmssSSS */
		public const String PURE_DATETIME_MS_PATTERN = "yyyyMMddHHmmssSSS";

		//-------------------------------------------------------------------------------------------------------------------------------- Others
		/** HTTP头中日期时间格式：EEE, dd MMM yyyy HH:mm:ss z */
		public const String HTTP_DATETIME_PATTERN = "EEE, dd MMM yyyy HH:mm:ss z";

		/** JDK中日期时间格式：EEE MMM dd HH:mm:ss zzz yyyy */
		public const String JDK_DATETIME_PATTERN = "EEE MMM dd HH:mm:ss zzz yyyy";

		/** UTC时间：yyyy-MM-dd'T'HH:mm:ss'Z' */
		public const String UTC_PATTERN = "yyyy-MM-dd'T'HH:mm:ss'Z'";

		/** UTC时间：yyyy-MM-dd'T'HH:mm:ssZ */
		public const String UTC_WITH_ZONE_OFFSET_PATTERN = "yyyy-MM-dd'T'HH:mm:ssZ";

		/** UTC时间：yyyy-MM-dd'T'HH:mm:ss.SSS'Z' */
		public const String UTC_MS_PATTERN = "yyyy-MM-dd'T'HH:mm:ss.SSS'Z'";

		/** UTC时间：yyyy-MM-dd'T'HH:mm:ssZ */
		public const String UTC_MS_WITH_ZONE_OFFSET_PATTERN = "yyyy-MM-dd'T'HH:mm:ss.SSSZ";
	}
}

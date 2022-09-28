using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Lrw.Core.Helper.Date
*│　类    名： DateField
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：Koolss
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2020/5/15 星期五 14:49:58
*│　机器名称：HL
*└──────────────────────────────────────────────────────────────┘
*/
namespace WeChat.Extend.Helper.Date
{
    public enum DateField
    {
        /// <summary>
        /// 世纪
        /// </summary>
        ERA,
        /// <summary>
        /// 年
        /// </summary>
        YEAR,
        /// <summary>
        /// 月
        /// </summary>
        MONTH,
        /// <summary>
        /// 一年中第几周
        /// </summary>
        WEEK_OF_YEAR,
        /// <summary>
        /// 一月中第几周
        /// </summary>
        WEEK_OF_MONTH,
        /// <summary>
        /// 一月中的第几天
        /// </summary>
        DAY_OF_MONTH,
        /// <summary>
        /// 一年中的第几天
        /// </summary>
        DAY_OF_YEAR,
        /// <summary>
        /// 周几，1表示周日，2表示周一
        /// </summary>
        DAY_OF_WEEK,
        /// <summary>
        /// 天所在的周是这个月的第几周
        /// </summary>
        DAY_OF_WEEK_IN_MONTH,
        /// <summary>
        /// 上午或者下午
        /// </summary>
        AM_PM,
        /// <summary>
        /// 小时，用于12小时制
        /// </summary>
        HOUR,
        /// <summary>
        /// 小时，用于24小时制
        /// </summary>
        HOUR_OF_DAY,
        /// <summary>
        /// 分钟
        /// </summary>
        MINUTE,
        /// <summary>
        /// 秒
        /// </summary>
        SECOND,
        /// <summary>
        /// 毫秒
        /// </summary>
        MILLISECOND,
    }
}

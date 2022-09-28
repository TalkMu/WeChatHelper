using System;
using System.Collections.Generic;
using System.Text;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.DTO.Weather
*│　类    名： WeatherDTO
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 11:30:08
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.DTO.Weather
{
    public class WeatherDTO
    {
        /// <summary>
        /// 返回状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 返回结果总数目
        /// </summary>
        public string count { get; set; }

        /// <summary>
        /// 返回的状态信息
        /// </summary>
        public string info { get; set; }

        /// <summary>
        /// 返回状态说明,10000代表正确
        /// </summary>
        public string infocode { get; set; }

        /// <summary>
        /// 预报天气信息数据
        /// </summary>
        public List<ForecastsItem> forecasts { get; set; }
    }

    public class CastsItem
    {
        /// <summary>
        /// 日期
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 星期几
        /// </summary>
        public string week { get; set; }
        /// <summary>
        /// 白天天气现象
        /// </summary>
        public string dayweather { get; set; }
        /// <summary>
        /// 晚上天气现象
        /// </summary>
        public string nightweather { get; set; }
        /// <summary>
        /// 白天温度
        /// </summary>
        public string daytemp { get; set; }
        /// <summary>
        /// 晚上温度
        /// </summary>
        public string nighttemp { get; set; }
        /// <summary>
        /// 白天风向
        /// </summary>
        public string daywind { get; set; }
        /// <summary>
        /// 晚上风向
        /// </summary>
        public string nightwind { get; set; }
        /// <summary>
        /// 白天风力
        /// </summary>
        public string daypower { get; set; }
        /// <summary>
        /// 晚上风力
        /// </summary>
        public string nightpower { get; set; }
    }

    public class ForecastsItem
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 城市编码
        /// </summary>
        public string adcode { get; set; }
        /// <summary>
        /// 省份名称
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 预报发布时间
        /// </summary>
        public string reporttime { get; set; }
        /// <summary>
        /// 预报数据list结构，元素cast,按顺序为当天、第二天、第三天的预报数据
        /// </summary>
        public List<CastsItem> casts { get; set; }
    }
}

using Newtonsoft.Json;
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
    public class AMapWeatherDTO
    {
        /// <summary>
        /// 返回状态
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// 返回结果总数目
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public string Count { get; set; }
        /// <summary>
        /// 返回的状态信息
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }
        /// <summary>
        /// 返回状态说明,10000代表正确
        /// </summary>
        [JsonProperty(PropertyName = "infocode")]
        public string InfoCode { get; set; }
        /// <summary>
        /// 实况天气数据信息
        /// </summary>
        [JsonProperty(PropertyName = "lives")]
        public List<LivesItem> Lives { get; set; }
    }

    public class LivesItem
    {
        /// <summary>
        /// 省份名
        /// </summary>
        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }
        /// <summary>
        /// 城市名
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty(PropertyName = "adcode")]
        public string AdCode { get; set; }
        /// <summary>
        /// 天气现象（汉字描述）
        /// </summary>
        [JsonProperty(PropertyName = "weather")]
        public string Weather { get; set; }
        /// <summary>
        /// 实时气温，单位：摄氏度
        /// </summary>
        [JsonProperty(PropertyName = "temperature")]
        public string Temperature { get; set; }
        /// <summary>
        /// 风向描述
        /// </summary>
        [JsonProperty(PropertyName = "winddirection")]
        public string WindDirection { get; set; }
        /// <summary>
        /// 风力级别，单位：级
        /// </summary>
        [JsonProperty(PropertyName = "windpower")]
        public string WindPower { get; set; }
        /// <summary>
        /// 空气湿度
        /// </summary>
        [JsonProperty(PropertyName = "humidity")]
        public string Humidity { get; set; }
        /// <summary>
        /// 数据发布的时间
        /// </summary>
        [JsonProperty(PropertyName = "reporttime")]
        public string ReportTime { get; set; }
    }
}

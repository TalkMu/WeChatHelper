using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.DTO.CiBa;
using WeChat.DTO.Weather;
using WeChat.Extend.Helper;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.Service.Api
*│　类    名： ApiHelper
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 15:29:03
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class ApiService
    {
        /// <summary>
        /// 获取今日天气
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        public static CastsItem GetToDayWeather(string cityName)
        {
            var url = "https://restapi.amap.com/v3/weather/weatherInfo";
            var response = HttpHelper.Get(url, "city=" + cityName + "&extensions=all&key=024ef1bc665969e39667c3d1dbc43d1d");
            var weather = JsonHelper.FromJson<WeatherDTO>(response);
            var cityInfo = weather.forecasts.FirstOrDefault();
            var today = cityInfo.casts.FirstOrDefault();
            var content = string.Format("天气：{0}\n温度：{1}℃\n{2}风：{3}级", today.dayweather, today.daytemp, today.daywind, today.daypower);
            return today;
        }

        /// <summary>
        /// 获取词霸每日一句
        /// </summary>
        /// <returns></returns>
        public static string GetCiBa()
        {
            var url = "http://open.iciba.com/dsapi";
            var response = HttpHelper.Get(url);
            var ciBaResponse = JsonHelper.FromJson<CiBaDTO>(response);
            return string.Format("{0}\n{1}", ciBaResponse.content, ciBaResponse.note);
        }

        /// <summary>
        /// 获取格言
        /// </summary>
        /// <returns></returns>
        public static string GetMotto()
        {
            var url = "http://wufazhuce.com/";
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var content = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='fp-one-cita']/a").InnerText;
            return content;

        }

        public static string NextFestival() 
        {
            var url = "https://www.daojishi321.com/";
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var festival = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div/div[2]/div[2]/div/span[1]/span[2]/strong[1]/a").InnerText;

            var date = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div/div[2]/div[2]/div/span[1]/span[2]/strong[2]").InnerText;
            return festival + "|" + date;
        }
    }
}

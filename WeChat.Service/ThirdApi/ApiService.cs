using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.DTO.CiBa;
using WeChat.DTO.Weather;
using WeChat.Extend.Helper;
using WeChat.ModelView.Third;

namespace WeChat.Service.ThirdApi
{
	/**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.Service.ThirdApi
	*│　类    名： WeatherApiService
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/11 10:57:55
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
	public class ApiService
    {
		public WeatherMV GetWeatherInfo(string cityCode) 
		{
			var url = "https://restapi.amap.com/v3/weather/weatherInfo";
			var response = HttpHelper.Get(url, "city=" + cityCode + "&extensions=base&key=024ef1bc665969e39667c3d1dbc43d1d");
			var result = JsonHelper.FromJson<AMapWeatherDTO>(response);
			var liveWeather = result.Lives.FirstOrDefault();
			WeatherMV weatherMV = new WeatherMV() 
			{
				Weather = liveWeather.Weather,
				Temperature = liveWeather.Temperature,
				WindDirection = liveWeather.WindDirection,
				WindPower = liveWeather.WindPower,
				Humidity = liveWeather.Humidity,
			};
			return weatherMV;
		}

        /// <summary>
        /// 获取词霸每日一句
        /// </summary>
        /// <returns></returns>
        public string GetCiBa()
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
        public string GetMotto()
        {
            var url = "http://wufazhuce.com/";
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var content = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='fp-one-cita']/a").InnerText;
            return content;

        }
        /// <summary>
        /// 获取下一个节日信息
        /// </summary>
        /// <returns></returns>
        public NextFestivalMV NextFestival()
        {
            var url = "https://www.daojishi321.com/";
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var festival = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div/div[2]/div[2]/div/span[1]/span[2]/strong[1]/a").InnerText;

            var date = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/div/div[2]/div[2]/div/span[1]/span[2]/strong[2]").InnerText;
            NextFestivalMV nextFestivalMV = new NextFestivalMV() 
            {
                Festival = festival,
                FestivalDate = date,
            };
            return nextFestivalMV;
        }
    }
}

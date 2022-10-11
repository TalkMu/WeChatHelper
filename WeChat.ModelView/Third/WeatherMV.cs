using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.ModelView.Third
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.ModelView.Third
	*│　类    名： WeatherMV
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/11 11:24:46
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class WeatherMV
    {
		/// <summary>
		/// 天气现象（汉字描述）
		/// </summary>
		public string Weather { get; set; }
		/// <summary>
		/// 实时气温
		/// </summary>
		public string Temperature { get; set; }
		/// <summary>
		/// 最低温
		/// </summary>
		public string MinimumTemperature { get; set; }
		/// <summary>
		/// 最高温
		/// </summary>
		public string HighestTemperature { get; set; }
		/// <summary>
		/// 风向描述
		/// </summary>
		public string WindDirection { get; set; }
		/// <summary>
		/// 风力级别，单位：级
		/// </summary>
		public string WindPower { get; set; }
		/// <summary>
		/// 空气湿度
		/// </summary>
		public string Humidity { get; set; }

	}
}

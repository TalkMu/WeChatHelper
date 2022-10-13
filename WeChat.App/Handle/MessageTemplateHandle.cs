using Masuit.Tools.DateTimeExt;
using System;
using System.Windows.Forms;
using WeChat.App.Quartz;
using WeChat.App.Service;
using WeChat.Domain.Constant;
using WeChat.Extend.Helper.Date;
using WeChat.Service.Robot;
using WeChat.Service.System;
using WeChat.Service.ThirdApi;

namespace WeChat.App.Handle
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.App.Handle
	*│　类    名： MessageTemplateHandle
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/10 14:12:27
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class MessageTemplateHandle
    {
		/// <summary>
		/// 加载任务
		/// </summary>
		public void LoadQuart()
		{
			var list = new MessageTemplateService().FindByEnable(true);
			list.ForEach(x =>
			{
				//QuartzManage.StartJob<MessageTemplateQuartz>(x.TaskCode, QuartzConstant.MESSAGE_TEMPLATE, x.Cron);
			});
		}

		public void ExecQuart(string taskCode) 
		{
            // 消息模板
            var wxMessageTemplate = new MessageTemplateService().FindByTaskCode(taskCode);

            // 查询需要发送的用户列表
            var wxUserList = new UserMessageTemplateService().FindWxUserByMsgTemplateId(wxMessageTemplate.Id);

            // 处理模板数据
            var content = wxMessageTemplate.Content;
            // 年
            if (content.Contains("${Year}"))
            {
                var year = DateHelper.Format(DateTime.Now, "yyyy");
                content = content.Replace("${Year}", year);
            }
            // 月
            if (content.Contains("${Month}"))
            {
                var month = DateHelper.Format(DateTime.Now, "MM");
                content = content.Replace("${Month}", month);
            }
            // 日
            if (content.Contains("${Day}"))
            {
                var day = DateHelper.Format(DateTime.Now, "dd");
                content = content.Replace("${Day}", day);
            }
            // 星期
            if (content.Contains("${Week}"))
            {
                var week = DateHelper.DayOfWeek(DateTime.Now);
                content = content.Replace("${Week}", week);
            }
            // 农历日期
            if (content.Contains("${LunarCalendar}"))
            {
                ChineseCalendar calendar = new ChineseCalendar(DateTime.Now);
                var result = calendar.GanZhiYearString + "农历" + calendar.ChineseMonthString + calendar.ChineseDayString;
                content = content.Replace("${LunarCalendar}", result);
            }
            // 下一个节日
            if (content.Contains("${Festival}"))
            {
                var result = new ApiService().NextFestival();
                content = content.Replace("${Festival}", result.Festival);
                content = content.Replace("${FestivalCountDown}", result.FestivalCountDown);
            }
            // 格言
            if (content.Contains("${Motto}"))
            {
                var result = new ApiService().GetMotto();
                content = content.Replace("${Motto}", result);
            }


            // 恋爱累计天数
            if (content.Contains("${LoveNum}")) 
            {
                var result = DateTime.Now.Subtract(DateTime.Parse(Appsetting.LOVE_START_DATE));
                content = content.Replace("${LoveNum}", result.Days.ToString());
            }

            

            // 词霸
            if (content.Contains("${CiBa}")) 
            {
                var result = new ApiService().GetCiBa();
                content = content.Replace("${CiBa}", result);
            }
            SocketService socketService = new SocketService();
            DictService dictService = new DictService();
            var dict = dictService.FindByDictCode("DEFAULT_CITY_CODE");
            wxUserList.ForEach(user =>
            {
                if (user.CityCode != null || dict != null)
                {
                    if (user.CityCode == null)
                    {
                        user.CityCode = dict.DictVal;
                        user.CityName = dict.Remark;
                    }
                    // 城市
                    if (content.Contains("${City}"))
                    {
                        content = content.Replace("${City}", user.CityName);
                    }
                    // 天气
                    var weather = new ApiService().GetWeatherInfo(user.CityCode);
                    if (content.Contains("${Weather}"))
                    {
                        content = content.Replace("${Weather}", weather.Weather);
                    }
                    // 当前温度
                    if (content.Contains("${Temperature}"))
                    {
                        content = content.Replace("${Temperature}", weather.Temperature + "℃");
                    }
                    // 风向
                    if (content.Contains("${WindDirection}"))
                    {
                        content = content.Replace("${WindDirection}", weather.WindDirection);
                    }
                    // 风向等级
                    if (content.Contains("${WindPower}"))
                    {
                        content = content.Replace("${WindPower}", weather.WindPower);
                    }
                    // 空气湿度
                    if (content.Contains("${Humidity}"))
                    {
                        content = content.Replace("${Humidity}", weather.Humidity + "%");
                    }
                }
                
                socketService.Send(user.WxId, content);
                //MessageBox.Show($"[Task]:{taskCode} content:{content}");
            });
            

            
        }
	}
}

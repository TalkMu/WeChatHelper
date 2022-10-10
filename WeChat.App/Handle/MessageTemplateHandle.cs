using Masuit.Tools.DateTimeExt;
using System;
using System.Windows.Forms;
using WeChat.App.Quartz;
using WeChat.App.Service;
using WeChat.Domain.Constant;
using WeChat.Extend.Helper.Date;
using WeChat.Service.Robot;

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
				QuartzManage.StartJob<MessageTemplateQuartz>(x.TaskCode, QuartzConstant.MESSAGE_TEMPLATE, x.Cron);
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
            if (content.Contains("${year}"))
            {
                var year = DateHelper.Format(DateTime.Now, "yyyy");
                content = content.Replace("${year}", year);
            }
            // 月
            if (content.Contains("${month}"))
            {
                var month = DateHelper.Format(DateTime.Now, "MM");
                content = content.Replace("${month}", month);
            }
            // 日
            if (content.Contains("${day}"))
            {
                var day = DateHelper.Format(DateTime.Now, "dd");
                content = content.Replace("${day}", day);
            }
            // 星期
            if (content.Contains("${week}"))
            {
                var week = DateHelper.DayOfWeek(DateTime.Now);
                content = content.Replace("${week}", week);
            }
            // 农历日期
            if (content.Contains("${lunar_calendar}"))
            {
                ChineseCalendar calendar = new ChineseCalendar(DateTime.Now);
                var result = "农历" + calendar.ChineseMonthString + calendar.ChineseDayString;
                content = content.Replace("${lunar_calendar}", result);
            }
            // 下一个节日
            if (content.Contains("${festival}"))
            {
                var result = ApiService.NextFestival();
                var arr = result.Split("|");
                if (arr.Length == 2) 
                {
                    content = content.Replace("${festival}", arr[0]);
                    var d = DateTime.Parse(arr[1]).Subtract(DateTime.Now);
                    content = content.Replace("${festival_num}", d.Days.ToString());
                }
                
            }

            
            // 恋爱累计天数
            if (content.Contains("${love_num}")) 
            {
                var result = DateTime.Now.Subtract(DateTime.Parse(Appsetting.LOVE_START_DATE));
                content = content.Replace("${love_num}", result.Days.ToString());
            }

            

            // 词霸
            if (content.Contains("${ciba}")) 
            {
                var result = ApiService.GetCiBa();
                content = content.Replace("${ciba}", result);
            }
            SocketService socketService = new SocketService();
            wxUserList.ForEach(user =>
            {
                // 城市
                if (content.Contains("${city}"))
                {
                    content = content.Replace("${city}", user.City);
                }
                // 天气
                var weather = ApiService.GetToDayWeather(user.City);
                if (content.Contains("${weather}")) 
                {
                    content = content.Replace("${weather}", weather.dayweather);
                }
                // 温度范围
                if (content.Contains("${temperature}"))
                {
                    content = content.Replace("${temperature}", weather.daytemp);
                }
                // 空气质量
                if (content.Contains("${air_quality}"))
                {
                    content = content.Replace("${air_quality}", "良 | 87");
                }
                //socketService.Send(user.WxId, content);
            });
            

            MessageBox.Show($"[Task]:{taskCode} content:{content}");
        }
	}
}

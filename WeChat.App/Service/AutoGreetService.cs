using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Domain;
using WeChat.Domain.Enum;
using WeChat.DTO.Socket;
using WeChat.Service.WeChat;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.Service.AutoGreet
*│　类    名： AutoGreetService
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 14:54:32
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class AutoGreetService
    {
        public void ExcAutoGreetTask()
        {
            var config = new AutoGreetConfigService().FindByUserId(AppData.loginUser.Id);
            if (config == null || config.EnableAutoGreet != true) 
            {
                return;
            }
            // 获取需要发送的用户列表
            var list = new FriendService().GetAutoGreetUserList();
            list.ForEach(p =>
            {
                // 获取问候消息
                var message = new StringBuilder(DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒"));
                message.Append("\n");
                if (config.EnableMotto == true)
                {
                    // 获取格言
                    var motto = ApiService.GetMotto();
                    message.Append(motto);
                    message.Append("\n");
                }
                if (config.EnableWeather == true)
                {
                    // 查询天气
                    var todayWeather = ApiService.GetToDayWeather("成都");
                    message.Append(todayWeather);
                    message.Append("\n");
                }
                if (config.EnableCiba == true)
                {
                    // 获取词霸语句
                    var ciba = ApiService.GetCiBa();
                    message.Append(ciba);
                    message.Append("\n");
                }
                new SocketService().Send(p.WxId,message.ToString());
            });
        }

        //private List<WxUser> ListByUserId(string userId)
        //{
        //    using (WeChatHelperContext c = new WeChatHelperContext())
        //    {
        //        return c.WxAutoGreets.Where(p => p.UserId.Equals(userId)).Select(p=>p.GreetUser).ToList();
        //    }
        //}
    }
}

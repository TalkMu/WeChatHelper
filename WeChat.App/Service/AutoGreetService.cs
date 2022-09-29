using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        //public void SendText() 
        //{
        //    //var client = WxSocket.GetCurClient();
        //    //if (client == null)
        //    //{
        //    //    return;
        //    //}
        //    //var useId = client.User.UserId;
        //    //using (WeChatHelperContext c = new WeChatHelperContext())
        //    //{
        //    //    var config = c.WxAutoGreetConfigs.FirstOrDefault(p => p.UserId.Equals(useId));
        //    //    if (config.Status == false)
        //    //    {
        //    //        return;
        //    //    }
        //    //    StringBuilder message = new StringBuilder(DateTime.Now.ToString("yyyy年MM月dd HH时mm分ss秒"));
        //    //    message.Append("\n");
        //    //    if (config.EnableMotto == true)
        //    //    {
        //    //        message.Append(ApiService.GetMotto());
        //    //        message.Append("\n");
        //    //    }
        //    //    if (config.EnableWeather == true)
        //    //    {
        //    //        message.Append(ApiService.GetToDayWeather("成都"));
        //    //        message.Append("\n");
        //    //    }
        //    //    if (config.EnableCiba == true)
        //    //    {
        //    //        message.Append(ApiService.GetCiBa());
        //    //        message.Append("\n");
        //    //    }
        //    //    if (string.IsNullOrEmpty(config.SuffixText))
        //    //    {
        //    //        message.Append(config.SuffixText);
        //    //    }
        //    //    var wxIds = c.WxAutoGreets.Where(p=>p.UserId.Equals(useId)).Select(x=>x.UserId).ToList();
        //    //    MessageService messageService = new MessageService();
        //    //    wxIds.ForEach(wxId =>
        //    //    {
        //    //        messageService.SendText(wxId, message.ToString());
        //    //    });
        //    //}
        //}

        //public List<WxUser> GetList() 
        //{
        //    //var client = WxSocket.GetCurClient();
        //    //if (client == null)
        //    //{
        //    //    return null;
        //    //}
        //    //using (WeChatHelperContext c = new WeChatHelperContext())
        //    //{
        //    //    var list = c.WxAutoGreets.Where(p=>p.UserId == client.User.UserId).Select(x=>x.GreetUser).ToList();
        //    //    return list;
        //    //}
        //    return null;
        //}

        //public bool SaveOrUpdate(WxAutoGreet wxAutoGreet) 
        //{
        //    using (WeChatHelperContext c = new WeChatHelperContext())
        //    {
        //        if (wxAutoGreet.Id == 0)
        //        {
        //            c.WxAutoGreets.Add(wxAutoGreet);
        //        }
        //        else 
        //        {
        //            c.WxAutoGreets.Update(wxAutoGreet);
        //        }
        //        return c.SaveChanges()==1;
        //    }
        //}

        //public bool DeleteById(int id) 
        //{
        //    using (WeChatHelperContext c = new WeChatHelperContext())
        //    {
        //        var wxAutoGreet = c.WxAutoGreets.FirstOrDefault(p => p.Id == id);
        //        if (wxAutoGreet != null)
        //        {
        //            c.WxAutoGreets.Remove(wxAutoGreet);
        //            return true;
        //        }
        //        return false;
        //    }
        //}

        //public void ExcAutoGreetTask()
        //{
        //    //var userId = WxSocket.GetCurUser().UserId;
        //    //MessageService messageService = new MessageService();
        //    //var list = this.ListByUserId(userId);
        //    //var config = new AutoGreetConfigService().FindByUserId(userId);
        //    //// 获取问候消息
        //    //var message = new StringBuilder(DateTime.Now.ToString("yyyy年MM月dd日 HH时mm时ss分"));
        //    //message.Append("\n");
        //    //list.ForEach(p =>
        //    //{
        //    //    if (config.EnableMotto == true)
        //    //    {
        //    //        // 获取格言
        //    //        var motto = ApiService.GetMotto();
        //    //        message.Append(motto);
        //    //        message.Append("\n");
        //    //    }
        //    //    if (config.EnableWeather == true)
        //    //    {
        //    //        // 查询天气
        //    //        var todayWeather = ApiService.GetToDayWeather(p.City);
        //    //        message.Append(todayWeather);
        //    //        message.Append("\n");
        //    //    }
        //    //    if (config.EnableCiba == true)
        //    //    {
        //    //        // 获取词霸语句
        //    //        var ciba = ApiService.GetCiBa();
        //    //        message.Append(ciba);
        //    //        message.Append("\n");
        //    //    }
                
        //    //    messageService.SendText(p.UserId, message.ToString());
        //    //});
        //}

        //private List<WxUser> ListByUserId(string userId)
        //{
        //    using (WeChatHelperContext c = new WeChatHelperContext())
        //    {
        //        return c.WxAutoGreets.Where(p => p.UserId.Equals(userId)).Select(p=>p.GreetUser).ToList();
        //    }
        //}
    }
}

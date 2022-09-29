using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.App.Service
*│　类    名： AutoGreetConfigService
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/4/1 23:10:26
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class AutoGreetConfigService
    {
        //public bool SaveOrUpdate(WxAutoGreetConfig wxAutoGreetConfig)
        //{
        //    using (WeChatHelperContext c = new WeChatHelperContext())
        //    {
        //        if (wxAutoGreetConfig.Id == 0) 
        //        {
        //            c.WxAutoGreetConfigs.Add(wxAutoGreetConfig);
        //        }
        //        else
        //        {
        //            c.WxAutoGreetConfigs.Update(wxAutoGreetConfig);
        //        }
        //        return c.SaveChanges() == 1;
        //    }
        //}

        //internal WxAutoGreetConfig FindByUserId(string userId)
        //{
        //    using (WeChatHelperContext c = new WeChatHelperContext())
        //    {
        //        return c.WxAutoGreetConfigs.FirstOrDefault(p=>p.UserId.Equals(userId));
        //    }
        //}
    }
}

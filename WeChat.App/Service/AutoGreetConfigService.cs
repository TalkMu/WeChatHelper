using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Domain.Models;

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
        public bool SaveOrUpdate(WxAutoGreetConfig wxAutoGreetConfig)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                var config = FindByUserId(wxAutoGreetConfig.UserId);
                if (config == null)
                {
                    c.WxAutoGreetConfigs.Add(wxAutoGreetConfig);
                }
                else
                {
                    config.EnableWeather = wxAutoGreetConfig.EnableWeather;
                    config.EnableAutoGreet = wxAutoGreetConfig.EnableAutoGreet;
                    config.EnableCiba = wxAutoGreetConfig.EnableCiba;
                    config.EnableMotto = wxAutoGreetConfig.EnableMotto;
                    config.ExecuteTime = wxAutoGreetConfig.ExecuteTime;
                }
                return c.SaveChanges() == 1;
            }
        }

        public WxAutoGreetConfig FindByUserId(long userId)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                return c.WxAutoGreetConfigs.FirstOrDefault(p => p.UserId == userId);
            }
        }
    }
}

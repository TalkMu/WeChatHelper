using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.App.Socket;
using WeChat.Domain.Models;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.Service.Friend
*│　类    名： FriendService
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 16:36:39
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class FriendService
    {
        public List<WxUser> GetList() 
        {
            //var client = WxSocket.GetCurClient();
            //using (WeChatHelperContext c = new WeChatHelperContext())
            //{
            //    var list = c.WxUserFriends.Where(p => p.UserId == client.User.UserId).Select(x => x.FriendUser).ToList();
            //    return list;
            //}
            return null;
        }
    }
}

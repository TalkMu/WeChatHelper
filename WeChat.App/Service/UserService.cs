using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.App.Socket;
using WeChat.Domain.Enum;
using WeChat.Domain.Models;
using WeChat.DTO.Socket;
using WeChat.Extend.Helper;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.App.Service
*│　类    名： UserService
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/4/1 22:59:01
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class UserService
    {
        public bool SaveOrUpdate(WxUser wxUser)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                if (!c.WxUsers.Any(p => p.UserId.Equals(wxUser.UserId)))
                {
                    c.WxUsers.Add(wxUser);
                }
                else
                {
                    c.WxUsers.Update(wxUser);
                }
                return c.SaveChanges() == 1;
            }
        }

        #region 查询用户信息
        public void GetWxUserInfo()
        {
            var socketModel = new SocketDTO
            {
                type = SocketDataEnum.USER_LIST
            };
            //WxSocket.SendSocket(JsonHelper.ToJson(socketModel));
        }

        public WxUser FindByWxId(string wxId)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                return c.WxUsers.FirstOrDefault(p => p.UserId.Equals(wxId));
            }
        }
        #endregion
    }
}

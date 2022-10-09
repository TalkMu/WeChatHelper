using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WeChat.Domain.Models;

namespace WeChat.Domain
{
    public class AppData
    {
        /// <summary>
        /// 登录用户
        /// </summary>
        public static WxUser loginUser;

        /// <summary>
        /// socket对象
        /// </summary>
        public static WebSocket webSocket;

        public static long GetUserId()
        {
            if (loginUser != null)
            {
                return loginUser.Id;
            }
            return 0;
        }
    }
}

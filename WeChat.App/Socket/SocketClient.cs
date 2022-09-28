using Fleck;
using System;
using System.Collections.Generic;
using System.Text;
using WeChat.Domain.Models;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.Service.Socket
*│　类    名： SocketClient
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 13:36:25
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Socket
{
    public class SocketClient
    {
        public int Pid { get; set; }
        public bool Selected { get; set; }

        public WxUser User { get; set; }

        public IWebSocketConnection Connection { get; set; }
    }
}

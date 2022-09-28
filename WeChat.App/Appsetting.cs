using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WeChat.App
{
    internal class Appsetting
    {
        /// <summary>
        /// 长链接地址
        /// </summary>
        public static readonly string SOCKET_URL = ConfigurationManager.AppSettings["WsUrl"].ToString();
    }
}

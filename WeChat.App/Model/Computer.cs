using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.App.Model
{
    public class Computer
    {
        /// <summary>
        /// 局域网设备IP
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 路由器IP
        /// </summary>
        public string RouteIp { get; set; }
        /// <summary>
        /// Mac 物理地址
        /// </summary>
        public string Mac { get; set; }
        /// <summary>
        /// 远程桌面端口
        /// </summary>
        public int RemotePort { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 远程唤醒端口
        /// </summary>
        public int WolPort { get;set; }


    }
}

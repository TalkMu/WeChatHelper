using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.App.Service;
using WeChat.App.Socket;
using WeChat.Domain.Models;
using WeChat.DTO.Socket;
using WeChat.Extend.Helper;

namespace WeChat.App.Handle
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  UserHandle 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 23:11:31 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 23:11:31 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class UserHandle
    {

        /// <summary>
        /// 接收当前登录用户信息
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="message"></param>
        public static void ReceiveUserInfo(IWebSocketConnection connection, string message)
        {
            //UserService userService = new UserService();
            //var socket = JsonHelper.FromJson<SocketDTO<WxUser>>(message);
            //userService.SaveOrUpdate(socket.content);
            //var user = userService.FindByWxId(socket.content.UserId);
            //var pId = 1;
            //var curSocketConnon = WxSocket.socketClients.FirstOrDefault(p => p.Pid == pId);
            //curSocketConnon.User = user;
            //if (curSocketConnon == null)
            //{
            //    curSocketConnon = new SocketClient();
            //    curSocketConnon.Connection = connection;
            //    curSocketConnon.Pid = pId;
            //    //WxSocket.socketClients.Add(curSocketConnon);
            //}
            //else
            //{
            //    curSocketConnon.Connection = connection;
            //}

            //var rowIndex = WeChatHelper.form.OpenMoreView.Rows.Add();
            //WeChatHelper.form.OpenMoreView.Rows[rowIndex].Cells["WxId"].Value = user.UserId;
            //WeChatHelper.form.OpenMoreView.Rows[rowIndex].Cells["NickName"].Value = user.NickName;
            //WeChatHelper.form.OpenMoreView.Rows[rowIndex].Cells["Mobile"].Value = user.Mobile;

            // 读取自动问候配置
            AutoGreetHandle.ReadAutoGreetConfig();

            // 初始化AppConfig
            //AppConfigHandle.ReadAppConfig();
        }
    }
}

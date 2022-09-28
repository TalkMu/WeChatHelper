
using System;
using System.Collections.Generic;
using System.Text;
using WeChat.App.Socket;
using WeChat.Domain.Enum;
using WeChat.DTO.Message;
using WeChat.DTO.Socket;
using WeChat.Extend.Helper;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.Service.Message
*│　类    名： MessageService
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 13:50:40
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class MessageService
    {

        public void SendText(string wxId, string message) 
        {
            var socketModel = new SocketDTO
            {
                content = JsonHelper.ToJson(new SendTextDTO
                {
                    WxId = wxId,
                    Message = message
                }),
                type = SocketDataEnum.Cmd_SendTextMessage
            };
            //WxSocket.SendSocket(JsonHelper.ToJson(socketModel));
        }
    }
}

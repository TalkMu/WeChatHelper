using System;
using System.Collections.Generic;
using System.Text;
using WeChat.Domain.Enum;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.DTO.Socket
*│　类    名： SocketDTO
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 13:52:45
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.DTO.Socket
{
    public class SocketDTO
    {
        /// <summary>
        /// Socket消息类型->SocketDataEnum
        /// </summary>
        public SocketDataEnum type { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 群组id 群组内发送@消息时使用
        /// </summary>
        public string roomid { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 接收消息人的 微信原始id
        /// </summary>
        public string wxid { get; set; }

        /// <summary>
        /// 数据内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 扩展消息
        /// </summary>
        public string ext { get; set; }
        /// <summary>
        /// 图片消息的图片地址(绝对路径 D:/xxx.jpg)
        /// </summary>
        public string path { get; set; }
    }
}

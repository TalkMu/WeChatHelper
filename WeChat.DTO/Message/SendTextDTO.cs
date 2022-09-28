using System;
using System.Collections.Generic;
using System.Text;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.DTO.Message
*│　类    名： SendTextDTO
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 14:01:01
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.DTO.Message
{
    public class SendTextDTO
    {
        public string WxId { get; set; }
        public string Message { get; set; }
    }
}

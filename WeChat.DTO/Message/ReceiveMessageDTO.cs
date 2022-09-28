using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.DTO.Message
{
    public class ReceiveMessageDTO
    {
        public string WxId { get; set; }
        public string Content { get; set; }
        public string SenderWxId { get; set; }
    }
}

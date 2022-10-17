using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    public partial class WxUserChatRecord
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 发送人ID
        /// </summary>
        public long FromId { get; set; }
        /// <summary>
        /// 接收人ID
        /// </summary>
        public long ToId { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 文本内容
        /// </summary>
        public string MsgContent { get; set; }

        public virtual WxUser From { get; set; }
        public virtual WxUser To { get; set; }
    }
}

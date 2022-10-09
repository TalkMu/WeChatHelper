using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 用户消息模板
    /// </summary>
    public partial class WxUserMessageTemplate
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 消息模板ID
        /// </summary>
        public long MsgTempId { get; set; }

        public virtual WxMessageTemplate MsgTemp { get; set; }
        public virtual WxUser User { get; set; }
    }
}

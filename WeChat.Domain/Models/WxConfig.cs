using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 助手配置
    /// </summary>
    public partial class WxConfig
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
        /// 开启问候
        /// </summary>
        public ulong EnableAutoGreet { get; set; }
        /// <summary>
        /// 开启闲聊
        /// </summary>
        public ulong EnableAutoChat { get; set; }

        public virtual WxUser User { get; set; }
    }
}

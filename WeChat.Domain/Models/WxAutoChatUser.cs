using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 自动聊天用户配置
    /// </summary>
    public partial class WxAutoChatUser
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
        /// 朋友用户ID
        /// </summary>
        public long FriendUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        public virtual WxUser FriendUser { get; set; }
        public virtual WxUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 用户好友
    /// </summary>
    public partial class WxUserFriend
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
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 开启自动聊天
        /// </summary>
        public ulong EnableAutoChat { get; set; }
        /// <summary>
        /// 开启自动问候
        /// </summary>
        public ulong EnableAutoGreet { get; set; }

        public virtual WxUser FriendUser { get; set; }
        public virtual WxUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 微信用户
    /// </summary>
    public partial class WxUser
    {
        public WxUser()
        {
            WxAutoChatUserFriendUsers = new HashSet<WxAutoChatUser>();
            WxAutoChatUserUsers = new HashSet<WxAutoChatUser>();
            WxAutoGreetConfigs = new HashSet<WxAutoGreetConfig>();
            WxAutoGreetUserFriendUsers = new HashSet<WxAutoGreetUser>();
            WxAutoGreetUserUsers = new HashSet<WxAutoGreetUser>();
            WxConfigs = new HashSet<WxConfig>();
            WxUserFriendFriendUsers = new HashSet<WxUserFriend>();
            WxUserFriendUsers = new HashSet<WxUserFriend>();
        }

        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 微信ID
        /// </summary>
        public string WxId { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string WxCode { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 头像大图
        /// </summary>
        public string BigHeadImg { get; set; }
        /// <summary>
        /// 头像小图
        /// </summary>
        public string LittleHeadImg { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Nation { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string Provice { get; set; }
        /// <summary>
        /// 朋友圈封面
        /// </summary>
        public string Cover { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        public virtual ICollection<WxAutoChatUser> WxAutoChatUserFriendUsers { get; set; }
        public virtual ICollection<WxAutoChatUser> WxAutoChatUserUsers { get; set; }
        public virtual ICollection<WxAutoGreetConfig> WxAutoGreetConfigs { get; set; }
        public virtual ICollection<WxAutoGreetUser> WxAutoGreetUserFriendUsers { get; set; }
        public virtual ICollection<WxAutoGreetUser> WxAutoGreetUserUsers { get; set; }
        public virtual ICollection<WxConfig> WxConfigs { get; set; }
        public virtual ICollection<WxUserFriend> WxUserFriendFriendUsers { get; set; }
        public virtual ICollection<WxUserFriend> WxUserFriendUsers { get; set; }
    }
}

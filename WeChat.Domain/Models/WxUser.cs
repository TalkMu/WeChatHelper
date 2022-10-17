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
            WxUserChatRecordFroms = new HashSet<WxUserChatRecord>();
            WxUserChatRecordTos = new HashSet<WxUserChatRecord>();
            WxUserFriendFriendUsers = new HashSet<WxUserFriend>();
            WxUserFriendUsers = new HashSet<WxUserFriend>();
            WxUserMessageTemplates = new HashSet<WxUserMessageTemplate>();
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
        /// 省份
        /// </summary>
        public int? ProviceId { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public int? CityId { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public int? AreaId { get; set; }
        /// <summary>
        /// 朋友圈封面
        /// </summary>
        public string Cover { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        public virtual WxAddressArea Area { get; set; }
        public virtual WxAddressCity City { get; set; }
        public virtual WxAddressProvince Provice { get; set; }
        public virtual ICollection<WxUserChatRecord> WxUserChatRecordFroms { get; set; }
        public virtual ICollection<WxUserChatRecord> WxUserChatRecordTos { get; set; }
        public virtual ICollection<WxUserFriend> WxUserFriendFriendUsers { get; set; }
        public virtual ICollection<WxUserFriend> WxUserFriendUsers { get; set; }
        public virtual ICollection<WxUserMessageTemplate> WxUserMessageTemplates { get; set; }
    }
}

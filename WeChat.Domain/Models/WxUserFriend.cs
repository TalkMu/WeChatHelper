using System;
using System.Collections.Generic;

#nullable disable

namespace WeChat.Domain.Models
{
    public partial class WxUserFriend
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string FriendUserId { get; set; }
        public string Remarks { get; set; }

        public virtual WxUser FriendUser { get; set; }
        public virtual WxUser User { get; set; }
    }
}

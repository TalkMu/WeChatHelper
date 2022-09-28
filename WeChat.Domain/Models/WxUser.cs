using System;
using System.Collections.Generic;

#nullable disable

namespace WeChat.Domain.Models
{
    public partial class WxUser
    {
        public WxUser()
        {
            WxAppConfigs = new HashSet<WxAppConfig>();
            WxAutoGreetConfigs = new HashSet<WxAutoGreetConfig>();
            WxAutoGreetGreetUsers = new HashSet<WxAutoGreet>();
            WxAutoGreetUsers = new HashSet<WxAutoGreet>();
            WxUserFriendFriendUsers = new HashSet<WxUserFriend>();
            WxUserFriendUsers = new HashSet<WxUserFriend>();
        }

        public string UserId { get; set; }
        public string NickName { get; set; }
        public string Mobile { get; set; }
        public string HeadImg { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Sex { get; set; }
        public string Sign { get; set; }

        public virtual ICollection<WxAppConfig> WxAppConfigs { get; set; }
        public virtual ICollection<WxAutoGreetConfig> WxAutoGreetConfigs { get; set; }
        public virtual ICollection<WxAutoGreet> WxAutoGreetGreetUsers { get; set; }
        public virtual ICollection<WxAutoGreet> WxAutoGreetUsers { get; set; }
        public virtual ICollection<WxUserFriend> WxUserFriendFriendUsers { get; set; }
        public virtual ICollection<WxUserFriend> WxUserFriendUsers { get; set; }
    }
}

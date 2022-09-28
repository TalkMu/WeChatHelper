using System;
using System.Collections.Generic;

#nullable disable

namespace WeChat.Domain.Models
{
    public partial class WxAutoGreet
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string GreetUserId { get; set; }

        public virtual WxUser GreetUser { get; set; }
        public virtual WxUser User { get; set; }
    }
}

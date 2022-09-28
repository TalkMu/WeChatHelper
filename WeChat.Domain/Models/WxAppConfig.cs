using System;
using System.Collections.Generic;

#nullable disable

namespace WeChat.Domain.Models
{
    public partial class WxAppConfig
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public bool? EnableHarvestCode { get; set; }

        public virtual WxUser User { get; set; }
    }
}

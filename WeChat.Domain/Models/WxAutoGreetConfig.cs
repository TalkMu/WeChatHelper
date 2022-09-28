using System;
using System.Collections.Generic;

#nullable disable

namespace WeChat.Domain.Models
{
    public partial class WxAutoGreetConfig
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public bool? Status { get; set; }
        public TimeSpan? GreetTime { get; set; }
        public bool? EnableMotto { get; set; }
        public bool? EnableCiba { get; set; }
        public bool? EnableWeather { get; set; }
        public string SuffixText { get; set; }

        public virtual WxUser User { get; set; }
    }
}

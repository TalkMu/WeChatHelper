
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.App.ModelView
{
    public class WxUserMV
    {
        [JsonProperty(PropertyName = "wx_id")]
        public string WxId { get; set; }

        [JsonProperty(PropertyName = "wx_code")]
        public string WxCode { get; set; }

        [JsonProperty(PropertyName = "wx_name")]
        public string NickName { get; set; }
    }
}

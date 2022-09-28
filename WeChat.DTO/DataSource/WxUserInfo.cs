using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.DTO.DataSource
{
    public class WxUserInfo
    {
        [JsonProperty(PropertyName = "wx_id")]
        public string WxId { get; set; }

        [JsonProperty(PropertyName = "wx_code")]
        public string WxCode { get; set; }

        [JsonProperty(PropertyName = "wx_name")]
        public string NickName { get; set; }
    }
}

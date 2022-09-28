using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.DTO.DataSource
{
    public class WxFriendUser
    {
        [JsonProperty(PropertyName = "wxid")]
        public string WxId { get; set; }
        [JsonProperty(PropertyName = "wxcode")]
        public string WxCode { get; set; }
        [JsonProperty(PropertyName = "headimg")]
        public string HeadImg { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string NickName { get; set; }
        [JsonProperty(PropertyName = "remarks")]
        public string Remark { get; set; }
        [JsonProperty(PropertyName = "node")]
        public string Node { get; set; }
    }
}

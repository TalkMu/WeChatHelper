
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeChat.Domain.Models;

namespace WeChat.App.ModelView.User
{
    public class WxUserMV: WxUser
    {
        [JsonProperty(PropertyName = "wx_id")]
        public string WxId { get; set; }

        [JsonProperty(PropertyName = "wx_code")]
        public string WxCode { get; set; }

        [JsonProperty(PropertyName = "wx_name")]
        public string NickName { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
    }
}

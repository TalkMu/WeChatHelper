using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.DTO.Message
{
    public class WsUser
    {
        /// <summary>
        /// 头像地址
        /// </summary>
        [JsonProperty(PropertyName = "headimg")]
        public string HeadImg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node")]
        public int Node { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "wxcode")]
        public string WxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "wxid")]
        public string WxId { get; set; }
    }
}

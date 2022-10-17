using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeChat.Domain.Enum;

namespace WeChat.DTO.Socket
{
    public class WxServerReceiveDTO<T>
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public T Data { get; set; }
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        /// <summary>
        /// 群聊消息的发送者WxId
        /// </summary>
        [JsonProperty(PropertyName = "id1")]
        public string Sender { get; set; }
        /// <summary>
        /// 私聊WxId 或群聊WxId
        /// </summary>
        [JsonProperty(PropertyName = "wxId")]
        public string WxId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string receiver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int srvid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SocketDataEnum Code { get; set; }
    }
}

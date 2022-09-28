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
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string receiver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sender { get; set; }
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
        public string time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SocketDataEnum Code { get; set; }
    }
}

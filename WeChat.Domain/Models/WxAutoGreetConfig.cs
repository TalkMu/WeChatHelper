using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    public partial class WxAutoGreetConfig
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 开启自动问候
        /// </summary>
        public bool EnableAutoGreet { get; set; }
        /// <summary>
        /// 执行时间
        /// </summary>
        public TimeOnly? ExecuteTime { get; set; }
        /// <summary>
        /// 启用格言
        /// </summary>
        public bool? EnableMotto { get; set; }
        /// <summary>
        /// 启用天气
        /// </summary>
        public bool? EnableWeather { get; set; }
        /// <summary>
        /// 启用词霸
        /// </summary>
        public bool? EnableCiba { get; set; }
        /// <summary>
        /// 结尾内容
        /// </summary>
        public string SuffixText { get; set; }

        public virtual WxUser User { get; set; }
    }
}

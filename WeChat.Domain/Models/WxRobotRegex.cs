using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 机器人-正则匹配
    /// </summary>
    public partial class WxRobotRegex
    {
        public WxRobotRegex()
        {
            WxRobotRegexReplies = new HashSet<WxRobotRegexReply>();
        }

        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 正则表达式
        /// </summary>
        public string Regex { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long CreateBy { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long? UpdateBy { get; set; }

        public virtual ICollection<WxRobotRegexReply> WxRobotRegexReplies { get; set; }
    }
}

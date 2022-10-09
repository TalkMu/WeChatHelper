using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 机器人=》智能回复
    /// </summary>
    public partial class WxRobotRegexReply
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 正则表达式
        /// </summary>
        public long RegexId { get; set; }
        /// <summary>
        /// 回复内容
        /// </summary>
        public string Content { get; set; }
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

        public virtual WxRobotRegex Regex { get; set; }
    }
}

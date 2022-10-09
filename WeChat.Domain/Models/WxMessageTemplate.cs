using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 消息模板配置
    /// </summary>
    public partial class WxMessageTemplate
    {
        public WxMessageTemplate()
        {
            WxUserMessageTemplates = new HashSet<WxUserMessageTemplate>();
        }

        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 消息模板名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 消息模板内容
        /// </summary>
        public string Content { get; set; }
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
        /// <summary>
        /// cron表达式
        /// </summary>
        public string Cron { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public virtual ICollection<WxUserMessageTemplate> WxUserMessageTemplates { get; set; }
    }
}

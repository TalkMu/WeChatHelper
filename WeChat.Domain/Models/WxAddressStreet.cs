using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 地址设置 -》 街道
    /// </summary>
    public partial class WxAddressStreet
    {
        /// <summary>
        /// 自增列
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 街道代码
        /// </summary>
        public string StreetCode { get; set; }
        /// <summary>
        /// 父级区代码
        /// </summary>
        public string AreaCode { get; set; }
        /// <summary>
        /// 街道名称
        /// </summary>
        public string StreetName { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string Lng { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string Lat { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public long? CreateUser { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public long? UpdateUser { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int? IsDeleted { get; set; }
    }
}

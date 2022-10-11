using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 地址设置 -》 地区
    /// </summary>
    public partial class WxAddressArea
    {
        public WxAddressArea()
        {
            WxUsers = new HashSet<WxUser>();
        }

        /// <summary>
        /// 自增列
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 行政区划代码
        /// </summary>
        public string AreaCode { get; set; }
        /// <summary>
        /// 区号
        /// </summary>
        public string AreaNo { get; set; }
        /// <summary>
        /// 父级市代码
        /// </summary>
        public string CityCode { get; set; }
        /// <summary>
        /// 市名称
        /// </summary>
        public string AreaName { get; set; }
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

        public virtual ICollection<WxUser> WxUsers { get; set; }
    }
}

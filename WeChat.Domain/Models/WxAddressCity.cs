using System;
using System.Collections.Generic;

namespace WeChat.Domain.Models
{
    /// <summary>
    /// 地址设置 -》 城市
    /// </summary>
    public partial class WxAddressCity
    {
        public WxAddressCity()
        {
            WxUsers = new HashSet<WxUser>();
        }

        /// <summary>
        /// 自增列
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 市代码
        /// </summary>
        public string CityCode { get; set; }
        /// <summary>
        /// 市名称
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 省代码
        /// </summary>
        public string ProvinceCode { get; set; }
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
        /// <summary>
        /// 区号
        /// </summary>
        public string AreaNo { get; set; }

        public virtual ICollection<WxUser> WxUsers { get; set; }
    }
}

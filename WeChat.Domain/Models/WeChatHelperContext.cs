using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WeChat.Domain.Models
{
    public partial class WeChatHelperContext : DbContext
    {
        public WeChatHelperContext()
        {
        }

        public WeChatHelperContext(DbContextOptions<WeChatHelperContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WxAddressArea> WxAddressAreas { get; set; }
        public virtual DbSet<WxAddressCity> WxAddressCities { get; set; }
        public virtual DbSet<WxAddressProvince> WxAddressProvinces { get; set; }
        public virtual DbSet<WxAddressStreet> WxAddressStreets { get; set; }
        public virtual DbSet<WxDict> WxDicts { get; set; }
        public virtual DbSet<WxMessageTemplate> WxMessageTemplates { get; set; }
        public virtual DbSet<WxRobotRegex> WxRobotRegices { get; set; }
        public virtual DbSet<WxRobotRegexReply> WxRobotRegexReplies { get; set; }
        public virtual DbSet<WxUser> WxUsers { get; set; }
        public virtual DbSet<WxUserFriend> WxUserFriends { get; set; }
        public virtual DbSet<WxUserMessageTemplate> WxUserMessageTemplates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseMySql("server=home.koolss.com;port=3306;user=wechat-helper;password=t4WFTERayphii7k6;database=wechat-helper", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.6.50-mysql"));
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=1qaz!QAZ;database=wechat_helper", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.6.50-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<WxAddressArea>(entity =>
            {
                entity.ToTable("wx_address_area");

                entity.HasComment("地址设置 -》 地区")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.AreaCode, "Index_1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("自增列");

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("area_code")
                    .HasComment("行政区划代码");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("area_name")
                    .HasComment("市名称");

                entity.Property(e => e.AreaNo)
                    .HasMaxLength(40)
                    .HasColumnName("area_no")
                    .HasComment("区号");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(40)
                    .HasColumnName("city_code")
                    .HasComment("父级市代码");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("create_user")
                    .HasComment("创建用户");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(2)")
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否删除");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .HasColumnName("lat")
                    .HasComment("纬度");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .HasColumnName("lng")
                    .HasComment("经度");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("short_name")
                    .HasComment("简称");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(6)")
                    .HasColumnName("sort")
                    .HasComment("排序");

                entity.Property(e => e.Status)
                    .HasColumnType("int(2)")
                    .HasColumnName("status")
                    .HasComment("状态");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("update_user")
                    .HasComment("修改人");
            });

            modelBuilder.Entity<WxAddressCity>(entity =>
            {
                entity.ToTable("wx_address_city");

                entity.HasComment("地址设置 -》 城市")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CityCode, "Index_1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("自增列");

                entity.Property(e => e.AreaNo)
                    .HasMaxLength(40)
                    .HasColumnName("area_no")
                    .HasComment("区号");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("city_code")
                    .HasComment("市代码");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("city_name")
                    .HasComment("市名称");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("create_user")
                    .HasComment("创建用户");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(2)")
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否删除");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .HasColumnName("lat")
                    .HasComment("纬度");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .HasColumnName("lng")
                    .HasComment("经度");

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(40)
                    .HasColumnName("province_code")
                    .HasComment("省代码");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("short_name")
                    .HasComment("简称");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(6)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序");

                entity.Property(e => e.Status)
                    .HasColumnType("int(2)")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("update_user")
                    .HasComment("修改人");
            });

            modelBuilder.Entity<WxAddressProvince>(entity =>
            {
                entity.ToTable("wx_address_province");

                entity.HasComment("地址设置 -》 省份")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ProvinceCode, "Index_1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("自增列");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("create_user")
                    .HasComment("创建用户");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(2)")
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否删除");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .HasColumnName("lat")
                    .HasComment("纬度");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .HasColumnName("lng")
                    .HasComment("经度");

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("province_code")
                    .HasComment("省份代码");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("province_name")
                    .HasComment("省份名称");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("short_name")
                    .HasComment("简称");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(6)")
                    .HasColumnName("sort")
                    .HasComment("排序");

                entity.Property(e => e.Status)
                    .HasColumnType("int(2)")
                    .HasColumnName("status")
                    .HasComment("状态");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("update_user")
                    .HasComment("修改人");
            });

            modelBuilder.Entity<WxAddressStreet>(entity =>
            {
                entity.ToTable("wx_address_street");

                entity.HasComment("地址设置 -》 街道")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.StreetCode, "Index_1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("自增列");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(40)
                    .HasColumnName("area_code")
                    .HasComment("父级区代码");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("create_user")
                    .HasComment("创建用户");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(2)")
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否删除");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .HasColumnName("lat")
                    .HasComment("纬度");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .HasColumnName("lng")
                    .HasComment("经度");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("short_name")
                    .HasComment("简称");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(6)")
                    .HasColumnName("sort")
                    .HasComment("排序");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status")
                    .HasComment("状态");

                entity.Property(e => e.StreetCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("street_code")
                    .HasComment("街道代码");

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("street_name")
                    .HasComment("街道名称");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("bigint(64)")
                    .HasColumnName("update_user")
                    .HasComment("修改人");
            });

            modelBuilder.Entity<WxDict>(entity =>
            {
                entity.ToTable("wx_dict");

                entity.HasComment("字典");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("create_by")
                    .HasComment("创建人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasComment("创建时间");

                entity.Property(e => e.DictCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dict_code")
                    .HasComment("字典代码");

                entity.Property(e => e.DictName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dict_name")
                    .HasComment("字典名称");

                entity.Property(e => e.DictVal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dict_val")
                    .HasComment("字典值");

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasComment("是否启用");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .HasColumnName("remark")
                    .HasComment("备注");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("update_by")
                    .HasComment("修改人");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");
            });

            modelBuilder.Entity<WxMessageTemplate>(entity =>
            {
                entity.ToTable("wx_message_template");

                entity.HasComment("消息模板配置");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("content")
                    .HasComment("消息模板内容");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("create_by")
                    .HasComment("创建人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasComment("创建时间");

                entity.Property(e => e.Cron)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("cron")
                    .HasComment("cron表达式");

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasComment("是否启用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("消息模板名称");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .HasColumnName("remark")
                    .HasComment("备注");

                entity.Property(e => e.TaskCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("task_code")
                    .HasComment("任务代码");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("update_by")
                    .HasComment("修改人");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");
            });

            modelBuilder.Entity<WxRobotRegex>(entity =>
            {
                entity.ToTable("wx_robot_regex");

                entity.HasComment("机器人-正则匹配");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("create_by")
                    .HasComment("创建人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasComment("创建时间");

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasComment("是否启用");

                entity.Property(e => e.Regex)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("regex")
                    .HasComment("正则表达式");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("update_by")
                    .HasComment("修改人");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");
            });

            modelBuilder.Entity<WxRobotRegexReply>(entity =>
            {
                entity.ToTable("wx_robot_regex_reply");

                entity.HasComment("机器人=》智能回复");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("content")
                    .HasComment("回复内容");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("create_by")
                    .HasComment("创建人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasComment("创建时间");

                entity.Property(e => e.RegexId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("regex_id")
                    .HasComment("正则表达式");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("update_by")
                    .HasComment("修改人");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("修改时间");

                entity.HasOne(d => d.Regex)
                    .WithMany(p => p.WxRobotRegexReplies)
                    .HasForeignKey(d => d.RegexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_robot_regex_reply_wx_robot_regex_1");
            });

            modelBuilder.Entity<WxUser>(entity =>
            {
                entity.ToTable("wx_user");

                entity.HasComment("微信用户");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("area_id")
                    .HasComment("区域");

                entity.Property(e => e.BigHeadImg)
                    .HasMaxLength(255)
                    .HasColumnName("big_head_img")
                    .HasComment("头像大图");

                entity.Property(e => e.CityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("city_id")
                    .HasComment("城市");

                entity.Property(e => e.Cover)
                    .HasMaxLength(100)
                    .HasColumnName("cover")
                    .HasComment("朋友圈封面");

                entity.Property(e => e.LittleHeadImg)
                    .HasMaxLength(255)
                    .HasColumnName("little_head_img")
                    .HasComment("头像小图");

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .HasColumnName("nation")
                    .HasComment("国家");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .HasColumnName("nick_name")
                    .HasComment("昵称");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone")
                    .HasComment("电话");

                entity.Property(e => e.ProviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provice_id")
                    .HasComment("省份");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .HasColumnName("remark")
                    .HasComment("备注");

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .HasColumnName("sex")
                    .HasComment("性别");

                entity.Property(e => e.Sign)
                    .HasMaxLength(100)
                    .HasColumnName("sign")
                    .HasComment("签名");

                entity.Property(e => e.WxCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("wx_code")
                    .HasComment("微信号");

                entity.Property(e => e.WxId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("wx_id")
                    .HasComment("微信ID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.WxUsers)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("fk_wx_user_wx_address_area_1");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.WxUsers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("fk_wx_user_wx_address_city_1");

                entity.HasOne(d => d.Provice)
                    .WithMany(p => p.WxUsers)
                    .HasForeignKey(d => d.ProviceId)
                    .HasConstraintName("fk_wx_user_wx_address_province_1");
            });

            modelBuilder.Entity<WxUserFriend>(entity =>
            {
                entity.ToTable("wx_user_friend");

                entity.HasComment("用户好友");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasComment("创建时间");

                entity.Property(e => e.FriendUserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("friend_user_id")
                    .HasComment("朋友用户ID");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("remark")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.FriendUser)
                    .WithMany(p => p.WxUserFriendFriendUsers)
                    .HasForeignKey(d => d.FriendUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_user_friend_wx_user_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxUserFriendUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_user_friend_wx_user_1");
            });

            modelBuilder.Entity<WxUserMessageTemplate>(entity =>
            {
                entity.ToTable("wx_user_message_template");

                entity.HasComment("用户消息模板");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.MsgTempId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("msg_temp_id")
                    .HasComment("消息模板ID");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.MsgTemp)
                    .WithMany(p => p.WxUserMessageTemplates)
                    .HasForeignKey(d => d.MsgTempId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_user_message_template_wx_message_template_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxUserMessageTemplates)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_user_message_template_wx_user_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

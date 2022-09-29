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

        public virtual DbSet<WxAutoChatUser> WxAutoChatUsers { get; set; }
        public virtual DbSet<WxAutoGreetConfig> WxAutoGreetConfigs { get; set; }
        public virtual DbSet<WxAutoGreetUser> WxAutoGreetUsers { get; set; }
        public virtual DbSet<WxConfig> WxConfigs { get; set; }
        public virtual DbSet<WxUser> WxUsers { get; set; }
        public virtual DbSet<WxUserFriend> WxUserFriends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=home.koolss.com;port=3306;user=wechat_robot;password=WfrWxLX8wacek8HM;database=wechat_robot", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.6.50-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<WxAutoChatUser>(entity =>
            {
                entity.ToTable("wx_auto_chat_user");

                entity.HasComment("自动聊天用户配置");

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

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.FriendUser)
                    .WithMany(p => p.WxAutoChatUserFriendUsers)
                    .HasForeignKey(d => d.FriendUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_chat_user_wx_user_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxAutoChatUserUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_chat_user_wx_user_1");
            });

            modelBuilder.Entity<WxAutoGreetConfig>(entity =>
            {
                entity.ToTable("wx_auto_greet_config");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.EnableAutoGreet)
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_auto_greet")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("开启自动问候");

                entity.Property(e => e.EnableCiba)
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_ciba")
                    .HasComment("启用词霸");

                entity.Property(e => e.EnableMotto)
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_motto")
                    .HasComment("启用格言");

                entity.Property(e => e.EnableWeather)
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_weather")
                    .HasComment("启用天气");

                entity.Property(e => e.ExecuteTime)
                    .HasColumnType("time")
                    .HasColumnName("execute_time")
                    .HasComment("执行时间");

                entity.Property(e => e.SuffixText)
                    .HasMaxLength(200)
                    .HasColumnName("suffix_text")
                    .HasComment("结尾内容");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxAutoGreetConfigs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_greet_config_wx_user_1");
            });

            modelBuilder.Entity<WxAutoGreetUser>(entity =>
            {
                entity.ToTable("wx_auto_greet_user");

                entity.HasComment("自动问候用户配置");

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

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.FriendUser)
                    .WithMany(p => p.WxAutoGreetUserFriendUsers)
                    .HasForeignKey(d => d.FriendUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_greet_user_wx_user_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxAutoGreetUserUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_greet_user_wx_user_1");
            });

            modelBuilder.Entity<WxConfig>(entity =>
            {
                entity.ToTable("wx_config");

                entity.HasComment("助手配置");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.EnableAutoChat)
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_auto_chat")
                    .HasComment("开启闲聊");

                entity.Property(e => e.EnableAutoGreet)
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_auto_greet")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("开启问候");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxConfigs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_config_wx_user_1");
            });

            modelBuilder.Entity<WxUser>(entity =>
            {
                entity.ToTable("wx_user");

                entity.HasComment("微信用户");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.BigHeadImg)
                    .HasMaxLength(255)
                    .HasColumnName("big_head_img")
                    .HasComment("头像大图");

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

                entity.Property(e => e.Provice)
                    .HasMaxLength(50)
                    .HasColumnName("provice")
                    .HasComment("地区");

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
            });

            modelBuilder.Entity<WxUserFriend>(entity =>
            {
                entity.ToTable("wx_user_friend");

                entity.HasComment("用户好友");

                entity.HasIndex(e => e.UserId, "fk_wx_user_friend_wx_user_1");

                entity.HasIndex(e => e.FriendUserId, "fk_wx_user_friend_wx_user_2");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

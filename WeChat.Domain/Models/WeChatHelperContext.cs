using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

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

        public virtual DbSet<WxAppConfig> WxAppConfigs { get; set; }
        public virtual DbSet<WxAutoGreet> WxAutoGreets { get; set; }
        public virtual DbSet<WxAutoGreetConfig> WxAutoGreetConfigs { get; set; }
        public virtual DbSet<WxUser> WxUsers { get; set; }
        public virtual DbSet<WxUserFriend> WxUserFriends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=home.koolss.com;port=3306;user=wechat_robot;password=WfrWxLX8wacek8HM;database=wechat_robot");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WxAppConfig>(entity =>
            {
                entity.ToTable("wx_app_config");

                entity.HasComment("APP设置");

                entity.HasIndex(e => e.UserId, "fk_wx_app_config_wx_user_1");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.EnableHarvestCode)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_harvest_code")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("开启收货码");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxAppConfigs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_app_config_wx_user_1");
            });

            modelBuilder.Entity<WxAutoGreet>(entity =>
            {
                entity.ToTable("wx_auto_greet");

                entity.HasComment("自动问候用户列表");

                entity.HasIndex(e => e.UserId, "fk_wx_auto_greet_wx_user_1");

                entity.HasIndex(e => e.GreetUserId, "fk_wx_auto_greet_wx_user_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.GreetUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("greet_user_id")
                    .HasComment("问候用户ID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.GreetUser)
                    .WithMany(p => p.WxAutoGreetGreetUsers)
                    .HasForeignKey(d => d.GreetUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_greet_wx_user_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxAutoGreetUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_greet_wx_user_1");
            });

            modelBuilder.Entity<WxAutoGreetConfig>(entity =>
            {
                entity.ToTable("wx_auto_greet_config");

                entity.HasComment("自动问候配置");

                entity.HasIndex(e => e.UserId, "fk_wx_auto_greet_config_wx_user_1");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.EnableCiba)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_ciba")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("是否打开词霸");

                entity.Property(e => e.EnableMotto)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_motto")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("是否打开格言");

                entity.Property(e => e.EnableWeather)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("enable_weather")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("是否打开天气");

                entity.Property(e => e.GreetTime)
                    .HasColumnName("greet_time")
                    .HasComment("自动问候时间");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("status")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("是否开启自动问候");

                entity.Property(e => e.SuffixText)
                    .HasMaxLength(500)
                    .HasColumnName("suffix_text")
                    .HasComment("结尾内容");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_id")
                    .HasComment("用户ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WxAutoGreetConfigs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wx_auto_greet_config_wx_user_1");
            });

            modelBuilder.Entity<WxUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("wx_user");

                entity.HasComment("用户基本信息");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id")
                    .HasComment("微信ID");

                entity.Property(e => e.City)
                    .HasMaxLength(10)
                    .HasColumnName("city")
                    .HasComment("市");

                entity.Property(e => e.HeadImg)
                    .HasMaxLength(500)
                    .HasColumnName("head_img")
                    .HasComment("头像");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .HasColumnName("mobile")
                    .HasComment("电话");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .HasColumnName("nick_name")
                    .HasComment("昵称");

                entity.Property(e => e.Province)
                    .HasMaxLength(10)
                    .HasColumnName("province")
                    .HasComment("省");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasColumnName("sex")
                    .IsFixedLength(true)
                    .HasComment("性别");

                entity.Property(e => e.Sign)
                    .HasMaxLength(500)
                    .HasColumnName("sign")
                    .HasComment("签名");
            });

            modelBuilder.Entity<WxUserFriend>(entity =>
            {
                entity.ToTable("wx_user_friend");

                entity.HasComment("用户好友信息表");

                entity.HasIndex(e => e.UserId, "fk_wx_user_friend_wx_user_1");

                entity.HasIndex(e => e.FriendUserId, "fk_wx_user_friend_wx_user_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.FriendUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("friend_user_id")
                    .HasComment("好友ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .HasColumnName("remarks")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
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

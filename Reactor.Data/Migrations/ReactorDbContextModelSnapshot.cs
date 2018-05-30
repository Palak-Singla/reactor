﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Reactor.Data.EfContext;
using System;

namespace Reactor.Data.Migrations
{
    [DbContext(typeof(ReactorDbContext))]
    partial class ReactorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Chats.Chat", b =>
                {
                    b.Property<string>("ChatId")
                        .HasMaxLength(256);

                    b.HasKey("ChatId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Comments.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentById")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("CommentById");

                    b.HasIndex("PostId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Follows.Follow", b =>
                {
                    b.Property<string>("FollowerId")
                        .HasMaxLength(450);

                    b.Property<string>("FolloweeId")
                        .HasMaxLength(450);

                    b.HasKey("FollowerId", "FolloweeId");

                    b.HasIndex("FolloweeId");

                    b.ToTable("Follow");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Friends.Friend", b =>
                {
                    b.Property<string>("RequestedById")
                        .HasMaxLength(450);

                    b.Property<string>("RequestedToId")
                        .HasMaxLength(450);

                    b.Property<DateTime?>("BecameFriendsOn");

                    b.Property<DateTime?>("RequestedOn");

                    b.Property<int>("Status");

                    b.HasKey("RequestedById", "RequestedToId");

                    b.HasIndex("RequestedToId");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Likes.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("LikeById")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("LikeById");

                    b.HasIndex("PostId");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Messages.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("RecipientId")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Notifications.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsRead");

                    b.Property<string>("RecipientId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Notifications.NotificationAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("NotificationId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NotificationId");

                    b.ToTable("NotificationAttribute");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Photos.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Posts.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<DateTime>("CreatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Reactor.Core.Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePictureUrl")
                        .HasMaxLength(256);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Reactor.Core.Domain.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Comments.Comment", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User", "CommentBy")
                        .WithMany("Comments")
                        .HasForeignKey("CommentById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Reactor.Core.Domain.Posts.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Follows.Follow", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User", "Followee")
                        .WithMany("Followers")
                        .HasForeignKey("FolloweeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Reactor.Core.Domain.Users.User", "Follower")
                        .WithMany("Followees")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Friends.Friend", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User", "RequestedBy")
                        .WithMany("SentFriendRequests")
                        .HasForeignKey("RequestedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Reactor.Core.Domain.Users.User", "RequestedTo")
                        .WithMany("ReceievedFriendRequests")
                        .HasForeignKey("RequestedToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Likes.Like", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User", "LikeBy")
                        .WithMany("Likes")
                        .HasForeignKey("LikeById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Reactor.Core.Domain.Posts.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Messages.Message", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Chats.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Notifications.Notification", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User", "Recipient")
                        .WithMany("Notifications")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Notifications.NotificationAttribute", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Notifications.Notification", "Notification")
                        .WithMany("Attributes")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Photos.Photo", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Posts.Post", "Post")
                        .WithMany("Photos")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reactor.Core.Domain.Posts.Post", b =>
                {
                    b.HasOne("Reactor.Core.Domain.Users.User", "CreatedBy")
                        .WithMany("Posts")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

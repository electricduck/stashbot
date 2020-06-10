﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StashBot;

namespace StashBot.Migrations
{
    [DbContext(typeof(StashBotDbContext))]
    partial class StashBotDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("StashBot.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanDeleteOthers")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanFlushQueue")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanManageAuthors")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanQueue")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TelegramDetailsLastUpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("TelegramId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TelegramName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelegramUsername")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelegramUsernameUpper")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("StashBot.Models.QueueItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostFailureReason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PostedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("QueuedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UsernameUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MessageId", "SourceUrl");

                    b.ToTable("Queue");
                });

            modelBuilder.Entity("StashBot.Models.QueueItem", b =>
                {
                    b.HasOne("StashBot.Models.Author", "Author")
                        .WithMany("QueueItems")
                        .HasForeignKey("AuthorId");
                });
#pragma warning restore 612, 618
        }
    }
}

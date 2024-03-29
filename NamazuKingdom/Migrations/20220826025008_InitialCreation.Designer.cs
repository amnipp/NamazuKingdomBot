﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NamazuKingdom.Services;

#nullable disable

namespace NamazuKingdom.Migrations
{
    [DbContext(typeof(NamazuKingdomDbContext))]
    [Migration("20220826025008_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("NamazuKingdom.Models.DiscordUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<long>("DiscordUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PreferredPronouns")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DiscordUsers");
                });

            modelBuilder.Entity("NamazuKingdom.Models.UserSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ShouldShowBirthday")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TTSVoiceName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<bool>("UseTTS")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserRefId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserRefId")
                        .IsUnique();

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("NamazuKingdom.Models.UserSettings", b =>
                {
                    b.HasOne("NamazuKingdom.Models.DiscordUsers", "DiscordUser")
                        .WithOne("UserSettings")
                        .HasForeignKey("NamazuKingdom.Models.UserSettings", "UserRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscordUser");
                });

            modelBuilder.Entity("NamazuKingdom.Models.DiscordUsers", b =>
                {
                    b.Navigation("UserSettings")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

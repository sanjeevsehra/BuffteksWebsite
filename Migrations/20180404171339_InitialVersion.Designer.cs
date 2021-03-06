﻿// <auto-generated />
using BuffteksWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace BuffteksWebsite.Migrations
{
    [DbContext(typeof(BuffteksWebsiteContext))]
    [Migration("20180404171339_InitialVersion")]
    partial class InitialVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("BuffteksWebsite.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birthday");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Major");

                    b.Property<string>("Phone");

                    b.Property<string>("Standing");

                    b.HasKey("MemberID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}

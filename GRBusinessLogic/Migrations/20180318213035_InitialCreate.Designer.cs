﻿// <auto-generated />
using GR.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace GRBusinessLogic.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180318213035_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("GR.BusinessLogic.Models.Item", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("Quality");

                    b.Property<int>("SellIn");

                    b.HasKey("Name");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}

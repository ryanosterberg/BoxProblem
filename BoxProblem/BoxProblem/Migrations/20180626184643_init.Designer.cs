﻿// <auto-generated />
using BoxProblem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BoxProblem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180626184643_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoxProblem.Data.BoxInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanHoldLiquid");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("InventoryCount");

                    b.Property<int>("Volume");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Boxes");
                });
#pragma warning restore 612, 618
        }
    }
}

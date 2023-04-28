﻿// <auto-generated />
using System;
using EshopApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EshopApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230428073316_addedVirtual")]
    partial class addedVirtual
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EshopApi.Data.Model.CompanyKeys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CompanyKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CompanyKeys");
                });

            modelBuilder.Entity("EshopApi.Data.Model.PurchaseOrderHeaders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("PoNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("PurchaseOrderItemsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseOrderItemsId");

                    b.ToTable("PurchaseOrderHeaders");
                });

            modelBuilder.Entity("EshopApi.Data.Model.PurchaseOrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<float>("PricePerUnit")
                        .HasColumnType("real");

                    b.Property<int>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<string>("ShopItemTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrderItems");
                });

            modelBuilder.Entity("EshopApi.Data.Model.PurchaseOrderHeaders", b =>
                {
                    b.HasOne("EshopApi.Data.Model.PurchaseOrderItems", null)
                        .WithMany("PurchaseOrderHeaders")
                        .HasForeignKey("PurchaseOrderItemsId");
                });

            modelBuilder.Entity("EshopApi.Data.Model.PurchaseOrderItems", b =>
                {
                    b.Navigation("PurchaseOrderHeaders");
                });
#pragma warning restore 612, 618
        }
    }
}

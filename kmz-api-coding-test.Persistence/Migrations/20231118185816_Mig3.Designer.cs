﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kmz_api_coding_test.Persistence.Contexts;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    [DbContext(typeof(ECommerceTestDbContext))]
    [Migration("20231118185816_Mig3")]
    partial class Mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InventoryProduct", b =>
                {
                    b.Property<int>("InventoriesInventoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("InventoriesInventoryId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("InventoryProduct");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"), 1L, 1);

                    b.Property<string>("FriendlyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesUnitID")
                        .HasColumnType("int");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitQuantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("SalesUnitID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.ProductPrice", b =>
                {
                    b.Property<int>("ProductPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductPriceId"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SalesUnitID")
                        .HasColumnType("int");

                    b.HasKey("ProductPriceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesUnitID");

                    b.ToTable("ProductPrices");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.SalesUnit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SalesUnits");
                });

            modelBuilder.Entity("InventoryProduct", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.Inventory", null)
                        .WithMany()
                        .HasForeignKey("InventoriesInventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kmz_api_coding_test.Core.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Inventory", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.SalesUnit", "SalesUnit")
                        .WithMany()
                        .HasForeignKey("SalesUnitID");

                    b.Navigation("SalesUnit");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Product", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.ProductPrice", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.Product", "Product")
                        .WithMany("Prices")
                        .HasForeignKey("ProductId");

                    b.HasOne("kmz_api_coding_test.Core.Entities.SalesUnit", "SalesUnit")
                        .WithMany()
                        .HasForeignKey("SalesUnitID");

                    b.Navigation("Product");

                    b.Navigation("SalesUnit");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Product", b =>
                {
                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}

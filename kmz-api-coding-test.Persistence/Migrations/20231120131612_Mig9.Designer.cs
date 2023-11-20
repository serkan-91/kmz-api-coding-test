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
    [Migration("20231120131612_Mig9")]
    partial class Mig9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FriendlyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesUnitID")
                        .HasColumnType("int");

                    b.Property<int>("UnitPerQuantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitQuantity")
                        .HasColumnType("int");

                    b.HasKey("SKU");

                    b.HasIndex("SalesUnitID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.InventoryProducts", b =>
                {
                    b.Property<int>("InventoryProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryProductsId"), 1L, 1);

                    b.Property<string>("InventorySKU")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SaleUnitAmount")
                        .HasColumnType("int");

                    b.Property<int>("UnitPerQuantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryProductsId");

                    b.HasIndex("InventorySKU");

                    b.HasIndex("ProductId");

                    b.ToTable("InventoryProducts");
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductAttributesProductAttributeId")
                        .HasColumnType("int");

                    b.Property<int>("RemainStock")
                        .HasColumnType("int");

                    b.Property<int?>("SalesUnitID")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductAttributesProductAttributeId");

                    b.HasIndex("SalesUnitID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.ProductAttribute", b =>
                {
                    b.Property<int>("ProductAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductAttributeId"), 1L, 1);

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductAttributeId");

                    b.ToTable("ProductAttributes");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.SalesUnit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SalesUnits");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Inventory", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.SalesUnit", "SalesUnit")
                        .WithMany()
                        .HasForeignKey("SalesUnitID");

                    b.Navigation("SalesUnit");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.InventoryProducts", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.Inventory", null)
                        .WithMany("InventoryProducts")
                        .HasForeignKey("InventorySKU");

                    b.HasOne("kmz_api_coding_test.Core.Entities.Product", null)
                        .WithMany("InventoryProducts")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Product", b =>
                {
                    b.HasOne("kmz_api_coding_test.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("kmz_api_coding_test.Core.Entities.ProductAttribute", "ProductAttributes")
                        .WithMany()
                        .HasForeignKey("ProductAttributesProductAttributeId");

                    b.HasOne("kmz_api_coding_test.Core.Entities.SalesUnit", "SalesUnit")
                        .WithMany()
                        .HasForeignKey("SalesUnitID");

                    b.Navigation("Category");

                    b.Navigation("ProductAttributes");

                    b.Navigation("SalesUnit");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Inventory", b =>
                {
                    b.Navigation("InventoryProducts");
                });

            modelBuilder.Entity("kmz_api_coding_test.Core.Entities.Product", b =>
                {
                    b.Navigation("InventoryProducts");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhatToBuyAPI.Data;

namespace WhatToBuyAPI.Migrations
{
    [DbContext(typeof(WhatToBuyAPIContext))]
    partial class WhatToBuyAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WhatToBuyAPI.Models.Product", b =>
                {
                    b.Property<Guid>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductTypeID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductItem", b =>
                {
                    b.Property<Guid>("ProductItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Number")
                        .HasColumnType("float");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductItemId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductListId");

                    b.ToTable("ProductItem");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductList", b =>
                {
                    b.Property<Guid>("ProductListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateBuy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ProductListId");

                    b.ToTable("ProductList");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductType", b =>
                {
                    b.Property<Guid>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductTypeId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductTypeId");

                    b.HasIndex("ProductTypeId1");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.Product", b =>
                {
                    b.HasOne("WhatToBuyAPI.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductItem", b =>
                {
                    b.HasOne("WhatToBuyAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WhatToBuyAPI.Models.ProductList", null)
                        .WithMany("ProductItems")
                        .HasForeignKey("ProductListId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductType", b =>
                {
                    b.HasOne("WhatToBuyAPI.Models.ProductType", null)
                        .WithMany("ProductTypes")
                        .HasForeignKey("ProductTypeId1");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductList", b =>
                {
                    b.Navigation("ProductItems");
                });

            modelBuilder.Entity("WhatToBuyAPI.Models.ProductType", b =>
                {
                    b.Navigation("ProductTypes");
                });
#pragma warning restore 612, 618
        }
    }
}

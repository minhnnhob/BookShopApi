﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1670_API.Data;

#nullable disable

namespace _1670_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230519025244_DatabaseVer5")]
    partial class DatabaseVer5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_1670_API.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AuthorName")
                        .HasColumnType("float");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("DateAdded")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("thumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("_1670_API.Models.BookStore", b =>
                {
                    b.Property<int>("StoreID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("StoreID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("BookStores");
                });

            modelBuilder.Entity("_1670_API.Models.CartItem", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("UserID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("_1670_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("_1670_API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("storeID")
                        .HasColumnType("int");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("storeID");

                    b.HasIndex("userID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("_1670_API.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("_1670_API.Models.Store", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("userID")
                        .IsUnique()
                        .HasFilter("[userID] IS NOT NULL");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("_1670_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_1670_API.Models.Book", b =>
                {
                    b.HasOne("_1670_API.Models.Category", "category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("_1670_API.Models.BookStore", b =>
                {
                    b.HasOne("_1670_API.Models.Book", "book")
                        .WithMany("bookStores")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1670_API.Models.Store", "store")
                        .WithMany()
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("store");
                });

            modelBuilder.Entity("_1670_API.Models.CartItem", b =>
                {
                    b.HasOne("_1670_API.Models.Book", "book")
                        .WithMany("cartItems")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1670_API.Models.User", "user")
                        .WithMany("cartItems")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1670_API.Models.Order", b =>
                {
                    b.HasOne("_1670_API.Models.Store", "store")
                        .WithMany("orders")
                        .HasForeignKey("storeID");

                    b.HasOne("_1670_API.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("userID");

                    b.Navigation("store");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1670_API.Models.OrderItem", b =>
                {
                    b.HasOne("_1670_API.Models.Book", "book")
                        .WithMany("orderItems")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1670_API.Models.Order", "order")
                        .WithMany("orderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("order");
                });

            modelBuilder.Entity("_1670_API.Models.Store", b =>
                {
                    b.HasOne("_1670_API.Models.User", "user")
                        .WithOne("store")
                        .HasForeignKey("_1670_API.Models.Store", "userID");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1670_API.Models.Book", b =>
                {
                    b.Navigation("bookStores");

                    b.Navigation("cartItems");

                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("_1670_API.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("_1670_API.Models.Order", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("_1670_API.Models.Store", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("_1670_API.Models.User", b =>
                {
                    b.Navigation("cartItems");

                    b.Navigation("orders");

                    b.Navigation("store")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

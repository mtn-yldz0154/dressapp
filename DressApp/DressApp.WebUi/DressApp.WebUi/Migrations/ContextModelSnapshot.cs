﻿// <auto-generated />
using System;
using DressApp.WebUi.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DressApp.WebUi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("AdminRole")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("AdminUserName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Favori", b =>
                {
                    b.Property<int>("FavoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FavoriImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FavoriPrice")
                        .HasColumnType("float");

                    b.Property<int>("UrunSayisi")
                        .HasColumnType("int");

                    b.HasKey("FavoriId");

                    b.ToTable("Favoris");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.LikeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LikeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LikeId");

                    b.HasIndex("ProductId");

                    b.ToTable("LikeItems");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConversationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FavoriAppovred")
                        .HasColumnType("bit");

                    b.Property<bool>("HomeIsAppovred")
                        .HasColumnType("bit");

                    b.Property<string>("Kreaksiyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ozellik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.Property<int>("RayonId")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<bool>("SepetAppovred")
                        .HasColumnType("bit");

                    b.Property<string>("SmallImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarNumber")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("RayonId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.ProductUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductUsers");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.ProductUserItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("FavoriAppovred")
                        .HasColumnType("bit");

                    b.Property<bool>("LikeApovred")
                        .HasColumnType("bit");

                    b.Property<string>("LongProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.Property<int?>("ProductUserId")
                        .HasColumnType("int");

                    b.Property<int>("RayonId")
                        .HasColumnType("int");

                    b.Property<bool>("SepetAppovred")
                        .HasColumnType("bit");

                    b.Property<string>("SmallImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductUserId");

                    b.HasIndex("RayonId");

                    b.ToTable("ProductUserItems");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Rayon", b =>
                {
                    b.Property<int>("RayonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RayonDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RayonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("RayonId");

                    b.ToTable("Rayons");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Sepet", b =>
                {
                    b.Property<int>("SepetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SepetImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SepetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sepetprice")
                        .HasColumnType("float");

                    b.Property<int>("UrunSayisi")
                        .HasColumnType("int");

                    b.HasKey("SepetId");

                    b.ToTable("Sepets");
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.CartItem", b =>
                {
                    b.HasOne("DressApp.WebUi.Data.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DressApp.WebUi.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.LikeItem", b =>
                {
                    b.HasOne("DressApp.WebUi.Data.Models.Like", "Like")
                        .WithMany("LikeItems")
                        .HasForeignKey("LikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DressApp.WebUi.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.OrderItem", b =>
                {
                    b.HasOne("DressApp.WebUi.Data.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DressApp.WebUi.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.Product", b =>
                {
                    b.HasOne("DressApp.WebUi.Data.Models.Rayon", "Rayon")
                        .WithMany("Products")
                        .HasForeignKey("RayonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DressApp.WebUi.Data.Models.ProductUserItem", b =>
                {
                    b.HasOne("DressApp.WebUi.Data.Models.ProductUser", null)
                        .WithMany("productUserItems")
                        .HasForeignKey("ProductUserId");

                    b.HasOne("DressApp.WebUi.Data.Models.Rayon", "Rayon")
                        .WithMany()
                        .HasForeignKey("RayonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
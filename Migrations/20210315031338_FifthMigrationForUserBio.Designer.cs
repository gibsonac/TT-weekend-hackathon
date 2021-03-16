﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tenant_turner.Models;

namespace tenant_turner.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210315031338_FifthMigrationForUserBio")]
    partial class FifthMigrationForUserBio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("tenant_turner.Models.Picture", b =>
                {
                    b.Property<int>("Pictureid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Rentalid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("TEXT");

                    b.HasKey("Pictureid");

                    b.HasIndex("Rentalid");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("tenant_turner.Models.Rental", b =>
                {
                    b.Property<int>("Rentalid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasColumnType("TEXT");

                    b.Property<double>("Bathrooms")
                        .HasColumnName("bathrooms")
                        .HasColumnType("DOUBLE(8,2)");

                    b.Property<sbyte>("Bedrooms")
                        .HasColumnName("bedrooms")
                        .HasColumnType("TINYINT");

                    b.Property<DateTime>("Created_At")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Deposit")
                        .HasColumnName("deposit")
                        .HasColumnType("INT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Pets")
                        .HasColumnName("pets")
                        .HasColumnType("BOOLEAN");

                    b.Property<string>("Restrictions")
                        .HasColumnName("restrictions")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sqft")
                        .HasColumnName("sqft")
                        .HasColumnType("INT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Userid")
                        .HasColumnType("int");

                    b.HasKey("Rentalid");

                    b.HasIndex("Userid");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("tenant_turner.Models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<sbyte>("Admin_Lvl")
                        .HasColumnName("admin_lvl")
                        .HasColumnType("TINYINT");

                    b.Property<DateTime>("Created_At")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Staff_bio")
                        .HasColumnName("staff_bio")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Staff_pic")
                        .HasColumnName("staff_pic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("tenant_turner.Models.Picture", b =>
                {
                    b.HasOne("tenant_turner.Models.Rental", "RelatedHome")
                        .WithMany("Pictures")
                        .HasForeignKey("Rentalid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tenant_turner.Models.Rental", b =>
                {
                    b.HasOne("tenant_turner.Models.User", "Property_Manager")
                        .WithMany("Managed_Rentals")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

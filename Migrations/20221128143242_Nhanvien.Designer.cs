﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Nhom02.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20221128143242_Nhanvien")]
    partial class Nhanvien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Nhom02.Models.Nhacungcap", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("SdtNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNCC")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNCC");

                    b.ToTable("Nhacungcap");
                });

            modelBuilder.Entity("Nhom02.Models.Nhanvien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNV")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaysinhNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("SdtNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("Nhom02.Models.Sanpham", b =>
                {
                    b.Property<string>("MaSP")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GiaSP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .HasColumnType("TEXT");

                    b.HasKey("MaSP");

                    b.ToTable("Sanpham");
                });
#pragma warning restore 612, 618
        }
    }
}

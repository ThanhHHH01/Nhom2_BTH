using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nhom02.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<Nhom02.Models.Nhacungcap> Nhacungcap { get; set; } = default!;

        public DbSet<Nhom02.Models.Sanpham> Sanpham { get; set; } = default!;

        public DbSet<Nhom02.Models.Nhanvien> Nhanvien { get; set; } = default!;

        public DbSet<Nhom02.Models.Nhaphang> Nhaphang { get; set; } = default!;

        public DbSet<Nhom02.Models.Khachhang> Khachhang { get; set; } = default!;

        public DbSet<Nhom02.Models.Hoadon> Hoadon { get; set; } = default!;
    }

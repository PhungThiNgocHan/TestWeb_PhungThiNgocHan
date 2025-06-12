using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_PhungThiNgocHan.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Seed dữ liệu 6 phim mẫu
                modelBuilder.Entity<Book>().HasData(
                    new Book { Id = 0001, Title = "Lập trình Web PHP & MySQL", Price = 210000, Quantity = 12 },
                    new Book { Id = 0002, Title = "Cấu trúc dữ liệu và giải thuật", Price = 95000, Quantity = 5 },
                    new Book { Id = 0003, Title = "Kỹ thuật lập trình", Price = 70000, Quantity = 10 },
                    new Book { Id = 0004, Title = "Lập trình Java core", Price = 140000, Quantity = 15 },
                    new Book { Id = 1, Title = "Cơ sở dữ liệu", Price = 60000, Quantity = 7 }

                );
            }
        }
    }

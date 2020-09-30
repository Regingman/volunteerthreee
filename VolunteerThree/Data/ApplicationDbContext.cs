using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VolunteerThree.Models;

namespace VolunteerThree.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Zon> Zons { get; set; }
        public DbSet<Reg> Regs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reg>().HasData(
            new { Id = 1, RName = "Баткен" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 1, ZName = "Баткен", RegId = 1 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 2, ZName = "Кадамжай", RegId = 1 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 3, ZName = "Лейлек", RegId = 1 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 4, ZName = "г.Баткен", RegId = 1 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 5, ZName = "г.Кызыл-Кыя", RegId = 1 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 6, ZName = "г. Сулюкта", RegId = 1 });

            modelBuilder.Entity<Reg>().HasData(
            new { Id = 2, RName = "Жалал-Абад" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 7, ZName = "Аксы", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 8, ZName = "Ала-Бука", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 9, ZName = "Базар-Коргон", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 10, ZName = "Ноокен", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 11, ZName = "Сузак", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 12, ZName = "Тогуз-Торо", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 13, ZName = "Токтогул", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 14, ZName = "Чаткал", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 15, ZName = "г.Жалал-Абад", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 16, ZName = "г.Кара-Куль", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 17, ZName = "г.Майлуу-Суу", RegId = 2 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 18, ZName = "г.Таш-Кумыр", RegId = 2 });

            modelBuilder.Entity<Reg>().HasData(
            new { Id = 3, RName = "Иссык-Куль" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 19, ZName = "Ак-Суу", RegId = 3 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 20, ZName = "Джети-Огуз", RegId = 3 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 21, ZName = "Иссык-Куль", RegId = 3 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 22, ZName = "Тон", RegId = 3 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 23, ZName = "Тюп", RegId = 3 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 24, ZName = "г.Балыкчы", RegId = 3 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 25, ZName = "г.Каракол", RegId = 3 });

            modelBuilder.Entity<Reg>().HasData(
            new { Id = 4, RName = "Нарын" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 26, ZName = "Ак-Талаа", RegId = 4 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 27, ZName = "Ат-Башы", RegId = 4 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 28, ZName = "Жумгал", RegId = 4 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 29, ZName = "Кочкор", RegId = 4 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 30, ZName = "Нарын", RegId = 4 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 31, ZName = "г.Нарын", RegId = 4 });


            modelBuilder.Entity<Reg>().HasData(
            new { Id = 5, RName = "Ош" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 32, ZName = "Алай", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 33, ZName = "Араван", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 34, ZName = "Кара-Кулжа", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 35, ZName = "Кара-Суу", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 36, ZName = "Ноокат ", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 37, ZName = "Өзгөн ", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 38, ZName = "Чон-Алай", RegId = 5 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 39, ZName = "г.Ош ", RegId = 5 });

            modelBuilder.Entity<Reg>().HasData(
            new { Id = 6, RName = "Талас" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 40, ZName = "Бакай-Ата", RegId = 6 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 41, ZName = "Кара-Буура", RegId = 6 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 42, ZName = "Манас ", RegId = 6 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 43, ZName = "Талас ", RegId = 6 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 44, ZName = "г.Талас ", RegId = 6 });

            modelBuilder.Entity<Reg>().HasData(
            new { Id = 7, RName = "Чуй" });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 45, ZName = "Аламудун", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 46, ZName = "Жайыл ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 47, ZName = "Кемин  ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 48, ZName = "Москва  ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 49, ZName = "Панфилов  ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 50, ZName = "Сокулук ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 51, ZName = "Чуй ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 52, ZName = "Ысык-Ата  ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 53, ZName = "Токмок  ", RegId = 7 });
            modelBuilder.Entity<Zon>().HasData(
            new { Id = 54, ZName = "г.Бишкек  ", RegId = 7 });
        }
    }
   
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab4_zad2.Components.Baza_danych;

namespace Lab4_zad2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Lab4_zad2.Components.Baza_danych.Game> Game { get; set; } = default!;
    }
}

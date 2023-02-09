using EF_HW1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_HW1.Context;

public class LibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-8V8B7U4\\MSSQLSERVER01;Initial Catalog=LibraryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        base.OnConfiguring(optionsBuilder); 
    }


    public DbSet<Student> Students { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Author> Authors { get; set; }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _1670_NhatMinh_Source.Models;

namespace _1670_NhatMinh_Source.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<_1670_NhatMinh_Source.Models.Book> Book { get; set; } = default!;
        public DbSet<_1670_NhatMinh_Source.Models.Category> Category { get; set; } = default!;
        public DbSet<_1670_NhatMinh_Source.Models.Comment> Comment { get; set; } = default!;
        public DbSet<_1670_NhatMinh_Source.Models.ApplicationRole> ApplicationRole { get; set; } = default!;
    }
}
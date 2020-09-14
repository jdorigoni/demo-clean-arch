using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Data.Context
{
    public class UniversityDBContext : IdentityDbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {            
        }

        public DbSet<Course> Courses { get; set; }
    }
}

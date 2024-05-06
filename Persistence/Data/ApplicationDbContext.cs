using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> students { get; set; }
        public DbSet<SubjectModel> subjects { get; set; }
    }
}

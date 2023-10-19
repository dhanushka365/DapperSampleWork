using DapperSampleWork.Models;
using Microsoft.EntityFrameworkCore;

namespace DapperSampleWork.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Company> Companies { get; set; }

    }
}

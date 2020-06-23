using Microsoft.EntityFrameworkCore;
using BlazorApp.Data.Entities;

namespace BlazorApp.Data
{
    public class BlazorDbContext : DbContext
    {
        public BlazorDbContext(DbContextOptions<BlazorDbContext> options) : base(options)
        {
        }

        public DbSet<MessageItem> Messages { get; set; }
    }
}

using System;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public static class BlazorDbContextOptions
    {
        public static DbContextOptionsBuilder<BlazorDbContext> GetOptions(DbContextOptionsBuilder<BlazorDbContext> builder)
        {
            builder.UseSqlServer(Environment.GetEnvironmentVariable("SQLAZURECONNSTR_DefaultConnection"));

            return builder;
        }
    }
}

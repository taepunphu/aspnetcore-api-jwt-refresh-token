using aspnetcore_api_jwt_refresh_token.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_api_jwt_refresh_token.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {} 

        public DbSet<User> Users {get; set;}
    }
}
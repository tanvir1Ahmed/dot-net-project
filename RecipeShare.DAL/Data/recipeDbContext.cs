using Microsoft.EntityFrameworkCore;
using RecipeShare.Api.Models.Domain;

namespace RecipeShare.Api.Data
{
    public class recipeDbContext:DbContext
    {
        public recipeDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<User> users { get; set; }
    }
}

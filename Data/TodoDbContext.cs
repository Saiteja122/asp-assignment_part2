using Microsoft.EntityFrameworkCore;
using todoApp.Models;

namespace todoApp.Data
{
    //todoApp
    public class TodoDbContext : DbContext
    {
        public TodoDbContext (DbContextOptions<TodoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; }
    }
    
}
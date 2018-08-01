using System.Data.Entity;

namespace TodoNet.Models
{
    // @todo реализовать database seeds
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
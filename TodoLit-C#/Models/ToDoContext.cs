using Microsoft.EntityFrameworkCore;

namespace TodoLit_C_.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Status> Statuses { get; set; } = null!;


        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { categoryId = "work", Name = "Work" },
                new Category { categoryId = "home", Name = "Home" },
                new Category { categoryId = "ex", Name = "Exercise" },
                new Category { categoryId = "shop", Name = "Shopping" },
                new Category { categoryId = "call", Name = "Contact" }
                );

            modelBuilder.Entity<Status>().HasData(
              new Status { StatusId = "open", Name = "Open" },
              new Status { StatusId = "closed", Name = "Completed" }
              
              );
        }


    }
}

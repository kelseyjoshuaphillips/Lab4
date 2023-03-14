using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class NewsDbContext :DbContext
    {
        //constructor
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options){}
        //dbset
        public DbSet<NewsBoard> NewsBoards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsBoard>().ToTable("Newsboard");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Subscription>().HasKey(c => new { c.NewsBoardId, c.ClientId });       
        }
    }
}

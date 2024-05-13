using Microsoft.EntityFrameworkCore;
using Newsletter.Consumer.Models;
using RabbitMQ.Client;

namespace Newsletter.Consumer.Context;
internal sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseInMemoryDatabase("MyDb");
        optionsBuilder.UseSqlServer("Data Source=ETUBAS;Initial Catalog=NewsletterDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Blog> Blogs { get; set; }
}

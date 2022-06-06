using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ComicConApi.Models
{
    public class ComicConContext : DbContext
    {
        public ComicConContext(DbContextOptions<ComicConContext> options)
            : base(options)
        {
        }
        public DbSet<ComicConTicket> ComicConTicket { get; set; } = null!;
    }
}

using Microsoft.EntityFrameworkCore;
using PokemonCardsAPI.Models;

namespace PokemonCardsAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> Types { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Collection> Collections { get; set; }
    }
}
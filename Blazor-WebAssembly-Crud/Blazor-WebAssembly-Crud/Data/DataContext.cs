using Blazor_WebAssembly_Crud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blazor_WebAssembly_Crud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "Cyberpunk 2077", Publisher = "Cd Projekt", ReleaseYear = 2020 },
                new VideoGame { Id = 2, Title = "Lol", Publisher = "From Software ", ReleaseYear = 2019 },
                new VideoGame { Id = 3, Title = "Cs Go 2", Publisher = "Nintendo", ReleaseYear = 2023 }
            );
        }

        public DbSet<VideoGame> VideoGames { get; set; }
    }
}

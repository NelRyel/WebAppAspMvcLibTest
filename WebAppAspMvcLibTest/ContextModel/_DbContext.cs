using Microsoft.EntityFrameworkCore;
using WebAppAspMvcLibTest.entModels.GenresModel;

namespace WebAppAspMvcLibTest.ContextModel
{
    public class _DbContext : DbContext
    {

        public DbSet<GeneralGenre> Genres { get; set; } = null!;
        public DbSet<GameGenre> GamesGenres { get; set; } = null!;
        public DbSet<Movie_Series_Anime_Genre> MoviesGenres { get; set; } = null!;

        public _DbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mvcapplib.db");
        }



    }
}

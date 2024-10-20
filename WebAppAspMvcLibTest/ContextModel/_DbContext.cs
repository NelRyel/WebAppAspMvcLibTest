using Microsoft.EntityFrameworkCore;
using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;
using WebAppAspMvcLibTest.entModels.Humans;
using WebAppAspMvcLibTest.entModels.Products;


namespace WebAppAspMvcLibTest.ContextModel
{
    public class _DbContext : DbContext
    {

        public DbSet<GeneralGenre> GeneralGenres { get; set; } = null!;
        public DbSet<GameGenre> GamesGenres { get; set; } = null!;
        public DbSet<Movie_Series_Anime_Genre> MoviesGenres { get; set; } = null!;

        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Developer> Developers { get; set; } = null!;
        public DbSet<Distributer> Distributers { get; set; } = null!;
        public DbSet<Production> Productions { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Studio_Movie_Series_Animated> Studios { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Director> Directors { get; set; } = null!;
        public DbSet<Human> Humans { get; set; } = null!;
        public DbSet<Producer> Producers { get; set; } = null!;

        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Serial> Serials { get; set; } = null!;







        public _DbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mvcapplib.db");
        }



    }
}

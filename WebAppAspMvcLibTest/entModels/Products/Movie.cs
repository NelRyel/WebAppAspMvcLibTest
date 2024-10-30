using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;
using WebAppAspMvcLibTest.entModels.Humans;

namespace WebAppAspMvcLibTest.entModels.Products
{
    public class Movie : Product
    {
        public List<Director>? Directors { get; set; }
        public List<Producer>? Producers { get; set; }
        public List<Actor>? Actors { get; set; }
        public List<Production>? Productions { get; set; } = new();
        public List<Distributer>? Distributors { get; set; } = new();
        public List<Movie_Series_Anime_Genre>? Genres { get; set; } = new();
        public int? RunnigTime { get; set; }


    }
}

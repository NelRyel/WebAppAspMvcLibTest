using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;
using WebAppAspMvcLibTest.entModels.Humans;

namespace WebAppAspMvcLibTest.entModels.Products
{ 

    public class Series : Product
    {
    public List<Director>? Directors { get; set; }
    public List<Producer>? Producers { get; set; }
    public List<Actor>? Actors { get; set; }
    public List<Production>? Productions { get; set; }
    public List<Distributer>? Distributors { get; set; }
    public List<Movie_Series_Anime_Genre>? Genres { get; set; }
    public int RunnigTime { get; set; }

    }

}


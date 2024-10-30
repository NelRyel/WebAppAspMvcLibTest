using WebAppAspMvcLibTest.entModels.Products;

namespace WebAppAspMvcLibTest.entModels.GenresModel
{
    public class Movie_Series_Anime_Genre : GeneralGenre
    {
        public List<Movie> Movies { get; set; } = new();
        public List<Serial> Serials { get; set; } = new();
    }
}

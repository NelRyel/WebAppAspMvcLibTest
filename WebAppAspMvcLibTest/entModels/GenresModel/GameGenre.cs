using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;
using WebAppAspMvcLibTest.entModels.Humans;
using WebAppAspMvcLibTest.entModels.Products;

namespace WebAppAspMvcLibTest.entModels.GenresModel
{
    public class GameGenre : GeneralGenre
    {
        public List<Game>? Games { get; set; } = new();
    }
}

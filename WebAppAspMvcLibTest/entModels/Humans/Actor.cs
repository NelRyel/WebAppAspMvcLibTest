using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;
using WebAppAspMvcLibTest.entModels.Humans;
using WebAppAspMvcLibTest.entModels.Products;

namespace WebAppAspMvcLibTest.entModels.Humans
{
    public class Actor : Human
    {
        public List<Movie> Movies { get; set; }
        public List<Serial> Serials { get; set; }

    }
}

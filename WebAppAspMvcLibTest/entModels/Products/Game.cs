using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;

namespace WebAppAspMvcLibTest.entModels.Products
{
    public class Game : Product
    {
        public int? PublisherId { get; set; }
        public Publisher? Publisher { get; set; }

        public int? DeveloperId { get; set; }
        public Developer? Developer { get; set; }

        public List<GameGenre> Genres { get; set; }

    }
}

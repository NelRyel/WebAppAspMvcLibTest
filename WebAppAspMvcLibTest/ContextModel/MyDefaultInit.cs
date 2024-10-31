using WebAppAspMvcLibTest.entModels.GenresModel;

namespace WebAppAspMvcLibTest.ContextModel
{
    public class MyDefaultInit
    {
        public void CreateGenres()
        {
            string path = "C:\\sharpProjects\\asp\\WebAppAspMvcLibTest\\WebAppAspMvcLibTest\\genres.txt";

            List<string> gnames = new List<string>();
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    gnames.Add(line);
                    //Console.WriteLine(line);
                }
            }
            using (_DbContext db = new _DbContext())
            {
                foreach (string gname in gnames) 
                { 
                    GameGenre gameGenre = new GameGenre();
                    gameGenre.Name = gname;
                    db.GamesGenres.Add(gameGenre);
                
                }
                db.SaveChanges();
            }
        }
        
        public void CreateMovieGenres()
        {
            string path = "C:\\sharpProjects\\asp\\WebAppAspMvcLibTest\\WebAppAspMvcLibTest\\moviegnrs.txt";
            List<string> gnames = new List<string>();
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    gnames.Add(line);
                    //Console.WriteLine(line);
                }
            }
            using (_DbContext db = new _DbContext())
            {
                foreach (string gname in gnames)
                {
                    Movie_Series_Anime_Genre gnrs = new Movie_Series_Anime_Genre();
                    gnrs.Name = gname;
                    db.MoviesGenres.Add(gnrs);

                }
                db.SaveChanges();
            }
        }

    }
}

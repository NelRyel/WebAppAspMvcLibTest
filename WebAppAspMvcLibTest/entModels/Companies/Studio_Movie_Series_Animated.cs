﻿using WebAppAspMvcLibTest.entModels.Products;

namespace WebAppAspMvcLibTest.entModels.Companies
{
    public class Studio_Movie_Series_Animated : Company
    {
        public List<Movie> Movies { get; set; }
        public List<Serial> Serials { get; set; }
    }
}

﻿using WebAppAspMvcLibTest.entModels.Products;

namespace WebAppAspMvcLibTest.entModels.Companies
{
    public class Production : Company
    {
        public List<Movie> Movies { get; set; }
        public List<Serial> Serials { get; set; }
    }
}

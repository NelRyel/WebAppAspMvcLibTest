﻿using System.ComponentModel.DataAnnotations.Schema;
using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.GenresModel;
using WebAppAspMvcLibTest.entModels.Humans;
using WebAppAspMvcLibTest.entModels.Products;

namespace WebAppAspMvcLibTest.entModels.Humans
{
    //[Table("Actors")]
    public class Actor : Human
    {
        public List<Movie> Movies { get; set; } = new();
        public List<Serial> Serials { get; set; } = new();

    }
}

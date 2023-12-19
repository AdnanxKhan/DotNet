using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyApp.Models
{
    public class Movie
    {
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }


    }
}
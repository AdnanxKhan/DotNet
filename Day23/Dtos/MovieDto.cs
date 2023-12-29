using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NewApp.Dtos
{
    public class MovieDto
    {
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Movie Name is Required.")]

        public string MovieName { get; set; }
        [Required(ErrorMessage = "Genre is Required.")]

        public string Genre { get; set; }
        [Required(ErrorMessage = "Release Date is Required.")]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Date Added on is Required.")]

        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Number in Stock is Required.")]

        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}
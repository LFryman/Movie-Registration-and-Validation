using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistrationAndValidation.Models
{
    public class Movie
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public int Year { get; set; }
        [Required]
        public List<string> Actors { get; set; }
        [Required]
        public List<string> Directors { get; set; }
    }
    public enum Genre
    {
        Scifi,
        Romance,
        Fantacy,
        Action,
        Drama,
        Mystery,
        Horror
    }
}

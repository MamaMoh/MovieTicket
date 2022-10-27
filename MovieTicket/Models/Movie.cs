using MovieTicket.Data;
using MovieTicket.Data.@enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "ImageURL")]
        public string ImageURL { get; set; }
        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }
        [Display(Name = "MovieCategory")]
        public MovieCategory MovieCategory { get; set; }

        //relationship
        public List<Actor_Movie> Actor_Movies { get; set; }

        // cinema
        public int CinemaId { get; set; }
        
        public Cinema Cinema { get; set; }

        // producer
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}

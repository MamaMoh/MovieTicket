using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="Profile is required")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="FullName must be between 3 and 50 char")]
        public string? FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}

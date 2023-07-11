using System.ComponentModel.DataAnnotations;

namespace BlazorDemoProject.Pages.Demos.Demo6.Models
{
    public class Game
    {
        [Required]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Note { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }


    }
}

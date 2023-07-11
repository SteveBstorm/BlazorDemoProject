using System.ComponentModel.DataAnnotations;

namespace BlazorDemoProject.Pages.Exercices.Exo2.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        public string Label { get; set; }
        public DateTime Date { get; set; }
        [Range(0, 60)]
        public int Duration { get; set; }
        public bool IsFinished { get; set; } = false;
    }
}

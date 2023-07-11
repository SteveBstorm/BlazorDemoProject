using BlazorDemoProject.Pages.Exercices.Exo2.Models;
using Microsoft.AspNetCore.Components;
using System.Data;

namespace BlazorDemoProject.Pages.Exercices.Exo2
{
    public partial class TodoDetail
    {
        [Parameter]
        public Todo CurrentTask{ get; set; }

        
    }
}

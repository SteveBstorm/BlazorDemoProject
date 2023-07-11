using BlazorDemoProject.Pages.Demos.Demo6.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemoProject.Pages.Demos.Demo6
{
    public partial class Demo6
    {
        /*
        Pour la création d'un formulaire, une propriété du type contenant les Attributs de validations
        est requise, et instancié au plus tard dans le constructeur. 
        Un constructeur sans paramètres est requis pour cette classe (pour un formulaire de création)
        Dans le cas d'un formulaire d'update, l'objet peut être construit avec ses valeurs
        */
        public Game NewGame { get; set; }

        private List<string> _genre { get; set; }
        public Demo6()
        {
            NewGame = new Game();
            _genre = new List<string>() { "Hack'n Slash", "RPG", "MMORPG", "RTS" };
        }
         
        public void ValidateForm()
        {
            Console.WriteLine(NewGame.Genre);
        }
    }
}

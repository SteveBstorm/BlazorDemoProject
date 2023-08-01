using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemoProject.Pages.Demos.Demo7
{
    public partial class Demo7
    {
        [Inject]
        public IJSRuntime jsRuntime { get; set; }
        private IJSObjectReference jsModule;

        //Pour l'injection de dépendance, prévoir une propriété pour accueillir l'instance

        public int MyValue { get; set; }

        private async Task ShowValue()
        {
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "myKey", MyValue);
        }

        //Pour utiliser du code JS stocké dans un script "global" à l'application
        /*Importer son contenu dans un container de type IJSObjectReference lors de l'initialisation du composant,
            ce qui correspond à créer un module JS (si plusieurs fichier JS, plusieurs objets nécéssaire)

        */
        protected override async Task OnInitializedAsync()
        {
            jsModule = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./script/myScript.js");
        }

        //Une fois l'import fait, Invoke le contenu du module comme s'il s'agissait de IJSRuntime
        //Une méthode DisposeAsync() existe... 
        private async Task TestCallFunction()
        {
            await jsModule.InvokeVoidAsync("myFunction");
        }

    }
}

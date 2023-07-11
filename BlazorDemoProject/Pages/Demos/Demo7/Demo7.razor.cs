using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemoProject.Pages.Demos.Demo7
{
    public partial class Demo7
    {
        [Inject]
        public IJSRuntime jsRuntime { get; set; }

        //Pour l'injection de dépendance, prévoir une propriété pour accueillir l'instance

        public int MyValue { get; set; }

        private async Task ShowValue()
        {
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "myKey", MyValue);
        }
    }
}

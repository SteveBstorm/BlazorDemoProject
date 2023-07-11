using BlazorDemoProject.Pages.Exercices.Exo2.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemoProject.Pages.Exercices.Exo2
{
    public partial class TodoAdd
    {
        public Todo NewTodo { get; set; }

        public TodoAdd()
        {
            NewTodo = new Todo();
        }

        [Parameter]
        public EventCallback<Todo> SaveNewTodo { get; set; }

        public async Task OnValidSubmit()
        {
            await SaveNewTodo.InvokeAsync(NewTodo);
            NewTodo = new Todo();
        }
    }
}

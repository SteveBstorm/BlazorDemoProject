using BlazorDemoProject.Pages.Exercices.Exo2.Models;
using System.Collections.ObjectModel;

namespace BlazorDemoProject.Pages.Exercices.Exo2
{
    public partial class TodoList
    {
        public List<Todo> Todos { get; set; }
        private int counter = 0;

        public Todo SelectedTask { get; set; }

        protected override void OnInitialized()
        {
            Todos = new List<Todo>();
        }
        

        public void Add(Todo t)
        {
            Console.WriteLine(t.Label);
            t.Id = ++counter;
            Todos.Add(t);
        }

        private void SelectTask(Todo selected)
        {
            SelectedTask = selected;
        }

        private void FinishTask(int id)
        {
            int index = Todos.FindIndex(x => x.Id == id);
            Todos[index].IsFinished = true;
        }


    }
}

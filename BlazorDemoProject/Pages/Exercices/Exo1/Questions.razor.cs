using Microsoft.AspNetCore.Components;

namespace BlazorDemoProject.Pages.Exercices.Exo1
{
    public partial class Questions
    {
        [Parameter]
        public string Username { get; set; }

        public List<string> QuestionList { get; set; }

        public int Counter { get; set; }
        public string CurrentQuestion { get; set; }

        [Parameter]
        public EventCallback<string> NotifyAnswer{ get; set; }

        [Parameter]
        public EventCallback NotifyEndGame { get; set; }

        public Questions()
        {
            QuestionList = new List<string>();
            QuestionList.Add("Aimez-vous Blazor ?");
            QuestionList.Add("Pas trop mal à la tête ?");
            QuestionList.Add("On continue ?");

            Counter = 0;
            CurrentQuestion = QuestionList[Counter];
            Counter++;
        }

        public void Answer(string rep)
        {
            

            NotifyAnswer.InvokeAsync(rep);
            if (Counter >= QuestionList.Count)
            {
                CurrentQuestion = "";
                NotifyEndGame.InvokeAsync(true);
            }
            else
            {
                CurrentQuestion = QuestionList[Counter];
            }
            Counter++;

        }
    }
}

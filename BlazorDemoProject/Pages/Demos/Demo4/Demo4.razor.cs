using Microsoft.AspNetCore.Components;

namespace BlazorDemoProject.Pages.Demos.Demo4
{
    public partial class Demo4
    {
        public List<Item> ItemList { get; set; }
        private int counter = 0;
        public Demo4()
        {
            ItemList = new List<Item>();
            for(int i = 0; i < 50; i++)
            {
                ItemList.Add(new Item
                {
                    Id = ++counter,
                    Content = Guid.NewGuid().ToString(),
                });
            }
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}

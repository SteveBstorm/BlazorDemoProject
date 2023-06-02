namespace BlazorDemoProject.Pages.Demos.Demo2
{
    public partial class Demo2
    {
        public int MyValue { get; set; }
        public int ValueToRemove { get; set; }

        public void Add()
        {
            MyValue++;
        }

        public void Remove(int value)
        {
            MyValue -= value;
        }
    }
}

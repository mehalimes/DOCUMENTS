namespace Week2.Classes
{
    public class Person
    {
        public string Name { get; set; }
        protected byte Age { get; set; }
        public Person(string Name, byte Age)
        {
            this.Name = Name;
            this.Age = Age;
            Console.WriteLine("Person constructor has been called.");
        }
        public Person() 
        {
            Console.WriteLine("Person parameterless constructor has been called.");
        }
        public void ShowInformation()
        {
            Console.WriteLine($"INFO {this.Name} {this.Age}");
        }
    }
}

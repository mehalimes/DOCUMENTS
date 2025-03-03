namespace Week2.Classes
{
    public class Student : Person
    {
        public string StudentNumber { get; set; }

        public Student() : base()
        {
            this.StudentNumber = "100";
            Console.WriteLine("Student parameterless constructor has been called.");
        }

        public Student(string Name, byte Age, string StudentNumber) : base(Name, Age)
        {
            this.StudentNumber = StudentNumber;
            Console.WriteLine("Student constructor has been called.");
        }

        public void ShowStudentInformation()
        {
            Console.WriteLine($"INFO {this.Name} {this.Age} {this.StudentNumber}");
        }
    }
}

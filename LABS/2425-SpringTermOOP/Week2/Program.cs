using Week2.Classes;

namespace Week2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", 15, "23390008003");
            Student s2 = new Student();

            s1.ShowInformation();
            s1.ShowStudentInformation();

            s2.ShowInformation();
            s2.ShowStudentInformation();
        }
    }
}

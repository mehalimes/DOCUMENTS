using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class Program
    {
        static Dictionary<string, string> phoneDirectory = new Dictionary<string, string>();
        static void addPerson()
        {
            Console.Clear();

            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Phone Number : ");
            string phoneNumber = Console.ReadLine();

            phoneDirectory[name] = phoneNumber;

            Console.WriteLine("Person added successfully.");
            Console.ReadLine();
            drawMenu();

        }
        static void deletePerson()
        {
            Console.Clear();

            Console.Write("Enter name : ");

            string name = Console.ReadLine();
            phoneDirectory.Remove(name);

            Console.WriteLine("Person deleted successfully.");
            Console.ReadLine();
            drawMenu();
        }
        static void findPhoneNumber()
        {
            Console.Clear();

            Console.Write("Enter the name of phone number to be found : ");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} - {phoneDirectory[name]}");

            Console.ReadLine();
            drawMenu();
        }
        static void listAllDirectory()
        {
            Console.Clear();
            Console.WriteLine("\t All Phone Numbers");

            foreach(KeyValuePair<string, string> item in phoneDirectory)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
            drawMenu();
        }

        static void drawMenu()
        {
            Console.Clear();
            Console.WriteLine("\t MENU");

            Console.WriteLine("1 - Add Person");
            Console.WriteLine("2 - Delete Person");
            Console.WriteLine("3 - Find Phone Number");
            Console.WriteLine("4 - List All Directory");
            Console.WriteLine("5 - Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    addPerson();
                    break;
                case 2:
                    deletePerson();
                    break;
                case 3:
                    findPhoneNumber();
                    break;
                case 4:
                    listAllDirectory();
                    break;
                case 5:
                default:
                    Console.WriteLine("Exited.");
                    Console.ReadLine();
                    return;
            }
        }
        static void Main(string[] args)
        {
            drawMenu();
        }
    }
}

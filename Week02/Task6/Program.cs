using System;

namespace Task6
{
    public struct Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(int age)
        {
            Name = "John";
            Surname = "Doe";
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the valid name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the valid surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter an age: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(age);

            if(name == person.Name && surname == person.Surname)
            {
                if(age > 18)
                {
                    Console.WriteLine("Your age is appropriate");
                }
                else
                {
                    Console.WriteLine("Your age is not appropriate");
                }
            }
            else
            {
                Console.WriteLine("Name or Surname is not appropriate");
            }
        }
    }
}

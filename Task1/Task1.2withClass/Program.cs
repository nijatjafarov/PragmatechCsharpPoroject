using System;


class Person
{
    string name;
    string surname;
    byte age;
    string email;

    public Person()
    {
        Console.WriteLine("You didn't input any data");
    }

    public Person(string _name, string _surname, byte _age, string _email)
    {
        this.name = _name;
        this.surname = _surname;
        this.age = _age;
        this.email = _email;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello, {0} {1}", name, surname);
    }

    public void SayEmail()
    {
        Console.WriteLine("Your email address is {0}", email);
    }
    public void SayAge()
    {
        Console.WriteLine("Your age is {0}", age);
    }

    ~Person()
    {

    }
}


class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your surname: ");
        string surname = Console.ReadLine();

        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Person person = new Person(name, surname, age, email);


    }
}
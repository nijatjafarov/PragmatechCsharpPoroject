using System;

namespace Task1
{
    public struct User
    {
        public string Username;
        public int Password;

        public User(string username, int password)
        {
            Username = username;
            Password = password;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nijatjafarov", 123456);

            Console.Write("UserName daxil edin: ");
            string userName = Console.ReadLine();

            Console.Write("PassWord daxil edin: ");
            int passWord = int.Parse(Console.ReadLine());
            Console.Clear();

            if(userName == user.Username && passWord == user.Password)
            {
                Console.WriteLine("Sayta xosh gelmishsiniz! Hemise siz gelesiniz!");
            }
            else
            {
                Console.WriteLine("UserName ve ya PassWord yalnishdir");
            }
        }
    }
}

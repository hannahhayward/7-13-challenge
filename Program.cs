using System;
using System.Collections.Generic;

namespace _7_13_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, string> users = new Dictionary<string, string>();
            Console.WriteLine("enter your username");
            var name = Console.ReadLine();
            Console.WriteLine("your username is" + name);
            Console.WriteLine(" enter your password ");
            var password = Console.ReadLine();
            Console.WriteLine("your password is" + password) ;
            users.Add(name, password );
            foreach(KeyValuePair<string, string> user in users)
            {
                Console.WriteLine(name, password);
            }
        }
            }
}

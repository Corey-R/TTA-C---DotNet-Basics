using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Escape character "\" for quotes
            Console.WriteLine("Hello, \"" + name + "\"`!");        
            Console.Read();
        }
    }
}

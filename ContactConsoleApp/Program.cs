using System;
using System.Collections;


namespace ContactConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int EndOfProgram = 0;
            string Task;
            int LastPlace = 0;
            int MaxLastPlace = 15;
            Contact[] ContactList = new Contact[MaxLastPlace];

            while (EndOfProgram < 1)
            {
                Console.WriteLine("What do you want to do?");
                Task = Console.ReadLine();
                Logic.DoLogic(Task, ref LastPlace, ref ContactList);
            }
        }
    }
}

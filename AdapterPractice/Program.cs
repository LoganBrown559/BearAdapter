/*
 * 
 * Name: Logan Brown
 * File: Program.cs
 * Date: 2/12/2021
 * Description: Main Driver for program, goes through every step clearly.
 * 
 */
using System;

namespace AdapterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is going to tell the user what is happening at all times.
            //The program will have them hit enter between steps, so it is clear what's happening.

            Console.WriteLine("This project will create an instance of toy bear, a real bear,");
            Console.WriteLine("    and a Toy Bear using the Bear Adapter. Then we will show");
            Console.WriteLine("    off the functionality of everything.");
            Console.WriteLine("\nPlease press enter between each step to progress. This is so you");
            Console.WriteLine("    can see each step in progress. Ready? Press enter.");

            Console.ReadLine();

            Console.WriteLine("Creating Grizzly...");
            Grizzly RealBear = new Grizzly();
            Console.WriteLine("New Grizzly bear made! Press enter to continue...");

            Console.ReadLine();

            Console.WriteLine("Creating toy bear...");
            TeddyBear FakeBear = new TeddyBear();
            Console.WriteLine("Toy Bear has been made. Press enter to continue...");

            Console.ReadLine();

            Console.WriteLine("Using Adapter to make the Grizzly a toy bear...");
            BearAdapter NowABear = new BearAdapter(RealBear);
            Console.WriteLine("Adapter Bear made. Press enter...");

            Console.ReadLine();

            Console.WriteLine("Running both Grizzly Bear Funcitons...");
            Console.WriteLine("Maul:");
            Console.Write("\t");
            RealBear.Maul();
            Console.WriteLine("\nHibernate:");
            Console.Write("\t");
            RealBear.Hibernate();

            Console.WriteLine("\nTask complete. Press enter...");

            Console.ReadLine();

            Console.WriteLine("Running Teddy Bear \"Hug\" Fucniton...");
            Console.WriteLine("Hug:");
            Console.Write("\t");
            FakeBear.Hug();

            Console.WriteLine("Task Complete. Press enter...");

            Console.ReadLine();

            Console.WriteLine("Running Adapter Bear \"Hug\" Fucniton...");
            Console.WriteLine("Hug:");
            Console.Write("\t");
            NowABear.Hug();
        }
    }
}

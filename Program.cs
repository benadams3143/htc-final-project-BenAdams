using System;

namespace final_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");
            Console.WriteLine("Here are a few riddles to test your smarts...");

            Console.WriteLine("If a car key would open a car, and a house key opens a house, then what key opens a banana?");
            string input = Console.ReadLine();

            if (input == "monkey"){
                Console.WriteLine("Right! Onto the next riddle...");
            }

            else {
                Console.WriteLine("Nope! Try again...");
            }
            
            Q2();

        }

            public static void Q2()
            {
            Console.WriteLine("I stand when I'm sitting, and jump when I'm walking. Who am I?");
            string input2 =Console.ReadLine();

            if (input2 == "kangaroo"){
                Console.WriteLine("That is the answer! Another one...");
            }
            else{
                Console.WriteLine("Nope! Try again...");

                
            }
            Q3();
            
    }
    public static void Q3()
            {
            Console.WriteLine("The more you take, the more you leave behind. What am I?");
            string input3 =Console.ReadLine();

            if (input3 == "fingerprints"){
                Console.WriteLine("Let's go! another one down!");
            }
            else{
                Console.WriteLine("Nope! Try again...");
                }
                Q4();
}
public static void Q4()
            {
            Console.WriteLine("Give me food, and I will live. Give me water and I will die. What am I?");
            string input4 =Console.ReadLine();

            if (input4 == "fire"){
                Console.WriteLine("Yep that is the answer. No onto the final boss...");
            }
            else{
                Console.WriteLine("Nope! Try again...");
                }

                //butler, maid, gardener, murder riddle as #5
    }
}
}
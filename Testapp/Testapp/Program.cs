using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;
            
            while (true)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                
                {
                // Add minutes exercised to total 
                   

                try {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                        runningTotal += minutes;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not valid input.");
                        continue;
                  
                    }

                    // Display total minutes exercised to the screen 
                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
                }
                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");
        }
    }
}

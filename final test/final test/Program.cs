using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            var entry = 0;

            try
            {
                Console.Write("Enter the number of times to print \"Yay!\": ");
                var entryParsed = int.Parse(Console.ReadLine());

                if (entryParsed < 0)
                {
                    Console.Write("You must enter a positive number.");
                }
                else
                {
                    entry += entryParsed;
                }

            }
            catch (FormatException)
            {
                Console.Write("You must enter a whole number.");
            }

            var x = 0;

            while (true)
            {

                if (x < entry)
                {
                    Console.Write("Yay!");
                    x++;
                }
                else
                {
                    break;
                }


            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuApp
{

    class MenuMaker 
    {
        public Random Randomizer;

        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofurky" };
        string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "Rye", "White", "French", "Pumpernickle", "wheat", "a roll" };

        public string GetMenuItem()
        {

            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiments + " on " + randomBreads;
        }

    }
}


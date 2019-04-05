using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerApp
{
    class Farmer
    {
        public int MyProperty { get; set; }
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        public int BagsOfFeed { get; set; }
        public Farmer (int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set 
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }

}

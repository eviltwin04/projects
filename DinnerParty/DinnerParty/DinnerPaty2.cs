using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public class DinnerParty2
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal costOfDecorations = 0;

        public DinnerParty2(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
            private decimal calculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
            return costOfDecorations;
        }

        private decimal calculateCostOfBeveragesPerPerson()
            {
                decimal costOfBeveragesPerPerson;
                if (HealthyOption)
                {
                    costOfBeveragesPerPerson = 5.00M;
                }
                else
                {
                    costOfBeveragesPerPerson = 20.00M;
                }
                return costOfBeveragesPerPerson;
            }

                public decimal Cost
        {
            get
            {
                decimal totalCost = calculateCostOfDecorations();
                totalCost += ((calculateCostOfBeveragesPerPerson()
                                + CostOfFoodPerPerson) * NumberOfPeople);

                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;

            }
        }
    }
}

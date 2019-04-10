using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public class DinnerParty2 : Party
    {

        public bool HealthyOption { get; set; }
        

        public DinnerParty2(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
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

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
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

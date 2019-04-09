//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DinnerParty
//{
//    class DinnerParty

//    {
//        public const int CostOfFoodPerPerson = 25;

//        public int NumberOfPeople;
//        public decimal CostOfBeveragesPerPerson;
//        public decimal CostOfDecorations = 0;

//        public void SetHealthyOption(bool healthyOption)
//        {if (healthyOption)
//            {
//                CostOfBeveragesPerPerson = 5.00M;
//            }
//            else
//            {
//                CostOfBeveragesPerPerson = 20.00M;
//            }

//        }

//        public void SetPartyOptions (int people, bool fancy)
//        {
//            NumberOfPeople = people;
//            CalculateCostOfDecorations(fancy);
//        }

//        public int GetNumberOfPeople ()
//        {
//            return NumberOfPeople;
//        }

//        public void CalculateCostOfDecorations (bool fancy)
//        {
//            if (fancy)
//            {
//                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
//            }
//            else
//            {
//                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
//            }
//        }

//        public decimal CalculateCost(bool healthyOption)
//        {
//            decimal totalCost = CostOfDecorations + ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople);
//            if (healthyOption)
//                {
//                 return totalCost * 0.95M;
//                }
//            else
//            {
//                return totalCost;
//            }
//        }


//    }
//}

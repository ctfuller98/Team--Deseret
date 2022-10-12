using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tibbitts
{
    public class DeskQuote : Desk
    {
        public string fullName { get; set; }
        public Desk desk { get; set; }
        public string quoteDate { get; set; }
        public int rushDays { get; set; }
        public object RushCost { get; }
        public object TotalPrice { get; }

        //public int MaterialPrice { get; set; }


        public DeskQuote()
        {
            fullName = String.Empty;
            desk = new Desk();
            quoteDate = DateTime.Now.ToShortDateString();
            rushDays = 14;
            //MaterialPrice = (int)desk.material;
            //RushCost = getRushCost(rushDays);
            //TotalPrice = getTotal();
        }
        private DateTime TimeStamp = new DateTime();

        public DateTime timeStamp { get => TimeStamp; set => TimeStamp = value; }

        public int totalCost;

        public int linearFeet;

        public int drawerCost;

        public int rushCost;



        public int getLinearFeetCost(int width, int depth)
        {
            linearFeet = width * depth;

            return linearFeet;
        }

        public int getDrawerCost(int numDrawers)
        {
            return drawerCost += numDrawers * 50;
        }

        /*public int getMaterialCost(string materialType)
        {
            // Declare variables.
            int materialCost = 0;

            switch (materialType)
            {
                case 0:
                    materialCost += 100;
                    break;
                case 1:
                    materialCost += 200;
                    break;
                case 2:
                    materialCost += 300;
                    break;
                case 3:
                    materialCost += 125;
                    break;
                case 4:
                    materialCost += 50;
                    break;
                default:
                    materialCost += 0;
                    break;
            }
            
            return totalCost += materialCost;
        }*/
        

        public int getRushCost(int rushDays)
        {
            int linearFeet = getLinearFeetCost(desk.width, desk.depth);
            //int rushCost = 0;

            if (linearFeet < 1000)
            {
                if (rushDays == 7)
                    rushCost = 30;
                else if (rushDays == 5)
                    rushCost = 40;
                else if (rushDays == 3)
                    rushCost = 60;
            }
            else if (linearFeet > 999 && linearFeet < 2001)
            {
                if (rushDays == 7)
                    rushCost = 35;
                else if (rushDays == 5)
                    rushCost = 50;
                else if (rushDays == 3)
                    rushCost = 70;
            }
            else if (linearFeet > 2000)
            {
                if (rushDays == 7)
                    rushCost = 40;
                else if (rushDays == 5)
                    rushCost = 60;
                else if (rushDays == 3)
                    rushCost = 80;
            }
            else
            {
                rushCost = 0;
            }

            return rushCost;

        }

        public int getTotal()
        {
            totalCost += 200;
            totalCost += getLinearFeetCost(desk.width, desk.depth);
            totalCost += getDrawerCost(desk.numDrawers);
            //totalCost += getMaterialCost(desk.material);
            totalCost += (int)desk.material;
            totalCost += getRushCost(rushDays);

            return totalCost;
        }
    }
}

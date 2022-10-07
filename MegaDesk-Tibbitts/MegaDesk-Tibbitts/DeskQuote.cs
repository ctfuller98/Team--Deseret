using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tibbitts
{
    public class DeskQuote : Desk
    {

        private DateTime TimeStamp = new DateTime();

        public DateTime timeStamp { get => TimeStamp; set => TimeStamp = value; }

        public int totalCost;

        private int linearFeet;

        public int getLinearFeetCost(int width, int depth)
        {
            linearFeet = width * depth;

            return linearFeet;
        }

        public int getDrawerCost(int numDrawers)
        {
            return totalCost += numDrawers * 50;
        }

        public int getMaterialCost(int materialType)
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
                case 3:
                    materialCost += 300;
                    break;
                case 4:
                    materialCost += 125;
                    break;
                case 5:
                    materialCost += 50;
                    break;
                default:
                    materialCost += 0;
                    break;
            }
            
            return totalCost += materialCost;
        }

        public int getRushCost(int rush)
        {
            int linearFeet = getLinearFeetCost(width, depth);
            int rushCost = 0;


            if (linearFeet < 1000)
            {
                if (rush == 7)
                    rushCost = 30;
                else if (rush == 5)
                    rushCost = 40;
                else if (rush == 3)
                    rushCost = 60;
            }
            else if (linearFeet > 999 && linearFeet < 2001)
            {
                if (rush == 7)
                    rushCost = 35;
                else if (rush == 5)
                    rushCost = 50;
                else if (rush == 3)
                    rushCost = 70;
            }
            else if (linearFeet > 2000)
            {
                if (rush == 7)
                    rushCost = 40;
                else if (rush == 5)
                    rushCost = 60;
                else if (rush == 3)
                    rushCost = 80;
            }
            else
            {
                rushCost = 0;
            }

            return totalCost += rushCost;

        }

        public int getTotal()
        {
            totalCost += 200;
            totalCost += getLinearFeetCost(width, depth);
            totalCost += getDrawerCost(numDrawers);
            totalCost += getMaterialCost(materialType);
            totalCost += getRushCost(rush);

            return totalCost;
        }
    }
}

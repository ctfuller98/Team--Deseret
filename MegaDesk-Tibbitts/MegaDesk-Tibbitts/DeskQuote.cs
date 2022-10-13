using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tibbitts
{
    public class DeskQuote
    {

        // Declare variables
        public Desk Desk = new Desk();
        public string name { get; set; }
        public int rush { get; set; }

        public DateTime TimeStamp = DateTime.Today;
      
        private DateTime TimeStamp = new DateTime();

        public DateTime timeStamp { get => TimeStamp; set => TimeStamp = value; }
        public int totalCost;
        public int linearFeet;
        public int rushCost;
        public int materialCost;
        public int drawerCost;
        public static int quoteNum { get; set; }

        public DeskQuote()
        {
            quoteNum++;
        }

        // Declare methods
        public int getLinearFeetCost()
        {
            linearFeet = Desk.width * Desk.depth;

            return linearFeet;
        }

        public int getDrawerCost()
        {
            drawerCost = Desk.numDrawers * 50;

            return drawerCost;
        }

        public int getMaterialCost()
        {
            // Declare variables.
            materialCost = 0;

            switch (Desk.materialType)
            {
                case "laminate":
                    materialCost += 100;
                    break;
                case "oak":
                    materialCost += 200;
                    break;
                case "rosewood":
                    materialCost += 300;
                    break;
                case "veneer":
                    materialCost += 125;
                    break;
                case "pine":
                    materialCost += 50;
                    break;
                default:
                    materialCost += 0;
                    break;
            }
            
            return materialCost;
        }

        public int getRushCost(int rush)
        {

            if (linearFeet < 1000)
            {
                if (rush == 7)
                    rushCost = 30;
                else if (rush == 5)
                    rushCost = 40;
                else if (rush == 3)
                    rushCost = 60;
            }
            else if (linearFeet >= 1000 && linearFeet < 2000)
            {
                if (rush == 7)
                    rushCost = 35;
                else if (rush == 5)
                    rushCost = 50;
                else if (rush == 3)
                    rushCost = 70;
            }
            else if (linearFeet >= 2000)
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

            return rushCost;
        }

        public int getTotal(Desk Desk)
        {
            int baseCost = 200;
            linearFeet = getLinearFeetCost();
            drawerCost = getDrawerCost();
            materialCost = getMaterialCost();
            rushCost = getRushCost(rush);

            return totalCost = baseCost + linearFeet + drawerCost + materialCost + rushCost;
        }
    }
}

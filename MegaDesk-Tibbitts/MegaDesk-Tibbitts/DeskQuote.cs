using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json.Linq;

namespace MegaDesk_Tibbitts
{
    public class DeskQuote
    {
        // Declare variables
        public Desk Desk = new Desk();
        public string name { get; set; }
        public int rush { get; set; }

        public DateTime TimeStamp = DateTime.Today;
        public int totalCost;
        public int linearFeet;
        public int rushCost;
        public int materialCost;
        public int drawerCost;
        public int rows = 3;
        public int columns = 3;

        // Multi dimensional array variable.
        public int[,] RushArray;
        public static int quoteNum { get; set; }

        public DeskQuote()
        {
            quoteNum++;

        }

        // Declare methods
        public int getLinearFeetCost()
        {
            linearFeet = Desk.Width * Desk.Depth;

            return linearFeet;
        }

        public int getDrawerCost()
        {
            drawerCost = Desk.DrawerNumber * 50;

            return drawerCost;
        }

        public int getMaterialCost()
        {
            // Declare variables.
            materialCost = 0;

            switch (Desk.Material)
            {
                case "Laminate":
                    materialCost += 100;
                    break;
                case "Oak":
                    materialCost += 200;
                    break;
                case "Rosewood":
                    materialCost += 300;
                    break;
                case "Veneer":
                    materialCost += 125;
                    break;
                case "Pine":
                    materialCost += 50;
                    break;
                default:
                    materialCost += 0;
                    break;
            }

            return materialCost;
        }

        public void getRushOrder(out int[,] array, int rows, int columns)
        {
            // Read All Lines Method.
            string path =
                @"C:\Users\tomto\source\repos\Team--Deseret\MegaDesk-Tibbitts\MegaDesk-Tibbitts\Resources\rushOrderPrices.txt";
            //string[] readText = File.ReadAllLines("rushOrderPrices.txt");
            string[] readText = File.ReadAllLines(path);
            array = new int[rows, columns];
            int index = 0;

            // Create multi dimensional array.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int num = Int32.Parse(readText[index]);
                    array[i, j] = num;
                    index++;
                }
            }
        }


        public int getRushCost(int rush)
        {

            if (linearFeet < 1000)
            {
                if (rush == 7)
                    rushCost = RushArray[2, 0];
                else if (rush == 5)
                    rushCost = RushArray[1, 0];
                else if (rush == 3)
                    rushCost = RushArray[0, 0];
            }
            else if (linearFeet >= 1000 && linearFeet < 2000)
            {
                if (rush == 7)
                    rushCost = RushArray[2, 1];
                else if (rush == 5)
                    rushCost = RushArray[1, 1];
                else if (rush == 3)
                    rushCost = RushArray[0, 1];
            }
            else if (linearFeet >= 2000)
            {
                if (rush == 7)
                    rushCost = RushArray[2, 2];
                else if (rush == 5)
                    rushCost = RushArray[1, 2];
                else if (rush == 3)
                    rushCost = RushArray[0, 2];
            }
            else
            {
                rushCost = 0;
            }

            return rushCost;
        }

        public int getTotal(Desk Desk)
        {
            getRushOrder(out RushArray, rows, columns);
            int baseCost = 200;
            linearFeet = getLinearFeetCost();
            drawerCost = getDrawerCost();
            materialCost = getMaterialCost();
            rushCost = getRushCost(rush);

            return totalCost = baseCost + linearFeet + drawerCost + materialCost + rushCost;
        }
    }
}


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

        public int getLinearFeetCost(int width, int depth)
        {
            return totalCost += width * depth;
        }

        public int getDrawerCost(int numDrawers)
        {
            return totalCost += numDrawers * 50;
        }

        public int getTotal()
        {
            totalCost += 200;
            totalCost += getLinearFeetCost(width, depth);
            totalCost += getDrawerCost(numDrawers);
            totalCost += 300; //Hard coded rosewood option
            totalCost += 80; //Hard coded Rush option

            return totalCost;
        }
    }


}

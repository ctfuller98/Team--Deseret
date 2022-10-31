using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DeseretMegaDesk.Models
{
    public class DeskQuote
    {
        public const int BASE_PRICE = 200;
        public const int DRAWER_PRICE = 50;

        public int ID { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        public int DeskWidth { get; set; }

        public int DeskDepth { get; set; }

        public int DeskDrawers { get; set; }
        public int RushDays { get; set; }

        
        [DisplayName("Desktop Material")]
        [EnumDataType(typeof(DesktopMaterial))]
        public DesktopMaterial DesktopMaterial { get; set; }
        public DateTime QuoteDate { get; set; } = DateTime.Now;

        //logic
        public int SurfaceArea => DeskWidth * DeskDepth;
        public int AreaPrice => Math.Max(SurfaceArea - 1000, 0);
        public int DrawersPrice => DeskDrawers * DRAWER_PRICE;
        public int MaterialPrice => (int)DesktopMaterial;

        private int GetRushCost()
        {
            var rushCost = 0;
            if (SurfaceArea < 1000)
            {
                if (RushDays == 7)
                    rushCost = 30;
                else if (RushDays == 5)
                    rushCost = 40;
                else if (RushDays == 3)
                    rushCost = 60;
            }
            else if (SurfaceArea >= 1000 && SurfaceArea < 2000)
            {
                if (RushDays == 7)
                    rushCost = 35;
                else if (RushDays == 5)
                    rushCost = 50;
                else if (RushDays == 3)
                    rushCost = 70;
            }
            else if (SurfaceArea >= 2000)
            {
                if (RushDays == 7)
                    rushCost = 40;
                else if (RushDays == 5)
                    rushCost = 60;
                else if (RushDays == 3)
                    rushCost = 80;
            }
            else
            {
                rushCost = 0;
            }

            return rushCost;
        }

        public int TotalPrice => BASE_PRICE + AreaPrice + DrawersPrice + MaterialPrice + GetRushCost() ;


    }
}

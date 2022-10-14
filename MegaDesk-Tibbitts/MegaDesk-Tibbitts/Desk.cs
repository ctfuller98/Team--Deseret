using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tibbitts
{
    public class Desk
    {
        // Set constant values.
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;

        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;
        
        // Desk Material ENUM
        public enum DeskMaterial
        {
            Pine,
            Laminate,
            Veneer,
            Oak,
            Rosewood
        }

        private int _width;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= MAX_WIDTH && value >= MIN_WIDTH)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Invalid width value");
                }
            }
        }

        private int _depth;
        public int Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                if (value <= MAX_DEPTH && value >= MIN_DEPTH)
                {
                    _depth = value;
                }
                else
                {
                    throw new Exception("Invalid depth value.");
                }
            }
        }

        private int _drawerNumber;

        public int DrawerNumber
        {
            get
            {
                return _drawerNumber;
            }
            set
            {
                if (value <= MAX_DRAWERS && value >= MIN_DRAWERS)
                {
                    _drawerNumber = value;
                }
                else
                {
                    throw new Exception("Invalid Drawer Amount.");
                }
            }
        }

        public string Material { get; set; }

        // public constructor
        public Desk() { }
    }

    
}

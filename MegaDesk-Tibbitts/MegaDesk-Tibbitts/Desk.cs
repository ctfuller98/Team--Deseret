using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tibbitts
{
    public enum DeskMaterial
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300,
    }
    public class Desk
    {
        public const int MAXWIDTH = 96;
        public const int MINWIDTH = 24;
        public const int MAXDEPTH = 48;
        public const int MINDEPTH = 12;
        public const int MAXDRWERS = 7;
        public const int MINDRAWERS = 0;

        //default
        public Desk()
        {
            width = 0;
            depth = 0;
            numDrawers = 0;
            material = DeskMaterial.Pine;
        }
        public Desk(int width, int depth, int numDrawers, DeskMaterial material)
                {
                    this.width = width;
                    this.depth = depth;
                    this.numDrawers = numDrawers;
                    this.material = material;
                }
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public DeskMaterial material { get; set; }

        

        private int _width;

        public int Width
        {
            get { return _width; }
            set
            {
                if (value <= MAXWIDTH && value >= MINWIDTH)
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
            get { return _depth; }
            set
            {
                if (value <= MAXDEPTH && value >= MINDEPTH)
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
            get { return _drawerNumber; }
            set
            {
                if (value <= MAXDRWERS && value >= MINDRAWERS)
                {
                    _drawerNumber = value;
                }
                else
                {
                    throw new Exception("Invalid Drawer Amount.");
                }
            }
        }

        public int getSurfaceArea()
        {
            return Width * Depth;
        }
    }
}

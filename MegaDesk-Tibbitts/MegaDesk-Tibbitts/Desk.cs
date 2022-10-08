using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tibbitts
{
    public class Desk
    {
        public const int MAXWIDTH = 96;
        public const int MINWIDTH = 24;
        public const int MAXDEPTH = 48;
        public const int MINDEPTH = 12;
        public const int MAXDRWERS = 7;
        public const int MINDRAWERS = 0;


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

        public DeskMaterial Material { get; set; }

        public Desk(int width, int depth, int drawerNumber, DeskMaterial material)
        {
            this.Width = width;
            this.Depth = depth;
            this.DrawerNumber = drawerNumber;
            this.Material = material;
        }

        public int getSurfaceArea()
        {
            return Width * Depth;
        }
    }
}

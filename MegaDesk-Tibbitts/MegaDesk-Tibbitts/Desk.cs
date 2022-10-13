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

        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public string materialType { get; set; }
    }

    // Enumerated value.
    public enum DesktopMaterial {laminate, oak, rosewood, veneer, pine};
}

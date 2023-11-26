using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public struct Pixel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointF Pf { get; set; }
        public Color Color { get; set; }
    }
}

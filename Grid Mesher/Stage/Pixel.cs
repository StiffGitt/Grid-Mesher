using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Mesher.Stage
{
    public struct Pixel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public Vector3 P { get; set; }
        public Vector3 N { get; set; }
    }
}

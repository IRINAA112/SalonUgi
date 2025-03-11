using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonUgi
{
    public struct Linie
    {
        public Pen culoare;
        public List<Point> points;
        public Linie(Pen culoare)
        {
            points = new List<Point>();
            this.culoare = culoare;
        }
    }

}

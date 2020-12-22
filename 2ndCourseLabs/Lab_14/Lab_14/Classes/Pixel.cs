using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14.Classes
{
    class Pixel
    {
        Point point;
        bool seen;
        Color color;

        public Pixel(Point point, Color color) {
            this.point = point;
            seen = true;
            this.Color = color;
        }

        public Point Point { get => point; set => point = value; }
        public bool Seen { get => seen; set => seen = value; }
        public Color Color { get => color; set => color = value; }
    }
}

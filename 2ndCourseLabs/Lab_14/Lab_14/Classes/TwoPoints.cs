using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_14.Classes
{
    class TwoPoints
    {
        Point first;
        Point second;
        bool seen;
        Color color;

        public TwoPoints(Point first, Point second, Color color) {
            this.First = first;
            this.Second = second;
            Seen = true;
            this.Color = color;
        }

        public Point First { get => first; set => first = value; }
        public Point Second { get => second; set => second = value; }
        public bool Seen { get => seen; set => seen = value; }
        public Color Color { get => color; set => color = value; }
    }
}
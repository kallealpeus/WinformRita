using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformRita
{
    public class Triangle : Shape
    {
        public Point Center { get; set; }
        public int Side { get; set; }
        public int Perimeter { get { return Side*3; } }

        public override void Draw(Pen pen,Graphics g)
        {
            
            Point point1 = new Point(Center.X, Center.Y - (int)(Math.Sqrt(3) / 2 * Side / 2));
            Point point2 = new Point(Center.X - Side / 2, Center.Y + (int)(Math.Sqrt(3) / 2 * Side / 2));
            Point point3 = new Point(Center.X + Side / 2, Center.Y + (int)(Math.Sqrt(3) / 2 * Side / 2));
            Point[] points = {point1,point2,point3};

            g.DrawPolygon(pen, points);
        }
    }
}

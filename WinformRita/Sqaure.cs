using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformRita
{
    public class Sqaure : Shape
    {
        //public Color Color { get; set; }
        public Point Center { get; set; }
        public int Side { get; set; }
        public int Perimeter 
        {
            get { return Side * 4; }
        }
        public int Area
        {
            get { return Side * Side; }
        }

        public override void Draw(Pen pen, Graphics g)
        {
            g.DrawRectangle(
                pen,
                Center.X - Side/2, 
                Center.Y - Side/2,
                Side,
                Side
                );
        }
    }
}

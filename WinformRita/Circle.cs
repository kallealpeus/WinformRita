using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformRita
{
    public class Circle : Shape
    {
        public int Radie { get; set; }
        //public Color Color { get; set; }
        public Point Center { get; set; }
        public int Diameter
        {
            get 
            { 
                return Radie * 2; 
            }
        }
        public double Circumference 
        {
            get
            {
                return Radie * Math.PI * 2;
            }
        }
        public double Area
        {
            get
            {
                return Radie * Radie * Math.PI;
            }
        }

        public override void Draw(Pen pen, Graphics g)
        {
            g.DrawEllipse(
                pen,
                Center.X - Radie,
                Center.Y - Radie,
                Radie,
                Radie);
            
        }

    }
}

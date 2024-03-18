using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformRita
{
    public abstract class Shape
    {
        public virtual Color Color { get; set; }

        public abstract void Draw(Pen pen, Graphics g);
    }
}

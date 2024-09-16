using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshInheritancePolymorph.InheritanceDeep
{
    public class D2Square : Shape
    {
        public double side;

        public D2Square() : base(Color.RED, Color.WHITE)
        {
            side = 1;
        }

        public D2Square(int side, Color p, Color b) : base(p, b)
        {
            this.side = side;
        }

        public double Sqr()
        {
            return side * side;
        }


        public new void Show()
        {
            Console.WriteLine("Square: side = {0}, sqr = {1}", side, Sqr());
            // base.Show();
            //ShowColor();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshInheritancePolymorph.InheritanceDeep
{
    struct Coordinate
    {
        int x, y;
    }
    public class D2Circle : Shape
    {
        //center;
        public double radius;

        public D2Circle(Color p, Color b)
            : base(p, b)
        {
            
        }

        public double Sqr()
        {
            return 3.14 * radius * radius;
        }

        public void Show()
        {

            
            protectMethod();
            Console.WriteLine("Circle: radius = {0}, sqr = {1}", radius, Sqr());
            ShowColor();
        }


    }
}

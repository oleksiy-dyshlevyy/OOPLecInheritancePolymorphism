using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshInheritancePolymorph.Polymorphism
{
    interface IShape
    {
        void Draw();
    }
    interface ISquareable
    {
        int Square();
    }

    interface IPerimetrable
    {
        int Perimetr();
    }

    interface ILength
    {
        int Length();
    }
    public class MyShape: IShape
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }


        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    class Circle : MyShape, ISquareable/*, ILength*/
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
        public int Square()
        {
            return 0;
        }
    }
    class Rectangle : MyShape, IPerimetrable, ISquareable
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
        public int Square()
        {
            return 0;
        }
        public int Perimetr()
        {
            return 0;
        }
    }
    class Triangle : MyShape
    {
        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}

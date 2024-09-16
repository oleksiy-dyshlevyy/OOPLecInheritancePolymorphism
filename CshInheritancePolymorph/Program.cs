using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CshInheritancePolymorph.BasicInheritance;
using CshInheritancePolymorph.InheritanceDeep;
using CshInheritancePolymorph.Interfaces;
using CshInheritancePolymorph.Polymorphism;

namespace CshInheritancePolymorph
{
   
    class Program
    {
        public static void PolymorphismExampleMethod(/*IShape*/ MyShape myShape)
        {
          //  myShape = new CshInheritancePolymorph.Polymorphism.MyShape();
            //  MyShape myShape1 = new Rectangle();
            myShape.Draw();
        }

        static void Main(string[] args)
        {
            


            #region Lec 7 - Inheritance

            User user = new User();
            user.Name = "Kolia";
            
            Manager manager = new Manager();
            manager.Name = "Vania";
            manager.Company = "ABC";
           // manager.PrintName();

            Shape shape1 = new Shape(Color.GREY, Color.GREY);
            shape1.ShowColor();

            D2Circle circle1 = new D2Circle(Color.GREY, Color.GREY);
            circle1.radius = 45;
            circle1.pen = Color.GREY;
            circle1.brush = Color.GREEN;
            circle1.Show();
            circle1.ShowColor();
            circle1.Sqr();

            D3Squere d3 = new D3Squere();
            d3.pen = Color.BLACK;
            d3.side = 5;
            d3.Volume();
            d3.Show();

            // circle1.protectMethod(); //  error!!!! 

            D2Square d2Squere = new D2Square();
            d2Squere.Show();
            D2Square d2Squere2 = new D2Square(5, Color.BLUE, Color.BLUE);
            d2Squere.Show();
            D3Squere d3Squere = new D3Squere();
            d3Squere.Show();
            d3Squere.ShowColor();

            shape1 = circle1;
            shape1 = d3Squere;
           // circle1 = (D2Circle)shape1;
          //  circle1 = (D2Circle)d2Squere2;
            circle1 = shape1 as D2Circle;
            bool flag = shape1 is D2Circle;
            //circle1 = shape1 as D2Circle;

            // Type type = typeof (Shape);
            #endregion

            #region Lec 8 - Polymorphism
            // simple example
            A a = new A();
            //a.Method();

            a.f();
            B b = new B();
             b.f();
            a = b;

            a.f();
            C c = new C();

            // c = (C)a;
            //B b1 = new C();
            //b1.f();

            a = c;
            a.f();

            b = c;
            b.f();

            //C c1 = new D();
            //c1.f();
            D d = new D();
            d.f();
            a = d;
            a.f();

            b = d;
            b.f();

            c = d;
            c.f();

            MyShape myshape = new MyShape();
            myshape.Draw();

            Circle circle = new Circle();
            circle.Draw();

            myshape = circle;
            myshape.Draw();

            MyShape myShape1 = new Rectangle();
            myShape1.Draw();

            Triangle triangle = new Triangle();
            myshape = /*(MyShape)*/triangle as MyShape;
            triangle = myShape1 as Triangle;

            //myshape = /*(MyShape)*/triangle is MyShape;
            //  triangle = (Triangle)circle;

            // features of polymorphism

            Rectangle r = new Rectangle();
            
            MyShape[] shapeArray = new MyShape[3];
            shapeArray[0] = r;
            shapeArray[1] = triangle;
            shapeArray[2] = circle;

            //for (int i = 0; i < 3; i++)
            //    shapeArray[i].Draw();

            var shapes = new List<MyShape>
        {
            new Rectangle(),
            new Triangle(),
            new Circle()
        };


            //for (int i = 0; i < 3; i++)
            //{
            //    shapeArray[i].Draw();
            //}
            foreach (var shape in shapes)
            {
                // is
                //if (shape is Rectangle)
                //    Console.WriteLine("This is rectangle");

                //as
                MyShape myshape1 = shape as Rectangle;
                //if (myshape1 != null)
                //    Console.WriteLine("This is rectangle");

                shape.Draw();
            }


            PolymorphismExampleMethod(new Rectangle());

            // typeof

            //Type t = typeof(MyShape);
            //Console.WriteLine(t.FullName);
            //if (t.IsClass)
            //    Console.WriteLine("It's a class");
            //if (!t.IsAbstract)
            //    Console.WriteLine("It's not abstract");
            //System.Reflection.MemberInfo[] mas = t.GetMembers();

            //foreach (System.Reflection.MemberInfo element in mas)
            //    Console.WriteLine("--" + element.Name);

            //Console.ReadKey();
            #endregion

            #region Interfaces

            int bookPages = 365;
            IPrintedBook book = new Book(bookPages);

            IPrintedBook printed_book = (IPrintedBook)book;
            printed_book.Publish();
            
            IEBook e_book = (IEBook)book;
            e_book.Publish();


            #endregion
        }
    }
}

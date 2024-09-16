using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshInheritancePolymorph.Polymorphism
{
    
    class PolymorphClass
    {
       
    }

    public/* abstract*/ class A
    {
        //public A()
        //{ }

        //abstract public void Method();
        // { }
        virtual public void f()
        {
            Console.WriteLine("class A");
        }
    }
    public class B : A
    {
        //public B()
        //{ }
        //public override void Method()
        //{ }

        //   public int q;
        //new
        //virtual
        override public void f()
        {
            Console.WriteLine("class B");
        }
    }

    /*sealed*/ public class C : B
    {
      //  new
      //  sealed
 public /*virtual*/ override void f()
        {
            Console.WriteLine("class C");
        }
    }

    public class D : C
    {
        public /*virtual*/ override void f()
        {
          //  base.f();
            Console.WriteLine("class D");
           
        }
    }

}

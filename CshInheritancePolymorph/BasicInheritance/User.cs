using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshInheritancePolymorph.BasicInheritance
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User()
        {
            Id = 1;
            Name = "Vasia";
        }

        protected void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}

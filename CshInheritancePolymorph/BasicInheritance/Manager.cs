using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshInheritancePolymorph.BasicInheritance
{
    class Manager: User
    {
        public string Company { get; set; }

        public Manager()
        {
            Name = "Vania";
            Company = "SomeCompany";
            PrintName();
        }
    }
}

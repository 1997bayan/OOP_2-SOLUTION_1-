using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class TypeC : TypeA
    {
            // M = 10; // Invalid [Not Inherited]
            // X = 10; // Invalid -> X is Private Protected => Not Inherited
            //Y = 18 ;// Y is Protected => Is Inherited As Private
           // Z = 30; // Z is internal Protected => Is Inherited Private
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class TypeB : TypeA
    {
        public TypeB() 
        {
            X = 10; // X is protected private => Inherited As Private
            Y = 20; // Y is protected => Inherited As Private
            Z = 30; // Z is internal protected => Inherited As Internal
            // M = 40; // Invalid [Not Inherited]



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Inherticance
{
    internal class Child : Parent 
    {
        public int Z { get; set; }


        public Child(int _x , int _y ,int z) :base ( _x , _y)//the compiler do chain with child condtructor and parent parmeterless condtructor but there is no  parmeterless condtructor in parent class
                                             //So there is an error if we dont use condtructor chaining and we need use :base() 
        {
            X = _x;
            Y = _y;
            Z = z;
        }


        public new int Product() // THERE ARE TWO WAYS FOR OVERWITE : 
                                  // 1- new keyWord
                                  //2- override
        {
            return X*Y*Z; 
        }

        public override string ToString() // TO USE OVERRIDE : the first appear for the method should be public virtual 
        {
            return $"{X} , {Y} , {Z}";
        }
        

    }
}

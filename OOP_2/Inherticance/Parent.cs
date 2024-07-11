using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.Inherticance
{
    internal class Parent
    {
        #region Automatic property
        public int X { get; set; }
        public int Y { get; set; }

        #endregion

        #region Constructor
        //public Parent()
        //{
            
        //}
        public Parent(int _x , int _y) { 

            X = _x;
            Y = _y;
        }

        #region Methods

        public override string ToString()
        {
            return $"x : {X} , y :{Y}";
        }

        public virtual int product()
        {
            return X *  Y ;
        }

        #endregion


        #endregion

    }
}

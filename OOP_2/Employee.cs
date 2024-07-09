using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal struct Employee
    {
        private int Id;
        private string Name;
        public decimal salary;


        public Employee( int _id , string _name , decimal _salary )
        {
            Id = _id ;
            Name = _name ;
            salary = _salary ;

        }

        public void SetName (string value)
        {
            // Validation: If the length of the value is greater than 5, truncate it to the first 5 characters.
            Name = value.Length <=5  ? value : value.Substring(0,5) ;
            
        }

        public string GetName ()
        {
            return Name ;
        }


    }
}

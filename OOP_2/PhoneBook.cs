using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_2
{
    internal struct PhoneBook
    {


        #region Attributes
        string[] names;
        long[] numbers;
        int size;

        #endregion

        #region property 
        public int Size ///Read only property 
        {
            get { return size; }
        }

        //the array fixed linkes

        #endregion

        #region Constructors
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }

        #endregion

        #region Non-Static method
        public void AddPerson(int position, string name, long number)
        {
            if ((numbers is not null) && (names is not null))
            {
                if ((position >= 0) && (position < size))
                {

                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }
        #endregion

        #region GetNumber
        public long GetNumber(string name)
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                    }
                }
            }

            return -1;
        }
        #endregion

        #region SetNewNumber
        public void SetNewNumber(string existedName, long newNumber)
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (existedName == names[i])
                    {
                        numbers[i] = newNumber;
                        break; // for performance if it found the number , do not continue the loop 
                        // or we can use:
                        //return;
                    }
                }
            }


        }
        #endregion

        #region indexer

        public long this[string name]
        {
            get
            {
                if (names is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;

            }
            set
            {
                if (names is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = value;
                            break; // for performance if it found the number , do not continue the loop 
                                   // or we can use:
                                   //return;
                        }
                    }
                }


            }
        }


        #endregion
        #region indexer overloading

        public string this[int index]
        {
            get
            {

                return $"postion is {index} Name is {names[index]} Number is : {numbers[index]}";

            }



        }
        #endregion

    }
}

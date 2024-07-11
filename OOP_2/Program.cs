using common;
using OOP_2.Inherticance;
using System.Security.Cryptography;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion
            Employee emp = new Employee();

            emp.SetName("Bayan");

            //Console.WriteLine(emp.GetName());



            //Full time proprrty

            emp.Salary = 2000;
            //Console.WriteLine(emp.Salary);

            decimal ded = emp.dedaction;
           // Console.WriteLine(ded);
            #endregion

            #region PhoneBook With Struct

            PhoneBook c1 = new PhoneBook(3);
            c1.AddPerson(0, "Bayan", 123);
            c1.AddPerson(1, "OMar", 456);
            c1.AddPerson(2, "rayan", 789);

           // Console.WriteLine(c1.GetNumber("Bayan"));
            #endregion

            #region Indexer property
            c1["Bayan"] = 101001;
            Console.WriteLine(c1["Bayan"]);
            for (int i = 0; i < c1.Size; i++)
            {

                Console.WriteLine(c1[i]);

            }
            #endregion


            #region class
            Car car1;
            car1 = new Car(5, "BMW");

            #endregion

            #region  Inhertiacne

            Parent p1 = new Parent(1,2);
            Console.WriteLine("Parent"); 
            Console.WriteLine(p1.product());
            Console.WriteLine(p1.ToString());
            Console.WriteLine("Child");

            Child ch1 = new Child(4,55,66);
            Console.WriteLine(ch1.product());
            Console.WriteLine(ch1.ToString());

            //inhertance is a single inhertance ,in c# there is no multiple inhertance

            TypeB objB = new TypeB();
            // ObjB.X = 10; // Invalid [Private]
            // ObjB.Y = 20; // Invalid [Private]
            // ObjB.Z = 30; // Invalid [Internal]

            TypeC OBJC = new TypeC();
            //OBJC.X = 8; // Invalid X IS NOT inherted 
            //OBJC.Y = 8; // Invalid [Private]
            // OBJC.Z = 8; // Invalid [Private]

            #endregion


        }











    }
}

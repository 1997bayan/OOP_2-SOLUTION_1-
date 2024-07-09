namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();

            emp.SetName("Bayan");

            Console.WriteLine(emp.GetName());



            //Full time proprrty

            emp.Salary = 2000;
            Console.WriteLine(emp.Salary);
        }
    }
}

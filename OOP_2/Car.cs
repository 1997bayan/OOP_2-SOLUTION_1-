using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Car
    {
		#region Attributes
		private int id;
		private string? model;
		private double speed;

		#endregion



		#region Properties
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}

        #endregion


        #region Constructors

		//First constructors 
        public Car(int _id , string _model , double _speed)
        {
            id = _id;
			model = _model;
			speed = _speed;
			Console.WriteLine("CTOR1");
        }

        //Second constructors =>  Constructor chaining
        public Car(int _id, string _model) : this ( _id ,  _model ,170 )
        {
            //id = _id;
            //model = _model;
            //speed = 170; 
            Console.WriteLine("CTOR2");

        }

        public Car(int _id) :this (_id , "BMW")
		{
            Console.WriteLine("CTOR3");

            //model = "bmw";

        }




        #endregion


    }
}

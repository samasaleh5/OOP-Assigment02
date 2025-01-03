using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment02
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string model;
        private double speed;
        #endregion

        #region Constructor
        //struct Clr always generate parameterless constructor and intialize it with default values
        //class CLR generate parameterless constructor[empty]

        //when i made constructor compiler will no longer generate parameterless constructor
        public Car(int id,string model,double speed)
        {
            Console.WriteLine("Ctor 3");
            this.id = id;
            this.model = model;
            this.speed = speed; 
        }
        public Car(int id, string model):this (id,model,290)
        {
            Console.WriteLine("Ctor 2");
            //this.id = id;
            //this.model = model;
            //speed = 290;//default value
        }
        public Car(int id):this(id,"BMW")
        {
            Console.WriteLine("Ctor 1");
            //this.id = id;
        }
        #endregion

        #region Properties
        public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public  string Model
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

        #region Methods
        public override string ToString()
        {
            return $"Car Id : {id}\n Car Model : {model}\n Car Speed : {speed}";

        }
        #endregion

    }
}

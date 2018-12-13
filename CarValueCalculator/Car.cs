using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarValueCalculator
{
    class Car
    {
        //myCar.Make = "Oldsmobile";
        //    myCar.Model = "Cutlas Supreme";
        //    myCar.Year = 1986;
        //Member Variables / private to this class

        #region member Variables
            private string _carMake = string.Empty;
            private string _model = string.Empty;
            private int _year = 0;
            private decimal _carValue = 0M;
            private decimal _carFutureValue = 0M;
        #endregion

        #region Properties
            public string CarMake
            {
                get => _carMake;
                set => _carMake = value;
            }

            public string Model
            {
                get => _model;
                set => _model = value;
            }

            public int Year
            {
                get => _year;
                set => _year = value;
            }

            public decimal CarValue { get => _carValue; set => _carValue = value; }
            public decimal CarFutureValue { get => _carFutureValue; set => _carFutureValue = value; }
        #endregion

        #region Methods
        public decimal DetermineCarValue(int myCarYear)
        {
            decimal carValue = 00.00M;
            if (myCarYear > 2000)
            {
                carValue = 5000.00M;
                return carValue;
            }
            else
            {
                carValue = 1000.00M;
                return carValue;
            }
        }

        public decimal DetermineFutureValue(Car myCarObject)
        {
            if (myCarObject.CarValue >= 5000 && myCarObject.CarMake == "Honda")
            {
                return 2000.00M;
            }
            else if(myCarObject.CarValue < 5000 && myCarObject.CarMake == "Honda")
            {
                return 1000.00M;
            }
            else
            {
                return 0.0M;
            }

        }

        

        //GetCarData
        public Car GetCarData(Car carObject)
        {
            Console.WriteLine("Enter the car make: ");
            carObject.CarMake = Console.ReadLine();

            Console.WriteLine("Enter the Car model: ");
            carObject.Model = Console.ReadLine();

            Console.WriteLine("Enter the car year: ");
            carObject.Year = int.Parse(Console.ReadLine());

            return carObject;
        }
        
        #endregion

        //The end user will access these values through public we call 
        //properties




    }
}

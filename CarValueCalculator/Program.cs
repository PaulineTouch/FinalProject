using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarValueCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCalculations = GetNumberOfCarCalculations();

            //Instantiate/Create an Instance of the Car Class
            Car myCar = new Car();
            myCar.GetCarData(myCar);
            myCar.CarValue = myCar.DetermineCarValue(myCar.Year);
            Console.WriteLine("The Value of your car is: {0}", myCar.CarValue);

            //instantiate/create object two to hold the data/methods of the second car instance
            Car myCar2 = new Car();
            myCar2.GetCarData(myCar2);
            myCar2.CarValue = myCar2.DetermineCarValue(myCar2.Year);
            Console.WriteLine("The Value of your car is: {0}", myCar2.CarValue);

            //Determine the future value of car object 1
            myCar.CarFutureValue = myCar.DetermineFutureValue(myCar);

            //Determine the future value of car object 2
            myCar2.CarFutureValue = myCar2.DetermineFutureValue(myCar2);
        }

        //how many car calculations
        public static int GetNumberOfCarCalculations()
        {
            Console.WriteLine("How many unique Car Calculations will you be performing today?");
            int numberOfCalculations = 0;
            return numberOfCalculations = int.Parse(Console.ReadLine());
        }
    }
}

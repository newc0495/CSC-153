using System;

namespace ClassLibrary
{
    public class Car
    {
        // Fields
        private int _year;
        private string _make;
        private int _speed;

        //Properties
        public int Year { get => _year; set => _year = value; }
        public string Make { get => _make; set => _make = value; }
        public int Speed { get => _speed; set => _speed = value; }

        // Constructor
        public Car()
        {
            Make = "";
            Year = 1900;
            Speed = 0;
        }
        public Car(int year, string make)
        {
            Make = make;
            Year = year;
            Speed = 0;
        }

        // Methods
        public static string Accelerate(Car thisCar)
        {
            thisCar.Speed += 5;
            return $"The {thisCar.Year} {thisCar.Make} is now going {thisCar.Speed}mph.";
        }

        public static string Brake(Car thisCar)
        {
            if (thisCar.Speed == 0)
            {
                return $"The {thisCar.Year} {thisCar.Make} is already stopped.";
            }
            else
            {
                thisCar.Speed -= 5;
                return $"The {thisCar.Year} {thisCar.Make} is now going {thisCar.Speed}mph."; 
            }
        }
    }
}

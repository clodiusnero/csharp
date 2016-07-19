using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    abstract class Vehicle
    {
        public string TypeOfVehicale { get; set; }

        public Vehicle(string typeOfVehicale)
        {
            this.TypeOfVehicale = typeOfVehicale;
        }

        public virtual string DescribeVehicle()
        {
            return ("This is an: " + TypeOfVehicale);
        }
    }


    class Car : Vehicle
    {
        public bool engineIsRunning = false;
        public Car(string typOfVehicale) : base("Car")
        {
            this.TypeOfVehicale = TypeOfVehicale;
        }

        public void StartEngine(bool engineIsRunning)
        {
            engineIsRunning = true;
        }

        public void StopEngine(bool engineIsRunning)
        {
            engineIsRunning = false;
        }

        public override string DescribeVehicle()
        {
            return ("This is an: " + TypeOfVehicale + ", and the engine is running? " + engineIsRunning + ".");
        }
    }


    class Boat : Vehicle
    {
        public Boat(string typOfVehicale) : base("Boat")
        {
            this.TypeOfVehicale = TypeOfVehicale;
        }

        public override string DescribeVehicle()
        {
            return ("This is an: " + TypeOfVehicale);
        }
    }


    class VehicleData
    {
        public void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v.DescribeVehicle());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var vd = new VehicleData();
            var car = new Car("");
            var boat = new Boat("");

            Console.Write("Kristofers Vehicle<R>\n\nIn this program you can print vehicles.\n\n1: Car\n2: Boat\n\nWhat option would you like to print? ");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    vd.PrintVehicle(car);
                    break;
                case "2":
                    vd.PrintVehicle(boat);
                    break;
            }
            Console.Write("\nPress any key to exit . . . ");
            Console.ReadKey();
        }

    }
}
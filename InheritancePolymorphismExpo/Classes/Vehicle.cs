using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismExpo.Classes
{
    internal abstract class Vehicle
    {
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected int NumberOfWheels { get; set; }
        protected int NumberOfDoors { get; set; }
        protected int NumberOfSeats {  get; set; }
        protected string Color { get; set; }

        public Vehicle() { }

        public Vehicle(string brand, string model, int numberOfWheels, int numberOfDoors, int numberOfSeats, string color)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
            NumberOfDoors = numberOfDoors;
            NumberOfSeats = numberOfSeats;
            Color = color;
        }

        public abstract string drive();

        public virtual string getPrice()
        {
            return string.Format("C", 0);
        }
    }
}

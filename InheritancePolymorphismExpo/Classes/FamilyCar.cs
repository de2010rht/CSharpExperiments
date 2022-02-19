using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismExpo.Classes
{
    internal class FamilyCar : Vehicle
    {
        public string SteeringType { get; set; }
        public decimal Price {  get; set; }

        public FamilyCar() : base() { }

        public FamilyCar(string brand, string model, int numberOfWheels, int numberOfDoors, int numberOfSeats, 
            string color, string steeringType, decimal price) : base(brand, model, numberOfWheels, 
                numberOfDoors, numberOfSeats, color)
        {
            SteeringType = steeringType;
            Price = price;
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }

        public override string drive()
        {
            return "Driving " + ToString() + " on road";
        }

        public override string getPrice()
        {
            return string.Format("Price of {0} {1} - {2:c}", Brand, Model, Price);
        }
    }
}

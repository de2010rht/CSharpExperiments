using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritancePolymorphismExpo.Interfaces;

namespace InheritancePolymorphismExpo.Classes
{
    internal class Truck : Vehicle, ITruckDetails
    {
        public string ProducedAt { get; set; }
        public double LoadCapacity { get; set; }
        public bool IsNationalPermitCarrier { get; set; }

        public Truck() : base() { }

        public Truck(string brand, string model, int numberOfWheels, int numberOfDoors, int numberOfSeats, 
            string color, string producedAt, double loadCapacity, bool isNPCarrier) : base(brand, model, 
                numberOfWheels, numberOfDoors, numberOfSeats, color)
        {
            ProducedAt = producedAt;
            LoadCapacity = loadCapacity;
            IsNationalPermitCarrier = isNPCarrier;
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }

        public override string drive()
        {
            return "Driving " + ToString() + " on highway";
        }

        public override string getPrice()
        {
            return string.Format("Price of {0} {1} is more than {2:c}", Brand, Model, 2500000);
        }
    }
}

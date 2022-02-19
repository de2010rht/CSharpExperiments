using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismExpo.Interfaces
{
    internal interface ITruckDetails
    {
        double LoadCapacity { get; set; }

        bool IsNationalPermitCarrier { get; set; }
    }
}

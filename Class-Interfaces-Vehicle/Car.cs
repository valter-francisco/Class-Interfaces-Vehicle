using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Interfaces_Vehicle
{
    internal class Car : IVehicle
    {
        int gasoline { get; set; }

        public Car(int gasoline)
        {
            this.gasoline = gasoline;
        }

        public bool FuelLevel()
        {
            if (this.gasoline > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Drive()
        {
            Console.WriteLine("Driving!");
            this.gasoline = 0;
        }

        public bool Refuel(int gasoline)
        {
            if (gasoline > 0)
            {
                this.gasoline = this.gasoline + gasoline;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

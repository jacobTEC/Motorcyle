using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle Motorcycle1 = new Motorcycle("Honda", true);
            Motorcycle1.Start();
            Motorcycle1.SetRpm();
            Motorcycle1.GetRpm();
            Motorcycle1.ShiftGearsUp();
            Motorcycle1.ShiftGearsUp();
            Motorcycle1.ShiftGearsUp();
            Motorcycle1.ShiftGearsDown(2);
            Motorcycle1.GetGear();
            Motorcycle1.GetSpeed();

            Console.WriteLine(Motorcycle1.ToString());

            Console.ReadKey();
            Console.Clear();

            Scooter Scooter1 = new Scooter("PGO", true);
            Scooter1.Start();
            Scooter1.SetRpm();
            Scooter1.GetRpm();
            Scooter1.ShiftGearsUp();
            Scooter1.ShiftGearsUp();
            Scooter1.ShiftGearsUp();
            Scooter1.ShiftGearsDown(2);
            Scooter1.GetGear();
            Scooter1.GetSpeed();

            Console.WriteLine(Scooter1.ToString());

            Console.ReadKey();
            Console.Clear();

            ElectricBike ElectricBike1 = new ElectricBike("Conway", true);
            ElectricBike1.Start();
            ElectricBike1.SetRpm();
            ElectricBike1.GetRpm();
            ElectricBike1.ShiftGearsUp();
            ElectricBike1.ShiftGearsUp();
            ElectricBike1.ShiftGearsUp();
            ElectricBike1.ShiftGearsDown(2);
            ElectricBike1.GetGear();
            ElectricBike1.GetSpeed();

            Console.WriteLine(ElectricBike1.ToString());

            Console.ReadKey();
            Console.Clear();
        }
    }
}

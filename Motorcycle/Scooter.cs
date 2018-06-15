using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    class Scooter : ICycle
    {
        private bool _Started;
        private int _Rpm;
        private int _Gear;
        private string _Name;
        private double _Speed;

        public Scooter()
        {
            _Started = false;
            _Rpm = 0;
            _Gear = 0;
            _Name = "";
        }

        public Scooter(string name, bool started)
        {
            if (started == true)
            {
                _Started = true;
                _Rpm = 500;
                _Gear = 0;
            }
            else
            {
                _Started = false;
                _Rpm = 0;
                _Gear = 0;
            }
            _Name = name;
        }

        public string name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void SetRpm()
        {
            if (_Started == false)
            {
                Console.WriteLine("Motoren er ikke startet");
            }
            else if (_Rpm <= 499)
            {
                Console.WriteLine("Motoren er ikke startet");
            }

            Console.WriteLine("Angiv rpm. (må ikke være under 500 eller over 4000)");
            _Rpm = int.Parse(Console.ReadLine());

            if (_Rpm >= 4001 || _Rpm <= 499)
            {
                Console.WriteLine("Rpm går over eller under grænsen");
                _Rpm = 500;
            }
        }

        public void GetRpm()
        {
            int rpm = _Rpm;
            Console.WriteLine("Nuværence rpm: " + rpm);
        }

        public void Isstarted()
        {
            bool isstarted = _Started;
            Console.WriteLine(isstarted);
        }

        public void Start()
        {
            if (_Started != true)
            {
                _Started = true;
                _Rpm = 500;
                _Gear = 0;
            }
            else if (_Started == true)
            {
                Console.WriteLine("Motoren er allerede startet");
            }
        }

        public void Stop()
        {
            if (_Started != false)
            {
                _Started = false;
                _Rpm = 0;
                _Gear = 0;
            }
            else if (_Started == false)
            {
                Console.WriteLine("Motoren er allerede stoppet");
            }
        }

        public void GetSpeed()
        {
            _Speed = _Rpm * _Gear / 200;

            Console.WriteLine("Din nuværende fart er: " + _Speed);
        }

        public void ShiftGearsUp()
        {
            if (_Started == false)
            {
                Console.WriteLine("Motoren er ikke startet");
            }
            else if (_Gear > 5)
            {
                Console.WriteLine("Du har nådet maksimum antal af gear");
            }
            else
            {
                _Gear = _Gear + 1;
            }

        }

        public void ShiftGearsDown(int g)
        {
            if (g > _Gear)
            {
                Console.WriteLine("Angivet gear nedsættelse er ikke aktuelt");
            }
            else if (g < 0)
            {
                Console.WriteLine("Angivet gear nedsættelse er ikke aktuelt");
            }
            else if (g == _Gear)
            {
                Console.WriteLine("Angivet gear nedsættelse er ikke aktuelt");
            }
            else
            {
                _Gear = g;
            }
        }

        public void GetGear()
        {
            Console.WriteLine("Dit nuværende gear er: " + _Gear);
        }

        public override string ToString()
        {
            return "Navn: " + _Name + "\nStarted: " + _Started + "\nRpm: " + _Rpm + "\nGear: " + _Gear + "\nHastighed: " + _Speed;
        }
    }
}
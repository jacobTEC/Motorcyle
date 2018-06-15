using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    interface ICycle
    {
        void SetRpm();
        void GetRpm();
        void Start();
        void Stop();
        void GetSpeed();
        void ShiftGearsUp();
        void ShiftGearsDown(int g);
        void GetGear();
        string ToString();
    }
}

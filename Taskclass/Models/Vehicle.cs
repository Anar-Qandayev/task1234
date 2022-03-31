using System;
using System.Collections.Generic;
using System.Text;

namespace Taskclass.Models
{
    abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public abstract void AvarageSpeed();
        public abstract void ShowInfo();

    }
}

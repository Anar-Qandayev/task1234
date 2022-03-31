using System;
using System.Collections.Generic;
using System.Text;

namespace Taskclass.Models
{
    class Car:Vehicle
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public Car(int DoorCount, int WinCode, double DriveTime, double DrivePath) 
        {
            this.DoorCount=DoorCount;
            this.WinCode=WinCode;
        }
        public override void AvarageSpeed()
        {
            Console.WriteLine(DrivePath/DriveTime); 
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"");
        }
    }
}

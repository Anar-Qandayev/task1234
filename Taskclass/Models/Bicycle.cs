using System;
using System.Collections.Generic;
using System.Text;

namespace Taskclass.Models
{
    class Bicycle:Vehicle
    {
        public string PedalKind { get; set; }
        public Bicycle(string PedalKind, double DriveTime, double DrivePath)
        {
            this.PedalKind=PedalKind;
        }

        public override void AvarageSpeed()
        {
            Console.WriteLine(DrivePath/DriveTime);
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}

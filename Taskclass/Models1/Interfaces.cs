using System;
using System.Collections.Generic;
using System.Text;

namespace Taskclass.Models1
{

    interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentOil { get; set; }
        public int FuelType { get; set; }
        public void LeftFuelAmount();
    }
    interface IWheel
    {
        public int WheelThickness { get; set; }
    }
    interface ITransmission
    {
        public int TransmissionKind { get; set; }
    }
}

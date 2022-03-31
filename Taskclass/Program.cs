using System;
using Taskclass.Models;

namespace Taskclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(5,12345,5.3,8.5);
            car1.AvarageSpeed();
            Bicycle bicycle1 = new Bicycle("rubber", 5.3,8.5);
            bicycle1.AvarageSpeed();

        }
    }
}

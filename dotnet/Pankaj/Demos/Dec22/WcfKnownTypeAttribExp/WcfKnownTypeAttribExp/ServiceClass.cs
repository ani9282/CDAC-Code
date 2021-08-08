using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfKnownTypeAttribExp
{
    public class VehicleService : IVehicleService
    {
        public Vehicle GetVehicle(int type)
        {
            switch (type)
            {
                case 0:
                    return new Car()
                    {
                        ID = 10,
                        Brand = "Volvo",
                        SteeringWheelPosition = "left"
                    };

                case 1:
                    return new Bike()
                    {
                        ID = 11,
                        Brand = "Scott",
                        HasFrontWheelBreak = true
                    };

                case 2:
                    return new KidsBike()
                     {
                         ID = 12,
                         Brand = "Kid Scott",
                         HasFrontWheelBreak = false,
                         HasSupportingWheels = true
                     };

                default:
                    return null;
            }
        }

        public int GetNumberOfWheels(Vehicle vehicle)
        {
            return vehicle.NoOfWheels;
        }
    }

}
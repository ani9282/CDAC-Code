
using System.Runtime.Serialization;
namespace WcfKnownTypeAttribExp
{
    ///  
    /// Base class, abstract  
    ///  
    [KnownType(typeof(Car))]
    [KnownType(typeof(Bike))]
    abstract public class Vehicle
    {
        public int ID { get; set; }

        abstract public int NoOfWheels { get; }

        public string Brand { get; set; }
    }

    ///  
    /// Car class, inherits from Vehicle  
    ///  
    public class Car : Vehicle
    {
        override public int NoOfWheels { get { return 4; } }

        public string SteeringWheelPosition { get; set; }
    }

    ///  
    /// Bike class, inherits from Vehicle  
    ///  
   // [KnownType(typeof(KidsBike))]
    public class Bike : Vehicle
    {
        override public int NoOfWheels { get { return 2; } }

        public bool HasFrontWheelBreak { get; set; }
    }

    ///  
    /// Kid's bike class, inherits from Bike  
    ///  
    public class KidsBike : Bike
    {
        public bool HasSupportingWheels { get; set; }
    }

}  


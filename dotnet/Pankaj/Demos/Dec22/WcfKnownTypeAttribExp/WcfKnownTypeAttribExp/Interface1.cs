using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WcfKnownTypeAttribExp
{
   [ServiceContract]  
  public interface IVehicleService  
   {  
       [OperationContract]  
       Vehicle GetVehicle(int type);  
 
       [OperationContract]  
       int GetNumberOfWheels(Vehicle vehicle);  
    }  

}

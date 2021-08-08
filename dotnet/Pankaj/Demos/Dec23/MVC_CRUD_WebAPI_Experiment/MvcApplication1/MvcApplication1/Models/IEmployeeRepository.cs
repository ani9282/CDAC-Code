using System.Collections.Generic;

namespace MvcApplication1.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        IEnumerable<Employee> Delete(int id);
    }
}
